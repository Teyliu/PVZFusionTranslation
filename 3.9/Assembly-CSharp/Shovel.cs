using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using ZenGarden;

// Token: 0x0200088E RID: 2190
[Token(Token = "0x200088E")]
public class Shovel : InGameTool
{
	// Token: 0x06002CC4 RID: 11460 RVA: 0x000F3E18 File Offset: 0x000F2018
	[Token(Token = "0x6002CC4")]
	[Address(RVA = "0x6DD9F0", Offset = "0x6DBFF0", VA = "0x1806DD9F0")]
	private void Awake()
	{
		Shovel.Instance = this;
	}

	// Token: 0x06002CC5 RID: 11461 RVA: 0x000F3E2C File Offset: 0x000F202C
	[Token(Token = "0x6002CC5")]
	[Address(RVA = "0x6DDB50", Offset = "0x6DC150", VA = "0x1806DDB50", Slot = "7")]
	protected override void OnUpdate()
	{
		if (Input.GetKeyDownInt(KeyCodeManager.Shovel))
		{
		}
	}

	// Token: 0x06002CC6 RID: 11462 RVA: 0x000F3E48 File Offset: 0x000F2048
	[Token(Token = "0x6002CC6")]
	[Address(RVA = "0x6DDA50", Offset = "0x6DC050", VA = "0x1806DDA50", Slot = "8")]
	public override bool OnClick(Mouse mouse)
	{
		GameObject theItemOnMouse = mouse.theItemOnMouse;
		int num = 0;
		if (theItemOnMouse == num)
		{
			GameObject gameObject = base.gameObject;
			mouse.theItemOnMouse = gameObject;
			GameAPP.PlaySound((SoundType)((uint)21), 0.5f, 1f);
			base.PickUp();
			return true;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06002CC7 RID: 11463 RVA: 0x000F3E9C File Offset: 0x000F209C
	[Token(Token = "0x6002CC7")]
	[Address(RVA = "0x6DE050", Offset = "0x6DC650", VA = "0x1806DE050", Slot = "9")]
	public override void Use(Mouse mouse)
	{
		int num = 0;
		base.PutDown();
		int num2 = 0;
		mouse.ClearItemOnMouse(num2 != 0);
		Vector2 mousePosition = mouse.MousePosition;
		Vector2 zeroVector = Vector2.zeroVector;
		RaycastHit2D[] array;
		List<Plant> plantsOnMouse = mouse.GetPlantsOnMouse(array);
		Board board = this.board;
		Predicate<Plant> <>9__4_ = Shovel.<>c.<>9__4_0;
		if (<>9__4_ == 0)
		{
			Predicate<Plant> predicate;
			Shovel.<>c.<>9__4_0 = predicate;
		}
		int num3 = plantsOnMouse.RemoveAll(<>9__4_);
		Board board2 = this.board;
		if (num < array.Length)
		{
			Collider2D collider2D;
			if (collider2D.TryGetComponent<GardenPlant>(num))
			{
				uint num4;
				GameAPP.PlaySound((int)num4, 0.5f, 1f);
			}
			num++;
			int num5 = 0;
			Plant plant = plantsOnMouse[num5];
			if ((plant.dieMeansLose ? 1 : 0) == num)
			{
				Board board3 = this.board;
				this.ReturnPlantToGarden(plant);
				AdvantureData data = AdvantureConfig.data;
				bool flag;
				if (flag)
				{
					int thePlantType = (int)plant.thePlantType;
					PlantDataManager.PlantData plantData;
					if (plantData.cost > num)
					{
						CreateItem instance = CreateItem.Instance;
					}
				}
				Board board4 = this.board;
				PlantType thePlantType2 = plant.thePlantType;
				if (thePlantType2 != PlantType.UltimateFly && thePlantType2 != PlantType.CactusBlover)
				{
					ulong num6;
					num6 += num6;
					if (num6 > (ulong)0L)
					{
						CreateItem instance2 = CreateItem.Instance;
						num++;
					}
				}
				uint num7;
				GameAPP.PlaySound((int)num7, 0.5f, 1f);
			}
		}
	}

	// Token: 0x06002CC8 RID: 11464 RVA: 0x000F3FE8 File Offset: 0x000F21E8
	[Token(Token = "0x6002CC8")]
	[Address(RVA = "0x6DDBD0", Offset = "0x6DC1D0", VA = "0x1806DDBD0")]
	private void PayBackSun(Plant plant)
	{
		PlantType thePlantType = plant.thePlantType;
		if (thePlantType != PlantType.UltimateFly && thePlantType != PlantType.CactusBlover)
		{
			int num = 0;
			ulong num2;
			num2 += num2;
			if (num2 > (ulong)0L)
			{
				CreateItem instance = CreateItem.Instance;
				num++;
			}
		}
	}

	// Token: 0x06002CC9 RID: 11465 RVA: 0x000F4038 File Offset: 0x000F2238
	[Token(Token = "0x6002CC9")]
	[Address(RVA = "0x6DDCE0", Offset = "0x6DC2E0", VA = "0x1806DDCE0")]
	public void ReturnPlantToGarden(Plant plant)
	{
		int num;
		uint num2;
		int num3;
		do
		{
			num = 0;
			if (num2 >= (uint)(-1))
			{
				return;
			}
			Board board = this.board;
			if (num >= board.rowNum)
			{
				goto IL_00AF;
			}
			List<GardenPlant> gardenPlants = board.boardEntity.gardenPlants;
			bool flag;
			if (flag)
			{
				num3 = 0;
			}
		}
		while (num != 0);
		if (num3 == 0)
		{
			num++;
		}
		GardenPlant gardenPlant;
		GardenPlant component = gardenPlant.GetComponent<GardenPlant>();
		GardenPlantData gardenPlantData;
		component.data = gardenPlantData;
		if (component != 0)
		{
			if (component != 0)
			{
				component.data.growStage = (int)((ulong)2L);
				component.data.love = (int)((ulong)100L);
			}
			component.data.growStage = (int)((ulong)2L);
		}
		component.data.growStage = (int)((ulong)1L);
		component.battleTimer = 30f;
		return;
		IL_00AF:
		num2 += (uint)1;
		throw new NullReferenceException();
	}

	// Token: 0x06002CCA RID: 11466 RVA: 0x000F410C File Offset: 0x000F230C
	[Token(Token = "0x6002CCA")]
	[Address(RVA = "0x6CA550", Offset = "0x6C8B50", VA = "0x1806CA550")]
	public Shovel()
	{
		this.fullCD = 10f;
		this.avaliable = true;
		this.coolSpeed = 1f;
		base..ctor();
	}

	// Token: 0x04001AB6 RID: 6838
	[Token(Token = "0x4001AB6")]
	public static Shovel Instance;
}
