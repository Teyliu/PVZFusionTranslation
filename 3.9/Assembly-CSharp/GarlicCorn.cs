using System;
using Cpp2IlInjected;

// Token: 0x02000520 RID: 1312
[Token(Token = "0x2000520")]
public class GarlicCorn : Cornpult
{
	// Token: 0x0600188C RID: 6284 RVA: 0x000852B8 File Offset: 0x000834B8
	[Token(Token = "0x600188C")]
	[Address(RVA = "0x524F60", Offset = "0x523560", VA = "0x180524F60", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_garlicKernal;
	}

	// Token: 0x0600188D RID: 6285 RVA: 0x000852C8 File Offset: 0x000834C8
	[Token(Token = "0x600188D")]
	[Address(RVA = "0x524F50", Offset = "0x523550", VA = "0x180524F50", Slot = "78")]
	protected override BulletType GetBulletType2()
	{
		return BulletType.Bullet_garlicButter;
	}

	// Token: 0x0600188E RID: 6286 RVA: 0x000852D8 File Offset: 0x000834D8
	[Token(Token = "0x600188E")]
	[Address(RVA = "0x474940", Offset = "0x472F40", VA = "0x180474940")]
	public GarlicCorn()
	{
	}
}
