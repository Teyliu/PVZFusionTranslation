using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200040B RID: 1035
[Token(Token = "0x200040B")]
public class PuffPumpkin : Pumpkin
{
	// Token: 0x0600131F RID: 4895 RVA: 0x0006BD7C File Offset: 0x00069F7C
	[Token(Token = "0x600131F")]
	[Address(RVA = "0x42DFB0", Offset = "0x42C5B0", VA = "0x18042DFB0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 3f;
	}

	// Token: 0x06001320 RID: 4896 RVA: 0x0006BD9C File Offset: 0x00069F9C
	[Token(Token = "0x6001320")]
	[Address(RVA = "0x462060", Offset = "0x460660", VA = "0x180462060", Slot = "15")]
	protected override void Start()
	{
		int thePlantMaxHealth = this.thePlantMaxHealth;
		this.thePlantHealth = thePlantMaxHealth;
		base.Start();
	}

	// Token: 0x06001321 RID: 4897 RVA: 0x0006BDC0 File Offset: 0x00069FC0
	[Token(Token = "0x6001321")]
	[Address(RVA = "0x461EF0", Offset = "0x4604F0", VA = "0x180461EF0", Slot = "40")]
	protected override void AttributeEvent()
	{
		int num = 0;
		ulong num2;
		base.Recover(50f, (DamageType)num, true, num2 != 0UL);
		base.AttributeCountdown = 3f;
	}

	// Token: 0x06001322 RID: 4898 RVA: 0x0006BDE8 File Offset: 0x00069FE8
	[Token(Token = "0x6001322")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "33")]
	protected override bool Instead(int theDamage)
	{
		return false;
	}

	// Token: 0x06001323 RID: 4899 RVA: 0x0006BDF8 File Offset: 0x00069FF8
	[Token(Token = "0x6001323")]
	[Address(RVA = "0x461F40", Offset = "0x460540", VA = "0x180461F40", Slot = "32")]
	protected override int GetDamage(int damage)
	{
		return base.GetDamage(damage);
	}

	// Token: 0x06001324 RID: 4900 RVA: 0x0006BE10 File Offset: 0x0006A010
	[Token(Token = "0x6001324")]
	[Address(RVA = "0x461FA0", Offset = "0x4605A0", VA = "0x180461FA0", Slot = "29")]
	protected override void ReplaceSprite()
	{
		CrackStatus crackStatus;
		if (crackStatus != CrackStatus.Good)
		{
			if (crackStatus != CrackStatus.Good)
			{
				if (crackStatus == CrackStatus.Normal)
				{
					GameObject gameObject = this.head1;
					int num = 0;
					gameObject.SetActive(num != 0);
					GameObject gameObject2 = this.head2;
					int num2 = 0;
					gameObject2.SetActive(num2 != 0);
					return;
				}
				return;
			}
			else
			{
				GameObject gameObject3 = this.head1;
			}
		}
		ulong num3;
		this.head1.SetActive(num3 != 0UL);
		ulong num4;
		this.head2.SetActive(num4 != 0UL);
	}

	// Token: 0x06001325 RID: 4901 RVA: 0x0006BE78 File Offset: 0x0006A078
	[Token(Token = "0x6001325")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public PuffPumpkin()
	{
	}

	// Token: 0x04000C4B RID: 3147
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C4B")]
	public GameObject head1;

	// Token: 0x04000C4C RID: 3148
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000C4C")]
	public GameObject head2;
}
