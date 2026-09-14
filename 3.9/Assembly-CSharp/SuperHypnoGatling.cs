using System;
using Cpp2IlInjected;

// Token: 0x020005AE RID: 1454
[Token(Token = "0x20005AE")]
public class SuperHypnoGatling : SuperSnowGatling
{
	// Token: 0x06001AD8 RID: 6872 RVA: 0x0008FE9C File Offset: 0x0008E09C
	[Token(Token = "0x6001AD8")]
	[Address(RVA = "0x528020", Offset = "0x526620", VA = "0x180528020", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_hypnoPea;
	}

	// Token: 0x06001AD9 RID: 6873 RVA: 0x0008FEB0 File Offset: 0x0008E0B0
	[Token(Token = "0x6001AD9")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public SuperHypnoGatling()
	{
	}
}
