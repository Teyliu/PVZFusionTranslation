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
	// Token: 0x02000C04 RID: 3076
	[Token(Token = "0x2000C04")]
	public class RogueShooting : ChallengeLevelData
	{
		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x0600402B RID: 16427 RVA: 0x001541B4 File Offset: 0x001523B4
		[Token(Token = "0x170004C1")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x600402B")]
			[Address(RVA = "0x80F090", Offset = "0x80D690", VA = "0x18080F090", Slot = "42")]
			get
			{
				return ChallengeLevel.RogueShooting;
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x0600402C RID: 16428 RVA: 0x001541C8 File Offset: 0x001523C8
		[Token(Token = "0x170004C2")]
		public override string Name
		{
			[Token(Token = "0x600402C")]
			[Address(RVA = "0x80F0A0", Offset = "0x80D6A0", VA = "0x18080F0A0", Slot = "8")]
			get
			{
				return "诸神：进化，推荐难度0~3";
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x0600402D RID: 16429 RVA: 0x001541DC File Offset: 0x001523DC
		[Token(Token = "0x170004C3")]
		public override int MaxWave
		{
			[Token(Token = "0x600402D")]
			[Address(RVA = "0x3AAC80", Offset = "0x3A9280", VA = "0x1803AAC80", Slot = "10")]
			get
			{
				return 100;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x0600402E RID: 16430 RVA: 0x001541EC File Offset: 0x001523EC
		[Token(Token = "0x170004C4")]
		public override int CardCount
		{
			[Token(Token = "0x600402E")]
			[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "6")]
			get
			{
				return 1;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x0600402F RID: 16431 RVA: 0x001541FC File Offset: 0x001523FC
		[Token(Token = "0x170004C5")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x600402F")]
			[Address(RVA = "0x80F0D0", Offset = "0x80D6D0", VA = "0x18080F0D0", Slot = "20")]
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

		// Token: 0x06004030 RID: 16432 RVA: 0x00154274 File Offset: 0x00152474
		[Token(Token = "0x6004030")]
		[Address(RVA = "0x80EC50", Offset = "0x80D250", VA = "0x18080EC50", Slot = "35")]
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

		// Token: 0x06004031 RID: 16433 RVA: 0x001542B4 File Offset: 0x001524B4
		[Token(Token = "0x6004031")]
		[Address(RVA = "0x80EBA0", Offset = "0x80D1A0", VA = "0x18080EBA0", Slot = "34")]
		public override void ReinforcePlant(Plant plant)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06004032 RID: 16434 RVA: 0x001542D4 File Offset: 0x001524D4
		[Token(Token = "0x6004032")]
		[Address(RVA = "0x80EA90", Offset = "0x80D090", VA = "0x18080EA90", Slot = "39")]
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

		// Token: 0x06004033 RID: 16435 RVA: 0x0015434C File Offset: 0x0015254C
		[Token(Token = "0x6004033")]
		[Address(RVA = "0x80E950", Offset = "0x80CF50", VA = "0x18080E950", Slot = "40")]
		public override void OnAnimUIOver(Board board)
		{
			base.OnAnimUIOver(board);
			List<CardUI> cards = InGameUI.Instance.Cards;
			ShootingManager instance = ShootingManager.Instance;
			List<CardUI> cards2 = InGameUI.Instance.Cards;
			int num = 0;
			CardUI cardUI = cards2[num];
			int num2 = 0;
			int num3 = 0;
			instance.GetNewPlant((PlantType)num2, num3 != 0);
			GameObject seedBank = InGameUI.Instance.SeedBank;
			int num4 = 0;
			seedBank.SetActive(num4 != 0);
			this.SelectPlantCount();
		}

		// Token: 0x06004034 RID: 16436 RVA: 0x001543BC File Offset: 0x001525BC
		[Token(Token = "0x6004034")]
		[Address(RVA = "0x80ECB0", Offset = "0x80D2B0", VA = "0x18080ECB0")]
		private void SelectPlantCount()
		{
			UIResourcesLoader uimanager = GameAPP.UIManager;
			uint num;
			int count = (int)num;
			RogueShootingData shootingData = GameAPP.config.shootingData;
			int count3 = count;
			string text = string.Format("最多{0}株植物", shootingData);
			UnityAction unityAction = delegate
			{
				ShootingManager instance2 = ShootingManager.Instance;
				int count2 = count;
				instance2.maxPlantCount = count2;
			};
			bool flag = count3 >= (int)num;
			num += (uint)1;
			while (num <= (uint)5)
			{
			}
			InGameText instance = InGameText.Instance;
			int num2 = 0;
			instance.ShowText("请选择可用植物数量", 5f, num2 != 0);
			Delegate @delegate;
			if (@delegate == 0)
			{
			}
			if (@delegate != 0 && @delegate != 0)
			{
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		// Token: 0x06004035 RID: 16437 RVA: 0x00154470 File Offset: 0x00152670
		[Token(Token = "0x6004035")]
		[Address(RVA = "0x80CE90", Offset = "0x80B490", VA = "0x18080CE90")]
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
					Board.Instance.config.zombieHealthMultiplier = 2f;
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
					Board.Instance.config.zombieHealthMultiplier = 3f;
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
					Board.Instance.config.zombieHealthMultiplier = 4f;
					Board.Instance.config.zombieSpeedMultiplier = 1.5f;
					ShootingManager.Instance.difficulty = (int)((ulong)4L);
				};
				RogueShooting.<>c.<>9__15_3 = unityAction;
			}
			RogueShootingData shootingData3 = GameAPP.config.shootingData;
			List<DataRecord<int>> difficultyWin3 = GameAPP.config.shootingData.difficultyWin;
			uint num7;
			bool flag3 = shootingData3.GetValue<int>(difficultyWin3, (int)num7) != 0;
			InGameText instance = InGameText.Instance;
			int num8 = 0;
			instance.ShowText("请选择挑战难度", 5f, num8 != 0);
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

		// Token: 0x06004036 RID: 16438 RVA: 0x00154674 File Offset: 0x00152874
		[Token(Token = "0x6004036")]
		[Address(RVA = "0x80D960", Offset = "0x80BF60", VA = "0x18080D960")]
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
			UnityAction unityAction;
			if (RogueShooting.<>c.<>9__16_4 == 0)
			{
				unityAction = delegate
				{
					ShootingManager.Instance.maxStage = (int)((ulong)2147483647L);
					ShootingManager.Instance.endless = true;
				};
				RogueShooting.<>c.<>9__16_4 = unityAction;
			}
			InGameText instance = InGameText.Instance;
			int num8 = 0;
			instance.ShowText("请选择挑战进程", 5f, num8 != 0);
			if (ShootingManager.Instance.difficulty == 5)
			{
				Action action = new Action(this.CustomDebuff);
				Delegate @delegate = Delegate.Combine(unityAction, action);
				if (@delegate == 0)
				{
				}
				if (@delegate == 0 || @delegate == 0)
				{
					throw new InvalidCastException();
				}
			}
		}

		// Token: 0x06004037 RID: 16439 RVA: 0x001548EC File Offset: 0x00152AEC
		[Token(Token = "0x6004037")]
		[Address(RVA = "0x80BD50", Offset = "0x80A350", VA = "0x18080BD50")]
		private void CustomDebuff()
		{
			int num2;
			do
			{
				int num = 0;
				UIResourcesLoader uimanager = GameAPP.UIManager;
				num2 = 0;
				List<TravelDebuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				int size4 = list._size;
				int size5 = list._size;
				int size6 = list._size;
				int size7 = list._size;
				int size8 = list._size;
				int size9 = list._size;
				int size10 = list._size;
				int size11 = list._size;
				int size12 = list._size;
				int size13 = list._size;
				int size14 = list._size;
				int size15 = list._size;
				int size16 = list._size;
				int size17 = list._size;
				int size18 = list._size;
				int size19 = list._size;
				int size20 = list._size;
				Predicate<TravelDebuff> predicate;
				if (RogueShooting.<>c.<>9__17_0 == 0)
				{
					predicate = delegate(TravelDebuff debuff)
					{
						List<TravelDebuff> selectedDebuffs4 = ShootingManager.Instance.selectedDebuffs;
						bool flag2;
						return flag2;
					};
					RogueShooting.<>c.<>9__17_0 = predicate;
				}
				int num3 = list.RemoveAll(predicate);
				bool flag;
				if (flag)
				{
					RogueShooting.<>c__DisplayClass17_0 CS$<>8__locals1;
					CS$<>8__locals1.debuff = (TravelDebuff)num;
					TravelDebuff debuff2 = CS$<>8__locals1.debuff;
					string text;
					CS$<>8__locals1.debuffName = text;
					if ("每波僵尸数量增加" <= (ulong)19L)
					{
					}
					UnityAction unityAction = delegate
					{
						List<TravelDebuff> selectedDebuffs5 = ShootingManager.Instance.selectedDebuffs;
						TravelDebuff debuff3 = CS$<>8__locals1.debuff;
						int num5 = selectedDebuffs5._size + 1;
						selectedDebuffs5._size = num5;
						TravelMgr instance2 = TravelMgr.Instance;
						TravelDebuff debuff4 = CS$<>8__locals1.debuff;
						instance2.GetDebuff(debuff4);
						InGameText instance3 = InGameText.Instance;
						string debuffName = CS$<>8__locals1.debuffName;
						int size23 = ShootingManager.Instance.selectedDebuffs._size;
						string text4 = string.Format("已选择：{0}，当前共{1}个词条", debuffName, instance3);
					};
				}
			}
			while (num2 != 0);
			if (RogueShooting.<>c.<>9__17_1 == 0)
			{
				RogueShooting.<>c.<>9__17_1 = delegate(MultipleChoiceMenu menu, TheButton button)
				{
					InGameText instance4 = InGameText.Instance;
					int size24 = ShootingManager.Instance.selectedDebuffs._size;
					string text5 = string.Format("已完成词条选择，共{0}个僵尸词条", instance4);
					int num6 = 0;
					instance4.ShowText(text5, 3f, num6 != 0);
				};
			}
			List<TravelDebuff> selectedDebuffs = ShootingManager.Instance.selectedDebuffs;
			int size21 = ShootingManager.Instance.selectedDebuffs._size;
			string text2 = string.Format("你已经选择了所有{0}个可用的僵尸词条", size21);
			if (RogueShooting.<>c.<>9__17_2 == 0)
			{
				RogueShooting.<>c.<>9__17_2 = delegate
				{
				};
			}
			List<TravelDebuff> selectedDebuffs2 = ShootingManager.Instance.selectedDebuffs;
			List<TravelDebuff> selectedDebuffs3 = ShootingManager.Instance.selectedDebuffs;
			int size22 = selectedDebuffs3._size;
			string text3 = string.Format("请选择僵尸词条（可多选），已选：{0}个", selectedDebuffs3);
			InGameText instance = InGameText.Instance;
			int num4 = 0;
			instance.ShowText("请选择僵尸词条（可多选）", 5f, num4 != 0);
		}

		// Token: 0x06004038 RID: 16440 RVA: 0x00154B04 File Offset: 0x00152D04
		[Token(Token = "0x6004038")]
		[Address(RVA = "0x80E6A0", Offset = "0x80CCA0", VA = "0x18080E6A0")]
		private string GetDebuffDescription(TravelDebuff debuff)
		{
			if ("每波僵尸数量增加" <= (ulong)19L)
			{
				return "开局阳光归零";
			}
			return "未知词条";
		}

		// Token: 0x06004039 RID: 16441 RVA: 0x00154BA0 File Offset: 0x00152DA0
		[Token(Token = "0x6004039")]
		[Address(RVA = "0x6FAF20", Offset = "0x6F9520", VA = "0x1806FAF20")]
		public RogueShooting()
		{
		}
	}
}
