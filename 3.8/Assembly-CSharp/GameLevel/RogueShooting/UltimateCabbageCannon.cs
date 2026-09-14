using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C9E RID: 3230
	[Token(Token = "0x2000C9E")]
	public class UltimateCabbageCannon : BaseConfig
	{
		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x060043AD RID: 17325 RVA: 0x0015B724 File Offset: 0x00159924
		[Token(Token = "0x170006E2")]
		public override string Role
		{
			[Token(Token = "0x60043AD")]
			[Address(RVA = "0x840CF0", Offset = "0x83F2F0", VA = "0x180840CF0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x060043AE RID: 17326 RVA: 0x0015B738 File Offset: 0x00159938
		[Token(Token = "0x170006E3")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60043AE")]
			[Address(RVA = "0x840CE0", Offset = "0x83F2E0", VA = "0x180840CE0", Slot = "4")]
			get
			{
				return PlantType.UltimateCabbageCannon;
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x060043AF RID: 17327 RVA: 0x0015B74C File Offset: 0x0015994C
		[Token(Token = "0x170006E4")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60043AF")]
			[Address(RVA = "0x840AC0", Offset = "0x83F0C0", VA = "0x180840AC0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				UltimateCabbageCannon.UniqueUpgrade uniqueUpgrade = new UltimateCabbageCannon.UniqueUpgrade();
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x060043B0 RID: 17328 RVA: 0x0015B794 File Offset: 0x00159994
		[Token(Token = "0x60043B0")]
		[Address(RVA = "0x82EE90", Offset = "0x82D490", VA = "0x18082EE90", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 1f, num2 != 0, num);
		}

		// Token: 0x060043B1 RID: 17329 RVA: 0x0015B7BC File Offset: 0x001599BC
		[Token(Token = "0x60043B1")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public UltimateCabbageCannon()
		{
		}

		// Token: 0x02000C9F RID: 3231
		[Token(Token = "0x2000C9F")]
		private class UniqueUpgrade : BaseBuff
		{
			// Token: 0x170006E5 RID: 1765
			// (get) Token: 0x060043B2 RID: 17330 RVA: 0x0015B7D0 File Offset: 0x001599D0
			[Token(Token = "0x170006E5")]
			public override string Title
			{
				[Token(Token = "0x60043B2")]
				[Address(RVA = "0x846980", Offset = "0x844F80", VA = "0x180846980", Slot = "5")]
				get
				{
					return "强化：火炮";
				}
			}

			// Token: 0x170006E6 RID: 1766
			// (get) Token: 0x060043B3 RID: 17331 RVA: 0x0015B7E4 File Offset: 0x001599E4
			[Token(Token = "0x170006E6")]
			public override string Description
			{
				[Token(Token = "0x60043B3")]
				[Address(RVA = "0x846420", Offset = "0x844A20", VA = "0x180846420", Slot = "6")]
				get
				{
					return base.PlantName + "最大散射数+10";
				}
			}

			// Token: 0x170006E7 RID: 1767
			// (get) Token: 0x060043B4 RID: 17332 RVA: 0x0015B804 File Offset: 0x00159A04
			[Token(Token = "0x170006E7")]
			public override PlantType ShowType
			{
				[Token(Token = "0x60043B4")]
				[Address(RVA = "0x840CE0", Offset = "0x83F2E0", VA = "0x180840CE0", Slot = "4")]
				get
				{
					return PlantType.UltimateCabbageCannon;
				}
			}

			// Token: 0x170006E8 RID: 1768
			// (get) Token: 0x060043B5 RID: 17333 RVA: 0x0015B818 File Offset: 0x00159A18
			[Token(Token = "0x170006E8")]
			public override float AppearWeight
			{
				[Token(Token = "0x60043B5")]
				[Address(RVA = "0x830000", Offset = "0x82E600", VA = "0x180830000", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060043B6 RID: 17334 RVA: 0x0015B82C File Offset: 0x00159A2C
			[Token(Token = "0x60043B6")]
			[Address(RVA = "0x845B30", Offset = "0x844130", VA = "0x180845B30", Slot = "7")]
			public override void OnGet()
			{
				ShootingManager instance = ShootingManager.Instance;
				bool flag;
				if (flag)
				{
				}
			}

			// Token: 0x170006E9 RID: 1769
			// (get) Token: 0x060043B7 RID: 17335 RVA: 0x0015B84C File Offset: 0x00159A4C
			[Token(Token = "0x170006E9")]
			public override Quality Rarity
			{
				[Token(Token = "0x60043B7")]
				[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
				get
				{
					return Quality.gold;
				}
			}

			// Token: 0x060043B8 RID: 17336 RVA: 0x0015B85C File Offset: 0x00159A5C
			[Token(Token = "0x60043B8")]
			[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
			public UniqueUpgrade()
			{
			}
		}
	}
}
