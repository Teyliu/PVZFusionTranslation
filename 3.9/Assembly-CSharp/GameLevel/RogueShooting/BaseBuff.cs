using System;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CC7 RID: 3271
	[Token(Token = "0x2000CC7")]
	public abstract class BaseBuff
	{
		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x060043CC RID: 17356
		[Token(Token = "0x170005F1")]
		public abstract PlantType ShowType
		{
			[Token(Token = "0x60043CC")]
			[Address(Slot = "4")]
			get;
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x060043CD RID: 17357
		[Token(Token = "0x170005F2")]
		public abstract string Title
		{
			[Token(Token = "0x60043CD")]
			[Address(Slot = "5")]
			get;
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x060043CE RID: 17358
		[Token(Token = "0x170005F3")]
		public abstract string Description
		{
			[Token(Token = "0x60043CE")]
			[Address(Slot = "6")]
			get;
		}

		// Token: 0x060043CF RID: 17359
		[Token(Token = "0x60043CF")]
		[Address(Slot = "7")]
		public abstract void OnGet();

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x060043D0 RID: 17360 RVA: 0x00161B58 File Offset: 0x0015FD58
		[Token(Token = "0x170005F4")]
		public virtual int MaxCount
		{
			[Token(Token = "0x60043D0")]
			[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "8")]
			get
			{
				return 10;
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x060043D1 RID: 17361 RVA: 0x00161B68 File Offset: 0x0015FD68
		[Token(Token = "0x170005F5")]
		public virtual bool CanAppear
		{
			[Token(Token = "0x60043D1")]
			[Address(RVA = "0x3F1E60", Offset = "0x3F0460", VA = "0x1803F1E60", Slot = "9")]
			get
			{
				return true;
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x060043D2 RID: 17362 RVA: 0x00161B78 File Offset: 0x0015FD78
		[Token(Token = "0x170005F6")]
		public virtual bool Passive
		{
			[Token(Token = "0x60043D2")]
			[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "10")]
			get
			{
				return false;
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x060043D3 RID: 17363 RVA: 0x00161B88 File Offset: 0x0015FD88
		[Token(Token = "0x170005F7")]
		public virtual float AppearWeight
		{
			[Token(Token = "0x60043D3")]
			[Address(RVA = "0x88F620", Offset = "0x88DC20", VA = "0x18088F620", Slot = "11")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x060043D4 RID: 17364 RVA: 0x00161B9C File Offset: 0x0015FD9C
		[Token(Token = "0x170005F8")]
		protected string PlantName
		{
			[Token(Token = "0x60043D4")]
			[Address(RVA = "0x88F630", Offset = "0x88DC30", VA = "0x18088F630")]
			get
			{
				int showType = (int)this.ShowType;
				string text;
				return text;
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x060043D5 RID: 17365 RVA: 0x00161BB4 File Offset: 0x0015FDB4
		[Token(Token = "0x170005F9")]
		protected Plant Plant
		{
			[Token(Token = "0x60043D5")]
			[Address(RVA = "0x88F660", Offset = "0x88DC60", VA = "0x18088F660")]
			get
			{
				ShootingManager instance = ShootingManager.Instance;
				PlantType showType = this.ShowType;
				throw new NullReferenceException();
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x060043D6 RID: 17366
		[Token(Token = "0x170005FA")]
		public abstract Quality Rarity
		{
			[Token(Token = "0x60043D6")]
			[Address(Slot = "12")]
			get;
		}

		// Token: 0x060043D7 RID: 17367 RVA: 0x00161BD8 File Offset: 0x0015FDD8
		[Token(Token = "0x60043D7")]
		[Address(RVA = "0x88F580", Offset = "0x88DB80", VA = "0x18088F580")]
		protected void SafeModify(Action<Plant> action)
		{
			Plant plant = this.Plant;
			int num = 0;
			if (plant != num && action != 0)
			{
				Plant plant2 = this.Plant;
			}
		}

		// Token: 0x060043D8 RID: 17368 RVA: 0x00161C04 File Offset: 0x0015FE04
		[Token(Token = "0x60043D8")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		protected BaseBuff()
		{
		}
	}
}
