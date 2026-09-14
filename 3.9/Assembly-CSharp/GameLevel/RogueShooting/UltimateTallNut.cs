using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CF3 RID: 3315
	[Token(Token = "0x2000CF3")]
	public class UltimateTallNut : BaseConfig
	{
		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x060044D3 RID: 17619 RVA: 0x00163898 File Offset: 0x00161A98
		[Token(Token = "0x17000696")]
		public override string Role
		{
			[Token(Token = "0x60044D3")]
			[Address(RVA = "0x8C47E0", Offset = "0x8C2DE0", VA = "0x1808C47E0", Slot = "7")]
			get
			{
				return "防御";
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x060044D4 RID: 17620 RVA: 0x001638AC File Offset: 0x00161AAC
		[Token(Token = "0x17000697")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60044D4")]
			[Address(RVA = "0x8AD7C0", Offset = "0x8ABDC0", VA = "0x1808AD7C0", Slot = "4")]
			get
			{
				return PlantType.UltimateTallNut;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x060044D5 RID: 17621 RVA: 0x001638C0 File Offset: 0x00161AC0
		[Token(Token = "0x17000698")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60044D5")]
			[Address(RVA = "0x8C4650", Offset = "0x8C2C50", VA = "0x1808C4650", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UltimateTallNut.ReduceDamageBuff reduceDamageBuff = new UltimateTallNut.ReduceDamageBuff();
				int size = list._size;
				UltimateTallNut.HolographicBuff holographicBuff = new UltimateTallNut.HolographicBuff();
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060044D6 RID: 17622 RVA: 0x00163900 File Offset: 0x00161B00
		[Token(Token = "0x60044D6")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x060044D7 RID: 17623 RVA: 0x00163910 File Offset: 0x00161B10
		[Token(Token = "0x60044D7")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public UltimateTallNut()
		{
		}

		// Token: 0x02000CF4 RID: 3316
		[Token(Token = "0x2000CF4")]
		private class ReduceDamageBuff : BaseBuff
		{
			// Token: 0x17000699 RID: 1689
			// (get) Token: 0x060044D8 RID: 17624 RVA: 0x00163924 File Offset: 0x00161B24
			[Token(Token = "0x17000699")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60044D8")]
				[Address(RVA = "0x8AD7C0", Offset = "0x8ABDC0", VA = "0x1808AD7C0", Slot = "4")]
				get
				{
					return PlantType.UltimateTallNut;
				}
			}

			// Token: 0x1700069A RID: 1690
			// (get) Token: 0x060044D9 RID: 17625 RVA: 0x00163938 File Offset: 0x00161B38
			[Token(Token = "0x1700069A")]
			public override string Title
			{
				[Token(Token = "0x60044D9")]
				[Address(RVA = "0x8B2D30", Offset = "0x8B1330", VA = "0x1808B2D30", Slot = "5")]
				get
				{
					return "强化：减伤";
				}
			}

			// Token: 0x1700069B RID: 1691
			// (get) Token: 0x060044DA RID: 17626 RVA: 0x0016394C File Offset: 0x00161B4C
			[Token(Token = "0x1700069B")]
			public override string Description
			{
				[Token(Token = "0x60044DA")]
				[Address(RVA = "0x8B2D00", Offset = "0x8B1300", VA = "0x1808B2D00", Slot = "6")]
				get
				{
					return "植物获得9.9%伤害减免";
				}
			}

			// Token: 0x1700069C RID: 1692
			// (get) Token: 0x060044DB RID: 17627 RVA: 0x00163960 File Offset: 0x00161B60
			[Token(Token = "0x1700069C")]
			public override bool Passive
			{
				[Token(Token = "0x60044DB")]
				[Address(RVA = "0x3F1E60", Offset = "0x3F0460", VA = "0x1803F1E60", Slot = "10")]
				get
				{
					return true;
				}
			}

			// Token: 0x060044DC RID: 17628 RVA: 0x00163970 File Offset: 0x00161B70
			[Token(Token = "0x60044DC")]
			[Address(RVA = "0x8B2CA0", Offset = "0x8B12A0", VA = "0x1808B2CA0", Slot = "7")]
			public override void OnGet()
			{
				TravelMgr instance = TravelMgr.Instance;
				float damageReduction = instance.damageReduction;
				instance.damageReduction = damageReduction;
			}

			// Token: 0x1700069D RID: 1693
			// (get) Token: 0x060044DD RID: 17629 RVA: 0x0016399C File Offset: 0x00161B9C
			[Token(Token = "0x1700069D")]
			public override Quality Rarity
			{
				[Token(Token = "0x60044DD")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x060044DE RID: 17630 RVA: 0x001639AC File Offset: 0x00161BAC
			[Token(Token = "0x60044DE")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public ReduceDamageBuff()
			{
			}
		}

		// Token: 0x02000CF5 RID: 3317
		[Token(Token = "0x2000CF5")]
		private class HolographicBuff : BaseBuff
		{
			// Token: 0x1700069E RID: 1694
			// (get) Token: 0x060044DF RID: 17631 RVA: 0x001639C0 File Offset: 0x00161BC0
			[Token(Token = "0x1700069E")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60044DF")]
				[Address(RVA = "0x8AD7C0", Offset = "0x8ABDC0", VA = "0x1808AD7C0", Slot = "4")]
				get
				{
					return PlantType.UltimateTallNut;
				}
			}

			// Token: 0x1700069F RID: 1695
			// (get) Token: 0x060044E0 RID: 17632 RVA: 0x001639D4 File Offset: 0x00161BD4
			[Token(Token = "0x1700069F")]
			public override string Title
			{
				[Token(Token = "0x60044E0")]
				[Address(RVA = "0x8AD7D0", Offset = "0x8ABDD0", VA = "0x1808AD7D0", Slot = "5")]
				get
				{
					return "强化：分身";
				}
			}

			// Token: 0x170006A0 RID: 1696
			// (get) Token: 0x060044E1 RID: 17633 RVA: 0x001639E8 File Offset: 0x00161BE8
			[Token(Token = "0x170006A0")]
			public override string Description
			{
				[Token(Token = "0x60044E1")]
				[Address(RVA = "0x8AD790", Offset = "0x8ABD90", VA = "0x1808AD790", Slot = "6")]
				get
				{
					return "全息黑高数量+1";
				}
			}

			// Token: 0x170006A1 RID: 1697
			// (get) Token: 0x060044E2 RID: 17634 RVA: 0x001639FC File Offset: 0x00161BFC
			[Token(Token = "0x170006A1")]
			public override bool Passive
			{
				[Token(Token = "0x60044E2")]
				[Address(RVA = "0x3F1E60", Offset = "0x3F0460", VA = "0x1803F1E60", Slot = "10")]
				get
				{
					return true;
				}
			}

			// Token: 0x060044E3 RID: 17635 RVA: 0x00163A0C File Offset: 0x00161C0C
			[Token(Token = "0x60044E3")]
			[Address(RVA = "0x8AD610", Offset = "0x8ABC10", VA = "0x1808AD610", Slot = "7")]
			public override void OnGet()
			{
				int num = 0;
				if (ShootingManager.Instance.TryGetPlant((PlantType)((uint)913), num))
				{
					CreatePlant instance = CreatePlant.Instance;
					bool flag = "{il2cpp field on {'constant9' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StackPointer)}, offset 0xFFFFFFFFFFFFFFF8}" == typeof(HolographicPlant).TypeHandle;
				}
			}

			// Token: 0x170006A2 RID: 1698
			// (get) Token: 0x060044E4 RID: 17636 RVA: 0x00163A4C File Offset: 0x00161C4C
			[Token(Token = "0x170006A2")]
			public override Quality Rarity
			{
				[Token(Token = "0x60044E4")]
				[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x060044E5 RID: 17637 RVA: 0x00163A5C File Offset: 0x00161C5C
			[Token(Token = "0x60044E5")]
			[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
			public HolographicBuff()
			{
			}
		}
	}
}
