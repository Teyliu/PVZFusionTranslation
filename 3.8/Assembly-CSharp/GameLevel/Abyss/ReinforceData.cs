using System;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000CD6 RID: 3286
	[Token(Token = "0x2000CD6")]
	[Serializable]
	public class ReinforceData
	{
		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x060044D0 RID: 17616 RVA: 0x0015D780 File Offset: 0x0015B980
		[Token(Token = "0x17000785")]
		public int TotalLevel
		{
			[Token(Token = "0x60044D0")]
			[Address(RVA = "0x835C00", Offset = "0x834200", VA = "0x180835C00")]
			get
			{
				return this.speedLevel;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x060044D1 RID: 17617 RVA: 0x0015D794 File Offset: 0x0015B994
		[Token(Token = "0x17000786")]
		public float Damage
		{
			[Token(Token = "0x60044D1")]
			[Address(RVA = "0x835BA0", Offset = "0x8341A0", VA = "0x180835BA0")]
			get
			{
				float num;
				return num;
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x060044D2 RID: 17618 RVA: 0x0015D7A8 File Offset: 0x0015B9A8
		[Token(Token = "0x17000787")]
		public float Health
		{
			[Token(Token = "0x60044D2")]
			[Address(RVA = "0x835BC0", Offset = "0x8341C0", VA = "0x180835BC0")]
			get
			{
				float num;
				return num;
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x060044D3 RID: 17619 RVA: 0x0015D7BC File Offset: 0x0015B9BC
		[Token(Token = "0x17000788")]
		public float Speed
		{
			[Token(Token = "0x60044D3")]
			[Address(RVA = "0x835BE0", Offset = "0x8341E0", VA = "0x180835BE0")]
			get
			{
				float num;
				return num;
			}
		}

		// Token: 0x060044D4 RID: 17620 RVA: 0x0015D7D0 File Offset: 0x0015B9D0
		[Token(Token = "0x60044D4")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public ReinforceData()
		{
		}

		// Token: 0x0400315E RID: 12638
		[Token(Token = "0x400315E")]
		public const int MaxReinforceLevel = 20;

		// Token: 0x0400315F RID: 12639
		[Token(Token = "0x400315F")]
		public const float HealthPerLevel = 0.15f;

		// Token: 0x04003160 RID: 12640
		[Token(Token = "0x4003160")]
		public const float DamagePerLevel = 0.3f;

		// Token: 0x04003161 RID: 12641
		[Token(Token = "0x4003161")]
		public const float SpeedPerLevel = 0.2f;

		// Token: 0x04003162 RID: 12642
		[Token(Token = "0x4003162")]
		public const int CostMultiplier = 2;

		// Token: 0x04003163 RID: 12643
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003163")]
		public PlantType thePlantType;

		// Token: 0x04003164 RID: 12644
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4003164")]
		public int healthLevel;

		// Token: 0x04003165 RID: 12645
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003165")]
		public int damageLevel;

		// Token: 0x04003166 RID: 12646
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4003166")]
		public int speedLevel;
	}
}
