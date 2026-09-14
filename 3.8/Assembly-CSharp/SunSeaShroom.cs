using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004B7 RID: 1207
[Token(Token = "0x20004B7")]
public class SunSeaShroom : Producer
{
	// Token: 0x060016C4 RID: 5828 RVA: 0x0007D690 File Offset: 0x0007B890
	[Token(Token = "0x60016C4")]
	[Address(RVA = "0x4AB480", Offset = "0x4A9A80", VA = "0x1804AB480", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		base.AttributeCountdown = 20f;
	}

	// Token: 0x060016C5 RID: 5829 RVA: 0x0007D6B0 File Offset: 0x0007B8B0
	[Token(Token = "0x60016C5")]
	[Address(RVA = "0x4AB250", Offset = "0x4A9850", VA = "0x1804AB250", Slot = "40")]
	protected override void AttributeEvent()
	{
		if (this.growLevel == 0)
		{
			this.Grow();
			base.AttributeCountdown = 40f;
			return;
		}
		if (this.growLevel == 1)
		{
			this.Grow();
			return;
		}
	}

	// Token: 0x060016C6 RID: 5830 RVA: 0x0007D6E8 File Offset: 0x0007B8E8
	[Token(Token = "0x60016C6")]
	[Address(RVA = "0x4AB330", Offset = "0x4A9930", VA = "0x1804AB330", Slot = "70")]
	protected override void ProduceSun()
	{
		uint num;
		uint num2;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num, (int)num2), 0.3f, 1f);
		int num3 = this.growLevel;
		if (num3 != 0)
		{
			if (num3 != 0)
			{
				if (num3 != 1)
				{
					return;
				}
				CreateItem instance = CreateItem.Instance;
			}
			CreateItem instance2 = CreateItem.Instance;
		}
		CreateItem instance3 = CreateItem.Instance;
	}

	// Token: 0x060016C7 RID: 5831 RVA: 0x0007D744 File Offset: 0x0007B944
	[Token(Token = "0x60016C7")]
	[Address(RVA = "0x4AB2A0", Offset = "0x4A98A0", VA = "0x1804AB2A0")]
	public void Grow()
	{
		this.anim.SetTrigger("grow");
		GameAPP.PlaySound(56, 0.5f, 1f);
	}

	// Token: 0x060016C8 RID: 5832 RVA: 0x0007D778 File Offset: 0x0007B978
	[Token(Token = "0x60016C8")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public SunSeaShroom()
	{
	}

	// Token: 0x04000D9E RID: 3486
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000D9E")]
	private int growLevel;
}
