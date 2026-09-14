using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A76 RID: 2678
	[Token(Token = "0x2000A76")]
	public class JalaCaltrop : PlantData
	{
		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06003702 RID: 14082 RVA: 0x001272A0 File Offset: 0x001254A0
		[Token(Token = "0x17000296")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003702")]
			[Address(RVA = "0x76BDD0", Offset = "0x76A3D0", VA = "0x18076BDD0", Slot = "4")]
			get
			{
				return PlantType.JalaCaltrop;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06003703 RID: 14083 RVA: 0x001272B4 File Offset: 0x001254B4
		[Token(Token = "0x17000297")]
		public override string Title
		{
			[Token(Token = "0x6003703")]
			[Address(RVA = "0x76BF00", Offset = "0x76A500", VA = "0x18076BF00", Slot = "5")]
			get
			{
				return "破甲尖刺";
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06003704 RID: 14084 RVA: 0x001272C8 File Offset: 0x001254C8
		[Token(Token = "0x17000298")]
		public override string Description
		{
			[Token(Token = "0x6003704")]
			[Address(RVA = "0x76BDA0", Offset = "0x76A3A0", VA = "0x18076BDA0", Slot = "6")]
			get
			{
				return "攻击会同时削减僵尸的护甲";
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06003705 RID: 14085 RVA: 0x001272DC File Offset: 0x001254DC
		[Token(Token = "0x17000299")]
		public override int Cost
		{
			[Token(Token = "0x6003705")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "8")]
			get
			{
				return 2;
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06003706 RID: 14086 RVA: 0x001272EC File Offset: 0x001254EC
		[Token(Token = "0x1700029A")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003706")]
			[Address(RVA = "0x76BDE0", Offset = "0x76A3E0", VA = "0x18076BDE0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003707 RID: 14087 RVA: 0x00127328 File Offset: 0x00125528
		[Token(Token = "0x6003707")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public JalaCaltrop()
		{
		}
	}
}
