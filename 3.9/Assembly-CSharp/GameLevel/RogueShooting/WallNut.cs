using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CEE RID: 3310
	[Token(Token = "0x2000CEE")]
	public class WallNut : BaseConfig
	{
		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x060044B8 RID: 17592 RVA: 0x001635B0 File Offset: 0x001617B0
		[Token(Token = "0x17000685")]
		public override string Role
		{
			[Token(Token = "0x60044B8")]
			[Address(RVA = "0x8C74A0", Offset = "0x8C5AA0", VA = "0x1808C74A0", Slot = "7")]
			get
			{
				return "输出/防御";
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x060044B9 RID: 17593 RVA: 0x001635C4 File Offset: 0x001617C4
		[Token(Token = "0x17000686")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60044B9")]
			[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "4")]
			get
			{
				return PlantType.WallNut;
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x060044BA RID: 17594 RVA: 0x001635D4 File Offset: 0x001617D4
		[Token(Token = "0x17000687")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60044BA")]
			[Address(RVA = "0x8C71F0", Offset = "0x8C57F0", VA = "0x1808C71F0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x060044BB RID: 17595 RVA: 0x00163618 File Offset: 0x00161818
		[Token(Token = "0x60044BB")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x060044BC RID: 17596 RVA: 0x00163628 File Offset: 0x00161828
		[Token(Token = "0x60044BC")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public WallNut()
		{
		}
	}
}
