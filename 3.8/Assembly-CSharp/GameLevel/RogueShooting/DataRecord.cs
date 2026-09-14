using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CD3 RID: 3283
	[Token(Token = "0x2000CD3")]
	[Serializable]
	public class DataRecord<T>
	{
		// Token: 0x060044C4 RID: 17604 RVA: 0x0015D490 File Offset: 0x0015B690
		[Token(Token = "0x60044C4")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public DataRecord()
		{
		}

		// Token: 0x0400314E RID: 12622
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400314E")]
		public T element;

		// Token: 0x0400314F RID: 12623
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400314F")]
		public int victoryTimes;
	}
}
