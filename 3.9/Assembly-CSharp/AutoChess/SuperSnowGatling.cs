using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AD0 RID: 2768
	[Token(Token = "0x2000AD0")]
	public class SuperSnowGatling : PlantData
	{
		// Token: 0x17000360 RID: 864
		// (get) Token: 0x060038E2 RID: 14562 RVA: 0x0012D4F8 File Offset: 0x0012B6F8
		[Token(Token = "0x17000360")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60038E2")]
			[Address(RVA = "0x7DFF40", Offset = "0x7DE540", VA = "0x1807DFF40", Slot = "4")]
			get
			{
				return PlantType.SuperSnowGatling;
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x060038E3 RID: 14563 RVA: 0x0012D50C File Offset: 0x0012B70C
		[Token(Token = "0x17000361")]
		public override string Title
		{
			[Token(Token = "0x60038E3")]
			[Address(RVA = "0x7E00C0", Offset = "0x7DE6C0", VA = "0x1807E00C0", Slot = "5")]
			get
			{
				return "天河本怒涛";
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x060038E4 RID: 14564 RVA: 0x0012D520 File Offset: 0x0012B720
		[Token(Token = "0x17000362")]
		public override string Description
		{
			[Token(Token = "0x60038E4")]
			[Address(RVA = "0x7DFF10", Offset = "0x7DE510", VA = "0x1807DFF10", Slot = "6")]
			get
			{
				return "被减速的敌人受到攻击时获得能量，满能量后释放大招攻击敌人";
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x060038E5 RID: 14565 RVA: 0x0012D534 File Offset: 0x0012B734
		[Token(Token = "0x17000363")]
		public override int Cost
		{
			[Token(Token = "0x60038E5")]
			[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "8")]
			get
			{
				return 4;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x060038E6 RID: 14566 RVA: 0x0012D544 File Offset: 0x0012B744
		[Token(Token = "0x17000364")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60038E6")]
			[Address(RVA = "0x7DFF50", Offset = "0x7DE550", VA = "0x1807DFF50", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x060038E7 RID: 14567 RVA: 0x0012D588 File Offset: 0x0012B788
		[Token(Token = "0x60038E7")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public SuperSnowGatling()
		{
		}
	}
}
