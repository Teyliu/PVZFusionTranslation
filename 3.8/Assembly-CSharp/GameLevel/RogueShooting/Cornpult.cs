using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CAC RID: 3244
	[Token(Token = "0x2000CAC")]
	public class Cornpult : BaseConfig
	{
		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06004403 RID: 17411 RVA: 0x0015C130 File Offset: 0x0015A330
		[Token(Token = "0x1700071C")]
		public override string Role
		{
			[Token(Token = "0x6004403")]
			[Address(RVA = "0x82FEC0", Offset = "0x82E4C0", VA = "0x18082FEC0", Slot = "7")]
			get
			{
				return "辅助";
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06004404 RID: 17412 RVA: 0x0015C144 File Offset: 0x0015A344
		[Token(Token = "0x1700071D")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004404")]
			[Address(RVA = "0x6A1A60", Offset = "0x6A0060", VA = "0x1806A1A60", Slot = "4")]
			get
			{
				return PlantType.Cornpult;
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06004405 RID: 17413 RVA: 0x0015C154 File Offset: 0x0015A354
		[Token(Token = "0x1700071E")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004405")]
			[Address(RVA = "0x82FDA0", Offset = "0x82E3A0", VA = "0x18082FDA0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)28L);
				upgradeBuff.targetType = (PlantType)((ulong)1210L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004406 RID: 17414 RVA: 0x0015C198 File Offset: 0x0015A398
		[Token(Token = "0x6004406")]
		[Address(RVA = "0x82FD50", Offset = "0x82E350", VA = "0x18082FD50", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 19f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x06004407 RID: 17415 RVA: 0x0015C1CC File Offset: 0x0015A3CC
		[Token(Token = "0x6004407")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public Cornpult()
		{
		}
	}
}
