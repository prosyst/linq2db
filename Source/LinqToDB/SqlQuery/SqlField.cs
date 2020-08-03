﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinqToDB.SqlQuery
{
	using Mapping;

	public class SqlField : ISqlExpression
	{
		public SqlField()
		{
			CanBeNull = true;
		}

		public SqlField(SqlField field)
		{
			SystemType       = field.SystemType;
			Alias            = field.Alias;
			Name             = field.Name;
			PhysicalName     = field.PhysicalName;
			CanBeNull        = field.CanBeNull;
			IsPrimaryKey     = field.IsPrimaryKey;
			PrimaryKeyOrder  = field.PrimaryKeyOrder;
			IsIdentity       = field.IsIdentity;
			IsInsertable     = field.IsInsertable;
			IsUpdatable      = field.IsUpdatable;
			DataType         = field.DataType;
			DbType           = field.DbType;
			Length           = field.Length;
			Precision        = field.Precision;
			Scale            = field.Scale;
			CreateFormat     = field.CreateFormat;
			CreateOrder      = field.CreateOrder;
			ColumnDescriptor = field.ColumnDescriptor;
			IsDynamic        = field.IsDynamic;
		}

		public SqlField(ColumnDescriptor column)
		{
			Type              = new DbDataType(column.MemberType, column.DataType, column.DbType, column.Length, column.Precision, column.Scale);
			Name              = column.MemberName;
			PhysicalName      = column.ColumnName;
			CanBeNull         = column.CanBeNull;
			IsPrimaryKey      = column.IsPrimaryKey;
			PrimaryKeyOrder   = column.PrimaryKeyOrder;
			IsIdentity        = column.IsIdentity;
			IsInsertable      = !column.SkipOnInsert;
			IsUpdatable       = !column.SkipOnUpdate;
			SkipOnEntityFetch = column.SkipOnEntityFetch;
			CreateFormat      = column.CreateFormat;
			CreateOrder       = column.Order;
			ColumnDescriptor  = column;
		}

		public DbDataType?       Type              { get; set; }
		public string?           Alias             { get; set; }
		public string            Name              { get; set; } = null!; // not always true, see ColumnDescriptor notes
		public bool              IsPrimaryKey      { get; set; }
		public int               PrimaryKeyOrder   { get; set; }
		public bool              IsIdentity        { get; set; }
		public bool              IsInsertable      { get; set; }
		public bool              IsUpdatable       { get; set; }
		public bool              IsDynamic         { get; set; }
		public bool              SkipOnEntityFetch { get; set; }
		public string?           CreateFormat      { get; set; }
		public int?              CreateOrder       { get; set; }

		public ISqlTableSource?  Table             { get; set; }
		public ColumnDescriptor  ColumnDescriptor  { get; set; } = null!; // TODO: not true, we probably should introduce something else for non-column fields

		Type ISqlExpression.SystemType => Type?.SystemType!; // !!!

		private string _physicalName;
		public  string  PhysicalName
		{
			get => _physicalName ?? Name;
			set => _physicalName = value;
		}

		#region Overrides

//#if OVERRIDETOSTRING

		public override string ToString()
		{
			return ((IQueryElement)this).ToString(new StringBuilder(), new Dictionary<IQueryElement,IQueryElement>()).ToString();
		}

//#endif

		#endregion

		#region ISqlExpression Members

		public bool CanBeNull { get; set; }

		public bool Equals(ISqlExpression other, Func<ISqlExpression,ISqlExpression,bool> comparer)
		{
			return this == other;
		}

		public int Precedence => SqlQuery.Precedence.Primary;

		#endregion

		#region ISqlExpressionWalkable Members

		ISqlExpression ISqlExpressionWalkable.Walk(WalkOptions options, Func<ISqlExpression,ISqlExpression> func)
		{
			return func(this);
		}

		#endregion

		#region IEquatable<ISqlExpression> Members

		bool IEquatable<ISqlExpression>.Equals(ISqlExpression other)
		{
			return this == other;
		}

		#endregion

		#region ICloneableElement Members

		public ICloneableElement Clone(Dictionary<ICloneableElement, ICloneableElement> objectTree, Predicate<ICloneableElement> doClone)
		{
			if (!doClone(this))
				return this;

			Table.Clone(objectTree, doClone);

			return objectTree[this];
		}

		#endregion

		#region IQueryElement Members

		public QueryElementType ElementType => QueryElementType.SqlField;

		StringBuilder IQueryElement.ToString(StringBuilder sb, Dictionary<IQueryElement,IQueryElement> dic)
		{
			if (Table != null)
				sb
					.Append('t')
					.Append(Table.SourceID)
					.Append('.');

			return sb.Append(Name);
		}

		#endregion
	}
}
