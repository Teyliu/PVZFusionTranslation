using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C8B RID: 3211
	[Token(Token = "0x2000C8B")]
	public class Cactus : BaseConfig
	{
		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06004347 RID: 17223 RVA: 0x0015AB0C File Offset: 0x00158D0C
		[Token(Token = "0x170006A4")]
		public override string Role
		{
			[Token(Token = "0x6004347")]
			[Address(RVA = "0x82EAB0", Offset = "0x82D0B0", VA = "0x18082EAB0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06004348 RID: 17224 RVA: 0x0015AB20 File Offset: 0x00158D20
		[Token(Token = "0x170006A5")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004348")]
			[Address(RVA = "0x69C990", Offset = "0x69AF90", VA = "0x18069C990", Slot = "4")]
			get
			{
				return PlantType.Cactus;
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06004349 RID: 17225 RVA: 0x0015AB30 File Offset: 0x00158D30
		[Token(Token = "0x170006A6")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004349")]
			[Address(RVA = "0x82E990", Offset = "0x82CF90", VA = "0x18082E990", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)21L);
				upgradeBuff.targetType = (PlantType)((ulong)1191L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x0600434A RID: 17226 RVA: 0x0015AB74 File Offset: 0x00158D74
		[Token(Token = "0x600434A")]
		[Address(RVA = "0x82E940", Offset = "0x82CF40", VA = "0x18082E940", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 9f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x0600434B RID: 17227 RVA: 0x0015ABA8 File Offset: 0x00158DA8
		[Token(Token = "0x600434B")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public Cactus()
		{
		}
	}
}
