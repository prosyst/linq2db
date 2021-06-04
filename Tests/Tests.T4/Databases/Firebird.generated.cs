﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/linq2db/linq2db).
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------

#pragma warning disable 1591
#nullable enable

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

using LinqToDB;
using LinqToDB.Common;
using LinqToDB.Configuration;
using LinqToDB.Data;
using LinqToDB.Mapping;

namespace FirebirdDataContext
{
	public partial class TESTDB25DB : LinqToDB.Data.DataConnection
	{
		public ITable<AllType>           AllTypes            { get { return this.GetTable<AllType>(); } }
		public ITable<CamelCaseName>     CamelCaseNames      { get { return this.GetTable<CamelCaseName>(); } }
		public ITable<Child>             Children            { get { return this.GetTable<Child>(); } }
		public ITable<DataTypeTest>      DataTypeTests       { get { return this.GetTable<DataTypeTest>(); } }
		public ITable<Doctor>            Doctors             { get { return this.GetTable<Doctor>(); } }
		public ITable<Dual>              Duals               { get { return this.GetTable<Dual>(); } }
		public ITable<GrandChild>        GrandChildren       { get { return this.GetTable<GrandChild>(); } }
		public ITable<InheritanceChild>  InheritanceChildren { get { return this.GetTable<InheritanceChild>(); } }
		public ITable<InheritanceParent> InheritanceParents  { get { return this.GetTable<InheritanceParent>(); } }
		public ITable<LinqDataType>      LinqDataTypes       { get { return this.GetTable<LinqDataType>(); } }
		public ITable<Parent>            Parents             { get { return this.GetTable<Parent>(); } }
		public ITable<Patient>           Patients            { get { return this.GetTable<Patient>(); } }
		public ITable<Person>            People              { get { return this.GetTable<Person>(); } }
		public ITable<PersonView>        PersonViews         { get { return this.GetTable<PersonView>(); } }
		public ITable<SequenceTest>      SequenceTests       { get { return this.GetTable<SequenceTest>(); } }
		public ITable<TestIdentity>      TestIdentities      { get { return this.GetTable<TestIdentity>(); } }
		public ITable<TestMerge1>        TestMerge1          { get { return this.GetTable<TestMerge1>(); } }
		public ITable<TestMerge2>        TestMerge2          { get { return this.GetTable<TestMerge2>(); } }

		public TESTDB25DB()
		{
			InitDataContext();
			InitMappingSchema();
		}

		public TESTDB25DB(string configuration)
			: base(configuration)
		{
			InitDataContext();
			InitMappingSchema();
		}

		public TESTDB25DB(LinqToDbConnectionOptions options)
			: base(options)
		{
			InitDataContext();
			InitMappingSchema();
		}

		partial void InitDataContext  ();
		partial void InitMappingSchema();
	}

	[Table("AllTypes")]
	public partial class AllType
	{
		[Column(                     DbType="integer",         DataType=LinqToDB.DataType.Int32),                           PrimaryKey,  NotNull] public int       ID                { get; set; } // integer
		[Column("bigintDataType",    DbType="bigint",          DataType=LinqToDB.DataType.Int64),                              Nullable         ] public long?     BigintDataType    { get; set; } // bigint
		[Column("smallintDataType",  DbType="smallint",        DataType=LinqToDB.DataType.Int16),                              Nullable         ] public short?    SmallintDataType  { get; set; } // smallint
		[Column("decimalDataType",   DbType="decimal(18,0)",   DataType=LinqToDB.DataType.Decimal,  Precision=18, Scale=0),    Nullable         ] public decimal?  DecimalDataType   { get; set; } // decimal(18,0)
		[Column("intDataType",       DbType="integer",         DataType=LinqToDB.DataType.Int32),                              Nullable         ] public int?      IntDataType       { get; set; } // integer
		[Column("floatDataType",     DbType="float",           DataType=LinqToDB.DataType.Single),                             Nullable         ] public float?    FloatDataType     { get; set; } // float
		[Column("realDataType",      DbType="float",           DataType=LinqToDB.DataType.Single),                             Nullable         ] public float?    RealDataType      { get; set; } // float
		[Column("timestampDataType", DbType="timestamp",       DataType=LinqToDB.DataType.DateTime),                           Nullable         ] public DateTime? TimestampDataType { get; set; } // timestamp
		[Column("charDataType",      DbType="char(1)",         DataType=LinqToDB.DataType.NChar,    Length=1),                 Nullable         ] public char?     CharDataType      { get; set; } // char(1)
		[Column("char20DataType",    DbType="char(20)",        DataType=LinqToDB.DataType.NChar,    Length=20),                Nullable         ] public string?   Char20DataType    { get; set; } // char(20)
		[Column("varcharDataType",   DbType="varchar(20)",     DataType=LinqToDB.DataType.NVarChar, Length=20),                Nullable         ] public string?   VarcharDataType   { get; set; } // varchar(20)
		[Column("textDataType",      DbType="blob sub_type 1", DataType=LinqToDB.DataType.Text),                               Nullable         ] public string?   TextDataType      { get; set; } // blob sub_type 1
		[Column("ncharDataType",     DbType="char(20)",        DataType=LinqToDB.DataType.NChar,    Length=20),                Nullable         ] public string?   NcharDataType     { get; set; } // char(20)
		[Column("nvarcharDataType",  DbType="varchar(20)",     DataType=LinqToDB.DataType.NVarChar, Length=20),                Nullable         ] public string?   NvarcharDataType  { get; set; } // varchar(20)
		[Column("blobDataType",      DbType="blob",            DataType=LinqToDB.DataType.Blob),                               Nullable         ] public byte[]?   BlobDataType      { get; set; } // blob
	}

	[Table("CamelCaseName")]
	public partial class CamelCaseName
	{
		[Column(          DbType="integer",     DataType=LinqToDB.DataType.Int32),               PrimaryKey,  NotNull] public int     Id    { get; set; } // integer
		[Column(          DbType="varchar(20)", DataType=LinqToDB.DataType.NVarChar, Length=20),    Nullable         ] public string? NAME1 { get; set; } // varchar(20)
		[Column(          DbType="varchar(20)", DataType=LinqToDB.DataType.NVarChar, Length=20),    Nullable         ] public string? Name2 { get; set; } // varchar(20)
		[Column(          DbType="varchar(20)", DataType=LinqToDB.DataType.NVarChar, Length=20),    Nullable         ] public string? NAME3 { get; set; } // varchar(20)
		[Column("_NAME4", DbType="varchar(20)", DataType=LinqToDB.DataType.NVarChar, Length=20),    Nullable         ] public string? NAME4 { get; set; } // varchar(20)
		[Column("NAME 5", DbType="varchar(20)", DataType=LinqToDB.DataType.NVarChar, Length=20),    Nullable         ] public string? NAME5 { get; set; } // varchar(20)
	}

	[Table("Child")]
	public partial class Child
	{
		[Column(DbType="integer", DataType=LinqToDB.DataType.Int32), Nullable] public int? ParentID { get; set; } // integer
		[Column(DbType="integer", DataType=LinqToDB.DataType.Int32), Nullable] public int? ChildID  { get; set; } // integer
	}

	[Table("DataTypeTest")]
	public partial class DataTypeTest
	{
		[Column(             DbType="integer",          DataType=LinqToDB.DataType.Int32),                           PrimaryKey,  NotNull] public int       DataTypeID { get; set; } // integer
		[Column("Binary_",   DbType="blob",             DataType=LinqToDB.DataType.Blob),                               Nullable         ] public byte[]?   Binary     { get; set; } // blob
		[Column("Boolean_",  DbType="char(1)",          DataType=LinqToDB.DataType.NChar,    Length=1),                 Nullable         ] public char?     Boolean    { get; set; } // char(1)
		[Column("Byte_",     DbType="smallint",         DataType=LinqToDB.DataType.Int16),                              Nullable         ] public short?    Byte       { get; set; } // smallint
		[Column("Bytes_",    DbType="blob",             DataType=LinqToDB.DataType.Blob),                               Nullable         ] public byte[]?   Bytes      { get; set; } // blob
		[Column("CHAR_",     DbType="char(1)",          DataType=LinqToDB.DataType.NChar,    Length=1),                 Nullable         ] public char?     Char       { get; set; } // char(1)
		[Column("DateTime_", DbType="timestamp",        DataType=LinqToDB.DataType.DateTime),                           Nullable         ] public DateTime? DateTime   { get; set; } // timestamp
		[Column("Decimal_",  DbType="decimal(10,2)",    DataType=LinqToDB.DataType.Decimal,  Precision=10, Scale=2),    Nullable         ] public decimal?  Decimal    { get; set; } // decimal(10,2)
		[Column("Double_",   DbType="double precision", DataType=LinqToDB.DataType.Double),                             Nullable         ] public double?   Double     { get; set; } // double precision
		[Column("Guid_",     DbType="char(38)",         DataType=LinqToDB.DataType.NChar,    Length=38),                Nullable         ] public string?   Guid       { get; set; } // char(38)
		[Column("Int16_",    DbType="smallint",         DataType=LinqToDB.DataType.Int16),                              Nullable         ] public short?    Int16      { get; set; } // smallint
		[Column("Int32_",    DbType="integer",          DataType=LinqToDB.DataType.Int32),                              Nullable         ] public int?      Int32      { get; set; } // integer
		[Column("Int64_",    DbType="numeric(11,0)",    DataType=LinqToDB.DataType.Decimal,  Precision=11, Scale=0),    Nullable         ] public decimal?  Int64      { get; set; } // numeric(11,0)
		[Column("Money_",    DbType="decimal(18,4)",    DataType=LinqToDB.DataType.Decimal,  Precision=18, Scale=4),    Nullable         ] public decimal?  Money      { get; set; } // decimal(18,4)
		[Column("SByte_",    DbType="smallint",         DataType=LinqToDB.DataType.Int16),                              Nullable         ] public short?    SByte      { get; set; } // smallint
		[Column("Single_",   DbType="float",            DataType=LinqToDB.DataType.Single),                             Nullable         ] public float?    Single     { get; set; } // float
		[Column("Stream_",   DbType="blob",             DataType=LinqToDB.DataType.Blob),                               Nullable         ] public byte[]?   Stream     { get; set; } // blob
		[Column("String_",   DbType="varchar(50)",      DataType=LinqToDB.DataType.NVarChar, Length=50),                Nullable         ] public string?   String     { get; set; } // varchar(50)
		[Column("UInt16_",   DbType="smallint",         DataType=LinqToDB.DataType.Int16),                              Nullable         ] public short?    UInt16     { get; set; } // smallint
		[Column("UInt32_",   DbType="integer",          DataType=LinqToDB.DataType.Int32),                              Nullable         ] public int?      UInt32     { get; set; } // integer
		[Column("UInt64_",   DbType="numeric(11,0)",    DataType=LinqToDB.DataType.Decimal,  Precision=11, Scale=0),    Nullable         ] public decimal?  UInt64     { get; set; } // numeric(11,0)
		[Column("Xml_",      DbType="char(1000)",       DataType=LinqToDB.DataType.NChar,    Length=1000),              Nullable         ] public string?   Xml        { get; set; } // char(1000)
	}

	[Table("Doctor")]
	public partial class Doctor
	{
		[Column(DbType="integer",     DataType=LinqToDB.DataType.Int32),               PrimaryKey, NotNull] public int    PersonID { get; set; } // integer
		[Column(DbType="varchar(50)", DataType=LinqToDB.DataType.NVarChar, Length=50),             NotNull] public string Taxonomy { get; set; } = null!; // varchar(50)

		#region Associations

		/// <summary>
		/// FK_Doctor_Person
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=false, Relationship=LinqToDB.Mapping.Relationship.OneToOne, KeyName="FK_Doctor_Person", BackReferenceName="Doctor")]
		public Person Person { get; set; } = null!;

		#endregion
	}

	[Table("Dual")]
	public partial class Dual
	{
		[Column(DbType="varchar(10)", DataType=LinqToDB.DataType.NVarChar, Length=10), Nullable] public string? Dummy { get; set; } // varchar(10)
	}

	[Table("GrandChild")]
	public partial class GrandChild
	{
		[Column(DbType="integer", DataType=LinqToDB.DataType.Int32), Nullable] public int? ParentID     { get; set; } // integer
		[Column(DbType="integer", DataType=LinqToDB.DataType.Int32), Nullable] public int? ChildID      { get; set; } // integer
		[Column(DbType="integer", DataType=LinqToDB.DataType.Int32), Nullable] public int? GrandChildID { get; set; } // integer
	}

	[Table("InheritanceChild")]
	public partial class InheritanceChild
	{
		[Column(DbType="integer",     DataType=LinqToDB.DataType.Int32),               PrimaryKey,  NotNull] public int     InheritanceChildId  { get; set; } // integer
		[Column(DbType="integer",     DataType=LinqToDB.DataType.Int32),                            NotNull] public int     InheritanceParentId { get; set; } // integer
		[Column(DbType="integer",     DataType=LinqToDB.DataType.Int32),                  Nullable         ] public int?    TypeDiscriminator   { get; set; } // integer
		[Column(DbType="varchar(50)", DataType=LinqToDB.DataType.NVarChar, Length=50),    Nullable         ] public string? Name                { get; set; } // varchar(50)
	}

	[Table("InheritanceParent")]
	public partial class InheritanceParent
	{
		[Column(DbType="integer",     DataType=LinqToDB.DataType.Int32),               PrimaryKey,  NotNull] public int     InheritanceParentId { get; set; } // integer
		[Column(DbType="integer",     DataType=LinqToDB.DataType.Int32),                  Nullable         ] public int?    TypeDiscriminator   { get; set; } // integer
		[Column(DbType="varchar(50)", DataType=LinqToDB.DataType.NVarChar, Length=50),    Nullable         ] public string? Name                { get; set; } // varchar(50)
	}

	[Table("LinqDataTypes")]
	public partial class LinqDataType
	{
		[Column(DbType="integer",       DataType=LinqToDB.DataType.Int32),                           Nullable] public int?      ID             { get; set; } // integer
		[Column(DbType="decimal(10,4)", DataType=LinqToDB.DataType.Decimal,  Precision=10, Scale=4), Nullable] public decimal?  MoneyValue     { get; set; } // decimal(10,4)
		[Column(DbType="timestamp",     DataType=LinqToDB.DataType.DateTime),                        Nullable] public DateTime? DateTimeValue  { get; set; } // timestamp
		[Column(DbType="timestamp",     DataType=LinqToDB.DataType.DateTime),                        Nullable] public DateTime? DateTimeValue2 { get; set; } // timestamp
		[Column(DbType="char(1)",       DataType=LinqToDB.DataType.NChar,    Length=1),              Nullable] public char?     BoolValue      { get; set; } // char(1)
		[Column(DbType="char(38)",      DataType=LinqToDB.DataType.NChar,    Length=38),             Nullable] public string?   GuidValue      { get; set; } // char(38)
		[Column(DbType="blob",          DataType=LinqToDB.DataType.Blob),                            Nullable] public byte[]?   BinaryValue    { get; set; } // blob
		[Column(DbType="smallint",      DataType=LinqToDB.DataType.Int16),                           Nullable] public short?    SmallIntValue  { get; set; } // smallint
		[Column(DbType="integer",       DataType=LinqToDB.DataType.Int32),                           Nullable] public int?      IntValue       { get; set; } // integer
		[Column(DbType="bigint",        DataType=LinqToDB.DataType.Int64),                           Nullable] public long?     BigIntValue    { get; set; } // bigint
		[Column(DbType="varchar(50)",   DataType=LinqToDB.DataType.NVarChar, Length=50),             Nullable] public string?   StringValue    { get; set; } // varchar(50)
	}

	[Table("Parent")]
	public partial class Parent
	{
		[Column(DbType="integer", DataType=LinqToDB.DataType.Int32), Nullable] public int? ParentID { get; set; } // integer
		[Column(DbType="integer", DataType=LinqToDB.DataType.Int32), Nullable] public int? Value1   { get; set; } // integer
	}

	[Table("Patient")]
	public partial class Patient
	{
		[Column(DbType="integer",      DataType=LinqToDB.DataType.Int32),                PrimaryKey, NotNull] public int    PersonID  { get; set; } // integer
		[Column(DbType="varchar(256)", DataType=LinqToDB.DataType.NVarChar, Length=256),             NotNull] public string Diagnosis { get; set; } = null!; // varchar(256)

		#region Associations

		/// <summary>
		/// INTEG_18
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=false, Relationship=LinqToDB.Mapping.Relationship.OneToOne, KeyName="INTEG_18", BackReferenceName="INTEG")]
		public Person Person { get; set; } = null!;

		#endregion
	}

	[Table("Person")]
	public partial class Person
	{
		[Column(DbType="integer",     DataType=LinqToDB.DataType.Int32),               PrimaryKey,  NotNull] public int     PersonID   { get; set; } // integer
		[Column(DbType="varchar(50)", DataType=LinqToDB.DataType.NVarChar, Length=50),              NotNull] public string  FirstName  { get; set; } = null!; // varchar(50)
		[Column(DbType="varchar(50)", DataType=LinqToDB.DataType.NVarChar, Length=50),              NotNull] public string  LastName   { get; set; } = null!; // varchar(50)
		[Column(DbType="varchar(50)", DataType=LinqToDB.DataType.NVarChar, Length=50),    Nullable         ] public string? MiddleName { get; set; } // varchar(50)
		[Column(DbType="char(1)",     DataType=LinqToDB.DataType.NChar,    Length=1),               NotNull] public char    Gender     { get; set; } // char(1)

		#region Associations

		/// <summary>
		/// FK_Doctor_Person_BackReference
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=true, Relationship=LinqToDB.Mapping.Relationship.OneToOne, IsBackReference=true)]
		public Doctor? Doctor { get; set; }

		/// <summary>
		/// INTEG_18_BackReference
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=true, Relationship=LinqToDB.Mapping.Relationship.OneToOne, IsBackReference=true)]
		public Patient? INTEG { get; set; }

		#endregion
	}

	[Table("PersonView", IsView=true)]
	public partial class PersonView
	{
		[Column(DbType="integer",     DataType=LinqToDB.DataType.Int32),               Nullable] public int?    PersonID   { get; set; } // integer
		[Column(DbType="varchar(50)", DataType=LinqToDB.DataType.NVarChar, Length=50), Nullable] public string? FirstName  { get; set; } // varchar(50)
		[Column(DbType="varchar(50)", DataType=LinqToDB.DataType.NVarChar, Length=50), Nullable] public string? LastName   { get; set; } // varchar(50)
		[Column(DbType="varchar(50)", DataType=LinqToDB.DataType.NVarChar, Length=50), Nullable] public string? MiddleName { get; set; } // varchar(50)
		[Column(DbType="char(1)",     DataType=LinqToDB.DataType.NChar,    Length=1),  Nullable] public char?   Gender     { get; set; } // char(1)
	}

	[Table("SequenceTest")]
	public partial class SequenceTest
	{
		[Column(          DbType="integer",     DataType=LinqToDB.DataType.Int32),               PrimaryKey, NotNull] public int    ID    { get; set; } // integer
		[Column("Value_", DbType="varchar(50)", DataType=LinqToDB.DataType.NVarChar, Length=50),             NotNull] public string Value { get; set; } = null!; // varchar(50)
	}

	[Table("TestIdentity")]
	public partial class TestIdentity
	{
		[Column(DbType="integer", DataType=LinqToDB.DataType.Int32), PrimaryKey, NotNull] public int ID { get; set; } // integer
	}

	[Table("TestMerge1")]
	public partial class TestMerge1
	{
		[Column(DbType="integer",          DataType=LinqToDB.DataType.Int32),                            PrimaryKey,  NotNull] public int       Id              { get; set; } // integer
		[Column(DbType="integer",          DataType=LinqToDB.DataType.Int32),                               Nullable         ] public int?      Field1          { get; set; } // integer
		[Column(DbType="integer",          DataType=LinqToDB.DataType.Int32),                               Nullable         ] public int?      Field2          { get; set; } // integer
		[Column(DbType="integer",          DataType=LinqToDB.DataType.Int32),                               Nullable         ] public int?      Field3          { get; set; } // integer
		[Column(DbType="integer",          DataType=LinqToDB.DataType.Int32),                               Nullable         ] public int?      Field4          { get; set; } // integer
		[Column(DbType="integer",          DataType=LinqToDB.DataType.Int32),                               Nullable         ] public int?      Field5          { get; set; } // integer
		[Column(DbType="bigint",           DataType=LinqToDB.DataType.Int64),                               Nullable         ] public long?     FieldInt64      { get; set; } // bigint
		[Column(DbType="char(1)",          DataType=LinqToDB.DataType.NChar,    Length=1),                  Nullable         ] public char?     FieldBoolean    { get; set; } // char(1)
		[Column(DbType="varchar(20)",      DataType=LinqToDB.DataType.NVarChar, Length=20),                 Nullable         ] public string?   FieldString     { get; set; } // varchar(20)
		[Column(DbType="varchar(20)",      DataType=LinqToDB.DataType.NVarChar, Length=20),                 Nullable         ] public string?   FieldNString    { get; set; } // varchar(20)
		[Column(DbType="char(1)",          DataType=LinqToDB.DataType.NChar,    Length=1),                  Nullable         ] public char?     FieldChar       { get; set; } // char(1)
		[Column(DbType="char(1)",          DataType=LinqToDB.DataType.NChar,    Length=1),                  Nullable         ] public char?     FieldNChar      { get; set; } // char(1)
		[Column(DbType="float",            DataType=LinqToDB.DataType.Single),                              Nullable         ] public float?    FieldFloat      { get; set; } // float
		[Column(DbType="double precision", DataType=LinqToDB.DataType.Double),                              Nullable         ] public double?   FieldDouble     { get; set; } // double precision
		[Column(DbType="timestamp",        DataType=LinqToDB.DataType.DateTime),                            Nullable         ] public DateTime? FieldDateTime   { get; set; } // timestamp
		[Column(DbType="blob",             DataType=LinqToDB.DataType.Blob),                                Nullable         ] public byte[]?   FieldBinary     { get; set; } // blob
		[Column(DbType="char(38)",         DataType=LinqToDB.DataType.NChar,    Length=38),                 Nullable         ] public string?   FieldGuid       { get; set; } // char(38)
		[Column(DbType="decimal(18,10)",   DataType=LinqToDB.DataType.Decimal,  Precision=18, Scale=10),    Nullable         ] public decimal?  FieldDecimal    { get; set; } // decimal(18,10)
		[Column(DbType="date",             DataType=LinqToDB.DataType.Date),                                Nullable         ] public DateTime? FieldDate       { get; set; } // date
		[Column(DbType="timestamp",        DataType=LinqToDB.DataType.DateTime),                            Nullable         ] public DateTime? FieldTime       { get; set; } // timestamp
		[Column(DbType="varchar(20)",      DataType=LinqToDB.DataType.NVarChar, Length=20),                 Nullable         ] public string?   FieldEnumString { get; set; } // varchar(20)
		[Column(DbType="integer",          DataType=LinqToDB.DataType.Int32),                               Nullable         ] public int?      FieldEnumNumber { get; set; } // integer
	}

	[Table("TestMerge2")]
	public partial class TestMerge2
	{
		[Column(DbType="integer",          DataType=LinqToDB.DataType.Int32),                            PrimaryKey,  NotNull] public int       Id              { get; set; } // integer
		[Column(DbType="integer",          DataType=LinqToDB.DataType.Int32),                               Nullable         ] public int?      Field1          { get; set; } // integer
		[Column(DbType="integer",          DataType=LinqToDB.DataType.Int32),                               Nullable         ] public int?      Field2          { get; set; } // integer
		[Column(DbType="integer",          DataType=LinqToDB.DataType.Int32),                               Nullable         ] public int?      Field3          { get; set; } // integer
		[Column(DbType="integer",          DataType=LinqToDB.DataType.Int32),                               Nullable         ] public int?      Field4          { get; set; } // integer
		[Column(DbType="integer",          DataType=LinqToDB.DataType.Int32),                               Nullable         ] public int?      Field5          { get; set; } // integer
		[Column(DbType="bigint",           DataType=LinqToDB.DataType.Int64),                               Nullable         ] public long?     FieldInt64      { get; set; } // bigint
		[Column(DbType="char(1)",          DataType=LinqToDB.DataType.NChar,    Length=1),                  Nullable         ] public char?     FieldBoolean    { get; set; } // char(1)
		[Column(DbType="varchar(20)",      DataType=LinqToDB.DataType.NVarChar, Length=20),                 Nullable         ] public string?   FieldString     { get; set; } // varchar(20)
		[Column(DbType="varchar(20)",      DataType=LinqToDB.DataType.NVarChar, Length=20),                 Nullable         ] public string?   FieldNString    { get; set; } // varchar(20)
		[Column(DbType="char(1)",          DataType=LinqToDB.DataType.NChar,    Length=1),                  Nullable         ] public char?     FieldChar       { get; set; } // char(1)
		[Column(DbType="char(1)",          DataType=LinqToDB.DataType.NChar,    Length=1),                  Nullable         ] public char?     FieldNChar      { get; set; } // char(1)
		[Column(DbType="float",            DataType=LinqToDB.DataType.Single),                              Nullable         ] public float?    FieldFloat      { get; set; } // float
		[Column(DbType="double precision", DataType=LinqToDB.DataType.Double),                              Nullable         ] public double?   FieldDouble     { get; set; } // double precision
		[Column(DbType="timestamp",        DataType=LinqToDB.DataType.DateTime),                            Nullable         ] public DateTime? FieldDateTime   { get; set; } // timestamp
		[Column(DbType="blob",             DataType=LinqToDB.DataType.Blob),                                Nullable         ] public byte[]?   FieldBinary     { get; set; } // blob
		[Column(DbType="char(38)",         DataType=LinqToDB.DataType.NChar,    Length=38),                 Nullable         ] public string?   FieldGuid       { get; set; } // char(38)
		[Column(DbType="decimal(18,10)",   DataType=LinqToDB.DataType.Decimal,  Precision=18, Scale=10),    Nullable         ] public decimal?  FieldDecimal    { get; set; } // decimal(18,10)
		[Column(DbType="date",             DataType=LinqToDB.DataType.Date),                                Nullable         ] public DateTime? FieldDate       { get; set; } // date
		[Column(DbType="timestamp",        DataType=LinqToDB.DataType.DateTime),                            Nullable         ] public DateTime? FieldTime       { get; set; } // timestamp
		[Column(DbType="varchar(20)",      DataType=LinqToDB.DataType.NVarChar, Length=20),                 Nullable         ] public string?   FieldEnumString { get; set; } // varchar(20)
		[Column(DbType="integer",          DataType=LinqToDB.DataType.Int32),                               Nullable         ] public int?      FieldEnumNumber { get; set; } // integer
	}

	public static partial class TESTDB25DBStoredProcedures
	{
		#region AddIssue792Record

		public static int AddIssue792Record(this TESTDB25DB dataConnection)
		{
			return dataConnection.ExecuteProc("\"AddIssue792Record\"");
		}

		#endregion

		#region OutRefEnumTest

		public static IEnumerable<OutRefEnumTestResult> OutRefEnumTest(this TESTDB25DB dataConnection, string? STR, string? IN_INPUTOUTPUTSTR)
		{
			return dataConnection.QueryProc<OutRefEnumTestResult>("\"OutRefEnumTest\"",
				new DataParameter("STR",               STR,               LinqToDB.DataType.NVarChar),
				new DataParameter("IN_INPUTOUTPUTSTR", IN_INPUTOUTPUTSTR, LinqToDB.DataType.NVarChar));
		}

		public partial class OutRefEnumTestResult
		{
			public string? INPUTOUTPUTSTR { get; set; }
			public string? OUTPUTSTR      { get; set; }
		}

		#endregion

		#region OutRefTest

		public static IEnumerable<OutRefTestResult> OutRefTest(this TESTDB25DB dataConnection, int? ID, int? IN_INPUTOUTPUTID, string? STR, string? IN_INPUTOUTPUTSTR)
		{
			return dataConnection.QueryProc<OutRefTestResult>("\"OutRefTest\"",
				new DataParameter("ID",                ID,                LinqToDB.DataType.Int32),
				new DataParameter("IN_INPUTOUTPUTID",  IN_INPUTOUTPUTID,  LinqToDB.DataType.Int32),
				new DataParameter("STR",               STR,               LinqToDB.DataType.NVarChar),
				new DataParameter("IN_INPUTOUTPUTSTR", IN_INPUTOUTPUTSTR, LinqToDB.DataType.NVarChar));
		}

		public partial class OutRefTestResult
		{
			public int?    INPUTOUTPUTID  { get; set; }
			public string? INPUTOUTPUTSTR { get; set; }
			public int?    OUTPUTID       { get; set; }
			public string? OUTPUTSTR      { get; set; }
		}

		#endregion

		#region PatientSelectAll

		public static IEnumerable<PatientSelectAllResult> PatientSelectAll(this TESTDB25DB dataConnection)
		{
			return dataConnection.QueryProc<PatientSelectAllResult>("\"Patient_SelectAll\"");
		}

		public partial class PatientSelectAllResult
		{
			public int?    PERSONID   { get; set; }
			public string? FIRSTNAME  { get; set; }
			public string? LASTNAME   { get; set; }
			public string? MIDDLENAME { get; set; }
			public string? GENDER     { get; set; }
			public string? DIAGNOSIS  { get; set; }
		}

		#endregion

		#region PatientSelectByName

		public static IEnumerable<PatientSelectByNameResult> PatientSelectByName(this TESTDB25DB dataConnection, string? FIRSTNAME, string? LASTNAME)
		{
			return dataConnection.QueryProc<PatientSelectByNameResult>("\"Patient_SelectByName\"",
				new DataParameter("FIRSTNAME", FIRSTNAME, LinqToDB.DataType.NVarChar),
				new DataParameter("LASTNAME",  LASTNAME,  LinqToDB.DataType.NVarChar));
		}

		public partial class PatientSelectByNameResult
		{
			public int?    PERSONID   { get; set; }
			public string? MIDDLENAME { get; set; }
			public string? GENDER     { get; set; }
			public string? DIAGNOSIS  { get; set; }
		}

		#endregion

		#region PersonDelete

		public static int PersonDelete(this TESTDB25DB dataConnection, int? PERSONID)
		{
			return dataConnection.ExecuteProc("\"Person_Delete\"",
				new DataParameter("PERSONID", PERSONID, LinqToDB.DataType.Int32));
		}

		#endregion

		#region PersonInsert

		public static IEnumerable<PersonInsertResult> PersonInsert(this TESTDB25DB dataConnection, string? FIRSTNAME, string? LASTNAME, string? MIDDLENAME, char? GENDER)
		{
			return dataConnection.QueryProc<PersonInsertResult>("\"Person_Insert\"",
				new DataParameter("FIRSTNAME",  FIRSTNAME,  LinqToDB.DataType.NVarChar),
				new DataParameter("LASTNAME",   LASTNAME,   LinqToDB.DataType.NVarChar),
				new DataParameter("MIDDLENAME", MIDDLENAME, LinqToDB.DataType.NVarChar),
				new DataParameter("GENDER",     GENDER,     LinqToDB.DataType.NChar));
		}

		public partial class PersonInsertResult
		{
			public int? PERSONID { get; set; }
		}

		#endregion

		#region PersonInsertOutputParameter

		public static IEnumerable<PersonInsertOutputParameterResult> PersonInsertOutputParameter(this TESTDB25DB dataConnection, string? FIRSTNAME, string? LASTNAME, string? MIDDLENAME, char? GENDER)
		{
			return dataConnection.QueryProc<PersonInsertOutputParameterResult>("\"Person_Insert_OutputParameter\"",
				new DataParameter("FIRSTNAME",  FIRSTNAME,  LinqToDB.DataType.NVarChar),
				new DataParameter("LASTNAME",   LASTNAME,   LinqToDB.DataType.NVarChar),
				new DataParameter("MIDDLENAME", MIDDLENAME, LinqToDB.DataType.NVarChar),
				new DataParameter("GENDER",     GENDER,     LinqToDB.DataType.NChar));
		}

		public partial class PersonInsertOutputParameterResult
		{
			public int? PERSONID { get; set; }
		}

		#endregion

		#region PersonSelectAll

		public static IEnumerable<PersonSelectAllResult> PersonSelectAll(this TESTDB25DB dataConnection)
		{
			return dataConnection.QueryProc<PersonSelectAllResult>("\"Person_SelectAll\"");
		}

		public partial class PersonSelectAllResult
		{
			public int?    PERSONID   { get; set; }
			public string? FIRSTNAME  { get; set; }
			public string? LASTNAME   { get; set; }
			public string? MIDDLENAME { get; set; }
			public string? GENDER     { get; set; }
		}

		#endregion

		#region PersonSelectByKey

		public static IEnumerable<PersonSelectByKeyResult> PersonSelectByKey(this TESTDB25DB dataConnection, int? ID)
		{
			return dataConnection.QueryProc<PersonSelectByKeyResult>("\"Person_SelectByKey\"",
				new DataParameter("ID", ID, LinqToDB.DataType.Int32));
		}

		public partial class PersonSelectByKeyResult
		{
			public int?    PERSONID   { get; set; }
			public string? FIRSTNAME  { get; set; }
			public string? LASTNAME   { get; set; }
			public string? MIDDLENAME { get; set; }
			public string? GENDER     { get; set; }
		}

		#endregion

		#region PersonSelectByName

		public static IEnumerable<PersonSelectByNameResult> PersonSelectByName(this TESTDB25DB dataConnection, string? IN_FIRSTNAME, string? IN_LASTNAME)
		{
			return dataConnection.QueryProc<PersonSelectByNameResult>("\"Person_SelectByName\"",
				new DataParameter("IN_FIRSTNAME", IN_FIRSTNAME, LinqToDB.DataType.NVarChar),
				new DataParameter("IN_LASTNAME",  IN_LASTNAME,  LinqToDB.DataType.NVarChar));
		}

		public partial class PersonSelectByNameResult
		{
			public int?    PERSONID   { get; set; }
			public string? FIRSTNAME  { get; set; }
			public string? LASTNAME   { get; set; }
			public string? MIDDLENAME { get; set; }
			public string? GENDER     { get; set; }
		}

		#endregion

		#region PersonUpdate

		public static int PersonUpdate(this TESTDB25DB dataConnection, int? PERSONID, string? FIRSTNAME, string? LASTNAME, string? MIDDLENAME, char? GENDER)
		{
			return dataConnection.ExecuteProc("\"Person_Update\"",
				new DataParameter("PERSONID",   PERSONID,   LinqToDB.DataType.Int32),
				new DataParameter("FIRSTNAME",  FIRSTNAME,  LinqToDB.DataType.NVarChar),
				new DataParameter("LASTNAME",   LASTNAME,   LinqToDB.DataType.NVarChar),
				new DataParameter("MIDDLENAME", MIDDLENAME, LinqToDB.DataType.NVarChar),
				new DataParameter("GENDER",     GENDER,     LinqToDB.DataType.NChar));
		}

		#endregion

		#region ScalarDataReader

		public static IEnumerable<ScalarDataReaderResult> ScalarDataReader(this TESTDB25DB dataConnection)
		{
			return dataConnection.QueryProc<ScalarDataReaderResult>("\"Scalar_DataReader\"");
		}

		public partial class ScalarDataReaderResult
		{
			public int?    INTFIELD    { get; set; }
			public string? STRINGFIELD { get; set; }
		}

		#endregion

		#region ScalarOutputParameter

		public static IEnumerable<ScalarOutputParameterResult> ScalarOutputParameter(this TESTDB25DB dataConnection)
		{
			return dataConnection.QueryProc<ScalarOutputParameterResult>("\"Scalar_OutputParameter\"");
		}

		public partial class ScalarOutputParameterResult
		{
			public int?    OUTPUTINT    { get; set; }
			public string? OUTPUTSTRING { get; set; }
		}

		#endregion

		#region ScalarReturnParameter

		public static IEnumerable<ScalarReturnParameterResult> ScalarReturnParameter(this TESTDB25DB dataConnection)
		{
			return dataConnection.QueryProc<ScalarReturnParameterResult>("\"Scalar_ReturnParameter\"");
		}

		public partial class ScalarReturnParameterResult
		{
			public int? RETURN_VALUE { get; set; }
		}

		#endregion
	}

	public static partial class TableExtensions
	{
		public static AllType? Find(this ITable<AllType> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static CamelCaseName? Find(this ITable<CamelCaseName> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static DataTypeTest? Find(this ITable<DataTypeTest> table, int DataTypeID)
		{
			return table.FirstOrDefault(t =>
				t.DataTypeID == DataTypeID);
		}

		public static Doctor? Find(this ITable<Doctor> table, int PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static InheritanceChild? Find(this ITable<InheritanceChild> table, int InheritanceChildId)
		{
			return table.FirstOrDefault(t =>
				t.InheritanceChildId == InheritanceChildId);
		}

		public static InheritanceParent? Find(this ITable<InheritanceParent> table, int InheritanceParentId)
		{
			return table.FirstOrDefault(t =>
				t.InheritanceParentId == InheritanceParentId);
		}

		public static Patient? Find(this ITable<Patient> table, int PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static Person? Find(this ITable<Person> table, int PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static SequenceTest? Find(this ITable<SequenceTest> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static TestIdentity? Find(this ITable<TestIdentity> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static TestMerge1? Find(this ITable<TestMerge1> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static TestMerge2? Find(this ITable<TestMerge2> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}
	}
}

#pragma warning restore 1591
