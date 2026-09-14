using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000657 RID: 1623
[Token(Token = "0x2000657")]
public class DrownZombie : Zombie
{
	// Token: 0x06001EE5 RID: 7909 RVA: 0x000A4E18 File Offset: 0x000A3018
	[Token(Token = "0x6001EE5")]
	[Address(RVA = "0x540FF0", Offset = "0x53F5F0", VA = "0x180540FF0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)30L);
	}

	// Token: 0x06001EE6 RID: 7910 RVA: 0x000A4E38 File Offset: 0x000A3038
	[Token(Token = "0x6001EE6")]
	[Address(RVA = "0x541790", Offset = "0x53FD90", VA = "0x180541790", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int num = global::UnityEngine.Random.Range(5, 10);
	}

	// Token: 0x06001EE7 RID: 7911 RVA: 0x000A4E58 File Offset: 0x000A3058
	[Token(Token = "0x6001EE7")]
	[Address(RVA = "0x5417D0", Offset = "0x53FDD0", VA = "0x1805417D0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		float num = this.throwTime;
		int num2 = 0;
		if (num > (float)num2)
		{
			float deltaTime = Time.deltaTime;
			this.throwTime = num;
			this.StartThrow();
		}
	}

	// Token: 0x06001EE8 RID: 7912 RVA: 0x000A4E90 File Offset: 0x000A3090
	[Token(Token = "0x6001EE8")]
	[Address(RVA = "0x541730", Offset = "0x53FD30", VA = "0x180541730")]
	private void StartThrow()
	{
		int num = 0;
		base.ChangeStatus((ZombieStatus)num);
		this.anim.SetTrigger("throw");
	}

	// Token: 0x06001EE9 RID: 7913 RVA: 0x000A4EBC File Offset: 0x000A30BC
	[Token(Token = "0x6001EE9")]
	[Address(RVA = "0x5410F0", Offset = "0x53F6F0", VA = "0x1805410F0", Slot = "74")]
	protected virtual DrownProjectile GetDrownWeapon()
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

	// Token: 0x06001EEA RID: 7914 RVA: 0x000A4F14 File Offset: 0x000A3114
	[Token(Token = "0x6001EEA")]
	[Address(RVA = "0x540F20", Offset = "0x53F520", VA = "0x180540F20")]
	private void AnimThrow()
	{
		this.Shoot(4);
		if (Lawnf.TravelDebuff((TravelDebuff)((uint)10)))
		{
			this.Shoot(3);
			this.Shoot(5);
		}
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
	}

	// Token: 0x06001EEB RID: 7915 RVA: 0x000A4F5C File Offset: 0x000A315C
	[Token(Token = "0x6001EEB")]
	[Address(RVA = "0x541350", Offset = "0x53F950", VA = "0x180541350")]
	private void Shoot(int mindistance)
	{
		List<Plant> list;
		int num2;
		do
		{
			DrownProjectile drownWeapon = this.GetDrownWeapon();
			list = new List();
			int num = base.Column;
			num -= mindistance;
			num2 = 0;
			int theZombieRow = this.theZombieRow;
			List<Plant> list2 = Lawnf.Get1x1Plants(num, theZombieRow);
			bool flag;
			if (flag)
			{
			}
		}
		while (num2 != 0);
		bool flag2;
		List<Plant> list3;
		if (!flag2)
		{
			Func<Plant, bool> func;
			if (DrownZombie.<>c.<>9__7_0 == 0)
			{
				DrownZombie.<>c.<>9__7_0 = func;
			}
			list3 = Enumerable.ToList<Plant>(Enumerable.OrderByDescending<Plant, bool>(list, func));
		}
		int num3 = list3._size;
		num3 = global::UnityEngine.Random.Range(0, num3);
		Plant plant = list3[num3];
	}

	// Token: 0x06001EEC RID: 7916 RVA: 0x000A4FF8 File Offset: 0x000A31F8
	[Token(Token = "0x6001EEC")]
	[Address(RVA = "0x5410B0", Offset = "0x53F6B0", VA = "0x1805410B0")]
	private bool CheckPlant(Plant plant)
	{
		if (!plant.invincible && plant.plantTag == (ulong)0L)
		{
			bool flag;
			return flag;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001EED RID: 7917 RVA: 0x000A5024 File Offset: 0x000A3224
	[Token(Token = "0x6001EED")]
	[Address(RVA = "0x541280", Offset = "0x53F880", VA = "0x180541280")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int theZombieRow = this.theZombieRow;
			bool flag2;
			if (!flag2)
			{
				this.StartThrow();
			}
		}
	}

	// Token: 0x06001EEE RID: 7918 RVA: 0x000A5050 File Offset: 0x000A3250
	[Token(Token = "0x6001EEE")]
	[Address(RVA = "0x541010", Offset = "0x53F610", VA = "0x180541010", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06001EEF RID: 7919 RVA: 0x000A5090 File Offset: 0x000A3290
	[Token(Token = "0x6001EEF")]
	[Address(RVA = "0x541850", Offset = "0x53FE50", VA = "0x180541850")]
	public DrownZombie()
	{
	}

	// Token: 0x04001066 RID: 4198
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4001066")]
	protected float throwTime;
}
