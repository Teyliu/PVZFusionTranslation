using System;
using Cpp2IlInjected;

// Token: 0x0200083D RID: 2109
[Token(Token = "0x200083D")]
public class GardenWorldUI : BaseMenu
{
	// Token: 0x06002AFC RID: 11004 RVA: 0x000EBD24 File Offset: 0x000E9F24
	[Token(Token = "0x6002AFC")]
	[Address(RVA = "0x65C280", Offset = "0x65A880", VA = "0x18065C280")]
	public void BackToGarden()
	{
		UIMgr.EnterGarden();
	}

	// Token: 0x06002AFD RID: 11005 RVA: 0x000EBD38 File Offset: 0x000E9F38
	[Token(Token = "0x6002AFD")]
	[Address(RVA = "0x603FF0", Offset = "0x6025F0", VA = "0x180603FF0")]
	public GardenWorldUI()
	{
	}
}
