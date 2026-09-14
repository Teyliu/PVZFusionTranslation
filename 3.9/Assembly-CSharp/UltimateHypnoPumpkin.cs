using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000494 RID: 1172
[Token(Token = "0x2000494")]
public class UltimateHypnoPumpkin : HypnoPumpkin
{
	// Token: 0x060015B7 RID: 5559 RVA: 0x00077824 File Offset: 0x00075A24
	[Token(Token = "0x60015B7")]
	[Address(RVA = "0x4E0970", Offset = "0x4DEF70", VA = "0x1804E0970", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1f;
		this.theStatus = (PlantStatus)((ulong)4L);
		float num = global::UnityEngine.Random.Range(6f, 15f);
		this.hypnoTimer = num;
	}

	// Token: 0x060015B8 RID: 5560 RVA: 0x00077864 File Offset: 0x00075A64
	[Token(Token = "0x60015B8")]
	[Address(RVA = "0x4E1330", Offset = "0x4DF930", VA = "0x1804E1330", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int num = 0;
		this.GetEnergy(num);
	}

	// Token: 0x060015B9 RID: 5561 RVA: 0x00077880 File Offset: 0x00075A80
	[Token(Token = "0x60015B9")]
	[Address(RVA = "0x4E13D0", Offset = "0x4DF9D0", VA = "0x1804E13D0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
			this.HypnoUpdate();
			return;
		}
	}

	// Token: 0x060015BA RID: 5562 RVA: 0x000778A4 File Offset: 0x00075AA4
	[Token(Token = "0x60015BA")]
	[Address(RVA = "0x4E0B20", Offset = "0x4DF120", VA = "0x1804E0B20")]
	private void HypnoUpdate()
	{
		for (;;)
		{
			float num = this.hypnoTimer;
			int num2 = 0;
			if (num > (float)num2)
			{
				float deltaTime = Time.deltaTime;
				this.hypnoTimer = num;
				PlantStatus theStatus = this.theStatus;
				if (num2 != (int)num)
				{
					if (num2 != (int)num)
					{
						if (theStatus != PlantStatus.GoldMagnet_attrack)
						{
							goto IL_0058;
						}
						this.hypnoTimer = 6f;
					}
					this.hypnoTimer = 10f;
					goto IL_004D;
				}
				goto IL_004D;
				IL_0058:
				Transform axis = this.axis;
				int num3 = 0;
				List<Plant> plants = MagnetSystem.GetPlants(this);
				bool flag;
				if (flag)
				{
				}
				if (num3 == 0)
				{
					break;
				}
				continue;
				IL_004D:
				this.hypnoTimer = 15f;
				goto IL_0058;
			}
			break;
		}
	}

	// Token: 0x060015BB RID: 5563 RVA: 0x00077938 File Offset: 0x00075B38
	[Token(Token = "0x60015BB")]
	[Address(RVA = "0x4E0E20", Offset = "0x4DF420", VA = "0x1804E0E20")]
	private void HypnoZombie(int theColumn, int theRow, float adder, Vector2 center)
	{
		int num;
		do
		{
			num = 0;
			int num2 = 0;
			UltimateHypnoPumpkin.<>c__DisplayClass7_0 CS$<>8__locals1;
			CS$<>8__locals1.adder = adder;
			LayerMask zombieLayer = this.zombieLayer;
			Collider2D[] array;
			if (num >= array.Length)
			{
				return;
			}
			if (!array[num].TryGetComponent<Zombie>(num) || !Lawnf.InLandStatus((ZombieStatus)num))
			{
				break;
			}
			ParticleManager instance = ParticleManager.Instance;
			List<Plant> list = Lawnf.Get1x1Plants(theColumn, theRow);
			bool flag;
			if (flag)
			{
				UltimateHypnoPumpkin.<>c__DisplayClass7_1 CS$<>8__locals2;
				CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
				CS$<>8__locals2.plant = num2;
				if (CS$<>8__locals2.plant.thePlantType == PlantType.UltimateHypno)
				{
					continue;
				}
				float adder2 = CS$<>8__locals2.CS$<>8__locals1.adder;
				CS$<>8__locals2.plant.ModifyDamage((PlantDamageAdder)((uint)20), adder2, true, num);
				DelayAction delayAction = GameAPP.delayAction;
				Action action = delegate
				{
					Plant plant = CS$<>8__locals2.plant;
					int num3 = 0;
					if (plant != num3)
					{
						UltimateHypnoPumpkin.<>c__DisplayClass7_0 CS$<>8__locals3 = CS$<>8__locals2.CS$<>8__locals1;
						Plant plant2 = CS$<>8__locals2.plant;
						int num4 = 0;
						float adder3 = CS$<>8__locals3.adder;
						plant2.ModifyDamage((PlantDamageAdder)((uint)20), adder3, true, num4);
					}
				};
				delayAction.SetAction(action, 1f);
			}
		}
		while (num != 0);
		num++;
	}

	// Token: 0x060015BC RID: 5564 RVA: 0x00077A2C File Offset: 0x00075C2C
	[Token(Token = "0x60015BC")]
	[Address(RVA = "0x4E06A0", Offset = "0x4DECA0", VA = "0x1804E06A0", Slot = "39")]
	protected override void AttributeEvent()
	{
		for (;;)
		{
			base.AttributeCountdown = 1f;
			Zombie zombie = this.m_zombie;
			int num = 0;
			Zombie zombie2;
			if (zombie != num)
			{
				zombie2 = this.m_zombie;
				bool flag;
				if (!flag)
				{
					long totalFirstHealth = zombie2.TotalFirstHealth;
				}
				long totalFirstHealth2 = zombie2.TotalFirstHealth;
				uint num2;
				this.GetEnergy((int)num2);
			}
			PlantStatus theStatus = this.theStatus;
			if (zombie2 != 0)
			{
				if (zombie2 != 0)
				{
					if (theStatus != PlantStatus.GoldMagnet_attrack)
					{
						goto IL_007E;
					}
					uint num3;
					this.GetEnergy((int)num3);
				}
				uint num4;
				this.GetEnergy((int)num4);
				goto IL_0076;
			}
			goto IL_0076;
			IL_007E:
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
			int num5 = 0;
			bool flag2;
			if (flag2)
			{
			}
			if (num5 == 0)
			{
				break;
			}
			continue;
			IL_0076:
			uint num6;
			this.GetEnergy((int)num6);
			goto IL_007E;
		}
	}

	// Token: 0x060015BD RID: 5565 RVA: 0x00077AE8 File Offset: 0x00075CE8
	[Token(Token = "0x60015BD")]
	[Address(RVA = "0x4E0A30", Offset = "0x4DF030", VA = "0x1804E0A30")]
	private void GetEnergy(int value)
	{
		this.attributeCount = (int)((ulong)0L);
		base.UpdateText();
		bool flag;
		if (flag)
		{
			GameObject gameObject = this.c1;
			this.theStatus = (PlantStatus)((ulong)6L);
			ulong num;
			gameObject.SetActive(num != 0UL);
			ulong num2;
			this.c2.SetActive(num2 != 0UL);
			return;
		}
		GameObject gameObject2 = this.c1;
		this.theStatus = (PlantStatus)((ulong)4L);
		int num3 = 0;
		gameObject2.SetActive(num3 != 0);
		GameObject gameObject3 = this.c2;
		int num4 = 0;
		gameObject3.SetActive(num4 != 0);
	}

	// Token: 0x060015BE RID: 5566 RVA: 0x00077B70 File Offset: 0x00075D70
	[Token(Token = "0x60015BE")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "28")]
	protected override void ReplaceSprite()
	{
	}

	// Token: 0x060015BF RID: 5567 RVA: 0x00077B80 File Offset: 0x00075D80
	[Token(Token = "0x60015BF")]
	[Address(RVA = "0x4E09D0", Offset = "0x4DEFD0", VA = "0x1804E09D0", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (reason == Plant.DieReason.ByShovel)
		{
			Transform axis = this.axis;
			return;
		}
	}

	// Token: 0x060015C0 RID: 5568 RVA: 0x00077BA0 File Offset: 0x00075DA0
	[Token(Token = "0x60015C0")]
	[Address(RVA = "0x4E1260", Offset = "0x4DF860", VA = "0x1804E1260", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x060015C1 RID: 5569 RVA: 0x00077BC0 File Offset: 0x00075DC0
	[Token(Token = "0x60015C1")]
	[Address(RVA = "0x4E1410", Offset = "0x4DFA10", VA = "0x1804E1410")]
	public UltimateHypnoPumpkin()
	{
	}

	// Token: 0x04000D8A RID: 3466
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000D8A")]
	public GameObject c1;

	// Token: 0x04000D8B RID: 3467
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000D8B")]
	public GameObject c2;

	// Token: 0x04000D8C RID: 3468
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000D8C")]
	private float hypnoTimer;
}
