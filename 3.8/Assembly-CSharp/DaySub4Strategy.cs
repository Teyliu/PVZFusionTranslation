using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008D3 RID: 2259
[Token(Token = "0x20008D3")]
public class DaySub4Strategy : BaseLevelStrategy
{
	// Token: 0x06002DFB RID: 11771 RVA: 0x000FB578 File Offset: 0x000F9778
	[Token(Token = "0x6002DFB")]
	[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Day_sub4;
	}

	// Token: 0x06002DFC RID: 11772 RVA: 0x000FB588 File Offset: 0x000F9788
	[Token(Token = "0x6002DFC")]
	[Address(RVA = "0x6994A0", Offset = "0x697AA0", VA = "0x1806994A0", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.boardTag.disableSelectCard = true;
	}

	// Token: 0x06002DFD RID: 11773 RVA: 0x000FB5A8 File Offset: 0x000F97A8
	[Token(Token = "0x6002DFD")]
	[Address(RVA = "0x698EE0", Offset = "0x6974E0", VA = "0x180698EE0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 30;
	}

	// Token: 0x06002DFE RID: 11774 RVA: 0x000FB5B8 File Offset: 0x000F97B8
	[Token(Token = "0x6002DFE")]
	[Address(RVA = "0x699380", Offset = "0x697980", VA = "0x180699380", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		return list;
	}

	// Token: 0x06002DFF RID: 11775 RVA: 0x000FB5F4 File Offset: 0x000F97F4
	[Token(Token = "0x6002DFF")]
	[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.WallNut;
	}

	// Token: 0x06002E00 RID: 11776 RVA: 0x000FB604 File Offset: 0x000F9804
	[Token(Token = "0x6002E00")]
	[Address(RVA = "0x698EF0", Offset = "0x6974F0", VA = "0x180698EF0", Slot = "27")]
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

	// Token: 0x06002E01 RID: 11777 RVA: 0x000FB664 File Offset: 0x000F9864
	[Token(Token = "0x6002E01")]
	[Address(RVA = "0x699160", Offset = "0x697760", VA = "0x180699160", Slot = "28")]
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

	// Token: 0x06002E02 RID: 11778 RVA: 0x000FB6BC File Offset: 0x000F98BC
	[Token(Token = "0x6002E02")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x06002E03 RID: 11779 RVA: 0x000FB6D4 File Offset: 0x000F98D4
	[Token(Token = "0x6002E03")]
	[Address(RVA = "0x698E80", Offset = "0x697480", VA = "0x180698E80", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：随机植物VS随机僵尸";
	}

	// Token: 0x06002E04 RID: 11780 RVA: 0x000FB6E8 File Offset: 0x000F98E8
	[Token(Token = "0x6002E04")]
	[Address(RVA = "0x698EB0", Offset = "0x6974B0", VA = "0x180698EB0", Slot = "31")]
	public override string GetLevelTip()
	{
		return "只会随机出白天的植物和僵尸";
	}

	// Token: 0x06002E05 RID: 11781 RVA: 0x000FB6FC File Offset: 0x000F98FC
	[Token(Token = "0x6002E05")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public DaySub4Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
