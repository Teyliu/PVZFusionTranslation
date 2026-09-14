using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C85 RID: 3205
	[Token(Token = "0x2000C85")]
	public class Shooting_闪电突袭 : BaseDebuff
	{
		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06004296 RID: 17046 RVA: 0x0015C59C File Offset: 0x0015A79C
		[Token(Token = "0x1700059E")]
		public override int Point
		{
			[Token(Token = "0x6004296")]
			[Address(RVA = "0x88C900", Offset = "0x88AF00", VA = "0x18088C900", Slot = "21")]
			get
			{
				return 400;
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06004297 RID: 17047 RVA: 0x0015C5B0 File Offset: 0x0015A7B0
		[Token(Token = "0x1700059F")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x6004297")]
			[Address(RVA = "0x8A0960", Offset = "0x89EF60", VA = "0x1808A0960", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_闪电突袭;
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06004298 RID: 17048 RVA: 0x0015C5C4 File Offset: 0x0015A7C4
		[Token(Token = "0x170005A0")]
		public override string Description
		{
			[Token(Token = "0x6004298")]
			[Address(RVA = "0x8A0970", Offset = "0x89EF70", VA = "0x1808A0970", Slot = "13")]
			get
			{
				return "闪电突袭：每一波刷新僵尸后，随机3只僵尸获得100%独立速度增幅";
			}
		}

		// Token: 0x06004299 RID: 17049 RVA: 0x0015C5D8 File Offset: 0x0015A7D8
		[Token(Token = "0x6004299")]
		[Address(RVA = "0x8A0880", Offset = "0x89EE80", VA = "0x1808A0880", Slot = "17")]
		public override void OnSelect(Board board)
		{
			Func<Zombie, bool> <>9__1;
			Action action = delegate
			{
				List<Zombie> allZombies = Lawnf.GetAllZombies(false);
				Func<Zombie, bool> <>9__ = <>9__1;
				if (<>9__ == 0)
				{
					Func<Zombie, bool> func = delegate(Zombie a)
					{
						int column = a.Column;
						int columnNum = board.columnNum;
						return column >= columnNum;
					};
					<>9__1 = func;
				}
				uint num2;
				List<Zombie> random = ListExtensions.GetRandom<Zombie>(Enumerable.ToList<Zombie>(Enumerable.Where<Zombie>(allZombies, <>9__)), (int)num2);
				Action<Zombie> action2;
				if (Shooting_闪电突袭.<>c.<>9__6_2 == 0)
				{
					Shooting_闪电突袭.<>c.<>9__6_2 = action2;
				}
				random.ForEach(action2);
			};
			int num = 0;
			EventManager.AddListener((GameEvent)((uint)3), action, num != 0);
		}

		// Token: 0x0600429A RID: 17050 RVA: 0x0015C610 File Offset: 0x0015A810
		[Token(Token = "0x600429A")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_闪电突袭()
		{
		}
	}
}
