using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C12 RID: 3090
	[Token(Token = "0x2000C12")]
	public class Peashooter : BaseConfig
	{
		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06004082 RID: 16514 RVA: 0x001556BC File Offset: 0x001538BC
		[Token(Token = "0x170004E8")]
		public override string Role
		{
			[Token(Token = "0x6004082")]
			[Address(RVA = "0x835510", Offset = "0x833B10", VA = "0x180835510", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06004083 RID: 16515 RVA: 0x001556D0 File Offset: 0x001538D0
		[Token(Token = "0x170004E9")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004083")]
			[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "4")]
			get
			{
				return PlantType.Peashooter;
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06004084 RID: 16516 RVA: 0x001556E8 File Offset: 0x001538E8
		[Token(Token = "0x170004EA")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004084")]
			[Address(RVA = "0x8351E0", Offset = "0x8337E0", VA = "0x1808351E0", Slot = "5")]
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

		// Token: 0x06004085 RID: 16517 RVA: 0x001557A4 File Offset: 0x001539A4
		[Token(Token = "0x6004085")]
		[Address(RVA = "0x82E940", Offset = "0x82CF40", VA = "0x18082E940", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 9f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x06004086 RID: 16518 RVA: 0x001557D8 File Offset: 0x001539D8
		[Token(Token = "0x6004086")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public Peashooter()
		{
		}
	}
}
