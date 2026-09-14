using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C5D RID: 3165
	[Token(Token = "0x2000C5D")]
	public class Shooting_丢失幸运 : BaseDebuff
	{
		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x060041FB RID: 16891 RVA: 0x0015B0C0 File Offset: 0x001592C0
		[Token(Token = "0x17000556")]
		public override int Point
		{
			[Token(Token = "0x60041FB")]
			[Address(RVA = "0x480D00", Offset = "0x47F300", VA = "0x180480D00", Slot = "21")]
			get
			{
				return 200;
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x060041FC RID: 16892 RVA: 0x0015B0D4 File Offset: 0x001592D4
		[Token(Token = "0x17000557")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x60041FC")]
			[Address(RVA = "0x88C7A0", Offset = "0x88ADA0", VA = "0x18088C7A0", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_丢失幸运;
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x060041FD RID: 16893 RVA: 0x0015B0E8 File Offset: 0x001592E8
		[Token(Token = "0x17000558")]
		public override string Description
		{
			[Token(Token = "0x60041FD")]
			[Address(RVA = "0x88C7B0", Offset = "0x88ADB0", VA = "0x18088C7B0", Slot = "13")]
			get
			{
				return "丢失幸运：幸运值降低75";
			}
		}

		// Token: 0x060041FE RID: 16894 RVA: 0x0015B0FC File Offset: 0x001592FC
		[Token(Token = "0x60041FE")]
		[Address(RVA = "0x88C730", Offset = "0x88AD30", VA = "0x18088C730", Slot = "17")]
		public override void OnSelect(Board board)
		{
			ShootingManager instance = ShootingManager.Instance;
			float lucky = instance._lucky;
			instance.Lucky = lucky;
		}

		// Token: 0x060041FF RID: 16895 RVA: 0x0015B124 File Offset: 0x00159324
		[Token(Token = "0x60041FF")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_丢失幸运()
		{
		}
	}
}
