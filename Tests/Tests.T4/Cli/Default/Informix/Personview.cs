// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB.Mapping;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.Default.Informix
{
	[Table("personview", IsView = true)]
	public class Personview
	{
		[Column("personid"  , IsIdentity = true , SkipOnInsert = true, SkipOnUpdate = true)] public int     Personid   { get; set; } // SERIAL
		[Column("firstname" , CanBeNull  = false                                          )] public string  Firstname  { get; set; } = null!; // NVARCHAR(50)
		[Column("lastname"  , CanBeNull  = false                                          )] public string  Lastname   { get; set; } = null!; // NVARCHAR(50)
		[Column("middlename"                                                              )] public string? Middlename { get; set; } // NVARCHAR(50)
		[Column("gender"                                                                  )] public char    Gender     { get; set; } // CHAR(1)
	}
}
