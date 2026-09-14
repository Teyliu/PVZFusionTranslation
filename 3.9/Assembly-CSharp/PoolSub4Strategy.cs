using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000938 RID: 2360
[Token(Token = "0x2000938")]
public class PoolSub4Strategy : BaseLevelStrategy
{
	// Token: 0x06003039 RID: 12345 RVA: 0x00102B0C File Offset: 0x00100D0C
	[Token(Token = "0x6003039")]
	[Address(RVA = "0x71E0C0", Offset = "0x71C6C0", VA = "0x18071E0C0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Pool_sub4;
	}

	// Token: 0x0600303A RID: 12346 RVA: 0x00102B1C File Offset: 0x00100D1C
	[Token(Token = "0x600303A")]
	[Address(RVA = "0x712F40", Offset = "0x711540", VA = "0x180712F40", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.cardBank = false;
		board.boardTag.disableSelectCard = true;
		board.boardTag.isConvey = true;
		board.timeUntilNextWave = 3f;
	}

	// Token: 0x0600303B RID: 12347 RVA: 0x00102B5C File Offset: 0x00100D5C
	[Token(Token = "0x600303B")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x0600303C RID: 12348 RVA: 0x00102B6C File Offset: 0x00100D6C
	[Token(Token = "0x600303C")]
	[Address(RVA = "0x71E0D0", Offset = "0x71C6D0", VA = "0x18071E0D0", Slot = "24")]
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

	// Token: 0x0600303D RID: 12349 RVA: 0x00102BD0 File Offset: 0x00100DD0
	[Token(Token = "0x600303D")]
	[Address(RVA = "0x714BD0", Offset = "0x7131D0", VA = "0x180714BD0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.ThreePeater;
	}

	// Token: 0x0600303E RID: 12350 RVA: 0x00102BE0 File Offset: 0x00100DE0
	[Token(Token = "0x600303E")]
	[Address(RVA = "0x71DC70", Offset = "0x71C270", VA = "0x18071DC70", Slot = "26")]
	public override List<PlantType> GetConveyPlants()
	{
		List<PlantType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		list._size = 1;
		list._syncRoot = (ulong)0L;
		int size6 = list._size;
		list._size = 1;
		int size7 = list._size;
		list._size = 1;
		int size8 = list._size;
		list._size = 1;
		int size9 = list._size;
		list._size = 1;
		int size10 = list._size;
		list._size = 1;
		int size11 = list._size;
		return list;
	}

	// Token: 0x0600303F RID: 12351 RVA: 0x00102C9C File Offset: 0x00100E9C
	[Token(Token = "0x600303F")]
	[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Pool;
	}

	// Token: 0x06003040 RID: 12352 RVA: 0x00102CAC File Offset: 0x00100EAC
	[Token(Token = "0x6003040")]
	[Address(RVA = "0x71E090", Offset = "0x71C690", VA = "0x18071E090", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：泳池传送带";
	}

	// Token: 0x06003041 RID: 12353 RVA: 0x00102CC0 File Offset: 0x00100EC0
	[Token(Token = "0x6003041")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public PoolSub4Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
