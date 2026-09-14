using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C60 RID: 3168
	[Token(Token = "0x2000C60")]
	public class UltimateHypno : BaseConfig
	{
		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06004250 RID: 16976 RVA: 0x00158A68 File Offset: 0x00156C68
		[Token(Token = "0x1700060F")]
		public override string Role
		{
			[Token(Token = "0x6004250")]
			[Address(RVA = "0x842D60", Offset = "0x841360", VA = "0x180842D60", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06004251 RID: 16977 RVA: 0x00158A7C File Offset: 0x00156C7C
		[Token(Token = "0x17000610")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004251")]
			[Address(RVA = "0x82E4B0", Offset = "0x82CAB0", VA = "0x18082E4B0", Slot = "4")]
			get
			{
				return PlantType.UltimateHypno;
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06004252 RID: 16978 RVA: 0x00158A90 File Offset: 0x00156C90
		[Token(Token = "0x17000611")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004252")]
			[Address(RVA = "0x842A30", Offset = "0x841030", VA = "0x180842A30", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				UltimateHypno.MindContolledBuff mindContolledBuff = new UltimateHypno.MindContolledBuff();
				int size3 = list._size;
				UltimateHypno.HypnoEffect hypnoEffect = new UltimateHypno.HypnoEffect();
				int size4 = list._size;
				UltimateHypno.BombEffect bombEffect = new UltimateHypno.BombEffect();
				int size5 = list._size;
				return list;
			}
		}

		// Token: 0x06004253 RID: 16979 RVA: 0x00158AF8 File Offset: 0x00156CF8
		[Token(Token = "0x6004253")]
		[Address(RVA = "0x842980", Offset = "0x840F80", VA = "0x180842980", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06004254 RID: 16980 RVA: 0x00158B1C File Offset: 0x00156D1C
		[Token(Token = "0x6004254")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public UltimateHypno()
		{
		}

		// Token: 0x02000C61 RID: 3169
		[Token(Token = "0x2000C61")]
		private class MindContolledBuff : BaseBuff
		{
			// Token: 0x17000612 RID: 1554
			// (get) Token: 0x06004255 RID: 16981 RVA: 0x00158B30 File Offset: 0x00156D30
			[Token(Token = "0x17000612")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004255")]
				[Address(RVA = "0x82E4B0", Offset = "0x82CAB0", VA = "0x18082E4B0", Slot = "4")]
				get
				{
					return PlantType.UltimateHypno;
				}
			}

			// Token: 0x17000613 RID: 1555
			// (get) Token: 0x06004256 RID: 16982 RVA: 0x00158B44 File Offset: 0x00156D44
			[Token(Token = "0x17000613")]
			public override string Title
			{
				[Token(Token = "0x6004256")]
				[Address(RVA = "0x834070", Offset = "0x832670", VA = "0x180834070", Slot = "5")]
				get
				{
					return "强化：魅惑";
				}
			}

			// Token: 0x17000614 RID: 1556
			// (get) Token: 0x06004257 RID: 16983 RVA: 0x00158B58 File Offset: 0x00156D58
			[Token(Token = "0x17000614")]
			public override string Description
			{
				[Token(Token = "0x6004257")]
				[Address(RVA = "0x834040", Offset = "0x832640", VA = "0x180834040", Slot = "6")]
				get
				{
					return "魅惑概率提高7.5%";
				}
			}

			// Token: 0x06004258 RID: 16984 RVA: 0x00158B6C File Offset: 0x00156D6C
			[Token(Token = "0x6004258")]
			[Address(RVA = "0x833FB0", Offset = "0x8325B0", VA = "0x180833FB0", Slot = "7")]
			public override void OnGet()
			{
				ShootingManager instance = ShootingManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}

			// Token: 0x17000615 RID: 1557
			// (get) Token: 0x06004259 RID: 16985 RVA: 0x00158B8C File Offset: 0x00156D8C
			[Token(Token = "0x17000615")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004259")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x0600425A RID: 16986 RVA: 0x00158B9C File Offset: 0x00156D9C
			[Token(Token = "0x600425A")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public MindContolledBuff()
			{
			}
		}

		// Token: 0x02000C62 RID: 3170
		[Token(Token = "0x2000C62")]
		private class HypnoEffect : BaseBuff
		{
			// Token: 0x17000616 RID: 1558
			// (get) Token: 0x0600425B RID: 16987 RVA: 0x00158BB0 File Offset: 0x00156DB0
			[Token(Token = "0x17000616")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600425B")]
				[Address(RVA = "0x82E4B0", Offset = "0x82CAB0", VA = "0x18082E4B0", Slot = "4")]
				get
				{
					return PlantType.UltimateHypno;
				}
			}

			// Token: 0x17000617 RID: 1559
			// (get) Token: 0x0600425C RID: 16988 RVA: 0x00158BC4 File Offset: 0x00156DC4
			[Token(Token = "0x17000617")]
			public override string Title
			{
				[Token(Token = "0x600425C")]
				[Address(RVA = "0x8322A0", Offset = "0x8308A0", VA = "0x1808322A0", Slot = "5")]
				get
				{
					return "质变：普度众生";
				}
			}

			// Token: 0x17000618 RID: 1560
			// (get) Token: 0x0600425D RID: 16989 RVA: 0x00158BD8 File Offset: 0x00156DD8
			[Token(Token = "0x17000618")]
			public override string Description
			{
				[Token(Token = "0x600425D")]
				[Address(RVA = "0x832270", Offset = "0x830870", VA = "0x180832270", Slot = "6")]
				get
				{
					return "获得词条：普度众生";
				}
			}

			// Token: 0x17000619 RID: 1561
			// (get) Token: 0x0600425E RID: 16990 RVA: 0x00158BEC File Offset: 0x00156DEC
			[Token(Token = "0x17000619")]
			public override Quality Rarity
			{
				[Token(Token = "0x600425E")]
				[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x1700061A RID: 1562
			// (get) Token: 0x0600425F RID: 16991 RVA: 0x00158BFC File Offset: 0x00156DFC
			[Token(Token = "0x1700061A")]
			public override int MaxCount
			{
				[Token(Token = "0x600425F")]
				[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x1700061B RID: 1563
			// (get) Token: 0x06004260 RID: 16992 RVA: 0x00158C0C File Offset: 0x00156E0C
			[Token(Token = "0x1700061B")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004260")]
				[Address(RVA = "0x82E470", Offset = "0x82CA70", VA = "0x18082E470", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004261 RID: 16993 RVA: 0x00158C20 File Offset: 0x00156E20
			[Token(Token = "0x6004261")]
			[Address(RVA = "0x832210", Offset = "0x830810", VA = "0x180832210", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr instance = TravelMgr.Instance;
				int num = 0;
				instance.GetUltiBuff((UltiBuff)((uint)18), num != 0);
			}

			// Token: 0x06004262 RID: 16994 RVA: 0x00158C48 File Offset: 0x00156E48
			[Token(Token = "0x6004262")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public HypnoEffect()
			{
			}
		}

		// Token: 0x02000C63 RID: 3171
		[Token(Token = "0x2000C63")]
		private class BombEffect : BaseBuff
		{
			// Token: 0x1700061C RID: 1564
			// (get) Token: 0x06004263 RID: 16995 RVA: 0x00158C5C File Offset: 0x00156E5C
			[Token(Token = "0x1700061C")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004263")]
				[Address(RVA = "0x82E4B0", Offset = "0x82CAB0", VA = "0x18082E4B0", Slot = "4")]
				get
				{
					return PlantType.UltimateHypno;
				}
			}

			// Token: 0x1700061D RID: 1565
			// (get) Token: 0x06004264 RID: 16996 RVA: 0x00158C70 File Offset: 0x00156E70
			[Token(Token = "0x1700061D")]
			public override string Title
			{
				[Token(Token = "0x6004264")]
				[Address(RVA = "0x82E4C0", Offset = "0x82CAC0", VA = "0x18082E4C0", Slot = "5")]
				get
				{
					return "质变：定时炸弹";
				}
			}

			// Token: 0x1700061E RID: 1566
			// (get) Token: 0x06004265 RID: 16997 RVA: 0x00158C84 File Offset: 0x00156E84
			[Token(Token = "0x1700061E")]
			public override string Description
			{
				[Token(Token = "0x6004265")]
				[Address(RVA = "0x82E480", Offset = "0x82CA80", VA = "0x18082E480", Slot = "6")]
				get
				{
					return "获得词条：定时炸弹";
				}
			}

			// Token: 0x1700061F RID: 1567
			// (get) Token: 0x06004266 RID: 16998 RVA: 0x00158C98 File Offset: 0x00156E98
			[Token(Token = "0x1700061F")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004266")]
				[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x17000620 RID: 1568
			// (get) Token: 0x06004267 RID: 16999 RVA: 0x00158CA8 File Offset: 0x00156EA8
			[Token(Token = "0x17000620")]
			public override int MaxCount
			{
				[Token(Token = "0x6004267")]
				[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x17000621 RID: 1569
			// (get) Token: 0x06004268 RID: 17000 RVA: 0x00158CB8 File Offset: 0x00156EB8
			[Token(Token = "0x17000621")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004268")]
				[Address(RVA = "0x82E470", Offset = "0x82CA70", VA = "0x18082E470", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004269 RID: 17001 RVA: 0x00158CCC File Offset: 0x00156ECC
			[Token(Token = "0x6004269")]
			[Address(RVA = "0x82E410", Offset = "0x82CA10", VA = "0x18082E410", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)1019));
			}

			// Token: 0x0600426A RID: 17002 RVA: 0x00158CF4 File Offset: 0x00156EF4
			[Token(Token = "0x600426A")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public BombEffect()
			{
			}
		}
	}
}
