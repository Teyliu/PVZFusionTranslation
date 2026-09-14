using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200068F RID: 1679
[Token(Token = "0x200068F")]
public class Drown_a : Zombie
{
	// Token: 0x06001FF5 RID: 8181 RVA: 0x000A987C File Offset: 0x000A7A7C
	[Token(Token = "0x6001FF5")]
	[Address(RVA = "0x5A4340", Offset = "0x5A2940", VA = "0x1805A4340", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)30L);
		int num = global::UnityEngine.Random.Range(6, 9);
	}

	// Token: 0x06001FF6 RID: 8182 RVA: 0x000A98A4 File Offset: 0x000A7AA4
	[Token(Token = "0x6001FF6")]
	[Address(RVA = "0x5A42D0", Offset = "0x5A28D0", VA = "0x1805A42D0", Slot = "24")]
	protected override void AttributeEvent()
	{
		int num = 0;
		base.ChangeStatus((ZombieStatus)num);
		this.anim.SetTrigger("throw");
	}

	// Token: 0x06001FF7 RID: 8183 RVA: 0x000A98D4 File Offset: 0x000A7AD4
	[Token(Token = "0x6001FF7")]
	[Address(RVA = "0x5A4460", Offset = "0x5A2A60", VA = "0x1805A4460")]
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

	// Token: 0x06001FF8 RID: 8184 RVA: 0x000A992C File Offset: 0x000A7B2C
	[Token(Token = "0x6001FF8")]
	[Address(RVA = "0x5A4000", Offset = "0x5A2600", VA = "0x1805A4000", Slot = "76")]
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

	// Token: 0x06001FF9 RID: 8185 RVA: 0x000A99B4 File Offset: 0x000A7BB4
	[Token(Token = "0x6001FF9")]
	[Address(RVA = "0x5A4420", Offset = "0x5A2A20", VA = "0x1805A4420")]
	public static bool CheckPlant(Plant plant)
	{
		if (!plant.invincible && plant.plantTag == (ulong)0L)
		{
			bool flag;
			return flag;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001FFA RID: 8186 RVA: 0x000A99E0 File Offset: 0x000A7BE0
	[Token(Token = "0x6001FFA")]
	[Address(RVA = "0x586A30", Offset = "0x585030", VA = "0x180586A30", Slot = "63")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x06001FFB RID: 8187 RVA: 0x000A99F0 File Offset: 0x000A7BF0
	[Token(Token = "0x6001FFB")]
	[Address(RVA = "0x5A4380", Offset = "0x5A2980", VA = "0x1805A4380", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06001FFC RID: 8188 RVA: 0x000A9A30 File Offset: 0x000A7C30
	[Token(Token = "0x6001FFC")]
	[Address(RVA = "0x5A45F0", Offset = "0x5A2BF0", VA = "0x1805A45F0")]
	public Drown_a()
	{
	}
}
