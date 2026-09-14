using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine.Events;

namespace GameLevel
{
	// Token: 0x02000B14 RID: 2836
	[Token(Token = "0x2000B14")]
	public class CustomLevelData : LevelData
	{
		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06003B2A RID: 15146 RVA: 0x00136608 File Offset: 0x00134808
		// (set) Token: 0x06003B2B RID: 15147 RVA: 0x0013661C File Offset: 0x0013481C
		[Token(Token = "0x17000494")]
		public SerializedLevelData SerializedLevelData
		{
			[Token(Token = "0x6003B2A")]
			[Address(RVA = "0x7A23F0", Offset = "0x7A09F0", VA = "0x1807A23F0")]
			get;
			[Token(Token = "0x6003B2B")]
			[Address(RVA = "0x7A24A0", Offset = "0x7A0AA0", VA = "0x1807A24A0")]
			set;
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06003B2C RID: 15148 RVA: 0x00136630 File Offset: 0x00134830
		[Token(Token = "0x17000495")]
		public override LevelType LevelType
		{
			[Token(Token = "0x6003B2C")]
			[Address(RVA = "0x3ADAB0", Offset = "0x3AC0B0", VA = "0x1803ADAB0", Slot = "14")]
			get
			{
				return LevelType.CustomLevel;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06003B2D RID: 15149 RVA: 0x00136640 File Offset: 0x00134840
		// (set) Token: 0x06003B2E RID: 15150 RVA: 0x00136654 File Offset: 0x00134854
		[Token(Token = "0x17000496")]
		public Action<Board> CustomOnBoardAwake
		{
			[Token(Token = "0x6003B2D")]
			[Address(RVA = "0x70F770", Offset = "0x70DD70", VA = "0x18070F770")]
			get;
			[Token(Token = "0x6003B2E")]
			[Address(RVA = "0x7A2420", Offset = "0x7A0A20", VA = "0x1807A2420")]
			set;
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06003B2F RID: 15151 RVA: 0x00136668 File Offset: 0x00134868
		// (set) Token: 0x06003B30 RID: 15152 RVA: 0x0013667C File Offset: 0x0013487C
		[Token(Token = "0x17000497")]
		public Action<Board> CustomOnBoardStart
		{
			[Token(Token = "0x6003B2F")]
			[Address(RVA = "0x7A23C0", Offset = "0x7A09C0", VA = "0x1807A23C0")]
			get;
			[Token(Token = "0x6003B30")]
			[Address(RVA = "0x7A2440", Offset = "0x7A0A40", VA = "0x1807A2440")]
			set;
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06003B31 RID: 15153 RVA: 0x00136690 File Offset: 0x00134890
		// (set) Token: 0x06003B32 RID: 15154 RVA: 0x001366A4 File Offset: 0x001348A4
		[Token(Token = "0x17000498")]
		public Action<Board> CustomOnAnimUIOver
		{
			[Token(Token = "0x6003B31")]
			[Address(RVA = "0x7A23B0", Offset = "0x7A09B0", VA = "0x1807A23B0")]
			get;
			[Token(Token = "0x6003B32")]
			[Address(RVA = "0x7A2400", Offset = "0x7A0A00", VA = "0x1807A2400")]
			set;
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06003B33 RID: 15155 RVA: 0x001366B8 File Offset: 0x001348B8
		// (set) Token: 0x06003B34 RID: 15156 RVA: 0x001366CC File Offset: 0x001348CC
		[Token(Token = "0x17000499")]
		public Action<Plant> CustomReinforcePlant
		{
			[Token(Token = "0x6003B33")]
			[Address(RVA = "0x7A23D0", Offset = "0x7A09D0", VA = "0x1807A23D0")]
			get;
			[Token(Token = "0x6003B34")]
			[Address(RVA = "0x7A2460", Offset = "0x7A0A60", VA = "0x1807A2460")]
			set;
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06003B35 RID: 15157 RVA: 0x001366E0 File Offset: 0x001348E0
		// (set) Token: 0x06003B36 RID: 15158 RVA: 0x001366F4 File Offset: 0x001348F4
		[Token(Token = "0x1700049A")]
		public Action<Zombie> CustomReinforceZombie
		{
			[Token(Token = "0x6003B35")]
			[Address(RVA = "0x7A23E0", Offset = "0x7A09E0", VA = "0x1807A23E0")]
			get;
			[Token(Token = "0x6003B36")]
			[Address(RVA = "0x7A2480", Offset = "0x7A0A80", VA = "0x1807A2480")]
			set;
		}

		// Token: 0x06003B37 RID: 15159 RVA: 0x00136708 File Offset: 0x00134908
		[Token(Token = "0x6003B37")]
		[Address(RVA = "0x7A1D70", Offset = "0x7A0370", VA = "0x1807A1D70", Slot = "39")]
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

		// Token: 0x06003B38 RID: 15160 RVA: 0x001367B4 File Offset: 0x001349B4
		[Token(Token = "0x6003B38")]
		[Address(RVA = "0x7A1E20", Offset = "0x7A0420", VA = "0x1807A1E20", Slot = "36")]
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

		// Token: 0x06003B39 RID: 15161 RVA: 0x001367F4 File Offset: 0x001349F4
		[Token(Token = "0x6003B39")]
		[Address(RVA = "0x7A1D30", Offset = "0x7A0330", VA = "0x1807A1D30", Slot = "40")]
		public override void OnAnimUIOver(Board board)
		{
			base.OnAnimUIOver(board);
			if (this.<CustomOnAnimUIOver>k__BackingField != 0)
			{
			}
		}

		// Token: 0x06003B3A RID: 15162 RVA: 0x00136814 File Offset: 0x00134A14
		[Token(Token = "0x6003B3A")]
		[Address(RVA = "0x7A1EE0", Offset = "0x7A04E0", VA = "0x1807A1EE0", Slot = "34")]
		public override void ReinforcePlant(Plant plant)
		{
			base.ReinforcePlant(plant);
			if (this.<CustomReinforcePlant>k__BackingField != 0)
			{
			}
		}

		// Token: 0x06003B3B RID: 15163 RVA: 0x00136834 File Offset: 0x00134A34
		[Token(Token = "0x6003B3B")]
		[Address(RVA = "0x7A1F20", Offset = "0x7A0520", VA = "0x1807A1F20", Slot = "35")]
		public override void ReinforceZombie(Zombie zombie)
		{
			base.ReinforceZombie(zombie);
			if (this.<CustomReinforceZombie>k__BackingField != 0)
			{
			}
		}

		// Token: 0x06003B3C RID: 15164 RVA: 0x00136854 File Offset: 0x00134A54
		[Token(Token = "0x6003B3C")]
		[Address(RVA = "0x7A1F60", Offset = "0x7A0560", VA = "0x1807A1F60")]
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

		// Token: 0x06003B3D RID: 15165 RVA: 0x001368E4 File Offset: 0x00134AE4
		[Token(Token = "0x6003B3D")]
		[Address(RVA = "0x7A1FD0", Offset = "0x7A05D0", VA = "0x1807A1FD0")]
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
			int num3 = 0;
			instance2.ShowText("在这里种植的植物会在关卡开始时直接出现\n设置词条可在关卡开始时获得这些词条", 15f, num3 != 0);
			CustomLevelData.<>c__DisplayClass35_0 CS$<>8__locals1;
			CS$<>8__locals1.board = 0;
			Board board2 = CS$<>8__locals1.board;
			UnityAction unityAction = delegate
			{
				ulong num8;
				do
				{
					int num4 = 0;
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
						int num5 = 0;
						if (!(num4 != num5))
						{
							continue;
						}
						SavePlantData savePlantData = new SavePlantData(num4);
						List<SavePlantData> plants2 = levelData.plants;
					}
					ulong num6;
					if (num6 != (ulong)0L)
					{
						goto IL_0168;
					}
					bool flag3;
					if (flag3)
					{
						int num7 = 0;
						if (!(num4 != num7))
						{
							continue;
						}
						while (num4 == 0)
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
				while (num8 != (ulong)0L);
				return;
				IL_0168:
				throw new NullReferenceException();
			};
			UnityEvent unityEvent;
			unityEvent.AddListener(unityAction);
		}

		// Token: 0x06003B3E RID: 15166 RVA: 0x001369A4 File Offset: 0x00134BA4
		[Token(Token = "0x6003B3E")]
		[Address(RVA = "0x7A22D0", Offset = "0x7A08D0", VA = "0x1807A22D0")]
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

		// Token: 0x06003B3F RID: 15167 RVA: 0x001369E0 File Offset: 0x00134BE0
		[Token(Token = "0x6003B3F")]
		[Address(RVA = "0x7A23A0", Offset = "0x7A09A0", VA = "0x1807A23A0")]
		public CustomLevelData()
		{
		}

		// Token: 0x04002B8E RID: 11150
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002B8E")]
		public string levelId;

		// Token: 0x04002B8F RID: 11151
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002B8F")]
		public bool edit = true;
	}
}
