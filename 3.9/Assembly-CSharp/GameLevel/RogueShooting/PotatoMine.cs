using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D06 RID: 3334
	[Token(Token = "0x2000D06")]
	public class PotatoMine : BaseConfig
	{
		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06004538 RID: 17720 RVA: 0x001643FC File Offset: 0x001625FC
		[Token(Token = "0x170006D0")]
		public override string Role
		{
			[Token(Token = "0x6004538")]
			[Address(RVA = "0x8B14E0", Offset = "0x8AFAE0", VA = "0x1808B14E0", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06004539 RID: 17721 RVA: 0x00164410 File Offset: 0x00162610
		[Token(Token = "0x170006D1")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004539")]
			[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "4")]
			get
			{
				return PlantType.PotatoMine;
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x0600453A RID: 17722 RVA: 0x00164420 File Offset: 0x00162620
		[Token(Token = "0x170006D2")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600453A")]
			[Address(RVA = "0x8B13D0", Offset = "0x8AF9D0", VA = "0x1808B13D0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x0600453B RID: 17723 RVA: 0x0016444C File Offset: 0x0016264C
		[Token(Token = "0x600453B")]
		[Address(RVA = "0x8B1370", Offset = "0x8AF970", VA = "0x1808B1370", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			plant.AddSpeed(5f);
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 1f, num2 != 0, num);
		}

		// Token: 0x0600453C RID: 17724 RVA: 0x00164480 File Offset: 0x00162680
		[Token(Token = "0x600453C")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public PotatoMine()
		{
		}
	}
}
