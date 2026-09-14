using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000590 RID: 1424
[Token(Token = "0x2000590")]
public class SolarSunflower : Producer
{
	// Token: 0x06001A79 RID: 6777 RVA: 0x0008E264 File Offset: 0x0008C464
	[Token(Token = "0x6001A79")]
	[Address(RVA = "0x542040", Offset = "0x540640", VA = "0x180542040", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("enter");
	}

	// Token: 0x06001A7A RID: 6778 RVA: 0x0008E290 File Offset: 0x0008C490
	[Token(Token = "0x6001A7A")]
	[Address(RVA = "0x541900", Offset = "0x53FF00", VA = "0x180541900")]
	private void AnimLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform axis = this.axis;
		int num = 0;
		int num2 = 0;
		int thePlantRow = this.thePlantRow;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)128), num, thePlantRow, num3 != 0UL, (float)num2);
		GameAPP.PlaySound(16, 0.5f, 1f);
	}

	// Token: 0x06001A7B RID: 6779 RVA: 0x0008E2E4 File Offset: 0x0008C4E4
	[Token(Token = "0x6001A7B")]
	[Address(RVA = "0x541C70", Offset = "0x540270", VA = "0x180541C70", Slot = "69")]
	protected override void ProduceSun()
	{
		Transform shoot = this.shoot;
		int num = 0;
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
		Transform axis = this.axis;
		Board board = this.board;
		Func<Zombie, bool> func = new Func(this.CheckZombie);
		bool flag;
		if (!flag)
		{
			int num3 = 0;
			CreateItem instance = CreateItem.Instance;
			int thePlantRow = this.thePlantRow;
			int thePlantColumn = this.thePlantColumn;
			uint num4;
			GameObject gameObject = instance.SetCoin(thePlantColumn, thePlantRow, (int)num4, num, num3, num3 != 0);
			return;
		}
		Transform shoot2 = this.shoot;
		CreateBullet instance2 = CreateBullet.Instance;
		Transform shoot3 = this.shoot;
		Bullet bullet;
		Rigidbody2D rb = bullet.rb;
		Board instance3 = Board.Instance;
		int attackDamage = this.attackDamage;
		int num5 = 0;
		int num6 = this.FireBullets();
		num5 += attackDamage;
		bullet.Damage = num5;
		throw new NullReferenceException();
	}

	// Token: 0x06001A7C RID: 6780 RVA: 0x0008E3B0 File Offset: 0x0008C5B0
	[Token(Token = "0x6001A7C")]
	[Address(RVA = "0x5419F0", Offset = "0x53FFF0", VA = "0x1805419F0")]
	private bool CheckZombie(Zombie zombie)
	{
		if (!zombie.isMindControlled)
		{
			Transform axis = zombie.axis;
			float vision = this.vision;
			if (!zombie.beforeDying)
			{
				return zombie.theStatus != ZombieStatus.Dying;
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001A7D RID: 6781 RVA: 0x0008E3F4 File Offset: 0x0008C5F4
	[Token(Token = "0x6001A7D")]
	[Address(RVA = "0x5425E0", Offset = "0x540BE0", VA = "0x1805425E0")]
	private bool TryGetZombie([Out] Zombie zombie)
	{
		Transform axis = this.axis;
		Board board = this.board;
		Func<Zombie, bool> func = new Func(this.CheckZombie);
		bool flag;
		return flag;
	}

	// Token: 0x06001A7E RID: 6782 RVA: 0x0008E428 File Offset: 0x0008C628
	[Token(Token = "0x6001A7E")]
	[Address(RVA = "0x542520", Offset = "0x540B20", VA = "0x180542520", Slot = "42")]
	public override bool SuperSkill()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		int num = 0;
		ulong num2;
		base.Recover(z, (DamageType)num, true, num2 != 0UL);
		this.SuperShoot();
		return true;
	}

	// Token: 0x06001A7F RID: 6783 RVA: 0x0008E464 File Offset: 0x0008C664
	[Token(Token = "0x6001A7F")]
	[Address(RVA = "0x5420A0", Offset = "0x5406A0", VA = "0x1805420A0")]
	private void SuperShoot()
	{
		int num;
		do
		{
			ParticleManager instance = ParticleManager.Instance;
			Transform axis = this.axis;
			num = 0;
			uint num2;
			GameAPP.PlaySound((int)num2, 0.5f, 1f);
			List<Zombie> zombieArray = this.board.zombieArray;
			Func<Zombie, bool> func = delegate(Zombie z)
			{
				int num4 = 0;
				if (z != num4 && !z.isMindControlled)
				{
					Transform axis2 = z.axis;
					float vision = this.vision;
					if (!z.beforeDying)
					{
						return z.theStatus != ZombieStatus.Dying;
					}
				}
				throw new NullReferenceException();
			};
			List<Zombie> list = Enumerable.ToList<Zombie>(Enumerable.Where<Zombie>(zombieArray, func));
			int attackDamage = this.attackDamage;
			int num3 = this.FireBullets();
			bool flag;
			if (flag)
			{
				CreateBullet instance2 = CreateBullet.Instance;
				Transform shoot = this.shoot;
				Transform shoot2 = this.shoot;
				Bullet bullet;
				bullet.cannonPos = 0;
				bullet.cannonPos.y = (float)0;
				Rigidbody2D rb = bullet.rb;
				Board instance3 = Board.Instance;
			}
		}
		while (num != 0);
	}

	// Token: 0x06001A80 RID: 6784 RVA: 0x0008E550 File Offset: 0x0008C750
	[Token(Token = "0x6001A80")]
	[Address(RVA = "0x541A60", Offset = "0x540060", VA = "0x180541A60")]
	private int FireBullets()
	{
		Transform shoot = this.shoot;
		int num = 0;
		Vector3 vector;
		float z = vector.z;
		int num2 = this.bulletLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				Team <Team>k__BackingField = this.<Team>k__BackingField;
				Vector3 vector2;
				float z2 = vector2.z;
				num++;
			}
			num++;
		}
		return num;
	}

	// Token: 0x06001A81 RID: 6785 RVA: 0x0008E5AC File Offset: 0x0008C7AC
	[Token(Token = "0x6001A81")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public SolarSunflower()
	{
	}
}
