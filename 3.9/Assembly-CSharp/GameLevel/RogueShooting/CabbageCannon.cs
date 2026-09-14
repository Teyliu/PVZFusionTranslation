using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D73 RID: 3443
	[Token(Token = "0x2000D73")]
	public class CabbageCannon : BaseConfig
	{
		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x060047A5 RID: 18341 RVA: 0x00168AE8 File Offset: 0x00166CE8
		[Token(Token = "0x17000851")]
		public override string Role
		{
			[Token(Token = "0x60047A5")]
			[Address(RVA = "0x8A8F30", Offset = "0x8A7530", VA = "0x1808A8F30", Slot = "7")]
			get
			{
				return "输出";
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x060047A6 RID: 18342 RVA: 0x00168AFC File Offset: 0x00166CFC
		[Token(Token = "0x17000852")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60047A6")]
			[Address(RVA = "0x8A8F20", Offset = "0x8A7520", VA = "0x1808A8F20", Slot = "4")]
			get
			{
				return PlantType.CabbageCannon;
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x060047A7 RID: 18343 RVA: 0x00168B10 File Offset: 0x00166D10
		[Token(Token = "0x17000853")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60047A7")]
			[Address(RVA = "0x8A8E10", Offset = "0x8A7410", VA = "0x1808A8E10", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x060047A8 RID: 18344 RVA: 0x00168B3C File Offset: 0x00166D3C
		[Token(Token = "0x60047A8")]
		[Address(RVA = "0x8A89C0", Offset = "0x8A6FC0", VA = "0x1808A89C0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 9f, num2 != 0, num);
		}

		// Token: 0x060047A9 RID: 18345 RVA: 0x00168B64 File Offset: 0x00166D64
		[Token(Token = "0x60047A9")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public CabbageCannon()
		{
		}
	}
}
