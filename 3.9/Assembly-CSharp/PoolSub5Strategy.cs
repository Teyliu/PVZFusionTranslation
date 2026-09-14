using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x02000939 RID: 2361
[Token(Token = "0x2000939")]
public class PoolSub5Strategy : BaseLevelStrategy
{
	// Token: 0x06003042 RID: 12354 RVA: 0x00102CD8 File Offset: 0x00100ED8
	[Token(Token = "0x6003042")]
	[Address(RVA = "0x71E400", Offset = "0x71CA00", VA = "0x18071E400", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Pool_sub5;
	}

	// Token: 0x06003043 RID: 12355 RVA: 0x00102CE8 File Offset: 0x00100EE8
	[Token(Token = "0x6003043")]
	[Address(RVA = "0x71E580", Offset = "0x71CB80", VA = "0x18071E580", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		BoardConfig config = board.config;
		board.timeUntilNextWave = 10f;
		config.waveInterval = 15f;
		board.config.zombieSpeedMultiplier = 1.5f;
	}

	// Token: 0x06003044 RID: 12356 RVA: 0x00102D28 File Offset: 0x00100F28
	[Token(Token = "0x6003044")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06003045 RID: 12357 RVA: 0x00102D38 File Offset: 0x00100F38
	[Token(Token = "0x6003045")]
	[Address(RVA = "0x71E410", Offset = "0x71CA10", VA = "0x18071E410", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06003046 RID: 12358 RVA: 0x00102D7C File Offset: 0x00100F7C
	[Token(Token = "0x6003046")]
	[Address(RVA = "0x715870", Offset = "0x713E70", VA = "0x180715870", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.Caltrop;
	}

	// Token: 0x06003047 RID: 12359 RVA: 0x00102D8C File Offset: 0x00100F8C
	[Token(Token = "0x6003047")]
	[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Pool;
	}

	// Token: 0x06003048 RID: 12360 RVA: 0x00102D9C File Offset: 0x00100F9C
	[Token(Token = "0x6003048")]
	[Address(RVA = "0x71E3D0", Offset = "0x71C9D0", VA = "0x18071E3D0", Slot = "31")]
	public override string GetLevelTip()
	{
		return "精英预警：闪电战";
	}

	// Token: 0x06003049 RID: 12361 RVA: 0x00102DB0 File Offset: 0x00100FB0
	[Token(Token = "0x6003049")]
	[Address(RVA = "0x71E3A0", Offset = "0x71C9A0", VA = "0x18071E3A0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：泳池激斗";
	}

	// Token: 0x0600304A RID: 12362 RVA: 0x00102DC4 File Offset: 0x00100FC4
	[Token(Token = "0x600304A")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public PoolSub5Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
