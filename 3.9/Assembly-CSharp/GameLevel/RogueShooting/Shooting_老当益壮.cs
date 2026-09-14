using System;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C7E RID: 3198
	[Token(Token = "0x2000C7E")]
	public class Shooting_老当益壮 : BaseDebuff
	{
		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x0600427C RID: 17020 RVA: 0x0015C1E0 File Offset: 0x0015A3E0
		[Token(Token = "0x17000592")]
		public override int Point
		{
			[Token(Token = "0x600427C")]
			[Address(RVA = "0x59DF10", Offset = "0x59C510", VA = "0x18059DF10", Slot = "21")]
			get
			{
				return 300;
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x0600427D RID: 17021 RVA: 0x0015C1F4 File Offset: 0x0015A3F4
		[Token(Token = "0x17000593")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x600427D")]
			[Address(RVA = "0x8A0330", Offset = "0x89E930", VA = "0x1808A0330", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_老当益壮;
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x0600427E RID: 17022 RVA: 0x0015C208 File Offset: 0x0015A408
		[Token(Token = "0x17000594")]
		public override string Description
		{
			[Token(Token = "0x600427E")]
			[Address(RVA = "0x8A0340", Offset = "0x89E940", VA = "0x1808A0340", Slot = "13")]
			get
			{
				return "老当益壮：关卡波次增加时，有概率出现一些特别的读报僵尸，概率随波次提高";
			}
		}

		// Token: 0x0600427F RID: 17023 RVA: 0x0015C21C File Offset: 0x0015A41C
		[Token(Token = "0x600427F")]
		[Address(RVA = "0x8A0250", Offset = "0x89E850", VA = "0x1808A0250", Slot = "17")]
		public override void OnSelect(Board board)
		{
			Action action = delegate
			{
				Board board2 = board;
				if (global::UnityEngine.Random.value <= 0.95f)
				{
					int theWave = board.theWave;
					int num2 = 0;
					if (theWave + 1 > 0)
					{
						int num3 = 0;
						Board board3 = board;
						CreateZombie instance = CreateZombie.Instance;
						int num4 = board3.rowNum;
						num4 = global::UnityEngine.Random.Range(0, num4);
						int num5 = 0;
						Zombie zombie;
						if (zombie != num5)
						{
							Board board4 = board;
							Lawnf.SetZombieHealth(zombie, (float)num5);
							Board board5 = board;
							zombie.theOriginSpeed = (float)num3;
						}
						num2++;
					}
				}
			};
			int num = 0;
			EventManager.AddListener(GameEvent.BoardWaveAdd, action, num != 0);
		}

		// Token: 0x06004280 RID: 17024 RVA: 0x0015C254 File Offset: 0x0015A454
		[Token(Token = "0x6004280")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_老当益壮()
		{
		}
	}
}
