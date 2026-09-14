using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CF0 RID: 3312
	[Token(Token = "0x2000CF0")]
	public class UltimateChomper : BaseConfig
	{
		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x060044C2 RID: 17602 RVA: 0x001636C8 File Offset: 0x001618C8
		[Token(Token = "0x1700068B")]
		public override string Role
		{
			[Token(Token = "0x60044C2")]
			[Address(RVA = "0x8C12A0", Offset = "0x8BF8A0", VA = "0x1808C12A0", Slot = "7")]
			get
			{
				return "输出/防御";
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x060044C3 RID: 17603 RVA: 0x001636DC File Offset: 0x001618DC
		[Token(Token = "0x1700068C")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60044C3")]
			[Address(RVA = "0x7E8180", Offset = "0x7E6780", VA = "0x1807E8180", Slot = "4")]
			get
			{
				return PlantType.UltimateChomper;
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x060044C4 RID: 17604 RVA: 0x001636F0 File Offset: 0x001618F0
		[Token(Token = "0x1700068D")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60044C4")]
			[Address(RVA = "0x8C0FF0", Offset = "0x8BF5F0", VA = "0x1808C0FF0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				UltimateChomper.UniqueUpgrade uniqueUpgrade = new UltimateChomper.UniqueUpgrade();
				int size3 = list._size;
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x060044C5 RID: 17605 RVA: 0x00163744 File Offset: 0x00161944
		[Token(Token = "0x60044C5")]
		[Address(RVA = "0x8C0FB0", Offset = "0x8BF5B0", VA = "0x1808C0FB0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 3f, num2 != 0, num);
		}

		// Token: 0x060044C6 RID: 17606 RVA: 0x0016376C File Offset: 0x0016196C
		[Token(Token = "0x60044C6")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public UltimateChomper()
		{
		}

		// Token: 0x02000CF1 RID: 3313
		[Token(Token = "0x2000CF1")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x1700068E RID: 1678
			// (get) Token: 0x060044C7 RID: 17607 RVA: 0x00163780 File Offset: 0x00161980
			[Token(Token = "0x1700068E")]
			public override string Title
			{
				[Token(Token = "0x60044C7")]
				[Address(RVA = "0x8C6DE0", Offset = "0x8C53E0", VA = "0x1808C6DE0", Slot = "5")]
				get
				{
					return "强化：百分比伤害";
				}
			}

			// Token: 0x1700068F RID: 1679
			// (get) Token: 0x060044C8 RID: 17608 RVA: 0x00163794 File Offset: 0x00161994
			[Token(Token = "0x1700068F")]
			public override string Description
			{
				[Token(Token = "0x60044C8")]
				[Address(RVA = "0x8C68B0", Offset = "0x8C4EB0", VA = "0x1808C68B0", Slot = "6")]
				get
				{
					return base.PlantName + "百分比伤害+5%";
				}
			}

			// Token: 0x17000690 RID: 1680
			// (get) Token: 0x060044C9 RID: 17609 RVA: 0x001637B4 File Offset: 0x001619B4
			[Token(Token = "0x17000690")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60044C9")]
				[Address(RVA = "0x7E8180", Offset = "0x7E6780", VA = "0x1807E8180", Slot = "4")]
				get
				{
					return PlantType.UltimateChomper;
				}
			}

			// Token: 0x17000691 RID: 1681
			// (get) Token: 0x060044CA RID: 17610 RVA: 0x001637C8 File Offset: 0x001619C8
			[Token(Token = "0x17000691")]
			public override float AppearWeight
			{
				[Token(Token = "0x60044CA")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060044CB RID: 17611 RVA: 0x001637DC File Offset: 0x001619DC
			[Token(Token = "0x60044CB")]
			[Address(RVA = "0x8C5930", Offset = "0x8C3F30", VA = "0x1808C5930", Slot = "7")]
			public override void OnGet()
			{
				ShootingManager instance = ShootingManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}

			// Token: 0x17000692 RID: 1682
			// (get) Token: 0x060044CC RID: 17612 RVA: 0x001637FC File Offset: 0x001619FC
			[Token(Token = "0x17000692")]
			public override Quality Rarity
			{
				[Token(Token = "0x60044CC")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x060044CD RID: 17613 RVA: 0x0016380C File Offset: 0x00161A0C
			[Token(Token = "0x60044CD")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public UniqueUpgrade()
			{
			}
		}
	}
}
