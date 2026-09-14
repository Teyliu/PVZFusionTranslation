using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using PlaceRule;
using UnityEngine;

// Token: 0x0200042D RID: 1069
[Token(Token = "0x200042D")]
public class ScaredyPot : Pot
{
	// Token: 0x060013B7 RID: 5047 RVA: 0x0006E5A4 File Offset: 0x0006C7A4
	[Token(Token = "0x60013B7")]
	[Address(RVA = "0x4BAA80", Offset = "0x4B9080", VA = "0x1804BAA80", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (base.Active)
		{
			float num = Time.fixedDeltaTime * 0.3f;
			this.effect = num;
			PlantType pumpkinType = base.PumpkinType;
			if (pumpkinType != PlantType.ScaredyPumpkin)
			{
				Transform axis = this.axis;
				int num2 = this.zombieLayer;
				int num3 = 0;
				int num4 = 0;
				Collider2D[] array;
				if (num3 < array.Length)
				{
					bool flag;
					if (!flag || flag > true)
					{
						num4++;
					}
					this.effect = 0f;
				}
			}
			if (this.effect > 1f)
			{
				this.effect = 1f;
			}
			float num5 = this.timer;
			float fixedDeltaTime = Time.fixedDeltaTime;
			this.timer = num5;
			this.timer = 1f;
			this.Check();
		}
	}

	// Token: 0x060013B8 RID: 5048 RVA: 0x0006E67C File Offset: 0x0006C87C
	[Token(Token = "0x60013B8")]
	[Address(RVA = "0x4BA490", Offset = "0x4B8A90", VA = "0x1804BA490")]
	private void Check()
	{
		int num4;
		do
		{
			int num = 0;
			HashSet<Plant> hashSet = this.effectPlants;
			int num2 = 0;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
			}
			if (num2 != 0)
			{
				goto IL_0068;
			}
			num4 = 0;
			bool flag2;
			if (flag2)
			{
				if (PlaceManager.GetLayer((PlantType)num2) != Layer.Default)
				{
					continue;
				}
				if (num != 0)
				{
				}
			}
		}
		while (num4 != 0);
		PlantDataManager.PlantData plantData;
		bool flag3 = plantData.maxHealth == 0;
		return;
		IL_0068:
		throw new NullReferenceException();
	}

	// Token: 0x060013B9 RID: 5049 RVA: 0x0006E704 File Offset: 0x0006C904
	[Token(Token = "0x60013B9")]
	[Address(RVA = "0x4BA900", Offset = "0x4B8F00", VA = "0x1804BA900", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		int num2;
		do
		{
			int num = 0;
			HashSet<Plant> hashSet = this.effectPlants;
			num2 = 0;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
			}
		}
		while (num2 != 0);
	}

	// Token: 0x060013BA RID: 5050 RVA: 0x0006E744 File Offset: 0x0006C944
	[Token(Token = "0x60013BA")]
	[Address(RVA = "0x4BACD0", Offset = "0x4B92D0", VA = "0x1804BACD0")]
	public ScaredyPot()
	{
		HashSet<Plant> hashSet = new HashSet();
		this.effectPlants = hashSet;
		base..ctor();
	}

	// Token: 0x04000CDC RID: 3292
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000CDC")]
	public GameObject tear;

	// Token: 0x04000CDD RID: 3293
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000CDD")]
	private readonly HashSet<Plant> effectPlants;

	// Token: 0x04000CDE RID: 3294
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000CDE")]
	private float effect;

	// Token: 0x04000CDF RID: 3295
	[FieldOffset(Offset = "0x234")]
	[Token(Token = "0x4000CDF")]
	private float timer;
}
