using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;

// Token: 0x02000921 RID: 2337
[Token(Token = "0x2000921")]
public class NightSub1Strategy : BaseLevelStrategy
{
	// Token: 0x06002F9E RID: 12190 RVA: 0x00101128 File Offset: 0x000FF328
	[Token(Token = "0x6002F9E")]
	[Address(RVA = "0x7194F0", Offset = "0x717AF0", VA = "0x1807194F0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Night_sub1;
	}

	// Token: 0x06002F9F RID: 12191 RVA: 0x00101138 File Offset: 0x000FF338
	[Token(Token = "0x6002F9F")]
	[Address(RVA = "0x719820", Offset = "0x717E20", VA = "0x180719820", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.theSun = (int)((ulong)0L);
		board.boardTag.isHammerZombie = true;
		board.boardTag.disableInInterlude = true;
		BoardConfig config = board.config;
		board.timeUntilNextWave = 3f;
		config.zombieCountMultiplier = 1.5f;
		board.config.waveInterval = 30f;
	}

	// Token: 0x06002FA0 RID: 12192 RVA: 0x0010119C File Offset: 0x000FF39C
	[Token(Token = "0x6002FA0")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x06002FA1 RID: 12193 RVA: 0x001011AC File Offset: 0x000FF3AC
	[Token(Token = "0x6002FA1")]
	[Address(RVA = "0x719500", Offset = "0x717B00", VA = "0x180719500", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		int size6 = list._size;
		return list;
	}

	// Token: 0x06002FA2 RID: 12194 RVA: 0x0010120C File Offset: 0x000FF40C
	[Token(Token = "0x6002FA2")]
	[Address(RVA = "0x3F6B70", Offset = "0x3F5170", VA = "0x1803F6B70", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.HypnoShroom;
	}

	// Token: 0x06002FA3 RID: 12195 RVA: 0x0010121C File Offset: 0x000FF41C
	[Token(Token = "0x6002FA3")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Night;
	}

	// Token: 0x06002FA4 RID: 12196 RVA: 0x0010122C File Offset: 0x000FF42C
	[Token(Token = "0x6002FA4")]
	[Address(RVA = "0x7194C0", Offset = "0x717AC0", VA = "0x1807194C0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：锤僵尸";
	}

	// Token: 0x06002FA5 RID: 12197 RVA: 0x00101240 File Offset: 0x000FF440
	[Token(Token = "0x6002FA5")]
	[Address(RVA = "0x719770", Offset = "0x717D70", VA = "0x180719770", Slot = "35")]
	public override void InitCard(InitBoard board)
	{
		int num = 0;
		CardUI cardUI = board.CreateCard((PlantType)((uint)4), true, num != 0);
		int num2 = 0;
		CardUI cardUI2 = board.CreateCard((PlantType)((uint)1002), true, num2 != 0);
		int num3 = 0;
		CardUI cardUI3 = board.CreateCard((PlantType)((uint)239), true, num3 != 0);
		int num4 = 0;
		CardUI cardUI4 = board.CreateCard((PlantType)((uint)239), true, num4 != 0);
		int num5 = 0;
		CardUI cardUI5 = board.CreateCard((PlantType)((uint)10), true, num5 != 0);
	}

	// Token: 0x06002FA6 RID: 12198 RVA: 0x001012B0 File Offset: 0x000FF4B0
	[Token(Token = "0x6002FA6")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public NightSub1Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
