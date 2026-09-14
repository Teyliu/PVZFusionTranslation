using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000574 RID: 1396
[Token(Token = "0x2000574")]
public class StarSniper : SniperPea
{
	// Token: 0x060019D5 RID: 6613 RVA: 0x0008B25C File Offset: 0x0008945C
	[Token(Token = "0x60019D5")]
	[Address(RVA = "0x4E74D0", Offset = "0x4E5AD0", VA = "0x1804E74D0", Slot = "73")]
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

	// Token: 0x060019D6 RID: 6614 RVA: 0x0008B358 File Offset: 0x00089558
	[Token(Token = "0x60019D6")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public StarSniper()
	{
	}
}
