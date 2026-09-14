using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x020009BA RID: 2490
[Token(Token = "0x20009BA")]
public abstract class ScaryPotLevel : ChallengeLevelData
{
	// Token: 0x170001D6 RID: 470
	// (get) Token: 0x06003315 RID: 13077 RVA: 0x0010F05C File Offset: 0x0010D25C
	[Token(Token = "0x170001D6")]
	public override SceneType SceneType
	{
		[Token(Token = "0x6003315")]
		[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "12")]
		get
		{
			return SceneType.Night;
		}
	}

	// Token: 0x170001D7 RID: 471
	// (get) Token: 0x06003316 RID: 13078 RVA: 0x0010F06C File Offset: 0x0010D26C
	[Token(Token = "0x170001D7")]
	public override LevelType LevelType
	{
		[Token(Token = "0x6003316")]
		[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "14")]
		get
		{
			return LevelType.Challenge;
		}
	}

	// Token: 0x170001D8 RID: 472
	// (get) Token: 0x06003317 RID: 13079 RVA: 0x0010F07C File Offset: 0x0010D27C
	[Token(Token = "0x170001D8")]
	public virtual int EmptyColumns
	{
		[Token(Token = "0x6003317")]
		[Address(RVA = "0x633CE0", Offset = "0x6322E0", VA = "0x180633CE0", Slot = "43")]
		get;
	}

	// Token: 0x170001D9 RID: 473
	// (get) Token: 0x06003318 RID: 13080 RVA: 0x0010F090 File Offset: 0x0010D290
	[Token(Token = "0x170001D9")]
	public virtual int NumberOfColumns
	{
		[Token(Token = "0x6003318")]
		[Address(RVA = "0x70F750", Offset = "0x70DD50", VA = "0x18070F750", Slot = "44")]
		get;
	}

	// Token: 0x170001DA RID: 474
	// (get) Token: 0x06003319 RID: 13081 RVA: 0x0010F0A4 File Offset: 0x0010D2A4
	[Token(Token = "0x170001DA")]
	public virtual int NumberOfRows
	{
		[Token(Token = "0x6003319")]
		[Address(RVA = "0x70F760", Offset = "0x70DD60", VA = "0x18070F760", Slot = "45")]
		get;
	}

	// Token: 0x170001DB RID: 475
	// (get) Token: 0x0600331A RID: 13082 RVA: 0x0010F0B8 File Offset: 0x0010D2B8
	[Token(Token = "0x170001DB")]
	public virtual int GreenCount
	{
		[Token(Token = "0x600331A")]
		[Address(RVA = "0x70F740", Offset = "0x70DD40", VA = "0x18070F740", Slot = "46")]
		get;
	}

	// Token: 0x170001DC RID: 476
	// (get) Token: 0x0600331B RID: 13083 RVA: 0x0010F0CC File Offset: 0x0010D2CC
	[Token(Token = "0x170001DC")]
	public virtual int HypnoCount
	{
		[Token(Token = "0x600331B")]
		[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "47")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170001DD RID: 477
	// (get) Token: 0x0600331C RID: 13084 RVA: 0x0010F0DC File Offset: 0x0010D2DC
	[Token(Token = "0x170001DD")]
	public virtual int ObsidianCount
	{
		[Token(Token = "0x600331C")]
		[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "48")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170001DE RID: 478
	// (get) Token: 0x0600331D RID: 13085 RVA: 0x0010F0EC File Offset: 0x0010D2EC
	[Token(Token = "0x170001DE")]
	public virtual List<ZombieType> Zombies
	{
		[Token(Token = "0x600331D")]
		[Address(RVA = "0x629FF0", Offset = "0x6285F0", VA = "0x180629FF0", Slot = "49")]
		get;
	}

	// Token: 0x170001DF RID: 479
	// (get) Token: 0x0600331E RID: 13086 RVA: 0x0010F100 File Offset: 0x0010D300
	[Token(Token = "0x170001DF")]
	public virtual List<PlantType> Plants
	{
		[Token(Token = "0x600331E")]
		[Address(RVA = "0x70F770", Offset = "0x70DD70", VA = "0x18070F770", Slot = "50")]
		get;
	}

	// Token: 0x0600331F RID: 13087 RVA: 0x0010F114 File Offset: 0x0010D314
	[Token(Token = "0x600331F")]
	[Address(RVA = "0x70F680", Offset = "0x70DC80", VA = "0x18070F680", Slot = "39")]
	public override void OnBoardAwake(Board board)
	{
		board.theSun = (int)((ulong)0L);
		board.boardTag.isScaryPot = true;
		board.boardTag.disableInInterlude = true;
		board.cardBank = false;
	}

	// Token: 0x06003320 RID: 13088 RVA: 0x0010F150 File Offset: 0x0010D350
	[Token(Token = "0x6003320")]
	[Address(RVA = "0x70F6C0", Offset = "0x70DCC0", VA = "0x18070F6C0", Slot = "36")]
	public override void OnBoardStart(Board board)
	{
		int theMaxWave = board.theMaxWave;
		board.theWave = theMaxWave;
		int theBoardLevel = GameAPP.theBoardLevel;
	}

	// Token: 0x06003321 RID: 13089 RVA: 0x0010F178 File Offset: 0x0010D378
	[Token(Token = "0x6003321")]
	[Address(RVA = "0x6FAF20", Offset = "0x6F9520", VA = "0x1806FAF20")]
	protected ScaryPotLevel()
	{
	}
}
