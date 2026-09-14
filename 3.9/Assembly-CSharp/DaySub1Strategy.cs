using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200090C RID: 2316
[Token(Token = "0x200090C")]
public class DaySub1Strategy : BaseLevelStrategy
{
	// Token: 0x06002F14 RID: 12052 RVA: 0x000FFCE4 File Offset: 0x000FDEE4
	[Token(Token = "0x6002F14")]
	[Address(RVA = "0x3FA3D0", Offset = "0x3F89D0", VA = "0x1803FA3D0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Day_sub1;
	}

	// Token: 0x06002F15 RID: 12053 RVA: 0x000FFCF4 File Offset: 0x000FDEF4
	[Token(Token = "0x6002F15")]
	[Address(RVA = "0x7128E0", Offset = "0x710EE0", VA = "0x1807128E0", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.boardTag.isLoonGame = true;
		board.SetRedLine(2);
		board.cardBank = false;
		board.boardTag.disableSelectCard = true;
		board.boardTag.isConvey = true;
		board.timeUntilNextWave = 3f;
	}

	// Token: 0x06002F16 RID: 12054 RVA: 0x000FFD44 File Offset: 0x000FDF44
	[Token(Token = "0x6002F16")]
	[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 10;
	}

	// Token: 0x06002F17 RID: 12055 RVA: 0x000FFD54 File Offset: 0x000FDF54
	[Token(Token = "0x6002F17")]
	[Address(RVA = "0x712770", Offset = "0x710D70", VA = "0x180712770", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06002F18 RID: 12056 RVA: 0x000FFD9C File Offset: 0x000FDF9C
	[Token(Token = "0x6002F18")]
	[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Chomper;
	}

	// Token: 0x06002F19 RID: 12057 RVA: 0x000FFDAC File Offset: 0x000FDFAC
	[Token(Token = "0x6002F19")]
	[Address(RVA = "0x712490", Offset = "0x710A90", VA = "0x180712490", Slot = "26")]
	public override List<PlantType> GetConveyPlants()
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

	// Token: 0x06002F1A RID: 12058 RVA: 0x000FFE08 File Offset: 0x000FE008
	[Token(Token = "0x6002F1A")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x06002F1B RID: 12059 RVA: 0x000FFE20 File Offset: 0x000FE020
	[Token(Token = "0x6002F1B")]
	[Address(RVA = "0x712710", Offset = "0x710D10", VA = "0x180712710", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：坚果保龄球";
	}

	// Token: 0x06002F1C RID: 12060 RVA: 0x000FFE34 File Offset: 0x000FE034
	[Token(Token = "0x6002F1C")]
	[Address(RVA = "0x712740", Offset = "0x710D40", VA = "0x180712740", Slot = "31")]
	public override string GetLevelTip()
	{
		return "如果打不过多注意一下主线第四关";
	}

	// Token: 0x06002F1D RID: 12061 RVA: 0x000FFE48 File Offset: 0x000FE048
	[Token(Token = "0x6002F1D")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public DaySub1Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
