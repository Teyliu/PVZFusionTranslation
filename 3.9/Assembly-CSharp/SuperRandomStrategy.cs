using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000988 RID: 2440
[Token(Token = "0x2000988")]
public class SuperRandomStrategy : BaseLevelStrategy
{
	// Token: 0x06003255 RID: 12885 RVA: 0x00108600 File Offset: 0x00106800
	[Token(Token = "0x6003255")]
	[Address(RVA = "0x3F6BE0", Offset = "0x3F51E0", VA = "0x1803F6BE0", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.SuperRandom;
	}

	// Token: 0x06003256 RID: 12886 RVA: 0x00108614 File Offset: 0x00106814
	[Token(Token = "0x6003256")]
	[Address(RVA = "0x3F6A80", Offset = "0x3F5080", VA = "0x1803F6A80", Slot = "23")]
	public override int GetMaxWave()
	{
		return 100;
	}

	// Token: 0x06003257 RID: 12887 RVA: 0x00108624 File Offset: 0x00106824
	[Token(Token = "0x6003257")]
	[Address(RVA = "0x727B30", Offset = "0x726130", VA = "0x180727B30", Slot = "24")]
	public override List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		return list;
	}

	// Token: 0x06003258 RID: 12888 RVA: 0x00108668 File Offset: 0x00106868
	[Token(Token = "0x6003258")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SunFlower;
	}

	// Token: 0x06003259 RID: 12889 RVA: 0x00108678 File Offset: 0x00106878
	[Token(Token = "0x6003259")]
	[Address(RVA = "0x3F1E50", Offset = "0x3F0450", VA = "0x1803F1E50", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Day_6;
	}

	// Token: 0x0600325A RID: 12890 RVA: 0x00108688 File Offset: 0x00106888
	[Token(Token = "0x600325A")]
	[Address(RVA = "0x727B00", Offset = "0x726100", VA = "0x180727B00", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉挑战：超级随机";
	}

	// Token: 0x0600325B RID: 12891 RVA: 0x0010869C File Offset: 0x0010689C
	[Token(Token = "0x600325B")]
	[Address(RVA = "0x727EC0", Offset = "0x7264C0", VA = "0x180727EC0", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.boardTag.isSuperRandom = true;
		board.boardTag.enableAllTravelPlant = true;
		board.boardTag.disableSelectCard = true;
		board.theSun = (int)((ulong)1500L);
		TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)1000));
	}

	// Token: 0x0600325C RID: 12892 RVA: 0x001086F4 File Offset: 0x001068F4
	[Token(Token = "0x600325C")]
	[Address(RVA = "0x727CA0", Offset = "0x7262A0", VA = "0x180727CA0", Slot = "35")]
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

	// Token: 0x0600325D RID: 12893 RVA: 0x001088A8 File Offset: 0x00106AA8
	[Token(Token = "0x600325D")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public SuperRandomStrategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
