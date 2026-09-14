using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000472 RID: 1138
[Token(Token = "0x2000472")]
public class UltimateHypnoPumpkin : HypnoPumpkin
{
	// Token: 0x06001518 RID: 5400 RVA: 0x00074EA0 File Offset: 0x000730A0
	[Token(Token = "0x6001518")]
	[Address(RVA = "0x487560", Offset = "0x485B60", VA = "0x180487560", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1f;
		this.theStatus = (PlantStatus)((ulong)4L);
		float num = global::UnityEngine.Random.Range(6f, 15f);
		this.hypnoTimer = num;
	}

	// Token: 0x06001519 RID: 5401 RVA: 0x00074EE0 File Offset: 0x000730E0
	[Token(Token = "0x6001519")]
	[Address(RVA = "0x487F20", Offset = "0x486520", VA = "0x180487F20", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int num = 0;
		this.GetEnergy(num);
	}

	// Token: 0x0600151A RID: 5402 RVA: 0x00074EFC File Offset: 0x000730FC
	[Token(Token = "0x600151A")]
	[Address(RVA = "0x487FC0", Offset = "0x4865C0", VA = "0x180487FC0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
			this.HypnoUpdate();
			return;
		}
	}

	// Token: 0x0600151B RID: 5403 RVA: 0x00074F20 File Offset: 0x00073120
	[Token(Token = "0x600151B")]
	[Address(RVA = "0x487710", Offset = "0x485D10", VA = "0x180487710")]
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

	// Token: 0x0600151C RID: 5404 RVA: 0x00074FB4 File Offset: 0x000731B4
	[Token(Token = "0x600151C")]
	[Address(RVA = "0x487A10", Offset = "0x486010", VA = "0x180487A10")]
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

	// Token: 0x0600151D RID: 5405 RVA: 0x000750A8 File Offset: 0x000732A8
	[Token(Token = "0x600151D")]
	[Address(RVA = "0x4872B0", Offset = "0x4858B0", VA = "0x1804872B0", Slot = "40")]
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
					float totalFirstHealth = zombie2.TotalFirstHealth;
				}
				float totalFirstHealth2 = zombie2.TotalFirstHealth;
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
						goto IL_0078;
					}
					uint num3;
					this.GetEnergy((int)num3);
				}
				uint num4;
				this.GetEnergy((int)num4);
				goto IL_0070;
			}
			goto IL_0070;
			IL_0078:
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
			IL_0070:
			uint num6;
			this.GetEnergy((int)num6);
			goto IL_0078;
		}
	}

	// Token: 0x0600151E RID: 5406 RVA: 0x0007515C File Offset: 0x0007335C
	[Token(Token = "0x600151E")]
	[Address(RVA = "0x487620", Offset = "0x485C20", VA = "0x180487620")]
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

	// Token: 0x0600151F RID: 5407 RVA: 0x000751E4 File Offset: 0x000733E4
	[Token(Token = "0x600151F")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "29")]
	protected override void ReplaceSprite()
	{
	}

	// Token: 0x06001520 RID: 5408 RVA: 0x000751F4 File Offset: 0x000733F4
	[Token(Token = "0x6001520")]
	[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (reason == Plant.DieReason.ByShovel)
		{
			Transform axis = this.axis;
			return;
		}
	}

	// Token: 0x06001521 RID: 5409 RVA: 0x00075214 File Offset: 0x00073414
	[Token(Token = "0x6001521")]
	[Address(RVA = "0x487E50", Offset = "0x486450", VA = "0x180487E50", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001522 RID: 5410 RVA: 0x00075234 File Offset: 0x00073434
	[Token(Token = "0x6001522")]
	[Address(RVA = "0x488000", Offset = "0x486600", VA = "0x180488000")]
	public UltimateHypnoPumpkin()
	{
	}

	// Token: 0x04000CF2 RID: 3314
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000CF2")]
	public GameObject c1;

	// Token: 0x04000CF3 RID: 3315
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000CF3")]
	public GameObject c2;

	// Token: 0x04000CF4 RID: 3316
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000CF4")]
	private float hypnoTimer;
}
