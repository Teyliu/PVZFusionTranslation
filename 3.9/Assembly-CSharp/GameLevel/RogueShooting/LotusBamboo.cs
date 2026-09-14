using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000D98 RID: 3480
	[Token(Token = "0x2000D98")]
	public class LotusBamboo : BaseConfig
	{
		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06004878 RID: 18552 RVA: 0x0016A1DC File Offset: 0x001683DC
		[Token(Token = "0x170008D5")]
		public override string Role
		{
			[Token(Token = "0x6004878")]
			[Address(RVA = "0x8AEEE0", Offset = "0x8AD4E0", VA = "0x1808AEEE0", Slot = "7")]
			get
			{
				return "防御";
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06004879 RID: 18553 RVA: 0x0016A1F0 File Offset: 0x001683F0
		[Token(Token = "0x170008D6")]
		public override PlantType PlantType
		{
			[Token(Token = "0x6004879")]
			[Address(RVA = "0x8AEED0", Offset = "0x8AD4D0", VA = "0x1808AEED0", Slot = "4")]
			get
			{
				return PlantType.LotusBamboo;
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x0600487A RID: 18554 RVA: 0x0016A204 File Offset: 0x00168404
		[Token(Token = "0x170008D7")]
		public override List<BaseBuff> Buffs
		{
			[Token(Token = "0x600487A")]
			[Address(RVA = "0x8AEDC0", Offset = "0x8AD3C0", VA = "0x1808AEDC0", Slot = "5")]
			get
			{
				List<BaseBuff> list = new List();
				int size = list._size;
				return list;
			}
		}

		// Token: 0x0600487B RID: 18555 RVA: 0x0016A230 File Offset: 0x00168430
		[Token(Token = "0x600487B")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "6")]
		public override void ReinforcePlant(Plant plant)
		{
		}

		// Token: 0x0600487C RID: 18556 RVA: 0x0016A240 File Offset: 0x00168440
		[Token(Token = "0x600487C")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public LotusBamboo()
		{
		}
	}
}
