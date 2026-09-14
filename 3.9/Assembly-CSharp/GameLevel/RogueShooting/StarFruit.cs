using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D63 RID: 3427
	[Token(Token = "0x2000D63")]
	public class StarFruit : BaseConfig
	{
		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x0600474D RID: 18253 RVA: 0x00168198 File Offset: 0x00166398
		[Token(Token = "0x1700081B")]
		public override string Role
		{
			[Token(Token = "0x600474D")]
			[Address(RVA = "0x8B6070", Offset = "0x8B4670", VA = "0x1808B6070", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x0600474E RID: 18254 RVA: 0x001681AC File Offset: 0x001663AC
		[Token(Token = "0x1700081C")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600474E")]
			[Address(RVA = "0x7185D0", Offset = "0x716BD0", VA = "0x1807185D0", Slot = "4")]
			get
			{
				return PlantType.StarFruit;
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x0600474F RID: 18255 RVA: 0x001681BC File Offset: 0x001663BC
		[Token(Token = "0x1700081D")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600474F")]
			[Address(RVA = "0x8B5ED0", Offset = "0x8B44D0", VA = "0x1808B5ED0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06004750 RID: 18256 RVA: 0x001681F0 File Offset: 0x001663F0
		[Token(Token = "0x6004750")]
		[Address(RVA = "0x88FD80", Offset = "0x88E380", VA = "0x18088FD80", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 9f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x06004751 RID: 18257 RVA: 0x00168224 File Offset: 0x00166424
		[Token(Token = "0x6004751")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public StarFruit()
		{
		}
	}
}
