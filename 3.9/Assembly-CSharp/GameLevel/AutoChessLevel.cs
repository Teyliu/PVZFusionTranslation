using System;
using System.Collections.Generic;
using AutoChess;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel
{
	// Token: 0x02000B2C RID: 2860
	[Token(Token = "0x2000B2C")]
	public class AutoChessLevel : ChallengeLevelData
	{
		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06003B5D RID: 15197 RVA: 0x00137C7C File Offset: 0x00135E7C
		[Token(Token = "0x17000447")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x6003B5D")]
			[Address(RVA = "0x4D5510", Offset = "0x4D3B10", VA = "0x1804D5510", Slot = "42")]
			get
			{
				return ChallengeLevel.AutoChess;
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06003B5E RID: 15198 RVA: 0x00137C90 File Offset: 0x00135E90
		[Token(Token = "0x17000448")]
		public override string Name
		{
			[Token(Token = "0x6003B5E")]
			[Address(RVA = "0x7EA210", Offset = "0x7E8810", VA = "0x1807EA210", Slot = "8")]
			get
			{
				return "货币战争";
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06003B5F RID: 15199 RVA: 0x00137CA4 File Offset: 0x00135EA4
		[Token(Token = "0x17000449")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003B5F")]
			[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "12")]
			get
			{
				return SceneType.Day;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06003B60 RID: 15200 RVA: 0x00137CBC File Offset: 0x00135EBC
		[Token(Token = "0x1700044A")]
		public override int CardCount
		{
			[Token(Token = "0x6003B60")]
			[Address(RVA = "0x3F72C0", Offset = "0x3F58C0", VA = "0x1803F72C0", Slot = "6")]
			get
			{
				return 12;
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06003B61 RID: 15201 RVA: 0x00137CCC File Offset: 0x00135ECC
		// (set) Token: 0x06003B62 RID: 15202 RVA: 0x00137CDC File Offset: 0x00135EDC
		[Token(Token = "0x1700044B")]
		public override int MaxWave
		{
			[Token(Token = "0x6003B61")]
			[Address(RVA = "0x3F6A80", Offset = "0x3F5080", VA = "0x1803F6A80", Slot = "10")]
			get
			{
				return 100;
			}
			[Token(Token = "0x6003B62")]
			[Address(RVA = "0x7EA240", Offset = "0x7E8840", VA = "0x1807EA240", Slot = "11")]
			set
			{
				this.<MaxWave>k__BackingField = value;
			}
		}

		// Token: 0x06003B63 RID: 15203 RVA: 0x00137CF0 File Offset: 0x00135EF0
		[Token(Token = "0x6003B63")]
		[Address(RVA = "0x7E9CD0", Offset = "0x7E82D0", VA = "0x1807E9CD0", Slot = "39")]
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

		// Token: 0x06003B64 RID: 15204 RVA: 0x00137D84 File Offset: 0x00135F84
		[Token(Token = "0x6003B64")]
		[Address(RVA = "0x7E9E00", Offset = "0x7E8400", VA = "0x1807E9E00", Slot = "36")]
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

		// Token: 0x06003B65 RID: 15205 RVA: 0x00137DF0 File Offset: 0x00135FF0
		[Token(Token = "0x6003B65")]
		[Address(RVA = "0x7E9800", Offset = "0x7E7E00", VA = "0x1807E9800")]
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

		// Token: 0x06003B66 RID: 15206 RVA: 0x00137E40 File Offset: 0x00136040
		[Token(Token = "0x6003B66")]
		[Address(RVA = "0x7E98A0", Offset = "0x7E7EA0", VA = "0x1807E98A0")]
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

		// Token: 0x06003B67 RID: 15207 RVA: 0x00137EDC File Offset: 0x001360DC
		[Token(Token = "0x6003B67")]
		[Address(RVA = "0x7E9F00", Offset = "0x7E8500", VA = "0x1807E9F00")]
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

		// Token: 0x06003B68 RID: 15208 RVA: 0x00137FB8 File Offset: 0x001361B8
		[Token(Token = "0x6003B68")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "34")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x06003B69 RID: 15209 RVA: 0x00137FC8 File Offset: 0x001361C8
		[Token(Token = "0x6003B69")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "35")]
		public override void ReinforceZombie(Zombie zombie)
		{
		}

		// Token: 0x06003B6A RID: 15210 RVA: 0x00137FD8 File Offset: 0x001361D8
		[Token(Token = "0x6003B6A")]
		[Address(RVA = "0x7E9560", Offset = "0x7E7B60", VA = "0x1807E9560", Slot = "33")]
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

		// Token: 0x06003B6B RID: 15211 RVA: 0x00138060 File Offset: 0x00136260
		[Token(Token = "0x6003B6B")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public AutoChessLevel()
		{
		}
	}
}
