using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x0200087C RID: 2172
[Token(Token = "0x200087C")]
public class GodShootingMenu : BaseMenu
{
	// Token: 0x06002C34 RID: 11316 RVA: 0x000F0AE4 File Offset: 0x000EECE4
	[Token(Token = "0x6002C34")]
	[Address(RVA = "0x6C0D30", Offset = "0x6BF330", VA = "0x1806C0D30")]
	private void Start()
	{
		this.InitBasePlant();
		this.InitRoutes();
		int num = 0;
		this.ShowRoutes((PlantType)num);
		global::UnityEngine.Object.Destroy(this.sampleLayout);
		global::UnityEngine.Object.Destroy(this.sampleRoute);
	}

	// Token: 0x06002C35 RID: 11317 RVA: 0x000F0B1C File Offset: 0x000EED1C
	[Token(Token = "0x6002C35")]
	[Address(RVA = "0x6C01F0", Offset = "0x6BE7F0", VA = "0x1806C01F0")]
	private void InitBasePlant()
	{
		ulong num;
		do
		{
			Dictionary<PlantType, PlantEvolutionData> evolutions = GodEvolution.Evolutions;
			bool flag;
			if (flag)
			{
				GameObject gameObject = this.sampleCardPrefab;
				Transform transform = this.basePlantsContainer;
				UnityAction<TheCard> unityAction;
				global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform).GetComponent<TheCard>().clickEvent.AddListener(unityAction);
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06002C36 RID: 11318 RVA: 0x000F0B80 File Offset: 0x000EED80
	[Token(Token = "0x6002C36")]
	[Address(RVA = "0x6C0460", Offset = "0x6BEA60", VA = "0x1806C0460")]
	private void InitRoutes()
	{
		ulong num5;
		do
		{
			Dictionary<PlantType, PlantEvolutionData> evolutions = GodEvolution.Evolutions;
			bool flag;
			if (flag)
			{
				GameObject gameObject = this.sampleRoute;
				Transform transform = this.content;
				Transform transform2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform).transform;
				Dictionary<PlantType, GameObject> dictionary = this.routes;
				int num = 0;
				GameObject gameObject2 = transform2.gameObject;
				dictionary.Add(num, gameObject2);
				int num2 = 0;
				GodShootingMenu.<>c__DisplayClass9_0 CS$<>8__locals1;
				CS$<>8__locals1.<>4__this = this;
				PlantEvolutionRoute plantEvolutionRoute;
				CS$<>8__locals1.route = plantEvolutionRoute;
				Transform transform3 = global::UnityEngine.Object.Instantiate<GameObject>(this.sampleLayout, transform2).transform;
				TextMeshProUGUI componentInChildren = transform3.GetComponentInChildren<TextMeshProUGUI>();
				CS$<>8__locals1.routeName = componentInChildren;
				List<PlantType> stages = CS$<>8__locals1.route.stages;
				int num3 = 0;
				PlantType plantType = stages[num3];
				CS$<>8__locals1.basePlantType = plantType;
				List<PlantType> stages2 = CS$<>8__locals1.route.stages;
				GodShootingMenu.<>c__DisplayClass9_1 CS$<>8__locals2;
				CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
				TheCard component = global::UnityEngine.Object.Instantiate<GameObject>(this.sampleCardPrefab, transform3).GetComponent<TheCard>();
				PlantType plantType2 = CS$<>8__locals2.CS$<>8__locals1.route.stages[1];
				component.thePlantType = plantType2;
				TextMeshProUGUI costText = component.costText;
				int num4 = CS$<>8__locals2.CS$<>8__locals1.route.stageCost[1];
				string text;
				costText.text = text;
				CS$<>8__locals2.index = num2;
				UnityAction<TheCard> unityAction;
				component.clickEvent.AddListener(unityAction);
				GodData godData = GodManager.godData;
				PlantType basePlantType = CS$<>8__locals1.basePlantType;
				if (godData.GetRouteChoice(basePlantType) == num2)
				{
					TextMeshProUGUI routeName = CS$<>8__locals1.routeName;
					Dictionary<PlantType, TextMeshProUGUI> dictionary2 = this.yellowText;
					TextMeshProUGUI routeName2 = CS$<>8__locals1.routeName;
					PlantType basePlantType2 = CS$<>8__locals1.basePlantType;
					dictionary2.Add(basePlantType2, routeName2);
				}
				TextMeshProUGUI routeName3 = CS$<>8__locals1.routeName;
				string text2 = CS$<>8__locals1.route.routeName + ":";
				routeName3.text = text2;
				num2++;
			}
		}
		while (num5 != (ulong)0L);
	}

	// Token: 0x06002C37 RID: 11319 RVA: 0x000F0DFC File Offset: 0x000EEFFC
	[Token(Token = "0x6002C37")]
	[Address(RVA = "0x6C0BD0", Offset = "0x6BF1D0", VA = "0x1806C0BD0")]
	private void ShowRoutes(PlantType thePlantType)
	{
		ulong num;
		do
		{
			Dictionary<PlantType, GameObject> dictionary = this.routes;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06002C38 RID: 11320 RVA: 0x000F0E2C File Offset: 0x000EF02C
	[Token(Token = "0x6002C38")]
	[Address(RVA = "0x6C0DE0", Offset = "0x6BF3E0", VA = "0x1806C0DE0")]
	public GodShootingMenu()
	{
		Dictionary<PlantType, GameObject> dictionary = new Dictionary();
		this.routes = dictionary;
		Dictionary<PlantType, TextMeshProUGUI> dictionary2 = new Dictionary();
		this.yellowText = dictionary2;
		base..ctor();
	}

	// Token: 0x04001A1B RID: 6683
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001A1B")]
	public GameObject sampleCardPrefab;

	// Token: 0x04001A1C RID: 6684
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001A1C")]
	public Transform basePlantsContainer;

	// Token: 0x04001A1D RID: 6685
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001A1D")]
	public Transform content;

	// Token: 0x04001A1E RID: 6686
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001A1E")]
	public GameObject sampleLayout;

	// Token: 0x04001A1F RID: 6687
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001A1F")]
	public GameObject sampleRoute;

	// Token: 0x04001A20 RID: 6688
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001A20")]
	private readonly Dictionary<PlantType, GameObject> routes;

	// Token: 0x04001A21 RID: 6689
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001A21")]
	private readonly Dictionary<PlantType, TextMeshProUGUI> yellowText;
}
