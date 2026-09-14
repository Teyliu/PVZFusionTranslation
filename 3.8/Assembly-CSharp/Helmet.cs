using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000221 RID: 545
[Token(Token = "0x2000221")]
public class Helmet : Bucket
{
	// Token: 0x06000963 RID: 2403 RVA: 0x000335E4 File Offset: 0x000317E4
	[Token(Token = "0x6000963")]
	[Address(RVA = "0x87ECB0", Offset = "0x87D2B0", VA = "0x18087ECB0", Slot = "9")]
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

	// Token: 0x06000964 RID: 2404 RVA: 0x000336B4 File Offset: 0x000318B4
	[Token(Token = "0x6000964")]
	[Address(RVA = "0x87F000", Offset = "0x87D600", VA = "0x18087F000")]
	public Helmet()
	{
		this.disappear = true;
		this.gravity = 9.8f;
		this.verticalSpeed = 4f;
		base..ctor();
	}
}
