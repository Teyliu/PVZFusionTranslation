using System;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C7C RID: 3196
	[Token(Token = "0x2000C7C")]
	public class Shooting_人才下沉 : BaseDebuff
	{
		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06004275 RID: 17013 RVA: 0x0015C0BC File Offset: 0x0015A2BC
		[Token(Token = "0x1700058F")]
		public override int Point
		{
			[Token(Token = "0x6004275")]
			[Address(RVA = "0x88CDD0", Offset = "0x88B3D0", VA = "0x18088CDD0", Slot = "21")]
			get
			{
				return 250;
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06004276 RID: 17014 RVA: 0x0015C0D0 File Offset: 0x0015A2D0
		[Token(Token = "0x17000590")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x6004276")]
			[Address(RVA = "0x89EA70", Offset = "0x89D070", VA = "0x18089EA70", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_人才下沉;
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06004277 RID: 17015 RVA: 0x0015C0E4 File Offset: 0x0015A2E4
		[Token(Token = "0x17000591")]
		public override string Description
		{
			[Token(Token = "0x6004277")]
			[Address(RVA = "0x89EA80", Offset = "0x89D080", VA = "0x18089EA80", Slot = "13")]
			get
			{
				return "人才下沉：从第51波开始，每一波开始时会随机刷新5只第1波至50波才会出现的僵尸，但他获得10倍血量加成和1倍独立速度增幅";
			}
		}

		// Token: 0x06004278 RID: 17016 RVA: 0x0015C0F8 File Offset: 0x0015A2F8
		[Token(Token = "0x6004278")]
		[Address(RVA = "0x89E990", Offset = "0x89CF90", VA = "0x18089E990", Slot = "17")]
		public override void OnSelect(Board board)
		{
			Action action = delegate
			{
				if (board.theWave > 50)
				{
					int num2 = 0;
					Board board2 = board;
					CreateZombie instance = CreateZombie.Instance;
					int rowNum = board2.rowNum;
					int num3 = global::UnityEngine.Random.Range(0, rowNum);
					uint num4;
					ZombieType zombieType = ShootingManager.GetZombieType(board.theWave, (int)num4);
					int num5 = 0;
					Zombie zombie;
					if (zombie != num5)
					{
						Lawnf.SetZombieHealth(zombie, 10f);
						float theOriginSpeed = zombie.theOriginSpeed;
						zombie.theOriginSpeed = theOriginSpeed;
					}
					num2++;
				}
			};
			int num = 0;
			EventManager.AddListener(GameEvent.BoardWaveAdd, action, num != 0);
		}

		// Token: 0x06004279 RID: 17017 RVA: 0x0015C130 File Offset: 0x0015A330
		[Token(Token = "0x6004279")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_人才下沉()
		{
		}
	}
}
