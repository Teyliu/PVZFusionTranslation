using System;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000C3B RID: 3131
	[Token(Token = "0x2000C3B")]
	[Serializable]
	public class ReinforceData
	{
		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x0600413A RID: 16698 RVA: 0x00157718 File Offset: 0x00155918
		[Token(Token = "0x1700050F")]
		public int TotalLevel
		{
			[Token(Token = "0x600413A")]
			[Address(RVA = "0x87E750", Offset = "0x87CD50", VA = "0x18087E750")]
			get
			{
				return this.speedLevel;
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x0600413B RID: 16699 RVA: 0x0015772C File Offset: 0x0015592C
		[Token(Token = "0x17000510")]
		public float Damage
		{
			[Token(Token = "0x600413B")]
			[Address(RVA = "0x87E6F0", Offset = "0x87CCF0", VA = "0x18087E6F0")]
			get
			{
				float num;
				return num;
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x0600413C RID: 16700 RVA: 0x00157740 File Offset: 0x00155940
		[Token(Token = "0x17000511")]
		public float Health
		{
			[Token(Token = "0x600413C")]
			[Address(RVA = "0x87E710", Offset = "0x87CD10", VA = "0x18087E710")]
			get
			{
				float num;
				return num;
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x0600413D RID: 16701 RVA: 0x00157754 File Offset: 0x00155954
		[Token(Token = "0x17000512")]
		public float Speed
		{
			[Token(Token = "0x600413D")]
			[Address(RVA = "0x87E730", Offset = "0x87CD30", VA = "0x18087E730")]
			get
			{
				float num;
				return num;
			}
		}

		// Token: 0x0600413E RID: 16702 RVA: 0x00157768 File Offset: 0x00155968
		[Token(Token = "0x600413E")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public ReinforceData()
		{
		}

		// Token: 0x04003203 RID: 12803
		[Token(Token = "0x4003203")]
		public const int MaxReinforceLevel = 20;

		// Token: 0x04003204 RID: 12804
		[Token(Token = "0x4003204")]
		public const float HealthPerLevel = 0.15f;

		// Token: 0x04003205 RID: 12805
		[Token(Token = "0x4003205")]
		public const float DamagePerLevel = 0.3f;

		// Token: 0x04003206 RID: 12806
		[Token(Token = "0x4003206")]
		public const float SpeedPerLevel = 0.2f;

		// Token: 0x04003207 RID: 12807
		[Token(Token = "0x4003207")]
		public const int CostMultiplier = 2;

		// Token: 0x04003208 RID: 12808
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003208")]
		public PlantType thePlantType;

		// Token: 0x04003209 RID: 12809
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4003209")]
		public int healthLevel;

		// Token: 0x0400320A RID: 12810
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400320A")]
		public int damageLevel;

		// Token: 0x0400320B RID: 12811
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400320B")]
		public int speedLevel;
	}
}
