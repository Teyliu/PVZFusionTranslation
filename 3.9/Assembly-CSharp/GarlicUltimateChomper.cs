using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003A4 RID: 932
[Token(Token = "0x20003A4")]
public class GarlicUltimateChomper : UltimateChomper
{
	// Token: 0x0600111D RID: 4381 RVA: 0x000611DC File Offset: 0x0005F3DC
	[Token(Token = "0x600111D")]
	[Address(RVA = "0x48A550", Offset = "0x488B50", VA = "0x18048A550", Slot = "76")]
	public override void AnimShoot()
	{
		Transform transform = base.transform.Find("Shoot").transform;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		bullet.Damage = 300;
	}

	// Token: 0x0600111E RID: 4382 RVA: 0x0006121C File Offset: 0x0005F41C
	[Token(Token = "0x600111E")]
	[Address(RVA = "0x48A6A0", Offset = "0x488CA0", VA = "0x18048A6A0")]
	public GarlicUltimateChomper()
	{
	}
}
