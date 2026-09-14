using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000739 RID: 1849
[Token(Token = "0x2000739")]
public class SwitchBtn : UIBtn
{
	// Token: 0x060025A3 RID: 9635 RVA: 0x000C66EC File Offset: 0x000C48EC
	[Token(Token = "0x60025A3")]
	[Address(RVA = "0x5CA5F0", Offset = "0x5C8BF0", VA = "0x1805CA5F0", Slot = "4")]
	protected override void Awake()
	{
		base.Awake();
		this.normalPage.SetActive(true);
		GameObject gameObject = this.customPage;
		int num = 0;
		gameObject.SetActive(num != 0);
	}

	// Token: 0x060025A4 RID: 9636 RVA: 0x000C6724 File Offset: 0x000C4924
	[Token(Token = "0x60025A4")]
	[Address(RVA = "0x5CA640", Offset = "0x5C8C40", VA = "0x1805CA640", Slot = "7")]
	protected override void OnMouseUpAsButton()
	{
		base.OnMouseUpAsButton();
		GameObject gameObject = this.normalPage;
		bool activeSelf = gameObject.activeSelf;
		gameObject.SetActive(activeSelf);
		GameObject gameObject2 = this.customPage;
		bool activeSelf2 = gameObject2.activeSelf;
		gameObject2.SetActive(activeSelf2);
	}

	// Token: 0x060025A5 RID: 9637 RVA: 0x000C6768 File Offset: 0x000C4968
	[Token(Token = "0x60025A5")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public SwitchBtn()
	{
	}

	// Token: 0x040012F5 RID: 4853
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40012F5")]
	public GameObject normalPage;

	// Token: 0x040012F6 RID: 4854
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40012F6")]
	public GameObject customPage;
}
