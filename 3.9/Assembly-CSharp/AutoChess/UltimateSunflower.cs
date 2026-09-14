using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AD3 RID: 2771
	[Token(Token = "0x2000AD3")]
	public class UltimateSunflower : PlantData
	{
		// Token: 0x1700036F RID: 879
		// (get) Token: 0x060038F4 RID: 14580 RVA: 0x0012D6D4 File Offset: 0x0012B8D4
		[Token(Token = "0x1700036F")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60038F4")]
			[Address(RVA = "0x7E8FE0", Offset = "0x7E75E0", VA = "0x1807E8FE0", Slot = "4")]
			get
			{
				return PlantType.UltimateSunflower;
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x060038F5 RID: 14581 RVA: 0x0012D6E8 File Offset: 0x0012B8E8
		[Token(Token = "0x17000370")]
		public override string Title
		{
			[Token(Token = "0x60038F5")]
			[Address(RVA = "0x7E9110", Offset = "0x7E7710", VA = "0x1807E9110", Slot = "5")]
			get
			{
				return "双子奇兵";
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x060038F6 RID: 14582 RVA: 0x0012D6FC File Offset: 0x0012B8FC
		[Token(Token = "0x17000371")]
		public override string Description
		{
			[Token(Token = "0x60038F6")]
			[Address(RVA = "0x7E8FB0", Offset = "0x7E75B0", VA = "0x1807E8FB0", Slot = "6")]
			get
			{
				return "释放攻击后生阳光额外攻击，会基于场上向日葵的数量增加攻击段数";
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x060038F7 RID: 14583 RVA: 0x0012D710 File Offset: 0x0012B910
		[Token(Token = "0x17000372")]
		public override int Cost
		{
			[Token(Token = "0x60038F7")]
			[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "8")]
			get
			{
				return 4;
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x060038F8 RID: 14584 RVA: 0x0012D720 File Offset: 0x0012B920
		[Token(Token = "0x17000373")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60038F8")]
			[Address(RVA = "0x7E8FF0", Offset = "0x7E75F0", VA = "0x1807E8FF0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060038F9 RID: 14585 RVA: 0x0012D75C File Offset: 0x0012B95C
		[Token(Token = "0x60038F9")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public UltimateSunflower()
		{
		}
	}
}
