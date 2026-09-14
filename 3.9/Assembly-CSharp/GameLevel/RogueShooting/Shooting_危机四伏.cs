using System;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C77 RID: 3191
	[Token(Token = "0x2000C77")]
	public class Shooting_危机四伏 : BaseDebuff
	{
		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x0600425F RID: 16991 RVA: 0x0015BD68 File Offset: 0x00159F68
		[Token(Token = "0x17000586")]
		public override int Point
		{
			[Token(Token = "0x600425F")]
			[Address(RVA = "0x480D00", Offset = "0x47F300", VA = "0x180480D00", Slot = "21")]
			get
			{
				return 200;
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06004260 RID: 16992 RVA: 0x0015BD7C File Offset: 0x00159F7C
		[Token(Token = "0x17000587")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x6004260")]
			[Address(RVA = "0x89EBF0", Offset = "0x89D1F0", VA = "0x18089EBF0", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_危机四伏;
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06004261 RID: 16993 RVA: 0x0015BD90 File Offset: 0x00159F90
		[Token(Token = "0x17000588")]
		public override string Description
		{
			[Token(Token = "0x6004261")]
			[Address(RVA = "0x89EC00", Offset = "0x89D200", VA = "0x18089EC00", Slot = "13")]
			get
			{
				return "危机四伏：每一波僵尸刷新时，额外刷新随机路线的僵尸，数量随波次增加";
			}
		}

		// Token: 0x06004262 RID: 16994 RVA: 0x0015BDA4 File Offset: 0x00159FA4
		[Token(Token = "0x6004262")]
		[Address(RVA = "0x89EAF0", Offset = "0x89D0F0", VA = "0x18089EAF0", Slot = "17")]
		public override void OnSelect(Board board)
		{
			Shooting_危机四伏.<>c__DisplayClass6_0 CS$<>8__locals1;
			CS$<>8__locals1.board = board;
			Board board2 = CS$<>8__locals1.board;
			Action action = delegate
			{
				Board board3 = CS$<>8__locals1.board;
				float num2;
				if (0 > (int)num2 || num2 > 1f)
				{
				}
				int num3 = 0;
				RandomZombieType randomType = ShootingManager.randomType;
				ZombieType zombieType = ShootingManager.GetZombieType(CS$<>8__locals1.board.theWave, 5);
				Board board4 = CS$<>8__locals1.board;
				CreateZombie instance = CreateZombie.Instance;
				int num4 = board4.rowNum;
				num4 = global::UnityEngine.Random.Range(0, num4);
				num3++;
				ShootingManager.randomType = randomType;
			};
			int num = 0;
			EventManager.AddListener(GameEvent.BoardWaveAdd, action, num != 0);
		}

		// Token: 0x06004263 RID: 16995 RVA: 0x0015BDE4 File Offset: 0x00159FE4
		[Token(Token = "0x6004263")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_危机四伏()
		{
		}
	}
}
