using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C34 RID: 3124
	[Token(Token = "0x2000C34")]
	public class ThreeMine : BaseConfig
	{
		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06004152 RID: 16722 RVA: 0x00156DFC File Offset: 0x00154FFC
		[Token(Token = "0x1700056D")]
		public override string Role
		{
			[Token(Token = "0x6004152")]
			[Address(RVA = "0x83BB20", Offset = "0x83A120", VA = "0x18083BB20", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06004153 RID: 16723 RVA: 0x00156E10 File Offset: 0x00155010
		[Token(Token = "0x1700056E")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004153")]
			[Address(RVA = "0x77E970", Offset = "0x77CF70", VA = "0x18077E970", Slot = "4")]
			get
			{
				return PlantType.ThreeMine;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06004154 RID: 16724 RVA: 0x00156E24 File Offset: 0x00155024
		[Token(Token = "0x1700056F")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004154")]
			[Address(RVA = "0x83B870", Offset = "0x839E70", VA = "0x18083B870", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				ThreeMine.UniqueUpgrade uniqueUpgrade = new ThreeMine.UniqueUpgrade();
				int size3 = list._size;
				ThreeMine.ExplodeBuff explodeBuff = new ThreeMine.ExplodeBuff();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x06004155 RID: 16725 RVA: 0x00156E7C File Offset: 0x0015507C
		[Token(Token = "0x6004155")]
		[Address(RVA = "0x83B820", Offset = "0x839E20", VA = "0x18083B820", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 19f, num2 != 0, num);
			plant.attributeCountdown = 0.5f;
		}

		// Token: 0x06004156 RID: 16726 RVA: 0x00156EB0 File Offset: 0x001550B0
		[Token(Token = "0x6004156")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public ThreeMine()
		{
		}

		// Token: 0x02000C35 RID: 3125
		[Token(Token = "0x2000C35")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x17000570 RID: 1392
			// (get) Token: 0x06004157 RID: 16727 RVA: 0x00156EC4 File Offset: 0x001550C4
			[Token(Token = "0x17000570")]
			public override string Title
			{
				[Token(Token = "0x6004157")]
				[Address(RVA = "0x8468C0", Offset = "0x844EC0", VA = "0x1808468C0", Slot = "5")]
				get
				{
					return "强化：持久";
				}
			}

			// Token: 0x17000571 RID: 1393
			// (get) Token: 0x06004158 RID: 16728 RVA: 0x00156ED8 File Offset: 0x001550D8
			[Token(Token = "0x17000571")]
			public override string Description
			{
				[Token(Token = "0x6004158")]
				[Address(RVA = "0x846290", Offset = "0x844890", VA = "0x180846290", Slot = "6")]
				get
				{
					return base.PlantName + "大招持续时间+5秒";
				}
			}

			// Token: 0x17000572 RID: 1394
			// (get) Token: 0x06004159 RID: 16729 RVA: 0x00156EF8 File Offset: 0x001550F8
			[Token(Token = "0x17000572")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004159")]
				[Address(RVA = "0x77E970", Offset = "0x77CF70", VA = "0x18077E970", Slot = "4")]
				get
				{
					return PlantType.ThreeMine;
				}
			}

			// Token: 0x17000573 RID: 1395
			// (get) Token: 0x0600415A RID: 16730 RVA: 0x00156F0C File Offset: 0x0015510C
			[Token(Token = "0x17000573")]
			public override float AppearWeight
			{
				[Token(Token = "0x600415A")]
				[Address(RVA = "0x830000", Offset = "0x82E600", VA = "0x180830000", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600415B RID: 16731 RVA: 0x00156F20 File Offset: 0x00155120
			[Token(Token = "0x600415B")]
			[Address(RVA = "0x845830", Offset = "0x843E30", VA = "0x180845830", Slot = "7")]
			public override void OnGet()
			{
				ShootingManager instance = ShootingManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}

			// Token: 0x17000574 RID: 1396
			// (get) Token: 0x0600415C RID: 16732 RVA: 0x00156F40 File Offset: 0x00155140
			[Token(Token = "0x17000574")]
			public override Quality Rarity
			{
				[Token(Token = "0x600415C")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x0600415D RID: 16733 RVA: 0x00156F50 File Offset: 0x00155150
			[Token(Token = "0x600415D")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000C36 RID: 3126
		[Token(Token = "0x2000C36")]
		private class ExplodeBuff : BaseBuff
		{
			// Token: 0x17000575 RID: 1397
			// (get) Token: 0x0600415E RID: 16734 RVA: 0x00156F64 File Offset: 0x00155164
			[Token(Token = "0x17000575")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600415E")]
				[Address(RVA = "0x77E970", Offset = "0x77CF70", VA = "0x18077E970", Slot = "4")]
				get
				{
					return PlantType.ThreeMine;
				}
			}

			// Token: 0x17000576 RID: 1398
			// (get) Token: 0x0600415F RID: 16735 RVA: 0x00156F78 File Offset: 0x00155178
			[Token(Token = "0x17000576")]
			public override string Title
			{
				[Token(Token = "0x600415F")]
				[Address(RVA = "0x830F00", Offset = "0x82F500", VA = "0x180830F00", Slot = "5")]
				get
				{
					return "质变：爆破";
				}
			}

			// Token: 0x17000577 RID: 1399
			// (get) Token: 0x06004160 RID: 16736 RVA: 0x00156F8C File Offset: 0x0015518C
			[Token(Token = "0x17000577")]
			public override string Description
			{
				[Token(Token = "0x6004160")]
				[Address(RVA = "0x830E70", Offset = "0x82F470", VA = "0x180830E70", Slot = "6")]
				get
				{
					return "发射的子弹升级为爆破子弹";
				}
			}

			// Token: 0x17000578 RID: 1400
			// (get) Token: 0x06004161 RID: 16737 RVA: 0x00156FA0 File Offset: 0x001551A0
			[Token(Token = "0x17000578")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004161")]
				[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x17000579 RID: 1401
			// (get) Token: 0x06004162 RID: 16738 RVA: 0x00156FB0 File Offset: 0x001551B0
			[Token(Token = "0x17000579")]
			public override int MaxCount
			{
				[Token(Token = "0x6004162")]
				[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x1700057A RID: 1402
			// (get) Token: 0x06004163 RID: 16739 RVA: 0x00156FC0 File Offset: 0x001551C0
			[Token(Token = "0x1700057A")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004163")]
				[Address(RVA = "0x82E470", Offset = "0x82CA70", VA = "0x18082E470", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004164 RID: 16740 RVA: 0x00156FD4 File Offset: 0x001551D4
			[Token(Token = "0x6004164")]
			[Address(RVA = "0x830E10", Offset = "0x82F410", VA = "0x180830E10", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12003));
			}

			// Token: 0x06004165 RID: 16741 RVA: 0x00156FFC File Offset: 0x001551FC
			[Token(Token = "0x6004165")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public ExplodeBuff()
			{
			}
		}
	}
}
