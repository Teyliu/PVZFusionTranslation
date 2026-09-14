using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000101 RID: 257
[Token(Token = "0x2000101")]
public class ZumaBtn : UIBtn
{
	// Token: 0x060004E6 RID: 1254 RVA: 0x00019A44 File Offset: 0x00017C44
	[Token(Token = "0x60004E6")]
	[Address(RVA = "0x5EDE10", Offset = "0x5EC410", VA = "0x1805EDE10", Slot = "7")]
	protected override void OnMouseUpAsButton()
	{
		base.OnMouseUpAsButton();
		bool flag = !this.trigger;
		this.trigger = flag;
		if (this.btnType != 0)
		{
			UIMgr.BackToMenu();
			global::UnityEngine.Object.Destroy(Zuma.Instance.gameObject);
			return;
		}
		GameObject gameObject = base.transform.parent.GetChild(1).gameObject;
		bool flag2 = this.trigger;
		gameObject.SetActive(flag2);
		if (!this.trigger)
		{
			Time.timeScale = GameAPP.config.gameSpeed;
			return;
		}
		Time.timeScale = (float)0;
	}

	// Token: 0x060004E7 RID: 1255 RVA: 0x00019AD4 File Offset: 0x00017CD4
	[Token(Token = "0x60004E7")]
	[Address(RVA = "0x5EDD50", Offset = "0x5EC350", VA = "0x1805EDD50", Slot = "5")]
	protected override void OnMouseEnter()
	{
		base.OnMouseEnter();
		ZumaShooter.Instance.freeMouse = false;
	}

	// Token: 0x060004E8 RID: 1256 RVA: 0x00019AF8 File Offset: 0x00017CF8
	[Token(Token = "0x60004E8")]
	[Address(RVA = "0x5EDDB0", Offset = "0x5EC3B0", VA = "0x1805EDDB0", Slot = "6")]
	protected override void OnMouseExit()
	{
		base.OnMouseExit();
		ZumaShooter.Instance.freeMouse = true;
	}

	// Token: 0x060004E9 RID: 1257 RVA: 0x00019B1C File Offset: 0x00017D1C
	[Token(Token = "0x60004E9")]
	[Address(RVA = "0x5EDFC0", Offset = "0x5EC5C0", VA = "0x1805EDFC0")]
	public ZumaBtn()
	{
	}

	// Token: 0x040002FB RID: 763
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40002FB")]
	public int btnType;

	// Token: 0x040002FC RID: 764
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40002FC")]
	private bool trigger;
}
