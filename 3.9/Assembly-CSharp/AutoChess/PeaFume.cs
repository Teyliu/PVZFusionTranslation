using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AB8 RID: 2744
	[Token(Token = "0x2000AB8")]
	public class PeaFume : PlantData
	{
		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06003852 RID: 14418 RVA: 0x0012C610 File Offset: 0x0012A810
		[Token(Token = "0x170002E8")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003852")]
			[Address(RVA = "0x7D6B90", Offset = "0x7D5190", VA = "0x1807D6B90", Slot = "4")]
			get
			{
				return PlantType.PeaFume;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06003853 RID: 14419 RVA: 0x0012C624 File Offset: 0x0012A824
		[Token(Token = "0x170002E9")]
		public override string Title
		{
			[Token(Token = "0x6003853")]
			[Address(RVA = "0x7D6D10", Offset = "0x7D5310", VA = "0x1807D6D10", Slot = "5")]
			get
			{
				return "加速喷雾";
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06003854 RID: 14420 RVA: 0x0012C638 File Offset: 0x0012A838
		[Token(Token = "0x170002EA")]
		public override string Description
		{
			[Token(Token = "0x6003854")]
			[Address(RVA = "0x7D6B60", Offset = "0x7D5160", VA = "0x1807D6B60", Slot = "6")]
			get
			{
				return "加速提供更高伤害，同时治疗生命值较低的植物";
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06003855 RID: 14421 RVA: 0x0012C64C File Offset: 0x0012A84C
		[Token(Token = "0x170002EB")]
		public override int Cost
		{
			[Token(Token = "0x6003855")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "8")]
			get
			{
				return 2;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06003856 RID: 14422 RVA: 0x0012C65C File Offset: 0x0012A85C
		[Token(Token = "0x170002EC")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003856")]
			[Address(RVA = "0x7D6BA0", Offset = "0x7D51A0", VA = "0x1807D6BA0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06003857 RID: 14423 RVA: 0x0012C6A0 File Offset: 0x0012A8A0
		[Token(Token = "0x6003857")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public PeaFume()
		{
		}
	}
}
