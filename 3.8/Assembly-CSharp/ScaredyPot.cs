using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using PlaceRule;
using UnityEngine;

// Token: 0x02000412 RID: 1042
[Token(Token = "0x2000412")]
public class ScaredyPot : Pot
{
	// Token: 0x06001341 RID: 4929 RVA: 0x0006C714 File Offset: 0x0006A914
	[Token(Token = "0x6001341")]
	[Address(RVA = "0x464370", Offset = "0x462970", VA = "0x180464370", Slot = "17")]
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

	// Token: 0x06001342 RID: 4930 RVA: 0x0006C7EC File Offset: 0x0006A9EC
	[Token(Token = "0x6001342")]
	[Address(RVA = "0x463D80", Offset = "0x462380", VA = "0x180463D80")]
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

	// Token: 0x06001343 RID: 4931 RVA: 0x0006C874 File Offset: 0x0006AA74
	[Token(Token = "0x6001343")]
	[Address(RVA = "0x4641F0", Offset = "0x4627F0", VA = "0x1804641F0", Slot = "53")]
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

	// Token: 0x06001344 RID: 4932 RVA: 0x0006C8B4 File Offset: 0x0006AAB4
	[Token(Token = "0x6001344")]
	[Address(RVA = "0x4645C0", Offset = "0x462BC0", VA = "0x1804645C0")]
	public ScaredyPot()
	{
		HashSet<Plant> hashSet = new HashSet();
		this.effectPlants = hashSet;
		base..ctor();
	}

	// Token: 0x04000C61 RID: 3169
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000C61")]
	public GameObject tear;

	// Token: 0x04000C62 RID: 3170
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000C62")]
	private readonly HashSet<Plant> effectPlants;

	// Token: 0x04000C63 RID: 3171
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000C63")]
	private float effect;

	// Token: 0x04000C64 RID: 3172
	[FieldOffset(Offset = "0x234")]
	[Token(Token = "0x4000C64")]
	private float timer;
}
