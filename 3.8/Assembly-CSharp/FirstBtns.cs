using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000810 RID: 2064
[Token(Token = "0x2000810")]
public class FirstBtns : UIBtn
{
	// Token: 0x06002A07 RID: 10759 RVA: 0x000E5C54 File Offset: 0x000E3E54
	[Token(Token = "0x6002A07")]
	[Address(RVA = "0x63ACE0", Offset = "0x6392E0", VA = "0x18063ACE0", Slot = "7")]
	protected override void OnMouseUpAsButton()
	{
		base.OnMouseUpAsButton();
		this.pageToOpen.SetActive(true);
		GameObject gameObject = this.firstBtns;
		int num = 0;
		gameObject.SetActive(num != 0);
	}

	// Token: 0x06002A08 RID: 10760 RVA: 0x000E5C8C File Offset: 0x000E3E8C
	[Token(Token = "0x6002A08")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public FirstBtns()
	{
	}

	// Token: 0x0400184F RID: 6223
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400184F")]
	public GameObject pageToOpen;

	// Token: 0x04001850 RID: 6224
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001850")]
	public GameObject firstBtns;
}
