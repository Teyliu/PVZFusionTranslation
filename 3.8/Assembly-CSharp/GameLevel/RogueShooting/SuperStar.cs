using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C90 RID: 3216
	[Token(Token = "0x2000C90")]
	public class SuperStar : BaseConfig
	{
		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06004362 RID: 17250 RVA: 0x0015AE9C File Offset: 0x0015909C
		[Token(Token = "0x170006B5")]
		public override string Role
		{
			[Token(Token = "0x6004362")]
			[Address(RVA = "0x83ADB0", Offset = "0x8393B0", VA = "0x18083ADB0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06004363 RID: 17251 RVA: 0x0015AEB0 File Offset: 0x001590B0
		[Token(Token = "0x170006B6")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004363")]
			[Address(RVA = "0x83ADA0", Offset = "0x8393A0", VA = "0x18083ADA0", Slot = "4")]
			get
			{
				return PlantType.SuperStar;
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06004364 RID: 17252 RVA: 0x0015AEC4 File Offset: 0x001590C4
		[Token(Token = "0x170006B7")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004364")]
			[Address(RVA = "0x83AC80", Offset = "0x839280", VA = "0x18083AC80", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1104L);
				upgradeBuff.targetType = (PlantType)((ulong)909L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004365 RID: 17253 RVA: 0x0015AF0C File Offset: 0x0015910C
		[Token(Token = "0x6004365")]
		[Address(RVA = "0x831E70", Offset = "0x830470", VA = "0x180831E70", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 4f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x06004366 RID: 17254 RVA: 0x0015AF40 File Offset: 0x00159140
		[Token(Token = "0x6004366")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public SuperStar()
		{
		}
	}
}
