using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x020009F6 RID: 2550
[Token(Token = "0x20009F6")]
public abstract class ScaryPotLevel : ChallengeLevelData
{
	// Token: 0x1700021E RID: 542
	// (get) Token: 0x06003449 RID: 13385 RVA: 0x0011406C File Offset: 0x0011226C
	[Token(Token = "0x1700021E")]
	public override SceneType SceneType
	{
		[Token(Token = "0x6003449")]
		[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "12")]
		get
		{
			return SceneType.Night;
		}
	}

	// Token: 0x1700021F RID: 543
	// (get) Token: 0x0600344A RID: 13386 RVA: 0x0011407C File Offset: 0x0011227C
	[Token(Token = "0x1700021F")]
	public override LevelType LevelType
	{
		[Token(Token = "0x600344A")]
		[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "14")]
		get
		{
			return LevelType.Challenge;
		}
	}

	// Token: 0x17000220 RID: 544
	// (get) Token: 0x0600344B RID: 13387 RVA: 0x0011408C File Offset: 0x0011228C
	[Token(Token = "0x17000220")]
	public virtual int EmptyColumns
	{
		[Token(Token = "0x600344B")]
		[Address(RVA = "0x698010", Offset = "0x696610", VA = "0x180698010", Slot = "43")]
		get;
	}

	// Token: 0x17000221 RID: 545
	// (get) Token: 0x0600344C RID: 13388 RVA: 0x001140A0 File Offset: 0x001122A0
	[Token(Token = "0x17000221")]
	public virtual int NumberOfColumns
	{
		[Token(Token = "0x600344C")]
		[Address(RVA = "0x774C80", Offset = "0x773280", VA = "0x180774C80", Slot = "44")]
		get;
	}

	// Token: 0x17000222 RID: 546
	// (get) Token: 0x0600344D RID: 13389 RVA: 0x001140B4 File Offset: 0x001122B4
	[Token(Token = "0x17000222")]
	public virtual int NumberOfRows
	{
		[Token(Token = "0x600344D")]
		[Address(RVA = "0x774C90", Offset = "0x773290", VA = "0x180774C90", Slot = "45")]
		get;
	}

	// Token: 0x17000223 RID: 547
	// (get) Token: 0x0600344E RID: 13390 RVA: 0x001140C8 File Offset: 0x001122C8
	[Token(Token = "0x17000223")]
	public virtual int GreenCount
	{
		[Token(Token = "0x600344E")]
		[Address(RVA = "0x774C70", Offset = "0x773270", VA = "0x180774C70", Slot = "46")]
		get;
	}

	// Token: 0x17000224 RID: 548
	// (get) Token: 0x0600344F RID: 13391 RVA: 0x001140DC File Offset: 0x001122DC
	[Token(Token = "0x17000224")]
	public virtual int HypnoCount
	{
		[Token(Token = "0x600344F")]
		[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "47")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000225 RID: 549
	// (get) Token: 0x06003450 RID: 13392 RVA: 0x001140EC File Offset: 0x001122EC
	[Token(Token = "0x17000225")]
	public virtual int ObsidianCount
	{
		[Token(Token = "0x6003450")]
		[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "48")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000226 RID: 550
	// (get) Token: 0x06003451 RID: 13393 RVA: 0x001140FC File Offset: 0x001122FC
	[Token(Token = "0x17000226")]
	public virtual List<ZombieType> Zombies
	{
		[Token(Token = "0x6003451")]
		[Address(RVA = "0x68D8F0", Offset = "0x68BEF0", VA = "0x18068D8F0", Slot = "49")]
		get;
	}

	// Token: 0x17000227 RID: 551
	// (get) Token: 0x06003452 RID: 13394 RVA: 0x00114110 File Offset: 0x00112310
	[Token(Token = "0x17000227")]
	public virtual List<PlantType> Plants
	{
		[Token(Token = "0x6003452")]
		[Address(RVA = "0x774CA0", Offset = "0x7732A0", VA = "0x180774CA0", Slot = "50")]
		get;
	}

	// Token: 0x06003453 RID: 13395 RVA: 0x00114124 File Offset: 0x00112324
	[Token(Token = "0x6003453")]
	[Address(RVA = "0x774BB0", Offset = "0x7731B0", VA = "0x180774BB0", Slot = "39")]
	public override void OnBoardAwake(Board board)
	{
		board.theSun = (int)((ulong)0L);
		board.boardTag.isScaryPot = true;
		board.boardTag.disableInInterlude = true;
		board.cardBank = false;
	}

	// Token: 0x06003454 RID: 13396 RVA: 0x00114160 File Offset: 0x00112360
	[Token(Token = "0x6003454")]
	[Address(RVA = "0x774BF0", Offset = "0x7731F0", VA = "0x180774BF0", Slot = "36")]
	public override void OnBoardStart(Board board)
	{
		int theMaxWave = board.theMaxWave;
		board.theWave = theMaxWave;
		int theBoardLevel = GameAPP.theBoardLevel;
	}

	// Token: 0x06003455 RID: 13397 RVA: 0x00114188 File Offset: 0x00112388
	[Token(Token = "0x6003455")]
	[Address(RVA = "0x7602C0", Offset = "0x75E8C0", VA = "0x1807602C0")]
	protected ScaryPotLevel()
	{
	}
}
