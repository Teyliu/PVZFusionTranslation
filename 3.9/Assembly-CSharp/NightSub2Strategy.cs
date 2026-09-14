using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000922 RID: 2338
[Token(Token = "0x2000922")]
public class NightSub2Strategy : BaseLevelStrategy
{
	// Token: 0x06002FA7 RID: 12199 RVA: 0x001012C8 File Offset: 0x000FF4C8
	[Token(Token = "0x6002FA7")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Night_sub2;
	}

	// Token: 0x06002FA8 RID: 12200 RVA: 0x001012D8 File Offset: 0x000FF4D8
	[Token(Token = "0x6002FA8")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002FA9 RID: 12201 RVA: 0x001012E8 File Offset: 0x000FF4E8
	[Token(Token = "0x6002FA9")]
	[Address(RVA = "0x7198B0", Offset = "0x717EB0", VA = "0x1807198B0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x06002FAA RID: 12202 RVA: 0x00101338 File Offset: 0x000FF538
	[Token(Token = "0x6002FAA")]
	[Address(RVA = "0x3FA3D0", Offset = "0x3F89D0", VA = "0x1803FA3D0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.FumeShroom;
	}

	// Token: 0x06002FAB RID: 12203 RVA: 0x00101348 File Offset: 0x000FF548
	[Token(Token = "0x6002FAB")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Night;
	}

	// Token: 0x06002FAC RID: 12204 RVA: 0x00101358 File Offset: 0x000FF558
	[Token(Token = "0x6002FAC")]
	[Address(RVA = "0x719880", Offset = "0x717E80", VA = "0x180719880", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：撑杆舞会";
	}

	// Token: 0x06002FAD RID: 12205 RVA: 0x0010136C File Offset: 0x000FF56C
	[Token(Token = "0x6002FAD")]
	[Address(RVA = "0x719A80", Offset = "0x718080", VA = "0x180719A80", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		float timeUntilNextWave = board.timeUntilNextWave;
		board.timeUntilNextWave = timeUntilNextWave;
	}

	// Token: 0x06002FAE RID: 12206 RVA: 0x00101390 File Offset: 0x000FF590
	[Token(Token = "0x6002FAE")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public NightSub2Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
