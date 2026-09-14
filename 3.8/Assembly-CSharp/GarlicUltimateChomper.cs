using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000391 RID: 913
[Token(Token = "0x2000391")]
public class GarlicUltimateChomper : UltimateChomper
{
	// Token: 0x060010C3 RID: 4291 RVA: 0x0005FC90 File Offset: 0x0005DE90
	[Token(Token = "0x60010C3")]
	[Address(RVA = "0x436C70", Offset = "0x435270", VA = "0x180436C70", Slot = "76")]
	public override void AnimShoot()
	{
		Transform transform = base.transform.Find("Shoot").transform;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		bullet.Damage = 300;
	}

	// Token: 0x060010C4 RID: 4292 RVA: 0x0005FCD0 File Offset: 0x0005DED0
	[Token(Token = "0x60010C4")]
	[Address(RVA = "0x436DC0", Offset = "0x4353C0", VA = "0x180436DC0")]
	public GarlicUltimateChomper()
	{
	}
}
