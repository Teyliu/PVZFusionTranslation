using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C7C RID: 3196
	[Token(Token = "0x2000C7C")]
	public class Caltrop : BaseConfig
	{
		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x060042FA RID: 17146 RVA: 0x00159DB4 File Offset: 0x00157FB4
		[Token(Token = "0x1700067E")]
		public override string Role
		{
			[Token(Token = "0x60042FA")]
			[Address(RVA = "0x82EE60", Offset = "0x82D460", VA = "0x18082EE60", Slot = "7")]
			get
			{
				return "输出/防御/辅助";
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x060042FB RID: 17147 RVA: 0x00159DC8 File Offset: 0x00157FC8
		[Token(Token = "0x1700067F")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60042FB")]
			[Address(RVA = "0x69B710", Offset = "0x699D10", VA = "0x18069B710", Slot = "4")]
			get
			{
				return PlantType.Caltrop;
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x060042FC RID: 17148 RVA: 0x00159DD8 File Offset: 0x00157FD8
		[Token(Token = "0x17000680")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60042FC")]
			[Address(RVA = "0x82ECC0", Offset = "0x82D2C0", VA = "0x18082ECC0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)17L);
				upgradeBuff.targetType = (PlantType)((ulong)1060L);
				int size = list._size;
				UpgradeBuff upgradeBuff2;
				upgradeBuff2.sourceType = (PlantType)((ulong)17L);
				upgradeBuff2.targetType = (PlantType)((ulong)1048L);
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060042FD RID: 17149 RVA: 0x00159E3C File Offset: 0x0015803C
		[Token(Token = "0x60042FD")]
		[Address(RVA = "0x82E720", Offset = "0x82CD20", VA = "0x18082E720", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 14f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x060042FE RID: 17150 RVA: 0x00159E70 File Offset: 0x00158070
		[Token(Token = "0x60042FE")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public Caltrop()
		{
		}
	}
}
