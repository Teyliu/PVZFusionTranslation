using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D71 RID: 3441
	[Token(Token = "0x2000D71")]
	public class UltimateCabbage : BaseConfig
	{
		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06004799 RID: 18329 RVA: 0x0016899C File Offset: 0x00166B9C
		[Token(Token = "0x17000849")]
		public override string Role
		{
			[Token(Token = "0x6004799")]
			[Address(RVA = "0x8C0CD0", Offset = "0x8BF2D0", VA = "0x1808C0CD0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x0600479A RID: 18330 RVA: 0x001689B0 File Offset: 0x00166BB0
		[Token(Token = "0x1700084A")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600479A")]
			[Address(RVA = "0x8C0CC0", Offset = "0x8BF2C0", VA = "0x1808C0CC0", Slot = "4")]
			get
			{
				return PlantType.UltimateCabbage;
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x0600479B RID: 18331 RVA: 0x001689C4 File Offset: 0x00166BC4
		[Token(Token = "0x1700084B")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600479B")]
			[Address(RVA = "0x8C0AA0", Offset = "0x8BF0A0", VA = "0x1808C0AA0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				UltimateCabbage.UniqueUpgrade uniqueUpgrade = new UltimateCabbage.UniqueUpgrade();
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x0600479C RID: 18332 RVA: 0x00168A0C File Offset: 0x00166C0C
		[Token(Token = "0x600479C")]
		[Address(RVA = "0x8C0A40", Offset = "0x8BF040", VA = "0x1808C0A40", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 1f, num2 != 0, num);
			throw new NullReferenceException();
		}

		// Token: 0x0600479D RID: 18333 RVA: 0x00168A34 File Offset: 0x00166C34
		[Token(Token = "0x600479D")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public UltimateCabbage()
		{
		}

		// Token: 0x02000D72 RID: 3442
		[Token(Token = "0x2000D72")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x1700084C RID: 2124
			// (get) Token: 0x0600479E RID: 18334 RVA: 0x00168A48 File Offset: 0x00166C48
			[Token(Token = "0x1700084C")]
			public override string Title
			{
				[Token(Token = "0x600479E")]
				[Address(RVA = "0x8C6E40", Offset = "0x8C5440", VA = "0x1808C6E40", Slot = "5")]
				get
				{
					return "强化：陨星";
				}
			}

			// Token: 0x1700084D RID: 2125
			// (get) Token: 0x0600479F RID: 18335 RVA: 0x00168A5C File Offset: 0x00166C5C
			[Token(Token = "0x1700084D")]
			public override string Description
			{
				[Token(Token = "0x600479F")]
				[Address(RVA = "0x8C6900", Offset = "0x8C4F00", VA = "0x1808C6900", Slot = "6")]
				get
				{
					return base.PlantName + "陨星+1\n陨星锁定全场血量最高的僵尸，落地时造成相当于卷心菜攻击力100%的群体伤害\n然后造成30次伤害，每次伤害对范围内敌方随机单体造成100%的爆炸伤害";
				}
			}

			// Token: 0x1700084E RID: 2126
			// (get) Token: 0x060047A0 RID: 18336 RVA: 0x00168A7C File Offset: 0x00166C7C
			[Token(Token = "0x1700084E")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60047A0")]
				[Address(RVA = "0x8C0CC0", Offset = "0x8BF2C0", VA = "0x1808C0CC0", Slot = "4")]
				get
				{
					return PlantType.UltimateCabbage;
				}
			}

			// Token: 0x1700084F RID: 2127
			// (get) Token: 0x060047A1 RID: 18337 RVA: 0x00168A90 File Offset: 0x00166C90
			[Token(Token = "0x1700084F")]
			public override float AppearWeight
			{
				[Token(Token = "0x60047A1")]
				[Address(RVA = "0x8AAC10", Offset = "0x8A9210", VA = "0x1808AAC10", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060047A2 RID: 18338 RVA: 0x00168AA4 File Offset: 0x00166CA4
			[Token(Token = "0x60047A2")]
			[Address(RVA = "0x8C5E50", Offset = "0x8C4450", VA = "0x1808C5E50", Slot = "7")]
			public override void OnGet()
			{
				ShootingManager instance = ShootingManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}

			// Token: 0x17000850 RID: 2128
			// (get) Token: 0x060047A3 RID: 18339 RVA: 0x00168AC4 File Offset: 0x00166CC4
			[Token(Token = "0x17000850")]
			public override Quality Rarity
			{
				[Token(Token = "0x60047A3")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x060047A4 RID: 18340 RVA: 0x00168AD4 File Offset: 0x00166CD4
			[Token(Token = "0x60047A4")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public UniqueUpgrade()
			{
			}
		}
	}
}
