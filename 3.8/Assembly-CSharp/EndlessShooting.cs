using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000216 RID: 534
[Token(Token = "0x2000216")]
public class EndlessShooting : MonoBehaviour
{
	// Token: 0x0600092A RID: 2346 RVA: 0x00031DE8 File Offset: 0x0002FFE8
	[Token(Token = "0x600092A")]
	[Address(RVA = "0x878430", Offset = "0x876A30", VA = "0x180878430")]
	private void Awake()
	{
		EndlessShooting.Instance = this;
		int theBoardLevel = GameAPP.theBoardLevel;
		Board instance = Board.Instance;
		SaveInfo instance2 = SaveInfo.Instance;
		int savedID = instance.savedID;
		SurvivalData survivalData = instance2.GetSurvivalData(theBoardLevel, savedID);
		if (survivalData != 0)
		{
			List<PlantType> list = survivalData.cardOnBank;
			if (survivalData.boardData.theCurrentSurvivalRound > 1)
			{
				List<PlantType> list2 = survivalData.cardOnBank;
				this.cardOnBank = list2;
			}
		}
		this.GetCards();
	}

	// Token: 0x0600092B RID: 2347 RVA: 0x00031E5C File Offset: 0x0003005C
	[Token(Token = "0x600092B")]
	[Address(RVA = "0x878990", Offset = "0x876F90", VA = "0x180878990")]
	public void SetCard(int level)
	{
		Board instance = Board.Instance;
		SaveInfo instance2 = SaveInfo.Instance;
		int savedID = instance.savedID;
		SurvivalData survivalData = instance2.GetSurvivalData(level, savedID);
		if (survivalData != 0)
		{
			List<PlantType> list = survivalData.cardOnBank;
			if (survivalData.boardData.theCurrentSurvivalRound > 1)
			{
				List<PlantType> list2 = survivalData.cardOnBank;
				this.cardOnBank = list2;
			}
		}
		this.GetCards();
	}

	// Token: 0x0600092C RID: 2348 RVA: 0x00031EBC File Offset: 0x000300BC
	[Token(Token = "0x600092C")]
	[Address(RVA = "0x878590", Offset = "0x876B90", VA = "0x180878590")]
	public void GetCards()
	{
		int num2;
		List<PlantType> list;
		do
		{
			int num = 0;
			num2 = 0;
			this.cardOnBank._size = num2;
			list = new List();
			HashSet<PlantType> baiscPlants = CoreEnums.baiscPlants;
			bool flag;
			if (flag)
			{
				if (!GameAPP.resourcesManager.plantPrefabs.TryGetValue(num, num2))
				{
					continue;
				}
				while (num == 1)
				{
				}
				while (num == 12)
				{
				}
			}
		}
		while (num2 != 0);
		int num3 = 0;
		int num4 = list._size;
		num4 = global::UnityEngine.Random.Range(0, num4);
		num4 = list[num4];
		num3++;
	}

	// Token: 0x0600092D RID: 2349 RVA: 0x00031F50 File Offset: 0x00030150
	[Token(Token = "0x600092D")]
	[Address(RVA = "0x878A70", Offset = "0x877070", VA = "0x180878A70")]
	public EndlessShooting()
	{
		List<PlantType> list = new List();
		this.cardOnBank = list;
		base..ctor();
	}

	// Token: 0x0400048E RID: 1166
	[Token(Token = "0x400048E")]
	public static EndlessShooting Instance;

	// Token: 0x0400048F RID: 1167
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400048F")]
	public List<PlantType> cardOnBank;
}
