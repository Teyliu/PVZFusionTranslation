using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200090F RID: 2319
[Token(Token = "0x200090F")]
public class NightPoolSub4Strategy : BaseLevelStrategy
{
	// Token: 0x06002F87 RID: 12167 RVA: 0x000FF340 File Offset: 0x000FD540
	[Token(Token = "0x6002F87")]
	[Address(RVA = "0x69E830", Offset = "0x69CE30", VA = "0x18069E830", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.NightPool_sub4;
	}

	// Token: 0x06002F88 RID: 12168 RVA: 0x000FF350 File Offset: 0x000FD550
	[Token(Token = "0x6002F88")]
	[Address(RVA = "0x698E40", Offset = "0x697440", VA = "0x180698E40", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.cardBank = false;
		board.boardTag.disableSelectCard = true;
		board.boardTag.isConvey = true;
		board.timeUntilNextWave = 3f;
	}

	// Token: 0x06002F89 RID: 12169 RVA: 0x000FF390 File Offset: 0x000FD590
	[Token(Token = "0x6002F89")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002F8A RID: 12170 RVA: 0x000FF3A0 File Offset: 0x000FD5A0
	[Token(Token = "0x6002F8A")]
	[Address(RVA = "0x69E840", Offset = "0x69CE40", VA = "0x18069E840", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		int size6 = list._size;
		int size7 = list._size;
		return list;
	}

	// Token: 0x06002F8B RID: 12171 RVA: 0x000FF404 File Offset: 0x000FD604
	[Token(Token = "0x6002F8B")]
	[Address(RVA = "0x69E470", Offset = "0x69CA70", VA = "0x18069E470", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.StarFruit;
	}

	// Token: 0x06002F8C RID: 12172 RVA: 0x000FF414 File Offset: 0x000FD614
	[Token(Token = "0x6002F8C")]
	[Address(RVA = "0x69E480", Offset = "0x69CA80", VA = "0x18069E480", Slot = "26")]
	public override List<PlantType> GetConveyPlants()
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
		return list;
	}

	// Token: 0x06002F8D RID: 12173 RVA: 0x000FF488 File Offset: 0x000FD688
	[Token(Token = "0x6002F8D")]
	[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.NightPool;
	}

	// Token: 0x06002F8E RID: 12174 RVA: 0x000FF498 File Offset: 0x000FD698
	[Token(Token = "0x6002F8E")]
	[Address(RVA = "0x69E800", Offset = "0x69CE00", VA = "0x18069E800", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：浓雾传送带";
	}

	// Token: 0x06002F8F RID: 12175 RVA: 0x000FF4AC File Offset: 0x000FD6AC
	[Token(Token = "0x6002F8F")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public NightPoolSub4Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
