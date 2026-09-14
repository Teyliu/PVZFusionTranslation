using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D1E RID: 3358
	[Token(Token = "0x2000D1E")]
	public class IceFumeShroom : BaseConfig
	{
		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x060045C3 RID: 17859 RVA: 0x001652C4 File Offset: 0x001634C4
		[Token(Token = "0x1700072A")]
		public override string Role
		{
			[Token(Token = "0x60045C3")]
			[Address(RVA = "0x8AE490", Offset = "0x8ACA90", VA = "0x1808AE490", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x060045C4 RID: 17860 RVA: 0x001652D8 File Offset: 0x001634D8
		[Token(Token = "0x1700072B")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60045C4")]
			[Address(RVA = "0x8AE480", Offset = "0x8ACA80", VA = "0x1808AE480", Slot = "4")]
			get
			{
				return PlantType.IceFumeShroom;
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x060045C5 RID: 17861 RVA: 0x001652EC File Offset: 0x001634EC
		[Token(Token = "0x1700072C")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60045C5")]
			[Address(RVA = "0x8AE370", Offset = "0x8AC970", VA = "0x1808AE370", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060045C6 RID: 17862 RVA: 0x00165318 File Offset: 0x00163518
		[Token(Token = "0x60045C6")]
		[Address(RVA = "0x8AC280", Offset = "0x8AA880", VA = "0x1808AC280", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 14f, num2 != 0, num);
		}

		// Token: 0x060045C7 RID: 17863 RVA: 0x00165340 File Offset: 0x00163540
		[Token(Token = "0x60045C7")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public IceFumeShroom()
		{
		}
	}
}
