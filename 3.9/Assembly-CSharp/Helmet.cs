using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000226 RID: 550
[Token(Token = "0x2000226")]
public class Helmet : Bucket
{
	// Token: 0x06000979 RID: 2425 RVA: 0x00033420 File Offset: 0x00031620
	[Token(Token = "0x6000979")]
	[Address(RVA = "0x90E7C0", Offset = "0x90CDC0", VA = "0x18090E7C0", Slot = "9")]
	public override void Use()
	{
		Mouse m = this.m;
		int num = 0;
		List<Plant> plantArray = Board.Instance.boardEntity.plantArray;
		Plant plant = Board.Instance.boardEntity.plantArray[num];
		int num2 = 0;
		if (plant != num2 && plant == 0 && plant == 0)
		{
			PlantType thePlantType = plant.thePlantType;
			if (thePlantType == PlantType.ObsidianSpike)
			{
			}
			if (thePlantType == PlantType.TallNut)
			{
				int num3 = 0;
				plant.Die((Plant.DieReason)num3);
				CreatePlant instance = CreatePlant.Instance;
			}
			if (thePlantType == PlantType.TallNutFootball)
			{
				int num4 = 0;
				plant.Recover(5000f, (DamageType)num4, true, num != 0);
				global::UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		num++;
		Board instance2 = Board.Instance;
		base.GetComponent<Collider2D>().enabled = true;
	}

	// Token: 0x0600097A RID: 2426 RVA: 0x000334F0 File Offset: 0x000316F0
	[Token(Token = "0x600097A")]
	[Address(RVA = "0x90EB10", Offset = "0x90D110", VA = "0x18090EB10")]
	public Helmet()
	{
		this.disappear = true;
		this.gravity = 9.8f;
		this.verticalSpeed = 4f;
		base..ctor();
	}
}
