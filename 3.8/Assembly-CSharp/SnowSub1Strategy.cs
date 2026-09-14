using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;

// Token: 0x02000934 RID: 2356
[Token(Token = "0x2000934")]
public class SnowSub1Strategy : BaseLevelStrategy
{
	// Token: 0x06003077 RID: 12407 RVA: 0x0010195C File Offset: 0x000FFB5C
	[Token(Token = "0x6003077")]
	[Address(RVA = "0x4A0170", Offset = "0x49E770", VA = "0x1804A0170", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Snow_sub1;
	}

	// Token: 0x06003078 RID: 12408 RVA: 0x0010196C File Offset: 0x000FFB6C
	[Token(Token = "0x6003078")]
	[Address(RVA = "0x6ABFC0", Offset = "0x6AA5C0", VA = "0x1806ABFC0", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.boardTag.disableSelectCard = true;
		board.cardBank = false;
		TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)1000));
	}

	// Token: 0x06003079 RID: 12409 RVA: 0x001019A4 File Offset: 0x000FFBA4
	[Token(Token = "0x6003079")]
	[Address(RVA = "0x6ABD70", Offset = "0x6AA370", VA = "0x1806ABD70", Slot = "34")]
	public override void OnBoardStart(Board board)
	{
		board.timeUntilNextWave = 3f;
		CreatePlant instance = CreatePlant.Instance;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		Plant plant;
		plant.ModifyHealth((PlantHealthAdder)num3, 5f, num2 != 0);
		int num4 = 0;
		int num5 = 0;
		plant.ModifyDamage((PlantDamageAdder)num5, 5f, num4 != 0, num);
		if (SnowSub1Strategy.<>c.<>9__2_0 == 0)
		{
			Action<object> action;
			SnowSub1Strategy.<>c.<>9__2_0 = action;
		}
		InGameText instance2 = InGameText.Instance;
		int num6 = 0;
		instance2.ShowText("云杉弓手每次攻击，攻击力+10，攻速+1%", 5f, num6 != 0);
	}

	// Token: 0x0600307A RID: 12410 RVA: 0x00101A2C File Offset: 0x000FFC2C
	[Token(Token = "0x600307A")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x0600307B RID: 12411 RVA: 0x00101A3C File Offset: 0x000FFC3C
	[Token(Token = "0x600307B")]
	[Address(RVA = "0x6ABB50", Offset = "0x6AA150", VA = "0x1806ABB50", Slot = "24")]
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

	// Token: 0x0600307C RID: 12412 RVA: 0x00101A90 File Offset: 0x000FFC90
	[Token(Token = "0x600307C")]
	[Address(RVA = "0x6A44C0", Offset = "0x6A2AC0", VA = "0x1806A44C0", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SpruceShooter;
	}

	// Token: 0x0600307D RID: 12413 RVA: 0x00101AA0 File Offset: 0x000FFCA0
	[Token(Token = "0x600307D")]
	[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Snow_6;
	}

	// Token: 0x0600307E RID: 12414 RVA: 0x00101AB0 File Offset: 0x000FFCB0
	[Token(Token = "0x600307E")]
	[Address(RVA = "0x6ABB20", Offset = "0x6AA120", VA = "0x1806ABB20", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：英雄登场";
	}

	// Token: 0x0600307F RID: 12415 RVA: 0x00101AC4 File Offset: 0x000FFCC4
	[Token(Token = "0x600307F")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public SnowSub1Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
