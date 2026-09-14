using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D46 RID: 3398
	[Token(Token = "0x2000D46")]
	public class ThreePeater : BaseConfig
	{
		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x060046A8 RID: 18088 RVA: 0x00166AD8 File Offset: 0x00164CD8
		[Token(Token = "0x170007BB")]
		public override string Role
		{
			[Token(Token = "0x60046A8")]
			[Address(RVA = "0x8B8EB0", Offset = "0x8B74B0", VA = "0x1808B8EB0", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x060046A9 RID: 18089 RVA: 0x00166AEC File Offset: 0x00164CEC
		[Token(Token = "0x170007BC")]
		public override PlantType PlantType
		{
			[Token(Token = "0x60046A9")]
			[Address(RVA = "0x714BD0", Offset = "0x7131D0", VA = "0x180714BD0", Slot = "4")]
			get
			{
				return PlantType.ThreePeater;
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x060046AA RID: 18090 RVA: 0x00166AFC File Offset: 0x00164CFC
		[Token(Token = "0x170007BD")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x60046AA")]
			[Address(RVA = "0x8B8D10", Offset = "0x8B7310", VA = "0x1808B8D10", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x060046AB RID: 18091 RVA: 0x00166B30 File Offset: 0x00164D30
		[Token(Token = "0x60046AB")]
		[Address(RVA = "0x8A89C0", Offset = "0x8A6FC0", VA = "0x1808A89C0", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
			int num = 0;
			int num2 = 0;
			plant.ModifyDamage((PlantDamageAdder)((uint)14), 9f, num2 != 0, num);
		}

		// Token: 0x060046AC RID: 18092 RVA: 0x00166B58 File Offset: 0x00164D58
		[Token(Token = "0x60046AC")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public ThreePeater()
		{
		}
	}
}
