using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200068D RID: 1677
[Token(Token = "0x200068D")]
public class DrownZombie : Zombie
{
	// Token: 0x06001FE7 RID: 8167 RVA: 0x000A9584 File Offset: 0x000A7784
	[Token(Token = "0x6001FE7")]
	[Address(RVA = "0x5A3750", Offset = "0x5A1D50", VA = "0x1805A3750", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)30L);
	}

	// Token: 0x06001FE8 RID: 8168 RVA: 0x000A95A4 File Offset: 0x000A77A4
	[Token(Token = "0x6001FE8")]
	[Address(RVA = "0x5A3EF0", Offset = "0x5A24F0", VA = "0x1805A3EF0", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		int num = global::UnityEngine.Random.Range(5, 10);
	}

	// Token: 0x06001FE9 RID: 8169 RVA: 0x000A95C4 File Offset: 0x000A77C4
	[Token(Token = "0x6001FE9")]
	[Address(RVA = "0x5A3F30", Offset = "0x5A2530", VA = "0x1805A3F30", Slot = "17")]
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

	// Token: 0x06001FEA RID: 8170 RVA: 0x000A95FC File Offset: 0x000A77FC
	[Token(Token = "0x6001FEA")]
	[Address(RVA = "0x5A3E90", Offset = "0x5A2490", VA = "0x1805A3E90")]
	private void StartThrow()
	{
		int num = 0;
		base.ChangeStatus((ZombieStatus)num);
		this.anim.SetTrigger("throw");
	}

	// Token: 0x06001FEB RID: 8171 RVA: 0x000A9628 File Offset: 0x000A7828
	[Token(Token = "0x6001FEB")]
	[Address(RVA = "0x5A3850", Offset = "0x5A1E50", VA = "0x1805A3850", Slot = "76")]
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

	// Token: 0x06001FEC RID: 8172 RVA: 0x000A9680 File Offset: 0x000A7880
	[Token(Token = "0x6001FEC")]
	[Address(RVA = "0x5A3680", Offset = "0x5A1C80", VA = "0x1805A3680")]
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

	// Token: 0x06001FED RID: 8173 RVA: 0x000A96C8 File Offset: 0x000A78C8
	[Token(Token = "0x6001FED")]
	[Address(RVA = "0x5A3AB0", Offset = "0x5A20B0", VA = "0x1805A3AB0")]
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
				func = (Plant p) => p.thePlantType == PlantType.SuperUmbrella || p.thePlantType == PlantType.EmeraldUmbrella;
				DrownZombie.<>c.<>9__7_0 = func;
			}
			list3 = Enumerable.ToList<Plant>(Enumerable.OrderByDescending<Plant, bool>(list, func));
		}
		int num3 = list3._size;
		num3 = global::UnityEngine.Random.Range(0, num3);
		Plant plant = list3[num3];
	}

	// Token: 0x06001FEE RID: 8174 RVA: 0x000A9774 File Offset: 0x000A7974
	[Token(Token = "0x6001FEE")]
	[Address(RVA = "0x5A3810", Offset = "0x5A1E10", VA = "0x1805A3810")]
	private bool CheckPlant(Plant plant)
	{
		if (!plant.invincible && plant.plantTag == (ulong)0L)
		{
			bool flag;
			return flag;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001FEF RID: 8175 RVA: 0x000A97A0 File Offset: 0x000A79A0
	[Token(Token = "0x6001FEF")]
	[Address(RVA = "0x5A39E0", Offset = "0x5A1FE0", VA = "0x1805A39E0")]
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

	// Token: 0x06001FF0 RID: 8176 RVA: 0x000A97CC File Offset: 0x000A79CC
	[Token(Token = "0x6001FF0")]
	[Address(RVA = "0x5A3770", Offset = "0x5A1D70", VA = "0x1805A3770", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06001FF1 RID: 8177 RVA: 0x000A980C File Offset: 0x000A7A0C
	[Token(Token = "0x6001FF1")]
	[Address(RVA = "0x5A3FB0", Offset = "0x5A25B0", VA = "0x1805A3FB0")]
	public DrownZombie()
	{
	}

	// Token: 0x04001132 RID: 4402
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001132")]
	protected float throwTime;
}
