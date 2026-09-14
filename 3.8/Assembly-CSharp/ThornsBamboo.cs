using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000454 RID: 1108
[Token(Token = "0x2000454")]
public class ThornsBamboo : Bamboo
{
	// Token: 0x06001471 RID: 5233 RVA: 0x00072024 File Offset: 0x00070224
	[Token(Token = "0x6001471")]
	[Address(RVA = "0x477490", Offset = "0x475A90", VA = "0x180477490", Slot = "69")]
	protected override void CrashWithZombie(Zombie zombie, float x)
	{
		int num = 0;
		base.CrashWithZombie(zombie, x);
		Transform axis = this.axis;
		CreateBullet instance = CreateBullet.Instance;
		if (18446744073709551613UL > (ulong)2L)
		{
			int attackDamage = this.attackDamage;
			Bullet bullet;
			bullet.Damage = attackDamage;
			PlantType thePlantType = this.thePlantType;
			bullet.fromType = thePlantType;
			Transform transform = bullet.transform;
		}
		int num2 = 0;
		Bullet bullet2;
		bullet2.Damage = num2;
		PlantType thePlantType2 = this.thePlantType;
		int num3 = 0;
		bullet2.fromType = thePlantType2;
		bullet2.transform.rotation = num3;
		num++;
		num += 45;
		ParticleManager instance2 = ParticleManager.Instance;
	}

	// Token: 0x06001472 RID: 5234 RVA: 0x000720C4 File Offset: 0x000702C4
	[Token(Token = "0x6001472")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public ThornsBamboo()
	{
	}
}
