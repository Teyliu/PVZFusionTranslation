using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B28 RID: 2856
	[Token(Token = "0x2000B28")]
	public class IamZombieBoss : ChallengeLevelData
	{
		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06003B42 RID: 15170 RVA: 0x001372FC File Offset: 0x001354FC
		[Token(Token = "0x1700043B")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x6003B42")]
			[Address(RVA = "0x7EFDA0", Offset = "0x7EE3A0", VA = "0x1807EFDA0", Slot = "42")]
			get
			{
				return ChallengeLevel.IamZombieBoss;
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06003B43 RID: 15171 RVA: 0x00137310 File Offset: 0x00135510
		[Token(Token = "0x1700043C")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003B43")]
			[Address(RVA = "0x3FA3D0", Offset = "0x3F89D0", VA = "0x1803FA3D0", Slot = "12")]
			get
			{
				return SceneType.Night_6;
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06003B44 RID: 15172 RVA: 0x00137320 File Offset: 0x00135520
		[Token(Token = "0x1700043D")]
		public override string Name
		{
			[Token(Token = "0x6003B44")]
			[Address(RVA = "0x7EFDB0", Offset = "0x7EE3B0", VA = "0x1807EFDB0", Slot = "8")]
			get
			{
				return "我是僵？王";
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06003B45 RID: 15173 RVA: 0x00137334 File Offset: 0x00135534
		[Token(Token = "0x1700043E")]
		public override int MaxWave
		{
			[Token(Token = "0x6003B45")]
			[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x06003B46 RID: 15174 RVA: 0x00137344 File Offset: 0x00135544
		[Token(Token = "0x6003B46")]
		[Address(RVA = "0x7EF9E0", Offset = "0x7EDFE0", VA = "0x1807EF9E0", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			if (base.CardCount != 0)
			{
				int cardCount = base.CardCount;
				board.cardCountLimit = cardCount;
			}
			BoardConfig boardConfig = base.Config.Copy();
			board.config = boardConfig;
			BoardConfig config = base.Config;
			board.boardTag.imZombieBoss = true;
			board.boardTag.disableSelectCard = true;
			BoardConfig config2 = board.config;
			board.timeUntilNextWave = 30f;
			config2.startTip = "种植僵尸后，火红莲会持续为你生产僵尸";
			throw new NullReferenceException();
		}

		// Token: 0x06003B47 RID: 15175 RVA: 0x001373BC File Offset: 0x001355BC
		[Token(Token = "0x6003B47")]
		[Address(RVA = "0x7EFAF0", Offset = "0x7EE0F0", VA = "0x1807EFAF0", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			ulong num;
			do
			{
				List<CardUI> cards = InGameUI.Instance.Cards;
				bool flag;
				if (flag)
				{
					if (flag > true)
					{
						if (flag > true)
						{
							if (flag > true)
							{
								if (flag)
								{
								}
								if (flag)
								{
									goto IL_003A;
								}
							}
							if (flag)
							{
							}
							if (!flag)
							{
								goto IL_0071;
							}
						}
						IL_003A:
						if (flag)
						{
						}
						if (flag)
						{
						}
						if (flag)
						{
							goto IL_0062;
						}
					}
					if (flag > true)
					{
						if (flag > true && (flag || flag))
						{
							goto IL_006C;
						}
						if (!flag)
						{
							goto IL_0071;
						}
					}
					IL_0062:
					if (flag)
					{
						goto IL_0071;
					}
					if (flag)
					{
					}
					IL_006C:
					if (flag)
					{
					}
				}
				IL_0071:;
			}
			while (num != (ulong)0L);
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06003B48 RID: 15176 RVA: 0x00137450 File Offset: 0x00135650
		[Token(Token = "0x1700043F")]
		public override List<ZombieType> PreselectCards_zombie
		{
			[Token(Token = "0x6003B48")]
			[Address(RVA = "0x7EFDE0", Offset = "0x7EE3E0", VA = "0x1807EFDE0", Slot = "24")]
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
				int size10 = list._size;
				int size11 = list._size;
				int size12 = list._size;
				int size13 = list._size;
				int size14 = list._size;
				return list;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06003B49 RID: 15177 RVA: 0x001374EC File Offset: 0x001356EC
		[Token(Token = "0x17000440")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003B49")]
			[Address(RVA = "0x7F0300", Offset = "0x7EE900", VA = "0x1807F0300", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				list._size = 1;
				list._syncRoot = (ulong)0L;
				int size3 = list._size;
				list._size = 1;
				int size4 = list._size;
				list._size = 1;
				int size5 = list._size;
				list._size = 1;
				int size6 = list._size;
				list._size = 1;
				int size7 = list._size;
				list._size = 1;
				int size8 = list._size;
				list._size = 1;
				int size9 = list._size;
				list._size = 1;
				int size10 = list._size;
				list._size = 1;
				int size11 = list._size;
				list._size = 1;
				int size12 = list._size;
				return list;
			}
		}

		// Token: 0x06003B4A RID: 15178 RVA: 0x001375CC File Offset: 0x001357CC
		[Token(Token = "0x6003B4A")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public IamZombieBoss()
		{
		}
	}
}
