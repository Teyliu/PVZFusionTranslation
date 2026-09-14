using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C9B RID: 3227
	[Token(Token = "0x2000C9B")]
	public class UltimateCabbage : BaseConfig
	{
		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x0600439C RID: 17308 RVA: 0x0015B52C File Offset: 0x0015972C
		[Token(Token = "0x170006D7")]
		public override string Role
		{
			[Token(Token = "0x600439C")]
			[Address(RVA = "0x840FB0", Offset = "0x83F5B0", VA = "0x180840FB0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x0600439D RID: 17309 RVA: 0x0015B540 File Offset: 0x00159740
		[Token(Token = "0x170006D8")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600439D")]
			[Address(RVA = "0x840FA0", Offset = "0x83F5A0", VA = "0x180840FA0", Slot = "4")]
			get
			{
				return PlantType.UltimateCabbage;
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x0600439E RID: 17310 RVA: 0x0015B554 File Offset: 0x00159754
		[Token(Token = "0x170006D9")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600439E")]
			[Address(RVA = "0x840D80", Offset = "0x83F380", VA = "0x180840D80", Slot = "5")]
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

		// Token: 0x0600439F RID: 17311 RVA: 0x0015B59C File Offset: 0x0015979C
		[Token(Token = "0x600439F")]
		[Address(RVA = "0x840D20", Offset = "0x83F320", VA = "0x180840D20", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 1f, num2 != 0, num);
			throw new NullReferenceException();
		}

		// Token: 0x060043A0 RID: 17312 RVA: 0x0015B5C4 File Offset: 0x001597C4
		[Token(Token = "0x60043A0")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public UltimateCabbage()
		{
		}

		// Token: 0x02000C9C RID: 3228
		[Token(Token = "0x2000C9C")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x170006DA RID: 1754
			// (get) Token: 0x060043A1 RID: 17313 RVA: 0x0015B5D8 File Offset: 0x001597D8
			[Token(Token = "0x170006DA")]
			public override string Title
			{
				[Token(Token = "0x60043A1")]
				[Address(RVA = "0x846890", Offset = "0x844E90", VA = "0x180846890", Slot = "5")]
				get
				{
					return "强化：陨星";
				}
			}

			// Token: 0x170006DB RID: 1755
			// (get) Token: 0x060043A2 RID: 17314 RVA: 0x0015B5EC File Offset: 0x001597EC
			[Token(Token = "0x170006DB")]
			public override string Description
			{
				[Token(Token = "0x60043A2")]
				[Address(RVA = "0x846380", Offset = "0x844980", VA = "0x180846380", Slot = "6")]
				get
				{
					return base.PlantName + "陨星+1\n陨星锁定全场血量最高的僵尸，落地时造成相当于卷心菜攻击力100%的群体伤害\n然后造成30次伤害，每次伤害对范围内敌方随机单体造成100%的爆炸伤害";
				}
			}

			// Token: 0x170006DC RID: 1756
			// (get) Token: 0x060043A3 RID: 17315 RVA: 0x0015B60C File Offset: 0x0015980C
			[Token(Token = "0x170006DC")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60043A3")]
				[Address(RVA = "0x840FA0", Offset = "0x83F5A0", VA = "0x180840FA0", Slot = "4")]
				get
				{
					return PlantType.UltimateCabbage;
				}
			}

			// Token: 0x170006DD RID: 1757
			// (get) Token: 0x060043A4 RID: 17316 RVA: 0x0015B620 File Offset: 0x00159820
			[Token(Token = "0x170006DD")]
			public override float AppearWeight
			{
				[Token(Token = "0x60043A4")]
				[Address(RVA = "0x830000", Offset = "0x82E600", VA = "0x180830000", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060043A5 RID: 17317 RVA: 0x0015B634 File Offset: 0x00159834
			[Token(Token = "0x60043A5")]
			[Address(RVA = "0x845AC0", Offset = "0x8440C0", VA = "0x180845AC0", Slot = "7")]
			public override void OnGet()
			{
				ShootingManager instance = ShootingManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}

			// Token: 0x170006DE RID: 1758
			// (get) Token: 0x060043A6 RID: 17318 RVA: 0x0015B654 File Offset: 0x00159854
			[Token(Token = "0x170006DE")]
			public override Quality Rarity
			{
				[Token(Token = "0x60043A6")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x060043A7 RID: 17319 RVA: 0x0015B664 File Offset: 0x00159864
			[Token(Token = "0x60043A7")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public UniqueUpgrade()
			{
			}
		}
	}
}
