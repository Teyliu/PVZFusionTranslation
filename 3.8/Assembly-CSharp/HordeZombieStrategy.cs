using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200093E RID: 2366
[Token(Token = "0x200093E")]
public class HordeZombieStrategy : BaseLevelStrategy
{
	// Token: 0x060030BF RID: 12479 RVA: 0x001023FC File Offset: 0x001005FC
	[Token(Token = "0x60030BF")]
	[Address(RVA = "0x3AD630", Offset = "0x3ABC30", VA = "0x1803AD630", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.HordeZombie;
	}

	// Token: 0x060030C0 RID: 12480 RVA: 0x00102410 File Offset: 0x00100610
	[Token(Token = "0x60030C0")]
	[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 10;
	}

	// Token: 0x060030C1 RID: 12481 RVA: 0x00102420 File Offset: 0x00100620
	[Token(Token = "0x60030C1")]
	[Address(RVA = "0x69A350", Offset = "0x698950", VA = "0x18069A350", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		return list;
	}

	// Token: 0x060030C2 RID: 12482 RVA: 0x00102454 File Offset: 0x00100654
	[Token(Token = "0x60030C2")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SunFlower;
	}

	// Token: 0x060030C3 RID: 12483 RVA: 0x00102464 File Offset: 0x00100664
	[Token(Token = "0x60030C3")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x060030C4 RID: 12484 RVA: 0x0010247C File Offset: 0x0010067C
	[Token(Token = "0x60030C4")]
	[Address(RVA = "0x69A320", Offset = "0x698920", VA = "0x18069A320", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉挑战：僵尸海";
	}

	// Token: 0x060030C5 RID: 12485 RVA: 0x00102490 File Offset: 0x00100690
	[Token(Token = "0x60030C5")]
	[Address(RVA = "0x69A420", Offset = "0x698A20", VA = "0x18069A420", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.config.zombieCountMultiplier = 1000f;
	}

	// Token: 0x060030C6 RID: 12486 RVA: 0x001024B4 File Offset: 0x001006B4
	[Token(Token = "0x60030C6")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public HordeZombieStrategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
