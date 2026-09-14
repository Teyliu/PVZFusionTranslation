using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AD2 RID: 2770
	[Token(Token = "0x2000AD2")]
	public class UltimateHelmetGatling : PlantData
	{
		// Token: 0x1700036A RID: 874
		// (get) Token: 0x060038EE RID: 14574 RVA: 0x0012D638 File Offset: 0x0012B838
		[Token(Token = "0x1700036A")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60038EE")]
			[Address(RVA = "0x7E8630", Offset = "0x7E6C30", VA = "0x1807E8630", Slot = "4")]
			get
			{
				return PlantType.UltimateHelmetGatling;
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x060038EF RID: 14575 RVA: 0x0012D64C File Offset: 0x0012B84C
		[Token(Token = "0x1700036B")]
		public override string Title
		{
			[Token(Token = "0x60038EF")]
			[Address(RVA = "0x7E8760", Offset = "0x7E6D60", VA = "0x1807E8760", Slot = "5")]
			get
			{
				return "清空弹匣";
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x060038F0 RID: 14576 RVA: 0x0012D660 File Offset: 0x0012B860
		[Token(Token = "0x1700036C")]
		public override string Description
		{
			[Token(Token = "0x60038F0")]
			[Address(RVA = "0x7E8600", Offset = "0x7E6C00", VA = "0x1807E8600", Slot = "6")]
			get
			{
				return "攻击造成范围伤害";
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x060038F1 RID: 14577 RVA: 0x0012D674 File Offset: 0x0012B874
		[Token(Token = "0x1700036D")]
		public override int Cost
		{
			[Token(Token = "0x60038F1")]
			[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "8")]
			get
			{
				return 4;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x060038F2 RID: 14578 RVA: 0x0012D684 File Offset: 0x0012B884
		[Token(Token = "0x1700036E")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60038F2")]
			[Address(RVA = "0x7E8640", Offset = "0x7E6C40", VA = "0x1807E8640", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060038F3 RID: 14579 RVA: 0x0012D6C0 File Offset: 0x0012B8C0
		[Token(Token = "0x60038F3")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public UltimateHelmetGatling()
		{
		}
	}
}
