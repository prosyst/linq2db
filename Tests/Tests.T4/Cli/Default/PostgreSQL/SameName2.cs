// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB.Mapping;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.Default.PostgreSQL
{
	[Table("same_name2")]
	public class SameName2
	{
		[Column("id"       , IsPrimaryKey = true)] public int  Id       { get; set; } // integer
		[Column("same_name"                     )] public int? SameName { get; set; } // integer

		#region Associations
		/// <summary>
		/// same_name
		/// </summary>
		[Association(ThisKey = nameof(SameName), OtherKey = nameof(PostgreSQL.SameName.Id))]
		public SameName? Samename { get; set; }
		#endregion
	}
}
