using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace ZenGarden
{
	// Token: 0x02000A81 RID: 2689
	[Token(Token = "0x2000A81")]
	[Serializable]
	public class GardenAllData
	{
		// Token: 0x06003746 RID: 14150 RVA: 0x001285D8 File Offset: 0x001267D8
		[Token(Token = "0x6003746")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public GardenAllData()
		{
		}

		// Token: 0x04002AC2 RID: 10946
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002AC2")]
		public List<GardenPlantData> plantData;
	}
}
