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
	// Token: 0x02000B20 RID: 2848
	[Token(Token = "0x2000B20")]
	[Serializable]
	public class SerializedLevelData
	{
		// Token: 0x06003B78 RID: 15224 RVA: 0x00137A8C File Offset: 0x00135C8C
		[Token(Token = "0x6003B78")]
		[Address(RVA = "0x7B5090", Offset = "0x7B3690", VA = "0x1807B5090")]
		public SerializedLevelData Copy()
		{
			return JsonUtility.FromJson<SerializedLevelData>(JsonUtility.ToJson(this));
		}

		// Token: 0x06003B79 RID: 15225 RVA: 0x00137AA4 File Offset: 0x00135CA4
		[Token(Token = "0x6003B79")]
		[Address(RVA = "0x7B4D60", Offset = "0x7B3360", VA = "0x1807B4D60")]
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

		// Token: 0x06003B7A RID: 15226 RVA: 0x00137BEC File Offset: 0x00135DEC
		[Token(Token = "0x6003B7A")]
		[Address(RVA = "0x7B55B0", Offset = "0x7B3BB0", VA = "0x1807B55B0")]
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

		// Token: 0x06003B7B RID: 15227 RVA: 0x00137D40 File Offset: 0x00135F40
		[Token(Token = "0x6003B7B")]
		[Address(RVA = "0x7B57B0", Offset = "0x7B3DB0", VA = "0x1807B57B0")]
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

		// Token: 0x06003B7C RID: 15228 RVA: 0x00137ED4 File Offset: 0x001360D4
		[Token(Token = "0x6003B7C")]
		[Address(RVA = "0x7B48E0", Offset = "0x7B2EE0", VA = "0x1807B48E0")]
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

		// Token: 0x06003B7D RID: 15229 RVA: 0x00137F7C File Offset: 0x0013617C
		[Token(Token = "0x6003B7D")]
		[Address(RVA = "0x7B5480", Offset = "0x7B3A80", VA = "0x1807B5480")]
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

		// Token: 0x06003B7E RID: 15230 RVA: 0x00137FB0 File Offset: 0x001361B0
		[Token(Token = "0x6003B7E")]
		[Address(RVA = "0x7B5CF0", Offset = "0x7B42F0", VA = "0x1807B5CF0")]
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

		// Token: 0x06003B7F RID: 15231 RVA: 0x00137FE8 File Offset: 0x001361E8
		[Token(Token = "0x6003B7F")]
		[Address(RVA = "0x7B50E0", Offset = "0x7B36E0", VA = "0x1807B50E0")]
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

		// Token: 0x06003B80 RID: 15232 RVA: 0x00138098 File Offset: 0x00136298
		[Token(Token = "0x6003B80")]
		[Address(RVA = "0x7B5D90", Offset = "0x7B4390", VA = "0x1807B5D90")]
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

		// Token: 0x04002BC3 RID: 11203
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002BC3")]
		public List<ScaryPotData> scaryPots;

		// Token: 0x04002BC4 RID: 11204
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002BC4")]
		public VictoryType victoryType;

		// Token: 0x04002BC5 RID: 11205
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002BC5")]
		public BoardConfig boardConfig;

		// Token: 0x04002BC6 RID: 11206
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002BC6")]
		public Board.BoardTag boardTag;

		// Token: 0x04002BC7 RID: 11207
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002BC7")]
		public RhythmLevelData rhythmLevelData;

		// Token: 0x04002BC8 RID: 11208
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4002BC8")]
		public EventNodeGraph eventNodeGraph;

		// Token: 0x04002BC9 RID: 11209
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4002BC9")]
		public List<PlantDataManager.PlantData> plantDatas;

		// Token: 0x04002BCA RID: 11210
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4002BCA")]
		public List<SavePlantData> plants;

		// Token: 0x04002BCB RID: 11211
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4002BCB")]
		public List<PlantType> preSelectCards;

		// Token: 0x04002BCC RID: 11212
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4002BCC")]
		public List<ZombieType> preSelectCards_zombie;

		// Token: 0x04002BCD RID: 11213
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4002BCD")]
		public PlantEvolutionConfigLoader.EvolutionConfig GodShootingConfig;

		// Token: 0x04002BCE RID: 11214
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4002BCE")]
		public List<AdvBuff> advBuffs;

		// Token: 0x04002BCF RID: 11215
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x4002BCF")]
		public List<UltiBuff> ultiBuffs2;

		// Token: 0x04002BD0 RID: 11216
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x4002BD0")]
		public List<UltiBuff> ultiBuffs;

		// Token: 0x04002BD1 RID: 11217
		[FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x4002BD1")]
		public List<TravelDebuff> travelDebuffs;

		// Token: 0x04002BD2 RID: 11218
		[FieldOffset(Offset = "0xE0")]
		[Token(Token = "0x4002BD2")]
		public List<ZombieDataManager.ZombieData> zombieDatas;

		// Token: 0x04002BD3 RID: 11219
		[FieldOffset(Offset = "0xE8")]
		[Token(Token = "0x4002BD3")]
		public List<ZombieType> SpawnZombies;

		// Token: 0x04002BD4 RID: 11220
		[FieldOffset(Offset = "0xF0")]
		[Token(Token = "0x4002BD4")]
		public List<OrderedSpawn> orderedSpawns;

		// Token: 0x04002BD5 RID: 11221
		[FieldOffset(Offset = "0xF8")]
		[Token(Token = "0x4002BD5")]
		public SceneType sceneType;

		// Token: 0x04002BD6 RID: 11222
		[FieldOffset(Offset = "0xFC")]
		[Token(Token = "0x4002BD6")]
		public LevelType levelType;

		// Token: 0x04002BD7 RID: 11223
		[FieldOffset(Offset = "0x100")]
		[Token(Token = "0x4002BD7")]
		public int levelNumber;

		// Token: 0x04002BD8 RID: 11224
		[FieldOffset(Offset = "0x108")]
		[Token(Token = "0x4002BD8")]
		public string name;

		// Token: 0x04002BD9 RID: 11225
		[FieldOffset(Offset = "0x110")]
		[Token(Token = "0x4002BD9")]
		public int startSun;

		// Token: 0x04002BDA RID: 11226
		[FieldOffset(Offset = "0x114")]
		[Token(Token = "0x4002BDA")]
		public int maxWave;

		// Token: 0x04002BDB RID: 11227
		[FieldOffset(Offset = "0x118")]
		[Token(Token = "0x4002BDB")]
		public int cardCount;
	}
}
