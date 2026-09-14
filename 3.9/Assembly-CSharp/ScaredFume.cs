using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200057D RID: 1405
[Token(Token = "0x200057D")]
public class ScaredFume : Shooter
{
	// Token: 0x06001A12 RID: 6674 RVA: 0x0008C1E4 File Offset: 0x0008A3E4
	[Token(Token = "0x6001A12")]
	[Address(RVA = "0x53BB90", Offset = "0x53A190", VA = "0x18053BB90", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		PlantType thePlantType = this.thePlantType;
		Bullet bullet;
		bullet.fromType = thePlantType;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		GameAPP.PlaySound(57, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x06001A13 RID: 6675 RVA: 0x0008C240 File Offset: 0x0008A440
	[Token(Token = "0x6001A13")]
	[Address(RVA = "0x53B250", Offset = "0x539850", VA = "0x18053B250")]
	public void AttackZombie()
	{
		int num2;
		ulong num4;
		do
		{
			int num = 0;
			num2 = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				Transform axis = this.axis;
				Transform axis2 = this.axis;
				if (!base.SearchUniqueZombie(num))
				{
					continue;
				}
				int thePlantRow = this.thePlantRow;
				List<Zombie> zombieList = this.zombieList;
			}
		}
		while (num4 != (ulong)0L);
		int num5 = 0;
		Zombie zombie;
		if (zombie != num5)
		{
		}
		if (num2 != 0)
		{
			uint num6;
			GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num6), 0.5f, 1f);
		}
	}

	// Token: 0x06001A14 RID: 6676 RVA: 0x0008C2F8 File Offset: 0x0008A4F8
	[Token(Token = "0x6001A14")]
	[Address(RVA = "0x53AFB0", Offset = "0x5395B0", VA = "0x18053AFB0")]
	public void AnimShootFume()
	{
		Transform transform = base.transform.Find("Shoot").transform;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = GameAPP.particlePrefab[19];
		Transform transform2 = this.board.transform;
		GameObject gameObject2;
		Renderer component = gameObject2.GetComponent<ParticleSystem>().GetComponent<Renderer>();
		int thePlantRow = this.thePlantRow;
		string text = string.Format("particle{0}", component);
		component.sortingLayerName = text;
		GameAPP.PlaySound(58, 0.5f, 1f);
		this.AttackZombie();
	}

	// Token: 0x06001A15 RID: 6677 RVA: 0x0008C38C File Offset: 0x0008A58C
	[Token(Token = "0x6001A15")]
	[Address(RVA = "0x53B670", Offset = "0x539C70", VA = "0x18053B670", Slot = "44")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float thePlantAttackInterval = this.thePlantAttackInterval;
		this.thePlantAttackCountDown = thePlantAttackInterval;
		GameObject gameObject = this.SearchZombie();
		int num = 0;
		if (!(gameObject != num))
		{
			Zombie zombie = base.SearchBoss();
			int num2 = 0;
			if (!(zombie != num2))
			{
				return;
			}
		}
		Animator anim = this.anim;
		if (this.shootType == 0)
		{
			return;
		}
		anim.SetTrigger("shoot1");
	}

	// Token: 0x06001A16 RID: 6678 RVA: 0x0008C400 File Offset: 0x0008A600
	[Token(Token = "0x6001A16")]
	[Address(RVA = "0x53B7C0", Offset = "0x539DC0", VA = "0x18053B7C0", Slot = "43")]
	protected override GameObject SearchZombie()
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				int thePlantRow = this.thePlantRow;
				float vision = this.vision;
				Transform axis = this.axis;
				if (!base.SearchUniqueZombie(num))
				{
					continue;
				}
			}
		}
		while (num2 != 0);
		int num4 = 0;
		if (!(num2 == num4))
		{
			GameObject gameObject;
			return gameObject;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001A17 RID: 6679 RVA: 0x0008C498 File Offset: 0x0008A698
	[Token(Token = "0x6001A17")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public ScaredFume()
	{
	}

	// Token: 0x04000EF8 RID: 3832
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000EF8")]
	private int shootType;
}
