using System;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C66 RID: 3174
	[Token(Token = "0x2000C66")]
	public class Shooting_人才引进 : BaseDebuff
	{
		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06004222 RID: 16930 RVA: 0x0015B510 File Offset: 0x00159710
		[Token(Token = "0x1700056B")]
		public override int Point
		{
			[Token(Token = "0x6004222")]
			[Address(RVA = "0x88C900", Offset = "0x88AF00", VA = "0x18088C900", Slot = "21")]
			get
			{
				return 400;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06004223 RID: 16931 RVA: 0x0015B524 File Offset: 0x00159724
		[Token(Token = "0x1700056C")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x6004223")]
			[Address(RVA = "0x88C8C0", Offset = "0x88AEC0", VA = "0x18088C8C0", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_人才引进;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06004224 RID: 16932 RVA: 0x0015B538 File Offset: 0x00159738
		[Token(Token = "0x1700056D")]
		public override string Description
		{
			[Token(Token = "0x6004224")]
			[Address(RVA = "0x88C8D0", Offset = "0x88AED0", VA = "0x18088C8D0", Slot = "13")]
			get
			{
				return "人才引进：从第8波开始，在关卡的前50波中，每一波开始时会随机刷新一只第38波至88波才会出现的僵尸";
			}
		}

		// Token: 0x06004225 RID: 16933 RVA: 0x0015B54C File Offset: 0x0015974C
		[Token(Token = "0x6004225")]
		[Address(RVA = "0x88C7E0", Offset = "0x88ADE0", VA = "0x18088C7E0", Slot = "17")]
		public override void OnSelect(Board board)
		{
			Action action = delegate
			{
				if (board.theWave < 50)
				{
					Board board2 = board;
					CreateZombie instance = CreateZombie.Instance;
					int rowNum = board2.rowNum;
					int num2 = global::UnityEngine.Random.Range(0, rowNum);
					int num3 = board.theWave;
					num3 += 30;
					uint num4;
					ZombieType zombieType = ShootingManager.GetZombieType(num3, (int)num4);
				}
			};
			int num = 0;
			EventManager.AddListener(GameEvent.BoardWaveAdd, action, num != 0);
		}

		// Token: 0x06004226 RID: 16934 RVA: 0x0015B584 File Offset: 0x00159784
		[Token(Token = "0x6004226")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_人才引进()
		{
		}
	}
}
