using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200084E RID: 2126
[Token(Token = "0x200084E")]
public class FirstBtns : UIBtn
{
	// Token: 0x06002B45 RID: 11077 RVA: 0x000EAF94 File Offset: 0x000E9194
	[Token(Token = "0x6002B45")]
	[Address(RVA = "0x69F250", Offset = "0x69D850", VA = "0x18069F250", Slot = "7")]
	protected override void OnMouseUpAsButton()
	{
		base.OnMouseUpAsButton();
		this.pageToOpen.SetActive(true);
		GameObject gameObject = this.firstBtns;
		int num = 0;
		gameObject.SetActive(num != 0);
	}

	// Token: 0x06002B46 RID: 11078 RVA: 0x000EAFCC File Offset: 0x000E91CC
	[Token(Token = "0x6002B46")]
	[Address(RVA = "0x5EDFC0", Offset = "0x5EC5C0", VA = "0x1805EDFC0")]
	public FirstBtns()
	{
	}

	// Token: 0x0400194B RID: 6475
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400194B")]
	public GameObject pageToOpen;

	// Token: 0x0400194C RID: 6476
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400194C")]
	public GameObject firstBtns;
}
