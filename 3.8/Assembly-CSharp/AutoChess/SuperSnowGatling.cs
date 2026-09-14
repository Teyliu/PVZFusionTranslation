using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace AutoChess
{
	// Token: 0x02000A90 RID: 2704
	[Token(Token = "0x2000A90")]
	public class SuperSnowGatling : PlantData
	{
		// Token: 0x17000318 RID: 792
		// (get) Token: 0x0600379E RID: 14238 RVA: 0x001282C8 File Offset: 0x001264C8
		[Token(Token = "0x17000318")]
		public override PlantType PlantType
		{
			[Token(Token = "0x600379E")]
			[Address(RVA = "0x7790A0", Offset = "0x7776A0", VA = "0x1807790A0", Slot = "4")]
			get
			{
				return PlantType.SuperSnowGatling;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x0600379F RID: 14239 RVA: 0x001282DC File Offset: 0x001264DC
		[Token(Token = "0x17000319")]
		public override string Title
		{
			[Token(Token = "0x600379F")]
			[Address(RVA = "0x779220", Offset = "0x777820", VA = "0x180779220", Slot = "5")]
			get
			{
				return "天河本怒涛";
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x060037A0 RID: 14240 RVA: 0x001282F0 File Offset: 0x001264F0
		[Token(Token = "0x1700031A")]
		public override string Description
		{
			[Token(Token = "0x60037A0")]
			[Address(RVA = "0x779070", Offset = "0x777670", VA = "0x180779070", Slot = "6")]
			get
			{
				return "被减速的敌人受到攻击时获得能量，满能量后释放大招攻击敌人";
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x060037A1 RID: 14241 RVA: 0x00128304 File Offset: 0x00126504
		[Token(Token = "0x1700031B")]
		public override int Cost
		{
			[Token(Token = "0x60037A1")]
			[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "8")]
			get
			{
				return 4;
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x060037A2 RID: 14242 RVA: 0x00128314 File Offset: 0x00126514
		[Token(Token = "0x1700031C")]
		public override List<SynergyType> Synergy
		{
			[Token(Token = "0x60037A2")]
			[Address(RVA = "0x7790B0", Offset = "0x7776B0", VA = "0x1807790B0", Slot = "7")]
			get
			{
				List<SynergyType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x060037A3 RID: 14243 RVA: 0x00128358 File Offset: 0x00126558
		[Token(Token = "0x60037A3")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public SuperSnowGatling()
		{
		}
	}
}
