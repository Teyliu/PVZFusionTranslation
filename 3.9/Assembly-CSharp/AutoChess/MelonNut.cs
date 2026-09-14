using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000ABE RID: 2750
	[Token(Token = "0x2000ABE")]
	public class MelonNut : PlantData
	{
		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06003876 RID: 14454 RVA: 0x0012C9E0 File Offset: 0x0012ABE0
		[Token(Token = "0x17000306")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003876")]
			[Address(RVA = "0x7D3420", Offset = "0x7D1A20", VA = "0x1807D3420", Slot = "4")]
			get
			{
				return PlantType.MelonNut;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06003877 RID: 14455 RVA: 0x0012C9F4 File Offset: 0x0012ABF4
		[Token(Token = "0x17000307")]
		public override string Title
		{
			[Token(Token = "0x6003877")]
			[Address(RVA = "0x7D3550", Offset = "0x7D1B50", VA = "0x1807D3550", Slot = "5")]
			get
			{
				return "沐浴神血";
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06003878 RID: 14456 RVA: 0x0012CA08 File Offset: 0x0012AC08
		[Token(Token = "0x17000308")]
		public override string Description
		{
			[Token(Token = "0x6003878")]
			[Address(RVA = "0x7D33F0", Offset = "0x7D19F0", VA = "0x1807D33F0", Slot = "6")]
			get
			{
				return "释放攻击时使生命值上限永久提高，生命上限使受伤充能额外提高";
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06003879 RID: 14457 RVA: 0x0012CA1C File Offset: 0x0012AC1C
		[Token(Token = "0x17000309")]
		public override int Cost
		{
			[Token(Token = "0x6003879")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "8")]
			get
			{
				return 2;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x0600387A RID: 14458 RVA: 0x0012CA2C File Offset: 0x0012AC2C
		[Token(Token = "0x1700030A")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x600387A")]
			[Address(RVA = "0x7D3430", Offset = "0x7D1A30", VA = "0x1807D3430", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x0600387B RID: 14459 RVA: 0x0012CA68 File Offset: 0x0012AC68
		[Token(Token = "0x600387B")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public MelonNut()
		{
		}
	}
}
