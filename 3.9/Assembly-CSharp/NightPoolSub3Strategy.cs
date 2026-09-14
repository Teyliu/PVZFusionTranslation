using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200094A RID: 2378
[Token(Token = "0x200094A")]
public class NightPoolSub3Strategy : BaseLevelStrategy
{
	// Token: 0x060030B2 RID: 12466 RVA: 0x00103EC0 File Offset: 0x001020C0
	[Token(Token = "0x60030B2")]
	[Address(RVA = "0x7182C0", Offset = "0x7168C0", VA = "0x1807182C0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.NightPool_sub3;
	}

	// Token: 0x060030B3 RID: 12467 RVA: 0x00103ED0 File Offset: 0x001020D0
	[Token(Token = "0x60030B3")]
	[Address(RVA = "0x7185A0", Offset = "0x716BA0", VA = "0x1807185A0", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.boardTag.isIndestructible = true;
		board.theSun = (int)((ulong)3000L);
		board.boardTag.disableSummonZombie = true;
	}

	// Token: 0x060030B4 RID: 12468 RVA: 0x00103F08 File Offset: 0x00102108
	[Token(Token = "0x60030B4")]
	[Address(RVA = "0x712FE0", Offset = "0x7115E0", VA = "0x180712FE0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 30;
	}

	// Token: 0x060030B5 RID: 12469 RVA: 0x00103F18 File Offset: 0x00102118
	[Token(Token = "0x60030B5")]
	[Address(RVA = "0x7182D0", Offset = "0x7168D0", VA = "0x1807182D0", Slot = "24")]
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

	// Token: 0x060030B6 RID: 12470 RVA: 0x00103F7C File Offset: 0x0010217C
	[Token(Token = "0x60030B6")]
	[Address(RVA = "0x718280", Offset = "0x716880", VA = "0x180718280", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Magnetshroom;
	}

	// Token: 0x060030B7 RID: 12471 RVA: 0x00103F8C File Offset: 0x0010218C
	[Token(Token = "0x60030B7")]
	[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.NightPool;
	}

	// Token: 0x060030B8 RID: 12472 RVA: 0x00103F9C File Offset: 0x0010219C
	[Token(Token = "0x60030B8")]
	[Address(RVA = "0x718290", Offset = "0x716890", VA = "0x180718290", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：坚不可摧";
	}

	// Token: 0x060030B9 RID: 12473 RVA: 0x00103FB0 File Offset: 0x001021B0
	[Token(Token = "0x60030B9")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public NightPoolSub3Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
