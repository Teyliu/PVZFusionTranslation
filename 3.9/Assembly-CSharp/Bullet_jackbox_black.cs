using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000161 RID: 353
[Token(Token = "0x2000161")]
public class Bullet_jackbox_black : Bullet
{
	// Token: 0x0600065B RID: 1627 RVA: 0x0002127C File Offset: 0x0001F47C
	[Token(Token = "0x600065B")]
	[Address(RVA = "0x6F3AE0", Offset = "0x6F20E0", VA = "0x1806F3AE0", Slot = "21")]
	protected override void HitPlant(Plant plant)
	{
		if (Lawnf.TravelDebuff((TravelDebuff)((uint)39)))
		{
			CreateZombie instance = CreateZombie.Instance;
			Transform axis = plant.axis;
			int num = 0;
			Zombie zombie;
			if (zombie != num)
			{
				this.board.SetHealthInTravel(zombie);
			}
		}
		Transform transform = base.transform;
		Team <Team>k__BackingField = this.<Team>k__BackingField;
		int damage = this._damage;
		base.Die();
	}

	// Token: 0x0600065C RID: 1628 RVA: 0x000212E4 File Offset: 0x0001F4E4
	[Token(Token = "0x600065C")]
	[Address(RVA = "0x6F3D30", Offset = "0x6F2330", VA = "0x1806F3D30", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		Transform transform = base.transform;
		Team <Team>k__BackingField = this.<Team>k__BackingField;
		int damage = this._damage;
		base.Die();
	}

	// Token: 0x0600065D RID: 1629 RVA: 0x00021314 File Offset: 0x0001F514
	[Token(Token = "0x600065D")]
	[Address(RVA = "0x6F3970", Offset = "0x6F1F70", VA = "0x1806F3970", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Team <Team>k__BackingField = this.<Team>k__BackingField;
		int damage = this._damage;
		base.Die();
	}

	// Token: 0x0600065E RID: 1630 RVA: 0x00021344 File Offset: 0x0001F544
	[Token(Token = "0x600065E")]
	[Address(RVA = "0x6F3920", Offset = "0x6F1F20", VA = "0x1806F3920")]
	private void CursePlant(Plant plant)
	{
		bool flag = Lawnf.TravelDebuff((TravelDebuff)((uint)38));
	}

	// Token: 0x0600065F RID: 1631 RVA: 0x0002135C File Offset: 0x0001F55C
	[Token(Token = "0x600065F")]
	[Address(RVA = "0x6F38D0", Offset = "0x6F1ED0", VA = "0x1806F38D0", Slot = "20")]
	protected override bool Blocked(Plant plant)
	{
		return !Lawnf.TravelDebuff((TravelDebuff)((uint)39)) && base.Blocked(plant);
	}

	// Token: 0x06000660 RID: 1632 RVA: 0x00021380 File Offset: 0x0001F580
	[Token(Token = "0x6000660")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_jackbox_black()
	{
	}
}
