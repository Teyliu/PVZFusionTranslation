using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AC8 RID: 2760
	[Token(Token = "0x2000AC8")]
	public class CattailPlant : PlantData
	{
		// Token: 0x17000338 RID: 824
		// (get) Token: 0x060038B2 RID: 14514 RVA: 0x0012D000 File Offset: 0x0012B200
		[Token(Token = "0x17000338")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60038B2")]
			[Address(RVA = "0x7CE960", Offset = "0x7CCF60", VA = "0x1807CE960", Slot = "4")]
			get
			{
				return PlantType.CattailPlant;
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x060038B3 RID: 14515 RVA: 0x0012D014 File Offset: 0x0012B214
		[Token(Token = "0x17000339")]
		public override string Title
		{
			[Token(Token = "0x60038B3")]
			[Address(RVA = "0x7CEAE0", Offset = "0x7CD0E0", VA = "0x1807CEAE0", Slot = "5")]
			get
			{
				return "饱和式提问";
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x060038B4 RID: 14516 RVA: 0x0012D028 File Offset: 0x0012B228
		[Token(Token = "0x1700033A")]
		public override string Description
		{
			[Token(Token = "0x60038B4")]
			[Address(RVA = "0x7CE930", Offset = "0x7CCF30", VA = "0x1807CE930", Slot = "6")]
			get
			{
				return "攻击可以使敌人易伤，并触发多次射击";
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x060038B5 RID: 14517 RVA: 0x0012D03C File Offset: 0x0012B23C
		[Token(Token = "0x1700033B")]
		public override int Cost
		{
			[Token(Token = "0x60038B5")]
			[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "8")]
			get
			{
				return 3;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x060038B6 RID: 14518 RVA: 0x0012D04C File Offset: 0x0012B24C
		[Token(Token = "0x1700033C")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60038B6")]
			[Address(RVA = "0x7CE970", Offset = "0x7CCF70", VA = "0x1807CE970", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x060038B7 RID: 14519 RVA: 0x0012D090 File Offset: 0x0012B290
		[Token(Token = "0x60038B7")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public CattailPlant()
		{
		}
	}
}
