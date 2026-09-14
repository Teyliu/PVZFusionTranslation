using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006F6 RID: 1782
[Token(Token = "0x20006F6")]
public class UltimateFootballZombie : BlackFootballZombie
{
	// Token: 0x06002352 RID: 9042 RVA: 0x000B8BCC File Offset: 0x000B6DCC
	[Token(Token = "0x6002352")]
	[Address(RVA = "0x531BD0", Offset = "0x5301D0", VA = "0x180531BD0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 3f;
	}

	// Token: 0x06002353 RID: 9043 RVA: 0x000B8BEC File Offset: 0x000B6DEC
	[Token(Token = "0x6002353")]
	[Address(RVA = "0x5824D0", Offset = "0x580AD0", VA = "0x1805824D0", Slot = "15")]
	protected override void Start()
	{
		int num = 0;
		base.Start();
		Board board = this.board;
		Lawnf.SetZombieHealth(this, (float)num);
	}

	// Token: 0x06002354 RID: 9044 RVA: 0x000B8C18 File Offset: 0x000B6E18
	[Token(Token = "0x6002354")]
	[Address(RVA = "0x581A30", Offset = "0x580030", VA = "0x180581A30", Slot = "23")]
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

	// Token: 0x06002355 RID: 9045 RVA: 0x000B8CE0 File Offset: 0x000B6EE0
	[Token(Token = "0x6002355")]
	[Address(RVA = "0x5818C0", Offset = "0x57FEC0", VA = "0x1805818C0", Slot = "68")]
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

	// Token: 0x06002356 RID: 9046 RVA: 0x000B8D24 File Offset: 0x000B6F24
	[Token(Token = "0x6002356")]
	[Address(RVA = "0x581C80", Offset = "0x580280", VA = "0x180581C80", Slot = "61")]
	protected override void FirstArmorBroken()
	{
		ulong num27;
		do
		{
			bool flag;
			if (flag)
			{
				SpriteRenderer component = this.theFirstArmor.GetComponent<SpriteRenderer>();
				int num = 0;
				component.enabled = num != 0;
				Transform transform = this.theFirstArmor.transform;
				int num2 = 0;
				ulong num3;
				transform.GetChild(num2).gameObject.SetActive(num3 != 0UL);
				uint num4;
				GameObject gameObject = this.theFirstArmor.transform.GetChild((int)num4).gameObject;
				int num5 = 0;
				gameObject.SetActive(num5 != 0);
				List<GameObject> list = this.flags;
				bool flag2;
				if (flag2)
				{
					int num6 = 0;
					SpriteRenderer spriteRenderer;
					spriteRenderer.enabled = num6 != 0;
					int num7 = 0;
					Transform transform2;
					ulong num8;
					transform2.GetChild(num7).gameObject.SetActive(num8 != 0UL);
				}
				ulong num9;
				if (num9 != (ulong)0L)
				{
					goto IL_01E4;
				}
			}
			SpriteRenderer component2 = this.theFirstArmor.GetComponent<SpriteRenderer>();
			int num10 = 0;
			component2.enabled = num10 != 0;
			Transform transform3 = this.theFirstArmor.transform;
			int num11 = 0;
			GameObject gameObject2 = transform3.GetChild(num11).gameObject;
			int num12 = 0;
			gameObject2.SetActive(num12 != 0);
			uint num13;
			ulong num14;
			this.theFirstArmor.transform.GetChild((int)num13).gameObject.SetActive(num14 != 0UL);
			List<GameObject> list2 = this.flags;
			bool flag3;
			if (flag3)
			{
				int num15 = 0;
				SpriteRenderer spriteRenderer2;
				spriteRenderer2.enabled = num15 != 0;
				int num16 = 0;
				Transform transform4;
				ulong num17;
				transform4.GetChild(num16).gameObject.SetActive(num17 != 0UL);
			}
			ulong num18;
			if (num18 != (ulong)0L)
			{
				goto IL_0202;
			}
			SpriteRenderer spriteRenderer3;
			ulong num19;
			spriteRenderer3.enabled = num19 != 0UL;
			int num20 = 0;
			Transform transform5;
			GameObject gameObject3 = transform5.GetChild(num20).gameObject;
			int num21 = 0;
			gameObject3.SetActive(num21 != 0);
			uint num22;
			GameObject gameObject4 = gameObject3.transform.GetChild((int)num22).gameObject;
			int num23 = 0;
			gameObject4.SetActive(num23 != 0);
			bool flag4;
			if (flag4)
			{
				SpriteRenderer spriteRenderer4;
				ulong num24;
				spriteRenderer4.enabled = num24 != 0UL;
				int num25 = 0;
				Transform transform6;
				GameObject gameObject5 = transform6.GetChild(num25).gameObject;
				int num26 = 0;
				gameObject5.SetActive(num26 != 0);
			}
		}
		while (num27 != (ulong)0L);
		return;
		IL_01E4:
		throw new NullReferenceException();
		IL_0202:
		throw new NullReferenceException();
	}

	// Token: 0x06002357 RID: 9047 RVA: 0x000B8F54 File Offset: 0x000B7154
	[Token(Token = "0x6002357")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x06002358 RID: 9048 RVA: 0x000B8F64 File Offset: 0x000B7164
	[Token(Token = "0x6002358")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06002359 RID: 9049 RVA: 0x000B8F74 File Offset: 0x000B7174
	[Token(Token = "0x6002359")]
	[Address(RVA = "0x546F50", Offset = "0x545550", VA = "0x180546F50", Slot = "32")]
	public override int GetDamage(int theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		int num;
		if (num > 5000)
		{
		}
		return num;
	}

	// Token: 0x0600235A RID: 9050 RVA: 0x000B8F90 File Offset: 0x000B7190
	[Token(Token = "0x600235A")]
	[Address(RVA = "0x546D50", Offset = "0x545350", VA = "0x180546D50", Slot = "25")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x0600235B RID: 9051 RVA: 0x000B8FA0 File Offset: 0x000B71A0
	[Token(Token = "0x600235B")]
	[Address(RVA = "0x582400", Offset = "0x580A00", VA = "0x180582400", Slot = "30")]
	protected override bool Instead(int damage)
	{
		List<Zombie> certainZombies = Lawnf.GetCertainZombies(this.board, (ZombieType)((uint)254));
		return base.Instead(damage);
	}

	// Token: 0x0600235C RID: 9052 RVA: 0x000B8FD4 File Offset: 0x000B71D4
	[Token(Token = "0x600235C")]
	[Address(RVA = "0x582520", Offset = "0x580B20", VA = "0x180582520")]
	public UltimateFootballZombie()
	{
		List<GameObject> list = new List();
		this.flags = list;
		base..ctor();
	}

	// Token: 0x0400117E RID: 4478
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x400117E")]
	public List<GameObject> flags;
}
