using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020009F9 RID: 2553
[Token(Token = "0x20009F9")]
public class ScaryPot3 : ScaryPotLevel
{
	// Token: 0x17000238 RID: 568
	// (get) Token: 0x06003468 RID: 13416 RVA: 0x00114678 File Offset: 0x00112878
	[Token(Token = "0x17000238")]
	public override string Name
	{
		[Token(Token = "0x6003468")]
		[Address(RVA = "0x771020", Offset = "0x76F620", VA = "0x180771020", Slot = "8")]
		get
		{
			return "连锁反应";
		}
	}

	// Token: 0x17000239 RID: 569
	// (get) Token: 0x06003469 RID: 13417 RVA: 0x0011468C File Offset: 0x0011288C
	[Token(Token = "0x17000239")]
	protected override ChallengeLevel Level
	{
		[Token(Token = "0x6003469")]
		[Address(RVA = "0x568FF0", Offset = "0x5675F0", VA = "0x180568FF0", Slot = "42")]
		get
		{
			return ChallengeLevel.ScaryPot3;
		}
	}

	// Token: 0x1700023A RID: 570
	// (get) Token: 0x0600346A RID: 13418 RVA: 0x0011469C File Offset: 0x0011289C
	[Token(Token = "0x1700023A")]
	public override int EmptyColumns
	{
		[Token(Token = "0x600346A")]
		[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "43")]
		get
		{
			return 2;
		}
	}

	// Token: 0x1700023B RID: 571
	// (get) Token: 0x0600346B RID: 13419 RVA: 0x001146AC File Offset: 0x001128AC
	[Token(Token = "0x1700023B")]
	public override int NumberOfColumns
	{
		[Token(Token = "0x600346B")]
		[Address(RVA = "0x3F6B70", Offset = "0x3F5170", VA = "0x1803F6B70", Slot = "44")]
		get
		{
			return 8;
		}
	}

	// Token: 0x1700023C RID: 572
	// (get) Token: 0x0600346C RID: 13420 RVA: 0x001146BC File Offset: 0x001128BC
	[Token(Token = "0x1700023C")]
	public override int NumberOfRows
	{
		[Token(Token = "0x600346C")]
		[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "45")]
		get
		{
			return 5;
		}
	}

	// Token: 0x1700023D RID: 573
	// (get) Token: 0x0600346D RID: 13421 RVA: 0x001146CC File Offset: 0x001128CC
	[Token(Token = "0x1700023D")]
	public override int GreenCount
	{
		[Token(Token = "0x600346D")]
		[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "46")]
		get
		{
			return 2;
		}
	}

	// Token: 0x1700023E RID: 574
	// (get) Token: 0x0600346E RID: 13422 RVA: 0x001146DC File Offset: 0x001128DC
	[Token(Token = "0x1700023E")]
	public override List<PlantType> Plants
	{
		[Token(Token = "0x600346E")]
		[Address(RVA = "0x771050", Offset = "0x76F650", VA = "0x180771050", Slot = "50")]
		get
		{
			List<PlantType> list = new List();
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
			int size15 = list._size;
			int size16 = list._size;
			int size17 = list._size;
			int size18 = list._size;
			int size19 = list._size;
			int size20 = list._size;
			return list;
		}
	}

	// Token: 0x1700023F RID: 575
	// (get) Token: 0x0600346F RID: 13423 RVA: 0x001147A8 File Offset: 0x001129A8
	[Token(Token = "0x1700023F")]
	public override List<ZombieType> Zombies
	{
		[Token(Token = "0x600346F")]
		[Address(RVA = "0x771780", Offset = "0x76FD80", VA = "0x180771780", Slot = "49")]
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
			int size15 = list._size;
			int size16 = list._size;
			int size17 = list._size;
			int size18 = list._size;
			int size19 = list._size;
			int size20 = list._size;
			return list;
		}
	}

	// Token: 0x06003470 RID: 13424 RVA: 0x00114874 File Offset: 0x00112A74
	[Token(Token = "0x6003470")]
	[Address(RVA = "0x7602C0", Offset = "0x75E8C0", VA = "0x1807602C0")]
	public ScaryPot3()
	{
	}
}
