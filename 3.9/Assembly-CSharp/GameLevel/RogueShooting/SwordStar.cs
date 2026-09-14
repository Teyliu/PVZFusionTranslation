using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D6B RID: 3435
	[Token(Token = "0x2000D6B")]
	public class SwordStar : BaseConfig
	{
		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06004776 RID: 18294 RVA: 0x001685AC File Offset: 0x001667AC
		[Token(Token = "0x17000832")]
		public override string Role
		{
			[Token(Token = "0x6004776")]
			[Address(RVA = "0x8B8860", Offset = "0x8B6E60", VA = "0x1808B8860", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06004777 RID: 18295 RVA: 0x001685C0 File Offset: 0x001667C0
		[Token(Token = "0x17000833")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004777")]
			[Address(RVA = "0x8B8850", Offset = "0x8B6E50", VA = "0x1808B8850", Slot = "4")]
			get
			{
				return PlantType.SwordStar;
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06004778 RID: 18296 RVA: 0x001685D4 File Offset: 0x001667D4
		[Token(Token = "0x17000834")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004778")]
			[Address(RVA = "0x8B8740", Offset = "0x8B6D40", VA = "0x1808B8740", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004779 RID: 18297 RVA: 0x00168600 File Offset: 0x00166800
		[Token(Token = "0x6004779")]
		[Address(RVA = "0x8AD470", Offset = "0x8ABA70", VA = "0x1808AD470", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 4f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x0600477A RID: 18298 RVA: 0x00168634 File Offset: 0x00166834
		[Token(Token = "0x600477A")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public SwordStar()
		{
		}
	}
}
