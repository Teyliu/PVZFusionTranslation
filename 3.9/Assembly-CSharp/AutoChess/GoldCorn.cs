using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000AC3 RID: 2755
	[Token(Token = "0x2000AC3")]
	public class GoldCorn : PlantData
	{
		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06003894 RID: 14484 RVA: 0x0012CCF4 File Offset: 0x0012AEF4
		[Token(Token = "0x1700031F")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6003894")]
			[Address(RVA = "0x7D2260", Offset = "0x7D0860", VA = "0x1807D2260", Slot = "4")]
			get
			{
				return PlantType.GoldCorn;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06003895 RID: 14485 RVA: 0x0012CD08 File Offset: 0x0012AF08
		[Token(Token = "0x17000320")]
		public override string Title
		{
			[Token(Token = "0x6003895")]
			[Address(RVA = "0x7D2390", Offset = "0x7D0990", VA = "0x1807D2390", Slot = "5")]
			get
			{
				return "石破天惊";
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06003896 RID: 14486 RVA: 0x0012CD1C File Offset: 0x0012AF1C
		[Token(Token = "0x17000321")]
		public override string Description
		{
			[Token(Token = "0x6003896")]
			[Address(RVA = "0x7D2230", Offset = "0x7D0830", VA = "0x1807D2230", Slot = "6")]
			get
			{
				return "我方小队其他目标释放大招后，使玉米的大招能发射更多子弹";
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06003897 RID: 14487 RVA: 0x0012CD30 File Offset: 0x0012AF30
		[Token(Token = "0x17000322")]
		public override int Cost
		{
			[Token(Token = "0x6003897")]
			[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "8")]
			get
			{
				return 3;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06003898 RID: 14488 RVA: 0x0012CD40 File Offset: 0x0012AF40
		[Token(Token = "0x17000323")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x6003898")]
			[Address(RVA = "0x7D2270", Offset = "0x7D0870", VA = "0x1807D2270", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003899 RID: 14489 RVA: 0x0012CD7C File Offset: 0x0012AF7C
		[Token(Token = "0x6003899")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public GoldCorn()
		{
		}
	}
}
