using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200083F RID: 2111
[Token(Token = "0x200083F")]
public class GodShootingLevelButton : UIButton
{
	// Token: 0x06002AFF RID: 11007 RVA: 0x000EBD60 File Offset: 0x000E9F60
	[Token(Token = "0x6002AFF")]
	[Address(RVA = "0x65C290", Offset = "0x65A890", VA = "0x18065C290")]
	private void Awake()
	{
		GameObject gameObject = this.trophy;
		bool[] clgLevelCompleted = GameAPP.clgLevelCompleted;
		int num = this.level;
		bool flag;
		gameObject.SetActive(flag);
	}

	// Token: 0x06002B00 RID: 11008 RVA: 0x000EBD90 File Offset: 0x000E9F90
	[Token(Token = "0x6002B00")]
	[Address(RVA = "0x65C330", Offset = "0x65A930", VA = "0x18065C330", Slot = "9")]
	protected override void OnMouseUpAsButton()
	{
		base.OnMouseUpAsButton();
		int num = this.level;
		int num2 = 0;
		UIMgr.EnterGame((LevelType)((uint)1), num, -1, num2);
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002B01 RID: 11009 RVA: 0x000EBDC0 File Offset: 0x000E9FC0
	[Token(Token = "0x6002B01")]
	[Address(RVA = "0x51C260", Offset = "0x51A860", VA = "0x18051C260")]
	public GodShootingLevelButton()
	{
	}

	// Token: 0x0400192A RID: 6442
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400192A")]
	public int level;

	// Token: 0x0400192B RID: 6443
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400192B")]
	public GameObject trophy;

	// Token: 0x0400192C RID: 6444
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400192C")]
	public bool mainLine;
}
