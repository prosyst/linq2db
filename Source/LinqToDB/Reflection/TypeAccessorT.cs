﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace LinqToDB.Reflection
{
	using Extensions;
	using LinqToDB.Common;

	public class TypeAccessor<T> : TypeAccessor
	{
		static TypeAccessor()
		{
			// Create Instance.
			//
			var type = typeof(T);

			if (type.IsValueType)
			{
				_createInstance = () => default!;
			}
			else
			{
				var ctor = type.IsAbstract ? null : type.GetDefaultConstructorEx();

				if (ctor == null)
				{
					Expression<Func<T>> mi;

					if (type.IsAbstract) mi = () => ThrowAbstractException();
					else                     mi = () => ThrowException();

					var body = Expression.Call(null, ((MethodCallExpression)mi.Body).Method);

					_createInstance = Expression.Lambda<Func<T>>(body).CompileExpression();
				}
				else
				{
					_createInstance = Expression.Lambda<Func<T>>(Expression.New(ctor)).CompileExpression();
				}
			}

			_members.AddRange(type.GetPublicInstanceValueMembers());

			// Add explicit interface implementation properties support
			// Or maybe we should support all private fields/properties?
			//
			if (!type.IsInterface && !type.IsArray)
			{
				var interfaceMethods = type.GetInterfaces().SelectMany(ti => type.GetInterfaceMapEx(ti).TargetMethods)
					.ToList();

				if (interfaceMethods.Count > 0)
				{
					foreach (var pi in type.GetNonPublicPropertiesEx())
					{
						if (pi.GetIndexParameters().Length == 0)
						{
							var getMethod = pi.GetGetMethod(true);
							var setMethod = pi.GetSetMethod(true);

							if ((getMethod == null || interfaceMethods.Contains(getMethod)) &&
								(setMethod == null || interfaceMethods.Contains(setMethod)))
							{
								_members.Add(pi);
							}
						}
					}
				}
			}

			// ObjectFactory
			//
			var attr = type.GetAttribute<ObjectFactoryAttribute>();

			if (attr != null)
				_objectFactory = attr.ObjectFactory;
		}

		static T ThrowException()
		{
			throw new LinqToDBException($"The '{typeof(T).FullName}' type must have default or init constructor.");
		}

		static T ThrowAbstractException()
		{
			throw new LinqToDBException($"Cant create an instance of abstract class '{typeof(T).FullName}'.");
		}

		static readonly List<MemberInfo> _members = new();
		static readonly IObjectFactory?  _objectFactory;

		internal TypeAccessor()
		{
			// init members
			foreach (var member in _members)
				if (!member.GetMemberType().IsByRef)
					AddMember(new MemberAccessor(this, member, null));

			ObjectFactory = _objectFactory;
		}

		static readonly Func<T> _createInstance;
		public override object   CreateInstance()
		{
			return _createInstance()!;
		}

		public T Create()
		{
			return _createInstance();
		}

		public override Type Type => typeof(T);
	}
}
