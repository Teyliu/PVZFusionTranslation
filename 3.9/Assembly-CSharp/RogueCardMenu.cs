using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000629 RID: 1577
[Token(Token = "0x2000629")]
public class RogueCardMenu : BaseMenu
{
	// Token: 0x06001DB9 RID: 7609 RVA: 0x0009E270 File Offset: 0x0009C470
	[Token(Token = "0x6001DB9")]
	[Address(RVA = "0x575800", Offset = "0x573E00", VA = "0x180575800")]
	public void SelectOption(RogueCardWindow rogueCardWindow)
	{
		ulong num;
		do
		{
			Dictionary<PlantType, int> plants = rogueCardWindow.plants;
			bool flag;
			if (flag)
			{
				List<PlantType> rogueCards = RogueManager.Instance.rogueCards;
			}
		}
		while (num != (ulong)0L);
		GameAPP.UIManager.Pop();
		Time.timeScale = GameAPP.config.gameSpeed;
		Board.Instance.TravelNextRound();
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06001DBA RID: 7610 RVA: 0x0009E2E0 File Offset: 0x0009C4E0
	[Token(Token = "0x6001DBA")]
	[Address(RVA = "0x575540", Offset = "0x573B40", VA = "0x180575540", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		this.InitCards();
		this.InitCards();
	}

	// Token: 0x06001DBB RID: 7611 RVA: 0x0009E300 File Offset: 0x0009C500
	[Token(Token = "0x6001DBB")]
	[Address(RVA = "0x575570", Offset = "0x573B70", VA = "0x180575570")]
	private void InitCards()
	{
		ulong num5;
		do
		{
			List<PlantType> ultimatePlants = Lawnf.GetUltimatePlants();
			Predicate<PlantType> <>9__3_ = RogueCardMenu.<>c.<>9__3_0;
			if (<>9__3_ == 0)
			{
				RogueCardMenu.<>c.<>9__3_0 = delegate(PlantType p)
				{
					bool flag2;
					bool flag3;
					PlantDataManager.PlantData plantData;
					return flag2 || flag3 || plantData.attackDamage == 0;
				};
			}
			int num = ultimatePlants.RemoveAll(<>9__3_);
			List<RogueCardWindow> list = this.cards;
			bool flag;
			if (flag)
			{
				int num2 = ultimatePlants._size;
				int num3 = global::UnityEngine.Random.Range(0, num2);
				num2 = num3;
				int num4 = ultimatePlants[num2];
				num4 = num3;
				ultimatePlants.RemoveAt(num4);
			}
		}
		while (num5 != (ulong)0L);
	}

	// Token: 0x06001DBC RID: 7612 RVA: 0x0009E38C File Offset: 0x0009C58C
	[Token(Token = "0x6001DBC")]
	[Address(RVA = "0x575A30", Offset = "0x574030", VA = "0x180575A30")]
	public RogueCardMenu()
	{
		List<RogueCardWindow> list = new List();
		this.cards = list;
		base..ctor();
	}

	// Token: 0x04001028 RID: 4136
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001028")]
	public List<RogueCardWindow> cards;
}
