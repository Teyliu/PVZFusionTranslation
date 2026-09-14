using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AC7 RID: 2759
	[Token(Token = "0x2000AC7")]
	public class DoomPeashooter : PlantData
	{
		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060038AC RID: 14508 RVA: 0x0012CF64 File Offset: 0x0012B164
		[Token(Token = "0x17000333")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60038AC")]
			[Address(RVA = "0x7CF200", Offset = "0x7CD800", VA = "0x1807CF200", Slot = "4")]
			get
			{
				return PlantType.DoomPeashooter;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060038AD RID: 14509 RVA: 0x0012CF78 File Offset: 0x0012B178
		[Token(Token = "0x17000334")]
		public override string Title
		{
			[Token(Token = "0x60038AD")]
			[Address(RVA = "0x7CF330", Offset = "0x7CD930", VA = "0x1807CF330", Slot = "5")]
			get
			{
				return "禁忌之力";
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060038AE RID: 14510 RVA: 0x0012CF8C File Offset: 0x0012B18C
		[Token(Token = "0x17000335")]
		public override string Description
		{
			[Token(Token = "0x60038AE")]
			[Address(RVA = "0x7CF1D0", Offset = "0x7CD7D0", VA = "0x1807CF1D0", Slot = "6")]
			get
			{
				return "攻击附带余烬效果，并在可发射毁灭菇子弹";
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060038AF RID: 14511 RVA: 0x0012CFA0 File Offset: 0x0012B1A0
		[Token(Token = "0x17000336")]
		public override int Cost
		{
			[Token(Token = "0x60038AF")]
			[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "8")]
			get
			{
				return 3;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x060038B0 RID: 14512 RVA: 0x0012CFB0 File Offset: 0x0012B1B0
		[Token(Token = "0x17000337")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60038B0")]
			[Address(RVA = "0x7CF210", Offset = "0x7CD810", VA = "0x1807CF210", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060038B1 RID: 14513 RVA: 0x0012CFEC File Offset: 0x0012B1EC
		[Token(Token = "0x60038B1")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public DoomPeashooter()
		{
		}
	}
}
