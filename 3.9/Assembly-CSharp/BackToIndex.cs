using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200084C RID: 2124
[Token(Token = "0x200084C")]
public class BackToIndex : UIBtn
{
	// Token: 0x06002B41 RID: 11073 RVA: 0x000EAE9C File Offset: 0x000E909C
	[Token(Token = "0x6002B41")]
	[Address(RVA = "0x698880", Offset = "0x696E80", VA = "0x180698880", Slot = "7")]
	protected override void OnMouseUpAsButton()
	{
		base.OnMouseUpAsButton();
		this.firstBtns.SetActive(true);
		GameObject gameObject = base.transform.parent.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
	}

	// Token: 0x06002B42 RID: 11074 RVA: 0x000EAEDC File Offset: 0x000E90DC
	[Token(Token = "0x6002B42")]
	[Address(RVA = "0x5EDFC0", Offset = "0x5EC5C0", VA = "0x1805EDFC0")]
	public BackToIndex()
	{
	}

	// Token: 0x04001949 RID: 6473
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001949")]
	public GameObject firstBtns;
}
