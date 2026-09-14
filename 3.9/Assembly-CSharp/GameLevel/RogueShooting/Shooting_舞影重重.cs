using System;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C75 RID: 3189
	[Token(Token = "0x2000C75")]
	public class Shooting_舞影重重 : BaseDebuff
	{
		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06004258 RID: 16984 RVA: 0x0015BC28 File Offset: 0x00159E28
		[Token(Token = "0x17000583")]
		public override int Point
		{
			[Token(Token = "0x6004258")]
			[Address(RVA = "0x88CB90", Offset = "0x88B190", VA = "0x18088CB90", Slot = "21")]
			get
			{
				return 150;
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06004259 RID: 16985 RVA: 0x0015BC3C File Offset: 0x00159E3C
		[Token(Token = "0x17000584")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x6004259")]
			[Address(RVA = "0x8A06C0", Offset = "0x89ECC0", VA = "0x1808A06C0", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_舞影重重;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x0600425A RID: 16986 RVA: 0x0015BC50 File Offset: 0x00159E50
		[Token(Token = "0x17000585")]
		public override string Description
		{
			[Token(Token = "0x600425A")]
			[Address(RVA = "0x8A06D0", Offset = "0x89ECD0", VA = "0x1808A06D0", Slot = "13")]
			get
			{
				return "舞影重重：关卡波次增加时，有概率出现一些特别的舞王僵尸，概率随波次提高";
			}
		}

		// Token: 0x0600425B RID: 16987 RVA: 0x0015BC64 File Offset: 0x00159E64
		[Token(Token = "0x600425B")]
		[Address(RVA = "0x8A05C0", Offset = "0x89EBC0", VA = "0x1808A05C0", Slot = "17")]
		public override void OnSelect(Board board)
		{
			Shooting_舞影重重.<>c__DisplayClass6_0 CS$<>8__locals1;
			CS$<>8__locals1.board = board;
			Board board2 = CS$<>8__locals1.board;
			Action action = delegate
			{
				Board board3 = CS$<>8__locals1.board;
				if (global::UnityEngine.Random.value <= 0.95f)
				{
					int theWave = CS$<>8__locals1.board.theWave;
					int num2 = 0;
					if (theWave + 1 > 0)
					{
						int num3 = 0;
						Board board4 = CS$<>8__locals1.board;
						CreateZombie instance = CreateZombie.Instance;
						int num4 = board4.rowNum;
						num4 = global::UnityEngine.Random.Range(0, num4);
						int num5 = 0;
						Zombie zombie;
						if (zombie != num5)
						{
							Board board5 = CS$<>8__locals1.board;
							Lawnf.SetZombieHealth(zombie, (float)num5);
							Board board6 = CS$<>8__locals1.board;
							zombie.theOriginSpeed = (float)num3;
						}
						num2++;
					}
				}
			};
			int num = 0;
			EventManager.AddListener(GameEvent.BoardWaveAdd, action, num != 0);
		}

		// Token: 0x0600425C RID: 16988 RVA: 0x0015BCA4 File Offset: 0x00159EA4
		[Token(Token = "0x600425C")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_舞影重重()
		{
		}
	}
}
