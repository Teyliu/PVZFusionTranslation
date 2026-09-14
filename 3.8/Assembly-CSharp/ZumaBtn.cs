using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000FC RID: 252
[Token(Token = "0x20000FC")]
public class ZumaBtn : UIBtn
{
	// Token: 0x060004CB RID: 1227 RVA: 0x00019640 File Offset: 0x00017840
	[Token(Token = "0x60004CB")]
	[Address(RVA = "0x5B8340", Offset = "0x5B6940", VA = "0x1805B8340", Slot = "7")]
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

	// Token: 0x060004CC RID: 1228 RVA: 0x000196D0 File Offset: 0x000178D0
	[Token(Token = "0x60004CC")]
	[Address(RVA = "0x5B8280", Offset = "0x5B6880", VA = "0x1805B8280", Slot = "5")]
	protected override void OnMouseEnter()
	{
		base.OnMouseEnter();
		ZumaShooter.Instance.freeMouse = false;
	}

	// Token: 0x060004CD RID: 1229 RVA: 0x000196F4 File Offset: 0x000178F4
	[Token(Token = "0x60004CD")]
	[Address(RVA = "0x5B82E0", Offset = "0x5B68E0", VA = "0x1805B82E0", Slot = "6")]
	protected override void OnMouseExit()
	{
		base.OnMouseExit();
		ZumaShooter.Instance.freeMouse = true;
	}

	// Token: 0x060004CE RID: 1230 RVA: 0x00019718 File Offset: 0x00017918
	[Token(Token = "0x60004CE")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public ZumaBtn()
	{
	}

	// Token: 0x040002ED RID: 749
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40002ED")]
	public int btnType;

	// Token: 0x040002EE RID: 750
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40002EE")]
	private bool trigger;
}
