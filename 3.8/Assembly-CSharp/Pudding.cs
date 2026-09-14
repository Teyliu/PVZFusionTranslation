using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200040A RID: 1034
[Token(Token = "0x200040A")]
public class Pudding : TorchWood
{
	// Token: 0x0600131B RID: 4891 RVA: 0x0006BCB8 File Offset: 0x00069EB8
	[Token(Token = "0x600131B")]
	[Address(RVA = "0x4309E0", Offset = "0x42EFE0", VA = "0x1804309E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x0600131C RID: 4892 RVA: 0x0006BCD8 File Offset: 0x00069ED8
	[Token(Token = "0x600131C")]
	[Address(RVA = "0x461D80", Offset = "0x460380", VA = "0x180461D80", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.AttributeCountdown = 1.5f;
		this.attributeCount = (int)((ulong)0L);
	}

	// Token: 0x0600131D RID: 4893 RVA: 0x0006BCFC File Offset: 0x00069EFC
	[Token(Token = "0x600131D")]
	[Address(RVA = "0x461DB0", Offset = "0x4603B0", VA = "0x180461DB0", Slot = "69")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
		int num = 0;
		if (collision.TryGetComponent<Bullet>(num) && base.CheckFire(num))
		{
			int num2 = this.attributeCount;
			num2++;
			this.attributeCount = num2;
			if (num2 < 30)
			{
				int thePlantRow = this.thePlantRow;
				num += 136;
				this.anim.SetTrigger("rise");
				this.theStatus = (PlantStatus)((ulong)25L);
			}
		}
	}

	// Token: 0x0600131E RID: 4894 RVA: 0x0006BD68 File Offset: 0x00069F68
	[Token(Token = "0x600131E")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public Pudding()
	{
	}
}
