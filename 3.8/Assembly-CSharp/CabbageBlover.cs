using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004C3 RID: 1219
[Token(Token = "0x20004C3")]
public class CabbageBlover : Shooter
{
	// Token: 0x06001708 RID: 5896 RVA: 0x0007EC24 File Offset: 0x0007CE24
	[Token(Token = "0x6001708")]
	[Address(RVA = "0x49B760", Offset = "0x499D60", VA = "0x18049B760", Slot = "44")]
	protected override GameObject SearchZombie()
	{
		Transform axis = this.axis;
		int num = 0;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			GameObject gameObject;
			if (flag)
			{
				int thePlantRow = this.thePlantRow;
				if (Lawnf.InLandStatus((ZombieStatus)num))
				{
					return gameObject;
				}
			}
			num++;
			return gameObject;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001709 RID: 5897 RVA: 0x0007EC74 File Offset: 0x0007CE74
	[Token(Token = "0x6001709")]
	[Address(RVA = "0x49B8D0", Offset = "0x499ED0", VA = "0x18049B8D0", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		uint num;
		uint num2;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num, (int)num2), 0.5f, 1f);
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		uint num3;
		num3 += (uint)2;
		bullet.fromType = thePlantType;
		bullet.Vy = 4f;
		bullet.detaVy = 15f;
		while (num3 <= (uint)2)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600170A RID: 5898 RVA: 0x0007ED04 File Offset: 0x0007CF04
	[Token(Token = "0x600170A")]
	[Address(RVA = "0x41CE10", Offset = "0x41B410", VA = "0x18041CE10", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cabbage;
	}

	// Token: 0x0600170B RID: 5899 RVA: 0x0007ED14 File Offset: 0x0007CF14
	[Token(Token = "0x600170B")]
	[Address(RVA = "0x499DE0", Offset = "0x4983E0", VA = "0x180499DE0")]
	public CabbageBlover()
	{
		this.dreamTime = 0.1f;
		base..ctor();
	}
}
