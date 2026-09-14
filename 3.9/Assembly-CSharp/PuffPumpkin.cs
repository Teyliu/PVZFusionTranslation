using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000426 RID: 1062
[Token(Token = "0x2000426")]
public class PuffPumpkin : Pumpkin
{
	// Token: 0x06001395 RID: 5013 RVA: 0x0006DC14 File Offset: 0x0006BE14
	[Token(Token = "0x6001395")]
	[Address(RVA = "0x47E710", Offset = "0x47CD10", VA = "0x18047E710", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 3f;
	}

	// Token: 0x06001396 RID: 5014 RVA: 0x0006DC34 File Offset: 0x0006BE34
	[Token(Token = "0x6001396")]
	[Address(RVA = "0x4B8750", Offset = "0x4B6D50", VA = "0x1804B8750", Slot = "15")]
	protected override void Start()
	{
		int thePlantMaxHealth = this.thePlantMaxHealth;
		this.thePlantHealth = thePlantMaxHealth;
		base.Start();
	}

	// Token: 0x06001397 RID: 5015 RVA: 0x0006DC58 File Offset: 0x0006BE58
	[Token(Token = "0x6001397")]
	[Address(RVA = "0x4B85E0", Offset = "0x4B6BE0", VA = "0x1804B85E0", Slot = "39")]
	protected override void AttributeEvent()
	{
		int num = 0;
		ulong num2;
		base.Recover(50f, (DamageType)num, true, num2 != 0UL);
		base.AttributeCountdown = 3f;
	}

	// Token: 0x06001398 RID: 5016 RVA: 0x0006DC80 File Offset: 0x0006BE80
	[Token(Token = "0x6001398")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "32")]
	protected override bool Instead(int theDamage)
	{
		return false;
	}

	// Token: 0x06001399 RID: 5017 RVA: 0x0006DC90 File Offset: 0x0006BE90
	[Token(Token = "0x6001399")]
	[Address(RVA = "0x4B8630", Offset = "0x4B6C30", VA = "0x1804B8630", Slot = "31")]
	protected override int GetDamage(int damage)
	{
		return base.GetDamage(damage);
	}

	// Token: 0x0600139A RID: 5018 RVA: 0x0006DCA8 File Offset: 0x0006BEA8
	[Token(Token = "0x600139A")]
	[Address(RVA = "0x4B8690", Offset = "0x4B6C90", VA = "0x1804B8690", Slot = "28")]
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

	// Token: 0x0600139B RID: 5019 RVA: 0x0006DD10 File Offset: 0x0006BF10
	[Token(Token = "0x600139B")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public PuffPumpkin()
	{
	}

	// Token: 0x04000CC6 RID: 3270
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000CC6")]
	public GameObject head1;

	// Token: 0x04000CC7 RID: 3271
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000CC7")]
	public GameObject head2;
}
