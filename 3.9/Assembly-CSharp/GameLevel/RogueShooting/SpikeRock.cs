using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D51 RID: 3409
	[Token(Token = "0x2000D51")]
	public class SpikeRock : BaseConfig
	{
		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x060046EF RID: 18159 RVA: 0x001672A4 File Offset: 0x001654A4
		[Token(Token = "0x170007EA")]
		public override string Role
		{
			[Token(Token = "0x60046EF")]
			[Address(RVA = "0x8B58F0", Offset = "0x8B3EF0", VA = "0x1808B58F0", Slot = "7")]
			get
			{
				return "辅助";
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x060046F0 RID: 18160 RVA: 0x001672B8 File Offset: 0x001654B8
		[Token(Token = "0x170007EB")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60046F0")]
			[Address(RVA = "0x8B58E0", Offset = "0x8B3EE0", VA = "0x1808B58E0", Slot = "4")]
			get
			{
				return PlantType.SpikeRock;
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x060046F1 RID: 18161 RVA: 0x001672CC File Offset: 0x001654CC
		[Token(Token = "0x170007EC")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60046F1")]
			[Address(RVA = "0x8B57D0", Offset = "0x8B3DD0", VA = "0x1808B57D0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060046F2 RID: 18162 RVA: 0x001672F8 File Offset: 0x001654F8
		[Token(Token = "0x60046F2")]
		[Address(RVA = "0x8A90B0", Offset = "0x8A76B0", VA = "0x1808A90B0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 14f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x060046F3 RID: 18163 RVA: 0x0016732C File Offset: 0x0016552C
		[Token(Token = "0x60046F3")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public SpikeRock()
		{
		}
	}
}
