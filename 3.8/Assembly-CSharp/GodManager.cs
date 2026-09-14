using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000C1 RID: 193
[Token(Token = "0x20000C1")]
public class GodManager : MonoBehaviour
{
	// Token: 0x06000373 RID: 883 RVA: 0x00010088 File Offset: 0x0000E288
	[Token(Token = "0x6000373")]
	[Address(RVA = "0x4B1C80", Offset = "0x4B0280", VA = "0x1804B1C80")]
	private void Awake()
	{
		GodManager.Instance = this;
	}

	// Token: 0x06000374 RID: 884 RVA: 0x0001009C File Offset: 0x0000E29C
	[Token(Token = "0x6000374")]
	[Address(RVA = "0x4B2780", Offset = "0x4B0D80", VA = "0x1804B2780")]
	private void Start()
	{
		ulong num;
		do
		{
			List<CardUI> childs = global::Core.Lawnf.GetChilds<CardUI>(SeedLibrary.Instance.transform);
			bool flag;
			if (flag)
			{
				Dictionary<PlantType, PlantEvolutionData> evolutions = GodEvolution.Evolutions;
				bool flag2;
				if (flag2)
				{
				}
				GameObject gameObject;
				global::UnityEngine.Object.Destroy(gameObject);
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06000375 RID: 885 RVA: 0x000100F4 File Offset: 0x0000E2F4
	[Token(Token = "0x6000375")]
	[Address(RVA = "0x4B2BC0", Offset = "0x4B11C0", VA = "0x1804B2BC0")]
	private void Update()
	{
		if (!this.toggle)
		{
			this.toggle = true;
			if (InGameUI.Instance.Cards._size > 5)
			{
				InGameText instance = InGameText.Instance;
				int num = 0;
				instance.ShowText("选择了超过5株植物，敌方开始出现高阶僵尸", 3f, num != 0);
				Dictionary<int, int> dictionary;
				Board.Instance.boardData.zombieLevelDic = dictionary;
			}
		}
	}

	// Token: 0x06000376 RID: 886 RVA: 0x00010158 File Offset: 0x0000E358
	[Token(Token = "0x6000376")]
	[Address(RVA = "0x4B1CF0", Offset = "0x4B02F0", VA = "0x1804B1CF0")]
	public void ClickCard(CardUI card)
	{
		int num = 0;
		Board board = card.board;
		int theSeedCost = card.theSeedCost;
		Dictionary<CardUI, PlantType> dictionary = this.cardBaseTypes;
		PlantType thePlantType = card.thePlantType;
		if (!dictionary.ContainsKey(card))
		{
			Dictionary<CardUI, PlantType> dictionary2 = this.cardBaseTypes;
		}
		PlantType plantType = this.cardBaseTypes[card];
		Dictionary<PlantType, Plant> dictionary3 = this.currentPlants;
		bool flag;
		if (flag)
		{
			Dictionary<PlantType, Plant> dictionary4 = this.currentPlants;
			int num2 = 0;
			Plant plant;
			if (!(plant == num2))
			{
				GameObject gameObject = plant.gameObject;
				int num3 = 0;
				if (!(gameObject == num3))
				{
					if (plant.thePlantType != thePlantType)
					{
						PlantType thePlantType2 = plant.thePlantType;
						bool flag2;
						if (flag2)
						{
							int num4 = 0;
							plant.Die((Plant.DieReason)num4);
							CreatePlant instance = CreatePlant.Instance;
							int num5 = 0;
							Plant plant2;
							if (plant2 != num5)
							{
								Dictionary<PlantType, PlantEvolutionData> evolutions = GodEvolution.Evolutions;
								bool flag3;
								if (flag3)
								{
								}
								Board board2 = card.board;
								Dictionary<PlantType, Plant> dictionary5 = this.currentPlants;
								this.OnUpdated(card);
								InGameText instance2 = InGameText.Instance;
								string name = global::Lawnf.GetName(plant.thePlantType);
								string text2;
								string text = "升级成功：" + name + " -> " + text2;
								return;
							}
							goto IL_0179;
						}
						else
						{
							int num6 = 0;
							InGameText instance3 = InGameText.Instance;
							string name2 = global::Lawnf.GetName((PlantType)num6);
							string text4;
							string text3 = "不能将" + name2 + "升级为" + text4;
						}
					}
					InGameText instance4 = InGameText.Instance;
					string text6;
					string text5 = "场上已经有一个" + text6 + "了";
				}
			}
			Dictionary<PlantType, Plant> dictionary6 = this.currentPlants;
		}
		IL_0179:
		Board board3 = card.board;
		int num8;
		if (num < board3.columnNum)
		{
			Board board4 = card.board;
			if (num < board4.rowNum)
			{
				List<Plant> list = global::Lawnf.Get1x1Plants(num, num);
				CreatePlant instance5 = CreatePlant.Instance;
				int num7 = 0;
				Plant plant3;
				if (plant3 != num7)
				{
					goto IL_01CA;
				}
				num++;
			}
			num++;
			IL_01CA:
			Dictionary<PlantType, PlantEvolutionData> evolutions2 = GodEvolution.Evolutions;
			bool flag4;
			if (flag4)
			{
			}
			Board board5 = card.board;
			Dictionary<PlantType, Plant> dictionary7 = this.currentPlants;
			this.OnUpdated(card);
			InGameText instance6 = InGameText.Instance;
			num8 = 0;
			string text8;
			string text7 = "种植了：" + text8;
		}
		InGameText instance7 = InGameText.Instance;
		InGameText instance8 = InGameText.Instance;
		int num9 = 0;
		instance8.ShowText("阳光不足", (float)num8, num9 != 0);
		GameAPP.PlaySound(26, 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x06000377 RID: 887 RVA: 0x000103B0 File Offset: 0x0000E5B0
	[Token(Token = "0x6000377")]
	[Address(RVA = "0x4B2550", Offset = "0x4B0B50", VA = "0x1804B2550")]
	private void OnUpdated(CardUI card)
	{
		int num = this.cardBaseTypes[card];
		PlantType thePlantType = card.thePlantType;
		bool flag;
		if (flag)
		{
			ulong num2;
			card.thePlantType = (PlantType)num2;
			card.ChangeCardSprite();
			int num3 = this.cardBaseTypes[card];
			GodData godData = GodManager.godData;
			int num4;
			num3 = num4;
			PlantEvolutionData plantEvolutionData;
			if (plantEvolutionData != 0)
			{
				List<PlantEvolutionRoute> routes = plantEvolutionData.GetRoutes();
				PlantEvolutionRoute plantEvolutionRoute = plantEvolutionData.GetRoutes()[num3];
				List<PlantType> stages = plantEvolutionRoute.stages;
				int num6;
				int num5 = plantEvolutionRoute.stageCost[num6];
				card.theSeedCost = num5;
			}
		}
	}

	// Token: 0x06000378 RID: 888 RVA: 0x00010444 File Offset: 0x0000E644
	[Token(Token = "0x6000378")]
	[Address(RVA = "0x4B2A00", Offset = "0x4B1000", VA = "0x1804B2A00")]
	public static bool TryGetEvolvedPlant(PlantType basePlant, PlantType plantType, [Out] PlantType evolvedType)
	{
		evolvedType.value__ = (int)plantType;
		GodData godData = GodManager.godData;
		PlantEvolutionData plantEvolutionData;
		if (plantEvolutionData != 0)
		{
			List<PlantEvolutionRoute> routes = plantEvolutionData.GetRoutes();
			int num;
			PlantEvolutionRoute plantEvolutionRoute = plantEvolutionData.GetRoutes()[num];
			int num2 = 0;
			if (plantEvolutionRoute.stages[num2] != plantType)
			{
				num2++;
			}
			int size = plantEvolutionRoute.stages._size;
			if (num2 < size)
			{
				PlantType plantType2 = plantEvolutionRoute.stages[1];
				evolvedType.value__ = (int)plantType2;
				return true;
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000379 RID: 889 RVA: 0x000104D0 File Offset: 0x0000E6D0
	[Token(Token = "0x6000379")]
	[Address(RVA = "0x4B2E50", Offset = "0x4B1450", VA = "0x1804B2E50")]
	public GodManager()
	{
		Dictionary<PlantType, Plant> dictionary = new Dictionary();
		this.currentPlants = dictionary;
		Dictionary<CardUI, PlantType> dictionary2 = new Dictionary();
		this.cardBaseTypes = dictionary2;
		base..ctor();
	}

	// Token: 0x0600037A RID: 890 RVA: 0x00010500 File Offset: 0x0000E700
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x600037A")]
	[Address(RVA = "0x4B2D30", Offset = "0x4B1330", VA = "0x1804B2D30")]
	static GodManager()
	{
		GodData godData = new GodData();
		List<RouteChoice> list = new List();
		godData.plantRouteChoices = list;
		List<PlantType> list2 = new List();
		godData.unlockedPlants = list2;
		GodManager.godData = godData;
	}

	// Token: 0x040001D1 RID: 465
	[Token(Token = "0x40001D1")]
	public static GodData godData;

	// Token: 0x040001D2 RID: 466
	[Token(Token = "0x40001D2")]
	public static GodManager Instance;

	// Token: 0x040001D3 RID: 467
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001D3")]
	public bool custom;

	// Token: 0x040001D4 RID: 468
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Token(Token = "0x40001D4")]
	private bool toggle;

	// Token: 0x040001D5 RID: 469
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001D5")]
	private readonly Dictionary<PlantType, Plant> currentPlants;

	// Token: 0x040001D6 RID: 470
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001D6")]
	private readonly Dictionary<CardUI, PlantType> cardBaseTypes;
}
