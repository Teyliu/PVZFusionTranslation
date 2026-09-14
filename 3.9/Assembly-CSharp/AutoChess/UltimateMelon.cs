using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000ADF RID: 2783
	[Token(Token = "0x2000ADF")]
	public class UltimateMelon : PlantData
	{
		// Token: 0x170003AB RID: 939
		// (get) Token: 0x0600393C RID: 14652 RVA: 0x0012DE24 File Offset: 0x0012C024
		[Token(Token = "0x170003AB")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600393C")]
			[Address(RVA = "0x7E8B30", Offset = "0x7E7130", VA = "0x1807E8B30", Slot = "4")]
			get
			{
				return PlantType.UltimateMelon;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x0600393D RID: 14653 RVA: 0x0012DE38 File Offset: 0x0012C038
		[Token(Token = "0x170003AC")]
		public override string Title
		{
			[Token(Token = "0x600393D")]
			[Address(RVA = "0x7E8C60", Offset = "0x7E7260", VA = "0x1807E8C60", Slot = "5")]
			get
			{
				return "窥视奥纪";
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x0600393E RID: 14654 RVA: 0x0012DE4C File Offset: 0x0012C04C
		[Token(Token = "0x170003AD")]
		public override string Description
		{
			[Token(Token = "0x600393E")]
			[Address(RVA = "0x7E8B00", Offset = "0x7E7100", VA = "0x1807E8B00", Slot = "6")]
			get
			{
				return "蒜毒叠加的层数提高";
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x0600393F RID: 14655 RVA: 0x0012DE60 File Offset: 0x0012C060
		[Token(Token = "0x170003AE")]
		public override int Cost
		{
			[Token(Token = "0x600393F")]
			[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "8")]
			get
			{
				return 5;
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06003940 RID: 14656 RVA: 0x0012DE70 File Offset: 0x0012C070
		[Token(Token = "0x170003AF")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003940")]
			[Address(RVA = "0x7E8B40", Offset = "0x7E7140", VA = "0x1807E8B40", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003941 RID: 14657 RVA: 0x0012DEAC File Offset: 0x0012C0AC
		[Token(Token = "0x6003941")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public UltimateMelon()
		{
		}
	}
}
