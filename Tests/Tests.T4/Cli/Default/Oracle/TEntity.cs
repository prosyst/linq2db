// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB.Mapping;
using System;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.Default.Oracle
{
	[Table("t_entity")]
	public class TEntity
	{
		[Column("entity_id", IsPrimaryKey = true)] public decimal   EntityId { get; set; } // NUMBER
		[Column("time"                          )] public DateTime? Time     { get; set; } // DATE
		[Column("duration"                      )] public TimeSpan? Duration { get; set; } // INTERVAL DAY(3) TO SECOND(2)
	}
}
