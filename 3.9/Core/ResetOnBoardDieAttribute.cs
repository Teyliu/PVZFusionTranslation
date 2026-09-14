using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Core
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	[AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	public sealed class ResetOnBoardDieAttribute : Attribute
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000003")]
		public object DefaultValue
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x7EE610", Offset = "0x7ECC10", VA = "0x1807EE610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x943C30", Offset = "0x942230", VA = "0x180943C30")]
		public ResetOnBoardDieAttribute()
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x943C60", Offset = "0x942260", VA = "0x180943C60")]
		public ResetOnBoardDieAttribute(object defaultValue)
		{
		}
	}
}
