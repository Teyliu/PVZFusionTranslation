using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005A9 RID: 1449
[Token(Token = "0x20005A9")]
public class SuperCherryShooter : Shooter
{
	// Token: 0x06001AC5 RID: 6853 RVA: 0x0008F808 File Offset: 0x0008DA08
	[Token(Token = "0x6001AC5")]
	[Address(RVA = "0x547C20", Offset = "0x546220", VA = "0x180547C20", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		int num = 0;
		bool flag;
		if (flag)
		{
			int num2 = bullet._damage;
			num2 -= num;
			bullet.Damage = num2;
		}
		return bullet;
	}

	// Token: 0x06001AC6 RID: 6854 RVA: 0x0008F874 File Offset: 0x0008DA74
	[Token(Token = "0x6001AC6")]
	[Address(RVA = "0x547D70", Offset = "0x546370", VA = "0x180547D70", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		if (damageType != DamageType.CherryExplode)
		{
			return;
		}
	}

	// Token: 0x06001AC7 RID: 6855 RVA: 0x0008F888 File Offset: 0x0008DA88
	[Token(Token = "0x6001AC7")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public SuperCherryShooter()
	{
	}
}
