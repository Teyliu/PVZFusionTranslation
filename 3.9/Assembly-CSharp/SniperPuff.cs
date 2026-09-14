using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200058A RID: 1418
[Token(Token = "0x200058A")]
public class SniperPuff : Shooter
{
	// Token: 0x06001A5A RID: 6746 RVA: 0x0008D884 File Offset: 0x0008BA84
	[Token(Token = "0x6001A5A")]
	[Address(RVA = "0x53FB50", Offset = "0x53E150", VA = "0x18053FB50", Slot = "39")]
	protected override void AttributeEvent()
	{
		Animator anim = this.anim;
		int num = 0;
		anim.SetBool("gather", num != 0);
		this.theStatus = (PlantStatus)((ulong)0L);
	}

	// Token: 0x06001A5B RID: 6747 RVA: 0x0008D8B8 File Offset: 0x0008BAB8
	[Token(Token = "0x6001A5B")]
	[Address(RVA = "0x53FCB0", Offset = "0x53E2B0", VA = "0x18053FCB0", Slot = "43")]
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

	// Token: 0x06001A5C RID: 6748 RVA: 0x0008D934 File Offset: 0x0008BB34
	[Token(Token = "0x6001A5C")]
	[Address(RVA = "0x53FEF0", Offset = "0x53E4F0", VA = "0x18053FEF0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform axis = this.axis;
		Board board = this.board;
		Vector3 vector;
		float z = vector.z;
		Func<Zombie, bool> func = new Func(this.CheckZombie);
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

	// Token: 0x06001A5D RID: 6749 RVA: 0x0008DA4C File Offset: 0x0008BC4C
	[Token(Token = "0x6001A5D")]
	[Address(RVA = "0x540600", Offset = "0x53EC00", VA = "0x180540600", Slot = "45")]
	protected override void UpdateAttackCountDown()
	{
		float thePlantAttackCountDown = this.thePlantAttackCountDown;
		this.thePlantAttackCountDown = thePlantAttackCountDown;
		base.UpdateAttackCountDown();
	}

	// Token: 0x06001A5E RID: 6750 RVA: 0x0008DA70 File Offset: 0x0008BC70
	[Token(Token = "0x6001A5E")]
	[Address(RVA = "0x5401A0", Offset = "0x53E7A0", VA = "0x1805401A0", Slot = "69")]
	protected override Bullet Shoot2()
	{
		Transform axis = this.axis;
		Board board = this.board;
		Vector3 vector;
		float z = vector.z;
		Func<Zombie, bool> func = new Func(this.CheckZombie);
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

	// Token: 0x06001A5F RID: 6751 RVA: 0x0008DB48 File Offset: 0x0008BD48
	[Token(Token = "0x6001A5F")]
	[Address(RVA = "0x53FBB0", Offset = "0x53E1B0", VA = "0x18053FBB0")]
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

	// Token: 0x06001A60 RID: 6752 RVA: 0x0008DBB4 File Offset: 0x0008BDB4
	[Token(Token = "0x6001A60")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public SniperPuff()
	{
	}

	// Token: 0x04000F02 RID: 3842
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000F02")]
	private int shootCount;
}
