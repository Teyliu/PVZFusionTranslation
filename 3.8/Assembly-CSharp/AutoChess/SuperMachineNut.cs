using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A9E RID: 2718
	[Token(Token = "0x2000A9E")]
	public class SuperMachineNut : PlantData
	{
		// Token: 0x1700035E RID: 862
		// (get) Token: 0x060037F2 RID: 14322 RVA: 0x00128B58 File Offset: 0x00126D58
		[Token(Token = "0x1700035E")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60037F2")]
			[Address(RVA = "0x778F10", Offset = "0x777510", VA = "0x180778F10", Slot = "4")]
			get
			{
				return PlantType.SuperMachineNut;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x060037F3 RID: 14323 RVA: 0x00128B6C File Offset: 0x00126D6C
		[Token(Token = "0x1700035F")]
		public override string Title
		{
			[Token(Token = "0x60037F3")]
			[Address(RVA = "0x779040", Offset = "0x777640", VA = "0x180779040", Slot = "5")]
			get
			{
				return "以剑为盾";
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x060037F4 RID: 14324 RVA: 0x00128B80 File Offset: 0x00126D80
		[Token(Token = "0x17000360")]
		public override string Description
		{
			[Token(Token = "0x60037F4")]
			[Address(RVA = "0x778EE0", Offset = "0x7774E0", VA = "0x180778EE0", Slot = "6")]
			get
			{
				return "我方小队受到伤害时为鱼丸提供能量，释放能量以回复生命值，并发动反击";
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x060037F5 RID: 14325 RVA: 0x00128B94 File Offset: 0x00126D94
		[Token(Token = "0x17000361")]
		public override int Cost
		{
			[Token(Token = "0x60037F5")]
			[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "8")]
			get
			{
				return 5;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x060037F6 RID: 14326 RVA: 0x00128BA4 File Offset: 0x00126DA4
		[Token(Token = "0x17000362")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60037F6")]
			[Address(RVA = "0x778F20", Offset = "0x777520", VA = "0x180778F20", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060037F7 RID: 14327 RVA: 0x00128BE0 File Offset: 0x00126DE0
		[Token(Token = "0x60037F7")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public SuperMachineNut()
		{
		}
	}
}
