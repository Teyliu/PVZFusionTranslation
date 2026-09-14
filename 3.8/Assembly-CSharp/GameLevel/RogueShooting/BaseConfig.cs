using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C0A RID: 3082
	[Token(Token = "0x2000C0A")]
	public abstract class BaseConfig
	{
		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x0600404E RID: 16462
		[Token(Token = "0x170004C6")]
		public abstract PlantType PlantType
		{
			[Token(Token = "0x600404E")]
			[Address(Slot = "4")]
			get;
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x0600404F RID: 16463
		[Token(Token = "0x170004C7")]
		public abstract List<BaseBuff> Buffs
		{
			[Token(Token = "0x600404F")]
			[Address(Slot = "5")]
			get;
		}

		// Token: 0x06004050 RID: 16464
		[Token(Token = "0x6004050")]
		[Address(Slot = "6")]
		public abstract void ReinforcePlant(Plant plant);

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06004051 RID: 16465
		[Token(Token = "0x170004C8")]
		public abstract string Role
		{
			[Token(Token = "0x6004051")]
			[Address(Slot = "7")]
			get;
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06004052 RID: 16466 RVA: 0x00155128 File Offset: 0x00153328
		[Token(Token = "0x170004C9")]
		protected Plant Plant
		{
			[Token(Token = "0x6004052")]
			[Address(RVA = "0x80B920", Offset = "0x809F20", VA = "0x18080B920")]
			get
			{
				ShootingManager instance = ShootingManager.Instance;
				PlantType plantType = this.PlantType;
				throw new NullReferenceException();
			}
		}

		// Token: 0x06004053 RID: 16467 RVA: 0x0015514C File Offset: 0x0015334C
		[Token(Token = "0x6004053")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		protected BaseConfig()
		{
		}
	}
}
