using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D48 RID: 3400
	[Token(Token = "0x2000D48")]
	public class SuperThreePeater : BaseConfig
	{
		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x060046B3 RID: 18099 RVA: 0x00166C30 File Offset: 0x00164E30
		[Token(Token = "0x170007C1")]
		public override string Role
		{
			[Token(Token = "0x60046B3")]
			[Address(RVA = "0x8B7F10", Offset = "0x8B6510", VA = "0x1808B7F10", Slot = "7")]
			get
			{
				return "辅助";
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x060046B4 RID: 18100 RVA: 0x00166C44 File Offset: 0x00164E44
		[Token(Token = "0x170007C2")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60046B4")]
			[Address(RVA = "0x8B7170", Offset = "0x8B5770", VA = "0x1808B7170", Slot = "4")]
			get
			{
				return PlantType.SuperThreePeater;
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x060046B5 RID: 18101 RVA: 0x00166C58 File Offset: 0x00164E58
		[Token(Token = "0x170007C3")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60046B5")]
			[Address(RVA = "0x8B7D80", Offset = "0x8B6380", VA = "0x1808B7D80", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				SuperThreePeater.UniqueUpgrade uniqueUpgrade = new SuperThreePeater.UniqueUpgrade();
				int size = list._size;
				SuperThreePeater.SuperBuff superBuff = new SuperThreePeater.SuperBuff();
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060046B6 RID: 18102 RVA: 0x00166C98 File Offset: 0x00164E98
		[Token(Token = "0x60046B6")]
		[Address(RVA = "0x8B7D20", Offset = "0x8B6320", VA = "0x1808B7D20", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x060046B7 RID: 18103 RVA: 0x00166CB0 File Offset: 0x00164EB0
		[Token(Token = "0x60046B7")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public SuperThreePeater()
		{
		}

		// Token: 0x02000D49 RID: 3401
		[Token(Token = "0x2000D49")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x170007C4 RID: 1988
			// (get) Token: 0x060046B8 RID: 18104 RVA: 0x00166CC4 File Offset: 0x00164EC4
			[Token(Token = "0x170007C4")]
			public override bool Passive
			{
				[Token(Token = "0x60046B8")]
				[Address(RVA = "0x3F1E60", Offset = "0x3F0460", VA = "0x1803F1E60", Slot = "10")]
				get
				{
					return true;
				}
			}

			// Token: 0x170007C5 RID: 1989
			// (get) Token: 0x060046B9 RID: 18105 RVA: 0x00166CD4 File Offset: 0x00164ED4
			[Token(Token = "0x170007C5")]
			public override string Title
			{
				[Token(Token = "0x60046B9")]
				[Address(RVA = "0x8C6EA0", Offset = "0x8C54A0", VA = "0x1808C6EA0", Slot = "5")]
				get
				{
					return "强化：红温";
				}
			}

			// Token: 0x170007C6 RID: 1990
			// (get) Token: 0x060046BA RID: 18106 RVA: 0x00166CE8 File Offset: 0x00164EE8
			[Token(Token = "0x170007C6")]
			public override string Description
			{
				[Token(Token = "0x60046BA")]
				[Address(RVA = "0x8C6AC0", Offset = "0x8C50C0", VA = "0x1808C6AC0", Slot = "6")]
				get
				{
					return "红温伤害增幅提高60%";
				}
			}

			// Token: 0x170007C7 RID: 1991
			// (get) Token: 0x060046BB RID: 18107 RVA: 0x00166CFC File Offset: 0x00164EFC
			[Token(Token = "0x170007C7")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60046BB")]
				[Address(RVA = "0x8B7170", Offset = "0x8B5770", VA = "0x1808B7170", Slot = "4")]
				get
				{
					return PlantType.SuperThreePeater;
				}
			}

			// Token: 0x060046BC RID: 18108 RVA: 0x00166D10 File Offset: 0x00164F10
			[Token(Token = "0x60046BC")]
			[Address(RVA = "0x8C5690", Offset = "0x8C3C90", VA = "0x1808C5690", Slot = "7")]
			public override void OnGet()
			{
				TravelData data = TravelMgr.Instance.data;
				float jalaMore = data.jalaMore;
				data.jalaMore = jalaMore;
			}

			// Token: 0x170007C8 RID: 1992
			// (get) Token: 0x060046BD RID: 18109 RVA: 0x00166D40 File Offset: 0x00164F40
			[Token(Token = "0x170007C8")]
			public override Quality Rarity
			{
				[Token(Token = "0x60046BD")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x060046BE RID: 18110 RVA: 0x00166D50 File Offset: 0x00164F50
			[Token(Token = "0x60046BE")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000D4A RID: 3402
		[Token(Token = "0x2000D4A")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x170007C9 RID: 1993
			// (get) Token: 0x060046BF RID: 18111 RVA: 0x00166D64 File Offset: 0x00164F64
			[Token(Token = "0x170007C9")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60046BF")]
				[Address(RVA = "0x8B7170", Offset = "0x8B5770", VA = "0x1808B7170", Slot = "4")]
				get
				{
					return PlantType.SuperThreePeater;
				}
			}

			// Token: 0x170007CA RID: 1994
			// (get) Token: 0x060046C0 RID: 18112 RVA: 0x00166D78 File Offset: 0x00164F78
			[Token(Token = "0x170007CA")]
			public override string Title
			{
				[Token(Token = "0x60046C0")]
				[Address(RVA = "0x8B7390", Offset = "0x8B5990", VA = "0x1808B7390", Slot = "5")]
				get
				{
					return "质变：百步穿杨";
				}
			}

			// Token: 0x170007CB RID: 1995
			// (get) Token: 0x060046C1 RID: 18113 RVA: 0x00166D8C File Offset: 0x00164F8C
			[Token(Token = "0x170007CB")]
			public override string Description
			{
				[Token(Token = "0x60046C1")]
				[Address(RVA = "0x8B6F70", Offset = "0x8B5570", VA = "0x1808B6F70", Slot = "6")]
				get
				{
					return base.PlantName + "变为五线射手，子弹可无限穿透";
				}
			}

			// Token: 0x170007CC RID: 1996
			// (get) Token: 0x060046C2 RID: 18114 RVA: 0x00166DAC File Offset: 0x00164FAC
			[Token(Token = "0x170007CC")]
			public override Quality Rarity
			{
				[Token(Token = "0x60046C2")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x170007CD RID: 1997
			// (get) Token: 0x060046C3 RID: 18115 RVA: 0x00166DBC File Offset: 0x00164FBC
			[Token(Token = "0x170007CD")]
			public override float AppearWeight
			{
				[Token(Token = "0x60046C3")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170007CE RID: 1998
			// (get) Token: 0x060046C4 RID: 18116 RVA: 0x00166DD0 File Offset: 0x00164FD0
			[Token(Token = "0x170007CE")]
			public override int MaxCount
			{
				[Token(Token = "0x60046C4")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x060046C5 RID: 18117 RVA: 0x00166DE0 File Offset: 0x00164FE0
			[Token(Token = "0x60046C5")]
			[Address(RVA = "0x8B64A0", Offset = "0x8B4AA0", VA = "0x1808B64A0", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12008));
			}

			// Token: 0x060046C6 RID: 18118 RVA: 0x00166E08 File Offset: 0x00165008
			[Token(Token = "0x60046C6")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public SuperBuff()
			{
			}
		}
	}
}
