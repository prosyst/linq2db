// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB.Mapping;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.Default.SQLite
{
	[Table("Person")]
	public class Person
	{
		[Column("PersonID"  , IsPrimaryKey = true , IsIdentity = true, SkipOnInsert = true, SkipOnUpdate = true)] public long    PersonId   { get; set; } // integer
		[Column("FirstName" , CanBeNull    = false                                                             )] public string  FirstName  { get; set; } = null!; // nvarchar(50)
		[Column("LastName"  , CanBeNull    = false                                                             )] public string  LastName   { get; set; } = null!; // nvarchar(50)
		[Column("MiddleName"                                                                                   )] public string? MiddleName { get; set; } // nvarchar(50)
		[Column("Gender"                                                                                       )] public char    Gender     { get; set; } // char(1)

		#region Associations
		/// <summary>
		/// FK_Doctor_0_0 backreference
		/// </summary>
		[Association(ThisKey = nameof(PersonId), OtherKey = nameof(SQLite.Doctor.PersonId))]
		public Doctor? Doctor { get; set; }

		/// <summary>
		/// FK_Patient_0_0 backreference
		/// </summary>
		[Association(ThisKey = nameof(PersonId), OtherKey = nameof(SQLite.Patient.PersonId))]
		public Patient? Patient { get; set; }
		#endregion
	}
}
