using System;
using Cpp2IlInjected;

// Token: 0x02000503 RID: 1283
[Token(Token = "0x2000503")]
public class HelmetGatling : Shooter
{
	// Token: 0x060017F8 RID: 6136 RVA: 0x000827E0 File Offset: 0x000809E0
	[Token(Token = "0x60017F8")]
	[Address(RVA = "0x4CADA0", Offset = "0x4C93A0", VA = "0x1804CADA0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		int num = this.attributeCount;
		num++;
		this.attributeCount = num;
		if (num != 12)
		{
			return BulletType.Bullet_ironPea;
		}
		this.attributeCount = (int)((ulong)0L);
		return BulletType.Bullet_helmetPea;
	}

	// Token: 0x060017F9 RID: 6137 RVA: 0x00082818 File Offset: 0x00080A18
	[Token(Token = "0x60017F9")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public HelmetGatling()
	{
	}
}
