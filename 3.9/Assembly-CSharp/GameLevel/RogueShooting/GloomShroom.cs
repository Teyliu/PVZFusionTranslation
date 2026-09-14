using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D27 RID: 3367
	[Token(Token = "0x2000D27")]
	public class GloomShroom : BaseConfig
	{
		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x060045FA RID: 17914 RVA: 0x00165840 File Offset: 0x00163A40
		[Token(Token = "0x1700074E")]
		public override string Role
		{
			[Token(Token = "0x60045FA")]
			[Address(RVA = "0x8AC770", Offset = "0x8AAD70", VA = "0x1808AC770", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x060045FB RID: 17915 RVA: 0x00165854 File Offset: 0x00163A54
		[Token(Token = "0x1700074F")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60045FB")]
			[Address(RVA = "0x8AC760", Offset = "0x8AAD60", VA = "0x1808AC760", Slot = "4")]
			get
			{
				return PlantType.GloomShroom;
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x060045FC RID: 17916 RVA: 0x00165868 File Offset: 0x00163A68
		[Token(Token = "0x17000750")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60045FC")]
			[Address(RVA = "0x8AC650", Offset = "0x8AAC50", VA = "0x1808AC650", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060045FD RID: 17917 RVA: 0x00165894 File Offset: 0x00163A94
		[Token(Token = "0x60045FD")]
		[Address(RVA = "0x8A89C0", Offset = "0x8A6FC0", VA = "0x1808A89C0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 9f, num2 != 0, num);
		}

		// Token: 0x060045FE RID: 17918 RVA: 0x001658BC File Offset: 0x00163ABC
		[Token(Token = "0x60045FE")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public GloomShroom()
		{
		}
	}
}
