using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000A1E RID: 2590
[Token(Token = "0x2000A1E")]
[Serializable]
public class TalentDatas
{
	// Token: 0x0600353A RID: 13626 RVA: 0x0011A924 File Offset: 0x00118B24
	[Token(Token = "0x600353A")]
	[Address(RVA = "0x782940", Offset = "0x780F40", VA = "0x180782940")]
	public TalentDatas()
	{
		List<TalentData> list = new List();
		this.talentDatas = list;
		base..ctor();
	}

	// Token: 0x04002699 RID: 9881
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002699")]
	public List<TalentData> talentDatas;
}
