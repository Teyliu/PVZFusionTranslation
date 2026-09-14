using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D43 RID: 3395
	[Token(Token = "0x2000D43")]
	public class CherrySquash : BaseConfig
	{
		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06004697 RID: 18071 RVA: 0x001668F4 File Offset: 0x00164AF4
		[Token(Token = "0x170007B0")]
		public override string Role
		{
			[Token(Token = "0x6004697")]
			[Address(RVA = "0x8AA180", Offset = "0x8A8780", VA = "0x1808AA180", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06004698 RID: 18072 RVA: 0x00166908 File Offset: 0x00164B08
		[Token(Token = "0x170007B1")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004698")]
			[Address(RVA = "0x8AA170", Offset = "0x8A8770", VA = "0x1808AA170", Slot = "4")]
			get
			{
				return PlantType.CherrySquash;
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06004699 RID: 18073 RVA: 0x0016691C File Offset: 0x00164B1C
		[Token(Token = "0x170007B2")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004699")]
			[Address(RVA = "0x8AA060", Offset = "0x8A8660", VA = "0x1808AA060", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x0600469A RID: 18074 RVA: 0x00166948 File Offset: 0x00164B48
		[Token(Token = "0x600469A")]
		[Address(RVA = "0x8A98D0", Offset = "0x8A7ED0", VA = "0x1808A98D0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 1f, num2 != 0, num);
		}

		// Token: 0x0600469B RID: 18075 RVA: 0x00166970 File Offset: 0x00164B70
		[Token(Token = "0x600469B")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public CherrySquash()
		{
		}
	}
}
