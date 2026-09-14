using System;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C0F RID: 3087
	[Token(Token = "0x2000C0F")]
	public class UpgradeBuff : BaseBuff
	{
		// Token: 0x06004071 RID: 16497 RVA: 0x001554E8 File Offset: 0x001536E8
		[Token(Token = "0x6004071")]
		[Address(RVA = "0x846AD0", Offset = "0x8450D0", VA = "0x180846AD0")]
		public UpgradeBuff(PlantType source, PlantType target)
		{
			this.sourceType = source;
			this.targetType = target;
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06004072 RID: 16498 RVA: 0x00155510 File Offset: 0x00153710
		[Token(Token = "0x170004DE")]
		public override PlantType ShowType
		{
			[Token(Token = "0x6004072")]
			[Address(RVA = "0x78AF10", Offset = "0x789510", VA = "0x18078AF10", Slot = "4")]
			get
			{
				return this.targetType;
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06004073 RID: 16499 RVA: 0x00155524 File Offset: 0x00153724
		[Token(Token = "0x170004DF")]
		public override string Title
		{
			[Token(Token = "0x6004073")]
			[Address(RVA = "0x846B70", Offset = "0x845170", VA = "0x180846B70", Slot = "5")]
			get
			{
				return "升级";
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06004074 RID: 16500 RVA: 0x00155538 File Offset: 0x00153738
		[Token(Token = "0x170004E0")]
		public override string Description
		{
			[Token(Token = "0x6004074")]
			[Address(RVA = "0x846B10", Offset = "0x845110", VA = "0x180846B10", Slot = "6")]
			get
			{
				string name = Lawnf.GetName(this.sourceType);
				string name2 = Lawnf.GetName(this.targetType);
				return name + "升级到" + name2;
			}
		}

		// Token: 0x06004075 RID: 16501 RVA: 0x0015556C File Offset: 0x0015376C
		[Token(Token = "0x6004075")]
		[Address(RVA = "0x846A70", Offset = "0x845070", VA = "0x180846A70", Slot = "7")]
		public override void OnGet()
		{
			ShootingManager instance = ShootingManager.Instance;
			PlantType plantType = this.targetType;
			PlantType plantType2 = this.sourceType;
			instance.UpgradePlant(plantType2, plantType);
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06004076 RID: 16502 RVA: 0x0015559C File Offset: 0x0015379C
		[Token(Token = "0x170004E1")]
		public override Quality Rarity
		{
			[Token(Token = "0x6004076")]
			[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "12")]
			get
			{
				return Quality.silver;
			}
		}

		// Token: 0x040030EC RID: 12524
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40030EC")]
		private readonly PlantType sourceType;

		// Token: 0x040030ED RID: 12525
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40030ED")]
		private readonly PlantType targetType;
	}
}
