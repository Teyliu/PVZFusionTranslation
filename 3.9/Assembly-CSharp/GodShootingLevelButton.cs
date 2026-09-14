using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200087B RID: 2171
[Token(Token = "0x200087B")]
public class GodShootingLevelButton : UIButton
{
	// Token: 0x06002C31 RID: 11313 RVA: 0x000F0A70 File Offset: 0x000EEC70
	[Token(Token = "0x6002C31")]
	[Address(RVA = "0x6C0110", Offset = "0x6BE710", VA = "0x1806C0110")]
	private void Awake()
	{
		GameObject gameObject = this.trophy;
		bool[] clgLevelCompleted = GameAPP.clgLevelCompleted;
		int num = this.level;
		bool flag;
		gameObject.SetActive(flag);
	}

	// Token: 0x06002C32 RID: 11314 RVA: 0x000F0AA0 File Offset: 0x000EECA0
	[Token(Token = "0x6002C32")]
	[Address(RVA = "0x6C01B0", Offset = "0x6BE7B0", VA = "0x1806C01B0", Slot = "9")]
	protected override void OnMouseUpAsButton()
	{
		base.OnMouseUpAsButton();
		int num = this.level;
		int num2 = 0;
		UIMgr.EnterGame((LevelType)((uint)1), num, -1, num2);
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002C33 RID: 11315 RVA: 0x000F0AD0 File Offset: 0x000EECD0
	[Token(Token = "0x6002C33")]
	[Address(RVA = "0x5763F0", Offset = "0x5749F0", VA = "0x1805763F0")]
	public GodShootingLevelButton()
	{
	}

	// Token: 0x04001A18 RID: 6680
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001A18")]
	public int level;

	// Token: 0x04001A19 RID: 6681
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001A19")]
	public GameObject trophy;

	// Token: 0x04001A1A RID: 6682
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001A1A")]
	public bool mainLine;
}
