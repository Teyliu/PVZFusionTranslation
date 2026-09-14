using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000772 RID: 1906
[Token(Token = "0x2000772")]
public class SwitchBtn : UIBtn
{
	// Token: 0x060026C8 RID: 9928 RVA: 0x000CB5D0 File Offset: 0x000C97D0
	[Token(Token = "0x60026C8")]
	[Address(RVA = "0x62B9B0", Offset = "0x629FB0", VA = "0x18062B9B0", Slot = "4")]
	protected override void Awake()
	{
		base.Awake();
		this.normalPage.SetActive(true);
		GameObject gameObject = this.customPage;
		int num = 0;
		gameObject.SetActive(num != 0);
	}

	// Token: 0x060026C9 RID: 9929 RVA: 0x000CB608 File Offset: 0x000C9808
	[Token(Token = "0x60026C9")]
	[Address(RVA = "0x62BA00", Offset = "0x62A000", VA = "0x18062BA00", Slot = "7")]
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

	// Token: 0x060026CA RID: 9930 RVA: 0x000CB64C File Offset: 0x000C984C
	[Token(Token = "0x60026CA")]
	[Address(RVA = "0x5EDFC0", Offset = "0x5EC5C0", VA = "0x1805EDFC0")]
	public SwitchBtn()
	{
	}

	// Token: 0x040013CB RID: 5067
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40013CB")]
	public GameObject normalPage;

	// Token: 0x040013CC RID: 5068
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40013CC")]
	public GameObject customPage;
}
