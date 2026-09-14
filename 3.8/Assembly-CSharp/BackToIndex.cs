using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200080E RID: 2062
[Token(Token = "0x200080E")]
public class BackToIndex : UIBtn
{
	// Token: 0x06002A03 RID: 10755 RVA: 0x000E5B5C File Offset: 0x000E3D5C
	[Token(Token = "0x6002A03")]
	[Address(RVA = "0x634470", Offset = "0x632A70", VA = "0x180634470", Slot = "7")]
	protected override void OnMouseUpAsButton()
	{
		base.OnMouseUpAsButton();
		this.firstBtns.SetActive(true);
		GameObject gameObject = base.transform.parent.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
	}

	// Token: 0x06002A04 RID: 10756 RVA: 0x000E5B9C File Offset: 0x000E3D9C
	[Token(Token = "0x6002A04")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public BackToIndex()
	{
	}

	// Token: 0x0400184D RID: 6221
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400184D")]
	public GameObject firstBtns;
}
