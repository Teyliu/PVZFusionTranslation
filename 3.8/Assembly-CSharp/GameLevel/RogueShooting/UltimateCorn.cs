using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CAE RID: 3246
	[Token(Token = "0x2000CAE")]
	public class UltimateCorn : BaseConfig
	{
		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x0600440D RID: 17421 RVA: 0x0015C298 File Offset: 0x0015A498
		[Token(Token = "0x17000722")]
		public override string Role
		{
			[Token(Token = "0x600440D")]
			[Address(RVA = "0x8419A0", Offset = "0x83FFA0", VA = "0x1808419A0", Slot = "7")]
			get
			{
				return "辅助";
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x0600440E RID: 17422 RVA: 0x0015C2AC File Offset: 0x0015A4AC
		[Token(Token = "0x17000723")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600440E")]
			[Address(RVA = "0x781460", Offset = "0x77FA60", VA = "0x180781460", Slot = "4")]
			get
			{
				return PlantType.UltimateCorn;
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x0600440F RID: 17423 RVA: 0x0015C2C0 File Offset: 0x0015A4C0
		[Token(Token = "0x17000724")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600440F")]
			[Address(RVA = "0x841780", Offset = "0x83FD80", VA = "0x180841780", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				UltimateCorn.ExtraDamageBuff extraDamageBuff = new UltimateCorn.ExtraDamageBuff();
				int size2 = list._size;
				UltimateCorn.SuperBuff superBuff = new UltimateCorn.SuperBuff();
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06004410 RID: 17424 RVA: 0x0015C30C File Offset: 0x0015A50C
		[Token(Token = "0x6004410")]
		[Address(RVA = "0x841660", Offset = "0x83FC60", VA = "0x180841660", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			plant.AddSpeed(3f);
			TravelMgr instance = TravelMgr.Instance;
			int num = 0;
			instance.GetUltiBuff((UltiBuff)((uint)30), num != 0);
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06004411 RID: 17425 RVA: 0x0015C358 File Offset: 0x0015A558
		[Token(Token = "0x6004411")]
		[Address(RVA = "0x8415B0", Offset = "0x83FBB0", VA = "0x1808415B0")]
		private void Butter(Plant plant)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06004412 RID: 17426 RVA: 0x0015C37C File Offset: 0x0015A57C
		[Token(Token = "0x6004412")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public UltimateCorn()
		{
		}

		// Token: 0x02000CAF RID: 3247
		[Token(Token = "0x2000CAF")]
		private class ExtraDamageBuff : BaseBuff
		{
			// Token: 0x17000725 RID: 1829
			// (get) Token: 0x06004413 RID: 17427 RVA: 0x0015C390 File Offset: 0x0015A590
			[Token(Token = "0x17000725")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004413")]
				[Address(RVA = "0x781460", Offset = "0x77FA60", VA = "0x180781460", Slot = "4")]
				get
				{
					return PlantType.UltimateCorn;
				}
			}

			// Token: 0x17000726 RID: 1830
			// (get) Token: 0x06004414 RID: 17428 RVA: 0x0015C3A4 File Offset: 0x0015A5A4
			[Token(Token = "0x17000726")]
			public override string Title
			{
				[Token(Token = "0x6004414")]
				[Address(RVA = "0x831070", Offset = "0x82F670", VA = "0x180831070", Slot = "5")]
				get
				{
					return "强化：撕裂";
				}
			}

			// Token: 0x17000727 RID: 1831
			// (get) Token: 0x06004415 RID: 17429 RVA: 0x0015C3B8 File Offset: 0x0015A5B8
			[Token(Token = "0x17000727")]
			public override string Description
			{
				[Token(Token = "0x6004415")]
				[Address(RVA = "0x831040", Offset = "0x82F640", VA = "0x180831040", Slot = "6")]
				get
				{
					return "黑洞会对附近的僵尸造成伤害，每拥有一个该词条，伤害比例增加100%";
				}
			}

			// Token: 0x17000728 RID: 1832
			// (get) Token: 0x06004416 RID: 17430 RVA: 0x0015C3CC File Offset: 0x0015A5CC
			[Token(Token = "0x17000728")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004416")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x17000729 RID: 1833
			// (get) Token: 0x06004417 RID: 17431 RVA: 0x0015C3DC File Offset: 0x0015A5DC
			[Token(Token = "0x17000729")]
			public override int MaxCount
			{
				[Token(Token = "0x6004417")]
				[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "8")]
				get
				{
					return 10;
				}
			}

			// Token: 0x1700072A RID: 1834
			// (get) Token: 0x06004418 RID: 17432 RVA: 0x0015C3EC File Offset: 0x0015A5EC
			[Token(Token = "0x1700072A")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004418")]
				[Address(RVA = "0x830000", Offset = "0x82E600", VA = "0x180830000", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004419 RID: 17433 RVA: 0x0015C400 File Offset: 0x0015A600
			[Token(Token = "0x6004419")]
			[Address(RVA = "0x830F30", Offset = "0x82F530", VA = "0x180830F30", Slot = "7")]
			public override void OnGet()
			{
				Action<Plant> <>9__12_ = UltimateCorn.ExtraDamageBuff.<>c.<>9__12_0;
				if (<>9__12_ == 0)
				{
					Action<Plant> action;
					UltimateCorn.ExtraDamageBuff.<>c.<>9__12_0 = action;
				}
				base.SafeModify(<>9__12_);
			}

			// Token: 0x0600441A RID: 17434 RVA: 0x0015C42C File Offset: 0x0015A62C
			[Token(Token = "0x600441A")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public ExtraDamageBuff()
			{
			}
		}

		// Token: 0x02000CB1 RID: 3249
		[Token(Token = "0x2000CB1")]
		private class SuperBuff : BaseBuff
		{
			// Token: 0x1700072B RID: 1835
			// (get) Token: 0x0600441E RID: 17438 RVA: 0x0015C440 File Offset: 0x0015A640
			[Token(Token = "0x1700072B")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600441E")]
				[Address(RVA = "0x781460", Offset = "0x77FA60", VA = "0x180781460", Slot = "4")]
				get
				{
					return PlantType.UltimateCorn;
				}
			}

			// Token: 0x1700072C RID: 1836
			// (get) Token: 0x0600441F RID: 17439 RVA: 0x0015C454 File Offset: 0x0015A654
			[Token(Token = "0x1700072C")]
			public override string Title
			{
				[Token(Token = "0x600441F")]
				[Address(RVA = "0x83A640", Offset = "0x838C40", VA = "0x18083A640", Slot = "5")]
				get
				{
					return "质变：引力";
				}
			}

			// Token: 0x1700072D RID: 1837
			// (get) Token: 0x06004420 RID: 17440 RVA: 0x0015C468 File Offset: 0x0015A668
			[Token(Token = "0x1700072D")]
			public override string Description
			{
				[Token(Token = "0x6004420")]
				[Address(RVA = "0x839E30", Offset = "0x838430", VA = "0x180839E30", Slot = "6")]
				get
				{
					return TravelDictionary.advancedBuffsText[(uint)12007];
				}
			}

			// Token: 0x1700072E RID: 1838
			// (get) Token: 0x06004421 RID: 17441 RVA: 0x0015C48C File Offset: 0x0015A68C
			[Token(Token = "0x1700072E")]
			public override Quality Rarity
			{
				[Token(Token = "0x6004421")]
				[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
				get
				{
					return Quality.diamond;
				}
			}

			// Token: 0x1700072F RID: 1839
			// (get) Token: 0x06004422 RID: 17442 RVA: 0x0015C49C File Offset: 0x0015A69C
			[Token(Token = "0x1700072F")]
			public override int MaxCount
			{
				[Token(Token = "0x6004422")]
				[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
				get
				{
					return 1;
				}
			}

			// Token: 0x17000730 RID: 1840
			// (get) Token: 0x06004423 RID: 17443 RVA: 0x0015C4AC File Offset: 0x0015A6AC
			[Token(Token = "0x17000730")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004423")]
				[Address(RVA = "0x82E470", Offset = "0x82CA70", VA = "0x18082E470", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06004424 RID: 17444 RVA: 0x0015C4C0 File Offset: 0x0015A6C0
			[Token(Token = "0x6004424")]
			[Address(RVA = "0x839D30", Offset = "0x838330", VA = "0x180839D30", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)12007));
			}

			// Token: 0x06004425 RID: 17445 RVA: 0x0015C4E8 File Offset: 0x0015A6E8
			[Token(Token = "0x6004425")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public SuperBuff()
			{
			}
		}
	}
}
