using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D61 RID: 3425
	[Token(Token = "0x2000D61")]
	public class UltimateCactus : BaseConfig
	{
		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06004741 RID: 18241 RVA: 0x00168040 File Offset: 0x00166240
		[Token(Token = "0x17000813")]
		public override string Role
		{
			[Token(Token = "0x6004741")]
			[Address(RVA = "0x8C0F80", Offset = "0x8BF580", VA = "0x1808C0F80", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06004742 RID: 18242 RVA: 0x00168054 File Offset: 0x00166254
		[Token(Token = "0x17000814")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004742")]
			[Address(RVA = "0x8C0F70", Offset = "0x8BF570", VA = "0x1808C0F70", Slot = "4")]
			get
			{
				return PlantType.UltimateCactus;
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06004743 RID: 18243 RVA: 0x00168068 File Offset: 0x00166268
		[Token(Token = "0x17000815")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004743")]
			[Address(RVA = "0x8C0D50", Offset = "0x8BF350", VA = "0x1808C0D50", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				UltimateCactus.UniqueUpgrade uniqueUpgrade = new UltimateCactus.UniqueUpgrade();
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06004744 RID: 18244 RVA: 0x001680B0 File Offset: 0x001662B0
		[Token(Token = "0x6004744")]
		[Address(RVA = "0x8C0D00", Offset = "0x8BF300", VA = "0x1808C0D00", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 3f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x06004745 RID: 18245 RVA: 0x001680E4 File Offset: 0x001662E4
		[Token(Token = "0x6004745")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public UltimateCactus()
		{
		}

		// Token: 0x02000D62 RID: 3426
		[Token(Token = "0x2000D62")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x17000816 RID: 2070
			// (get) Token: 0x06004746 RID: 18246 RVA: 0x001680F8 File Offset: 0x001662F8
			[Token(Token = "0x17000816")]
			public override string Title
			{
				[Token(Token = "0x6004746")]
				[Address(RVA = "0x8C6ED0", Offset = "0x8C54D0", VA = "0x1808C6ED0", Slot = "5")]
				get
				{
					return "强化：大招";
				}
			}

			// Token: 0x17000817 RID: 2071
			// (get) Token: 0x06004747 RID: 18247 RVA: 0x0016810C File Offset: 0x0016630C
			[Token(Token = "0x17000817")]
			public override string Description
			{
				[Token(Token = "0x6004747")]
				[Address(RVA = "0x8C6BE0", Offset = "0x8C51E0", VA = "0x1808C6BE0", Slot = "6")]
				get
				{
					return base.PlantName + "大招所需杀敌数-20";
				}
			}

			// Token: 0x17000818 RID: 2072
			// (get) Token: 0x06004748 RID: 18248 RVA: 0x0016812C File Offset: 0x0016632C
			[Token(Token = "0x17000818")]
			public override float AppearWeight
			{
				[Token(Token = "0x6004748")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000819 RID: 2073
			// (get) Token: 0x06004749 RID: 18249 RVA: 0x00168140 File Offset: 0x00166340
			[Token(Token = "0x17000819")]
			public override PlantType ShowType
			{
				[Token(Token = "0x6004749")]
				[Address(RVA = "0x8C0F70", Offset = "0x8BF570", VA = "0x1808C0F70", Slot = "4")]
				get
				{
					return PlantType.UltimateCactus;
				}
			}

			// Token: 0x0600474A RID: 18250 RVA: 0x00168154 File Offset: 0x00166354
			[Token(Token = "0x600474A")]
			[Address(RVA = "0x8C5FD0", Offset = "0x8C45D0", VA = "0x1808C5FD0", Slot = "7")]
			public override void OnGet()
			{
				ShootingManager instance = ShootingManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}

			// Token: 0x1700081A RID: 2074
			// (get) Token: 0x0600474B RID: 18251 RVA: 0x00168174 File Offset: 0x00166374
			[Token(Token = "0x1700081A")]
			public override Quality Rarity
			{
				[Token(Token = "0x600474B")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x0600474C RID: 18252 RVA: 0x00168184 File Offset: 0x00166384
			[Token(Token = "0x600474C")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public UniqueUpgrade()
			{
			}
		}
	}
}
