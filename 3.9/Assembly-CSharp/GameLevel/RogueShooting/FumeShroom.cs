using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D1D RID: 3357
	[Token(Token = "0x2000D1D")]
	public class FumeShroom : BaseConfig
	{
		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x060045BE RID: 17854 RVA: 0x00165228 File Offset: 0x00163428
		[Token(Token = "0x17000727")]
		public override string Role
		{
			[Token(Token = "0x60045BE")]
			[Address(RVA = "0x8AC4E0", Offset = "0x8AAAE0", VA = "0x1808AC4E0", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x060045BF RID: 17855 RVA: 0x0016523C File Offset: 0x0016343C
		[Token(Token = "0x17000728")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60045BF")]
			[Address(RVA = "0x3FA3D0", Offset = "0x3F89D0", VA = "0x1803FA3D0", Slot = "4")]
			get
			{
				return PlantType.FumeShroom;
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x060045C0 RID: 17856 RVA: 0x0016524C File Offset: 0x0016344C
		[Token(Token = "0x17000729")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60045C0")]
			[Address(RVA = "0x8AC2C0", Offset = "0x8AA8C0", VA = "0x1808AC2C0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x060045C1 RID: 17857 RVA: 0x00165288 File Offset: 0x00163488
		[Token(Token = "0x60045C1")]
		[Address(RVA = "0x8AC280", Offset = "0x8AA880", VA = "0x1808AC280", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 14f, num2 != 0, num);
		}

		// Token: 0x060045C2 RID: 17858 RVA: 0x001652B0 File Offset: 0x001634B0
		[Token(Token = "0x60045C2")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public FumeShroom()
		{
		}
	}
}
