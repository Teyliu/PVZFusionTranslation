using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008E8 RID: 2280
[Token(Token = "0x20008E8")]
public class NightSub4Strategy : BaseLevelStrategy
{
	// Token: 0x06002E85 RID: 11909 RVA: 0x000FC968 File Offset: 0x000FAB68
	[Token(Token = "0x6002E85")]
	[Address(RVA = "0x69FFF0", Offset = "0x69E5F0", VA = "0x18069FFF0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Night_sub4;
	}

	// Token: 0x06002E86 RID: 11910 RVA: 0x000FC978 File Offset: 0x000FAB78
	[Token(Token = "0x6002E86")]
	[Address(RVA = "0x6A0350", Offset = "0x69E950", VA = "0x1806A0350", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.boardTag.disableSelectCard = true;
		board.boardTag.plantingZombie = true;
	}

	// Token: 0x06002E87 RID: 11911 RVA: 0x000FC9A4 File Offset: 0x000FABA4
	[Token(Token = "0x6002E87")]
	[Address(RVA = "0x698EE0", Offset = "0x6974E0", VA = "0x180698EE0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 30;
	}

	// Token: 0x06002E88 RID: 11912 RVA: 0x000FC9B4 File Offset: 0x000FABB4
	[Token(Token = "0x6002E88")]
	[Address(RVA = "0x6A0000", Offset = "0x69E600", VA = "0x1806A0000", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		return list;
	}

	// Token: 0x06002E89 RID: 11913 RVA: 0x000FCA04 File Offset: 0x000FAC04
	[Token(Token = "0x6002E89")]
	[Address(RVA = "0x3AC960", Offset = "0x3AAF60", VA = "0x1803AC960", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.ScaredyShroom;
	}

	// Token: 0x06002E8A RID: 11914 RVA: 0x000FCA14 File Offset: 0x000FAC14
	[Token(Token = "0x6002E8A")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Night;
	}

	// Token: 0x06002E8B RID: 11915 RVA: 0x000FCA24 File Offset: 0x000FAC24
	[Token(Token = "0x6002E8B")]
	[Address(RVA = "0x69FFC0", Offset = "0x69E5C0", VA = "0x18069FFC0", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：我是僵尸";
	}

	// Token: 0x06002E8C RID: 11916 RVA: 0x000FCA38 File Offset: 0x000FAC38
	[Token(Token = "0x6002E8C")]
	[Address(RVA = "0x6A01D0", Offset = "0x69E7D0", VA = "0x1806A01D0", Slot = "35")]
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

	// Token: 0x06002E8D RID: 11917 RVA: 0x000FCB20 File Offset: 0x000FAD20
	[Token(Token = "0x6002E8D")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public NightSub4Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
