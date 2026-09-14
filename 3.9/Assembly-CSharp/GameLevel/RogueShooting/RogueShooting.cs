using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CBE RID: 3262
	[Token(Token = "0x2000CBE")]
	public class RogueShooting : ChallengeLevelData
	{
		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x0600439A RID: 17306 RVA: 0x00160B7C File Offset: 0x0015ED7C
		[Token(Token = "0x170005E6")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x600439A")]
			[Address(RVA = "0x891C40", Offset = "0x890240", VA = "0x180891C40", Slot = "42")]
			get
			{
				return ChallengeLevel.RogueShooting;
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x0600439B RID: 17307 RVA: 0x00160B90 File Offset: 0x0015ED90
		[Token(Token = "0x170005E7")]
		public override string Name
		{
			[Token(Token = "0x600439B")]
			[Address(RVA = "0x891C50", Offset = "0x890250", VA = "0x180891C50", Slot = "8")]
			get
			{
				return "诸神：进化，推荐难度0~3";
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x0600439C RID: 17308 RVA: 0x00160BA4 File Offset: 0x0015EDA4
		[Token(Token = "0x170005E8")]
		public override int MaxWave
		{
			[Token(Token = "0x600439C")]
			[Address(RVA = "0x3F6A80", Offset = "0x3F5080", VA = "0x1803F6A80", Slot = "10")]
			get
			{
				return 100;
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x0600439D RID: 17309 RVA: 0x00160BB4 File Offset: 0x0015EDB4
		[Token(Token = "0x170005E9")]
		public override int CardCount
		{
			[Token(Token = "0x600439D")]
			[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "6")]
			get
			{
				return 1;
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x0600439E RID: 17310 RVA: 0x00160BC4 File Offset: 0x0015EDC4
		[Token(Token = "0x170005EA")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x600439E")]
			[Address(RVA = "0x891C80", Offset = "0x890280", VA = "0x180891C80", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				int size4 = list._size;
				int size5 = list._size;
				int size6 = list._size;
				int size7 = list._size;
				int size8 = list._size;
				int size9 = list._size;
				return list;
			}
		}

		// Token: 0x0600439F RID: 17311 RVA: 0x00160C3C File Offset: 0x0015EE3C
		[Token(Token = "0x600439F")]
		[Address(RVA = "0x891BD0", Offset = "0x8901D0", VA = "0x180891BD0", Slot = "35")]
		public override void ReinforceZombie(Zombie zombie)
		{
			base.ReinforceZombie(zombie);
			if (!zombie.isMindControlled)
			{
				BoardConfig config = zombie.board.config;
				float theArmor = zombie.theArmor;
				zombie.theArmor = theArmor;
			}
		}

		// Token: 0x060043A0 RID: 17312 RVA: 0x00160C7C File Offset: 0x0015EE7C
		[Token(Token = "0x60043A0")]
		[Address(RVA = "0x891B20", Offset = "0x890120", VA = "0x180891B20", Slot = "34")]
		public override void ReinforcePlant(Plant plant)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x060043A1 RID: 17313 RVA: 0x00160C9C File Offset: 0x0015EE9C
		[Token(Token = "0x60043A1")]
		[Address(RVA = "0x891A10", Offset = "0x890010", VA = "0x180891A10", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.AddComponent<ShootingManager>().board = board;
			board.cardBank = false;
			board.timeUntilNextWave = 3f;
			board.boardTag.isShooting = true;
			TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)1000));
			TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)1018));
			TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)18));
		}

		// Token: 0x060043A2 RID: 17314 RVA: 0x00160D14 File Offset: 0x0015EF14
		[Token(Token = "0x60043A2")]
		[Address(RVA = "0x8918C0", Offset = "0x88FEC0", VA = "0x1808918C0", Slot = "40")]
		public override void OnAnimUIOver(Board board)
		{
			base.OnAnimUIOver(board);
			List<CardUI> cards = InGameUI.Instance.Cards;
			ShootingManager instance = ShootingManager.Instance;
			List<CardUI> cards2 = InGameUI.Instance.Cards;
			int num = 0;
			CardUI cardUI = cards2[num];
			int num2 = 0;
			instance.GetNewPlant((PlantType)num2);
			GameObject seedBank = InGameUI.Instance.SeedBank;
			int num3 = 0;
			seedBank.SetActive(num3 != 0);
			throw new NullReferenceException();
		}

		// Token: 0x060043A3 RID: 17315 RVA: 0x00160D78 File Offset: 0x0015EF78
		[Token(Token = "0x60043A3")]
		[Address(RVA = "0x891C30", Offset = "0x890230", VA = "0x180891C30", Slot = "43")]
		protected virtual void SelectPlantCount()
		{
			this.CustomDifficulty();
		}

		// Token: 0x060043A4 RID: 17316 RVA: 0x00160D8C File Offset: 0x0015EF8C
		[Token(Token = "0x60043A4")]
		[Address(RVA = "0x890130", Offset = "0x88E730", VA = "0x180890130")]
		private void CustomDifficulty()
		{
			UIResourcesLoader uimanager = GameAPP.UIManager;
			uint num;
			string text = GameAPP.config.shootingData.DifficultyDescription((int)num);
			string text2 = "额外5次刷新机会，正常僵尸数量\n\n" + text;
			if (RogueShooting.<>c.<>9__15_0 == 0)
			{
				RogueShooting.<>c.<>9__15_0 = delegate
				{
					ShootingManager instance2 = ShootingManager.Instance;
					ShootingManager.Instance.difficulty = (int)((ulong)1L);
					ShootingManager.Instance.BaseHealthMulitpier = 1f;
				};
			}
			uint num2;
			string text3 = GameAPP.config.shootingData.DifficultyDescription((int)num2);
			string text4 = "额外4次刷新机会，僵尸血量x2\n\n" + text3;
			if (RogueShooting.<>c.<>9__15_1 == 0)
			{
				RogueShooting.<>c.<>9__15_1 = delegate
				{
					ShootingManager instance3 = ShootingManager.Instance;
					ShootingManager.Instance.BaseHealthMulitpier = 2f;
					ShootingManager.Instance.difficulty = (int)((ulong)2L);
				};
			}
			RogueShootingData shootingData = GameAPP.config.shootingData;
			List<DataRecord<int>> difficultyWin = GameAPP.config.shootingData.difficultyWin;
			uint num3;
			bool flag = shootingData.GetValue<int>(difficultyWin, (int)num3) != 0;
			uint num4;
			string text5 = GameAPP.config.shootingData.DifficultyDescription((int)num4);
			string text6 = "额外3次刷新机会，僵尸血量x3\n\n" + text5;
			if (RogueShooting.<>c.<>9__15_2 == 0)
			{
				RogueShooting.<>c.<>9__15_2 = delegate
				{
					ShootingManager instance4 = ShootingManager.Instance;
					ShootingManager.Instance.BaseHealthMulitpier = 3f;
					ShootingManager.Instance.difficulty = (int)((ulong)3L);
				};
			}
			RogueShootingData shootingData2 = GameAPP.config.shootingData;
			List<DataRecord<int>> difficultyWin2 = GameAPP.config.shootingData.difficultyWin;
			uint num5;
			bool flag2 = shootingData2.GetValue<int>(difficultyWin2, (int)num5) != 0;
			uint num6;
			string text7 = GameAPP.config.shootingData.DifficultyDescription((int)num6);
			string text8 = "额外2次刷新机会，僵尸血量x4，速度x1.5\n\n" + text7;
			UnityAction unityAction;
			if (RogueShooting.<>c.<>9__15_3 == 0)
			{
				unityAction = delegate
				{
					ShootingManager instance5 = ShootingManager.Instance;
					ShootingManager.Instance.BaseHealthMulitpier = 4f;
					ShootingManager.Instance.BaseSpeedMultiplier = 1.5f;
					ShootingManager.Instance.difficulty = (int)((ulong)4L);
				};
				RogueShooting.<>c.<>9__15_3 = unityAction;
			}
			RogueShootingData shootingData3 = GameAPP.config.shootingData;
			List<DataRecord<int>> difficultyWin3 = GameAPP.config.shootingData.difficultyWin;
			uint num7;
			bool flag3 = shootingData3.GetValue<int>(difficultyWin3, (int)num7) != 0;
			InGameText instance = InGameText.Instance;
			Action action = new Action(this.CustomStage);
			Delegate @delegate = Delegate.Combine(unityAction, action);
			if (@delegate == 0)
			{
			}
			if (@delegate != 0 && @delegate != 0)
			{
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		// Token: 0x060043A5 RID: 17317 RVA: 0x00160F78 File Offset: 0x0015F178
		[Token(Token = "0x60043A5")]
		[Address(RVA = "0x890C10", Offset = "0x88F210", VA = "0x180890C10")]
		private void CustomStage()
		{
			UIResourcesLoader uimanager = GameAPP.UIManager;
			RogueShootingData shootingData = GameAPP.config.shootingData;
			int num = 0;
			string text = shootingData.StageDescription(num);
			string text2 = "经典的诸神进化\n\n" + text;
			if (RogueShooting.<>c.<>9__16_0 == 0)
			{
				RogueShooting.<>c.<>9__16_0 = delegate
				{
					ShootingManager.Instance.maxStage = (int)((ulong)0L);
				};
			}
			uint num2;
			string text3 = GameAPP.config.shootingData.StageDescription((int)num2);
			string text4 = "最终面临大帅的挑战\n\n" + text3;
			if (RogueShooting.<>c.<>9__16_1 == 0)
			{
				RogueShooting.<>c.<>9__16_1 = delegate
				{
					ShootingManager.Instance.maxStage = (int)((ulong)1L);
				};
			}
			RogueShootingData shootingData2 = GameAPP.config.shootingData;
			RogueShootingData shootingData3 = GameAPP.config.shootingData;
			int num3 = 0;
			List<DataRecord<int>> stageWins = shootingData3.stageWins;
			bool flag = shootingData2.GetValue<int>(stageWins, num3) != 0;
			uint num4;
			string text5 = GameAPP.config.shootingData.StageDescription((int)num4);
			string text6 = "1次轮回，最终面临僵王的挑战\n\n" + text5;
			if (RogueShooting.<>c.<>9__16_2 == 0)
			{
				RogueShooting.<>c.<>9__16_2 = delegate
				{
					ShootingManager.Instance.maxStage = (int)((ulong)2L);
				};
			}
			RogueShootingData shootingData4 = GameAPP.config.shootingData;
			List<DataRecord<int>> stageWins2 = GameAPP.config.shootingData.stageWins;
			uint num5;
			bool flag2 = shootingData4.GetValue<int>(stageWins2, (int)num5) != 0;
			uint num6;
			string text7 = GameAPP.config.shootingData.StageDescription((int)num6);
			string text8 = "2次轮回，最终面临黄金僵王的挑战\n\n" + text7;
			if (RogueShooting.<>c.<>9__16_3 == 0)
			{
				RogueShooting.<>c.<>9__16_3 = delegate
				{
					ShootingManager.Instance.maxStage = (int)((ulong)3L);
				};
			}
			RogueShootingData shootingData5 = GameAPP.config.shootingData;
			List<DataRecord<int>> stageWins3 = GameAPP.config.shootingData.stageWins;
			uint num7;
			bool flag3 = shootingData5.GetValue<int>(stageWins3, (int)num7) != 0;
			if (GameAPP.config.shootingData.victoryTimes < 20)
			{
			}
			if ("？？？" == 0)
			{
			}
			int maxStage = GameAPP.config.shootingData.maxStage;
			string text9 = string.Format("无尽模式，你能撑到第几轮？\n\n最大轮数：{0}", maxStage);
			if (RogueShooting.<>c.<>9__16_4 == 0)
			{
				RogueShooting.<>c.<>9__16_4 = delegate
				{
					ShootingManager.Instance.maxStage = (int)((ulong)2147483647L);
					ShootingManager.Instance.endless = true;
				};
			}
			ShootingManager.Instance.UpdateZombieData();
			InGameText instance = InGameText.Instance;
		}

		// Token: 0x060043A6 RID: 17318 RVA: 0x001611A4 File Offset: 0x0015F3A4
		[Token(Token = "0x60043A6")]
		[Address(RVA = "0x7602C0", Offset = "0x75E8C0", VA = "0x1807602C0")]
		public RogueShooting()
		{
		}
	}
}
