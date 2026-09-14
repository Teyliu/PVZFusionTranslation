using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D07 RID: 3335
	[Token(Token = "0x2000D07")]
	public class PeaMine : BaseConfig
	{
		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x0600453D RID: 17725 RVA: 0x00164494 File Offset: 0x00162694
		[Token(Token = "0x170006D3")]
		public override string Role
		{
			[Token(Token = "0x600453D")]
			[Address(RVA = "0x8B0F60", Offset = "0x8AF560", VA = "0x1808B0F60", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x0600453E RID: 17726 RVA: 0x001644A8 File Offset: 0x001626A8
		[Token(Token = "0x170006D4")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600453E")]
			[Address(RVA = "0x3F6F40", Offset = "0x3F5540", VA = "0x1803F6F40", Slot = "4")]
			get
			{
				return PlantType.PeaMine;
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x0600453F RID: 17727 RVA: 0x001644BC File Offset: 0x001626BC
		[Token(Token = "0x170006D5")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600453F")]
			[Address(RVA = "0x8B0E50", Offset = "0x8AF450", VA = "0x1808B0E50", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004540 RID: 17728 RVA: 0x001644E8 File Offset: 0x001626E8
		[Token(Token = "0x6004540")]
		[Address(RVA = "0x8AA970", Offset = "0x8A8F70", VA = "0x1808AA970", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 19f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x06004541 RID: 17729 RVA: 0x0016451C File Offset: 0x0016271C
		[Token(Token = "0x6004541")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public PeaMine()
		{
		}
	}
}
