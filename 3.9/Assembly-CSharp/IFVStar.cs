using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000547 RID: 1351
[Token(Token = "0x2000547")]
public class IFVStar : StarFruit
{
	// Token: 0x06001926 RID: 6438 RVA: 0x000885DC File Offset: 0x000867DC
	[Token(Token = "0x6001926")]
	[Address(RVA = "0x52A7C0", Offset = "0x528DC0", VA = "0x18052A7C0", Slot = "15")]
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

	// Token: 0x06001927 RID: 6439 RVA: 0x0008861C File Offset: 0x0008681C
	[Token(Token = "0x6001927")]
	[Address(RVA = "0x52A690", Offset = "0x528C90", VA = "0x18052A690", Slot = "72")]
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

	// Token: 0x06001928 RID: 6440 RVA: 0x00088664 File Offset: 0x00086864
	[Token(Token = "0x6001928")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06001929 RID: 6441 RVA: 0x00088674 File Offset: 0x00086874
	[Token(Token = "0x6001929")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public IFVStar()
	{
	}
}
