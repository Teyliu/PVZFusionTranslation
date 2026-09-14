using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C32 RID: 3122
	[Token(Token = "0x2000C32")]
	public class PotatoMine : BaseConfig
	{
		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06004148 RID: 16712 RVA: 0x00156C94 File Offset: 0x00154E94
		[Token(Token = "0x17000567")]
		public override string Role
		{
			[Token(Token = "0x6004148")]
			[Address(RVA = "0x835AB0", Offset = "0x8340B0", VA = "0x180835AB0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06004149 RID: 16713 RVA: 0x00156CA8 File Offset: 0x00154EA8
		[Token(Token = "0x17000568")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004149")]
			[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "4")]
			get
			{
				return PlantType.PotatoMine;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x0600414A RID: 16714 RVA: 0x00156CB8 File Offset: 0x00154EB8
		[Token(Token = "0x17000569")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600414A")]
			[Address(RVA = "0x835990", Offset = "0x833F90", VA = "0x180835990", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)4L);
				upgradeBuff.targetType = (PlantType)((ulong)1007L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x0600414B RID: 16715 RVA: 0x00156CFC File Offset: 0x00154EFC
		[Token(Token = "0x600414B")]
		[Address(RVA = "0x835930", Offset = "0x833F30", VA = "0x180835930", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			plant.AddSpeed(5f);
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 1f, num2 != 0, num);
		}

		// Token: 0x0600414C RID: 16716 RVA: 0x00156D30 File Offset: 0x00154F30
		[Token(Token = "0x600414C")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public PotatoMine()
		{
		}
	}
}
