using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D16 RID: 3350
	[Token(Token = "0x2000D16")]
	public class SnowGatlingPuff : BaseConfig
	{
		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06004596 RID: 17814 RVA: 0x00164E40 File Offset: 0x00163040
		[Token(Token = "0x1700070E")]
		public override string Role
		{
			[Token(Token = "0x6004596")]
			[Address(RVA = "0x8B5610", Offset = "0x8B3C10", VA = "0x1808B5610", Slot = "7")]
			get
			{
				return "辅助";
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06004597 RID: 17815 RVA: 0x00164E54 File Offset: 0x00163054
		[Token(Token = "0x1700070F")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004597")]
			[Address(RVA = "0x8B5060", Offset = "0x8B3660", VA = "0x1808B5060", Slot = "4")]
			get
			{
				return PlantType.SnowGatlingPuff;
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06004598 RID: 17816 RVA: 0x00164E68 File Offset: 0x00163068
		[Token(Token = "0x17000710")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004598")]
			[Address(RVA = "0x8B5500", Offset = "0x8B3B00", VA = "0x1808B5500", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				SnowGatlingPuff.SlowBuff slowBuff = new SnowGatlingPuff.SlowBuff();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004599 RID: 17817 RVA: 0x00164E9C File Offset: 0x0016309C
		[Token(Token = "0x6004599")]
		[Address(RVA = "0x8B5480", Offset = "0x8B3A80", VA = "0x1808B5480", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			plant.AddSpeed(1f);
			TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)10));
		}

		// Token: 0x0600459A RID: 17818 RVA: 0x00164ECC File Offset: 0x001630CC
		[Token(Token = "0x600459A")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public SnowGatlingPuff()
		{
		}

		// Token: 0x02000D17 RID: 3351
		[Token(Token = "0x2000D17")]
		private class SlowBuff : BaseBuff
		{
			// Token: 0x17000711 RID: 1809
			// (get) Token: 0x0600459B RID: 17819 RVA: 0x00164EE0 File Offset: 0x001630E0
			[Token(Token = "0x17000711")]
			public override bool Passive
			{
				[Token(Token = "0x600459B")]
				[Address(RVA = "0x3F1E60", Offset = "0x3F0460", VA = "0x1803F1E60", Slot = "10")]
				get
				{
					return true;
				}
			}

			// Token: 0x17000712 RID: 1810
			// (get) Token: 0x0600459C RID: 17820 RVA: 0x00164EF0 File Offset: 0x001630F0
			[Token(Token = "0x17000712")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600459C")]
				[Address(RVA = "0x8B5060", Offset = "0x8B3660", VA = "0x1808B5060", Slot = "4")]
				get
				{
					return PlantType.SnowGatlingPuff;
				}
			}

			// Token: 0x17000713 RID: 1811
			// (get) Token: 0x0600459D RID: 17821 RVA: 0x00164F04 File Offset: 0x00163104
			[Token(Token = "0x17000713")]
			public override string Title
			{
				[Token(Token = "0x600459D")]
				[Address(RVA = "0x8B5070", Offset = "0x8B3670", VA = "0x1808B5070", Slot = "5")]
				get
				{
					return "强化：减速";
				}
			}

			// Token: 0x17000714 RID: 1812
			// (get) Token: 0x0600459E RID: 17822 RVA: 0x00164F18 File Offset: 0x00163118
			[Token(Token = "0x17000714")]
			public override string Description
			{
				[Token(Token = "0x600459E")]
				[Address(RVA = "0x8B5030", Offset = "0x8B3630", VA = "0x1808B5030", Slot = "6")]
				get
				{
					return "僵尸的基础速度降低10%";
				}
			}

			// Token: 0x0600459F RID: 17823 RVA: 0x00164F2C File Offset: 0x0016312C
			[Token(Token = "0x600459F")]
			[Address(RVA = "0x8B4FD0", Offset = "0x8B35D0", VA = "0x1808B4FD0", Slot = "7")]
			public override void OnGet()
			{
				BoardConfig config = Board.Instance.config;
				float num = config.zombieSpeedMultiplier * 0.9f;
				config.zombieSpeedMultiplier = num;
			}

			// Token: 0x17000715 RID: 1813
			// (get) Token: 0x060045A0 RID: 17824 RVA: 0x00164F60 File Offset: 0x00163160
			[Token(Token = "0x17000715")]
			public override Quality Rarity
			{
				[Token(Token = "0x60045A0")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x060045A1 RID: 17825 RVA: 0x00164F70 File Offset: 0x00163170
			[Token(Token = "0x60045A1")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public SlowBuff()
			{
			}
		}
	}
}
