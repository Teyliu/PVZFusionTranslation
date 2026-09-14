using System;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C0C RID: 3084
	[Token(Token = "0x2000C0C")]
	public abstract class GeneralBuff : BaseBuff
	{
		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06004061 RID: 16481 RVA: 0x00155220 File Offset: 0x00153420
		[Token(Token = "0x170004D4")]
		public override int MaxCount
		{
			[Token(Token = "0x6004061")]
			[Address(RVA = "0x3ACD90", Offset = "0x3AB390", VA = "0x1803ACD90", Slot = "8")]
			get
			{
				return 1000;
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06004062 RID: 16482 RVA: 0x00155234 File Offset: 0x00153434
		[Token(Token = "0x170004D5")]
		public override PlantType ShowType
		{
			[Token(Token = "0x6004062")]
			[Address(RVA = "0x39C420", Offset = "0x39AA20", VA = "0x18039C420", Slot = "4")]
			get
			{
				return this.plantType;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06004063 RID: 16483 RVA: 0x00155248 File Offset: 0x00153448
		[Token(Token = "0x170004D6")]
		public override Quality Rarity
		{
			[Token(Token = "0x6004063")]
			[Address(RVA = "0x78AF10", Offset = "0x789510", VA = "0x18078AF10", Slot = "12")]
			get
			{
				return this.randomQuality;
			}
		}

		// Token: 0x06004064 RID: 16484 RVA: 0x0015525C File Offset: 0x0015345C
		[Token(Token = "0x6004064")]
		[Address(RVA = "0x78AF60", Offset = "0x789560", VA = "0x18078AF60")]
		public void ForceSetQuality(Quality quality)
		{
			this.randomQuality = quality;
		}

		// Token: 0x06004065 RID: 16485 RVA: 0x00155270 File Offset: 0x00153470
		[Token(Token = "0x6004065")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		protected GeneralBuff()
		{
		}

		// Token: 0x040030E8 RID: 12520
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40030E8")]
		protected PlantType plantType;

		// Token: 0x040030E9 RID: 12521
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40030E9")]
		protected Quality randomQuality;
	}
}
