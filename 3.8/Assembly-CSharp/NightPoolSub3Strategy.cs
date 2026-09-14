using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200090E RID: 2318
[Token(Token = "0x200090E")]
public class NightPoolSub3Strategy : BaseLevelStrategy
{
	// Token: 0x06002F7F RID: 12159 RVA: 0x000FF238 File Offset: 0x000FD438
	[Token(Token = "0x6002F7F")]
	[Address(RVA = "0x69E160", Offset = "0x69C760", VA = "0x18069E160", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.NightPool_sub3;
	}

	// Token: 0x06002F80 RID: 12160 RVA: 0x000FF248 File Offset: 0x000FD448
	[Token(Token = "0x6002F80")]
	[Address(RVA = "0x69E440", Offset = "0x69CA40", VA = "0x18069E440", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.boardTag.isIndestructible = true;
		board.theSun = (int)((ulong)3000L);
		board.boardTag.disableSummonZombie = true;
	}

	// Token: 0x06002F81 RID: 12161 RVA: 0x000FF280 File Offset: 0x000FD480
	[Token(Token = "0x6002F81")]
	[Address(RVA = "0x698EE0", Offset = "0x6974E0", VA = "0x180698EE0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 30;
	}

	// Token: 0x06002F82 RID: 12162 RVA: 0x000FF290 File Offset: 0x000FD490
	[Token(Token = "0x6002F82")]
	[Address(RVA = "0x69E170", Offset = "0x69C770", VA = "0x18069E170", Slot = "24")]
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

	// Token: 0x06002F83 RID: 12163 RVA: 0x000FF2F4 File Offset: 0x000FD4F4
	[Token(Token = "0x6002F83")]
	[Address(RVA = "0x69E120", Offset = "0x69C720", VA = "0x18069E120", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Magnetshroom;
	}

	// Token: 0x06002F84 RID: 12164 RVA: 0x000FF304 File Offset: 0x000FD504
	[Token(Token = "0x6002F84")]
	[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.NightPool;
	}

	// Token: 0x06002F85 RID: 12165 RVA: 0x000FF314 File Offset: 0x000FD514
	[Token(Token = "0x6002F85")]
	[Address(RVA = "0x69E130", Offset = "0x69C730", VA = "0x18069E130", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：坚不可摧";
	}

	// Token: 0x06002F86 RID: 12166 RVA: 0x000FF328 File Offset: 0x000FD528
	[Token(Token = "0x6002F86")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public NightPoolSub3Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
