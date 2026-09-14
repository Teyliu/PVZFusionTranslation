using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using ZenGarden;

// Token: 0x02000852 RID: 2130
[Token(Token = "0x2000852")]
public class Shovel : InGameTool
{
	// Token: 0x06002B92 RID: 11154 RVA: 0x000EF1C0 File Offset: 0x000ED3C0
	[Token(Token = "0x6002B92")]
	[Address(RVA = "0x678CE0", Offset = "0x6772E0", VA = "0x180678CE0")]
	private void Awake()
	{
		Shovel.Instance = this;
	}

	// Token: 0x06002B93 RID: 11155 RVA: 0x000EF1D4 File Offset: 0x000ED3D4
	[Token(Token = "0x6002B93")]
	[Address(RVA = "0x678E40", Offset = "0x677440", VA = "0x180678E40", Slot = "7")]
	protected override void OnUpdate()
	{
		if (Input.GetKeyDownInt(KeyCodeManager.Shovel))
		{
		}
	}

	// Token: 0x06002B94 RID: 11156 RVA: 0x000EF1F0 File Offset: 0x000ED3F0
	[Token(Token = "0x6002B94")]
	[Address(RVA = "0x678D40", Offset = "0x677340", VA = "0x180678D40", Slot = "8")]
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

	// Token: 0x06002B95 RID: 11157 RVA: 0x000EF244 File Offset: 0x000ED444
	[Token(Token = "0x6002B95")]
	[Address(RVA = "0x679310", Offset = "0x677910", VA = "0x180679310", Slot = "9")]
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

	// Token: 0x06002B96 RID: 11158 RVA: 0x000EF390 File Offset: 0x000ED590
	[Token(Token = "0x6002B96")]
	[Address(RVA = "0x678EC0", Offset = "0x6774C0", VA = "0x180678EC0")]
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

	// Token: 0x06002B97 RID: 11159 RVA: 0x000EF3E0 File Offset: 0x000ED5E0
	[Token(Token = "0x6002B97")]
	[Address(RVA = "0x678FD0", Offset = "0x6775D0", VA = "0x180678FD0")]
	public void ReturnPlantToGarden(Plant plant)
	{
		int num;
		uint num2;
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
			}
		}
		while (num != 0);
		ulong num3;
		if (num3 == (ulong)0L)
		{
			num++;
		}
		GardenPlant gardenPlant;
		GardenPlant component = gardenPlant.GetComponent<GardenPlant>();
		if (gardenPlant != 0)
		{
			if (gardenPlant != 0)
			{
				if (component != (ulong)1L)
				{
					goto IL_00A2;
				}
				component.data.growStage = (int)((ulong)2L);
				component.data.love = (int)((ulong)100L);
			}
			component.data.growStage = (int)((ulong)2L);
		}
		component.data.growStage = (int)((ulong)1L);
		IL_00A2:
		component.battleTimer = 30f;
		return;
		IL_00AF:
		num2 += (uint)1;
		throw new NullReferenceException();
	}

	// Token: 0x06002B98 RID: 11160 RVA: 0x000EF4B4 File Offset: 0x000ED6B4
	[Token(Token = "0x6002B98")]
	[Address(RVA = "0x6659E0", Offset = "0x663FE0", VA = "0x1806659E0")]
	public Shovel()
	{
		this.fullCD = 10f;
		this.avaliable = true;
		this.coolSpeed = 1f;
		base..ctor();
	}

	// Token: 0x040019C8 RID: 6600
	[Token(Token = "0x40019C8")]
	public static Shovel Instance;
}
