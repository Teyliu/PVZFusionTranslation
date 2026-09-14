using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using Unity.VisualScripting;

namespace GameLevel
{
	// Token: 0x02000B20 RID: 2848
	[Token(Token = "0x2000B20")]
	public class TreasureFateLevel : ChallengeLevelData
	{
		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06003B13 RID: 15123 RVA: 0x001361AC File Offset: 0x001343AC
		[Token(Token = "0x1700042C")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x6003B13")]
			[Address(RVA = "0x7FCCE0", Offset = "0x7FB2E0", VA = "0x1807FCCE0", Slot = "42")]
			get
			{
				return ChallengeLevel.Treasure_fate;
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06003B14 RID: 15124 RVA: 0x001361C0 File Offset: 0x001343C0
		[Token(Token = "0x1700042D")]
		public override string Name
		{
			[Token(Token = "0x6003B14")]
			[Address(RVA = "0x7FCCF0", Offset = "0x7FB2F0", VA = "0x1807FCCF0", Slot = "8")]
			get
			{
				return "神秘：命运";
			}
		}

		// Token: 0x06003B15 RID: 15125 RVA: 0x001361D4 File Offset: 0x001343D4
		[Token(Token = "0x6003B15")]
		[Address(RVA = "0x7FCA00", Offset = "0x7FB000", VA = "0x1807FCA00", Slot = "39")]
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

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06003B16 RID: 15126 RVA: 0x00136278 File Offset: 0x00134478
		[Token(Token = "0x1700042E")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003B16")]
			[Address(RVA = "0x7FCD70", Offset = "0x7FB370", VA = "0x1807FCD70", Slot = "20")]
			get
			{
				return TreasureData.GetZombieType();
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06003B17 RID: 15127 RVA: 0x0013628C File Offset: 0x0013448C
		[Token(Token = "0x1700042F")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003B17")]
			[Address(RVA = "0x7FCD20", Offset = "0x7FB320", VA = "0x1807FCD20", Slot = "12")]
			get
			{
				return TreasureData.levelSceneType;
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06003B18 RID: 15128 RVA: 0x001362A0 File Offset: 0x001344A0
		[Token(Token = "0x17000430")]
		public override int MaxWave
		{
			[Token(Token = "0x6003B18")]
			[Address(RVA = "0x3F6A80", Offset = "0x3F5080", VA = "0x1803F6A80", Slot = "10")]
			get
			{
				return 100;
			}
		}

		// Token: 0x06003B19 RID: 15129 RVA: 0x001362B0 File Offset: 0x001344B0
		[Token(Token = "0x6003B19")]
		[Address(RVA = "0x7FCBE0", Offset = "0x7FB1E0", VA = "0x1807FCBE0", Slot = "36")]
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

		// Token: 0x06003B1A RID: 15130 RVA: 0x001362F0 File Offset: 0x001344F0
		[Token(Token = "0x6003B1A")]
		[Address(RVA = "0x7FC200", Offset = "0x7FA800", VA = "0x1807FC200")]
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
						goto IL_0102;
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
						goto IL_0108;
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
			}
			return;
			IL_0102:
			throw new NullReferenceException();
			IL_0108:
			throw new NullReferenceException();
		}

		// Token: 0x06003B1B RID: 15131 RVA: 0x0013640C File Offset: 0x0013460C
		[Token(Token = "0x6003B1B")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public TreasureFateLevel()
		{
		}
	}
}
