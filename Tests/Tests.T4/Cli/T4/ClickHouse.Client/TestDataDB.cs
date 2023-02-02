﻿// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB;
using LinqToDB.Configuration;
using LinqToDB.Data;
using LinqToDB.Mapping;
using System;
using System.Linq;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.T4.ClickHouse.Client
{
	public partial class TestDataDB : DataConnection
	{
		public TestDataDB()
		{
			InitDataContext();
		}

		public TestDataDB(string configuration)
			: base(configuration)
		{
			InitDataContext();
		}

		public TestDataDB(DataOptions options)
			: base(options)
		{
			InitDataContext();
		}

		partial void InitDataContext();

		public ITable<AllType>           AllTypes            => this.GetTable<AllType>();
		public ITable<Child>             Children            => this.GetTable<Child>();
		public ITable<CollatedTable>     CollatedTables      => this.GetTable<CollatedTable>();
		public ITable<Doctor>            Doctors             => this.GetTable<Doctor>();
		public ITable<GrandChild>        GrandChildren       => this.GetTable<GrandChild>();
		public ITable<InheritanceChild>  InheritanceChildren => this.GetTable<InheritanceChild>();
		public ITable<InheritanceParent> InheritanceParents  => this.GetTable<InheritanceParent>();
		public ITable<LinqDataType>      LinqDataTypes       => this.GetTable<LinqDataType>();
		public ITable<Parent>            Parents             => this.GetTable<Parent>();
		public ITable<Patient>           Patients            => this.GetTable<Patient>();
		public ITable<Person>            People              => this.GetTable<Person>();
		public ITable<TestMerge1>        TestMerge1          => this.GetTable<TestMerge1>();
		public ITable<TestMerge2>        TestMerge2          => this.GetTable<TestMerge2>();
	}

	[Table("AllTypes")]
	public partial class AllType
	{
		[Column("ID"              , IsPrimaryKey = true, SkipOnUpdate = true)] public int     ID               { get; set; } // Int32
		[Column("intDataType"                                               )] public int?    IntDataType      { get; set; } // Int32
		[Column("smallintDataType"                                          )] public short?  SmallintDataType { get; set; } // Int16
		[Column("floatDataType"                                             )] public float?  FloatDataType    { get; set; } // Float32
		[Column("doubleDataType"                                            )] public double? DoubleDataType   { get; set; } // Float64
		[Column("ncharDataType"                                             )] public byte[]? NcharDataType    { get; set; } // FixedString(20)
		[Column("char20DataType"                                            )] public byte[]? Char20DataType   { get; set; } // FixedString(20)
		[Column("varcharDataType"                                           )] public string? VarcharDataType  { get; set; } // String
		[Column("charDataType"                                              )] public byte[]? CharDataType     { get; set; } // FixedString(1)
	}

	public static partial class ExtensionMethods
	{
		#region Table Extensions
		public static AllType? Find(this ITable<AllType> table, int id)
		{
			return table.FirstOrDefault(e => e.ID == id);
		}

		public static CollatedTable? Find(this ITable<CollatedTable> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Doctor? Find(this ITable<Doctor> table, int personId)
		{
			return table.FirstOrDefault(e => e.PersonID == personId);
		}

		public static InheritanceChild? Find(this ITable<InheritanceChild> table, int inheritanceChildId)
		{
			return table.FirstOrDefault(e => e.InheritanceChildId == inheritanceChildId);
		}

		public static InheritanceParent? Find(this ITable<InheritanceParent> table, int inheritanceParentId)
		{
			return table.FirstOrDefault(e => e.InheritanceParentId == inheritanceParentId);
		}

		public static LinqDataType? Find(this ITable<LinqDataType> table, int id)
		{
			return table.FirstOrDefault(e => e.ID == id);
		}

		public static Patient? Find(this ITable<Patient> table, int personId)
		{
			return table.FirstOrDefault(e => e.PersonID == personId);
		}

		public static Person? Find(this ITable<Person> table, int personId)
		{
			return table.FirstOrDefault(e => e.PersonID == personId);
		}

		public static TestMerge1? Find(this ITable<TestMerge1> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static TestMerge2? Find(this ITable<TestMerge2> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}
		#endregion
	}

	[Table("Child")]
	public partial class Child
	{
		[Column("ParentID")] public int ParentID { get; set; } // Int32
		[Column("ChildID" )] public int ChildID  { get; set; } // Int32
	}

	[Table("CollatedTable")]
	public partial class CollatedTable
	{
		[Column("Id"             , IsPrimaryKey = true, SkipOnUpdate = true)] public int     Id              { get; set; } // Int32
		[Column("CaseSensitive"                                            )] public string? CaseSensitive   { get; set; } // String
		[Column("CaseInsensitive"                                          )] public string? CaseInsensitive { get; set; } // String
	}

	[Table("Doctor")]
	public partial class Doctor
	{
		[Column("PersonID", IsPrimaryKey = true , SkipOnUpdate = true)] public int    PersonID { get; set; } // Int32
		[Column("Taxonomy", CanBeNull    = false                     )] public string Taxonomy { get; set; } = null!; // String
	}

	[Table("GrandChild")]
	public partial class GrandChild
	{
		[Column("ParentID"    )] public int ParentID     { get; set; } // Int32
		[Column("ChildID"     )] public int ChildID      { get; set; } // Int32
		[Column("GrandChildID")] public int GrandChildID { get; set; } // Int32
	}

	[Table("InheritanceChild")]
	public partial class InheritanceChild
	{
		[Column("InheritanceChildId" , IsPrimaryKey = true, SkipOnUpdate = true)] public int     InheritanceChildId  { get; set; } // Int32
		[Column("InheritanceParentId"                                          )] public int     InheritanceParentId { get; set; } // Int32
		[Column("TypeDiscriminator"                                            )] public int?    TypeDiscriminator   { get; set; } // Int32
		[Column("Name"                                                         )] public string? Name                { get; set; } // String
	}

	[Table("InheritanceParent")]
	public partial class InheritanceParent
	{
		[Column("InheritanceParentId", IsPrimaryKey = true, SkipOnUpdate = true)] public int     InheritanceParentId { get; set; } // Int32
		[Column("TypeDiscriminator"                                            )] public int?    TypeDiscriminator   { get; set; } // Int32
		[Column("Name"                                                         )] public string? Name                { get; set; } // String
	}

	[Table("LinqDataTypes")]
	public partial class LinqDataType
	{
		[Column("ID"            , IsPrimaryKey = true, SkipOnUpdate = true)] public int             ID             { get; set; } // Int32
		[Column("MoneyValue"                                              )] public decimal?        MoneyValue     { get; set; } // Decimal(18, 4)
		[Column("DateTimeValue"                                           )] public DateTimeOffset? DateTimeValue  { get; set; } // DateTime64(3)
		[Column("DateTimeValue2"                                          )] public DateTimeOffset? DateTimeValue2 { get; set; } // DateTime64(7)
		[Column("BoolValue"                                               )] public bool?           BoolValue      { get; set; } // Bool
		[Column("GuidValue"                                               )] public Guid?           GuidValue      { get; set; } // UUID
		[Column("BinaryValue"                                             )] public string?         BinaryValue    { get; set; } // String
		[Column("SmallIntValue"                                           )] public short?          SmallIntValue  { get; set; } // Int16
		[Column("IntValue"                                                )] public int?            IntValue       { get; set; } // Int32
		[Column("BigIntValue"                                             )] public long?           BigIntValue    { get; set; } // Int64
		[Column("StringValue"                                             )] public string?         StringValue    { get; set; } // String
	}

	[Table("Parent")]
	public partial class Parent
	{
		[Column("ParentID")] public int  ParentID { get; set; } // Int32
		[Column("Value1"  )] public int? Value1   { get; set; } // Int32
	}

	[Table("Patient")]
	public partial class Patient
	{
		[Column("PersonID" , IsPrimaryKey = true , SkipOnUpdate = true)] public int    PersonID  { get; set; } // Int32
		[Column("Diagnosis", CanBeNull    = false                     )] public string Diagnosis { get; set; } = null!; // String
	}

	[Table("Person")]
	public partial class Person
	{
		[Column("PersonID"  , IsPrimaryKey = true , SkipOnUpdate = true)] public int     PersonID   { get; set; } // Int32
		[Column("FirstName" , CanBeNull    = false                     )] public string  FirstName  { get; set; } = null!; // String
		[Column("LastName"  , CanBeNull    = false                     )] public string  LastName   { get; set; } = null!; // String
		[Column("MiddleName"                                           )] public string? MiddleName { get; set; } // String
		[Column("Gender"    , CanBeNull    = false                     )] public byte[]  Gender     { get; set; } = null!; // FixedString(1)
	}

	[Table("TestMerge1")]
	public partial class TestMerge1
	{
		[Column("Id"             , IsPrimaryKey = true, SkipOnUpdate = true)] public int             Id              { get; set; } // Int32
		[Column("Field1"                                                   )] public int?            Field1          { get; set; } // Int32
		[Column("Field2"                                                   )] public int?            Field2          { get; set; } // Int32
		[Column("Field3"                                                   )] public int?            Field3          { get; set; } // Int32
		[Column("Field4"                                                   )] public int?            Field4          { get; set; } // Int32
		[Column("Field5"                                                   )] public int?            Field5          { get; set; } // Int32
		[Column("FieldInt64"                                               )] public long?           FieldInt64      { get; set; } // Int64
		[Column("FieldBoolean"                                             )] public bool?           FieldBoolean    { get; set; } // Bool
		[Column("FieldString"                                              )] public string?         FieldString     { get; set; } // String
		[Column("FieldNString"                                             )] public string?         FieldNString    { get; set; } // String
		[Column("FieldChar"                                                )] public byte[]?         FieldChar       { get; set; } // FixedString(1)
		[Column("FieldNChar"                                               )] public byte[]?         FieldNChar      { get; set; } // FixedString(2)
		[Column("FieldFloat"                                               )] public float?          FieldFloat      { get; set; } // Float32
		[Column("FieldDouble"                                              )] public double?         FieldDouble     { get; set; } // Float64
		[Column("FieldDateTime"                                            )] public DateTimeOffset? FieldDateTime   { get; set; } // DateTime64(3)
		[Column("FieldDateTime2"                                           )] public DateTimeOffset? FieldDateTime2  { get; set; } // DateTime64(7)
		[Column("FieldBinary"                                              )] public string?         FieldBinary     { get; set; } // String
		[Column("FieldGuid"                                                )] public Guid?           FieldGuid       { get; set; } // UUID
		[Column("FieldDecimal"                                             )] public decimal?        FieldDecimal    { get; set; } // Decimal(38, 10)
		[Column("FieldDate"                                                )] public DateTime?       FieldDate       { get; set; } // Date
		[Column("FieldTime"                                                )] public long?           FieldTime       { get; set; } // Int64
		[Column("FieldEnumString"                                          )] public string?         FieldEnumString { get; set; } // String
		[Column("FieldEnumNumber"                                          )] public int?            FieldEnumNumber { get; set; } // Int32
	}

	[Table("TestMerge2")]
	public partial class TestMerge2
	{
		[Column("Id"             , IsPrimaryKey = true, SkipOnUpdate = true)] public int             Id              { get; set; } // Int32
		[Column("Field1"                                                   )] public int?            Field1          { get; set; } // Int32
		[Column("Field2"                                                   )] public int?            Field2          { get; set; } // Int32
		[Column("Field3"                                                   )] public int?            Field3          { get; set; } // Int32
		[Column("Field4"                                                   )] public int?            Field4          { get; set; } // Int32
		[Column("Field5"                                                   )] public int?            Field5          { get; set; } // Int32
		[Column("FieldInt64"                                               )] public long?           FieldInt64      { get; set; } // Int64
		[Column("FieldBoolean"                                             )] public bool?           FieldBoolean    { get; set; } // Bool
		[Column("FieldString"                                              )] public string?         FieldString     { get; set; } // String
		[Column("FieldNString"                                             )] public string?         FieldNString    { get; set; } // String
		[Column("FieldChar"                                                )] public byte[]?         FieldChar       { get; set; } // FixedString(1)
		[Column("FieldNChar"                                               )] public byte[]?         FieldNChar      { get; set; } // FixedString(2)
		[Column("FieldFloat"                                               )] public float?          FieldFloat      { get; set; } // Float32
		[Column("FieldDouble"                                              )] public double?         FieldDouble     { get; set; } // Float64
		[Column("FieldDateTime"                                            )] public DateTimeOffset? FieldDateTime   { get; set; } // DateTime64(3)
		[Column("FieldDateTime2"                                           )] public DateTimeOffset? FieldDateTime2  { get; set; } // DateTime64(7)
		[Column("FieldBinary"                                              )] public string?         FieldBinary     { get; set; } // String
		[Column("FieldGuid"                                                )] public Guid?           FieldGuid       { get; set; } // UUID
		[Column("FieldDecimal"                                             )] public decimal?        FieldDecimal    { get; set; } // Decimal(38, 10)
		[Column("FieldDate"                                                )] public DateTime?       FieldDate       { get; set; } // Date
		[Column("FieldTime"                                                )] public long?           FieldTime       { get; set; } // Int64
		[Column("FieldEnumString"                                          )] public string?         FieldEnumString { get; set; } // String
		[Column("FieldEnumNumber"                                          )] public int?            FieldEnumNumber { get; set; } // Int32
	}
}
