using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000ABD RID: 2749
	[Token(Token = "0x2000ABD")]
	public class CobCannon : PlantData
	{
		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06003870 RID: 14448 RVA: 0x0012C93C File Offset: 0x0012AB3C
		[Token(Token = "0x17000301")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003870")]
			[Address(RVA = "0x7CEE50", Offset = "0x7CD450", VA = "0x1807CEE50", Slot = "4")]
			get
			{
				return PlantType.CobCannon;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06003871 RID: 14449 RVA: 0x0012C950 File Offset: 0x0012AB50
		[Token(Token = "0x17000302")]
		public override string Title
		{
			[Token(Token = "0x6003871")]
			[Address(RVA = "0x7CEFD0", Offset = "0x7CD5D0", VA = "0x1807CEFD0", Slot = "5")]
			get
			{
				return "火箭发射";
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06003872 RID: 14450 RVA: 0x0012C964 File Offset: 0x0012AB64
		[Token(Token = "0x17000303")]
		public override string Description
		{
			[Token(Token = "0x6003872")]
			[Address(RVA = "0x7CEE20", Offset = "0x7CD420", VA = "0x1807CEE20", Slot = "6")]
			get
			{
				return "每次攻击后，提供伤害加成，敌人受到的伤害增加";
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06003873 RID: 14451 RVA: 0x0012C978 File Offset: 0x0012AB78
		[Token(Token = "0x17000304")]
		public override int Cost
		{
			[Token(Token = "0x6003873")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "8")]
			get
			{
				return 2;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06003874 RID: 14452 RVA: 0x0012C988 File Offset: 0x0012AB88
		[Token(Token = "0x17000305")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003874")]
			[Address(RVA = "0x7CEE60", Offset = "0x7CD460", VA = "0x1807CEE60", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06003875 RID: 14453 RVA: 0x0012C9CC File Offset: 0x0012ABCC
		[Token(Token = "0x6003875")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public CobCannon()
		{
		}
	}
}
