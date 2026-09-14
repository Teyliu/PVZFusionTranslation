using System;
using Cpp2IlInjected;

// Token: 0x0200054C RID: 1356
[Token(Token = "0x200054C")]
public class JalaCorn : Cornpult
{
	// Token: 0x06001933 RID: 6451 RVA: 0x000887BC File Offset: 0x000869BC
	[Token(Token = "0x6001933")]
	[Address(RVA = "0x52C7D0", Offset = "0x52ADD0", VA = "0x18052C7D0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_kernal_jala;
	}

	// Token: 0x06001934 RID: 6452 RVA: 0x000887D0 File Offset: 0x000869D0
	[Token(Token = "0x6001934")]
	[Address(RVA = "0x52C7C0", Offset = "0x52ADC0", VA = "0x18052C7C0", Slot = "78")]
	protected override BulletType GetBulletType2()
	{
		return BulletType.Bullet_butter_jala;
	}

	// Token: 0x06001935 RID: 6453 RVA: 0x000887E4 File Offset: 0x000869E4
	[Token(Token = "0x6001935")]
	[Address(RVA = "0x474940", Offset = "0x472F40", VA = "0x180474940")]
	public JalaCorn()
	{
	}
}
