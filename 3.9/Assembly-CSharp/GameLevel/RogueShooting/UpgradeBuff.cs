using System;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CCB RID: 3275
	[Token(Token = "0x2000CCB")]
	public class UpgradeBuff : BaseBuff
	{
		// Token: 0x060043E9 RID: 17385 RVA: 0x00162078 File Offset: 0x00160278
		[Token(Token = "0x60043E9")]
		[Address(RVA = "0x503D40", Offset = "0x502340", VA = "0x180503D40")]
		public UpgradeBuff(PlantType source, PlantType target)
		{
			this.sourceType = source;
			this.targetType = target;
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x060043EA RID: 17386 RVA: 0x001620A0 File Offset: 0x001602A0
		[Token(Token = "0x17000605")]
		public override PlantType ShowType
		{
			[Token(Token = "0x60043EA")]
			[Address(RVA = "0x3EB740", Offset = "0x3E9D40", VA = "0x1803EB740", Slot = "4")]
			get
			{
				return this.targetType;
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x060043EB RID: 17387 RVA: 0x001620B4 File Offset: 0x001602B4
		[Token(Token = "0x17000606")]
		public override string Title
		{
			[Token(Token = "0x60043EB")]
			[Address(RVA = "0x8A80D0", Offset = "0x8A66D0", VA = "0x1808A80D0", Slot = "5")]
			get
			{
				return "升级";
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x060043EC RID: 17388 RVA: 0x001620C8 File Offset: 0x001602C8
		[Token(Token = "0x17000607")]
		public override string Description
		{
			[Token(Token = "0x60043EC")]
			[Address(RVA = "0x8A8070", Offset = "0x8A6670", VA = "0x1808A8070", Slot = "6")]
			get
			{
				string name = Lawnf.GetName(this.sourceType);
				string name2 = Lawnf.GetName(this.targetType);
				return name + "升级到" + name2;
			}
		}

		// Token: 0x060043ED RID: 17389 RVA: 0x001620FC File Offset: 0x001602FC
		[Token(Token = "0x60043ED")]
		[Address(RVA = "0x8A8010", Offset = "0x8A6610", VA = "0x1808A8010", Slot = "7")]
		public override void OnGet()
		{
			ShootingManager instance = ShootingManager.Instance;
			PlantType plantType = this.targetType;
			PlantType plantType2 = this.sourceType;
			instance.UpgradePlant(plantType2, plantType);
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x060043EE RID: 17390 RVA: 0x0016212C File Offset: 0x0016032C
		[Token(Token = "0x17000608")]
		public override Quality Rarity
		{
			[Token(Token = "0x60043EE")]
			[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "12")]
			get
			{
				return Quality.silver;
			}
		}

		// Token: 0x04003359 RID: 13145
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003359")]
		private readonly PlantType sourceType;

		// Token: 0x0400335A RID: 13146
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400335A")]
		private readonly PlantType targetType;
	}
}
