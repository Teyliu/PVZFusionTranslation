using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000560 RID: 1376
[Token(Token = "0x2000560")]
public class SolarSunflower : Producer
{
	// Token: 0x06001999 RID: 6553 RVA: 0x0008A1DC File Offset: 0x000883DC
	[Token(Token = "0x6001999")]
	[Address(RVA = "0x4E3BD0", Offset = "0x4E21D0", VA = "0x1804E3BD0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("enter");
	}

	// Token: 0x0600199A RID: 6554 RVA: 0x0008A208 File Offset: 0x00088408
	[Token(Token = "0x600199A")]
	[Address(RVA = "0x4E3490", Offset = "0x4E1A90", VA = "0x1804E3490")]
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

	// Token: 0x0600199B RID: 6555 RVA: 0x0008A25C File Offset: 0x0008845C
	[Token(Token = "0x600199B")]
	[Address(RVA = "0x4E3800", Offset = "0x4E1E00", VA = "0x1804E3800", Slot = "70")]
	protected override void ProduceSun()
	{
		Transform shoot = this.shoot;
		int num = 0;
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
		Transform axis = this.axis;
		Board board = this.board;
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

	// Token: 0x0600199C RID: 6556 RVA: 0x0008A31C File Offset: 0x0008851C
	[Token(Token = "0x600199C")]
	[Address(RVA = "0x4E3580", Offset = "0x4E1B80", VA = "0x1804E3580")]
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

	// Token: 0x0600199D RID: 6557 RVA: 0x0008A360 File Offset: 0x00088560
	[Token(Token = "0x600199D")]
	[Address(RVA = "0x4E4170", Offset = "0x4E2770", VA = "0x1804E4170")]
	private bool TryGetZombie([Out] Zombie zombie)
	{
		Transform axis = this.axis;
		Board board = this.board;
		bool flag;
		return flag;
	}

	// Token: 0x0600199E RID: 6558 RVA: 0x0008A388 File Offset: 0x00088588
	[Token(Token = "0x600199E")]
	[Address(RVA = "0x4E40B0", Offset = "0x4E26B0", VA = "0x1804E40B0", Slot = "43")]
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

	// Token: 0x0600199F RID: 6559 RVA: 0x0008A3C4 File Offset: 0x000885C4
	[Token(Token = "0x600199F")]
	[Address(RVA = "0x4E3C30", Offset = "0x4E2230", VA = "0x1804E3C30")]
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
			Func<Zombie, bool> func;
			List<Zombie> list = Enumerable.ToList<Zombie>(Enumerable.Where<Zombie>(this.board.zombieArray, func));
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

	// Token: 0x060019A0 RID: 6560 RVA: 0x0008A49C File Offset: 0x0008869C
	[Token(Token = "0x60019A0")]
	[Address(RVA = "0x4E35F0", Offset = "0x4E1BF0", VA = "0x1804E35F0")]
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

	// Token: 0x060019A1 RID: 6561 RVA: 0x0008A4F8 File Offset: 0x000886F8
	[Token(Token = "0x60019A1")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public SolarSunflower()
	{
	}
}
