using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000923 RID: 2339
[Token(Token = "0x2000923")]
public class NightSub3Strategy : BaseLevelStrategy
{
	// Token: 0x06002FAF RID: 12207 RVA: 0x001013A8 File Offset: 0x000FF5A8
	[Token(Token = "0x6002FAF")]
	[Address(RVA = "0x716AF0", Offset = "0x7150F0", VA = "0x180716AF0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Night_sub3;
	}

	// Token: 0x06002FB0 RID: 12208 RVA: 0x001013B8 File Offset: 0x000FF5B8
	[Token(Token = "0x6002FB0")]
	[Address(RVA = "0x712F40", Offset = "0x711540", VA = "0x180712F40", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.cardBank = false;
		board.boardTag.disableSelectCard = true;
		board.boardTag.isConvey = true;
		board.timeUntilNextWave = 3f;
	}

	// Token: 0x06002FB1 RID: 12209 RVA: 0x001013F8 File Offset: 0x000FF5F8
	[Token(Token = "0x6002FB1")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002FB2 RID: 12210 RVA: 0x00101408 File Offset: 0x000FF608
	[Token(Token = "0x6002FB2")]
	[Address(RVA = "0x719F00", Offset = "0x718500", VA = "0x180719F00", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		return list;
	}

	// Token: 0x06002FB3 RID: 12211 RVA: 0x0010145C File Offset: 0x000FF65C
	[Token(Token = "0x6002FB3")]
	[Address(RVA = "0x3F6B70", Offset = "0x3F5170", VA = "0x1803F6B70", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.HypnoShroom;
	}

	// Token: 0x06002FB4 RID: 12212 RVA: 0x0010146C File Offset: 0x000FF66C
	[Token(Token = "0x6002FB4")]
	[Address(RVA = "0x719AB0", Offset = "0x7180B0", VA = "0x180719AB0", Slot = "26")]
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
		int size10 = list._size;
		int size11 = list._size;
		return list;
	}

	// Token: 0x06002FB5 RID: 12213 RVA: 0x001014F0 File Offset: 0x000FF6F0
	[Token(Token = "0x6002FB5")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Night;
	}

	// Token: 0x06002FB6 RID: 12214 RVA: 0x00101500 File Offset: 0x000FF700
	[Token(Token = "0x6002FB6")]
	[Address(RVA = "0x719ED0", Offset = "0x7184D0", VA = "0x180719ED0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：黑夜传送带";
	}

	// Token: 0x06002FB7 RID: 12215 RVA: 0x00101514 File Offset: 0x000FF714
	[Token(Token = "0x6002FB7")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public NightSub3Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
