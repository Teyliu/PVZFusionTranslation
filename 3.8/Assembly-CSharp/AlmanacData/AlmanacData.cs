using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AlmanacData
{
	// Token: 0x02000A43 RID: 2627
	[Token(Token = "0x2000A43")]
	[Serializable]
	public class AlmanacData
	{
		// Token: 0x0600360A RID: 13834 RVA: 0x001235C4 File Offset: 0x001217C4
		[Token(Token = "0x600360A")]
		[Address(RVA = "0x74C4C0", Offset = "0x74AAC0", VA = "0x18074C4C0")]
		public AlmanacData()
		{
			List<Details> list = new List();
			this.details = list;
			List<PlantInfo> list2 = new List();
			this.plants = list2;
			List<ZombieInfo> list3 = new List();
			this.zombies = list3;
			base..ctor();
		}

		// Token: 0x04002953 RID: 10579
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002953")]
		public List<Details> details;

		// Token: 0x04002954 RID: 10580
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002954")]
		public List<PlantInfo> plants;

		// Token: 0x04002955 RID: 10581
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002955")]
		public List<ZombieInfo> zombies;
	}
}
