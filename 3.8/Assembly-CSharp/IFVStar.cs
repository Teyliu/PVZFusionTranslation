using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200051A RID: 1306
[Token(Token = "0x200051A")]
public class IFVStar : StarFruit
{
	// Token: 0x06001857 RID: 6231 RVA: 0x00084A48 File Offset: 0x00082C48
	[Token(Token = "0x6001857")]
	[Address(RVA = "0x4CE400", Offset = "0x4CCA00", VA = "0x1804CE400", Slot = "15")]
	protected override void Start()
	{
		int num;
		do
		{
			base.Start();
			if (!Lawnf.TravelAdvanced((AdvBuff)((uint)34)))
			{
				break;
			}
			List<Plant> plants = MagnetSystem.GetPlants(this);
			num = 0;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x06001858 RID: 6232 RVA: 0x00084A88 File Offset: 0x00082C88
	[Token(Token = "0x6001858")]
	[Address(RVA = "0x4CE2D0", Offset = "0x4CC8D0", VA = "0x1804CE2D0", Slot = "73")]
	protected override void SetBullet(Transform _transform, BulletMoveWay theMovingWay)
	{
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		Transform transform = bullet.transform;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x06001859 RID: 6233 RVA: 0x00084AD0 File Offset: 0x00082CD0
	[Token(Token = "0x6001859")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x0600185A RID: 6234 RVA: 0x00084AE0 File Offset: 0x00082CE0
	[Token(Token = "0x600185A")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public IFVStar()
	{
	}
}
