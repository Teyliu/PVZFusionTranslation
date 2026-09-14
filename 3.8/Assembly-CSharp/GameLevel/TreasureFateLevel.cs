using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using Unity.VisualScripting;

namespace GameLevel
{
	// Token: 0x02000AE0 RID: 2784
	[Token(Token = "0x2000AE0")]
	public class TreasureFateLevel : ChallengeLevelData
	{
		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x060039CF RID: 14799 RVA: 0x001310CC File Offset: 0x0012F2CC
		[Token(Token = "0x170003E4")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x60039CF")]
			[Address(RVA = "0x796450", Offset = "0x794A50", VA = "0x180796450", Slot = "42")]
			get
			{
				return ChallengeLevel.Treasure_fate;
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x060039D0 RID: 14800 RVA: 0x001310E0 File Offset: 0x0012F2E0
		[Token(Token = "0x170003E5")]
		public override string Name
		{
			[Token(Token = "0x60039D0")]
			[Address(RVA = "0x796460", Offset = "0x794A60", VA = "0x180796460", Slot = "8")]
			get
			{
				return "神秘：命运";
			}
		}

		// Token: 0x060039D1 RID: 14801 RVA: 0x001310F4 File Offset: 0x0012F2F4
		[Token(Token = "0x60039D1")]
		[Address(RVA = "0x796170", Offset = "0x794770", VA = "0x180796170", Slot = "39")]
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
			board.config.startTip = "在剩余时间结束前撤离";
			board.config.applyRandomData = true;
			int difficulty = GameAPP.config.difficulty;
			board.lockedDifficulty = difficulty;
			board.boardTag.isTreasure = true;
			board.AddComponent<TreasureManager>().board = board;
			TravelMgr instance = TravelMgr.Instance;
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x060039D2 RID: 14802 RVA: 0x00131198 File Offset: 0x0012F398
		[Token(Token = "0x170003E6")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x60039D2")]
			[Address(RVA = "0x7964E0", Offset = "0x794AE0", VA = "0x1807964E0", Slot = "20")]
			get
			{
				return TreasureData.GetZombieType();
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x060039D3 RID: 14803 RVA: 0x001311AC File Offset: 0x0012F3AC
		[Token(Token = "0x170003E7")]
		public override SceneType SceneType
		{
			[Token(Token = "0x60039D3")]
			[Address(RVA = "0x796490", Offset = "0x794A90", VA = "0x180796490", Slot = "12")]
			get
			{
				return TreasureData.levelSceneType;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x060039D4 RID: 14804 RVA: 0x001311C0 File Offset: 0x0012F3C0
		[Token(Token = "0x170003E8")]
		public override int MaxWave
		{
			[Token(Token = "0x60039D4")]
			[Address(RVA = "0x3AAC80", Offset = "0x3A9280", VA = "0x1803AAC80", Slot = "10")]
			get
			{
				return 100;
			}
		}

		// Token: 0x060039D5 RID: 14805 RVA: 0x001311D0 File Offset: 0x0012F3D0
		[Token(Token = "0x60039D5")]
		[Address(RVA = "0x796350", Offset = "0x794950", VA = "0x180796350", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			Action action = delegate
			{
				TreasureFateLevel <>4__this = this;
				Board board2 = board;
				<>4__this.GetBuffs(board2);
			};
			int num = 0;
			EventManager.AddListener(GameEvent.BoardWaveAdd, action, num != 0);
		}

		// Token: 0x060039D6 RID: 14806 RVA: 0x00131210 File Offset: 0x0012F410
		[Token(Token = "0x60039D6")]
		[Address(RVA = "0x795980", Offset = "0x793F80", VA = "0x180795980")]
		protected void GetBuffs(Board board)
		{
			List<object> list;
			ulong num7;
			do
			{
				list = new List();
				int num = board.theWave;
				ulong num2;
				num2 += num2;
				num = (int)((ulong)num - num2);
				if (num == 2)
				{
					Dictionary<AdvBuff, string> advancedBuffsText = TravelDictionary.advancedBuffsText;
					bool flag;
					if (flag)
					{
						bool flag2;
						while (flag2)
						{
						}
					}
					ulong num3;
					if (num3 != (ulong)0L)
					{
						goto IL_0115;
					}
					Dictionary<UltiBuff, string> ultimateBuffsText = TravelDictionary.ultimateBuffsText;
					bool flag3;
					if (flag3)
					{
						bool flag4;
						while (flag4)
						{
						}
					}
					ulong num4;
					if (num4 != (ulong)0L)
					{
						goto IL_011B;
					}
				}
				int num5 = board.theWave;
				ulong num6;
				num6 += num6;
				num5 = (int)((ulong)num5 - num6);
				if (num5 != 1)
				{
					break;
				}
				Dictionary<TravelDebuff, ValueTuple<string, ZombieType>> debuffData = TravelDictionary.debuffData;
				bool flag5;
				if (flag5)
				{
					bool flag6;
					while (flag6)
					{
					}
					bool flag7;
					while (flag7)
					{
					}
				}
			}
			while (num7 != (ulong)0L);
			object random = ListExtensions.GetRandom<object>(list);
			if (random != 0)
			{
				if (random == 0)
				{
					if (random == 0)
					{
						if (random == 0)
						{
							return;
						}
						TravelMgr instance = TravelMgr.Instance;
					}
					TravelMgr instance2 = TravelMgr.Instance;
				}
				TravelMgr instance3 = TravelMgr.Instance;
				InGameText instance4 = InGameText.Instance;
				string text = TravelMgr.Instance.GetText(random);
				int num8 = 0;
				instance4.ShowText(text, 5f, num8 != 0);
			}
			return;
			IL_0115:
			throw new NullReferenceException();
			IL_011B:
			throw new NullReferenceException();
		}

		// Token: 0x060039D7 RID: 14807 RVA: 0x00131340 File Offset: 0x0012F540
		[Token(Token = "0x60039D7")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public TreasureFateLevel()
		{
		}
	}
}
