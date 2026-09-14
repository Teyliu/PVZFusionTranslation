using System;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C10 RID: 3088
	[Token(Token = "0x2000C10")]
	public class StarUpBuff : BaseBuff
	{
		// Token: 0x06004077 RID: 16503 RVA: 0x001555AC File Offset: 0x001537AC
		[Token(Token = "0x6004077")]
		[Address(RVA = "0x8396F0", Offset = "0x837CF0", VA = "0x1808396F0")]
		public StarUpBuff(PlantType target)
		{
			this.targetType = target;
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06004078 RID: 16504 RVA: 0x001555C8 File Offset: 0x001537C8
		[Token(Token = "0x170004E2")]
		public override PlantType ShowType
		{
			[Token(Token = "0x6004078")]
			[Address(RVA = "0x39C420", Offset = "0x39AA20", VA = "0x18039C420", Slot = "4")]
			get
			{
				return this.targetType;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06004079 RID: 16505 RVA: 0x001555DC File Offset: 0x001537DC
		[Token(Token = "0x170004E3")]
		public override string Title
		{
			[Token(Token = "0x6004079")]
			[Address(RVA = "0x839780", Offset = "0x837D80", VA = "0x180839780", Slot = "5")]
			get
			{
				return "超进化：星辉";
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x0600407A RID: 16506 RVA: 0x001555F0 File Offset: 0x001537F0
		[Token(Token = "0x170004E4")]
		public override string Description
		{
			[Token(Token = "0x600407A")]
			[Address(RVA = "0x839730", Offset = "0x837D30", VA = "0x180839730", Slot = "6")]
			get
			{
				return Lawnf.GetName(this.targetType) + "升级成星辉形态";
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x0600407B RID: 16507 RVA: 0x00155614 File Offset: 0x00153814
		[Token(Token = "0x170004E5")]
		public override int MaxCount
		{
			[Token(Token = "0x600407B")]
			[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "8")]
			get
			{
				return 1;
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x0600407C RID: 16508 RVA: 0x00155624 File Offset: 0x00153824
		[Token(Token = "0x170004E6")]
		public override float AppearWeight
		{
			[Token(Token = "0x600407C")]
			[Address(RVA = "0x839720", Offset = "0x837D20", VA = "0x180839720", Slot = "11")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x0600407D RID: 16509 RVA: 0x00155638 File Offset: 0x00153838
		[Token(Token = "0x170004E7")]
		public override Quality Rarity
		{
			[Token(Token = "0x600407D")]
			[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
			get
			{
				return Quality.diamond;
			}
		}

		// Token: 0x0600407E RID: 16510 RVA: 0x00155648 File Offset: 0x00153848
		[Token(Token = "0x600407E")]
		[Address(RVA = "0x8395E0", Offset = "0x837BE0", VA = "0x1808395E0", Slot = "7")]
		public override void OnGet()
		{
			Action<Plant> <>9__14_ = StarUpBuff.<>c.<>9__14_0;
			if (<>9__14_ == 0)
			{
				Action<Plant> action;
				StarUpBuff.<>c.<>9__14_0 = action;
			}
			base.SafeModify(<>9__14_);
		}

		// Token: 0x040030EE RID: 12526
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40030EE")]
		private readonly PlantType targetType;
	}
}
