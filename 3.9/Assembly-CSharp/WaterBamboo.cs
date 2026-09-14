using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004BE RID: 1214
[Token(Token = "0x20004BE")]
public class WaterBamboo : Bamboo
{
	// Token: 0x060016BB RID: 5819 RVA: 0x0007D3E0 File Offset: 0x0007B5E0
	[Token(Token = "0x60016BB")]
	[Address(RVA = "0x51BE50", Offset = "0x51A450", VA = "0x18051BE50", Slot = "68")]
	protected override void CrashWithZombie(Zombie zombie, float x)
	{
		int num = 0;
		if (zombie.HasBuff((EffectType)num))
		{
			zombie.AttributeEvent();
		}
		base.CrashWithZombie(zombie, x);
	}

	// Token: 0x060016BC RID: 5820 RVA: 0x0007D410 File Offset: 0x0007B610
	[Token(Token = "0x60016BC")]
	[Address(RVA = "0x51BEE0", Offset = "0x51A4E0", VA = "0x18051BEE0", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x060016BD RID: 5821 RVA: 0x0007D430 File Offset: 0x0007B630
	[Token(Token = "0x60016BD")]
	[Address(RVA = "0x51C020", Offset = "0x51A620", VA = "0x18051C020", Slot = "24")]
	public override void UpdateText()
	{
		base.UpdateText();
		GameObject gameObject = this.ice;
		int num = 0;
		if (gameObject != num)
		{
			this.ice.SetActive(num != 0);
		}
	}

	// Token: 0x060016BE RID: 5822 RVA: 0x0007D468 File Offset: 0x0007B668
	[Token(Token = "0x60016BE")]
	[Address(RVA = "0x4A12B0", Offset = "0x49F8B0", VA = "0x1804A12B0", Slot = "58")]
	public override void InfluenceByIceShroom()
	{
	}

	// Token: 0x060016BF RID: 5823 RVA: 0x0007D478 File Offset: 0x0007B678
	[Token(Token = "0x60016BF")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public WaterBamboo()
	{
	}

	// Token: 0x04000E09 RID: 3593
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000E09")]
	public GameObject ice;
}
