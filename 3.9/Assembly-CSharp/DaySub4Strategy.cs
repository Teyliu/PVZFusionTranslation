using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200090F RID: 2319
[Token(Token = "0x200090F")]
public class DaySub4Strategy : BaseLevelStrategy
{
	// Token: 0x06002F2E RID: 12078 RVA: 0x001000AC File Offset: 0x000FE2AC
	[Token(Token = "0x6002F2E")]
	[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Day_sub4;
	}

	// Token: 0x06002F2F RID: 12079 RVA: 0x001000BC File Offset: 0x000FE2BC
	[Token(Token = "0x6002F2F")]
	[Address(RVA = "0x7135A0", Offset = "0x711BA0", VA = "0x1807135A0", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.boardTag.disableSelectCard = true;
	}

	// Token: 0x06002F30 RID: 12080 RVA: 0x001000DC File Offset: 0x000FE2DC
	[Token(Token = "0x6002F30")]
	[Address(RVA = "0x712FE0", Offset = "0x7115E0", VA = "0x180712FE0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 30;
	}

	// Token: 0x06002F31 RID: 12081 RVA: 0x001000EC File Offset: 0x000FE2EC
	[Token(Token = "0x6002F31")]
	[Address(RVA = "0x713480", Offset = "0x711A80", VA = "0x180713480", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		return list;
	}

	// Token: 0x06002F32 RID: 12082 RVA: 0x00100128 File Offset: 0x000FE328
	[Token(Token = "0x6002F32")]
	[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.WallNut;
	}

	// Token: 0x06002F33 RID: 12083 RVA: 0x00100138 File Offset: 0x000FE338
	[Token(Token = "0x6002F33")]
	[Address(RVA = "0x712FF0", Offset = "0x7115F0", VA = "0x180712FF0", Slot = "27")]
	public override List<PlantType> GetRandomPlantTypes()
	{
		List<PlantType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		int size6 = list._size;
		return list;
	}

	// Token: 0x06002F34 RID: 12084 RVA: 0x00100198 File Offset: 0x000FE398
	[Token(Token = "0x6002F34")]
	[Address(RVA = "0x713260", Offset = "0x711860", VA = "0x180713260", Slot = "28")]
	public override List<ZombieType> GetRandomZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		return list;
	}

	// Token: 0x06002F35 RID: 12085 RVA: 0x001001F0 File Offset: 0x000FE3F0
	[Token(Token = "0x6002F35")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x06002F36 RID: 12086 RVA: 0x00100208 File Offset: 0x000FE408
	[Token(Token = "0x6002F36")]
	[Address(RVA = "0x712F80", Offset = "0x711580", VA = "0x180712F80", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：随机植物VS随机僵尸";
	}

	// Token: 0x06002F37 RID: 12087 RVA: 0x0010021C File Offset: 0x000FE41C
	[Token(Token = "0x6002F37")]
	[Address(RVA = "0x712FB0", Offset = "0x7115B0", VA = "0x180712FB0", Slot = "31")]
	public override string GetLevelTip()
	{
		return "只会随机出白天的植物和僵尸";
	}

	// Token: 0x06002F38 RID: 12088 RVA: 0x00100230 File Offset: 0x000FE430
	[Token(Token = "0x6002F38")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public DaySub4Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
