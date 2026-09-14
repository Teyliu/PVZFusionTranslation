using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AD6 RID: 2774
	[Token(Token = "0x2000AD6")]
	public class UltimateBigSniper : PlantData
	{
		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06003906 RID: 14598 RVA: 0x0012D8A8 File Offset: 0x0012BAA8
		[Token(Token = "0x1700037E")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003906")]
			[Address(RVA = "0x7E7E60", Offset = "0x7E6460", VA = "0x1807E7E60", Slot = "4")]
			get
			{
				return PlantType.UltimateBigSniper;
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06003907 RID: 14599 RVA: 0x0012D8BC File Offset: 0x0012BABC
		[Token(Token = "0x1700037F")]
		public override string Title
		{
			[Token(Token = "0x6003907")]
			[Address(RVA = "0x7E7F90", Offset = "0x7E6590", VA = "0x1807E7F90", Slot = "5")]
			get
			{
				return "精准打击";
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06003908 RID: 14600 RVA: 0x0012D8D0 File Offset: 0x0012BAD0
		[Token(Token = "0x17000380")]
		public override string Description
		{
			[Token(Token = "0x6003908")]
			[Address(RVA = "0x7E7E30", Offset = "0x7E6430", VA = "0x1807E7E30", Slot = "6")]
			get
			{
				return "场上敌人越多，全队幸运一击的伤害越高";
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06003909 RID: 14601 RVA: 0x0012D8E4 File Offset: 0x0012BAE4
		[Token(Token = "0x17000381")]
		public override int Cost
		{
			[Token(Token = "0x6003909")]
			[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "8")]
			get
			{
				return 4;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x0600390A RID: 14602 RVA: 0x0012D8F4 File Offset: 0x0012BAF4
		[Token(Token = "0x17000382")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x600390A")]
			[Address(RVA = "0x7E7E70", Offset = "0x7E6470", VA = "0x1807E7E70", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x0600390B RID: 14603 RVA: 0x0012D930 File Offset: 0x0012BB30
		[Token(Token = "0x600390B")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public UltimateBigSniper()
		{
		}
	}
}
