using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D64 RID: 3428
	[Token(Token = "0x2000D64")]
	public class SuperStar : BaseConfig
	{
		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06004752 RID: 18258 RVA: 0x00168238 File Offset: 0x00166438
		[Token(Token = "0x1700081E")]
		public override string Role
		{
			[Token(Token = "0x6004752")]
			[Address(RVA = "0x8B7CF0", Offset = "0x8B62F0", VA = "0x1808B7CF0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06004753 RID: 18259 RVA: 0x0016824C File Offset: 0x0016644C
		[Token(Token = "0x1700081F")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004753")]
			[Address(RVA = "0x8B7CE0", Offset = "0x8B62E0", VA = "0x1808B7CE0", Slot = "4")]
			get
			{
				return PlantType.SuperStar;
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06004754 RID: 18260 RVA: 0x00168260 File Offset: 0x00166460
		[Token(Token = "0x17000820")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004754")]
			[Address(RVA = "0x8B7BD0", Offset = "0x8B61D0", VA = "0x1808B7BD0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004755 RID: 18261 RVA: 0x0016828C File Offset: 0x0016648C
		[Token(Token = "0x6004755")]
		[Address(RVA = "0x8AD470", Offset = "0x8ABA70", VA = "0x1808AD470", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 4f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x06004756 RID: 18262 RVA: 0x001682C0 File Offset: 0x001664C0
		[Token(Token = "0x6004756")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public SuperStar()
		{
		}
	}
}
