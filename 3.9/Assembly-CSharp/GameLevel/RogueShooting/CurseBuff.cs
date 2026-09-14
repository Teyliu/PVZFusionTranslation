using System;
using Cpp2IlInjected;
using UI;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CCE RID: 3278
	[Token(Token = "0x2000CCE")]
	public abstract class CurseBuff : BaseBuff
	{
		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x060043FA RID: 17402 RVA: 0x00162264 File Offset: 0x00160464
		[Token(Token = "0x1700060F")]
		public override bool CanAppear
		{
			[Token(Token = "0x60043FA")]
			[Address(RVA = "0x88F7B0", Offset = "0x88DDB0", VA = "0x18088F7B0", Slot = "9")]
			get
			{
				return ShootingManager.Instance.hellMode;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x060043FB RID: 17403 RVA: 0x00162284 File Offset: 0x00160484
		[Token(Token = "0x17000610")]
		public override bool Passive
		{
			[Token(Token = "0x60043FB")]
			[Address(RVA = "0x3F1E60", Offset = "0x3F0460", VA = "0x1803F1E60", Slot = "10")]
			get
			{
				return true;
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x060043FC RID: 17404 RVA: 0x00162294 File Offset: 0x00160494
		[Token(Token = "0x17000611")]
		public override int MaxCount
		{
			[Token(Token = "0x60043FC")]
			[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "8")]
			get
			{
				return 1;
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x060043FD RID: 17405 RVA: 0x001622A4 File Offset: 0x001604A4
		[Token(Token = "0x17000612")]
		public override float AppearWeight
		{
			[Token(Token = "0x60043FD")]
			[Address(RVA = "0x88F7A0", Offset = "0x88DDA0", VA = "0x18088F7A0", Slot = "11")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x060043FE RID: 17406 RVA: 0x001622B8 File Offset: 0x001604B8
		[Token(Token = "0x17000613")]
		public override Quality Rarity
		{
			[Token(Token = "0x60043FE")]
			[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "12")]
			get
			{
				return Quality.curse;
			}
		}

		// Token: 0x060043FF RID: 17407 RVA: 0x001622C8 File Offset: 0x001604C8
		[Token(Token = "0x60043FF")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		protected CurseBuff()
		{
		}
	}
}
