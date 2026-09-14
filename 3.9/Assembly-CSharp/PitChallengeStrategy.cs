using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200097C RID: 2428
[Token(Token = "0x200097C")]
public class PitChallengeStrategy : BaseLevelStrategy
{
	// Token: 0x06003203 RID: 12803 RVA: 0x001073C8 File Offset: 0x001055C8
	[Token(Token = "0x6003203")]
	[Address(RVA = "0x3F8720", Offset = "0x3F6D20", VA = "0x1803F8720", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.PitChallenge;
	}

	// Token: 0x06003204 RID: 12804 RVA: 0x001073DC File Offset: 0x001055DC
	[Token(Token = "0x6003204")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06003205 RID: 12805 RVA: 0x001073EC File Offset: 0x001055EC
	[Token(Token = "0x6003205")]
	[Address(RVA = "0x71AA70", Offset = "0x719070", VA = "0x18071AA70", Slot = "24")]
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

	// Token: 0x06003206 RID: 12806 RVA: 0x00107444 File Offset: 0x00105644
	[Token(Token = "0x6003206")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SunFlower;
	}

	// Token: 0x06003207 RID: 12807 RVA: 0x00107454 File Offset: 0x00105654
	[Token(Token = "0x6003207")]
	[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.NightPool;
	}

	// Token: 0x06003208 RID: 12808 RVA: 0x00107464 File Offset: 0x00105664
	[Token(Token = "0x6003208")]
	[Address(RVA = "0x71AA40", Offset = "0x719040", VA = "0x18071AA40", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉挑战：你挖不掉它";
	}

	// Token: 0x06003209 RID: 12809 RVA: 0x00107478 File Offset: 0x00105678
	[Token(Token = "0x6003209")]
	[Address(RVA = "0x71AC90", Offset = "0x719290", VA = "0x18071AC90", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		int num = 0;
		int num2 = 0;
		if (num2 < board.columnNum)
		{
			int num3 = 0;
			if (num3 < board.rowNum)
			{
				if (board.GetBoxType(num, num3) != BoxType.Water)
				{
					board.boardAction.SetPit(num, num3).maxTimer = 100000f;
				}
				num3++;
			}
			num++;
		}
	}

	// Token: 0x0600320A RID: 12810 RVA: 0x001074D0 File Offset: 0x001056D0
	[Token(Token = "0x600320A")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public PitChallengeStrategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
