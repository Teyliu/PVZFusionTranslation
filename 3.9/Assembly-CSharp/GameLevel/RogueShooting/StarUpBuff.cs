using System;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CCC RID: 3276
	[Token(Token = "0x2000CCC")]
	public class StarUpBuff : BaseBuff
	{
		// Token: 0x060043EF RID: 17391 RVA: 0x0016213C File Offset: 0x0016033C
		[Token(Token = "0x60043EF")]
		[Address(RVA = "0x3FDAB0", Offset = "0x3FC0B0", VA = "0x1803FDAB0")]
		public StarUpBuff(PlantType target)
		{
			this.targetType = target;
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x060043F0 RID: 17392 RVA: 0x00162158 File Offset: 0x00160358
		[Token(Token = "0x17000609")]
		public override PlantType ShowType
		{
			[Token(Token = "0x60043F0")]
			[Address(RVA = "0x3E8430", Offset = "0x3E6A30", VA = "0x1803E8430", Slot = "4")]
			get
			{
				return this.targetType;
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x060043F1 RID: 17393 RVA: 0x0016216C File Offset: 0x0016036C
		[Token(Token = "0x1700060A")]
		public override string Title
		{
			[Token(Token = "0x60043F1")]
			[Address(RVA = "0x8A1440", Offset = "0x89FA40", VA = "0x1808A1440", Slot = "5")]
			get
			{
				return "超进化：星辉";
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x060043F2 RID: 17394 RVA: 0x00162180 File Offset: 0x00160380
		[Token(Token = "0x1700060B")]
		public override string Description
		{
			[Token(Token = "0x60043F2")]
			[Address(RVA = "0x8A13F0", Offset = "0x89F9F0", VA = "0x1808A13F0", Slot = "6")]
			get
			{
				return Lawnf.GetName(this.targetType) + "升级成星辉形态";
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x060043F3 RID: 17395 RVA: 0x001621A4 File Offset: 0x001603A4
		[Token(Token = "0x1700060C")]
		public override int MaxCount
		{
			[Token(Token = "0x60043F3")]
			[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
			get
			{
				return 1;
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x060043F4 RID: 17396 RVA: 0x001621B4 File Offset: 0x001603B4
		[Token(Token = "0x1700060D")]
		public override float AppearWeight
		{
			[Token(Token = "0x60043F4")]
			[Address(RVA = "0x8A13E0", Offset = "0x89F9E0", VA = "0x1808A13E0", Slot = "11")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x060043F5 RID: 17397 RVA: 0x001621C8 File Offset: 0x001603C8
		[Token(Token = "0x1700060E")]
		public override Quality Rarity
		{
			[Token(Token = "0x60043F5")]
			[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "12")]
			get
			{
				return Quality.iridescent;
			}
		}

		// Token: 0x060043F6 RID: 17398 RVA: 0x001621D8 File Offset: 0x001603D8
		[Token(Token = "0x60043F6")]
		[Address(RVA = "0x8A1270", Offset = "0x89F870", VA = "0x1808A1270", Slot = "7")]
		public override void OnGet()
		{
			Action<Plant> <>9__14_ = StarUpBuff.<>c.<>9__14_0;
			if (<>9__14_ == 0)
			{
				Action<Plant> action;
				StarUpBuff.<>c.<>9__14_0 = action;
			}
			Plant plant = base.Plant;
			int num = 0;
			if (plant != num && <>9__14_ != 0)
			{
				Plant plant2 = base.Plant;
			}
		}

		// Token: 0x0400335B RID: 13147
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400335B")]
		private readonly PlantType targetType;
	}
}
