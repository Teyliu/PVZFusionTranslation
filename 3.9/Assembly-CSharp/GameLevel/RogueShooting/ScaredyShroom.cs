using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D32 RID: 3378
	[Token(Token = "0x2000D32")]
	public class ScaredyShroom : BaseConfig
	{
		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06004636 RID: 17974 RVA: 0x00165E68 File Offset: 0x00164068
		[Token(Token = "0x17000772")]
		public override string Role
		{
			[Token(Token = "0x6004636")]
			[Address(RVA = "0x8B3890", Offset = "0x8B1E90", VA = "0x1808B3890", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06004637 RID: 17975 RVA: 0x00165E7C File Offset: 0x0016407C
		[Token(Token = "0x17000773")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004637")]
			[Address(RVA = "0x3F87C0", Offset = "0x3F6DC0", VA = "0x1803F87C0", Slot = "4")]
			get
			{
				return PlantType.ScaredyShroom;
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06004638 RID: 17976 RVA: 0x00165E8C File Offset: 0x0016408C
		[Token(Token = "0x17000774")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004638")]
			[Address(RVA = "0x8B36F0", Offset = "0x8B1CF0", VA = "0x1808B36F0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06004639 RID: 17977 RVA: 0x00165EC0 File Offset: 0x001640C0
		[Token(Token = "0x6004639")]
		[Address(RVA = "0x8A90B0", Offset = "0x8A76B0", VA = "0x1808A90B0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 14f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x0600463A RID: 17978 RVA: 0x00165EF4 File Offset: 0x001640F4
		[Token(Token = "0x600463A")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public ScaredyShroom()
		{
		}
	}
}
