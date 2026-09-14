using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C2C RID: 3116
	[Token(Token = "0x2000C2C")]
	public class UltimateChomper : BaseConfig
	{
		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06004124 RID: 16676 RVA: 0x001568C4 File Offset: 0x00154AC4
		[Token(Token = "0x1700054F")]
		public override string Role
		{
			[Token(Token = "0x6004124")]
			[Address(RVA = "0x841580", Offset = "0x83FB80", VA = "0x180841580", Slot = "7")]
			get
			{
				return "输出/防御";
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06004125 RID: 16677 RVA: 0x001568D8 File Offset: 0x00154AD8
		[Token(Token = "0x17000550")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004125")]
			[Address(RVA = "0x7812D0", Offset = "0x77F8D0", VA = "0x1807812D0", Slot = "4")]
			get
			{
				return PlantType.UltimateChomper;
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06004126 RID: 16678 RVA: 0x001568EC File Offset: 0x00154AEC
		[Token(Token = "0x17000551")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004126")]
			[Address(RVA = "0x8412D0", Offset = "0x83F8D0", VA = "0x1808412D0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				UltimateChomper.UniqueUpgrade uniqueUpgrade = new UltimateChomper.UniqueUpgrade();
				int size3 = list._size;
				StarUpBuff starUpBuff;
				starUpBuff.targetType = (PlantType)((ulong)903L);
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x06004127 RID: 16679 RVA: 0x0015694C File Offset: 0x00154B4C
		[Token(Token = "0x6004127")]
		[Address(RVA = "0x841290", Offset = "0x83F890", VA = "0x180841290", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 3f, num2 != 0, num);
		}

		// Token: 0x06004128 RID: 16680 RVA: 0x00156974 File Offset: 0x00154B74
		[Token(Token = "0x6004128")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public UltimateChomper()
		{
		}

		// Token: 0x02000C2D RID: 3117
		[Token(Token = "0x2000C2D")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x17000552 RID: 1362
			// (get) Token: 0x06004129 RID: 16681 RVA: 0x00156988 File Offset: 0x00154B88
			[Token(Token = "0x17000552")]
			public override string Title
			{
				[Token(Token = "0x6004129")]
				[Address(RVA = "0x846830", Offset = "0x844E30", VA = "0x180846830", Slot = "5")]
				get
				{
					return "强化：百分比伤害";
				}
			}

			// Token: 0x17000553 RID: 1363
			// (get) Token: 0x0600412A RID: 16682 RVA: 0x0015699C File Offset: 0x00154B9C
			[Token(Token = "0x17000553")]
			public override string Description
			{
				[Token(Token = "0x600412A")]
				[Address(RVA = "0x846330", Offset = "0x844930", VA = "0x180846330", Slot = "6")]
				get
				{
					return base.PlantName + "百分比伤害+5%";
				}
			}

			// Token: 0x17000554 RID: 1364
			// (get) Token: 0x0600412B RID: 16683 RVA: 0x001569BC File Offset: 0x00154BBC
			[Token(Token = "0x17000554")]
			public override PlantType ShowType
			{
				[Token(Token = "0x600412B")]
				[Address(RVA = "0x7812D0", Offset = "0x77F8D0", VA = "0x1807812D0", Slot = "4")]
				get
				{
					return PlantType.UltimateChomper;
				}
			}

			// Token: 0x17000555 RID: 1365
			// (get) Token: 0x0600412C RID: 16684 RVA: 0x001569D0 File Offset: 0x00154BD0
			[Token(Token = "0x17000555")]
			public override float AppearWeight
			{
				[Token(Token = "0x600412C")]
				[Address(RVA = "0x830000", Offset = "0x82E600", VA = "0x180830000", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600412D RID: 16685 RVA: 0x001569E4 File Offset: 0x00154BE4
			[Token(Token = "0x600412D")]
			[Address(RVA = "0x8456B0", Offset = "0x843CB0", VA = "0x1808456B0", Slot = "7")]
			public override void OnGet()
			{
				ShootingManager instance = ShootingManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}

			// Token: 0x17000556 RID: 1366
			// (get) Token: 0x0600412E RID: 16686 RVA: 0x00156A04 File Offset: 0x00154C04
			[Token(Token = "0x17000556")]
			public override Quality Rarity
			{
				[Token(Token = "0x600412E")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x0600412F RID: 16687 RVA: 0x00156A14 File Offset: 0x00154C14
			[Token(Token = "0x600412F")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public UniqueUpgrade()
			{
			}
		}
	}
}
