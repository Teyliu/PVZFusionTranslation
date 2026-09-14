using System;
using Cpp2IlInjected;

// Token: 0x02000548 RID: 1352
[Token(Token = "0x2000548")]
public class IronCorn : Cornpult
{
	// Token: 0x0600192A RID: 6442 RVA: 0x00088688 File Offset: 0x00086888
	[Token(Token = "0x600192A")]
	[Address(RVA = "0x52C4C0", Offset = "0x52AAC0", VA = "0x18052C4C0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_kernal_iron;
	}

	// Token: 0x0600192B RID: 6443 RVA: 0x00088698 File Offset: 0x00086898
	[Token(Token = "0x600192B")]
	[Address(RVA = "0x52C4B0", Offset = "0x52AAB0", VA = "0x18052C4B0", Slot = "78")]
	protected override BulletType GetBulletType2()
	{
		return BulletType.Bullet_butter_iron;
	}

	// Token: 0x0600192C RID: 6444 RVA: 0x000886A8 File Offset: 0x000868A8
	[Token(Token = "0x600192C")]
	[Address(RVA = "0x474940", Offset = "0x472F40", VA = "0x180474940")]
	public IronCorn()
	{
	}
}
