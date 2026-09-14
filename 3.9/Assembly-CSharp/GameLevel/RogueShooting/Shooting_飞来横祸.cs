using System;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C80 RID: 3200
	[Token(Token = "0x2000C80")]
	public class Shooting_飞来横祸 : BaseDebuff
	{
		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06004283 RID: 17027 RVA: 0x0015C318 File Offset: 0x0015A518
		[Token(Token = "0x17000595")]
		public override int Point
		{
			[Token(Token = "0x6004283")]
			[Address(RVA = "0x88CB90", Offset = "0x88B190", VA = "0x18088CB90", Slot = "21")]
			get
			{
				return 150;
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06004284 RID: 17028 RVA: 0x0015C32C File Offset: 0x0015A52C
		[Token(Token = "0x17000596")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x6004284")]
			[Address(RVA = "0x8A0BE0", Offset = "0x89F1E0", VA = "0x1808A0BE0", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_飞来横祸;
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06004285 RID: 17029 RVA: 0x0015C340 File Offset: 0x0015A540
		[Token(Token = "0x17000597")]
		public override string Description
		{
			[Token(Token = "0x6004285")]
			[Address(RVA = "0x8A0BF0", Offset = "0x89F1F0", VA = "0x1808A0BF0", Slot = "13")]
			get
			{
				return "飞来横祸：关卡波次增加时，有概率出现一些特别的蹦极僵尸，概率随波次提高";
			}
		}

		// Token: 0x06004286 RID: 17030 RVA: 0x0015C354 File Offset: 0x0015A554
		[Token(Token = "0x6004286")]
		[Address(RVA = "0x8A0B00", Offset = "0x89F100", VA = "0x1808A0B00", Slot = "17")]
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
						CreateZombie instance = CreateZombie.Instance;
						int num3 = 0;
						Zombie zombie;
						if (zombie != num3 && zombie != 0)
						{
							uint num4;
							ZombieType zombieType = ShootingManager.GetZombieType(board.theWave, (int)num4);
						}
						num2++;
					}
				}
			};
			int num = 0;
			EventManager.AddListener(GameEvent.BoardWaveAdd, action, num != 0);
		}

		// Token: 0x06004287 RID: 17031 RVA: 0x0015C38C File Offset: 0x0015A58C
		[Token(Token = "0x6004287")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_飞来横祸()
		{
		}
	}
}
