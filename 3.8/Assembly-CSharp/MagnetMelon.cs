using System;
using Cpp2IlInjected;

// Token: 0x02000536 RID: 1334
[Token(Token = "0x2000536")]
public class MagnetMelon : Melonpult
{
	// Token: 0x060018D2 RID: 6354 RVA: 0x00086D00 File Offset: 0x00084F00
	[Token(Token = "0x60018D2")]
	[Address(RVA = "0x4D5B20", Offset = "0x4D4120", VA = "0x1804D5B20", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_melon_magnet;
	}

	// Token: 0x060018D3 RID: 6355 RVA: 0x00086D14 File Offset: 0x00084F14
	[Token(Token = "0x60018D3")]
	[Address(RVA = "0x41DAA0", Offset = "0x41C0A0", VA = "0x18041DAA0")]
	public MagnetMelon()
	{
	}
}
