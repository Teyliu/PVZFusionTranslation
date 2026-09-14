using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000C6 RID: 198
[Token(Token = "0x20000C6")]
public class GodManager : MonoBehaviour
{
	// Token: 0x0600038E RID: 910 RVA: 0x000103F8 File Offset: 0x0000E5F8
	[Token(Token = "0x600038E")]
	[Address(RVA = "0x4F1310", Offset = "0x4EF910", VA = "0x1804F1310")]
	private void Awake()
	{
		GodManager.Instance = this;
	}

	// Token: 0x0600038F RID: 911 RVA: 0x0001040C File Offset: 0x0000E60C
	[Token(Token = "0x600038F")]
	[Address(RVA = "0x4F1E30", Offset = "0x4F0430", VA = "0x1804F1E30")]
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

	// Token: 0x06000390 RID: 912 RVA: 0x00010464 File Offset: 0x0000E664
	[Token(Token = "0x6000390")]
	[Address(RVA = "0x4F2270", Offset = "0x4F0870", VA = "0x1804F2270")]
	private void Update()
	{
		if (!this.toggle)
		{
			this.toggle = true;
			if (InGameUI.Instance.Cards._size > 5)
			{
				InGameText instance = InGameText.Instance;
				Dictionary<int, int> dictionary;
				Board.Instance.boardData.zombieLevelDic = dictionary;
			}
		}
	}

	// Token: 0x06000391 RID: 913 RVA: 0x000104B4 File Offset: 0x0000E6B4
	[Token(Token = "0x6000391")]
	[Address(RVA = "0x4F1380", Offset = "0x4EF980", VA = "0x1804F1380")]
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
			string text8;
			string text7 = "种植了：" + text8;
		}
		InGameText instance7 = InGameText.Instance;
		InGameText instance8 = InGameText.Instance;
		GameAPP.PlaySound(26, 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x06000392 RID: 914 RVA: 0x000106F4 File Offset: 0x0000E8F4
	[Token(Token = "0x6000392")]
	[Address(RVA = "0x4F1C00", Offset = "0x4F0200", VA = "0x1804F1C00")]
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

	// Token: 0x06000393 RID: 915 RVA: 0x00010788 File Offset: 0x0000E988
	[Token(Token = "0x6000393")]
	[Address(RVA = "0x4F20B0", Offset = "0x4F06B0", VA = "0x1804F20B0")]
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

	// Token: 0x06000394 RID: 916 RVA: 0x00010814 File Offset: 0x0000EA14
	[Token(Token = "0x6000394")]
	[Address(RVA = "0x4F2510", Offset = "0x4F0B10", VA = "0x1804F2510")]
	public GodManager()
	{
		Dictionary<PlantType, Plant> dictionary = new Dictionary();
		this.currentPlants = dictionary;
		Dictionary<CardUI, PlantType> dictionary2 = new Dictionary();
		this.cardBaseTypes = dictionary2;
		base..ctor();
	}

	// Token: 0x06000395 RID: 917 RVA: 0x00010844 File Offset: 0x0000EA44
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x6000395")]
	[Address(RVA = "0x4F23F0", Offset = "0x4F09F0", VA = "0x1804F23F0")]
	static GodManager()
	{
		GodData godData = new GodData();
		List<RouteChoice> list = new List();
		godData.plantRouteChoices = list;
		List<PlantType> list2 = new List();
		godData.unlockedPlants = list2;
		GodManager.godData = godData;
	}

	// Token: 0x040001DE RID: 478
	[Token(Token = "0x40001DE")]
	public static GodData godData;

	// Token: 0x040001DF RID: 479
	[Token(Token = "0x40001DF")]
	public static GodManager Instance;

	// Token: 0x040001E0 RID: 480
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001E0")]
	public bool custom;

	// Token: 0x040001E1 RID: 481
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Token(Token = "0x40001E1")]
	private bool toggle;

	// Token: 0x040001E2 RID: 482
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001E2")]
	private readonly Dictionary<PlantType, Plant> currentPlants;

	// Token: 0x040001E3 RID: 483
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001E3")]
	private readonly Dictionary<CardUI, PlantType> cardBaseTypes;
}
