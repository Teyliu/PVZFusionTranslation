using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200015B RID: 347
[Token(Token = "0x200015B")]
public class Bullet_jackbox_black : Bullet
{
	// Token: 0x06000651 RID: 1617 RVA: 0x000218E0 File Offset: 0x0001FAE0
	[Token(Token = "0x6000651")]
	[Address(RVA = "0x6C8210", Offset = "0x6C6810", VA = "0x1806C8210", Slot = "24")]
	protected override void HitPlant(Plant plant)
	{
		Transform transform = base.transform;
		Team <Team>k__BackingField = this.<Team>k__BackingField;
		int damage = this._damage;
		base.Die();
	}

	// Token: 0x06000652 RID: 1618 RVA: 0x00021910 File Offset: 0x0001FB10
	[Token(Token = "0x6000652")]
	[Address(RVA = "0x6C8380", Offset = "0x6C6980", VA = "0x1806C8380", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		Transform transform = base.transform;
		Team <Team>k__BackingField = this.<Team>k__BackingField;
		int damage = this._damage;
		base.Die();
	}

	// Token: 0x06000653 RID: 1619 RVA: 0x00021940 File Offset: 0x0001FB40
	[Token(Token = "0x6000653")]
	[Address(RVA = "0x6C80A0", Offset = "0x6C66A0", VA = "0x1806C80A0", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Team <Team>k__BackingField = this.<Team>k__BackingField;
		int damage = this._damage;
		base.Die();
	}

	// Token: 0x06000654 RID: 1620 RVA: 0x00021970 File Offset: 0x0001FB70
	[Token(Token = "0x6000654")]
	[Address(RVA = "0x532A80", Offset = "0x531080", VA = "0x180532A80")]
	private void CursePlant(Plant plant)
	{
		bool flag = plant.SetEffect((EffectType)((uint)103), 1f, 10f);
	}

	// Token: 0x06000655 RID: 1621 RVA: 0x00021994 File Offset: 0x0001FB94
	[Token(Token = "0x6000655")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_jackbox_black()
	{
	}
}
