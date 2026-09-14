using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000924 RID: 2340
[Token(Token = "0x2000924")]
public class NightSub4Strategy : BaseLevelStrategy
{
	// Token: 0x06002FB8 RID: 12216 RVA: 0x0010152C File Offset: 0x000FF72C
	[Token(Token = "0x6002FB8")]
	[Address(RVA = "0x71A150", Offset = "0x718750", VA = "0x18071A150", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Night_sub4;
	}

	// Token: 0x06002FB9 RID: 12217 RVA: 0x0010153C File Offset: 0x000FF73C
	[Token(Token = "0x6002FB9")]
	[Address(RVA = "0x71A4B0", Offset = "0x718AB0", VA = "0x18071A4B0", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.boardTag.disableSelectCard = true;
		board.boardTag.plantingZombie = true;
	}

	// Token: 0x06002FBA RID: 12218 RVA: 0x00101568 File Offset: 0x000FF768
	[Token(Token = "0x6002FBA")]
	[Address(RVA = "0x712FE0", Offset = "0x7115E0", VA = "0x180712FE0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 30;
	}

	// Token: 0x06002FBB RID: 12219 RVA: 0x00101578 File Offset: 0x000FF778
	[Token(Token = "0x6002FBB")]
	[Address(RVA = "0x71A160", Offset = "0x718760", VA = "0x18071A160", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x06002FBC RID: 12220 RVA: 0x001015C8 File Offset: 0x000FF7C8
	[Token(Token = "0x6002FBC")]
	[Address(RVA = "0x3F87C0", Offset = "0x3F6DC0", VA = "0x1803F87C0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.ScaredyShroom;
	}

	// Token: 0x06002FBD RID: 12221 RVA: 0x001015D8 File Offset: 0x000FF7D8
	[Token(Token = "0x6002FBD")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Night;
	}

	// Token: 0x06002FBE RID: 12222 RVA: 0x001015E8 File Offset: 0x000FF7E8
	[Token(Token = "0x6002FBE")]
	[Address(RVA = "0x71A120", Offset = "0x718720", VA = "0x18071A120", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：我是僵尸";
	}

	// Token: 0x06002FBF RID: 12223 RVA: 0x001015FC File Offset: 0x000FF7FC
	[Token(Token = "0x6002FBF")]
	[Address(RVA = "0x71A330", Offset = "0x718930", VA = "0x18071A330", Slot = "35")]
	public override void InitCard(InitBoard board)
	{
		int num = 0;
		board.CreateCard((ZombieType)num, true).theSeedCost = (int)((ulong)25L);
		board.CreateCard((ZombieType)((uint)2), true).theSeedCost = (int)((ulong)50L);
		board.CreateCard((ZombieType)((uint)4), true).theSeedCost = (int)((ulong)100L);
		board.CreateCard((ZombieType)((uint)9), true).theSeedCost = (int)((ulong)125L);
		board.CreateCard((ZombieType)((uint)15), true).theSeedCost = (int)((ulong)300L);
		board.CreateCard((ZombieType)((uint)16), true).theSeedCost = (int)((ulong)400L);
		IZECard izecard = board.CreateCard((ZombieType)((uint)35), true);
		int num2 = 0;
		izecard.theSeedCost = (int)((ulong)500L);
		CardUI cardUI = board.CreateCard((PlantType)((uint)1), true, num2 != 0);
		int num3 = 0;
		CardUI cardUI2 = board.CreateCard((PlantType)((uint)10), true, num3 != 0);
		int num4 = 0;
		CardUI cardUI3 = board.CreateCard((PlantType)((uint)8), true, num4 != 0);
		int num5 = 0;
		CardUI cardUI4 = board.CreateCard((PlantType)((uint)239), true, num5 != 0);
	}

	// Token: 0x06002FC0 RID: 12224 RVA: 0x001016E4 File Offset: 0x000FF8E4
	[Token(Token = "0x6002FC0")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public NightSub4Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
