using System;
using System.Collections.Generic;
using AutoChess;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel
{
	// Token: 0x02000AEC RID: 2796
	[Token(Token = "0x2000AEC")]
	public class AutoChessLevel : ChallengeLevelData
	{
		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06003A19 RID: 14873 RVA: 0x00132C34 File Offset: 0x00130E34
		[Token(Token = "0x170003FF")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x6003A19")]
			[Address(RVA = "0x47DB90", Offset = "0x47C190", VA = "0x18047DB90", Slot = "42")]
			get
			{
				return ChallengeLevel.AutoChess;
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06003A1A RID: 14874 RVA: 0x00132C48 File Offset: 0x00130E48
		[Token(Token = "0x17000400")]
		public override string Name
		{
			[Token(Token = "0x6003A1A")]
			[Address(RVA = "0x783360", Offset = "0x781960", VA = "0x180783360", Slot = "8")]
			get
			{
				return "货币战争";
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06003A1B RID: 14875 RVA: 0x00132C5C File Offset: 0x00130E5C
		[Token(Token = "0x17000401")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003A1B")]
			[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "12")]
			get
			{
				return SceneType.Day;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06003A1C RID: 14876 RVA: 0x00132C74 File Offset: 0x00130E74
		[Token(Token = "0x17000402")]
		public override int CardCount
		{
			[Token(Token = "0x6003A1C")]
			[Address(RVA = "0x3AB4C0", Offset = "0x3A9AC0", VA = "0x1803AB4C0", Slot = "6")]
			get
			{
				return 12;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06003A1D RID: 14877 RVA: 0x00132C84 File Offset: 0x00130E84
		// (set) Token: 0x06003A1E RID: 14878 RVA: 0x00132C94 File Offset: 0x00130E94
		[Token(Token = "0x17000403")]
		public override int MaxWave
		{
			[Token(Token = "0x6003A1D")]
			[Address(RVA = "0x3AAC80", Offset = "0x3A9280", VA = "0x1803AAC80", Slot = "10")]
			get
			{
				return 100;
			}
			[Token(Token = "0x6003A1E")]
			[Address(RVA = "0x783390", Offset = "0x781990", VA = "0x180783390", Slot = "11")]
			set
			{
				this.<MaxWave>k__BackingField = value;
			}
		}

		// Token: 0x06003A1F RID: 14879 RVA: 0x00132CA8 File Offset: 0x00130EA8
		[Token(Token = "0x6003A1F")]
		[Address(RVA = "0x782E20", Offset = "0x781420", VA = "0x180782E20", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			if (this.CardCount != 0)
			{
				int cardCount = this.CardCount;
				board.cardCountLimit = cardCount;
			}
			BoardConfig boardConfig = base.Config.Copy();
			board.config = boardConfig;
			float firstWaveArrivedTimer = base.Config.firstWaveArrivedTimer;
			board.timeUntilNextWave = firstWaveArrivedTimer;
			board.boardTag.disableInInterlude = true;
			board.boardTag.disableMower = true;
			board.boardTag.disableNormalSun = true;
			board.boardTag.disableSummonZombie = true;
			TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)1000));
		}

		// Token: 0x06003A20 RID: 14880 RVA: 0x00132D3C File Offset: 0x00130F3C
		[Token(Token = "0x6003A20")]
		[Address(RVA = "0x782F50", Offset = "0x781550", VA = "0x180782F50", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			InGameUI.Instance.GloveBank.SetActive(true);
			this.StartAutoChess(board);
			this.InitZombieRows();
			int num = 0;
			if (num < board.columnNum)
			{
				int num2 = 0;
				GridItem gridItem = GridItem.SetGridItem(num, 1, (GridItemType)((uint)7), (GraveType)num2);
				int num3 = 0;
				GridItem gridItem2 = GridItem.SetGridItem(num, 2, (GridItemType)((uint)7), (GraveType)num3);
				int num4 = 0;
				GridItem gridItem3 = GridItem.SetGridItem(num, 3, (GridItemType)((uint)7), (GraveType)num4);
				num++;
			}
		}

		// Token: 0x06003A21 RID: 14881 RVA: 0x00132DA8 File Offset: 0x00130FA8
		[Token(Token = "0x6003A21")]
		[Address(RVA = "0x782950", Offset = "0x780F50", VA = "0x180782950")]
		private void FillGraves(Board board)
		{
			int num = 0;
			if (num < board.columnNum)
			{
				int num2 = 0;
				GridItem gridItem = GridItem.SetGridItem(num, 1, (GridItemType)((uint)7), (GraveType)num2);
				int num3 = 0;
				GridItem gridItem2 = GridItem.SetGridItem(num, 2, (GridItemType)((uint)7), (GraveType)num3);
				int num4 = 0;
				GridItem gridItem3 = GridItem.SetGridItem(num, 3, (GridItemType)((uint)7), (GraveType)num4);
				num++;
			}
		}

		// Token: 0x06003A22 RID: 14882 RVA: 0x00132DF8 File Offset: 0x00130FF8
		[Token(Token = "0x6003A22")]
		[Address(RVA = "0x7829F0", Offset = "0x780FF0", VA = "0x1807829F0")]
		private void InitZombieRows()
		{
			int num4;
			do
			{
				int num = 0;
				List<ZombieSpawnData> list = InitZombieList.zombieList[num];
				bool flag;
				if (flag)
				{
				}
				if (num != 0)
				{
					goto IL_0083;
				}
				int num2 = 0;
				num++;
				List<ZombieSpawnData> list2 = InitZombieList.zombieList[41];
				bool flag2;
				if (flag2)
				{
					int num3 = global::UnityEngine.Random.Range(0, 2);
				}
				if (num2 != 0)
				{
					goto IL_0089;
				}
				num4 = 0;
				uint num5;
				num5 += (uint)1;
				List<List<ZombieSpawnData>> zombieList = InitZombieList.zombieList;
				List<ZombieSpawnData> list3 = InitZombieList.zombieList[41];
				bool flag3;
				if (flag3)
				{
					int num6 = global::UnityEngine.Random.Range(0, 3);
				}
			}
			while (num4 != 0);
			uint num7;
			num7 += (uint)1;
			return;
			IL_0083:
			throw new NullReferenceException();
			IL_0089:
			throw new NullReferenceException();
		}

		// Token: 0x06003A23 RID: 14883 RVA: 0x00132E94 File Offset: 0x00131094
		[Token(Token = "0x6003A23")]
		[Address(RVA = "0x783050", Offset = "0x781650", VA = "0x180783050")]
		public void StartAutoChess(Board board)
		{
			Debug.Log("[AutoChessLevel] ========== 手动启动自走棋系统 ==========");
			Debug.Log("[AutoChessLevel] 1/6 - 添加经济系统...");
			EconomyManager economyManager = board.gameObject.AddComponent<EconomyManager>();
			Debug.Log("[AutoChessLevel] 2/6 - 添加商店系统...");
			ShopManager shopManager = board.gameObject.AddComponent<ShopManager>();
			Debug.Log("[AutoChessLevel] 3/6 - 添加羁绊系统...");
			global::AutoChess.SynergyManager synergyManager = board.gameObject.AddComponent<global::AutoChess.SynergyManager>();
			Debug.Log("[AutoChessLevel] 4/6 - 添加回合系统...");
			RoundManager roundManager = board.gameObject.AddComponent<RoundManager>();
			Debug.Log("[AutoChessLevel] 5/6 - 添加UI系统...");
			AutoChessUI autoChessUI = board.gameObject.AddComponent<AutoChessUI>();
			Debug.Log("[AutoChessLevel] 6/6 - 添加存档系统...");
			AutoChessSaveSystem instance = AutoChessSaveSystem.Instance;
			Debug.Log("[AutoChessLevel] ========== 自走棋系统启动完成！===========");
			string text;
			Debug.LogError(text);
		}

		// Token: 0x06003A24 RID: 14884 RVA: 0x00132F70 File Offset: 0x00131170
		[Token(Token = "0x6003A24")]
		[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "34")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x06003A25 RID: 14885 RVA: 0x00132F80 File Offset: 0x00131180
		[Token(Token = "0x6003A25")]
		[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "35")]
		public override void ReinforceZombie(Zombie zombie)
		{
		}

		// Token: 0x06003A26 RID: 14886 RVA: 0x00132F90 File Offset: 0x00131190
		[Token(Token = "0x6003A26")]
		[Address(RVA = "0x7826B0", Offset = "0x780CB0", VA = "0x1807826B0", Slot = "33")]
		public override bool ClickCard(CardUI card)
		{
			if (card != 0)
			{
				if (typeof(SpecialCard).TypeHandle != (ulong)1L)
				{
					goto IL_0073;
				}
				RoundManager <Instance>k__BackingField = RoundManager.<Instance>k__BackingField;
				ShopManager <Instance>k__BackingField2 = ShopManager.<Instance>k__BackingField;
				ulong num;
				if (num == (ulong)0L)
				{
				}
				bool flag = !ShopManager.<Instance>k__BackingField.isShopLocked;
				<Instance>k__BackingField2.IsShopLocked = flag;
				bool flag2 = ShopManager.<Instance>k__BackingField.RerollShop();
				bool flag3 = ShopManager.<Instance>k__BackingField.BuyExperience();
			}
			ShopManager <Instance>k__BackingField3 = ShopManager.<Instance>k__BackingField;
			int num2 = InGameUI.Instance.Cards.IndexOf(card);
			PlantData plantData = <Instance>k__BackingField3.PurchasePlant(num2);
			IL_0073:
			throw new NullReferenceException();
		}

		// Token: 0x06003A27 RID: 14887 RVA: 0x00133018 File Offset: 0x00131218
		[Token(Token = "0x6003A27")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public AutoChessLevel()
		{
		}
	}
}
