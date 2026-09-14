using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D60 RID: 3424
	[Token(Token = "0x2000D60")]
	public class DoomCactus : BaseConfig
	{
		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x0600473C RID: 18236 RVA: 0x00167FA4 File Offset: 0x001661A4
		[Token(Token = "0x17000810")]
		public override string Role
		{
			[Token(Token = "0x600473C")]
			[Address(RVA = "0x8AB000", Offset = "0x8A9600", VA = "0x1808AB000", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x0600473D RID: 18237 RVA: 0x00167FB8 File Offset: 0x001661B8
		[Token(Token = "0x17000811")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600473D")]
			[Address(RVA = "0x8AAFF0", Offset = "0x8A95F0", VA = "0x1808AAFF0", Slot = "4")]
			get
			{
				return PlantType.DoomCactus;
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x0600473E RID: 18238 RVA: 0x00167FCC File Offset: 0x001661CC
		[Token(Token = "0x17000812")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600473E")]
			[Address(RVA = "0x8AAEE0", Offset = "0x8A94E0", VA = "0x1808AAEE0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x0600473F RID: 18239 RVA: 0x00167FF8 File Offset: 0x001661F8
		[Token(Token = "0x600473F")]
		[Address(RVA = "0x88FD80", Offset = "0x88E380", VA = "0x18088FD80", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 9f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x06004740 RID: 18240 RVA: 0x0016802C File Offset: 0x0016622C
		[Token(Token = "0x6004740")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public DoomCactus()
		{
		}
	}
}
