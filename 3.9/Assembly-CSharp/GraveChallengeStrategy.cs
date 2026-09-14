using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200097B RID: 2427
[Token(Token = "0x200097B")]
public class GraveChallengeStrategy : BaseLevelStrategy
{
	// Token: 0x060031FA RID: 12794 RVA: 0x0010723C File Offset: 0x0010543C
	[Token(Token = "0x60031FA")]
	[Address(RVA = "0x3F8FC0", Offset = "0x3F75C0", VA = "0x1803F8FC0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.GraveChallenge;
	}

	// Token: 0x060031FB RID: 12795 RVA: 0x00107250 File Offset: 0x00105450
	[Token(Token = "0x60031FB")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x060031FC RID: 12796 RVA: 0x00107260 File Offset: 0x00105460
	[Token(Token = "0x60031FC")]
	[Address(RVA = "0x713F70", Offset = "0x712570", VA = "0x180713F70", Slot = "24")]
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
		int size8 = list._size;
		int size9 = list._size;
		int size10 = list._size;
		return list;
	}

	// Token: 0x060031FD RID: 12797 RVA: 0x001072E0 File Offset: 0x001054E0
	[Token(Token = "0x60031FD")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SunFlower;
	}

	// Token: 0x060031FE RID: 12798 RVA: 0x001072F0 File Offset: 0x001054F0
	[Token(Token = "0x60031FE")]
	[Address(RVA = "0x3FA3D0", Offset = "0x3F89D0", VA = "0x1803FA3D0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Night_6;
	}

	// Token: 0x060031FF RID: 12799 RVA: 0x00107300 File Offset: 0x00105500
	[Token(Token = "0x60031FF")]
	[Address(RVA = "0x713F40", Offset = "0x712540", VA = "0x180713F40", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉挑战：你能挖掉它吗";
	}

	// Token: 0x06003200 RID: 12800 RVA: 0x00107314 File Offset: 0x00105514
	[Token(Token = "0x6003200")]
	[Address(RVA = "0x714370", Offset = "0x712970", VA = "0x180714370", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		int num = 0;
		if (num < board.columnNum)
		{
			if (num < board.rowNum)
			{
				if (0UL != (ulong)1L)
				{
					int num2 = 0;
					GridItem gridItem = GridItem.SetGridItem(num, num, (GridItemType)((uint)7), (GraveType)num2);
					num++;
				}
				Crater crater = board.boardAction.SetPit(num, num);
				int num3 = 0;
				if (crater != num3)
				{
					crater.maxTimer = 360f;
				}
				num++;
			}
			num++;
		}
	}

	// Token: 0x06003201 RID: 12801 RVA: 0x00107384 File Offset: 0x00105584
	[Token(Token = "0x6003201")]
	[Address(RVA = "0x714330", Offset = "0x712930", VA = "0x180714330", Slot = "35")]
	public override void InitCard(InitBoard board)
	{
		board.PreSelect((PlantType)((uint)239)).fullCD = 15f;
	}

	// Token: 0x06003202 RID: 12802 RVA: 0x001073B0 File Offset: 0x001055B0
	[Token(Token = "0x6003202")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public GraveChallengeStrategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
