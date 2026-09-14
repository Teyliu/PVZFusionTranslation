using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000840 RID: 2112
[Token(Token = "0x2000840")]
public class GodShootingMenu : BaseMenu
{
	// Token: 0x06002B02 RID: 11010 RVA: 0x000EBDD4 File Offset: 0x000E9FD4
	[Token(Token = "0x6002B02")]
	[Address(RVA = "0x65CEB0", Offset = "0x65B4B0", VA = "0x18065CEB0")]
	private void Start()
	{
		this.InitBasePlant();
		this.InitRoutes();
		int num = 0;
		this.ShowRoutes((PlantType)num);
		global::UnityEngine.Object.Destroy(this.sampleLayout);
		global::UnityEngine.Object.Destroy(this.sampleRoute);
	}

	// Token: 0x06002B03 RID: 11011 RVA: 0x000EBE0C File Offset: 0x000EA00C
	[Token(Token = "0x6002B03")]
	[Address(RVA = "0x65C370", Offset = "0x65A970", VA = "0x18065C370")]
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

	// Token: 0x06002B04 RID: 11012 RVA: 0x000EBE70 File Offset: 0x000EA070
	[Token(Token = "0x6002B04")]
	[Address(RVA = "0x65C5E0", Offset = "0x65ABE0", VA = "0x18065C5E0")]
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

	// Token: 0x06002B05 RID: 11013 RVA: 0x000EC0EC File Offset: 0x000EA2EC
	[Token(Token = "0x6002B05")]
	[Address(RVA = "0x65CD50", Offset = "0x65B350", VA = "0x18065CD50")]
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

	// Token: 0x06002B06 RID: 11014 RVA: 0x000EC11C File Offset: 0x000EA31C
	[Token(Token = "0x6002B06")]
	[Address(RVA = "0x65CF60", Offset = "0x65B560", VA = "0x18065CF60")]
	public GodShootingMenu()
	{
		Dictionary<PlantType, GameObject> dictionary = new Dictionary();
		this.routes = dictionary;
		Dictionary<PlantType, TextMeshProUGUI> dictionary2 = new Dictionary();
		this.yellowText = dictionary2;
		base..ctor();
	}

	// Token: 0x0400192D RID: 6445
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400192D")]
	public GameObject sampleCardPrefab;

	// Token: 0x0400192E RID: 6446
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400192E")]
	public Transform basePlantsContainer;

	// Token: 0x0400192F RID: 6447
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400192F")]
	public Transform content;

	// Token: 0x04001930 RID: 6448
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001930")]
	public GameObject sampleLayout;

	// Token: 0x04001931 RID: 6449
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001931")]
	public GameObject sampleRoute;

	// Token: 0x04001932 RID: 6450
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001932")]
	private readonly Dictionary<PlantType, GameObject> routes;

	// Token: 0x04001933 RID: 6451
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001933")]
	private readonly Dictionary<PlantType, TextMeshProUGUI> yellowText;
}
