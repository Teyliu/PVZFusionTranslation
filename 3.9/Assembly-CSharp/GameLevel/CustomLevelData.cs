using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine.Events;

namespace GameLevel
{
	// Token: 0x02000B56 RID: 2902
	[Token(Token = "0x2000B56")]
	public class CustomLevelData : LevelData
	{
		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06003C7B RID: 15483 RVA: 0x0013B958 File Offset: 0x00139B58
		// (set) Token: 0x06003C7C RID: 15484 RVA: 0x0013B96C File Offset: 0x00139B6C
		[Token(Token = "0x170004E4")]
		public SerializedLevelData SerializedLevelData
		{
			[Token(Token = "0x6003C7B")]
			[Address(RVA = "0x81D910", Offset = "0x81BF10", VA = "0x18081D910")]
			get;
			[Token(Token = "0x6003C7C")]
			[Address(RVA = "0x81D9C0", Offset = "0x81BFC0", VA = "0x18081D9C0")]
			set;
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06003C7D RID: 15485 RVA: 0x0013B980 File Offset: 0x00139B80
		[Token(Token = "0x170004E5")]
		public override LevelType LevelType
		{
			[Token(Token = "0x6003C7D")]
			[Address(RVA = "0x3F9920", Offset = "0x3F7F20", VA = "0x1803F9920", Slot = "14")]
			get
			{
				return LevelType.CustomLevel;
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06003C7E RID: 15486 RVA: 0x0013B990 File Offset: 0x00139B90
		// (set) Token: 0x06003C7F RID: 15487 RVA: 0x0013B9A4 File Offset: 0x00139BA4
		[Token(Token = "0x170004E6")]
		public Action<Board> CustomOnBoardAwake
		{
			[Token(Token = "0x6003C7E")]
			[Address(RVA = "0x774CA0", Offset = "0x7732A0", VA = "0x180774CA0")]
			get;
			[Token(Token = "0x6003C7F")]
			[Address(RVA = "0x81D940", Offset = "0x81BF40", VA = "0x18081D940")]
			set;
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06003C80 RID: 15488 RVA: 0x0013B9B8 File Offset: 0x00139BB8
		// (set) Token: 0x06003C81 RID: 15489 RVA: 0x0013B9CC File Offset: 0x00139BCC
		[Token(Token = "0x170004E7")]
		public Action<Board> CustomOnBoardStart
		{
			[Token(Token = "0x6003C80")]
			[Address(RVA = "0x81D8E0", Offset = "0x81BEE0", VA = "0x18081D8E0")]
			get;
			[Token(Token = "0x6003C81")]
			[Address(RVA = "0x81D960", Offset = "0x81BF60", VA = "0x18081D960")]
			set;
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06003C82 RID: 15490 RVA: 0x0013B9E0 File Offset: 0x00139BE0
		// (set) Token: 0x06003C83 RID: 15491 RVA: 0x0013B9F4 File Offset: 0x00139BF4
		[Token(Token = "0x170004E8")]
		public Action<Board> CustomOnAnimUIOver
		{
			[Token(Token = "0x6003C82")]
			[Address(RVA = "0x81D8D0", Offset = "0x81BED0", VA = "0x18081D8D0")]
			get;
			[Token(Token = "0x6003C83")]
			[Address(RVA = "0x81D920", Offset = "0x81BF20", VA = "0x18081D920")]
			set;
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06003C84 RID: 15492 RVA: 0x0013BA08 File Offset: 0x00139C08
		// (set) Token: 0x06003C85 RID: 15493 RVA: 0x0013BA1C File Offset: 0x00139C1C
		[Token(Token = "0x170004E9")]
		public Action<Plant> CustomReinforcePlant
		{
			[Token(Token = "0x6003C84")]
			[Address(RVA = "0x81D8F0", Offset = "0x81BEF0", VA = "0x18081D8F0")]
			get;
			[Token(Token = "0x6003C85")]
			[Address(RVA = "0x81D980", Offset = "0x81BF80", VA = "0x18081D980")]
			set;
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06003C86 RID: 15494 RVA: 0x0013BA30 File Offset: 0x00139C30
		// (set) Token: 0x06003C87 RID: 15495 RVA: 0x0013BA44 File Offset: 0x00139C44
		[Token(Token = "0x170004EA")]
		public Action<Zombie> CustomReinforceZombie
		{
			[Token(Token = "0x6003C86")]
			[Address(RVA = "0x81D900", Offset = "0x81BF00", VA = "0x18081D900")]
			get;
			[Token(Token = "0x6003C87")]
			[Address(RVA = "0x81D9A0", Offset = "0x81BFA0", VA = "0x18081D9A0")]
			set;
		}

		// Token: 0x06003C88 RID: 15496 RVA: 0x0013BA58 File Offset: 0x00139C58
		[Token(Token = "0x6003C88")]
		[Address(RVA = "0x81D280", Offset = "0x81B880", VA = "0x18081D280", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			if (this.<CustomOnBoardAwake>k__BackingField != 0)
			{
			}
			if (this.edit)
			{
				board.boardTag.allScaryPotShow = true;
				board.boardTag.allCards = true;
				board.boardTag.disableInInterlude = true;
				board.boardTag.disableSummonZombie = true;
				board.boardTag.superCustomEditorMode = true;
				board.boardTag.enableAllTravelPlant = true;
				board.maxSun = (int)((ulong)1000000L);
				board.theSun = (int)((ulong)1000000L);
				board.maxMoney = (int)((ulong)1000000L);
				board.theMoney = (int)((ulong)1000000L);
			}
		}

		// Token: 0x06003C89 RID: 15497 RVA: 0x0013BB04 File Offset: 0x00139D04
		[Token(Token = "0x6003C89")]
		[Address(RVA = "0x81D330", Offset = "0x81B930", VA = "0x18081D330", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			if (this.<CustomOnBoardStart>k__BackingField != 0)
			{
			}
			this.OnAnimUIOver(board);
			InGameUI.Instance.UpperUI();
			if (this.edit)
			{
				this.SetupEditorUI(board);
			}
		}

		// Token: 0x06003C8A RID: 15498 RVA: 0x0013BB44 File Offset: 0x00139D44
		[Token(Token = "0x6003C8A")]
		[Address(RVA = "0x81D240", Offset = "0x81B840", VA = "0x18081D240", Slot = "40")]
		public override void OnAnimUIOver(Board board)
		{
			base.OnAnimUIOver(board);
			if (this.<CustomOnAnimUIOver>k__BackingField != 0)
			{
			}
		}

		// Token: 0x06003C8B RID: 15499 RVA: 0x0013BB64 File Offset: 0x00139D64
		[Token(Token = "0x6003C8B")]
		[Address(RVA = "0x81D3F0", Offset = "0x81B9F0", VA = "0x18081D3F0", Slot = "34")]
		public override void ReinforcePlant(Plant plant)
		{
			base.ReinforcePlant(plant);
			if (this.<CustomReinforcePlant>k__BackingField != 0)
			{
			}
		}

		// Token: 0x06003C8C RID: 15500 RVA: 0x0013BB84 File Offset: 0x00139D84
		[Token(Token = "0x6003C8C")]
		[Address(RVA = "0x81D430", Offset = "0x81BA30", VA = "0x18081D430", Slot = "35")]
		public override void ReinforceZombie(Zombie zombie)
		{
			base.ReinforceZombie(zombie);
			if (this.<CustomReinforceZombie>k__BackingField != 0)
			{
			}
		}

		// Token: 0x06003C8D RID: 15501 RVA: 0x0013BBA4 File Offset: 0x00139DA4
		[Token(Token = "0x6003C8D")]
		[Address(RVA = "0x81D470", Offset = "0x81BA70", VA = "0x18081D470")]
		private void SetupEditorMode(Board board)
		{
			board.boardTag.allScaryPotShow = true;
			board.boardTag.allCards = true;
			board.boardTag.disableInInterlude = true;
			board.boardTag.disableSummonZombie = true;
			board.boardTag.superCustomEditorMode = true;
			board.boardTag.enableAllTravelPlant = true;
			board.maxSun = (int)((ulong)1000000L);
			board.theSun = (int)((ulong)1000000L);
			board.maxMoney = (int)((ulong)1000000L);
			board.theMoney = (int)((ulong)1000000L);
		}

		// Token: 0x06003C8E RID: 15502 RVA: 0x0013BC34 File Offset: 0x00139E34
		[Token(Token = "0x6003C8E")]
		[Address(RVA = "0x81D4E0", Offset = "0x81BAE0", VA = "0x18081D4E0")]
		private void SetupEditorUI(Board board)
		{
			int num;
			do
			{
				InGameUI instance = InGameUI.Instance;
				instance.GloveBank.SetActive(true);
				instance.HammerBank.SetActive(true);
				instance.ShowCardBank.SetActive(true);
				HashSet<CardUI> cards = instance.cards;
				num = 0;
				bool flag;
				if (flag)
				{
				}
			}
			while (num != 0);
			int num2 = 0;
			Glove.Instance.fullCD = (float)num2;
			Hammer.Instance.fullCD = (float)num2;
			InGameText instance2 = InGameText.Instance;
			CustomLevelData.<>c__DisplayClass35_0 CS$<>8__locals1;
			CS$<>8__locals1.board = 0;
			Board board2 = CS$<>8__locals1.board;
			UnityAction unityAction = delegate
			{
				ulong num7;
				do
				{
					int num3 = 0;
					SerializedLevelData levelData = CustomMenu._levelData;
					List<SavePlantData> plants = levelData.plants;
					int size = plants._size;
					plants._size = (int)((ulong)0L);
					if (size > 0)
					{
					}
					List<ScaryPotData> scaryPots = levelData.scaryPots;
					int size2 = scaryPots._size;
					scaryPots._size = (int)((ulong)0L);
					if (size2 > 0)
					{
					}
					List<AdvBuff> advBuffs = TravelMgr.Instance.data.advBuffs;
					levelData.advBuffs = advBuffs;
					List<UltiBuff> ultiBuffs_lv = TravelMgr.Instance.data.ultiBuffs_lv2;
					levelData.ultiBuffs2 = ultiBuffs_lv;
					List<UltiBuff> ultiBuffs = TravelMgr.Instance.data.ultiBuffs;
					levelData.ultiBuffs = ultiBuffs;
					List<TravelDebuff> travelDebuffs = TravelMgr.Instance.data.travelDebuffs;
					levelData.travelDebuffs = travelDebuffs;
					List<Plant> plantArray = CS$<>8__locals1.board.boardEntity.plantArray;
					bool flag2;
					if (flag2)
					{
						int num4 = 0;
						if (!(num3 != num4))
						{
							continue;
						}
						SavePlantData savePlantData = new SavePlantData(num3);
						List<SavePlantData> plants2 = levelData.plants;
					}
					ulong num5;
					if (num5 != (ulong)0L)
					{
						goto IL_0168;
					}
					bool flag3;
					if (flag3)
					{
						int num6 = 0;
						if (!(num3 != num6))
						{
							continue;
						}
						while (num3 == 0)
						{
						}
						ScaryPotData scaryPotData = new ScaryPotData();
						scaryPotData.itemType = scaryPotData;
						scaryPotData.theColumn = scaryPotData;
						scaryPotData.theRow = scaryPotData;
						scaryPotData.thePlantType = scaryPotData;
						scaryPotData.theZombieType = scaryPotData;
						List<ScaryPotData> scaryPots2 = levelData.scaryPots;
					}
				}
				while (num7 != (ulong)0L);
				return;
				IL_0168:
				throw new NullReferenceException();
			};
			UnityEvent unityEvent;
			unityEvent.AddListener(unityAction);
		}

		// Token: 0x06003C8F RID: 15503 RVA: 0x0013BCE0 File Offset: 0x00139EE0
		[Token(Token = "0x6003C8F")]
		[Address(RVA = "0x81D7F0", Offset = "0x81BDF0", VA = "0x18081D7F0")]
		private void SetupLevelEndSave(Board board)
		{
			Board board2 = board;
			UnityAction unityAction = delegate
			{
				ulong num5;
				do
				{
					int num = 0;
					SerializedLevelData levelData = CustomMenu._levelData;
					List<SavePlantData> plants = levelData.plants;
					int size = plants._size;
					plants._size = (int)((ulong)0L);
					if (size > 0)
					{
					}
					List<ScaryPotData> scaryPots = levelData.scaryPots;
					int size2 = scaryPots._size;
					scaryPots._size = (int)((ulong)0L);
					if (size2 > 0)
					{
					}
					List<AdvBuff> advBuffs = TravelMgr.Instance.data.advBuffs;
					levelData.advBuffs = advBuffs;
					List<UltiBuff> ultiBuffs_lv = TravelMgr.Instance.data.ultiBuffs_lv2;
					levelData.ultiBuffs2 = ultiBuffs_lv;
					List<UltiBuff> ultiBuffs = TravelMgr.Instance.data.ultiBuffs;
					levelData.ultiBuffs = ultiBuffs;
					List<TravelDebuff> travelDebuffs = TravelMgr.Instance.data.travelDebuffs;
					levelData.travelDebuffs = travelDebuffs;
					List<Plant> plantArray = board.boardEntity.plantArray;
					bool flag;
					if (flag)
					{
						int num2 = 0;
						if (!(num != num2))
						{
							continue;
						}
						SavePlantData savePlantData = new SavePlantData(num);
						List<SavePlantData> plants2 = levelData.plants;
					}
					ulong num3;
					if (num3 != (ulong)0L)
					{
						goto IL_0168;
					}
					bool flag2;
					if (flag2)
					{
						int num4 = 0;
						if (!(num != num4))
						{
							continue;
						}
						while (num == 0)
						{
						}
						ScaryPotData scaryPotData = new ScaryPotData();
						scaryPotData.itemType = scaryPotData;
						scaryPotData.theColumn = scaryPotData;
						scaryPotData.theRow = scaryPotData;
						scaryPotData.thePlantType = scaryPotData;
						scaryPotData.theZombieType = scaryPotData;
						List<ScaryPotData> scaryPots2 = levelData.scaryPots;
					}
				}
				while (num5 != (ulong)0L);
				return;
				IL_0168:
				throw new NullReferenceException();
			};
			UnityEvent unityEvent;
			unityEvent.AddListener(unityAction);
		}

		// Token: 0x06003C90 RID: 15504 RVA: 0x0013BD1C File Offset: 0x00139F1C
		[Token(Token = "0x6003C90")]
		[Address(RVA = "0x81D8C0", Offset = "0x81BEC0", VA = "0x18081D8C0")]
		public CustomLevelData()
		{
		}

		// Token: 0x04002D02 RID: 11522
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002D02")]
		public string levelId;

		// Token: 0x04002D03 RID: 11523
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002D03")]
		public bool edit = true;
	}
}
