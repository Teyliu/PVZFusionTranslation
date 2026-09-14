using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C70 RID: 3184
	[Token(Token = "0x2000C70")]
	public class NuclearSquash : BaseConfig
	{
		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x060042AC RID: 17068 RVA: 0x001594CC File Offset: 0x001576CC
		[Token(Token = "0x1700064A")]
		public override string Role
		{
			[Token(Token = "0x60042AC")]
			[Address(RVA = "0x834290", Offset = "0x832890", VA = "0x180834290", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x060042AD RID: 17069 RVA: 0x001594E0 File Offset: 0x001576E0
		[Token(Token = "0x1700064B")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60042AD")]
			[Address(RVA = "0x830BC0", Offset = "0x82F1C0", VA = "0x180830BC0", Slot = "4")]
			get
			{
				return PlantType.NuclearSquash;
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x060042AE RID: 17070 RVA: 0x001594F4 File Offset: 0x001576F4
		[Token(Token = "0x1700064C")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60042AE")]
			[Address(RVA = "0x8340F0", Offset = "0x8326F0", VA = "0x1808340F0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				NuclearSquash.DuringBuff duringBuff = new NuclearSquash.DuringBuff();
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060042AF RID: 17071 RVA: 0x00159534 File Offset: 0x00157734
		[Token(Token = "0x60042AF")]
		[Address(RVA = "0x8340A0", Offset = "0x8326A0", VA = "0x1808340A0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), -0.5f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x060042B0 RID: 17072 RVA: 0x00159568 File Offset: 0x00157768
		[Token(Token = "0x60042B0")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public NuclearSquash()
		{
		}

		// Token: 0x02000C71 RID: 3185
		[Token(Token = "0x2000C71")]
		private class DuringBuff : BaseBuff
		{
			// Token: 0x1700064D RID: 1613
			// (get) Token: 0x060042B1 RID: 17073 RVA: 0x0015957C File Offset: 0x0015777C
			[Token(Token = "0x1700064D")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60042B1")]
				[Address(RVA = "0x830BC0", Offset = "0x82F1C0", VA = "0x180830BC0", Slot = "4")]
				get
				{
					return PlantType.NuclearSquash;
				}
			}

			// Token: 0x1700064E RID: 1614
			// (get) Token: 0x060042B2 RID: 17074 RVA: 0x00159590 File Offset: 0x00157790
			[Token(Token = "0x1700064E")]
			public override string Title
			{
				[Token(Token = "0x60042B2")]
				[Address(RVA = "0x830BD0", Offset = "0x82F1D0", VA = "0x180830BD0", Slot = "5")]
				get
				{
					return "强化：王从天降";
				}
			}

			// Token: 0x1700064F RID: 1615
			// (get) Token: 0x060042B3 RID: 17075 RVA: 0x001595A4 File Offset: 0x001577A4
			[Token(Token = "0x1700064F")]
			public override string Description
			{
				[Token(Token = "0x60042B3")]
				[Address(RVA = "0x830B90", Offset = "0x82F190", VA = "0x180830B90", Slot = "6")]
				get
				{
					return "辐射持续时间+1秒";
				}
			}

			// Token: 0x17000650 RID: 1616
			// (get) Token: 0x060042B4 RID: 17076 RVA: 0x001595B8 File Offset: 0x001577B8
			[Token(Token = "0x17000650")]
			public override Quality Rarity
			{
				[Token(Token = "0x60042B4")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x17000651 RID: 1617
			// (get) Token: 0x060042B5 RID: 17077 RVA: 0x001595C8 File Offset: 0x001577C8
			[Token(Token = "0x17000651")]
			public override float AppearWeight
			{
				[Token(Token = "0x60042B5")]
				[Address(RVA = "0x830000", Offset = "0x82E600", VA = "0x180830000", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060042B6 RID: 17078 RVA: 0x001595DC File Offset: 0x001577DC
			[Token(Token = "0x60042B6")]
			[Address(RVA = "0x830B00", Offset = "0x82F100", VA = "0x180830B00", Slot = "7")]
			public override void OnGet()
			{
				Plant plant = base.Plant;
				int num = 0;
				if (plant != num)
				{
					Plant plant2 = base.Plant;
				}
			}

			// Token: 0x060042B7 RID: 17079 RVA: 0x0015960C File Offset: 0x0015780C
			[Token(Token = "0x60042B7")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public DuringBuff()
			{
			}
		}
	}
}
