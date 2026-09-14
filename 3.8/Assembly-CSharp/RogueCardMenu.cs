using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005F4 RID: 1524
[Token(Token = "0x20005F4")]
public class RogueCardMenu : BaseMenu
{
	// Token: 0x06001CBA RID: 7354 RVA: 0x00099718 File Offset: 0x00097918
	[Token(Token = "0x6001CBA")]
	[Address(RVA = "0x51B670", Offset = "0x519C70", VA = "0x18051B670")]
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

	// Token: 0x06001CBB RID: 7355 RVA: 0x00099788 File Offset: 0x00097988
	[Token(Token = "0x6001CBB")]
	[Address(RVA = "0x51B3B0", Offset = "0x5199B0", VA = "0x18051B3B0", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		this.InitCards();
		this.InitCards();
	}

	// Token: 0x06001CBC RID: 7356 RVA: 0x000997A8 File Offset: 0x000979A8
	[Token(Token = "0x6001CBC")]
	[Address(RVA = "0x51B3E0", Offset = "0x5199E0", VA = "0x18051B3E0")]
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

	// Token: 0x06001CBD RID: 7357 RVA: 0x00099834 File Offset: 0x00097A34
	[Token(Token = "0x6001CBD")]
	[Address(RVA = "0x51B8A0", Offset = "0x519EA0", VA = "0x18051B8A0")]
	public RogueCardMenu()
	{
		List<RogueCardWindow> list = new List();
		this.cards = list;
		base..ctor();
	}

	// Token: 0x04000F60 RID: 3936
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000F60")]
	public List<RogueCardWindow> cards;
}
