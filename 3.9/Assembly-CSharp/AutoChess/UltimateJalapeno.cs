using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000ACF RID: 2767
	[Token(Token = "0x2000ACF")]
	public class UltimateJalapeno : PlantData
	{
		// Token: 0x1700035B RID: 859
		// (get) Token: 0x060038DC RID: 14556 RVA: 0x0012D454 File Offset: 0x0012B654
		[Token(Token = "0x1700035B")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60038DC")]
			[Address(RVA = "0x7E87C0", Offset = "0x7E6DC0", VA = "0x1807E87C0", Slot = "4")]
			get
			{
				return PlantType.UltimateJalapeno;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x060038DD RID: 14557 RVA: 0x0012D468 File Offset: 0x0012B668
		[Token(Token = "0x1700035C")]
		public override string Title
		{
			[Token(Token = "0x60038DD")]
			[Address(RVA = "0x7E8940", Offset = "0x7E6F40", VA = "0x1807E8940", Slot = "5")]
			get
			{
				return "斩将祭旗";
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x060038DE RID: 14558 RVA: 0x0012D47C File Offset: 0x0012B67C
		[Token(Token = "0x1700035D")]
		public override string Description
		{
			[Token(Token = "0x60038DE")]
			[Address(RVA = "0x7E8790", Offset = "0x7E6D90", VA = "0x1807E8790", Slot = "6")]
			get
			{
				return "全场植物按百分比分摊伤害，我方小队幸运一击伤害提高，新增固定时间获得充能";
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x060038DF RID: 14559 RVA: 0x0012D490 File Offset: 0x0012B690
		[Token(Token = "0x1700035E")]
		public override int Cost
		{
			[Token(Token = "0x60038DF")]
			[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "8")]
			get
			{
				return 4;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x060038E0 RID: 14560 RVA: 0x0012D4A0 File Offset: 0x0012B6A0
		[Token(Token = "0x1700035F")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60038E0")]
			[Address(RVA = "0x7E87D0", Offset = "0x7E6DD0", VA = "0x1807E87D0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x060038E1 RID: 14561 RVA: 0x0012D4E4 File Offset: 0x0012B6E4
		[Token(Token = "0x60038E1")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public UltimateJalapeno()
		{
		}
	}
}
