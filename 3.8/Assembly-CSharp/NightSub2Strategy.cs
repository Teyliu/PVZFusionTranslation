using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008E6 RID: 2278
[Token(Token = "0x20008E6")]
public class NightSub2Strategy : BaseLevelStrategy
{
	// Token: 0x06002E74 RID: 11892 RVA: 0x000FC704 File Offset: 0x000FA904
	[Token(Token = "0x6002E74")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Night_sub2;
	}

	// Token: 0x06002E75 RID: 11893 RVA: 0x000FC714 File Offset: 0x000FA914
	[Token(Token = "0x6002E75")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002E76 RID: 11894 RVA: 0x000FC724 File Offset: 0x000FA924
	[Token(Token = "0x6002E76")]
	[Address(RVA = "0x69F750", Offset = "0x69DD50", VA = "0x18069F750", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x06002E77 RID: 11895 RVA: 0x000FC774 File Offset: 0x000FA974
	[Token(Token = "0x6002E77")]
	[Address(RVA = "0x3AE560", Offset = "0x3ACB60", VA = "0x1803AE560", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.FumeShroom;
	}

	// Token: 0x06002E78 RID: 11896 RVA: 0x000FC784 File Offset: 0x000FA984
	[Token(Token = "0x6002E78")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Night;
	}

	// Token: 0x06002E79 RID: 11897 RVA: 0x000FC794 File Offset: 0x000FA994
	[Token(Token = "0x6002E79")]
	[Address(RVA = "0x69F720", Offset = "0x69DD20", VA = "0x18069F720", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：撑杆舞会";
	}

	// Token: 0x06002E7A RID: 11898 RVA: 0x000FC7A8 File Offset: 0x000FA9A8
	[Token(Token = "0x6002E7A")]
	[Address(RVA = "0x69F920", Offset = "0x69DF20", VA = "0x18069F920", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		float timeUntilNextWave = board.timeUntilNextWave;
		board.timeUntilNextWave = timeUntilNextWave;
	}

	// Token: 0x06002E7B RID: 11899 RVA: 0x000FC7CC File Offset: 0x000FA9CC
	[Token(Token = "0x6002E7B")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public NightSub2Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
