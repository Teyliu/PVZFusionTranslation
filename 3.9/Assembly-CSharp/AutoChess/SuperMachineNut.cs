using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000ADE RID: 2782
	[Token(Token = "0x2000ADE")]
	public class SuperMachineNut : PlantData
	{
		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06003936 RID: 14646 RVA: 0x0012DD88 File Offset: 0x0012BF88
		[Token(Token = "0x170003A6")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003936")]
			[Address(RVA = "0x7DFDB0", Offset = "0x7DE3B0", VA = "0x1807DFDB0", Slot = "4")]
			get
			{
				return PlantType.SuperMachineNut;
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06003937 RID: 14647 RVA: 0x0012DD9C File Offset: 0x0012BF9C
		[Token(Token = "0x170003A7")]
		public override string Title
		{
			[Token(Token = "0x6003937")]
			[Address(RVA = "0x7DFEE0", Offset = "0x7DE4E0", VA = "0x1807DFEE0", Slot = "5")]
			get
			{
				return "以剑为盾";
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06003938 RID: 14648 RVA: 0x0012DDB0 File Offset: 0x0012BFB0
		[Token(Token = "0x170003A8")]
		public override string Description
		{
			[Token(Token = "0x6003938")]
			[Address(RVA = "0x7DFD80", Offset = "0x7DE380", VA = "0x1807DFD80", Slot = "6")]
			get
			{
				return "我方小队受到伤害时为鱼丸提供能量，释放能量以回复生命值，并发动反击";
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06003939 RID: 14649 RVA: 0x0012DDC4 File Offset: 0x0012BFC4
		[Token(Token = "0x170003A9")]
		public override int Cost
		{
			[Token(Token = "0x6003939")]
			[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "8")]
			get
			{
				return 5;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x0600393A RID: 14650 RVA: 0x0012DDD4 File Offset: 0x0012BFD4
		[Token(Token = "0x170003AA")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x600393A")]
			[Address(RVA = "0x7DFDC0", Offset = "0x7DE3C0", VA = "0x1807DFDC0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x0600393B RID: 14651 RVA: 0x0012DE10 File Offset: 0x0012C010
		[Token(Token = "0x600393B")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public SuperMachineNut()
		{
		}
	}
}
