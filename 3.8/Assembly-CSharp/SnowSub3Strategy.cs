using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000937 RID: 2359
[Token(Token = "0x2000937")]
public class SnowSub3Strategy : BaseLevelStrategy
{
	// Token: 0x0600308B RID: 12427 RVA: 0x00101C78 File Offset: 0x000FFE78
	[Token(Token = "0x600308B")]
	[Address(RVA = "0x6AC660", Offset = "0x6AAC60", VA = "0x1806AC660", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Snow_sub3;
	}

	// Token: 0x0600308C RID: 12428 RVA: 0x00101C88 File Offset: 0x000FFE88
	[Token(Token = "0x600308C")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x0600308D RID: 12429 RVA: 0x00101C98 File Offset: 0x000FFE98
	[Token(Token = "0x600308D")]
	[Address(RVA = "0x6AC670", Offset = "0x6AAC70", VA = "0x1806AC670", Slot = "24")]
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

	// Token: 0x0600308E RID: 12430 RVA: 0x00101CEC File Offset: 0x000FFEEC
	[Token(Token = "0x600308E")]
	[Address(RVA = "0x6A44C0", Offset = "0x6A2AC0", VA = "0x1806A44C0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SpruceShooter;
	}

	// Token: 0x0600308F RID: 12431 RVA: 0x00101CFC File Offset: 0x000FFEFC
	[Token(Token = "0x600308F")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Snow_6;
	}

	// Token: 0x06003090 RID: 12432 RVA: 0x00101D0C File Offset: 0x000FFF0C
	[Token(Token = "0x6003090")]
	[Address(RVA = "0x6AC630", Offset = "0x6AAC30", VA = "0x1806AC630", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：无僵尸之地";
	}

	// Token: 0x06003091 RID: 12433 RVA: 0x00101D20 File Offset: 0x000FFF20
	[Token(Token = "0x6003091")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public SnowSub3Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
