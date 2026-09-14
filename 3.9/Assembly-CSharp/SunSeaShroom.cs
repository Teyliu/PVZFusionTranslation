using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004DB RID: 1243
[Token(Token = "0x20004DB")]
public class SunSeaShroom : Producer
{
	// Token: 0x0600176D RID: 5997 RVA: 0x000802E8 File Offset: 0x0007E4E8
	[Token(Token = "0x600176D")]
	[Address(RVA = "0x5170B0", Offset = "0x5156B0", VA = "0x1805170B0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		base.AttributeCountdown = 20f;
	}

	// Token: 0x0600176E RID: 5998 RVA: 0x00080308 File Offset: 0x0007E508
	[Token(Token = "0x600176E")]
	[Address(RVA = "0x516E80", Offset = "0x515480", VA = "0x180516E80", Slot = "39")]
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

	// Token: 0x0600176F RID: 5999 RVA: 0x00080340 File Offset: 0x0007E540
	[Token(Token = "0x600176F")]
	[Address(RVA = "0x516F60", Offset = "0x515560", VA = "0x180516F60", Slot = "69")]
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

	// Token: 0x06001770 RID: 6000 RVA: 0x0008039C File Offset: 0x0007E59C
	[Token(Token = "0x6001770")]
	[Address(RVA = "0x516ED0", Offset = "0x5154D0", VA = "0x180516ED0")]
	public void Grow()
	{
		this.anim.SetTrigger("grow");
		GameAPP.PlaySound(56, 0.5f, 1f);
	}

	// Token: 0x06001771 RID: 6001 RVA: 0x000803D0 File Offset: 0x0007E5D0
	[Token(Token = "0x6001771")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public SunSeaShroom()
	{
	}

	// Token: 0x04000E37 RID: 3639
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000E37")]
	private int growLevel;
}
