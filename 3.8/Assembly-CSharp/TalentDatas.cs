using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020009E2 RID: 2530
[Token(Token = "0x20009E2")]
[Serializable]
public class TalentDatas
{
	// Token: 0x06003406 RID: 13318 RVA: 0x001159CC File Offset: 0x00113BCC
	[Token(Token = "0x6003406")]
	[Address(RVA = "0x71D3D0", Offset = "0x71B9D0", VA = "0x18071D3D0")]
	public TalentDatas()
	{
		List<TalentData> list = new List();
		this.talentDatas = list;
		base..ctor();
	}

	// Token: 0x04002587 RID: 9607
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002587")]
	public List<TalentData> talentDatas;
}
