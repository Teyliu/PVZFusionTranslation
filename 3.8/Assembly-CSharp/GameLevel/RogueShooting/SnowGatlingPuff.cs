using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C42 RID: 3138
	[Token(Token = "0x2000C42")]
	public class SnowGatlingPuff : BaseConfig
	{
		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x060041A6 RID: 16806 RVA: 0x001577B8 File Offset: 0x001559B8
		[Token(Token = "0x170005A5")]
		public override string Role
		{
			[Token(Token = "0x60041A6")]
			[Address(RVA = "0x838DB0", Offset = "0x8373B0", VA = "0x180838DB0", Slot = "7")]
			get
			{
				return "辅助";
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x060041A7 RID: 16807 RVA: 0x001577CC File Offset: 0x001559CC
		[Token(Token = "0x170005A6")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60041A7")]
			[Address(RVA = "0x838880", Offset = "0x836E80", VA = "0x180838880", Slot = "4")]
			get
			{
				return PlantType.SnowGatlingPuff;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x060041A8 RID: 16808 RVA: 0x001577E0 File Offset: 0x001559E0
		[Token(Token = "0x170005A7")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60041A8")]
			[Address(RVA = "0x838CA0", Offset = "0x8372A0", VA = "0x180838CA0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				SnowGatlingPuff.SlowBuff slowBuff = new SnowGatlingPuff.SlowBuff();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060041A9 RID: 16809 RVA: 0x00157814 File Offset: 0x00155A14
		[Token(Token = "0x60041A9")]
		[Address(RVA = "0x838C20", Offset = "0x837220", VA = "0x180838C20", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			plant.AddSpeed(1f);
			TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)10));
		}

		// Token: 0x060041AA RID: 16810 RVA: 0x00157844 File Offset: 0x00155A44
		[Token(Token = "0x60041AA")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public SnowGatlingPuff()
		{
		}

		// Token: 0x02000C43 RID: 3139
		[Token(Token = "0x2000C43")]
		private class SlowBuff : BaseBuff
		{
			// Token: 0x170005A8 RID: 1448
			// (get) Token: 0x060041AB RID: 16811 RVA: 0x00157858 File Offset: 0x00155A58
			[Token(Token = "0x170005A8")]
			public override bool Passive
			{
				[Token(Token = "0x60041AB")]
				[Address(RVA = "0x3A5ED0", Offset = "0x3A44D0", VA = "0x1803A5ED0", Slot = "10")]
				get
				{
					return true;
				}
			}

			// Token: 0x170005A9 RID: 1449
			// (get) Token: 0x060041AC RID: 16812 RVA: 0x00157868 File Offset: 0x00155A68
			[Token(Token = "0x170005A9")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60041AC")]
				[Address(RVA = "0x838880", Offset = "0x836E80", VA = "0x180838880", Slot = "4")]
				get
				{
					return PlantType.SnowGatlingPuff;
				}
			}

			// Token: 0x170005AA RID: 1450
			// (get) Token: 0x060041AD RID: 16813 RVA: 0x0015787C File Offset: 0x00155A7C
			[Token(Token = "0x170005AA")]
			public override string Title
			{
				[Token(Token = "0x60041AD")]
				[Address(RVA = "0x838890", Offset = "0x836E90", VA = "0x180838890", Slot = "5")]
				get
				{
					return "强化：减速";
				}
			}

			// Token: 0x170005AB RID: 1451
			// (get) Token: 0x060041AE RID: 16814 RVA: 0x00157890 File Offset: 0x00155A90
			[Token(Token = "0x170005AB")]
			public override string Description
			{
				[Token(Token = "0x60041AE")]
				[Address(RVA = "0x838850", Offset = "0x836E50", VA = "0x180838850", Slot = "6")]
				get
				{
					return "僵尸的基础速度降低10%";
				}
			}

			// Token: 0x060041AF RID: 16815 RVA: 0x001578A4 File Offset: 0x00155AA4
			[Token(Token = "0x60041AF")]
			[Address(RVA = "0x8387F0", Offset = "0x836DF0", VA = "0x1808387F0", Slot = "7")]
			public override void OnGet()
			{
				BoardConfig config = Board.Instance.config;
				float num = config.zombieSpeedMultiplier * 0.9f;
				config.zombieSpeedMultiplier = num;
			}

			// Token: 0x170005AC RID: 1452
			// (get) Token: 0x060041B0 RID: 16816 RVA: 0x001578D8 File Offset: 0x00155AD8
			[Token(Token = "0x170005AC")]
			public override Quality Rarity
			{
				[Token(Token = "0x60041B0")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x060041B1 RID: 16817 RVA: 0x001578E8 File Offset: 0x00155AE8
			[Token(Token = "0x60041B1")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public SlowBuff()
			{
			}
		}
	}
}
