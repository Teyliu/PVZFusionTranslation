using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AD8 RID: 2776
	[Token(Token = "0x2000AD8")]
	public class EmeraldUmbrella : PlantData
	{
		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06003912 RID: 14610 RVA: 0x0012D9E0 File Offset: 0x0012BBE0
		[Token(Token = "0x17000388")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003912")]
			[Address(RVA = "0x7D16A0", Offset = "0x7CFCA0", VA = "0x1807D16A0", Slot = "4")]
			get
			{
				return PlantType.EmeraldUmbrella;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06003913 RID: 14611 RVA: 0x0012D9F4 File Offset: 0x0012BBF4
		[Token(Token = "0x17000389")]
		public override string Title
		{
			[Token(Token = "0x6003913")]
			[Address(RVA = "0x7D17D0", Offset = "0x7CFDD0", VA = "0x1807D17D0", Slot = "5")]
			get
			{
				return "欧拉！";
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06003914 RID: 14612 RVA: 0x0012DA08 File Offset: 0x0012BC08
		[Token(Token = "0x1700038A")]
		public override string Description
		{
			[Token(Token = "0x6003914")]
			[Address(RVA = "0x7D1670", Offset = "0x7CFC70", VA = "0x1807D1670", Slot = "6")]
			get
			{
				return "斩杀失败时也能造成5000真实伤害";
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06003915 RID: 14613 RVA: 0x0012DA1C File Offset: 0x0012BC1C
		[Token(Token = "0x1700038B")]
		public override int Cost
		{
			[Token(Token = "0x6003915")]
			[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "8")]
			get
			{
				return 4;
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06003916 RID: 14614 RVA: 0x0012DA2C File Offset: 0x0012BC2C
		[Token(Token = "0x1700038C")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003916")]
			[Address(RVA = "0x7D16B0", Offset = "0x7CFCB0", VA = "0x1807D16B0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003917 RID: 14615 RVA: 0x0012DA68 File Offset: 0x0012BC68
		[Token(Token = "0x6003917")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public EmeraldUmbrella()
		{
		}
	}
}
