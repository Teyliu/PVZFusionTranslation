using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A81 RID: 2689
	[Token(Token = "0x2000A81")]
	public class ThreeMine : PlantData
	{
		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06003744 RID: 14148 RVA: 0x0012798C File Offset: 0x00125B8C
		[Token(Token = "0x170002CD")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003744")]
			[Address(RVA = "0x77E970", Offset = "0x77CF70", VA = "0x18077E970", Slot = "4")]
			get
			{
				return PlantType.ThreeMine;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06003745 RID: 14149 RVA: 0x001279A0 File Offset: 0x00125BA0
		[Token(Token = "0x170002CE")]
		public override string Title
		{
			[Token(Token = "0x6003745")]
			[Address(RVA = "0x77EAA0", Offset = "0x77D0A0", VA = "0x18077EAA0", Slot = "5")]
			get
			{
				return "贪婪之手";
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06003746 RID: 14150 RVA: 0x001279B4 File Offset: 0x00125BB4
		[Token(Token = "0x170002CF")]
		public override string Description
		{
			[Token(Token = "0x6003746")]
			[Address(RVA = "0x77E940", Offset = "0x77CF40", VA = "0x18077E940", Slot = "6")]
			get
			{
				return "可以按星级为前台驯海游侠提供的羁绊增益";
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06003747 RID: 14151 RVA: 0x001279C8 File Offset: 0x00125BC8
		[Token(Token = "0x170002D0")]
		public override int Cost
		{
			[Token(Token = "0x6003747")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "8")]
			get
			{
				return 2;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06003748 RID: 14152 RVA: 0x001279D8 File Offset: 0x00125BD8
		[Token(Token = "0x170002D1")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003748")]
			[Address(RVA = "0x77E980", Offset = "0x77CF80", VA = "0x18077E980", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003749 RID: 14153 RVA: 0x00127A14 File Offset: 0x00125C14
		[Token(Token = "0x6003749")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public ThreeMine()
		{
		}
	}
}
