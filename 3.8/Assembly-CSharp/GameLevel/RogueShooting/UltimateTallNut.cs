using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C2F RID: 3119
	[Token(Token = "0x2000C2F")]
	public class UltimateTallNut : BaseConfig
	{
		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06004135 RID: 16693 RVA: 0x00156ABC File Offset: 0x00154CBC
		[Token(Token = "0x1700055A")]
		public override string Role
		{
			[Token(Token = "0x6004135")]
			[Address(RVA = "0x8446C0", Offset = "0x842CC0", VA = "0x1808446C0", Slot = "7")]
			get
			{
				return "防御";
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06004136 RID: 16694 RVA: 0x00156AD0 File Offset: 0x00154CD0
		[Token(Token = "0x1700055B")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004136")]
			[Address(RVA = "0x8321D0", Offset = "0x8307D0", VA = "0x1808321D0", Slot = "4")]
			get
			{
				return PlantType.UltimateTallNut;
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06004137 RID: 16695 RVA: 0x00156AE4 File Offset: 0x00154CE4
		[Token(Token = "0x1700055C")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004137")]
			[Address(RVA = "0x844530", Offset = "0x842B30", VA = "0x180844530", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UltimateTallNut.ReduceDamageBuff reduceDamageBuff = new UltimateTallNut.ReduceDamageBuff();
				int size = list._size;
				UltimateTallNut.HolographicBuff holographicBuff = new UltimateTallNut.HolographicBuff();
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06004138 RID: 16696 RVA: 0x00156B24 File Offset: 0x00154D24
		[Token(Token = "0x6004138")]
		[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x06004139 RID: 16697 RVA: 0x00156B34 File Offset: 0x00154D34
		[Token(Token = "0x6004139")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public UltimateTallNut()
		{
		}

		// Token: 0x02000C30 RID: 3120
		[Token(Token = "0x2000C30")]
		private class ReduceDamageBuff : BaseBuff
		{
			// Token: 0x1700055D RID: 1373
			// (get) Token: 0x0600413A RID: 16698 RVA: 0x00156B48 File Offset: 0x00154D48
			[Token(Token = "0x1700055D")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600413A")]
				[Address(RVA = "0x8321D0", Offset = "0x8307D0", VA = "0x1808321D0", Slot = "4")]
				get
				{
					return PlantType.UltimateTallNut;
				}
			}

			// Token: 0x1700055E RID: 1374
			// (get) Token: 0x0600413B RID: 16699 RVA: 0x00156B5C File Offset: 0x00154D5C
			[Token(Token = "0x1700055E")]
			public override string Title
			{
				[Token(Token = "0x600413B")]
				[Address(RVA = "0x835B70", Offset = "0x834170", VA = "0x180835B70", Slot = "5")]
				get
				{
					return "强化：减伤";
				}
			}

			// Token: 0x1700055F RID: 1375
			// (get) Token: 0x0600413C RID: 16700 RVA: 0x00156B70 File Offset: 0x00154D70
			[Token(Token = "0x1700055F")]
			public override string Description
			{
				[Token(Token = "0x600413C")]
				[Address(RVA = "0x835B40", Offset = "0x834140", VA = "0x180835B40", Slot = "6")]
				get
				{
					return "植物获得9.9%伤害减免";
				}
			}

			// Token: 0x17000560 RID: 1376
			// (get) Token: 0x0600413D RID: 16701 RVA: 0x00156B84 File Offset: 0x00154D84
			[Token(Token = "0x17000560")]
			public override bool Passive
			{
				[Token(Token = "0x600413D")]
				[Address(RVA = "0x3A5ED0", Offset = "0x3A44D0", VA = "0x1803A5ED0", Slot = "10")]
				get
				{
					return true;
				}
			}

			// Token: 0x0600413E RID: 16702 RVA: 0x00156B94 File Offset: 0x00154D94
			[Token(Token = "0x600413E")]
			[Address(RVA = "0x835AE0", Offset = "0x8340E0", VA = "0x180835AE0", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr instance = TravelMgr.Instance;
				float damageReduction = instance.damageReduction;
				instance.damageReduction = damageReduction;
			}

			// Token: 0x17000561 RID: 1377
			// (get) Token: 0x0600413F RID: 16703 RVA: 0x00156BC0 File Offset: 0x00154DC0
			[Token(Token = "0x17000561")]
			public override Quality Rarity
			{
				[Token(Token = "0x600413F")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x06004140 RID: 16704 RVA: 0x00156BD0 File Offset: 0x00154DD0
			[Token(Token = "0x6004140")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public ReduceDamageBuff()
			{
			}
		}

		// Token: 0x02000C31 RID: 3121
		[Token(Token = "0x2000C31")]
		private class HolographicBuff : BaseBuff
		{
			// Token: 0x17000562 RID: 1378
			// (get) Token: 0x06004141 RID: 16705 RVA: 0x00156BE4 File Offset: 0x00154DE4
			[Token(Token = "0x17000562")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004141")]
				[Address(RVA = "0x8321D0", Offset = "0x8307D0", VA = "0x1808321D0", Slot = "4")]
				get
				{
					return PlantType.UltimateTallNut;
				}
			}

			// Token: 0x17000563 RID: 1379
			// (get) Token: 0x06004142 RID: 16706 RVA: 0x00156BF8 File Offset: 0x00154DF8
			[Token(Token = "0x17000563")]
			public override string Title
			{
				[Token(Token = "0x6004142")]
				[Address(RVA = "0x8321E0", Offset = "0x8307E0", VA = "0x1808321E0", Slot = "5")]
				get
				{
					return "强化：分身";
				}
			}

			// Token: 0x17000564 RID: 1380
			// (get) Token: 0x06004143 RID: 16707 RVA: 0x00156C0C File Offset: 0x00154E0C
			[Token(Token = "0x17000564")]
			public override string Description
			{
				[Token(Token = "0x6004143")]
				[Address(RVA = "0x8321A0", Offset = "0x8307A0", VA = "0x1808321A0", Slot = "6")]
				get
				{
					return "全息黑高数量+1";
				}
			}

			// Token: 0x17000565 RID: 1381
			// (get) Token: 0x06004144 RID: 16708 RVA: 0x00156C20 File Offset: 0x00154E20
			[Token(Token = "0x17000565")]
			public override bool Passive
			{
				[Token(Token = "0x6004144")]
				[Address(RVA = "0x3A5ED0", Offset = "0x3A44D0", VA = "0x1803A5ED0", Slot = "10")]
				get
				{
					return true;
				}
			}

			// Token: 0x06004145 RID: 16709 RVA: 0x00156C30 File Offset: 0x00154E30
			[Token(Token = "0x6004145")]
			[Address(RVA = "0x832020", Offset = "0x830620", VA = "0x180832020", Slot = "7")]
			public override void OnGet()
			{
				int num = 0;
				if (ShootingManager.Instance.TryGetPlant((PlantType)((uint)913), num))
				{
					CreatePlant instance = CreatePlant.Instance;
					bool flag = "{il2cpp field on {'constant9' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StackPointer)}, offset 0xFFFFFFFFFFFFFFF8}" == typeof(HolographicPlant).TypeHandle;
				}
			}

			// Token: 0x17000566 RID: 1382
			// (get) Token: 0x06004146 RID: 16710 RVA: 0x00156C70 File Offset: 0x00154E70
			[Token(Token = "0x17000566")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004146")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x06004147 RID: 16711 RVA: 0x00156C80 File Offset: 0x00154E80
			[Token(Token = "0x6004147")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public HolographicBuff()
			{
			}
		}
	}
}
