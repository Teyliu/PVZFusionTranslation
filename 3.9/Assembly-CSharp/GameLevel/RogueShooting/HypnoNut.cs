using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D2C RID: 3372
	[Token(Token = "0x2000D2C")]
	public class HypnoNut : BaseConfig
	{
		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06004618 RID: 17944 RVA: 0x00165B58 File Offset: 0x00163D58
		[Token(Token = "0x17000762")]
		public override string Role
		{
			[Token(Token = "0x6004618")]
			[Address(RVA = "0x8ADED0", Offset = "0x8AC4D0", VA = "0x1808ADED0", Slot = "7")]
			get
			{
				return "输出/辅助";
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06004619 RID: 17945 RVA: 0x00165B6C File Offset: 0x00163D6C
		[Token(Token = "0x17000763")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004619")]
			[Address(RVA = "0x8ADEC0", Offset = "0x8AC4C0", VA = "0x1808ADEC0", Slot = "4")]
			get
			{
				return PlantType.HypnoNut;
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x0600461A RID: 17946 RVA: 0x00165B80 File Offset: 0x00163D80
		[Token(Token = "0x17000764")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600461A")]
			[Address(RVA = "0x8ADDB0", Offset = "0x8AC3B0", VA = "0x1808ADDB0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x0600461B RID: 17947 RVA: 0x00165BAC File Offset: 0x00163DAC
		[Token(Token = "0x600461B")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x0600461C RID: 17948 RVA: 0x00165BBC File Offset: 0x00163DBC
		[Token(Token = "0x600461C")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public HypnoNut()
		{
		}
	}
}
