using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000AE8 RID: 2792
	[Token(Token = "0x2000AE8")]
	public class IamZombieBoss : ChallengeLevelData
	{
		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x060039FE RID: 14846 RVA: 0x00132244 File Offset: 0x00130444
		[Token(Token = "0x170003F3")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x60039FE")]
			[Address(RVA = "0x789730", Offset = "0x787D30", VA = "0x180789730", Slot = "42")]
			get
			{
				return ChallengeLevel.IamZombieBoss;
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x060039FF RID: 14847 RVA: 0x00132258 File Offset: 0x00130458
		[Token(Token = "0x170003F4")]
		public override SceneType SceneType
		{
			[Token(Token = "0x60039FF")]
			[Address(RVA = "0x3AE560", Offset = "0x3ACB60", VA = "0x1803AE560", Slot = "12")]
			get
			{
				return SceneType.Night_6;
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06003A00 RID: 14848 RVA: 0x00132268 File Offset: 0x00130468
		[Token(Token = "0x170003F5")]
		public override string Name
		{
			[Token(Token = "0x6003A00")]
			[Address(RVA = "0x789740", Offset = "0x787D40", VA = "0x180789740", Slot = "8")]
			get
			{
				return "我是僵？王";
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06003A01 RID: 14849 RVA: 0x0013227C File Offset: 0x0013047C
		[Token(Token = "0x170003F6")]
		public override int MaxWave
		{
			[Token(Token = "0x6003A01")]
			[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x06003A02 RID: 14850 RVA: 0x0013228C File Offset: 0x0013048C
		[Token(Token = "0x6003A02")]
		[Address(RVA = "0x789370", Offset = "0x787970", VA = "0x180789370", Slot = "39")]
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

		// Token: 0x06003A03 RID: 14851 RVA: 0x00132304 File Offset: 0x00130504
		[Token(Token = "0x6003A03")]
		[Address(RVA = "0x789480", Offset = "0x787A80", VA = "0x180789480", Slot = "36")]
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

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06003A04 RID: 14852 RVA: 0x00132398 File Offset: 0x00130598
		[Token(Token = "0x170003F7")]
		public override List<ZombieType> PreselectCards_zombie
		{
			[Token(Token = "0x6003A04")]
			[Address(RVA = "0x789770", Offset = "0x787D70", VA = "0x180789770", Slot = "24")]
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

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06003A05 RID: 14853 RVA: 0x00132434 File Offset: 0x00130634
		[Token(Token = "0x170003F8")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003A05")]
			[Address(RVA = "0x789C90", Offset = "0x788290", VA = "0x180789C90", Slot = "20")]
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

		// Token: 0x06003A06 RID: 14854 RVA: 0x00132514 File Offset: 0x00130714
		[Token(Token = "0x6003A06")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public IamZombieBoss()
		{
		}
	}
}
