using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A92 RID: 2706
	[Token(Token = "0x2000A92")]
	public class UltimateHelmetGatling : PlantData
	{
		// Token: 0x17000322 RID: 802
		// (get) Token: 0x060037AA RID: 14250 RVA: 0x00128408 File Offset: 0x00126608
		[Token(Token = "0x17000322")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60037AA")]
			[Address(RVA = "0x781780", Offset = "0x77FD80", VA = "0x180781780", Slot = "4")]
			get
			{
				return PlantType.UltimateHelmetGatling;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x060037AB RID: 14251 RVA: 0x0012841C File Offset: 0x0012661C
		[Token(Token = "0x17000323")]
		public override string Title
		{
			[Token(Token = "0x60037AB")]
			[Address(RVA = "0x7818B0", Offset = "0x77FEB0", VA = "0x1807818B0", Slot = "5")]
			get
			{
				return "清空弹匣";
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x060037AC RID: 14252 RVA: 0x00128430 File Offset: 0x00126630
		[Token(Token = "0x17000324")]
		public override string Description
		{
			[Token(Token = "0x60037AC")]
			[Address(RVA = "0x781750", Offset = "0x77FD50", VA = "0x180781750", Slot = "6")]
			get
			{
				return "攻击造成范围伤害";
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x060037AD RID: 14253 RVA: 0x00128444 File Offset: 0x00126644
		[Token(Token = "0x17000325")]
		public override int Cost
		{
			[Token(Token = "0x60037AD")]
			[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "8")]
			get
			{
				return 4;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x060037AE RID: 14254 RVA: 0x00128454 File Offset: 0x00126654
		[Token(Token = "0x17000326")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60037AE")]
			[Address(RVA = "0x781790", Offset = "0x77FD90", VA = "0x180781790", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060037AF RID: 14255 RVA: 0x00128490 File Offset: 0x00126690
		[Token(Token = "0x60037AF")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public UltimateHelmetGatling()
		{
		}
	}
}
