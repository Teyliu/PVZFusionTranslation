using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace ZenGarden
{
	// Token: 0x02000A41 RID: 2625
	[Token(Token = "0x2000A41")]
	[Serializable]
	public class GardenAllData
	{
		// Token: 0x06003602 RID: 13826 RVA: 0x0012335C File Offset: 0x0012155C
		[Token(Token = "0x6003602")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public GardenAllData()
		{
		}

		// Token: 0x0400294F RID: 10575
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400294F")]
		public List<GardenPlantData> plantData;
	}
}
