using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A6D RID: 2669
	[Token(Token = "0x2000A6D")]
	public class Plantern : PlantData
	{
		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060036CC RID: 14028 RVA: 0x00126D30 File Offset: 0x00124F30
		[Token(Token = "0x17000269")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60036CC")]
			[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "4")]
			get
			{
				return PlantType.Plantern;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060036CD RID: 14029 RVA: 0x00126D40 File Offset: 0x00124F40
		[Token(Token = "0x1700026A")]
		public override string Title
		{
			[Token(Token = "0x60036CD")]
			[Address(RVA = "0x770300", Offset = "0x76E900", VA = "0x180770300", Slot = "5")]
			get
			{
				return "燎烟古方";
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060036CE RID: 14030 RVA: 0x00126D54 File Offset: 0x00124F54
		[Token(Token = "0x1700026B")]
		public override string Description
		{
			[Token(Token = "0x60036CE")]
			[Address(RVA = "0x770160", Offset = "0x76E760", VA = "0x180770160", Slot = "6")]
			get
			{
				return "我方小队攻击敌人后，治疗我方低生命值目标";
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060036CF RID: 14031 RVA: 0x00126D68 File Offset: 0x00124F68
		[Token(Token = "0x1700026C")]
		public override int Cost
		{
			[Token(Token = "0x60036CF")]
			[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
			get
			{
				return 1;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060036D0 RID: 14032 RVA: 0x00126D78 File Offset: 0x00124F78
		[Token(Token = "0x1700026D")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60036D0")]
			[Address(RVA = "0x770190", Offset = "0x76E790", VA = "0x180770190", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x060036D1 RID: 14033 RVA: 0x00126DBC File Offset: 0x00124FBC
		[Token(Token = "0x60036D1")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public Plantern()
		{
		}
	}
}
