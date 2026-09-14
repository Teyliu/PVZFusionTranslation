using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CCF RID: 3279
	[Token(Token = "0x2000CCF")]
	public class Peashooter : BaseConfig
	{
		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06004400 RID: 17408 RVA: 0x001622DC File Offset: 0x001604DC
		[Token(Token = "0x17000614")]
		public override string Role
		{
			[Token(Token = "0x6004400")]
			[Address(RVA = "0x890100", Offset = "0x88E700", VA = "0x180890100", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06004401 RID: 17409 RVA: 0x001622F0 File Offset: 0x001604F0
		[Token(Token = "0x17000615")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004401")]
			[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "4")]
			get
			{
				return PlantType.Peashooter;
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06004402 RID: 17410 RVA: 0x00162308 File Offset: 0x00160508
		[Token(Token = "0x17000616")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004402")]
			[Address(RVA = "0x88FDD0", Offset = "0x88E3D0", VA = "0x18088FDD0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int num = 0;
				UpgradeBuff upgradeBuff;
				upgradeBuff.targetType = (PlantType)((ulong)1382L);
				upgradeBuff.sourceType = (PlantType)num;
				int size = list._size;
				UpgradeBuff upgradeBuff2;
				upgradeBuff2.sourceType = (PlantType)num;
				upgradeBuff2.targetType = (PlantType)((ulong)1109L);
				int size2 = list._size;
				UpgradeBuff upgradeBuff3;
				upgradeBuff3.sourceType = (PlantType)num;
				upgradeBuff3.targetType = (PlantType)((ulong)1017L);
				int size3 = list._size;
				UpgradeBuff upgradeBuff4;
				upgradeBuff4.sourceType = (PlantType)num;
				upgradeBuff4.targetType = (PlantType)((ulong)1306L);
				int size4 = list._size;
				UpgradeBuff upgradeBuff5;
				upgradeBuff5.sourceType = (PlantType)num;
				upgradeBuff5.targetType = (PlantType)((ulong)1034L);
				int size5 = list._size;
				return list;
			}
		}

		// Token: 0x06004403 RID: 17411 RVA: 0x001623C4 File Offset: 0x001605C4
		[Token(Token = "0x6004403")]
		[Address(RVA = "0x88FD80", Offset = "0x88E380", VA = "0x18088FD80", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 9f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x06004404 RID: 17412 RVA: 0x001623F8 File Offset: 0x001605F8
		[Token(Token = "0x6004404")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public Peashooter()
		{
		}
	}
}
