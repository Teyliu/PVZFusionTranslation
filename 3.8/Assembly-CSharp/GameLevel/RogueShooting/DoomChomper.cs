using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C39 RID: 3129
	[Token(Token = "0x2000C39")]
	public class DoomChomper : BaseConfig
	{
		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06004170 RID: 16752 RVA: 0x00157174 File Offset: 0x00155374
		[Token(Token = "0x17000581")]
		public override string Role
		{
			[Token(Token = "0x6004170")]
			[Address(RVA = "0x8307A0", Offset = "0x82EDA0", VA = "0x1808307A0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06004171 RID: 16753 RVA: 0x00157188 File Offset: 0x00155388
		[Token(Token = "0x17000582")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004171")]
			[Address(RVA = "0x82F700", Offset = "0x82DD00", VA = "0x18082F700", Slot = "4")]
			get
			{
				return PlantType.DoomChomper;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06004172 RID: 16754 RVA: 0x0015719C File Offset: 0x0015539C
		[Token(Token = "0x17000583")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004172")]
			[Address(RVA = "0x8304F0", Offset = "0x82EAF0", VA = "0x1808304F0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				DoomChomper.UniqueUpgrade uniqueUpgrade = new DoomChomper.UniqueUpgrade();
				int size3 = list._size;
				DoomChomper.ChompBuff chompBuff = new DoomChomper.ChompBuff();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x06004173 RID: 16755 RVA: 0x001571F4 File Offset: 0x001553F4
		[Token(Token = "0x6004173")]
		[Address(RVA = "0x830430", Offset = "0x82EA30", VA = "0x180830430", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			bool flag = "{il2cpp field on {'Chomper' (constant value of type Mono.Cecil.TypeReference)}, offset 0xFFFFFFFFFFFFFFF8}" == typeof(Chomper).TypeHandle;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 1f, num2 != 0, num);
		}

		// Token: 0x06004174 RID: 16756 RVA: 0x0015722C File Offset: 0x0015542C
		[Token(Token = "0x6004174")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public DoomChomper()
		{
		}

		// Token: 0x02000C3A RID: 3130
		[Token(Token = "0x2000C3A")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x17000584 RID: 1412
			// (get) Token: 0x06004175 RID: 16757 RVA: 0x00157240 File Offset: 0x00155440
			[Token(Token = "0x17000584")]
			public override string Title
			{
				[Token(Token = "0x6004175")]
				[Address(RVA = "0x846770", Offset = "0x844D70", VA = "0x180846770", Slot = "5")]
				get
				{
					return "强化：爆炸";
				}
			}

			// Token: 0x17000585 RID: 1413
			// (get) Token: 0x06004176 RID: 16758 RVA: 0x00157254 File Offset: 0x00155454
			[Token(Token = "0x17000585")]
			public override string Description
			{
				[Token(Token = "0x6004176")]
				[Address(RVA = "0x8460B0", Offset = "0x8446B0", VA = "0x1808460B0", Slot = "6")]
				get
				{
					return base.PlantName + "爆炸数+1";
				}
			}

			// Token: 0x17000586 RID: 1414
			// (get) Token: 0x06004177 RID: 16759 RVA: 0x00157274 File Offset: 0x00155474
			[Token(Token = "0x17000586")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004177")]
				[Address(RVA = "0x82F700", Offset = "0x82DD00", VA = "0x18082F700", Slot = "4")]
				get
				{
					return PlantType.DoomChomper;
				}
			}

			// Token: 0x17000587 RID: 1415
			// (get) Token: 0x06004178 RID: 16760 RVA: 0x00157288 File Offset: 0x00155488
			[Token(Token = "0x17000587")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004178")]
				[Address(RVA = "0x830000", Offset = "0x82E600", VA = "0x180830000", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004179 RID: 16761 RVA: 0x0015729C File Offset: 0x0015549C
			[Token(Token = "0x6004179")]
			[Address(RVA = "0x845950", Offset = "0x843F50", VA = "0x180845950", Slot = "7")]
			public override void OnGet()
			{
				ShootingManager instance = ShootingManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}

			// Token: 0x17000588 RID: 1416
			// (get) Token: 0x0600417A RID: 16762 RVA: 0x001572BC File Offset: 0x001554BC
			[Token(Token = "0x17000588")]
			public override Quality Rarity
			{
				[Token(Token = "0x600417A")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x0600417B RID: 16763 RVA: 0x001572CC File Offset: 0x001554CC
			[Token(Token = "0x600417B")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000C3B RID: 3131
		[Token(Token = "0x2000C3B")]
		private class ChompBuff : BaseBuff
		{
			// Token: 0x17000589 RID: 1417
			// (get) Token: 0x0600417C RID: 16764 RVA: 0x001572E0 File Offset: 0x001554E0
			[Token(Token = "0x17000589")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600417C")]
				[Address(RVA = "0x82F700", Offset = "0x82DD00", VA = "0x18082F700", Slot = "4")]
				get
				{
					return PlantType.DoomChomper;
				}
			}

			// Token: 0x1700058A RID: 1418
			// (get) Token: 0x0600417D RID: 16765 RVA: 0x001572F4 File Offset: 0x001554F4
			[Token(Token = "0x1700058A")]
			public override string Title
			{
				[Token(Token = "0x600417D")]
				[Address(RVA = "0x82F710", Offset = "0x82DD10", VA = "0x18082F710", Slot = "5")]
				get
				{
					return "质变：毁灭";
				}
			}

			// Token: 0x1700058B RID: 1419
			// (get) Token: 0x0600417E RID: 16766 RVA: 0x00157308 File Offset: 0x00155508
			[Token(Token = "0x1700058B")]
			public override string Description
			{
				[Token(Token = "0x600417E")]
				[Address(RVA = "0x82F6B0", Offset = "0x82DCB0", VA = "0x18082F6B0", Slot = "6")]
				get
				{
					return base.PlantName + "攻击时没有吞噬僵尸也将释放爆炸，吞下则释放两次";
				}
			}

			// Token: 0x1700058C RID: 1420
			// (get) Token: 0x0600417F RID: 16767 RVA: 0x00157328 File Offset: 0x00155528
			[Token(Token = "0x1700058C")]
			public override Quality Rarity
			{
				[Token(Token = "0x600417F")]
				[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x1700058D RID: 1421
			// (get) Token: 0x06004180 RID: 16768 RVA: 0x00157338 File Offset: 0x00155538
			[Token(Token = "0x1700058D")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004180")]
				[Address(RVA = "0x82E470", Offset = "0x82CA70", VA = "0x18082E470", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700058E RID: 1422
			// (get) Token: 0x06004181 RID: 16769 RVA: 0x0015734C File Offset: 0x0015554C
			[Token(Token = "0x1700058E")]
			public override int MaxCount
			{
				[Token(Token = "0x6004181")]
				[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x06004182 RID: 16770 RVA: 0x0015735C File Offset: 0x0015555C
			[Token(Token = "0x6004182")]
			[Address(RVA = "0x82F650", Offset = "0x82DC50", VA = "0x18082F650", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12004));
			}

			// Token: 0x06004183 RID: 16771 RVA: 0x00157384 File Offset: 0x00155584
			[Token(Token = "0x6004183")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public ChompBuff()
			{
			}
		}
	}
}
