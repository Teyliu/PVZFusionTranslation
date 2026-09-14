using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace OpenBLive.Runtime.Utilities
{
	// Token: 0x02000E41 RID: 3649
	[Token(Token = "0x2000E41")]
	[StructLayout(2)]
	internal struct SingleConverter
	{
		// Token: 0x06004B49 RID: 19273 RVA: 0x00172260 File Offset: 0x00170460
		[Token(Token = "0x6004B49")]
		[Address(RVA = "0x8D2010", Offset = "0x8D0610", VA = "0x1808D2010")]
		internal SingleConverter(int intValue)
		{
			this.intValue = intValue;
		}

		// Token: 0x06004B4A RID: 19274 RVA: 0x00172274 File Offset: 0x00170474
		[Token(Token = "0x6004B4A")]
		[Address(RVA = "0x8D2000", Offset = "0x8D0600", VA = "0x1808D2000")]
		internal SingleConverter(float floatValue)
		{
			this.intValue = (int)floatValue;
		}

		// Token: 0x06004B4B RID: 19275 RVA: 0x00172288 File Offset: 0x00170488
		[Token(Token = "0x6004B4B")]
		[Address(RVA = "0x8CF440", Offset = "0x8CDA40", VA = "0x1808CF440")]
		internal int GetIntValue()
		{
			return 0;
		}

		// Token: 0x06004B4C RID: 19276 RVA: 0x00172298 File Offset: 0x00170498
		[Token(Token = "0x6004B4C")]
		[Address(RVA = "0x8D1FF0", Offset = "0x8D05F0", VA = "0x1808D1FF0")]
		internal float GetFloatValue()
		{
			return 0f;
		}

		// Token: 0x04003541 RID: 13633
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4003541")]
		private int intValue;

		// Token: 0x04003542 RID: 13634
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4003542")]
		private float floatValue;
	}
}
