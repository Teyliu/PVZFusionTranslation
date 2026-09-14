using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using GameLevel.EventNodes;
using PlantEvolution;
using RhythmGame;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

namespace GameLevel
{
	// Token: 0x02000B62 RID: 2914
	[Token(Token = "0x2000B62")]
	[Serializable]
	public class SerializedLevelData
	{
		// Token: 0x06003CC9 RID: 15561 RVA: 0x0013CD68 File Offset: 0x0013AF68
		[Token(Token = "0x6003CC9")]
		[Address(RVA = "0x8309D0", Offset = "0x82EFD0", VA = "0x1808309D0")]
		public SerializedLevelData Copy()
		{
			return JsonUtility.FromJson<SerializedLevelData>(JsonUtility.ToJson(this));
		}

		// Token: 0x06003CCA RID: 15562 RVA: 0x0013CD80 File Offset: 0x0013AF80
		[Token(Token = "0x6003CCA")]
		[Address(RVA = "0x8306A0", Offset = "0x82ECA0", VA = "0x1808306A0")]
		public CustomLevelData BuildLevel()
		{
			this.levelType = (LevelType)((ulong)11L);
			CustomLevelData customLevelData = new CustomLevelData();
			customLevelData.edit = true;
			customLevelData.edit = false;
			LevelType levelType = this.levelType;
			customLevelData.LevelType = levelType;
			int num = this.levelNumber;
			customLevelData.LevelNumber = num;
			string text = this.name;
			customLevelData.Name = text;
			SceneType sceneType = this.sceneType;
			customLevelData.SceneType = sceneType;
			List<ZombieType> spawnZombies = this.SpawnZombies;
			customLevelData.SpawnZombies = spawnZombies;
			int num2 = this.maxWave;
			customLevelData.MaxWave = num2;
			Action<Board> action;
			customLevelData.<CustomOnBoardAwake>k__BackingField = action;
			Action<Board> action2;
			customLevelData.<CustomOnBoardStart>k__BackingField = action2;
			Action<Board> action3;
			customLevelData.<CustomOnAnimUIOver>k__BackingField = action3;
			int num3 = this.cardCount;
			customLevelData.CardCount = num3;
			List<PlantType> list = this.preSelectCards;
			customLevelData.PreselectCards = list;
			List<ZombieType> list2 = this.preSelectCards_zombie;
			customLevelData.PreselectCards_zombie = list2;
			List<PlantDataManager.PlantData> list3 = this.plantDatas;
			customLevelData.PlantDatas = list3;
			List<ZombieDataManager.ZombieData> list4 = this.zombieDatas;
			customLevelData.<ZombieDatas>k__BackingField = list4;
			List<ScaryPotData> list5 = this.scaryPots;
			customLevelData.ScaryPotDatas = list5;
			BoardConfig boardConfig = this.boardConfig;
			customLevelData.Config = boardConfig;
			VictoryType victoryType = this.victoryType;
			customLevelData.VictoryType = victoryType;
			List<OrderedSpawn> list6 = this.orderedSpawns;
			customLevelData.OrderedSpawns = list6;
			customLevelData.<SerializedLevelData>k__BackingField = this;
			customLevelData.SceneType = (SceneType)((uint)39);
			return customLevelData;
		}

		// Token: 0x06003CCB RID: 15563 RVA: 0x0013CEC8 File Offset: 0x0013B0C8
		[Token(Token = "0x6003CCB")]
		[Address(RVA = "0x830EF0", Offset = "0x82F4F0", VA = "0x180830EF0")]
		private void OnBoardAwake(Board board)
		{
			this.ApplyBuffs(board);
			Board.BoardTag boardTag = this.boardTag;
			bool isScaredyDream = this.boardTag.isScaredyDream;
			bool isEndless = this.boardTag.isEndless;
			bool isFreeCardSelect = this.boardTag.isFreeCardSelect;
			bool freeGloveZombie = this.boardTag.freeGloveZombie;
			bool plantingZombie = this.boardTag.plantingZombie;
			board.boardTag = boardTag;
			board.boardTag.isScaredyDream = isScaredyDream;
			board.boardTag.isEndless = isEndless;
			board.boardTag.isFreeCardSelect = isFreeCardSelect;
			board.boardTag.freeGloveZombie = freeGloveZombie;
			board.boardTag.plantingZombie = plantingZombie;
			board.boardTag.disableSelectCard = true;
			board.cardBank = false;
			board.boardTag.disableSummonZombie = true;
			int redLineColumn = board.config.redLineColumn;
			board.SetRedLine(redLineColumn);
			int num = 0;
			board.UpdateRandomData(num != 0);
			if (this.GodShootingConfig != (ulong)0L)
			{
				GodEvolution.LoadDynamicFromConfig(this.GodShootingConfig);
				board.AddComponent<GodManager>().custom = true;
			}
			GameObject gameObject = Resources.Load<GameObject>("Board/Game/Rhyhm/RhyhmManager");
			Transform transform = board.transform;
			GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform);
			board.boardTag.disableSelectCard = true;
			board.boardTag.disableNormalSun = true;
			board.thePoints = 0f;
			board.theWave = (int)((ulong)1L);
		}

		// Token: 0x06003CCC RID: 15564 RVA: 0x0013D01C File Offset: 0x0013B21C
		[Token(Token = "0x6003CCC")]
		[Address(RVA = "0x8310F0", Offset = "0x82F6F0", VA = "0x1808310F0")]
		private void OnBoardStart(Board board)
		{
			SerializedLevelData.<>c__DisplayClass28_0 CS$<>8__locals1;
			Board board3;
			do
			{
				CS$<>8__locals1.board = board;
				Board board2 = CS$<>8__locals1.board;
				int num = this.startSun;
				if (this.scaryPots != (ulong)0L)
				{
					this.InitScaryPots();
				}
				if (this.plants != (ulong)0L)
				{
					bool flag;
					if (flag)
					{
					}
					ulong num2;
					if (num2 != (ulong)0L)
					{
						continue;
					}
				}
				board3 = CS$<>8__locals1.board;
			}
			while (typeof(IZVictory).TypeHandle != 0);
			if (new DefaultVictory() == (ulong)1L)
			{
				IZVictory izvictory = new IZVictory();
				board3.boardVicotry = izvictory;
			}
			Board board4 = CS$<>8__locals1.board;
			GameObject shovelBank = InGameUI.Instance.ShovelBank;
			int num3 = 0;
			shovelBank.SetActive(num3 != 0);
			Board board5 = CS$<>8__locals1.board;
			int theMaxWave = board5.theMaxWave;
			board5.theWave = theMaxWave;
			Board board6 = CS$<>8__locals1.board;
			Action action = delegate
			{
				Board board8 = CS$<>8__locals1.board;
				int theMaxWave2 = board8.theMaxWave;
				if (board8.theWave == theMaxWave2)
				{
					int theMaxWave3 = board8.theMaxWave;
					board8.theWave = theMaxWave3;
				}
			};
			int num4 = 0;
			EventManager.AddListener(GameEvent.BoardWaveAdd, action, num4 != 0);
			GameObject seedBank = InGameUI.Instance.SeedBank;
			int num5 = 0;
			seedBank.SetActive(num5 != 0);
			GameObject shovelBank2 = InGameUI.Instance.ShovelBank;
			int num6 = 0;
			shovelBank2.SetActive(num6 != 0);
			GameObject slowTrigger = InGameUI.Instance.SlowTrigger;
			int num7 = 0;
			slowTrigger.SetActive(num7 != 0);
			RhythmGameManager <Instance>k__BackingField = RhythmGameManager.<Instance>k__BackingField;
			Board board7 = CS$<>8__locals1.board;
			<Instance>k__BackingField.board = board7;
			string text;
			EventNodeGraph eventNodeGraph = JsonUtility.FromJson<EventNodeGraph>(text);
			EventNodeManager.Instance.RegisterGraph(eventNodeGraph);
			EventNodeManager.Instance.Initialize();
			UnityEvent dieEvent = CS$<>8__locals1.board.DieEvent;
			UnityAction unityAction = new UnityAction(EventNodeManager.Instance.Unregister);
			dieEvent.AddListener(unityAction);
		}

		// Token: 0x06003CCD RID: 15565 RVA: 0x0013D1B0 File Offset: 0x0013B3B0
		[Token(Token = "0x6003CCD")]
		[Address(RVA = "0x830220", Offset = "0x82E820", VA = "0x180830220")]
		private void ApplyBuffs(Board board)
		{
			ulong num6;
			do
			{
				int num = 0;
				List<AdvBuff> list = this.advBuffs;
				bool flag;
				if (flag)
				{
					TravelMgr.Instance.GetNormalBuff((AdvBuff)num);
				}
				ulong num2;
				if (num2 != (ulong)0L)
				{
					goto IL_0089;
				}
				bool flag2;
				if (flag2)
				{
					TravelMgr instance = TravelMgr.Instance;
					int num3 = 0;
					instance.GetUltiBuff((UltiBuff)num, num3 != 0);
				}
				ulong num4;
				if (num4 != (ulong)0L)
				{
					goto IL_008F;
				}
				bool flag3;
				if (flag3)
				{
					TravelMgr.Instance.GetUltiBuff((UltiBuff)num, true);
				}
				ulong num5;
				if (num5 != (ulong)0L)
				{
					goto IL_0095;
				}
				bool flag4;
				if (flag4)
				{
					TravelMgr.Instance.GetDebuff((TravelDebuff)num);
				}
			}
			while (num6 != (ulong)0L);
			return;
			IL_0089:
			throw new NullReferenceException();
			IL_008F:
			throw new NullReferenceException();
			IL_0095:
			throw new NullReferenceException();
		}

		// Token: 0x06003CCE RID: 15566 RVA: 0x0013D258 File Offset: 0x0013B458
		[Token(Token = "0x6003CCE")]
		[Address(RVA = "0x830DC0", Offset = "0x82F3C0", VA = "0x180830DC0")]
		private void OnAnimUIOver(Board board)
		{
			ulong num;
			do
			{
				List<OnGameStartNode> gameStartNodes = EventNodeManager.Instance.gameStartNodes;
				bool flag;
				if (flag)
				{
				}
			}
			while (num != (ulong)0L);
		}

		// Token: 0x06003CCF RID: 15567 RVA: 0x0013D28C File Offset: 0x0013B48C
		[Token(Token = "0x6003CCF")]
		[Address(RVA = "0x831630", Offset = "0x82FC30", VA = "0x180831630")]
		private void SetVictoryCondition(Board board)
		{
			VictoryType victoryType = this.victoryType;
			if (victoryType == VictoryType.DefaultVictory)
			{
				DefaultVictory defaultVictory = new DefaultVictory();
				board.boardVicotry = defaultVictory;
				return;
			}
			while (victoryType != VictoryType.IZVictory)
			{
			}
			IZVictory izvictory = new IZVictory();
			throw new NullReferenceException();
		}

		// Token: 0x06003CD0 RID: 15568 RVA: 0x0013D2C4 File Offset: 0x0013B4C4
		[Token(Token = "0x6003CD0")]
		[Address(RVA = "0x830A20", Offset = "0x82F020", VA = "0x180830A20")]
		private void InitScaryPots()
		{
			List<ScaryPotData> list;
			int num;
			do
			{
				list = this.scaryPots;
				num = 0;
				bool flag;
				if (flag)
				{
				}
			}
			while (num != 0);
			var <>9__32_ = SerializedLevelData.<>c.<>9__32_0;
			if (<>9__32_ == 0)
			{
				var func;
				SerializedLevelData.<>c.<>9__32_0 = func;
			}
			var list2 = Enumerable.ToList(Enumerable.Select(list, <>9__32_));
			ListExtensions.Shuffle(list2);
			int num2 = 0;
			List<ScaryPotData> list3 = this.scaryPots;
			ScaryPotData scaryPotData = this.scaryPots[num2];
			var anon = list2[num2];
			if (scaryPotData.thePlantType == PlantType.Nothing)
			{
				if (scaryPotData.theZombieType == ZombieType.Nothing)
				{
					goto IL_008C;
				}
				ZombieType theZombieType = scaryPotData.theZombieType;
			}
			PlantType thePlantType = scaryPotData.thePlantType;
			IL_008C:
			num2++;
			List<ScaryPotData> list4 = this.scaryPots;
		}

		// Token: 0x06003CD1 RID: 15569 RVA: 0x0013D374 File Offset: 0x0013B574
		[Token(Token = "0x6003CD1")]
		[Address(RVA = "0x8316D0", Offset = "0x82FCD0", VA = "0x1808316D0")]
		public SerializedLevelData()
		{
			List<ScaryPotData> list = new List();
			this.scaryPots = list;
			BoardConfig boardConfig = new BoardConfig();
			this.boardConfig = boardConfig;
			EventNodeGraph eventNodeGraph = new EventNodeGraph();
			this.eventNodeGraph = eventNodeGraph;
			List<PlantDataManager.PlantData> list2 = new List();
			this.plantDatas = list2;
			List<SavePlantData> list3 = new List();
			this.plants = list3;
			List<PlantType> list4 = new List();
			this.preSelectCards = list4;
			List<ZombieType> list5 = new List();
			this.preSelectCards_zombie = list5;
			List<AdvBuff> list6 = new List();
			this.advBuffs = list6;
			List<UltiBuff> list7 = new List();
			this.ultiBuffs2 = list7;
			List<UltiBuff> list8 = new List();
			this.ultiBuffs = list8;
			List<TravelDebuff> list9 = new List();
			this.travelDebuffs = list9;
			List<ZombieDataManager.ZombieData> list10 = new List();
			this.zombieDatas = list10;
			List<ZombieType> list11 = new List();
			this.SpawnZombies = list11;
			List<OrderedSpawn> list12 = new List();
			this.orderedSpawns = list12;
			this.startSun = (int)((ulong)500L);
			this.maxWave = (int)((ulong)10L);
			this.cardCount = (int)((ulong)14L);
			base..ctor();
		}

		// Token: 0x04002D37 RID: 11575
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002D37")]
		public List<ScaryPotData> scaryPots;

		// Token: 0x04002D38 RID: 11576
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002D38")]
		public VictoryType victoryType;

		// Token: 0x04002D39 RID: 11577
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002D39")]
		public BoardConfig boardConfig;

		// Token: 0x04002D3A RID: 11578
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002D3A")]
		public Board.BoardTag boardTag;

		// Token: 0x04002D3B RID: 11579
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002D3B")]
		public RhythmLevelData rhythmLevelData;

		// Token: 0x04002D3C RID: 11580
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4002D3C")]
		public EventNodeGraph eventNodeGraph;

		// Token: 0x04002D3D RID: 11581
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4002D3D")]
		public List<PlantDataManager.PlantData> plantDatas;

		// Token: 0x04002D3E RID: 11582
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4002D3E")]
		public List<SavePlantData> plants;

		// Token: 0x04002D3F RID: 11583
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4002D3F")]
		public List<PlantType> preSelectCards;

		// Token: 0x04002D40 RID: 11584
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4002D40")]
		public List<ZombieType> preSelectCards_zombie;

		// Token: 0x04002D41 RID: 11585
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4002D41")]
		public PlantEvolutionConfigLoader.EvolutionConfig GodShootingConfig;

		// Token: 0x04002D42 RID: 11586
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4002D42")]
		public List<AdvBuff> advBuffs;

		// Token: 0x04002D43 RID: 11587
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x4002D43")]
		public List<UltiBuff> ultiBuffs2;

		// Token: 0x04002D44 RID: 11588
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x4002D44")]
		public List<UltiBuff> ultiBuffs;

		// Token: 0x04002D45 RID: 11589
		[FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x4002D45")]
		public List<TravelDebuff> travelDebuffs;

		// Token: 0x04002D46 RID: 11590
		[FieldOffset(Offset = "0xE0")]
		[Token(Token = "0x4002D46")]
		public List<ZombieDataManager.ZombieData> zombieDatas;

		// Token: 0x04002D47 RID: 11591
		[FieldOffset(Offset = "0xE8")]
		[Token(Token = "0x4002D47")]
		public List<ZombieType> SpawnZombies;

		// Token: 0x04002D48 RID: 11592
		[FieldOffset(Offset = "0xF0")]
		[Token(Token = "0x4002D48")]
		public List<OrderedSpawn> orderedSpawns;

		// Token: 0x04002D49 RID: 11593
		[FieldOffset(Offset = "0xF8")]
		[Token(Token = "0x4002D49")]
		public SceneType sceneType;

		// Token: 0x04002D4A RID: 11594
		[FieldOffset(Offset = "0xFC")]
		[Token(Token = "0x4002D4A")]
		public LevelType levelType;

		// Token: 0x04002D4B RID: 11595
		[FieldOffset(Offset = "0x100")]
		[Token(Token = "0x4002D4B")]
		public int levelNumber;

		// Token: 0x04002D4C RID: 11596
		[FieldOffset(Offset = "0x108")]
		[Token(Token = "0x4002D4C")]
		public string name;

		// Token: 0x04002D4D RID: 11597
		[FieldOffset(Offset = "0x110")]
		[Token(Token = "0x4002D4D")]
		public int startSun;

		// Token: 0x04002D4E RID: 11598
		[FieldOffset(Offset = "0x114")]
		[Token(Token = "0x4002D4E")]
		public int maxWave;

		// Token: 0x04002D4F RID: 11599
		[FieldOffset(Offset = "0x118")]
		[Token(Token = "0x4002D4F")]
		public int cardCount;
	}
}
