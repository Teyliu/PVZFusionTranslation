using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D7F RID: 3455
	[Token(Token = "0x2000D7F")]
	public class UltimateSpring : BaseConfig
	{
		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x060047EB RID: 18411 RVA: 0x00169248 File Offset: 0x00167448
		[Token(Token = "0x1700087E")]
		public override string Role
		{
			[Token(Token = "0x60047EB")]
			[Address(RVA = "0x8C3DA0", Offset = "0x8C23A0", VA = "0x1808C3DA0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x060047EC RID: 18412 RVA: 0x0016925C File Offset: 0x0016745C
		[Token(Token = "0x1700087F")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60047EC")]
			[Address(RVA = "0x8B7160", Offset = "0x8B5760", VA = "0x1808B7160", Slot = "4")]
			get
			{
				return PlantType.UltimateSpring;
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x060047ED RID: 18413 RVA: 0x00169270 File Offset: 0x00167470
		[Token(Token = "0x17000880")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60047ED")]
			[Address(RVA = "0x8C3AF0", Offset = "0x8C20F0", VA = "0x1808C3AF0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				UltimateSpring.UniqueUpgrade uniqueUpgrade = new UltimateSpring.UniqueUpgrade();
				int size3 = list._size;
				UltimateSpring.SuperBuff superBuff = new UltimateSpring.SuperBuff();
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x060047EE RID: 18414 RVA: 0x001692C8 File Offset: 0x001674C8
		[Token(Token = "0x60047EE")]
		[Address(RVA = "0x8C3980", Offset = "0x8C1F80", VA = "0x1808C3980", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			bool flag = "{il2cpp field on \"在该模式中，\", offset 0xFFFFFFFFFFFFFFF8}" == typeof(Thrower).TypeHandle;
			InGameText instance = InGameText.Instance;
			int plantType = (int)this.PlantType;
			string text2;
			string text = "在该模式中，" + text2 + "会持续射击鼠标所在位置";
		}

		// Token: 0x060047EF RID: 18415 RVA: 0x00169310 File Offset: 0x00167510
		[Token(Token = "0x60047EF")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public UltimateSpring()
		{
		}

		// Token: 0x02000D80 RID: 3456
		[Token(Token = "0x2000D80")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x17000881 RID: 2177
			// (get) Token: 0x060047F0 RID: 18416 RVA: 0x00169324 File Offset: 0x00167524
			[Token(Token = "0x17000881")]
			public override string Title
			{
				[Token(Token = "0x60047F0")]
				[Address(RVA = "0x8C6D80", Offset = "0x8C5380", VA = "0x1808C6D80", Slot = "5")]
				get
				{
					return "强化：火海";
				}
			}

			// Token: 0x17000882 RID: 2178
			// (get) Token: 0x060047F1 RID: 18417 RVA: 0x00169338 File Offset: 0x00167538
			[Token(Token = "0x17000882")]
			public override string Description
			{
				[Token(Token = "0x60047F1")]
				[Address(RVA = "0x8C6AF0", Offset = "0x8C50F0", VA = "0x1808C6AF0", Slot = "6")]
				get
				{
					return base.PlantName + "火海时间+3秒";
				}
			}

			// Token: 0x17000883 RID: 2179
			// (get) Token: 0x060047F2 RID: 18418 RVA: 0x00169358 File Offset: 0x00167558
			[Token(Token = "0x17000883")]
			public override float AppearWeight
			{
				[Token(Token = "0x60047F2")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000884 RID: 2180
			// (get) Token: 0x060047F3 RID: 18419 RVA: 0x0016936C File Offset: 0x0016756C
			[Token(Token = "0x17000884")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60047F3")]
				[Address(RVA = "0x8B7160", Offset = "0x8B5760", VA = "0x1808B7160", Slot = "4")]
				get
				{
					return PlantType.UltimateSpring;
				}
			}

			// Token: 0x060047F4 RID: 18420 RVA: 0x00169380 File Offset: 0x00167580
			[Token(Token = "0x60047F4")]
			[Address(RVA = "0x8C59B0", Offset = "0x8C3FB0", VA = "0x1808C59B0", Slot = "7")]
			public override void OnGet()
			{
				Plant plant = base.Plant;
				int num = 0;
				if (plant != num)
				{
					Plant plant2 = base.Plant;
				}
			}

			// Token: 0x17000885 RID: 2181
			// (get) Token: 0x060047F5 RID: 18421 RVA: 0x001693B0 File Offset: 0x001675B0
			[Token(Token = "0x17000885")]
			public override Quality Rarity
			{
				[Token(Token = "0x60047F5")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x060047F6 RID: 18422 RVA: 0x001693C0 File Offset: 0x001675C0
			[Token(Token = "0x60047F6")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public UniqueUpgrade()
			{
			}
		}

		// Token: 0x02000D81 RID: 3457
		[Token(Token = "0x2000D81")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x17000886 RID: 2182
			// (get) Token: 0x060047F7 RID: 18423 RVA: 0x001693D4 File Offset: 0x001675D4
			[Token(Token = "0x17000886")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60047F7")]
				[Address(RVA = "0x8B7160", Offset = "0x8B5760", VA = "0x1808B7160", Slot = "4")]
				get
				{
					return PlantType.UltimateSpring;
				}
			}

			// Token: 0x17000887 RID: 2183
			// (get) Token: 0x060047F8 RID: 18424 RVA: 0x001693E8 File Offset: 0x001675E8
			[Token(Token = "0x17000887")]
			public override string Title
			{
				[Token(Token = "0x60047F8")]
				[Address(RVA = "0x8B74B0", Offset = "0x8B5AB0", VA = "0x1808B74B0", Slot = "5")]
				get
				{
					return "质变：火海";
				}
			}

			// Token: 0x17000888 RID: 2184
			// (get) Token: 0x060047F9 RID: 18425 RVA: 0x001693FC File Offset: 0x001675FC
			[Token(Token = "0x17000888")]
			public override string Description
			{
				[Token(Token = "0x60047F9")]
				[Address(RVA = "0x8B6DC0", Offset = "0x8B53C0", VA = "0x1808B6DC0", Slot = "6")]
				get
				{
					return "火神的子弹命中地面时也会生成火海，命中僵尸最多额外分裂2次";
				}
			}

			// Token: 0x17000889 RID: 2185
			// (get) Token: 0x060047FA RID: 18426 RVA: 0x00169410 File Offset: 0x00167610
			[Token(Token = "0x17000889")]
			public override Quality Rarity
			{
				[Token(Token = "0x60047FA")]
				[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x1700088A RID: 2186
			// (get) Token: 0x060047FB RID: 18427 RVA: 0x00169420 File Offset: 0x00167620
			[Token(Token = "0x1700088A")]
			public override int MaxCount
			{
				[Token(Token = "0x60047FB")]
				[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x1700088B RID: 2187
			// (get) Token: 0x060047FC RID: 18428 RVA: 0x00169430 File Offset: 0x00167630
			[Token(Token = "0x1700088B")]
			public override float AppearWeight
			{
				[Token(Token = "0x60047FC")]
				[Address(RVA = "0x8A8BB0", Offset = "0x8A71B0", VA = "0x1808A8BB0", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060047FD RID: 18429 RVA: 0x00169444 File Offset: 0x00167644
			[Token(Token = "0x60047FD")]
			[Address(RVA = "0x8B6620", Offset = "0x8B4C20", VA = "0x1808B6620", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12000));
			}

			// Token: 0x060047FE RID: 18430 RVA: 0x0016946C File Offset: 0x0016766C
			[Token(Token = "0x60047FE")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public SuperBuff()
			{
			}
		}
	}
}
