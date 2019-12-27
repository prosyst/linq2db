﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/linq2db/linq2db).
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------

#pragma warning disable 1591

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

using LinqToDB;
using LinqToDB.Common;
using LinqToDB.Data;
using LinqToDB.Mapping;

namespace AccessDataContext
{
	public partial class TestDataDB : LinqToDB.Data.DataConnection
	{
		public ITable<AllType>             AllTypes             { get { return this.GetTable<AllType>(); } }
		public ITable<Child>               Children             { get { return this.GetTable<Child>(); } }
		public ITable<DataTypeTest>        DataTypeTests        { get { return this.GetTable<DataTypeTest>(); } }
		public ITable<Doctor>              Doctors              { get { return this.GetTable<Doctor>(); } }
		public ITable<Dual>                Duals                { get { return this.GetTable<Dual>(); } }
		public ITable<GrandChild>          GrandChildren        { get { return this.GetTable<GrandChild>(); } }
		public ITable<InheritanceChild>    InheritanceChildren  { get { return this.GetTable<InheritanceChild>(); } }
		public ITable<InheritanceParent>   InheritanceParents   { get { return this.GetTable<InheritanceParent>(); } }
		public ITable<LinqDataType>        LinqDataTypes        { get { return this.GetTable<LinqDataType>(); } }
		public ITable<LinqDataTypesQuery>  LinqDataTypesQueries { get { return this.GetTable<LinqDataTypesQuery>(); } }
		public ITable<LinqDataTypesQuery1> LinqDataTypesQuery1  { get { return this.GetTable<LinqDataTypesQuery1>(); } }
		public ITable<LinqDataTypesQuery2> LinqDataTypesQuery2  { get { return this.GetTable<LinqDataTypesQuery2>(); } }
		public ITable<Parent>              Parents              { get { return this.GetTable<Parent>(); } }
		public ITable<Patient>             Patients             { get { return this.GetTable<Patient>(); } }
		public ITable<PatientSelectAll>    PatientSelectAll     { get { return this.GetTable<PatientSelectAll>(); } }
		public ITable<Person>              People               { get { return this.GetTable<Person>(); } }
		public ITable<PersonSelectAll>     PersonSelectAll      { get { return this.GetTable<PersonSelectAll>(); } }
		public ITable<ScalarDataReader>    ScalarDataReaders    { get { return this.GetTable<ScalarDataReader>(); } }
		public ITable<TestIdentity>        TestIdentities       { get { return this.GetTable<TestIdentity>(); } }
		public ITable<TestMerge1>          TestMerge1           { get { return this.GetTable<TestMerge1>(); } }
		public ITable<TestMerge2>          TestMerge2           { get { return this.GetTable<TestMerge2>(); } }

		public TestDataDB()
		{
			InitDataContext();
			InitMappingSchema();
		}

		public TestDataDB(string configuration)
			: base(configuration)
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
		[Column(                            DbType="Long",       DataType=DataType.Int32,     Precision=10),          Identity   ] public int       ID                       { get; set; } // Long
		[Column("bitDataType",              DbType="Bit",        DataType=DataType.Boolean,   Length=2),              NotNull    ] public bool      BitDataType              { get; set; } // Bit
		[Column("smallintDataType",         DbType="Short",      DataType=DataType.Int16,     Precision=5),              Nullable] public short?    SmallintDataType         { get; set; } // Short
		[Column("decimalDataType",          DbType="Decimal",    DataType=DataType.Decimal,   Precision=18, Scale=0),    Nullable] public decimal?  DecimalDataType          { get; set; } // Decimal
		[Column("intDataType",              DbType="Long",       DataType=DataType.Int32,     Precision=10),             Nullable] public int?      IntDataType              { get; set; } // Long
		[Column("tinyintDataType",          DbType="Byte",       DataType=DataType.Byte,      Precision=3),              Nullable] public byte?     TinyintDataType          { get; set; } // Byte
		[Column("moneyDataType",            DbType="Currency",   DataType=DataType.Money,     Precision=19),             Nullable] public decimal?  MoneyDataType            { get; set; } // Currency
		[Column("floatDataType",            DbType="Double",     DataType=DataType.Double,    Precision=15),             Nullable] public double?   FloatDataType            { get; set; } // Double
		[Column("realDataType",             DbType="Single",     DataType=DataType.Single,    Precision=7),              Nullable] public float?    RealDataType             { get; set; } // Single
		[Column("datetimeDataType",         DbType="DateTime",   DataType=DataType.DateTime),                            Nullable] public DateTime? DatetimeDataType         { get; set; } // DateTime
		[Column("charDataType",             DbType="text(1)",    DataType=DataType.NText,     Length=1),                 Nullable] public char?     CharDataType             { get; set; } // text(1)
		[Column("char20DataType",           DbType="text(20)",   DataType=DataType.NText,     Length=20),                Nullable] public string    Char20DataType           { get; set; } // text(20)
		[Column("varcharDataType",          DbType="text(20)",   DataType=DataType.NText,     Length=20),                Nullable] public string    VarcharDataType          { get; set; } // text(20)
		[Column("textDataType",             DbType="text(0)",    DataType=DataType.NText,     Length=0),                 Nullable] public string    TextDataType             { get; set; } // text(0)
		[Column("ncharDataType",            DbType="text(20)",   DataType=DataType.NText,     Length=20),                Nullable] public string    NcharDataType            { get; set; } // text(20)
		[Column("nvarcharDataType",         DbType="text(20)",   DataType=DataType.NText,     Length=20),                Nullable] public string    NvarcharDataType         { get; set; } // text(20)
		[Column("ntextDataType",            DbType="text(0)",    DataType=DataType.NText,     Length=0),                 Nullable] public string    NtextDataType            { get; set; } // text(0)
		[Column("binaryDataType",           DbType="image(10)",  DataType=DataType.Undefined, Length=10),                Nullable] public byte[]    BinaryDataType           { get; set; } // image(10)
		[Column("varbinaryDataType",        DbType="image(510)", DataType=DataType.Undefined, Length=510),               Nullable] public byte[]    VarbinaryDataType        { get; set; } // image(510)
		[Column("imageDataType",            DbType="image(0)",   DataType=DataType.Undefined, Length=0),                 Nullable] public byte[]    ImageDataType            { get; set; } // image(0)
		[Column("oleObjectDataType",        DbType="image(0)",   DataType=DataType.Undefined, Length=0),                 Nullable] public byte[]    OleObjectDataType        { get; set; } // image(0)
		[Column("uniqueidentifierDataType", DbType="GUID",       DataType=DataType.Guid),                                Nullable] public Guid?     UniqueidentifierDataType { get; set; } // GUID
	}

	[Table("Child")]
	public partial class Child
	{
		[Column(DbType="Long", DataType=DataType.Int32, Precision=10), Nullable] public int? ParentID { get; set; } // Long
		[Column(DbType="Long", DataType=DataType.Int32, Precision=10), Nullable] public int? ChildID  { get; set; } // Long
	}

	[Table("DataTypeTest")]
	public partial class DataTypeTest
	{
		[Column(             DbType="Long",     DataType=DataType.Int32,     Precision=10), PrimaryKey, Identity] public int       DataTypeID { get; set; } // Long
		[Column("Binary_",   DbType="image(0)", DataType=DataType.Undefined, Length=0),     Nullable            ] public byte[]    Binary     { get; set; } // image(0)
		[Column("Boolean_",  DbType="Long",     DataType=DataType.Int32,     Precision=10), Nullable            ] public int?      Boolean    { get; set; } // Long
		[Column("Byte_",     DbType="Byte",     DataType=DataType.Byte,      Precision=3),  Nullable            ] public byte?     Byte       { get; set; } // Byte
		[Column("Bytes_",    DbType="image(0)", DataType=DataType.Undefined, Length=0),     Nullable            ] public byte[]    Bytes      { get; set; } // image(0)
		[Column("Char_",     DbType="text(1)",  DataType=DataType.NText,     Length=1),     Nullable            ] public char?     Char       { get; set; } // text(1)
		[Column("DateTime_", DbType="DateTime", DataType=DataType.DateTime),                Nullable            ] public DateTime? DateTime   { get; set; } // DateTime
		[Column("Decimal_",  DbType="Currency", DataType=DataType.Money,     Precision=19), Nullable            ] public decimal?  Decimal    { get; set; } // Currency
		[Column("Double_",   DbType="Double",   DataType=DataType.Double,    Precision=15), Nullable            ] public double?   Double     { get; set; } // Double
		[Column("Guid_",     DbType="GUID",     DataType=DataType.Guid),                    Nullable            ] public Guid?     Guid       { get; set; } // GUID
		[Column("Int16_",    DbType="Short",    DataType=DataType.Int16,     Precision=5),  Nullable            ] public short?    Int16      { get; set; } // Short
		[Column("Int32_",    DbType="Long",     DataType=DataType.Int32,     Precision=10), Nullable            ] public int?      Int32      { get; set; } // Long
		[Column("Int64_",    DbType="Long",     DataType=DataType.Int32,     Precision=10), Nullable            ] public int?      Int64      { get; set; } // Long
		[Column("Money_",    DbType="Currency", DataType=DataType.Money,     Precision=19), Nullable            ] public decimal?  Money      { get; set; } // Currency
		[Column("SByte_",    DbType="Byte",     DataType=DataType.Byte,      Precision=3),  Nullable            ] public byte?     SByte      { get; set; } // Byte
		[Column("Single_",   DbType="Single",   DataType=DataType.Single,    Precision=7),  Nullable            ] public float?    Single     { get; set; } // Single
		[Column("Stream_",   DbType="image(0)", DataType=DataType.Undefined, Length=0),     Nullable            ] public byte[]    Stream     { get; set; } // image(0)
		[Column("String_",   DbType="text(50)", DataType=DataType.NText,     Length=50),    Nullable            ] public string    String     { get; set; } // text(50)
		[Column("UInt16_",   DbType="Short",    DataType=DataType.Int16,     Precision=5),  Nullable            ] public short?    UInt16     { get; set; } // Short
		[Column("UInt32_",   DbType="Long",     DataType=DataType.Int32,     Precision=10), Nullable            ] public int?      UInt32     { get; set; } // Long
		[Column("UInt64_",   DbType="Long",     DataType=DataType.Int32,     Precision=10), Nullable            ] public int?      UInt64     { get; set; } // Long
		[Column("Xml_",      DbType="text(0)",  DataType=DataType.NText,     Length=0),     Nullable            ] public string    Xml        { get; set; } // text(0)
	}

	[Table("Doctor")]
	public partial class Doctor
	{
		[Column(DbType="Long",     DataType=DataType.Int32, Precision=10), PrimaryKey, Identity] public int    PersonID { get; set; } // Long
		[Column(DbType="text(50)", DataType=DataType.NText, Length=50),    NotNull             ] public string Taxonomy { get; set; } // text(50)

		#region Associations

		/// <summary>
		/// PersonDoctor
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=false, Relationship=Relationship.OneToOne, KeyName="PersonDoctor", BackReferenceName="PersonDoctor")]
		public Person Person { get; set; }

		#endregion
	}

	[Table("Dual")]
	public partial class Dual
	{
		[Column(DbType="text(10)", DataType=DataType.NText, Length=10), Nullable] public string Dummy { get; set; } // text(10)
	}

	[Table("GrandChild")]
	public partial class GrandChild
	{
		[Column(DbType="Long", DataType=DataType.Int32, Precision=10), Nullable] public int? ParentID     { get; set; } // Long
		[Column(DbType="Long", DataType=DataType.Int32, Precision=10), Nullable] public int? ChildID      { get; set; } // Long
		[Column(DbType="Long", DataType=DataType.Int32, Precision=10), Nullable] public int? GrandChildID { get; set; } // Long
	}

	[Table("InheritanceChild")]
	public partial class InheritanceChild
	{
		[Column(DbType="Long",     DataType=DataType.Int32, Precision=10), PrimaryKey, Identity] public int    InheritanceChildId  { get; set; } // Long
		[Column(DbType="Long",     DataType=DataType.Int32, Precision=10),             Identity] public int    InheritanceParentId { get; set; } // Long
		[Column(DbType="Long",     DataType=DataType.Int32, Precision=10), Nullable            ] public int?   TypeDiscriminator   { get; set; } // Long
		[Column(DbType="text(50)", DataType=DataType.NText, Length=50),    Nullable            ] public string Name                { get; set; } // text(50)
	}

	[Table("InheritanceParent")]
	public partial class InheritanceParent
	{
		[Column(DbType="Long",     DataType=DataType.Int32, Precision=10), PrimaryKey, Identity] public int    InheritanceParentId { get; set; } // Long
		[Column(DbType="Long",     DataType=DataType.Int32, Precision=10), Nullable            ] public int?   TypeDiscriminator   { get; set; } // Long
		[Column(DbType="text(50)", DataType=DataType.NText, Length=50),    Nullable            ] public string Name                { get; set; } // text(50)
	}

	[Table("LinqDataTypes")]
	public partial class LinqDataType
	{
		[Column(DbType="Long",     DataType=DataType.Int32,     Precision=10),             Nullable] public int?      ID             { get; set; } // Long
		[Column(DbType="Decimal",  DataType=DataType.Decimal,   Precision=10, Scale=4),    Nullable] public decimal?  MoneyValue     { get; set; } // Decimal
		[Column(DbType="DateTime", DataType=DataType.DateTime),                            Nullable] public DateTime? DateTimeValue  { get; set; } // DateTime
		[Column(DbType="DateTime", DataType=DataType.DateTime),                            Nullable] public DateTime? DateTimeValue2 { get; set; } // DateTime
		[Column(DbType="Bit",      DataType=DataType.Boolean,   Length=2),              NotNull    ] public bool      BoolValue      { get; set; } // Bit
		[Column(DbType="GUID",     DataType=DataType.Guid),                                Nullable] public Guid?     GuidValue      { get; set; } // GUID
		[Column(DbType="image(0)", DataType=DataType.Undefined, Length=0),                 Nullable] public byte[]    BinaryValue    { get; set; } // image(0)
		[Column(DbType="Short",    DataType=DataType.Int16,     Precision=5),              Nullable] public short?    SmallIntValue  { get; set; } // Short
		[Column(DbType="Long",     DataType=DataType.Int32,     Precision=10),             Nullable] public int?      IntValue       { get; set; } // Long
		[Column(DbType="Long",     DataType=DataType.Int32,     Precision=10),             Nullable] public int?      BigIntValue    { get; set; } // Long
		[Column(DbType="text(50)", DataType=DataType.NText,     Length=50),                Nullable] public string    StringValue    { get; set; } // text(50)
	}

	[Table("LinqDataTypes Query", IsView=true)]
	public partial class LinqDataTypesQuery
	{
		[Column(DbType="DateTime", DataType=DataType.DateTime), Nullable] public DateTime? DateTimeValue { get; set; } // DateTime
	}

	[Table("LinqDataTypes Query1", IsView=true)]
	public partial class LinqDataTypesQuery1
	{
		[Column(DbType="Long", DataType=DataType.Int32, Precision=10), Nullable] public int? ID { get; set; } // Long
	}

	[Table("LinqDataTypes Query2", IsView=true)]
	public partial class LinqDataTypesQuery2
	{
		[Column(DbType="Long", DataType=DataType.Int32, Precision=10), Nullable] public int? ID { get; set; } // Long
	}

	[Table("Parent")]
	public partial class Parent
	{
		[Column(DbType="Long", DataType=DataType.Int32, Precision=10), Nullable] public int? ParentID { get; set; } // Long
		[Column(DbType="Long", DataType=DataType.Int32, Precision=10), Nullable] public int? Value1   { get; set; } // Long
	}

	[Table("Patient")]
	public partial class Patient
	{
		[Column(DbType="Long",      DataType=DataType.Int32, Precision=10), PrimaryKey, Identity] public int    PersonID  { get; set; } // Long
		[Column(DbType="text(255)", DataType=DataType.NText, Length=255),   NotNull             ] public string Diagnosis { get; set; } // text(255)

		#region Associations

		/// <summary>
		/// PersonPatient
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=false, Relationship=Relationship.OneToOne, KeyName="PersonPatient", BackReferenceName="PersonPatient")]
		public Person Person { get; set; }

		#endregion
	}

	[Table("Patient_SelectAll", IsView=true)]
	public partial class PatientSelectAll
	{
		[Column(DbType="Long",      DataType=DataType.Int32, Precision=10), Identity] public int    PersonID   { get; set; } // Long
		[Column(DbType="text(50)",  DataType=DataType.NText, Length=50),    Nullable] public string FirstName  { get; set; } // text(50)
		[Column(DbType="text(50)",  DataType=DataType.NText, Length=50),    Nullable] public string LastName   { get; set; } // text(50)
		[Column(DbType="text(50)",  DataType=DataType.NText, Length=50),    Nullable] public string MiddleName { get; set; } // text(50)
		[Column(DbType="text(1)",   DataType=DataType.NText, Length=1),     Nullable] public char?  Gender     { get; set; } // text(1)
		[Column(DbType="text(255)", DataType=DataType.NText, Length=255),   Nullable] public string Diagnosis  { get; set; } // text(255)
	}

	[Table("Person")]
	public partial class Person
	{
		[Column(DbType="Long",     DataType=DataType.Int32, Precision=10), PrimaryKey,  Identity] public int    PersonID   { get; set; } // Long
		[Column(DbType="text(50)", DataType=DataType.NText, Length=50),    NotNull              ] public string FirstName  { get; set; } // text(50)
		[Column(DbType="text(50)", DataType=DataType.NText, Length=50),    NotNull              ] public string LastName   { get; set; } // text(50)
		[Column(DbType="text(50)", DataType=DataType.NText, Length=50),       Nullable          ] public string MiddleName { get; set; } // text(50)
		[Column(DbType="text(1)",  DataType=DataType.NText, Length=1),     NotNull              ] public char   Gender     { get; set; } // text(1)

		#region Associations

		/// <summary>
		/// PersonDoctor_BackReference
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=true, Relationship=Relationship.OneToOne, IsBackReference=true)]
		public Doctor PersonDoctor { get; set; }

		/// <summary>
		/// PersonPatient_BackReference
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=true, Relationship=Relationship.OneToOne, IsBackReference=true)]
		public Patient PersonPatient { get; set; }

		#endregion
	}

	[Table("Person_SelectAll", IsView=true)]
	public partial class PersonSelectAll
	{
		[Column(DbType="Long",     DataType=DataType.Int32, Precision=10), Identity] public int    PersonID   { get; set; } // Long
		[Column(DbType="text(50)", DataType=DataType.NText, Length=50),    Nullable] public string FirstName  { get; set; } // text(50)
		[Column(DbType="text(50)", DataType=DataType.NText, Length=50),    Nullable] public string LastName   { get; set; } // text(50)
		[Column(DbType="text(50)", DataType=DataType.NText, Length=50),    Nullable] public string MiddleName { get; set; } // text(50)
		[Column(DbType="text(1)",  DataType=DataType.NText, Length=1),     Nullable] public char?  Gender     { get; set; } // text(1)
	}

	[Table("Scalar_DataReader", IsView=true)]
	public partial class ScalarDataReader
	{
		[Column("intField",    DbType="Long",      DataType=DataType.Int32, Precision=10), Nullable] public int?   IntField    { get; set; } // Long
		[Column("stringField", DbType="text(255)", DataType=DataType.NText, Length=255),   Nullable] public string StringField { get; set; } // text(255)
	}

	[Table("TestIdentity")]
	public partial class TestIdentity
	{
		[Column(DbType="Long", DataType=DataType.Int32, Precision=10), PrimaryKey, Identity] public int ID { get; set; } // Long
	}

	[Table("TestMerge1")]
	public partial class TestMerge1
	{
		[Column(DbType="Long",      DataType=DataType.Int32,     Precision=10),           PrimaryKey,  Identity] public int       Id              { get; set; } // Long
		[Column(DbType="Long",      DataType=DataType.Int32,     Precision=10),              Nullable          ] public int?      Field1          { get; set; } // Long
		[Column(DbType="Long",      DataType=DataType.Int32,     Precision=10),              Nullable          ] public int?      Field2          { get; set; } // Long
		[Column(DbType="Long",      DataType=DataType.Int32,     Precision=10),              Nullable          ] public int?      Field3          { get; set; } // Long
		[Column(DbType="Long",      DataType=DataType.Int32,     Precision=10),              Nullable          ] public int?      Field4          { get; set; } // Long
		[Column(DbType="Long",      DataType=DataType.Int32,     Precision=10),              Nullable          ] public int?      Field5          { get; set; } // Long
		[Column(DbType="Bit",       DataType=DataType.Boolean,   Length=2),               NotNull              ] public bool      FieldBoolean    { get; set; } // Bit
		[Column(DbType="text(20)",  DataType=DataType.NText,     Length=20),                 Nullable          ] public string    FieldString     { get; set; } // text(20)
		[Column(DbType="text(20)",  DataType=DataType.NText,     Length=20),                 Nullable          ] public string    FieldNString    { get; set; } // text(20)
		[Column(DbType="text(1)",   DataType=DataType.NText,     Length=1),                  Nullable          ] public char?     FieldChar       { get; set; } // text(1)
		[Column(DbType="text(1)",   DataType=DataType.NText,     Length=1),                  Nullable          ] public char?     FieldNChar      { get; set; } // text(1)
		[Column(DbType="Single",    DataType=DataType.Single,    Precision=7),               Nullable          ] public float?    FieldFloat      { get; set; } // Single
		[Column(DbType="Double",    DataType=DataType.Double,    Precision=15),              Nullable          ] public double?   FieldDouble     { get; set; } // Double
		[Column(DbType="DateTime",  DataType=DataType.DateTime),                             Nullable          ] public DateTime? FieldDateTime   { get; set; } // DateTime
		[Column(DbType="image(20)", DataType=DataType.Undefined, Length=20),                 Nullable          ] public byte[]    FieldBinary     { get; set; } // image(20)
		[Column(DbType="GUID",      DataType=DataType.Guid),                                 Nullable          ] public Guid?     FieldGuid       { get; set; } // GUID
		[Column(DbType="Decimal",   DataType=DataType.Decimal,   Precision=24, Scale=10),    Nullable          ] public decimal?  FieldDecimal    { get; set; } // Decimal
		[Column(DbType="DateTime",  DataType=DataType.DateTime),                             Nullable          ] public DateTime? FieldDate       { get; set; } // DateTime
		[Column(DbType="DateTime",  DataType=DataType.DateTime),                             Nullable          ] public DateTime? FieldTime       { get; set; } // DateTime
		[Column(DbType="text(20)",  DataType=DataType.NText,     Length=20),                 Nullable          ] public string    FieldEnumString { get; set; } // text(20)
		[Column(DbType="Long",      DataType=DataType.Int32,     Precision=10),              Nullable          ] public int?      FieldEnumNumber { get; set; } // Long
	}

	[Table("TestMerge2")]
	public partial class TestMerge2
	{
		[Column(DbType="Long",      DataType=DataType.Int32,     Precision=10),           PrimaryKey,  Identity] public int       Id              { get; set; } // Long
		[Column(DbType="Long",      DataType=DataType.Int32,     Precision=10),              Nullable          ] public int?      Field1          { get; set; } // Long
		[Column(DbType="Long",      DataType=DataType.Int32,     Precision=10),              Nullable          ] public int?      Field2          { get; set; } // Long
		[Column(DbType="Long",      DataType=DataType.Int32,     Precision=10),              Nullable          ] public int?      Field3          { get; set; } // Long
		[Column(DbType="Long",      DataType=DataType.Int32,     Precision=10),              Nullable          ] public int?      Field4          { get; set; } // Long
		[Column(DbType="Long",      DataType=DataType.Int32,     Precision=10),              Nullable          ] public int?      Field5          { get; set; } // Long
		[Column(DbType="Bit",       DataType=DataType.Boolean,   Length=2),               NotNull              ] public bool      FieldBoolean    { get; set; } // Bit
		[Column(DbType="text(20)",  DataType=DataType.NText,     Length=20),                 Nullable          ] public string    FieldString     { get; set; } // text(20)
		[Column(DbType="text(20)",  DataType=DataType.NText,     Length=20),                 Nullable          ] public string    FieldNString    { get; set; } // text(20)
		[Column(DbType="text(1)",   DataType=DataType.NText,     Length=1),                  Nullable          ] public char?     FieldChar       { get; set; } // text(1)
		[Column(DbType="text(1)",   DataType=DataType.NText,     Length=1),                  Nullable          ] public char?     FieldNChar      { get; set; } // text(1)
		[Column(DbType="Single",    DataType=DataType.Single,    Precision=7),               Nullable          ] public float?    FieldFloat      { get; set; } // Single
		[Column(DbType="Double",    DataType=DataType.Double,    Precision=15),              Nullable          ] public double?   FieldDouble     { get; set; } // Double
		[Column(DbType="DateTime",  DataType=DataType.DateTime),                             Nullable          ] public DateTime? FieldDateTime   { get; set; } // DateTime
		[Column(DbType="image(20)", DataType=DataType.Undefined, Length=20),                 Nullable          ] public byte[]    FieldBinary     { get; set; } // image(20)
		[Column(DbType="GUID",      DataType=DataType.Guid),                                 Nullable          ] public Guid?     FieldGuid       { get; set; } // GUID
		[Column(DbType="Decimal",   DataType=DataType.Decimal,   Precision=24, Scale=10),    Nullable          ] public decimal?  FieldDecimal    { get; set; } // Decimal
		[Column(DbType="DateTime",  DataType=DataType.DateTime),                             Nullable          ] public DateTime? FieldDate       { get; set; } // DateTime
		[Column(DbType="DateTime",  DataType=DataType.DateTime),                             Nullable          ] public DateTime? FieldTime       { get; set; } // DateTime
		[Column(DbType="text(20)",  DataType=DataType.NText,     Length=20),                 Nullable          ] public string    FieldEnumString { get; set; } // text(20)
		[Column(DbType="Long",      DataType=DataType.Int32,     Precision=10),              Nullable          ] public int?      FieldEnumNumber { get; set; } // Long
	}

	public static partial class TestDataDBStoredProcedures
	{
		#region AddIssue792Record

		public static int AddIssue792Record(this TestDataDB dataConnection)
		{
			return dataConnection.ExecuteProc("[AddIssue792Record]");
		}

		#endregion

		#region PatientSelectByName

		public static int PatientSelectByName(this TestDataDB dataConnection, string @firstName, string @lastName)
		{
			return dataConnection.ExecuteProc("[Patient_SelectByName]",
				new DataParameter("@firstName", @firstName, DataType.NText),
				new DataParameter("@lastName",  @lastName,  DataType.NText));
		}

		#endregion

		#region PersonDelete

		public static int PersonDelete(this TestDataDB dataConnection, int? @PersonID)
		{
			return dataConnection.ExecuteProc("[Person_Delete]",
				new DataParameter("@PersonID", @PersonID, DataType.Int32));
		}

		#endregion

		#region PersonInsert

		public static int PersonInsert(this TestDataDB dataConnection, string @FirstName, string @MiddleName, string @LastName, string @Gender)
		{
			return dataConnection.ExecuteProc("[Person_Insert]",
				new DataParameter("@FirstName",  @FirstName,  DataType.NText),
				new DataParameter("@MiddleName", @MiddleName, DataType.NText),
				new DataParameter("@LastName",   @LastName,   DataType.NText),
				new DataParameter("@Gender",     @Gender,     DataType.NText));
		}

		#endregion

		#region PersonSelectByKey

		public static int PersonSelectByKey(this TestDataDB dataConnection, int? @id)
		{
			return dataConnection.ExecuteProc("[Person_SelectByKey]",
				new DataParameter("@id", @id, DataType.Int32));
		}

		#endregion

		#region PersonSelectByName

		public static int PersonSelectByName(this TestDataDB dataConnection, string @firstName, string @lastName)
		{
			return dataConnection.ExecuteProc("[Person_SelectByName]",
				new DataParameter("@firstName", @firstName, DataType.NText),
				new DataParameter("@lastName",  @lastName,  DataType.NText));
		}

		#endregion

		#region PersonSelectListByName

		public static int PersonSelectListByName(this TestDataDB dataConnection, string @firstName, string @lastName)
		{
			return dataConnection.ExecuteProc("[Person_SelectListByName]",
				new DataParameter("@firstName", @firstName, DataType.NText),
				new DataParameter("@lastName",  @lastName,  DataType.NText));
		}

		#endregion

		#region PersonUpdate

		public static int PersonUpdate(this TestDataDB dataConnection, int? @id, int? @PersonID, string @FirstName, string @MiddleName, string @LastName, string @Gender)
		{
			return dataConnection.ExecuteProc("[Person_Update]",
				new DataParameter("@id",         @id,         DataType.Int32),
				new DataParameter("@PersonID",   @PersonID,   DataType.Int32),
				new DataParameter("@FirstName",  @FirstName,  DataType.NText),
				new DataParameter("@MiddleName", @MiddleName, DataType.NText),
				new DataParameter("@LastName",   @LastName,   DataType.NText),
				new DataParameter("@Gender",     @Gender,     DataType.NText));
		}

		#endregion
	}

	public static partial class TableExtensions
	{
		public static DataTypeTest Find(this ITable<DataTypeTest> table, int DataTypeID)
		{
			return table.FirstOrDefault(t =>
				t.DataTypeID == DataTypeID);
		}

		public static Doctor Find(this ITable<Doctor> table, int PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static InheritanceChild Find(this ITable<InheritanceChild> table, int InheritanceChildId)
		{
			return table.FirstOrDefault(t =>
				t.InheritanceChildId == InheritanceChildId);
		}

		public static InheritanceParent Find(this ITable<InheritanceParent> table, int InheritanceParentId)
		{
			return table.FirstOrDefault(t =>
				t.InheritanceParentId == InheritanceParentId);
		}

		public static Patient Find(this ITable<Patient> table, int PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static Person Find(this ITable<Person> table, int PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static TestIdentity Find(this ITable<TestIdentity> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static TestMerge1 Find(this ITable<TestMerge1> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static TestMerge2 Find(this ITable<TestMerge2> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}
	}
}

#pragma warning restore 1591
