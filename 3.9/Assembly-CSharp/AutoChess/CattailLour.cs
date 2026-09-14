using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000ADC RID: 2780
	[Token(Token = "0x2000ADC")]
	public class CattailLour : PlantData
	{
		// Token: 0x1700039C RID: 924
		// (get) Token: 0x0600392A RID: 14634 RVA: 0x0012DC50 File Offset: 0x0012BE50
		[Token(Token = "0x1700039C")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600392A")]
			[Address(RVA = "0x7CE7D0", Offset = "0x7CCDD0", VA = "0x1807CE7D0", Slot = "4")]
			get
			{
				return PlantType.CattailLour;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x0600392B RID: 14635 RVA: 0x0012DC64 File Offset: 0x0012BE64
		[Token(Token = "0x1700039D")]
		public override string Title
		{
			[Token(Token = "0x600392B")]
			[Address(RVA = "0x7CE900", Offset = "0x7CCF00", VA = "0x1807CE900", Slot = "5")]
			get
			{
				return "猪市";
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x0600392C RID: 14636 RVA: 0x0012DC78 File Offset: 0x0012BE78
		[Token(Token = "0x1700039E")]
		public override string Description
		{
			[Token(Token = "0x600392C")]
			[Address(RVA = "0x7CE7A0", Offset = "0x7CCDA0", VA = "0x1807CE7A0", Slot = "6")]
			get
			{
				return "每次击杀敌人有概率获得金币，我方小队击杀敌人后也会释放僚机，敌人受到的伤害提高";
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x0600392D RID: 14637 RVA: 0x0012DC8C File Offset: 0x0012BE8C
		[Token(Token = "0x1700039F")]
		public override int Cost
		{
			[Token(Token = "0x600392D")]
			[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "8")]
			get
			{
				return 5;
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x0600392E RID: 14638 RVA: 0x0012DC9C File Offset: 0x0012BE9C
		[Token(Token = "0x170003A0")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x600392E")]
			[Address(RVA = "0x7CE7E0", Offset = "0x7CCDE0", VA = "0x1807CE7E0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x0600392F RID: 14639 RVA: 0x0012DCD8 File Offset: 0x0012BED8
		[Token(Token = "0x600392F")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public CattailLour()
		{
		}
	}
}
