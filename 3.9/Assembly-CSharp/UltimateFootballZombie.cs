using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200072E RID: 1838
[Token(Token = "0x200072E")]
public class UltimateFootballZombie : BlackFootballZombie
{
	// Token: 0x0600246E RID: 9326 RVA: 0x000BDA10 File Offset: 0x000BBC10
	[Token(Token = "0x600246E")]
	[Address(RVA = "0x588720", Offset = "0x586D20", VA = "0x180588720", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 3f;
	}

	// Token: 0x0600246F RID: 9327 RVA: 0x000BDA30 File Offset: 0x000BBC30
	[Token(Token = "0x600246F")]
	[Address(RVA = "0x5FD9F0", Offset = "0x5FBFF0", VA = "0x1805FD9F0", Slot = "16")]
	protected override void Start()
	{
		int num = 0;
		base.Start();
		Board board = this.board;
		Lawnf.SetZombieHealth(this, (float)num);
	}

	// Token: 0x06002470 RID: 9328 RVA: 0x000BDA5C File Offset: 0x000BBC5C
	[Token(Token = "0x6002470")]
	[Address(RVA = "0x5FD6D0", Offset = "0x5FBCD0", VA = "0x1805FD6D0", Slot = "24")]
	protected override void AttributeEvent()
	{
		ulong num6;
		do
		{
			this.attributeCountDown = 3f;
			bool flag;
			if (flag)
			{
				this.attributeCountDown = 1.5f;
			}
			int num = this.theAttackDamage;
			num += num;
			uint num2;
			this.theAttackDamage = (int)num2;
			this.theOriginSpeed = 3f;
			float theOriginSpeed = this.theOriginSpeed;
			this.theOriginSpeed = theOriginSpeed;
			GameObject theFirstArmor = this.theFirstArmor;
			int num3 = 0;
			if (theFirstArmor != num3)
			{
				int num4 = this.theFirstArmorMaxHealth;
				int num5 = this.theFirstArmorHealth;
				num5 += 6000;
				if (num4 >= num5)
				{
					num4 = num5;
				}
				this.theFirstArmorHealth = num4;
				this.FirstArmorBroken();
			}
			List<Plant> allPlants = Lawnf.GetAllPlants();
			bool flag2;
			if (flag2)
			{
			}
		}
		while (num6 != (ulong)0L);
	}

	// Token: 0x06002471 RID: 9329 RVA: 0x000BDB24 File Offset: 0x000BBD24
	[Token(Token = "0x6002471")]
	[Address(RVA = "0x5FD560", Offset = "0x5FBB60", VA = "0x1805FD560", Slot = "70")]
	protected override void AttackEffect(Plant plant)
	{
		base.AttackEffect(plant);
		Transform axis = plant.axis;
		Vector3 vector;
		float z = vector.z;
		Transform axis2 = plant.axis;
		CreateZombie instance = CreateZombie.Instance;
		int num = 0;
		plant.Die((Plant.DieReason)num);
	}

	// Token: 0x06002472 RID: 9330 RVA: 0x000BDB68 File Offset: 0x000BBD68
	[Token(Token = "0x6002472")]
	[Address(RVA = "0x586A30", Offset = "0x585030", VA = "0x180586A30", Slot = "63")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x06002473 RID: 9331 RVA: 0x000BDB78 File Offset: 0x000BBD78
	[Token(Token = "0x6002473")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x06002474 RID: 9332 RVA: 0x000BDB88 File Offset: 0x000BBD88
	[Token(Token = "0x6002474")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06002475 RID: 9333 RVA: 0x000BDB98 File Offset: 0x000BBD98
	[Token(Token = "0x6002475")]
	[Address(RVA = "0x5A9160", Offset = "0x5A7760", VA = "0x1805A9160", Slot = "33")]
	public override long GetDamage(long theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		long num;
		return num;
	}

	// Token: 0x06002476 RID: 9334 RVA: 0x000BDBAC File Offset: 0x000BBDAC
	[Token(Token = "0x6002476")]
	[Address(RVA = "0x5A9020", Offset = "0x5A7620", VA = "0x1805A9020", Slot = "26")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x06002477 RID: 9335 RVA: 0x000BDBBC File Offset: 0x000BBDBC
	[Token(Token = "0x6002477")]
	[Address(RVA = "0x5FD920", Offset = "0x5FBF20", VA = "0x1805FD920", Slot = "31")]
	protected override bool Instead(int damage)
	{
		List<Zombie> certainZombies = Lawnf.GetCertainZombies(this.board, (ZombieType)((uint)254));
		return base.Instead(damage);
	}

	// Token: 0x06002478 RID: 9336 RVA: 0x000BDBF0 File Offset: 0x000BBDF0
	[Token(Token = "0x6002478")]
	[Address(RVA = "0x5FDA40", Offset = "0x5FC040", VA = "0x1805FDA40")]
	public UltimateFootballZombie()
	{
	}
}
