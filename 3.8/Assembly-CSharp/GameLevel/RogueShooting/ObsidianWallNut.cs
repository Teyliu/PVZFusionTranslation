using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C85 RID: 3205
	[Token(Token = "0x2000C85")]
	public class ObsidianWallNut : BaseConfig
	{
		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x0600432A RID: 17194 RVA: 0x0015A614 File Offset: 0x00158814
		[Token(Token = "0x17000696")]
		public override string Role
		{
			[Token(Token = "0x600432A")]
			[Address(RVA = "0x835060", Offset = "0x833660", VA = "0x180835060", Slot = "7")]
			get
			{
				return "输出/防御";
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x0600432B RID: 17195 RVA: 0x0015A628 File Offset: 0x00158828
		[Token(Token = "0x17000697")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600432B")]
			[Address(RVA = "0x835050", Offset = "0x833650", VA = "0x180835050", Slot = "4")]
			get
			{
				return PlantType.ObsidianWallNut;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x0600432C RID: 17196 RVA: 0x0015A63C File Offset: 0x0015883C
		[Token(Token = "0x17000698")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600432C")]
			[Address(RVA = "0x834DA0", Offset = "0x8333A0", VA = "0x180834DA0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				ObsidianWallNut.ShootCountBuff shootCountBuff = new ObsidianWallNut.ShootCountBuff();
				int size3 = list._size;
				ObsidianWallNut.ShootBuff shootBuff = new ObsidianWallNut.ShootBuff();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x0600432D RID: 17197 RVA: 0x0015A694 File Offset: 0x00158894
		[Token(Token = "0x600432D")]
		[Address(RVA = "0x834BB0", Offset = "0x8331B0", VA = "0x180834BB0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)6));
		}

		// Token: 0x0600432E RID: 17198 RVA: 0x0015A6C8 File Offset: 0x001588C8
		[Token(Token = "0x600432E")]
		[Address(RVA = "0x834CD0", Offset = "0x8332D0", VA = "0x180834CD0")]
		private void UniqueUpdate(Plant plant)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x0600432F RID: 17199 RVA: 0x0015A6E8 File Offset: 0x001588E8
		[Token(Token = "0x600432F")]
		[Address(RVA = "0x834AF0", Offset = "0x8330F0", VA = "0x180834AF0")]
		private void CreateLoonNut(Plant plant, int count)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06004330 RID: 17200 RVA: 0x0015A70C File Offset: 0x0015890C
		[Token(Token = "0x6004330")]
		[Address(RVA = "0x834A30", Offset = "0x833030", VA = "0x180834A30")]
		private void CreateLoonNut2(Plant plant, int count)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06004331 RID: 17201 RVA: 0x0015A730 File Offset: 0x00158930
		[Token(Token = "0x6004331")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public ObsidianWallNut()
		{
		}

		// Token: 0x02000C86 RID: 3206
		[Token(Token = "0x2000C86")]
		private class ShootCountBuff : BaseBuff
		{
			// Token: 0x17000699 RID: 1689
			// (get) Token: 0x06004332 RID: 17202 RVA: 0x0015A744 File Offset: 0x00158944
			[Token(Token = "0x17000699")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004332")]
				[Address(RVA = "0x835050", Offset = "0x833650", VA = "0x180835050", Slot = "4")]
				get
				{
					return PlantType.ObsidianWallNut;
				}
			}

			// Token: 0x1700069A RID: 1690
			// (get) Token: 0x06004333 RID: 17203 RVA: 0x0015A758 File Offset: 0x00158958
			[Token(Token = "0x1700069A")]
			public override string Title
			{
				[Token(Token = "0x6004333")]
				[Address(RVA = "0x8387C0", Offset = "0x836DC0", VA = "0x1808387C0", Slot = "5")]
				get
				{
					return "强化：保龄球";
				}
			}

			// Token: 0x1700069B RID: 1691
			// (get) Token: 0x06004334 RID: 17204 RVA: 0x0015A76C File Offset: 0x0015896C
			[Token(Token = "0x1700069B")]
			public override string Description
			{
				[Token(Token = "0x6004334")]
				[Address(RVA = "0x838790", Offset = "0x836D90", VA = "0x180838790", Slot = "6")]
				get
				{
					return "保龄球发射数量+1";
				}
			}

			// Token: 0x1700069C RID: 1692
			// (get) Token: 0x06004335 RID: 17205 RVA: 0x0015A780 File Offset: 0x00158980
			[Token(Token = "0x1700069C")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004335")]
				[Address(RVA = "0x830000", Offset = "0x82E600", VA = "0x180830000", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004336 RID: 17206 RVA: 0x0015A794 File Offset: 0x00158994
			[Token(Token = "0x6004336")]
			[Address(RVA = "0x838720", Offset = "0x836D20", VA = "0x180838720", Slot = "7")]
			public override void OnGet()
			{
				ShootingManager instance = ShootingManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}

			// Token: 0x1700069D RID: 1693
			// (get) Token: 0x06004337 RID: 17207 RVA: 0x0015A7B4 File Offset: 0x001589B4
			[Token(Token = "0x1700069D")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004337")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x06004338 RID: 17208 RVA: 0x0015A7C4 File Offset: 0x001589C4
			[Token(Token = "0x6004338")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public ShootCountBuff()
			{
			}
		}

		// Token: 0x02000C87 RID: 3207
		[Token(Token = "0x2000C87")]
		private class ShootBuff : BaseBuff
		{
			// Token: 0x1700069E RID: 1694
			// (get) Token: 0x06004339 RID: 17209 RVA: 0x0015A7D8 File Offset: 0x001589D8
			[Token(Token = "0x1700069E")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004339")]
				[Address(RVA = "0x835050", Offset = "0x833650", VA = "0x180835050", Slot = "4")]
				get
				{
					return PlantType.ObsidianWallNut;
				}
			}

			// Token: 0x1700069F RID: 1695
			// (get) Token: 0x0600433A RID: 17210 RVA: 0x0015A7EC File Offset: 0x001589EC
			[Token(Token = "0x1700069F")]
			public override string Title
			{
				[Token(Token = "0x600433A")]
				[Address(RVA = "0x8386F0", Offset = "0x836CF0", VA = "0x1808386F0", Slot = "5")]
				get
				{
					return "质变：发射";
				}
			}

			// Token: 0x170006A0 RID: 1696
			// (get) Token: 0x0600433B RID: 17211 RVA: 0x0015A800 File Offset: 0x00158A00
			[Token(Token = "0x170006A0")]
			public override string Description
			{
				[Token(Token = "0x600433B")]
				[Address(RVA = "0x8386C0", Offset = "0x836CC0", VA = "0x1808386C0", Slot = "6")]
				get
				{
					return "每次攻击在每行发射一发保龄球";
				}
			}

			// Token: 0x170006A1 RID: 1697
			// (get) Token: 0x0600433C RID: 17212 RVA: 0x0015A814 File Offset: 0x00158A14
			[Token(Token = "0x170006A1")]
			public override Quality Rarity
			{
				[Token(Token = "0x600433C")]
				[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x170006A2 RID: 1698
			// (get) Token: 0x0600433D RID: 17213 RVA: 0x0015A824 File Offset: 0x00158A24
			[Token(Token = "0x170006A2")]
			public override int MaxCount
			{
				[Token(Token = "0x600433D")]
				[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x170006A3 RID: 1699
			// (get) Token: 0x0600433E RID: 17214 RVA: 0x0015A834 File Offset: 0x00158A34
			[Token(Token = "0x170006A3")]
			public override float AppearWeight
			{
				[Token(Token = "0x600433E")]
				[Address(RVA = "0x82E470", Offset = "0x82CA70", VA = "0x18082E470", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600433F RID: 17215 RVA: 0x0015A848 File Offset: 0x00158A48
			[Token(Token = "0x600433F")]
			[Address(RVA = "0x838640", Offset = "0x836C40", VA = "0x180838640", Slot = "7")]
			public override void OnGet()
			{
				ShootingManager instance = ShootingManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}

			// Token: 0x06004340 RID: 17216 RVA: 0x0015A868 File Offset: 0x00158A68
			[Token(Token = "0x6004340")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public ShootBuff()
			{
			}
		}
	}
}
