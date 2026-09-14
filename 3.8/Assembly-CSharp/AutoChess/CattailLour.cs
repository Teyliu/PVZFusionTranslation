using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A9C RID: 2716
	[Token(Token = "0x2000A9C")]
	public class CattailLour : PlantData
	{
		// Token: 0x17000354 RID: 852
		// (get) Token: 0x060037E6 RID: 14310 RVA: 0x00128A20 File Offset: 0x00126C20
		[Token(Token = "0x17000354")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60037E6")]
			[Address(RVA = "0x767990", Offset = "0x765F90", VA = "0x180767990", Slot = "4")]
			get
			{
				return PlantType.CattailLour;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x060037E7 RID: 14311 RVA: 0x00128A34 File Offset: 0x00126C34
		[Token(Token = "0x17000355")]
		public override string Title
		{
			[Token(Token = "0x60037E7")]
			[Address(RVA = "0x767AC0", Offset = "0x7660C0", VA = "0x180767AC0", Slot = "5")]
			get
			{
				return "猪市";
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x060037E8 RID: 14312 RVA: 0x00128A48 File Offset: 0x00126C48
		[Token(Token = "0x17000356")]
		public override string Description
		{
			[Token(Token = "0x60037E8")]
			[Address(RVA = "0x767960", Offset = "0x765F60", VA = "0x180767960", Slot = "6")]
			get
			{
				return "每次击杀敌人有概率获得金币，我方小队击杀敌人后也会释放僚机，敌人受到的伤害提高";
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x060037E9 RID: 14313 RVA: 0x00128A5C File Offset: 0x00126C5C
		[Token(Token = "0x17000357")]
		public override int Cost
		{
			[Token(Token = "0x60037E9")]
			[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "8")]
			get
			{
				return 5;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x060037EA RID: 14314 RVA: 0x00128A6C File Offset: 0x00126C6C
		[Token(Token = "0x17000358")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60037EA")]
			[Address(RVA = "0x7679A0", Offset = "0x765FA0", VA = "0x1807679A0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060037EB RID: 14315 RVA: 0x00128AA8 File Offset: 0x00126CA8
		[Token(Token = "0x60037EB")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public CattailLour()
		{
		}
	}
}
