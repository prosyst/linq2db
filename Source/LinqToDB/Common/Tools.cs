﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
namespace LinqToDB.Common
{
	using Data;
	using Linq;
	using Mapping;
	using Reflection;

	/// <summary>
	/// Various general-purpose helpers.
	/// </summary>
	public static class Tools
	{
		/// <summary>
		/// Checks that collection is not null and have at least one element.
		/// </summary>
		/// <param name="array">Collection to check.</param>
		/// <returns><c>true</c> if collection is null or contains no elements, <c>false</c> otherwise.</returns>
		public static bool IsNullOrEmpty([NotNullWhen(false)] this ICollection? array)
		{
			return array == null || array.Count == 0;
		}

		/// <summary>
		/// Returns path to original directory with provided assembly.
		/// </summary>
		/// <param name="assembly">Assembly.</param>
		/// <returns>Assembly directory path.</returns>
		internal static string GetPath(this Assembly assembly)
		{
			return Path.GetDirectoryName(assembly.GetFileName())
				?? throw new InvalidOperationException($"Cannot get path to {assembly.GetFileName()}");
		}

		/// <summary>
		/// Returns original path to assembly file.
		/// </summary>
		/// <param name="assembly">Assembly.</param>
		/// <returns>Assembly file path.</returns>
		internal static string GetFileName(this Assembly assembly)
		{
			return assembly.Location;
		}

		public static String SafeNullDump(this object obj)
		{
			return SafeNullDump(obj, false);
		}

		public static String SafeNullDump(this object obj, bool includeTypeName)
		{
			return new StringBuilder()
					.Append(obj == null ? "(null)" : obj.ToString())
					.Append(includeTypeName ? String.Format(" (type: {0})", (obj ?? new object()).GetType().FullName) : "")
					.ToString();
		}


		public static string ToDebugDisplay(string str)
		{
			static string RemoveDuplicates(string pattern, string input)
			{
				var toSearch = pattern + pattern;
				do
				{
					var s = input.Replace(toSearch, pattern);
					if (s == input)
						break;
					input = s;
				} while (true);

				return input;
			}

			str = RemoveDuplicates("\t",   str);
			str = RemoveDuplicates("\r\n", str);
			str = RemoveDuplicates("\n",   str);

			str = str.Replace("\t",   " ");
			str = str.Replace("\r\n", " ");
			str = str.Replace("\n",   " ");

			return str.Trim();
		}

		internal static HashSet<T> AddRange<T>(this HashSet<T> hashSet, IEnumerable<T> items)
		{
			foreach (var item in items)
				hashSet.Add(item);
			return hashSet;
		}

		public static IQueryable<T> CreateEmptyQuery<T>()
		{
			return Enumerable.Empty<T>().AsQueryable();
		}

		public static IQueryable CreateEmptyQuery(Type elementType)
		{
			var method = Methods.LinqToDB.Tools.CreateEmptyQuery.MakeGenericMethod(elementType);
			return (IQueryable)method.Invoke(null, Array<object>.Empty)!;
		}

		public static Assembly? TryLoadAssembly(string? assemblyName, string? providerFactory)
		{
			if (assemblyName != null)
			{
				try
				{
					// first try to get already loaded assembly as under .net framework
					// we can end up with multiple versions of assemblies in memory which
					// doesn't make sense and actually breaks T4 templates
					// https://github.com/linq2db/linq2db/issues/3218
					return AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(a => a.GetName().Name == assemblyName)
						?? Assembly.Load(assemblyName);
				}
				catch {}
			}

#if !NETSTANDARD2_0
			try
			{
				if (providerFactory != null)
					return DbProviderFactories.GetFactory(providerFactory).GetType().Assembly;
			}
			catch {}
#endif

			return null;
		}

		/// <summary>
		/// Clears all linq2db caches.
		/// </summary>
		public static void ClearAllCaches()
		{
			Query.ClearCaches();
			MappingSchema.ClearCache();
			DataConnection.ClearObjectReaderCache();
		}
	}
}
