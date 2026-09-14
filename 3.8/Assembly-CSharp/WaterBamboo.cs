using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200049C RID: 1180
[Token(Token = "0x200049C")]
public class WaterBamboo : Bamboo
{
	// Token: 0x0600161B RID: 5659 RVA: 0x0007A96C File Offset: 0x00078B6C
	[Token(Token = "0x600161B")]
	[Address(RVA = "0x4AD680", Offset = "0x4ABC80", VA = "0x1804AD680", Slot = "69")]
	protected override void CrashWithZombie(Zombie zombie, float x)
	{
		int num = 0;
		if (zombie.HasBuff((EffectType)num))
		{
		}
		base.CrashWithZombie(zombie, x);
	}

	// Token: 0x0600161C RID: 5660 RVA: 0x0007A994 File Offset: 0x00078B94
	[Token(Token = "0x600161C")]
	[Address(RVA = "0x4AD710", Offset = "0x4ABD10", VA = "0x1804AD710", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x0600161D RID: 5661 RVA: 0x0007A9B4 File Offset: 0x00078BB4
	[Token(Token = "0x600161D")]
	[Address(RVA = "0x4AD850", Offset = "0x4ABE50", VA = "0x1804AD850", Slot = "25")]
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

	// Token: 0x0600161E RID: 5662 RVA: 0x0007A9EC File Offset: 0x00078BEC
	[Token(Token = "0x600161E")]
	[Address(RVA = "0x44CAF0", Offset = "0x44B0F0", VA = "0x18044CAF0", Slot = "59")]
	public override void InfluenceByIceShroom()
	{
	}

	// Token: 0x0600161F RID: 5663 RVA: 0x0007A9FC File Offset: 0x00078BFC
	[Token(Token = "0x600161F")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public WaterBamboo()
	{
	}

	// Token: 0x04000D70 RID: 3440
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000D70")]
	public GameObject ice;
}
