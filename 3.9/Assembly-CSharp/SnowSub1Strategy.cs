using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;

// Token: 0x02000970 RID: 2416
[Token(Token = "0x2000970")]
public class SnowSub1Strategy : BaseLevelStrategy
{
	// Token: 0x060031AA RID: 12714 RVA: 0x001066E4 File Offset: 0x001048E4
	[Token(Token = "0x60031AA")]
	[Address(RVA = "0x51FE20", Offset = "0x51E420", VA = "0x18051FE20", Slot = "20")]
	public override AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Snow_sub1;
	}

	// Token: 0x060031AB RID: 12715 RVA: 0x001066F4 File Offset: 0x001048F4
	[Token(Token = "0x60031AB")]
	[Address(RVA = "0x726140", Offset = "0x724740", VA = "0x180726140", Slot = "21")]
	public override void SetupBoard(Board board)
	{
		board.boardTag.disableSelectCard = true;
		board.cardBank = false;
		TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)1000));
	}

	// Token: 0x060031AC RID: 12716 RVA: 0x0010672C File Offset: 0x0010492C
	[Token(Token = "0x60031AC")]
	[Address(RVA = "0x725EE0", Offset = "0x7244E0", VA = "0x180725EE0", Slot = "34")]
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
	}

	// Token: 0x060031AD RID: 12717 RVA: 0x0010679C File Offset: 0x0010499C
	[Token(Token = "0x60031AD")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "23")]
	public override int GetMaxWave()
	{
		return 20;
	}

	// Token: 0x060031AE RID: 12718 RVA: 0x001067AC File Offset: 0x001049AC
	[Token(Token = "0x60031AE")]
	[Address(RVA = "0x725CC0", Offset = "0x7242C0", VA = "0x180725CC0", Slot = "24")]
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

	// Token: 0x060031AF RID: 12719 RVA: 0x00106800 File Offset: 0x00104A00
	[Token(Token = "0x60031AF")]
	[Address(RVA = "0x71E620", Offset = "0x71CC20", VA = "0x18071E620", Slot = "25")]
	public override PlantType GetBasePlant()
	{
		return PlantType.SpruceShooter;
	}

	// Token: 0x060031B0 RID: 12720 RVA: 0x00106810 File Offset: 0x00104A10
	[Token(Token = "0x60031B0")]
	[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "29")]
	public override SceneType GetSceneType()
	{
		return SceneType.Snow_6;
	}

	// Token: 0x060031B1 RID: 12721 RVA: 0x00106820 File Offset: 0x00104A20
	[Token(Token = "0x60031B1")]
	[Address(RVA = "0x725C90", Offset = "0x724290", VA = "0x180725C90", Slot = "30")]
	public override string GetLevelName()
	{
		return "星辉支线：英雄登场";
	}

	// Token: 0x060031B2 RID: 12722 RVA: 0x00106834 File Offset: 0x00104A34
	[Token(Token = "0x60031B2")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public SnowSub1Strategy()
	{
		int num = 0;
		base.SetupBoard(num);
	}
}
