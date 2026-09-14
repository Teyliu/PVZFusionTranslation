using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CC6 RID: 3270
	[Token(Token = "0x2000CC6")]
	public abstract class BaseConfig
	{
		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x060043C6 RID: 17350
		[Token(Token = "0x170005ED")]
		public abstract PlantType PlantType
		{
			[Token(Token = "0x60043C6")]
			[Address(Slot = "4")]
			get;
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x060043C7 RID: 17351
		[Token(Token = "0x170005EE")]
		public abstract List<BaseBuff> Buffs
		{
			[Token(Token = "0x60043C7")]
			[Address(Slot = "5")]
			get;
		}

		// Token: 0x060043C8 RID: 17352
		[Token(Token = "0x60043C8")]
		[Address(Slot = "6")]
		public abstract void ReinforcePlant(Plant plant);

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x060043C9 RID: 17353
		[Token(Token = "0x170005EF")]
		public abstract string Role
		{
			[Token(Token = "0x60043C9")]
			[Address(Slot = "7")]
			get;
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x060043CA RID: 17354 RVA: 0x00161B20 File Offset: 0x0015FD20
		[Token(Token = "0x170005F0")]
		protected Plant Plant
		{
			[Token(Token = "0x60043CA")]
			[Address(RVA = "0x88F700", Offset = "0x88DD00", VA = "0x18088F700")]
			get
			{
				ShootingManager instance = ShootingManager.Instance;
				PlantType plantType = this.PlantType;
				throw new NullReferenceException();
			}
		}

		// Token: 0x060043CB RID: 17355 RVA: 0x00161B44 File Offset: 0x0015FD44
		[Token(Token = "0x60043CB")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		protected BaseConfig()
		{
		}
	}
}
