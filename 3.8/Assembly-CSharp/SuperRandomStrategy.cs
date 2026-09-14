using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200094C RID: 2380
[Token(Token = "0x200094C")]
public class SuperRandomStrategy : BaseLevelStrategy
{
	// Token: 0x06003122 RID: 12578 RVA: 0x0010388C File Offset: 0x00101A8C
	[Token(Token = "0x6003122")]
	[Address(RVA = "0x3AADE0", Offset = "0x3A93E0", VA = "0x1803AADE0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.SuperRandom;
	}

	// Token: 0x06003123 RID: 12579 RVA: 0x001038A0 File Offset: 0x00101AA0
	[Token(Token = "0x6003123")]
	[Address(RVA = "0x3AAC80", Offset = "0x3A9280", VA = "0x1803AAC80", Slot = "23")]
	public override int GetMaxWave()
	{
		return 100;
	}

	// Token: 0x06003124 RID: 12580 RVA: 0x001038B0 File Offset: 0x00101AB0
	[Token(Token = "0x6003124")]
	[Address(RVA = "0x6AD9B0", Offset = "0x6ABFB0", VA = "0x1806AD9B0", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06003125 RID: 12581 RVA: 0x001038F4 File Offset: 0x00101AF4
	[Token(Token = "0x6003125")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SunFlower;
	}

	// Token: 0x06003126 RID: 12582 RVA: 0x00103904 File Offset: 0x00101B04
	[Token(Token = "0x6003126")]
	[Address(RVA = "0x3A5EC0", Offset = "0x3A44C0", VA = "0x1803A5EC0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day_6;
	}

	// Token: 0x06003127 RID: 12583 RVA: 0x00103914 File Offset: 0x00101B14
	[Token(Token = "0x6003127")]
	[Address(RVA = "0x6AD980", Offset = "0x6ABF80", VA = "0x1806AD980", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉挑战：超级随机";
	}

	// Token: 0x06003128 RID: 12584 RVA: 0x00103928 File Offset: 0x00101B28
	[Token(Token = "0x6003128")]
	[Address(RVA = "0x6ADD40", Offset = "0x6AC340", VA = "0x1806ADD40", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.boardTag.isSuperRandom = true;
		board.boardTag.enableAllTravelPlant = true;
		board.boardTag.disableSelectCard = true;
		board.theSun = (int)((ulong)1500L);
		TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)1000));
	}

	// Token: 0x06003129 RID: 12585 RVA: 0x00103980 File Offset: 0x00101B80
	[Token(Token = "0x6003129")]
	[Address(RVA = "0x6ADB20", Offset = "0x6AC120", VA = "0x1806ADB20", Slot = "35")]
	public override void InitCard(InitBoard board)
	{
		int num = 0;
		CardUI cardUI = board.CreateCard((PlantType)((uint)227), true, num != 0);
		int num2 = 0;
		cardUI.fullCD = 7.5f;
		CardUI cardUI2 = board.CreateCard((PlantType)((uint)227), true, num2 != 0);
		int num3 = 0;
		cardUI2.fullCD = 7.5f;
		CardUI cardUI3 = board.CreateCard((PlantType)((uint)227), true, num3 != 0);
		int num4 = 0;
		cardUI3.fullCD = 7.5f;
		CardUI cardUI4 = board.CreateCard((PlantType)((uint)256), true, num4 != 0);
		int num5 = 0;
		cardUI4.theSeedCost = (int)((ulong)200L);
		CardUI cardUI5 = board.CreateCard((PlantType)((uint)256), true, num5 != 0);
		int num6 = 0;
		cardUI5.theSeedCost = (int)((ulong)200L);
		CardUI cardUI6 = board.CreateCard((PlantType)((uint)256), true, num6 != 0);
		int num7 = 0;
		cardUI6.theSeedCost = (int)((ulong)200L);
		CardUI cardUI7 = board.CreateCard((PlantType)((uint)256), true, num7 != 0);
		int num8 = 0;
		cardUI7.theSeedCost = (int)((ulong)200L);
		CardUI cardUI8 = board.CreateCard((PlantType)((uint)256), true, num8 != 0);
		int num9 = 0;
		cardUI8.theSeedCost = (int)((ulong)200L);
		CardUI cardUI9 = board.CreateCard((PlantType)((uint)253), true, num9 != 0);
		int num10 = 0;
		cardUI9.fullCD = 7.5f;
		CardUI cardUI10 = board.CreateCard((PlantType)((uint)253), true, num10 != 0);
		int num11 = 0;
		cardUI10.fullCD = 7.5f;
		CardUI cardUI11 = board.CreateCard((PlantType)((uint)250), true, num11 != 0);
		int num12 = 0;
		cardUI11.fullCD = 30f;
		board.CreateCard((PlantType)((uint)250), true, num12 != 0).fullCD = 30f;
		CardUI cardUI12 = board.PreSelect((PlantType)((uint)245));
		CardUI cardUI13 = board.PreSelect((PlantType)((uint)229));
	}

	// Token: 0x0600312A RID: 12586 RVA: 0x00103B34 File Offset: 0x00101D34
	[Token(Token = "0x600312A")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public SuperRandomStrategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
