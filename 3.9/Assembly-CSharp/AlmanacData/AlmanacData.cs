using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AlmanacData
{
	// Token: 0x02000A83 RID: 2691
	[Token(Token = "0x2000A83")]
	[Serializable]
	public class AlmanacData
	{
		// Token: 0x0600374E RID: 14158 RVA: 0x00128840 File Offset: 0x00126A40
		[Token(Token = "0x600374E")]
		[Address(RVA = "0x7B2E80", Offset = "0x7B1480", VA = "0x1807B2E80")]
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

		// Token: 0x04002AC6 RID: 10950
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002AC6")]
		public List<Details> details;

		// Token: 0x04002AC7 RID: 10951
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002AC7")]
		public List<PlantInfo> plants;

		// Token: 0x04002AC8 RID: 10952
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002AC8")]
		public List<ZombieInfo> zombies;
	}
}
