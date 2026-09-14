using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000659 RID: 1625
[Token(Token = "0x2000659")]
public class Drown_a : Zombie
{
	// Token: 0x06001EF3 RID: 7923 RVA: 0x000A5100 File Offset: 0x000A3300
	[Token(Token = "0x6001EF3")]
	[Address(RVA = "0x541BE0", Offset = "0x5401E0", VA = "0x180541BE0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)30L);
		int num = global::UnityEngine.Random.Range(6, 9);
	}

	// Token: 0x06001EF4 RID: 7924 RVA: 0x000A5128 File Offset: 0x000A3328
	[Token(Token = "0x6001EF4")]
	[Address(RVA = "0x541B70", Offset = "0x540170", VA = "0x180541B70", Slot = "23")]
	protected override void AttributeEvent()
	{
		int num = 0;
		base.ChangeStatus((ZombieStatus)num);
		this.anim.SetTrigger("throw");
	}

	// Token: 0x06001EF5 RID: 7925 RVA: 0x000A5158 File Offset: 0x000A3358
	[Token(Token = "0x6001EF5")]
	[Address(RVA = "0x541D00", Offset = "0x540300", VA = "0x180541D00")]
	protected DrownProjectile GetDrownWeapon()
	{
		GameObject gameObject = Resources.Load<GameObject>("Zombies/Zombie_drown/weapon");
		Transform shoot = this.shoot;
		Vector3 vector;
		float z = vector.z;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		DrownProjectile drownProjectile = gameObject2.AddComponent<DrownProjectile>();
		int theZombieRow = this.theZombieRow;
		drownProjectile.theRow = theZombieRow;
		return drownProjectile;
	}

	// Token: 0x06001EF6 RID: 7926 RVA: 0x000A51B0 File Offset: 0x000A33B0
	[Token(Token = "0x6001EF6")]
	[Address(RVA = "0x5418A0", Offset = "0x53FEA0", VA = "0x1805418A0", Slot = "74")]
	protected virtual void AnimThrow()
	{
		int num;
		ulong num2;
		do
		{
			DrownProjectile drownWeapon = this.GetDrownWeapon();
			num = 0;
			Board board = this.board;
			if (num >= board.columnNum)
			{
				return;
			}
			int theZombieRow = this.theZombieRow;
			List<Plant> list = Lawnf.Get1x1Plants(num, theZombieRow);
			bool flag;
			if (flag)
			{
				Transform axis = this.axis;
				Transform shoot = this.shoot;
				Vector3 vector;
				float z = vector.z;
			}
		}
		while (num2 != (ulong)0L);
		num++;
	}

	// Token: 0x06001EF7 RID: 7927 RVA: 0x000A5238 File Offset: 0x000A3438
	[Token(Token = "0x6001EF7")]
	[Address(RVA = "0x541CC0", Offset = "0x5402C0", VA = "0x180541CC0")]
	public static bool CheckPlant(Plant plant)
	{
		if (!plant.invincible && plant.plantTag == (ulong)0L)
		{
			bool flag;
			return flag;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001EF8 RID: 7928 RVA: 0x000A5264 File Offset: 0x000A3464
	[Token(Token = "0x6001EF8")]
	[Address(RVA = "0x51A5B0", Offset = "0x518BB0", VA = "0x18051A5B0", Slot = "61")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x06001EF9 RID: 7929 RVA: 0x000A5274 File Offset: 0x000A3474
	[Token(Token = "0x6001EF9")]
	[Address(RVA = "0x541C20", Offset = "0x540220", VA = "0x180541C20", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06001EFA RID: 7930 RVA: 0x000A52B4 File Offset: 0x000A34B4
	[Token(Token = "0x6001EFA")]
	[Address(RVA = "0x541E90", Offset = "0x540490", VA = "0x180541E90")]
	public Drown_a()
	{
	}
}
