using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D4B RID: 3403
	[Token(Token = "0x2000D4B")]
	public class BigGatling : BaseConfig
	{
		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x060046C7 RID: 18119 RVA: 0x00166E1C File Offset: 0x0016501C
		[Token(Token = "0x170007CF")]
		public override string Role
		{
			[Token(Token = "0x60046C7")]
			[Address(RVA = "0x8A8B20", Offset = "0x8A7120", VA = "0x1808A8B20", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x060046C8 RID: 18120 RVA: 0x00166E30 File Offset: 0x00165030
		[Token(Token = "0x170007D0")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60046C8")]
			[Address(RVA = "0x8A8B10", Offset = "0x8A7110", VA = "0x1808A8B10", Slot = "4")]
			get
			{
				return PlantType.BigGatling;
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x060046C9 RID: 18121 RVA: 0x00166E44 File Offset: 0x00165044
		[Token(Token = "0x170007D1")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60046C9")]
			[Address(RVA = "0x8A8A00", Offset = "0x8A7000", VA = "0x1808A8A00", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060046CA RID: 18122 RVA: 0x00166E70 File Offset: 0x00165070
		[Token(Token = "0x60046CA")]
		[Address(RVA = "0x8A89C0", Offset = "0x8A6FC0", VA = "0x1808A89C0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 9f, num2 != 0, num);
		}

		// Token: 0x060046CB RID: 18123 RVA: 0x00166E98 File Offset: 0x00165098
		[Token(Token = "0x60046CB")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public BigGatling()
		{
		}
	}
}
