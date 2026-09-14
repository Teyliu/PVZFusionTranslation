using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C73 RID: 3187
	[Token(Token = "0x2000C73")]
	public class Shooting_生化危机 : BaseDebuff
	{
		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06004251 RID: 16977 RVA: 0x0015BB44 File Offset: 0x00159D44
		[Token(Token = "0x17000580")]
		public override int Point
		{
			[Token(Token = "0x6004251")]
			[Address(RVA = "0x3F6A80", Offset = "0x3F5080", VA = "0x1803F6A80", Slot = "21")]
			get
			{
				return 100;
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06004252 RID: 16978 RVA: 0x0015BB54 File Offset: 0x00159D54
		[Token(Token = "0x17000581")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x6004252")]
			[Address(RVA = "0x89FED0", Offset = "0x89E4D0", VA = "0x18089FED0", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_生化危机;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06004253 RID: 16979 RVA: 0x0015BB68 File Offset: 0x00159D68
		[Token(Token = "0x17000582")]
		public override string Description
		{
			[Token(Token = "0x6004253")]
			[Address(RVA = "0x89FEE0", Offset = "0x89E4E0", VA = "0x18089FEE0", Slot = "13")]
			get
			{
				return "生化危机：植物消失时，在原地生成一只随机僵尸，该僵尸获得额外的血量加成";
			}
		}

		// Token: 0x06004254 RID: 16980 RVA: 0x0015BB7C File Offset: 0x00159D7C
		[Token(Token = "0x6004254")]
		[Address(RVA = "0x89FDC0", Offset = "0x89E3C0", VA = "0x18089FDC0", Slot = "17")]
		public override void OnSelect(Board board)
		{
			Shooting_生化危机.<>c__DisplayClass6_0 CS$<>8__locals1;
			CS$<>8__locals1.board = board;
			Board board2 = CS$<>8__locals1.board;
			int num = 0;
			Action<object> action;
			EventManager.AddListener_obj((GameEvent)((uint)20), action, num != 0);
		}

		// Token: 0x06004255 RID: 16981 RVA: 0x0015BBB0 File Offset: 0x00159DB0
		[Token(Token = "0x6004255")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_生化危机()
		{
		}
	}
}
