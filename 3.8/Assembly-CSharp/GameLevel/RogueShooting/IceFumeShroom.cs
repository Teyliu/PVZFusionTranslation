using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C4A RID: 3146
	[Token(Token = "0x2000C4A")]
	public class IceFumeShroom : BaseConfig
	{
		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x060041D3 RID: 16851 RVA: 0x00157C9C File Offset: 0x00155E9C
		[Token(Token = "0x170005C1")]
		public override string Role
		{
			[Token(Token = "0x60041D3")]
			[Address(RVA = "0x832ED0", Offset = "0x8314D0", VA = "0x180832ED0", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x060041D4 RID: 16852 RVA: 0x00157CB0 File Offset: 0x00155EB0
		[Token(Token = "0x170005C2")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60041D4")]
			[Address(RVA = "0x832EC0", Offset = "0x8314C0", VA = "0x180832EC0", Slot = "4")]
			get
			{
				return PlantType.IceFumeShroom;
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x060041D5 RID: 16853 RVA: 0x00157CC4 File Offset: 0x00155EC4
		[Token(Token = "0x170005C3")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60041D5")]
			[Address(RVA = "0x832DA0", Offset = "0x8313A0", VA = "0x180832DA0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				UpgradeBuff upgradeBuff;
				upgradeBuff.sourceType = (PlantType)((ulong)1037L);
				upgradeBuff.targetType = (PlantType)((ulong)904L);
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060041D6 RID: 16854 RVA: 0x00157D0C File Offset: 0x00155F0C
		[Token(Token = "0x60041D6")]
		[Address(RVA = "0x831300", Offset = "0x82F900", VA = "0x180831300", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 14f, num2 != 0, num);
		}

		// Token: 0x060041D7 RID: 16855 RVA: 0x00157D34 File Offset: 0x00155F34
		[Token(Token = "0x60041D7")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public IceFumeShroom()
		{
		}
	}
}
