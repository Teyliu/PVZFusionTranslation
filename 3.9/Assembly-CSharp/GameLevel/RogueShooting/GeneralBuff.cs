using System;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CC8 RID: 3272
	[Token(Token = "0x2000CC8")]
	public abstract class GeneralBuff : BaseBuff
	{
		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x060043D9 RID: 17369 RVA: 0x00161C18 File Offset: 0x0015FE18
		[Token(Token = "0x170005FB")]
		public override int MaxCount
		{
			[Token(Token = "0x60043D9")]
			[Address(RVA = "0x3F8C00", Offset = "0x3F7200", VA = "0x1803F8C00", Slot = "8")]
			get
			{
				return 1000;
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x060043DA RID: 17370 RVA: 0x00161C2C File Offset: 0x0015FE2C
		[Token(Token = "0x170005FC")]
		public override PlantType ShowType
		{
			[Token(Token = "0x60043DA")]
			[Address(RVA = "0x3E8430", Offset = "0x3E6A30", VA = "0x1803E8430", Slot = "4")]
			get
			{
				return this.plantType;
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x060043DB RID: 17371 RVA: 0x00161C40 File Offset: 0x0015FE40
		[Token(Token = "0x170005FD")]
		public override Quality Rarity
		{
			[Token(Token = "0x60043DB")]
			[Address(RVA = "0x3EB740", Offset = "0x3E9D40", VA = "0x1803EB740", Slot = "12")]
			get
			{
				return this.randomQuality;
			}
		}

		// Token: 0x060043DC RID: 17372 RVA: 0x00161C54 File Offset: 0x0015FE54
		[Token(Token = "0x60043DC")]
		[Address(RVA = "0x7F15D0", Offset = "0x7EFBD0", VA = "0x1807F15D0")]
		public void ForceSetQuality(Quality quality)
		{
			this.randomQuality = quality;
		}

		// Token: 0x060043DD RID: 17373 RVA: 0x00161C68 File Offset: 0x0015FE68
		[Token(Token = "0x60043DD")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		protected GeneralBuff()
		{
		}

		// Token: 0x04003355 RID: 13141
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003355")]
		protected PlantType plantType;

		// Token: 0x04003356 RID: 13142
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4003356")]
		protected Quality randomQuality;
	}
}
