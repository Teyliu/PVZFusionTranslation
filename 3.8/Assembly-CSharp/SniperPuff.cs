using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200055B RID: 1371
[Token(Token = "0x200055B")]
public class SniperPuff : Shooter
{
	// Token: 0x0600197E RID: 6526 RVA: 0x00089914 File Offset: 0x00087B14
	[Token(Token = "0x600197E")]
	[Address(RVA = "0x4E1A40", Offset = "0x4E0040", VA = "0x1804E1A40", Slot = "40")]
	protected override void AttributeEvent()
	{
		Animator anim = this.anim;
		int num = 0;
		anim.SetBool("gather", num != 0);
		this.theStatus = (PlantStatus)((ulong)0L);
	}

	// Token: 0x0600197F RID: 6527 RVA: 0x00089948 File Offset: 0x00087B48
	[Token(Token = "0x600197F")]
	[Address(RVA = "0x4E1BA0", Offset = "0x4E01A0", VA = "0x1804E1BA0", Slot = "44")]
	protected override GameObject SearchZombie()
	{
		for (;;)
		{
			int num = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			ulong num3;
			if (flag)
			{
				int num2 = 0;
				if (num != num2)
				{
					int thePlantRow = this.thePlantRow;
					float vision = this.vision;
					Transform axis = this.axis;
					if (this.CheckZombie(num))
					{
						break;
					}
				}
			}
			else if (num3 == (ulong)0L)
			{
				goto Block_3;
			}
		}
		GameObject gameObject;
		return gameObject;
		Block_3:
		throw new NullReferenceException();
	}

	// Token: 0x06001980 RID: 6528 RVA: 0x000899C4 File Offset: 0x00087BC4
	[Token(Token = "0x6001980")]
	[Address(RVA = "0x4E1DE0", Offset = "0x4E03E0", VA = "0x1804E1DE0", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform axis = this.axis;
		Board board = this.board;
		Vector3 vector;
		float z = vector.z;
		int num = 0;
		Zombie zombie;
		if (zombie != num)
		{
			ParticleManager instance = ParticleManager.Instance;
			Collider2D col = zombie.col;
			int num2 = 0;
			int theZombieRow = zombie.theZombieRow;
			int num3 = 0;
			int num4 = 0;
			ulong num5;
			Particle particle = instance.SetParticle((ParticleType)num4, num2, theZombieRow, num5 != 0UL, (float)num3);
			int num6 = this.shootCount;
			num6++;
			this.shootCount = num6;
			if (num6 != 6)
			{
			}
			this.shootCount = (int)((ulong)0L);
			PlantType thePlantType = this.thePlantType;
			ulong num7;
			zombie.TakeDamage(1000000, this, (DamageType)((uint)14), thePlantType, num7 != 0UL);
			GameAPP.PlaySound(40, 0.2f, 1f);
			int num8 = this.attributeCount;
			num8++;
			this.attributeCount = num8;
			this.anim.SetBool("gather", true);
			base.AttributeCountdown = 15f;
			this.attributeCount = (int)((ulong)0L);
			this.theStatus = (PlantStatus)((ulong)25L);
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001981 RID: 6529 RVA: 0x00089AD0 File Offset: 0x00087CD0
	[Token(Token = "0x6001981")]
	[Address(RVA = "0x4E24F0", Offset = "0x4E0AF0", VA = "0x1804E24F0", Slot = "46")]
	protected override void UpdateAttackCountDown()
	{
		float thePlantAttackCountDown = this.thePlantAttackCountDown;
		this.thePlantAttackCountDown = thePlantAttackCountDown;
		base.UpdateAttackCountDown();
	}

	// Token: 0x06001982 RID: 6530 RVA: 0x00089AF4 File Offset: 0x00087CF4
	[Token(Token = "0x6001982")]
	[Address(RVA = "0x4E2090", Offset = "0x4E0690", VA = "0x1804E2090", Slot = "70")]
	protected override Bullet Shoot2()
	{
		Transform axis = this.axis;
		Board board = this.board;
		Vector3 vector;
		float z = vector.z;
		int num = 0;
		Zombie zombie;
		if (zombie != num)
		{
			Transform axis2 = zombie.axis;
			Vector3 vector2;
			float z2 = vector2.z;
			int num2 = this.zombieLayer;
			int num3 = 0;
			int num4 = 0;
			Collider2D[] array;
			if (num3 < array.Length)
			{
				bool flag;
				if (flag && typeof(global::UnityEngine.Object).TypeHandle > (ulong)1L)
				{
					if (typeof(global::UnityEngine.Object).TypeHandle <= (ulong)6L)
					{
					}
					bool flag2;
					bool flag3;
					if (!flag2 && flag3)
					{
						PlantType thePlantType = this.thePlantType;
					}
				}
				num4++;
			}
			Collider2D col = zombie.col;
			ParticleManager instance = ParticleManager.Instance;
			uint num5;
			GameAPP.PlaySound((int)num5, 0.2f, 1f);
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001983 RID: 6531 RVA: 0x00089BBC File Offset: 0x00087DBC
	[Token(Token = "0x6001983")]
	[Address(RVA = "0x4E1AA0", Offset = "0x4E00A0", VA = "0x1804E1AA0")]
	private bool CheckZombie(Zombie zombie)
	{
		ZombieStatus theStatus = zombie.theStatus;
		if (typeof(global::UnityEngine.Object).TypeHandle > (ulong)1L)
		{
			if (typeof(global::UnityEngine.Object).TypeHandle <= (ulong)6L)
			{
			}
			if (theStatus != ZombieStatus.Bungi_awake && !zombie.beforeDying && !zombie.isMindControlled)
			{
				Collider2D col = zombie.col;
				int num = 0;
				if (col == num || zombie.col.enabled)
				{
				}
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001984 RID: 6532 RVA: 0x00089C28 File Offset: 0x00087E28
	[Token(Token = "0x6001984")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public SniperPuff()
	{
	}

	// Token: 0x04000E44 RID: 3652
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E44")]
	private int shootCount;
}
