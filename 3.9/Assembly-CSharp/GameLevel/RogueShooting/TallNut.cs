using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CF2 RID: 3314
	[Token(Token = "0x2000CF2")]
	public class TallNut : BaseConfig
	{
		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x060044CE RID: 17614 RVA: 0x00163820 File Offset: 0x00161A20
		[Token(Token = "0x17000693")]
		public override string Role
		{
			[Token(Token = "0x60044CE")]
			[Address(RVA = "0x8B89B0", Offset = "0x8B6FB0", VA = "0x1808B89B0", Slot = "7")]
			get
			{
				return "防御";
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x060044CF RID: 17615 RVA: 0x00163834 File Offset: 0x00161A34
		[Token(Token = "0x17000694")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60044CF")]
			[Address(RVA = "0x8B89A0", Offset = "0x8B6FA0", VA = "0x1808B89A0", Slot = "4")]
			get
			{
				return PlantType.TallNut;
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x060044D0 RID: 17616 RVA: 0x00163848 File Offset: 0x00161A48
		[Token(Token = "0x17000695")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60044D0")]
			[Address(RVA = "0x8B8890", Offset = "0x8B6E90", VA = "0x1808B8890", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060044D1 RID: 17617 RVA: 0x00163874 File Offset: 0x00161A74
		[Token(Token = "0x60044D1")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x060044D2 RID: 17618 RVA: 0x00163884 File Offset: 0x00161A84
		[Token(Token = "0x60044D2")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public TallNut()
		{
		}
	}
}
