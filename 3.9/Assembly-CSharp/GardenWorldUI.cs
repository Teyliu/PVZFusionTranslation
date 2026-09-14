using System;
using Cpp2IlInjected;

// Token: 0x02000879 RID: 2169
[Token(Token = "0x2000879")]
public class GardenWorldUI : BaseMenu
{
	// Token: 0x06002C2E RID: 11310 RVA: 0x000F0A34 File Offset: 0x000EEC34
	[Token(Token = "0x6002C2E")]
	[Address(RVA = "0x6C0100", Offset = "0x6BE700", VA = "0x1806C0100")]
	public void BackToGarden()
	{
		UIMgr.EnterGarden();
	}

	// Token: 0x06002C2F RID: 11311 RVA: 0x000F0A48 File Offset: 0x000EEC48
	[Token(Token = "0x6002C2F")]
	[Address(RVA = "0x667800", Offset = "0x665E00", VA = "0x180667800")]
	public GardenWorldUI()
	{
	}
}
