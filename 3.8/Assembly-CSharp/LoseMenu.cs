using System;
using Cpp2IlInjected;
using TMPro;

// Token: 0x0200085D RID: 2141
[Token(Token = "0x200085D")]
public class LoseMenu : BaseMenu
{
	// Token: 0x06002BBD RID: 11197 RVA: 0x000F02E8 File Offset: 0x000EE4E8
	[Token(Token = "0x6002BBD")]
	[Address(RVA = "0x603FF0", Offset = "0x6025F0", VA = "0x180603FF0")]
	public LoseMenu()
	{
	}

	// Token: 0x040019ED RID: 6637
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40019ED")]
	public TextMeshProUGUI title;
}
