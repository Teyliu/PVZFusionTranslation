using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Core
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	[AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	public sealed class ResetOnBoardDieAttribute : Attribute
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000003")]
		public object DefaultValue
		{
			[Token(Token = "0x6000066")]
			[Address(RVA = "0x787BE0", Offset = "0x7861E0", VA = "0x180787BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x8B3BA0", Offset = "0x8B21A0", VA = "0x1808B3BA0")]
		public ResetOnBoardDieAttribute()
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x8B3BD0", Offset = "0x8B21D0", VA = "0x1808B3BD0")]
		public ResetOnBoardDieAttribute(object defaultValue)
		{
		}
	}
}
