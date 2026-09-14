using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D11 RID: 3345
	[Token(Token = "0x2000D11")]
	public class UltimateBigChomper : BaseConfig
	{
		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06004579 RID: 17785 RVA: 0x00164B10 File Offset: 0x00162D10
		[Token(Token = "0x170006FB")]
		public override string Role
		{
			[Token(Token = "0x6004579")]
			[Address(RVA = "0x8BFF50", Offset = "0x8BE550", VA = "0x1808BFF50", Slot = "7")]
			get
			{
				return "防御";
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x0600457A RID: 17786 RVA: 0x00164B24 File Offset: 0x00162D24
		[Token(Token = "0x170006FC")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600457A")]
			[Address(RVA = "0x7E7B40", Offset = "0x7E6140", VA = "0x1807E7B40", Slot = "4")]
			get
			{
				return PlantType.UltimateBigChomper;
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x0600457B RID: 17787 RVA: 0x00164B38 File Offset: 0x00162D38
		[Token(Token = "0x170006FD")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600457B")]
			[Address(RVA = "0x8BFD30", Offset = "0x8BE330", VA = "0x1808BFD30", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				UltimateBigChomper.UniqueUpgrade uniqueUpgrade = new UltimateBigChomper.UniqueUpgrade();
				int size2 = list._size;
				UltimateBigChomper.SuperBuff superBuff = new UltimateBigChomper.SuperBuff();
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x0600457C RID: 17788 RVA: 0x00164B84 File Offset: 0x00162D84
		[Token(Token = "0x600457C")]
		[Address(RVA = "0x8BFC90", Offset = "0x8BE290", VA = "0x1808BFC90", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			bool flag = "{il2cpp field on {'Chomper' (constant value of type Mono.Cecil.TypeReference)}, offset 0xFFFFFFFFFFFFFFF8}" == typeof(Chomper).TypeHandle;
		}

		// Token: 0x0600457D RID: 17789 RVA: 0x00164BA8 File Offset: 0x00162DA8
		[Token(Token = "0x600457D")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public UltimateBigChomper()
		{
		}

		// Token: 0x02000D12 RID: 3346
		[Token(Token = "0x2000D12")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x170006FE RID: 1790
			// (get) Token: 0x0600457E RID: 17790 RVA: 0x00164BBC File Offset: 0x00162DBC
			[Token(Token = "0x170006FE")]
			public override string Title
			{
				[Token(Token = "0x600457E")]
				[Address(RVA = "0x8C7020", Offset = "0x8C5620", VA = "0x1808C7020", Slot = "5")]
				get
				{
					return "强化：范围";
				}
			}

			// Token: 0x170006FF RID: 1791
			// (get) Token: 0x0600457F RID: 17791 RVA: 0x00164BD0 File Offset: 0x00162DD0
			[Token(Token = "0x170006FF")]
			public override string Description
			{
				[Token(Token = "0x600457F")]
				[Address(RVA = "0x8C6A70", Offset = "0x8C5070", VA = "0x1808C6A70", Slot = "6")]
				get
				{
					return base.PlantName + "范围+1";
				}
			}

			// Token: 0x17000700 RID: 1792
			// (get) Token: 0x06004580 RID: 17792 RVA: 0x00164BF0 File Offset: 0x00162DF0
			[Token(Token = "0x17000700")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004580")]
				[Address(RVA = "0x7E7B40", Offset = "0x7E6140", VA = "0x1807E7B40", Slot = "4")]
				get
				{
					return PlantType.UltimateBigChomper;
				}
			}

			// Token: 0x06004581 RID: 17793 RVA: 0x00164C04 File Offset: 0x00162E04
			[Token(Token = "0x6004581")]
			[Address(RVA = "0x8C5B40", Offset = "0x8C4140", VA = "0x1808C5B40", Slot = "7")]
			public override void OnGet()
			{
				ShootingManager instance = ShootingManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}

			// Token: 0x17000701 RID: 1793
			// (get) Token: 0x06004582 RID: 17794 RVA: 0x00164C24 File Offset: 0x00162E24
			[Token(Token = "0x17000701")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004582")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x06004583 RID: 17795 RVA: 0x00164C34 File Offset: 0x00162E34
			[Token(Token = "0x6004583")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000D13 RID: 3347
		[Token(Token = "0x2000D13")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x17000702 RID: 1794
			// (get) Token: 0x06004584 RID: 17796 RVA: 0x00164C48 File Offset: 0x00162E48
			[Token(Token = "0x17000702")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004584")]
				[Address(RVA = "0x7E7B40", Offset = "0x7E6140", VA = "0x1807E7B40", Slot = "4")]
				get
				{
					return PlantType.UltimateBigChomper;
				}
			}

			// Token: 0x17000703 RID: 1795
			// (get) Token: 0x06004585 RID: 17797 RVA: 0x00164C5C File Offset: 0x00162E5C
			[Token(Token = "0x17000703")]
			public override string Title
			{
				[Token(Token = "0x6004585")]
				[Address(RVA = "0x8B72D0", Offset = "0x8B58D0", VA = "0x1808B72D0", Slot = "5")]
				get
				{
					return "质变：吞噬";
				}
			}

			// Token: 0x17000704 RID: 1796
			// (get) Token: 0x06004586 RID: 17798 RVA: 0x00164C70 File Offset: 0x00162E70
			[Token(Token = "0x17000704")]
			public override string Description
			{
				[Token(Token = "0x6004586")]
				[Address(RVA = "0x8B6DF0", Offset = "0x8B53F0", VA = "0x1808B6DF0", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)12009];
				}
			}

			// Token: 0x17000705 RID: 1797
			// (get) Token: 0x06004587 RID: 17799 RVA: 0x00164C94 File Offset: 0x00162E94
			[Token(Token = "0x17000705")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004587")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x17000706 RID: 1798
			// (get) Token: 0x06004588 RID: 17800 RVA: 0x00164CA4 File Offset: 0x00162EA4
			[Token(Token = "0x17000706")]
			public override int MaxCount
			{
				[Token(Token = "0x6004588")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x17000707 RID: 1799
			// (get) Token: 0x06004589 RID: 17801 RVA: 0x00164CB4 File Offset: 0x00162EB4
			[Token(Token = "0x17000707")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004589")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600458A RID: 17802 RVA: 0x00164CC8 File Offset: 0x00162EC8
			[Token(Token = "0x600458A")]
			[Address(RVA = "0x8B6440", Offset = "0x8B4A40", VA = "0x1808B6440", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12009));
			}

			// Token: 0x0600458B RID: 17803 RVA: 0x00164CF0 File Offset: 0x00162EF0
			[Token(Token = "0x600458B")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public SuperBuff()
			{
			}
		}
	}
}
