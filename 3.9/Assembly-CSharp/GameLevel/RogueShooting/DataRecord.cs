using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000DB9 RID: 3513
	[Token(Token = "0x2000DB9")]
	[Serializable]
	public class DataRecord<T>
	{
		// Token: 0x06004915 RID: 18709 RVA: 0x0016B140 File Offset: 0x00169340
		[Token(Token = "0x6004915")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public DataRecord()
		{
		}

		// Token: 0x040033E2 RID: 13282
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40033E2")]
		public T element;

		// Token: 0x040033E3 RID: 13283
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40033E3")]
		public int victoryTimes;
	}
}
