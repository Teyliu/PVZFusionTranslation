using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using RhythmGame;
using UnityEngine;

namespace GameLevel
{
	// Token: 0x02000AF4 RID: 2804
	[Token(Token = "0x2000AF4")]
	public class RhythmGameLevelData : ChallengeLevelData
	{
		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06003A4E RID: 14926 RVA: 0x00133918 File Offset: 0x00131B18
		[Token(Token = "0x17000414")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x6003A4E")]
			[Address(RVA = "0x48F2C0", Offset = "0x48D8C0", VA = "0x18048F2C0", Slot = "42")]
			get
			{
				return ChallengeLevel.RhythmGame;
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06003A4F RID: 14927 RVA: 0x0013392C File Offset: 0x00131B2C
		[Token(Token = "0x17000415")]
		public override string Name
		{
			[Token(Token = "0x6003A4F")]
			[Address(RVA = "0x791BD0", Offset = "0x7901D0", VA = "0x180791BD0", Slot = "8")]
			get
			{
				return "节 奏 大 师";
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06003A50 RID: 14928 RVA: 0x00133940 File Offset: 0x00131B40
		[Token(Token = "0x17000416")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003A50")]
			[Address(RVA = "0x69C9D0", Offset = "0x69AFD0", VA = "0x18069C9D0", Slot = "12")]
			get
			{
				return SceneType.LongMap_rhy;
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06003A51 RID: 14929 RVA: 0x00133950 File Offset: 0x00131B50
		[Token(Token = "0x17000417")]
		public override int MaxWave
		{
			[Token(Token = "0x6003A51")]
			[Address(RVA = "0x3AAC80", Offset = "0x3A9280", VA = "0x1803AAC80", Slot = "10")]
			get
			{
				return 100;
			}
		}

		// Token: 0x06003A52 RID: 14930 RVA: 0x00133960 File Offset: 0x00131B60
		[Token(Token = "0x6003A52")]
		[Address(RVA = "0x7917C0", Offset = "0x78FDC0", VA = "0x1807917C0", Slot = "39")]
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

		// Token: 0x06003A53 RID: 14931 RVA: 0x00133A30 File Offset: 0x00131C30
		[Token(Token = "0x6003A53")]
		[Address(RVA = "0x791990", Offset = "0x78FF90", VA = "0x180791990", Slot = "36")]
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

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06003A54 RID: 14932 RVA: 0x00133AF4 File Offset: 0x00131CF4
		[Token(Token = "0x17000418")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003A54")]
			[Address(RVA = "0x791C00", Offset = "0x790200", VA = "0x180791C00", Slot = "20")]
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

		// Token: 0x06003A55 RID: 14933 RVA: 0x00133B4C File Offset: 0x00131D4C
		[Token(Token = "0x6003A55")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public RhythmGameLevelData()
		{
		}
	}
}
