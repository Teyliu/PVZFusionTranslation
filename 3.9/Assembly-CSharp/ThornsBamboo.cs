using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000474 RID: 1140
[Token(Token = "0x2000474")]
public class ThornsBamboo : Bamboo
{
	// Token: 0x06001501 RID: 5377 RVA: 0x00074390 File Offset: 0x00072590
	[Token(Token = "0x6001501")]
	[Address(RVA = "0x4CED40", Offset = "0x4CD340", VA = "0x1804CED40", Slot = "68")]
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

	// Token: 0x06001502 RID: 5378 RVA: 0x00074430 File Offset: 0x00072630
	[Token(Token = "0x6001502")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public ThornsBamboo()
	{
	}
}
