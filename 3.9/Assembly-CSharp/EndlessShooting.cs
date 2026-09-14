using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200021B RID: 539
[Token(Token = "0x200021B")]
public class EndlessShooting : MonoBehaviour
{
	// Token: 0x06000940 RID: 2368 RVA: 0x00031C04 File Offset: 0x0002FE04
	[Token(Token = "0x6000940")]
	[Address(RVA = "0x907EC0", Offset = "0x9064C0", VA = "0x180907EC0")]
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

	// Token: 0x06000941 RID: 2369 RVA: 0x00031C78 File Offset: 0x0002FE78
	[Token(Token = "0x6000941")]
	[Address(RVA = "0x908420", Offset = "0x906A20", VA = "0x180908420")]
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

	// Token: 0x06000942 RID: 2370 RVA: 0x00031CD8 File Offset: 0x0002FED8
	[Token(Token = "0x6000942")]
	[Address(RVA = "0x908020", Offset = "0x906620", VA = "0x180908020")]
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

	// Token: 0x06000943 RID: 2371 RVA: 0x00031D6C File Offset: 0x0002FF6C
	[Token(Token = "0x6000943")]
	[Address(RVA = "0x908500", Offset = "0x906B00", VA = "0x180908500")]
	public EndlessShooting()
	{
		List<PlantType> list = new List();
		this.cardOnBank = list;
		base..ctor();
	}

	// Token: 0x04000493 RID: 1171
	[Token(Token = "0x4000493")]
	public static EndlessShooting Instance;

	// Token: 0x04000494 RID: 1172
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000494")]
	public List<PlantType> cardOnBank;
}
