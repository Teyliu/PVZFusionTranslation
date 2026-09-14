using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using RhythmGame;
using UnityEngine;

namespace GameLevel
{
	// Token: 0x02000B34 RID: 2868
	[Token(Token = "0x2000B34")]
	public class RhythmGameLevelData : ChallengeLevelData
	{
		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06003B92 RID: 15250 RVA: 0x0013895C File Offset: 0x00136B5C
		[Token(Token = "0x1700045C")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x6003B92")]
			[Address(RVA = "0x4E8840", Offset = "0x4E6E40", VA = "0x1804E8840", Slot = "42")]
			get
			{
				return ChallengeLevel.RhythmGame;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06003B93 RID: 15251 RVA: 0x00138970 File Offset: 0x00136B70
		[Token(Token = "0x1700045D")]
		public override string Name
		{
			[Token(Token = "0x6003B93")]
			[Address(RVA = "0x7F8220", Offset = "0x7F6820", VA = "0x1807F8220", Slot = "8")]
			get
			{
				return "节 奏 大 师";
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06003B94 RID: 15252 RVA: 0x00138984 File Offset: 0x00136B84
		[Token(Token = "0x1700045E")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003B94")]
			[Address(RVA = "0x716B30", Offset = "0x715130", VA = "0x180716B30", Slot = "12")]
			get
			{
				return SceneType.LongMap_rhy;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06003B95 RID: 15253 RVA: 0x00138994 File Offset: 0x00136B94
		[Token(Token = "0x1700045F")]
		public override int MaxWave
		{
			[Token(Token = "0x6003B95")]
			[Address(RVA = "0x3F6A80", Offset = "0x3F5080", VA = "0x1803F6A80", Slot = "10")]
			get
			{
				return 100;
			}
		}

		// Token: 0x06003B96 RID: 15254 RVA: 0x001389A4 File Offset: 0x00136BA4
		[Token(Token = "0x6003B96")]
		[Address(RVA = "0x7F7E10", Offset = "0x7F6410", VA = "0x1807F7E10", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			if (base.CardCount != 0)
			{
				int cardCount = base.CardCount;
				board.cardCountLimit = cardCount;
			}
			BoardConfig boardConfig = base.Config.Copy();
			board.config = boardConfig;
			float firstWaveArrivedTimer = base.Config.firstWaveArrivedTimer;
			board.timeUntilNextWave = firstWaveArrivedTimer;
			board.boardTag.disableSelectCard = true;
			board.boardTag.disableNormalSun = true;
			BoardConfig config = board.config;
			board.thePoints = 0f;
			board.theWave = (int)((ulong)11L);
			config.zombieCountMultiplier = 3f;
			board.config.firstWaveArrivedTimer = 3f;
			board.config.startTip = "根据BGM节奏点击下落的音符\n连击越高，子弹越多！";
			GameObject gameObject = Resources.Load<GameObject>("Board/Game/Rhyhm/RhyhmManager");
			Transform transform = board.transform;
			GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform);
		}

		// Token: 0x06003B97 RID: 15255 RVA: 0x00138A74 File Offset: 0x00136C74
		[Token(Token = "0x6003B97")]
		[Address(RVA = "0x7F7FE0", Offset = "0x7F65E0", VA = "0x1807F7FE0", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			Action action = delegate
			{
				Board board3 = board;
				if (board3.theWave == 19)
				{
					board3.theWave = (int)((ulong)18L);
				}
			};
			int num = 0;
			EventManager.AddListener(GameEvent.BoardWaveAdd, action, num != 0);
			GameObject seedBank = InGameUI.Instance.SeedBank;
			int num2 = 0;
			seedBank.SetActive(num2 != 0);
			GameObject shovelBank = InGameUI.Instance.ShovelBank;
			int num3 = 0;
			shovelBank.SetActive(num3 != 0);
			GameObject slowTrigger = InGameUI.Instance.SlowTrigger;
			int num4 = 0;
			slowTrigger.SetActive(num4 != 0);
			Board board2 = board;
			RhythmGameManager <Instance>k__BackingField = RhythmGameManager.<Instance>k__BackingField;
			RhythmLevelData rhythmLevelData = JsonUtility.FromJson<RhythmLevelData>(Resources.Load<TextAsset>("Audio/Music/Loon").text);
			rhythmLevelData.musicType = (MusicType)((ulong)13L);
			rhythmLevelData.fallTime = 1f;
			<Instance>k__BackingField.StartRhythmGame(rhythmLevelData);
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06003B98 RID: 15256 RVA: 0x00138B38 File Offset: 0x00136D38
		[Token(Token = "0x17000460")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003B98")]
			[Address(RVA = "0x7F8250", Offset = "0x7F6850", VA = "0x1807F8250", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				int size4 = list._size;
				int size5 = list._size;
				return list;
			}
		}

		// Token: 0x06003B99 RID: 15257 RVA: 0x00138B90 File Offset: 0x00136D90
		[Token(Token = "0x6003B99")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public RhythmGameLevelData()
		{
		}
	}
}
