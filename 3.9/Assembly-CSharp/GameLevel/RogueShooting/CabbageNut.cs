using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CF6 RID: 3318
	[Token(Token = "0x2000CF6")]
	public class CabbageNut : BaseConfig
	{
		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x060044E6 RID: 17638 RVA: 0x00163A70 File Offset: 0x00161C70
		[Token(Token = "0x170006A3")]
		public override string Role
		{
			[Token(Token = "0x60044E6")]
			[Address(RVA = "0x8A9080", Offset = "0x8A7680", VA = "0x1808A9080", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x060044E7 RID: 17639 RVA: 0x00163A84 File Offset: 0x00161C84
		[Token(Token = "0x170006A4")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60044E7")]
			[Address(RVA = "0x8A9070", Offset = "0x8A7670", VA = "0x1808A9070", Slot = "4")]
			get
			{
				return PlantType.CabbageNut;
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x060044E8 RID: 17640 RVA: 0x00163A98 File Offset: 0x00161C98
		[Token(Token = "0x170006A5")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60044E8")]
			[Address(RVA = "0x8A8F60", Offset = "0x8A7560", VA = "0x1808A8F60", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060044E9 RID: 17641 RVA: 0x00163AC4 File Offset: 0x00161CC4
		[Token(Token = "0x60044E9")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x060044EA RID: 17642 RVA: 0x00163AD4 File Offset: 0x00161CD4
		[Token(Token = "0x60044EA")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public CabbageNut()
		{
		}
	}
}
