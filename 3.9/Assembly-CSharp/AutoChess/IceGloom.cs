using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AC9 RID: 2761
	[Token(Token = "0x2000AC9")]
	public class IceGloom : PlantData
	{
		// Token: 0x1700033D RID: 829
		// (get) Token: 0x060038B8 RID: 14520 RVA: 0x0012D0A4 File Offset: 0x0012B2A4
		[Token(Token = "0x1700033D")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60038B8")]
			[Address(RVA = "0x7D2760", Offset = "0x7D0D60", VA = "0x1807D2760", Slot = "4")]
			get
			{
				return PlantType.IceGloom;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x060038B9 RID: 14521 RVA: 0x0012D0B8 File Offset: 0x0012B2B8
		[Token(Token = "0x1700033E")]
		public override string Title
		{
			[Token(Token = "0x60038B9")]
			[Address(RVA = "0x7D2890", Offset = "0x7D0E90", VA = "0x1807D2890", Slot = "5")]
			get
			{
				return "飞雷紫";
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x060038BA RID: 14522 RVA: 0x0012D0CC File Offset: 0x0012B2CC
		[Token(Token = "0x1700033F")]
		public override string Description
		{
			[Token(Token = "0x60038BA")]
			[Address(RVA = "0x7D2730", Offset = "0x7D0D30", VA = "0x1807D2730", Slot = "6")]
			get
			{
				return "对陷入减速状态的敌人施加标记，攻击消耗标记造成额外伤害，攻击范围提高";
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x060038BB RID: 14523 RVA: 0x0012D0E0 File Offset: 0x0012B2E0
		[Token(Token = "0x17000340")]
		public override int Cost
		{
			[Token(Token = "0x60038BB")]
			[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "8")]
			get
			{
				return 3;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x060038BC RID: 14524 RVA: 0x0012D0F0 File Offset: 0x0012B2F0
		[Token(Token = "0x17000341")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60038BC")]
			[Address(RVA = "0x7D2770", Offset = "0x7D0D70", VA = "0x1807D2770", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060038BD RID: 14525 RVA: 0x0012D12C File Offset: 0x0012B32C
		[Token(Token = "0x60038BD")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public IceGloom()
		{
		}
	}
}
