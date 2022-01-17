﻿//HintName: WithProperties.g.cs
// <auto-generated />

using System;
using System.ComponentModel.DataAnnotations;
using OceanWebSystems.Audit.EntityFramework;

namespace OceanWebSystems.Data.Models
{
	public partial class WithPropertiesAuditRecord : AuditRecordBase
	{
		[Key]
		public int AuditId { get; set; }

		public int Id { get; set; }

		public DateTime DateProperty { get; set; }

		public DateTime? NullableDateProperty { get; set; }

		public int? NullableIntegerProperty { get; set; }

		public byte ByteProperty { get; set; }

		public byte? NullableByteProperty { get; set; }

		public long LongProperty { get; set; }

		public long? NullableLongProperty { get; set; }

		public bool BooleanProperty { get; set; }

		public bool? NullableBooleanProperty { get; set; }

		public char CharProperty { get; set; }

		public char? NullableCharProperty { get; set; }

		public decimal DecimalProperty { get; set; }

		public decimal? NullableDecimalProperty { get; set; }

		public double DoubleProperty { get; set; }

		public double? NullableDoubleProperty { get; set; }

		public float FloatProperty { get; set; }

		public float? NullableFloatProperty { get; set; }

		public Guid GuidProperty { get; set; }

		public Guid? NullableGuidProperty { get; set; }

		public short ShortProperty { get; set; }

		public short? NullableShortProperty { get; set; }

		public DayOfWeek EnumProperty { get; set; }

		public DayOfWeek? NullableEnumProperty { get; set; }
	}
}
