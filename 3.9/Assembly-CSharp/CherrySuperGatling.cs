using System;
using Cpp2IlInjected;

// Token: 0x020004FB RID: 1275
[Token(Token = "0x20004FB")]
public class CherrySuperGatling : SuperGatling
{
	// Token: 0x060017FC RID: 6140 RVA: 0x000830FC File Offset: 0x000812FC
	[Token(Token = "0x60017FC")]
	[Address(RVA = "0x51EEF0", Offset = "0x51D4F0", VA = "0x18051EEF0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		float timer = this.timer;
		int num = 0;
		num += 178;
		return BulletType.Bullet_pea;
	}

	// Token: 0x060017FD RID: 6141 RVA: 0x00083128 File Offset: 0x00081328
	[Token(Token = "0x60017FD")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public CherrySuperGatling()
	{
	}
}
