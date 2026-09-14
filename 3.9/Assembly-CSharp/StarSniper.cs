using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005A4 RID: 1444
[Token(Token = "0x20005A4")]
public class StarSniper : SniperPea
{
	// Token: 0x06001AB5 RID: 6837 RVA: 0x0008F310 File Offset: 0x0008D510
	[Token(Token = "0x6001AB5")]
	[Address(RVA = "0x546BB0", Offset = "0x5451B0", VA = "0x180546BB0", Slot = "72")]
	protected override void AttackZombie(Zombie zombie, int damage, DamageType theDamageType = DamageType.Shieldless)
	{
		PlantType thePlantType = this.thePlantType;
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = this.ac.transform;
		Vector3 vector;
		float z = vector.z;
		int num = 0;
		int num2 = 0;
		if (theDamageType != DamageType.MaxDamage)
		{
			CreateBullet instance2 = CreateBullet.Instance;
			Transform transform2 = this.ac.transform;
			Transform transform3 = this.ac.transform;
			PlantType thePlantType2 = this.thePlantType;
			Bullet bullet;
			bullet.fromType = thePlantType2;
			int attackDamage = this.attackDamage;
			bullet.Damage = attackDamage;
			Transform transform4 = bullet.transform;
			bullet.transform.Translate(3f, (float)num, (float)num);
			bullet.targetZombie = zombie;
			uint num3;
			num3 += (uint)72;
			return;
		}
		Board board = this.board;
		int num4 = 0;
		BigStar bigStar = board.CreatePassiveMateorite();
		PlantType thePlantType3 = this.thePlantType;
		bigStar.fromType = thePlantType3;
		num4 += num4;
		bigStar.baseDamage = num4;
		int attackDamage2 = this.attackDamage;
		bigStar.bulletDamage = num2;
		throw new NullReferenceException();
	}

	// Token: 0x06001AB6 RID: 6838 RVA: 0x0008F40C File Offset: 0x0008D60C
	[Token(Token = "0x6001AB6")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public StarSniper()
	{
	}
}
