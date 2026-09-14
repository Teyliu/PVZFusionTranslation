using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200054E RID: 1358
[Token(Token = "0x200054E")]
public class ScaredFume : Shooter
{
	// Token: 0x06001936 RID: 6454 RVA: 0x00088278 File Offset: 0x00086478
	[Token(Token = "0x6001936")]
	[Address(RVA = "0x4DDA90", Offset = "0x4DC090", VA = "0x1804DDA90", Slot = "69")]
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

	// Token: 0x06001937 RID: 6455 RVA: 0x000882D4 File Offset: 0x000864D4
	[Token(Token = "0x6001937")]
	[Address(RVA = "0x4DD150", Offset = "0x4DB750", VA = "0x1804DD150")]
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

	// Token: 0x06001938 RID: 6456 RVA: 0x0008838C File Offset: 0x0008658C
	[Token(Token = "0x6001938")]
	[Address(RVA = "0x4DCEB0", Offset = "0x4DB4B0", VA = "0x1804DCEB0")]
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

	// Token: 0x06001939 RID: 6457 RVA: 0x00088420 File Offset: 0x00086620
	[Token(Token = "0x6001939")]
	[Address(RVA = "0x4DD570", Offset = "0x4DBB70", VA = "0x1804DD570", Slot = "45")]
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

	// Token: 0x0600193A RID: 6458 RVA: 0x00088494 File Offset: 0x00086694
	[Token(Token = "0x600193A")]
	[Address(RVA = "0x4DD6C0", Offset = "0x4DBCC0", VA = "0x1804DD6C0", Slot = "44")]
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

	// Token: 0x0600193B RID: 6459 RVA: 0x0008852C File Offset: 0x0008672C
	[Token(Token = "0x600193B")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public ScaredFume()
	{
	}

	// Token: 0x04000E3A RID: 3642
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E3A")]
	private int shootType;
}
