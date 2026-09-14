using System;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C0B RID: 3083
	[Token(Token = "0x2000C0B")]
	public abstract class BaseBuff
	{
		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06004054 RID: 16468
		[Token(Token = "0x170004CA")]
		public abstract PlantType ShowType
		{
			[Token(Token = "0x6004054")]
			[Address(Slot = "4")]
			get;
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06004055 RID: 16469
		[Token(Token = "0x170004CB")]
		public abstract string Title
		{
			[Token(Token = "0x6004055")]
			[Address(Slot = "5")]
			get;
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06004056 RID: 16470
		[Token(Token = "0x170004CC")]
		public abstract string Description
		{
			[Token(Token = "0x6004056")]
			[Address(Slot = "6")]
			get;
		}

		// Token: 0x06004057 RID: 16471
		[Token(Token = "0x6004057")]
		[Address(Slot = "7")]
		public abstract void OnGet();

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06004058 RID: 16472 RVA: 0x00155160 File Offset: 0x00153360
		[Token(Token = "0x170004CD")]
		public virtual int MaxCount
		{
			[Token(Token = "0x6004058")]
			[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "8")]
			get
			{
				return 10;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06004059 RID: 16473 RVA: 0x00155170 File Offset: 0x00153370
		[Token(Token = "0x170004CE")]
		public virtual bool CanAppear
		{
			[Token(Token = "0x6004059")]
			[Address(RVA = "0x3A5ED0", Offset = "0x3A44D0", VA = "0x1803A5ED0", Slot = "9")]
			get
			{
				return true;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x0600405A RID: 16474 RVA: 0x00155180 File Offset: 0x00153380
		[Token(Token = "0x170004CF")]
		public virtual bool Passive
		{
			[Token(Token = "0x600405A")]
			[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "10")]
			get
			{
				return false;
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x0600405B RID: 16475 RVA: 0x00155190 File Offset: 0x00153390
		[Token(Token = "0x170004D0")]
		public virtual float AppearWeight
		{
			[Token(Token = "0x600405B")]
			[Address(RVA = "0x80B840", Offset = "0x809E40", VA = "0x18080B840", Slot = "11")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x0600405C RID: 16476 RVA: 0x001551A4 File Offset: 0x001533A4
		[Token(Token = "0x170004D1")]
		protected string PlantName
		{
			[Token(Token = "0x600405C")]
			[Address(RVA = "0x80B850", Offset = "0x809E50", VA = "0x18080B850")]
			get
			{
				int showType = (int)this.ShowType;
				string text;
				return text;
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x0600405D RID: 16477 RVA: 0x001551BC File Offset: 0x001533BC
		[Token(Token = "0x170004D2")]
		protected Plant Plant
		{
			[Token(Token = "0x600405D")]
			[Address(RVA = "0x80B880", Offset = "0x809E80", VA = "0x18080B880")]
			get
			{
				ShootingManager instance = ShootingManager.Instance;
				PlantType showType = this.ShowType;
				throw new NullReferenceException();
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x0600405E RID: 16478
		[Token(Token = "0x170004D3")]
		public abstract Quality Rarity
		{
			[Token(Token = "0x600405E")]
			[Address(Slot = "12")]
			get;
		}

		// Token: 0x0600405F RID: 16479 RVA: 0x001551E0 File Offset: 0x001533E0
		[Token(Token = "0x600405F")]
		[Address(RVA = "0x80B7A0", Offset = "0x809DA0", VA = "0x18080B7A0")]
		protected void SafeModify(Action<Plant> action)
		{
			Plant plant = this.Plant;
			int num = 0;
			if (plant != num && action != 0)
			{
				Plant plant2 = this.Plant;
			}
		}

		// Token: 0x06004060 RID: 16480 RVA: 0x0015520C File Offset: 0x0015340C
		[Token(Token = "0x6004060")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		protected BaseBuff()
		{
		}
	}
}
