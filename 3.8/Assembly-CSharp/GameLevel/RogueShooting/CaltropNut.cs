using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C84 RID: 3204
	[Token(Token = "0x2000C84")]
	public class CaltropNut : BaseConfig
	{
		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06004325 RID: 17189 RVA: 0x0015A554 File Offset: 0x00158754
		[Token(Token = "0x17000693")]
		public override string Role
		{
			[Token(Token = "0x6004325")]
			[Address(RVA = "0x82EC90", Offset = "0x82D290", VA = "0x18082EC90", Slot = "7")]
			get
			{
				return "输出/防御";
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06004326 RID: 17190 RVA: 0x0015A568 File Offset: 0x00158768
		[Token(Token = "0x17000694")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004326")]
			[Address(RVA = "0x82EC80", Offset = "0x82D280", VA = "0x18082EC80", Slot = "4")]
			get
			{
				return PlantType.CaltropNut;
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06004327 RID: 17191 RVA: 0x0015A57C File Offset: 0x0015877C
		[Token(Token = "0x17000695")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004327")]
			[Address(RVA = "0x82EB60", Offset = "0x82D160", VA = "0x18082EB60", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1048L);
				upgradeBuff.targetType = (PlantType)((ulong)931L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004328 RID: 17192 RVA: 0x0015A5C4 File Offset: 0x001587C4
		[Token(Token = "0x6004328")]
		[Address(RVA = "0x82EAE0", Offset = "0x82D0E0", VA = "0x18082EAE0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			plant.uncrashable = true;
			TravelData data = TravelMgr.Instance.data;
			PlantType thePlantType = plant.thePlantType;
			data.SetDamage(thePlantType, 4f);
		}

		// Token: 0x06004329 RID: 17193 RVA: 0x0015A600 File Offset: 0x00158800
		[Token(Token = "0x6004329")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public CaltropNut()
		{
		}
	}
}
