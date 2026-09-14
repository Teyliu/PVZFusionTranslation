using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200097A RID: 2426
[Token(Token = "0x200097A")]
public class HordeZombieStrategy : BaseLevelStrategy
{
	// Token: 0x060031F2 RID: 12786 RVA: 0x0010716C File Offset: 0x0010536C
	[Token(Token = "0x60031F2")]
	[Address(RVA = "0x3F94A0", Offset = "0x3F7AA0", VA = "0x1803F94A0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.HordeZombie;
	}

	// Token: 0x060031F3 RID: 12787 RVA: 0x00107180 File Offset: 0x00105380
	[Token(Token = "0x60031F3")]
	[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 10;
	}

	// Token: 0x060031F4 RID: 12788 RVA: 0x00107190 File Offset: 0x00105390
	[Token(Token = "0x60031F4")]
	[Address(RVA = "0x7144B0", Offset = "0x712AB0", VA = "0x1807144B0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		return list;
	}

	// Token: 0x060031F5 RID: 12789 RVA: 0x001071C4 File Offset: 0x001053C4
	[Token(Token = "0x60031F5")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SunFlower;
	}

	// Token: 0x060031F6 RID: 12790 RVA: 0x001071D4 File Offset: 0x001053D4
	[Token(Token = "0x60031F6")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x060031F7 RID: 12791 RVA: 0x001071EC File Offset: 0x001053EC
	[Token(Token = "0x60031F7")]
	[Address(RVA = "0x714480", Offset = "0x712A80", VA = "0x180714480", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉挑战：僵尸海";
	}

	// Token: 0x060031F8 RID: 12792 RVA: 0x00107200 File Offset: 0x00105400
	[Token(Token = "0x60031F8")]
	[Address(RVA = "0x714580", Offset = "0x712B80", VA = "0x180714580", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.config.zombieCountMultiplier = 1000f;
	}

	// Token: 0x060031F9 RID: 12793 RVA: 0x00107224 File Offset: 0x00105424
	[Token(Token = "0x60031F9")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public HordeZombieStrategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
