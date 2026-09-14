using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D8B RID: 3467
	[Token(Token = "0x2000D8B")]
	public class Cornpult : BaseConfig
	{
		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x0600482F RID: 18479 RVA: 0x00169A3C File Offset: 0x00167C3C
		[Token(Token = "0x170008A8")]
		public override string Role
		{
			[Token(Token = "0x600482F")]
			[Address(RVA = "0x8AAAD0", Offset = "0x8A90D0", VA = "0x1808AAAD0", Slot = "7")]
			get
			{
				return "辅助";
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06004830 RID: 18480 RVA: 0x00169A50 File Offset: 0x00167C50
		[Token(Token = "0x170008A9")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004830")]
			[Address(RVA = "0x71BBC0", Offset = "0x71A1C0", VA = "0x18071BBC0", Slot = "4")]
			get
			{
				return PlantType.Cornpult;
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06004831 RID: 18481 RVA: 0x00169A60 File Offset: 0x00167C60
		[Token(Token = "0x170008AA")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x6004831")]
			[Address(RVA = "0x8AA9C0", Offset = "0x8A8FC0", VA = "0x1808AA9C0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x06004832 RID: 18482 RVA: 0x00169A8C File Offset: 0x00167C8C
		[Token(Token = "0x6004832")]
		[Address(RVA = "0x8AA970", Offset = "0x8A8F70", VA = "0x1808AA970", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 19f, num2 != 0, num);
			plant.AddSpeed(1f);
		}

		// Token: 0x06004833 RID: 18483 RVA: 0x00169AC0 File Offset: 0x00167CC0
		[Token(Token = "0x6004833")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public Cornpult()
		{
		}
	}
}
