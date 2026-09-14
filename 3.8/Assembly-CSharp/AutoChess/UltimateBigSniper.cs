using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A96 RID: 2710
	[Token(Token = "0x2000A96")]
	public class UltimateBigSniper : PlantData
	{
		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060037C2 RID: 14274 RVA: 0x00128678 File Offset: 0x00126878
		[Token(Token = "0x17000336")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60037C2")]
			[Address(RVA = "0x780FB0", Offset = "0x77F5B0", VA = "0x180780FB0", Slot = "4")]
			get
			{
				return PlantType.UltimateBigSniper;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x060037C3 RID: 14275 RVA: 0x0012868C File Offset: 0x0012688C
		[Token(Token = "0x17000337")]
		public override string Title
		{
			[Token(Token = "0x60037C3")]
			[Address(RVA = "0x7810E0", Offset = "0x77F6E0", VA = "0x1807810E0", Slot = "5")]
			get
			{
				return "精准打击";
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x060037C4 RID: 14276 RVA: 0x001286A0 File Offset: 0x001268A0
		[Token(Token = "0x17000338")]
		public override string Description
		{
			[Token(Token = "0x60037C4")]
			[Address(RVA = "0x780F80", Offset = "0x77F580", VA = "0x180780F80", Slot = "6")]
			get
			{
				return "场上敌人越多，全队幸运一击的伤害越高";
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x060037C5 RID: 14277 RVA: 0x001286B4 File Offset: 0x001268B4
		[Token(Token = "0x17000339")]
		public override int Cost
		{
			[Token(Token = "0x60037C5")]
			[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "8")]
			get
			{
				return 4;
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x060037C6 RID: 14278 RVA: 0x001286C4 File Offset: 0x001268C4
		[Token(Token = "0x1700033A")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60037C6")]
			[Address(RVA = "0x780FC0", Offset = "0x77F5C0", VA = "0x180780FC0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060037C7 RID: 14279 RVA: 0x00128700 File Offset: 0x00126900
		[Token(Token = "0x60037C7")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public UltimateBigSniper()
		{
		}
	}
}
