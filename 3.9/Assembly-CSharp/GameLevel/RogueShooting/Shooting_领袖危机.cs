using System;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C61 RID: 3169
	[Token(Token = "0x2000C61")]
	public class Shooting_领袖危机 : BaseDebuff
	{
		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x0600420F RID: 16911 RVA: 0x0015B2F0 File Offset: 0x001594F0
		[Token(Token = "0x17000562")]
		public override int Point
		{
			[Token(Token = "0x600420F")]
			[Address(RVA = "0x88CB90", Offset = "0x88B190", VA = "0x18088CB90", Slot = "21")]
			get
			{
				return 150;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06004210 RID: 16912 RVA: 0x0015B304 File Offset: 0x00159504
		[Token(Token = "0x17000563")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x6004210")]
			[Address(RVA = "0x88D060", Offset = "0x88B660", VA = "0x18088D060", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_领袖危机;
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06004211 RID: 16913 RVA: 0x0015B318 File Offset: 0x00159518
		[Token(Token = "0x17000564")]
		public override string Description
		{
			[Token(Token = "0x6004211")]
			[Address(RVA = "0x88D070", Offset = "0x88B670", VA = "0x18088D070", Slot = "13")]
			get
			{
				return "领袖危机：从第50波开始，旗帜波时将刷新随机领袖";
			}
		}

		// Token: 0x06004212 RID: 16914 RVA: 0x0015B32C File Offset: 0x0015952C
		[Token(Token = "0x6004212")]
		[Address(RVA = "0x88CF80", Offset = "0x88B580", VA = "0x18088CF80", Slot = "17")]
		public override void OnSelect(Board board)
		{
			Action action = delegate
			{
				int theWave = board.theWave;
				ulong num2;
				num2 += num2;
				num2 += num2;
				if ((ulong)theWave == num2)
				{
					ShootingManager instance = ShootingManager.Instance;
					ZombieType random = ListExtensions.GetRandom<ZombieType>(ShootingManager.Instance.leaders);
					Board board2 = board;
					CreateZombie instance2 = CreateZombie.Instance;
					int num3 = board2.rowNum;
					num3 = global::UnityEngine.Random.Range(0, num3);
				}
			};
			int num = 0;
			EventManager.AddListener(GameEvent.BoardWaveAdd, action, num != 0);
		}

		// Token: 0x06004213 RID: 16915 RVA: 0x0015B364 File Offset: 0x00159564
		[Token(Token = "0x6004213")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_领袖危机()
		{
		}
	}
}
