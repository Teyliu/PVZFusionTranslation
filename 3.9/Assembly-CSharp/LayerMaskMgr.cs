using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020009E9 RID: 2537
[Token(Token = "0x20009E9")]
public class LayerMaskMgr
{
	// Token: 0x060033FF RID: 13311 RVA: 0x00112A94 File Offset: 0x00110C94
	[Token(Token = "0x60033FF")]
	[Address(RVA = "0x7683E0", Offset = "0x7669E0", VA = "0x1807683E0")]
	public static void InitLayer()
	{
		LayerMaskMgr.plantBulletExclude = LayerMask.GetMask(new string[] { "Bullet", "Plant", "ZombieBullet" });
		LayerMaskMgr.dreamBulletExclude = LayerMask.GetMask(new string[] { "Bullet", "ZombieBullet" });
		LayerMaskMgr.zombieBulletExclude = LayerMask.GetMask(new string[] { "Bullet", "Zombie", "ZombieBullet" });
		LayerMaskMgr.plantExclude = LayerMask.GetMask(new string[] { "Bullet", "Plant", "TorchWood" });
		LayerMaskMgr.zombieExclude = LayerMask.GetMask(new string[] { "Zombie", "ZombieBullet" });
		LayerMaskMgr.hypnoZombieExclude = LayerMask.GetMask(new string[] { "Bullet", "Plant", "TorchWood" });
		LayerMaskMgr.BulletLayer = LayerMask.NameToLayer("Bullet");
		LayerMaskMgr.ZombieBulletLayer = LayerMask.NameToLayer("ZombieBullet");
	}

	// Token: 0x06003400 RID: 13312 RVA: 0x00112C14 File Offset: 0x00110E14
	[Token(Token = "0x6003400")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public LayerMaskMgr()
	{
	}

	// Token: 0x04002588 RID: 9608
	[Token(Token = "0x4002588")]
	public static LayerMask plantBulletExclude;

	// Token: 0x04002589 RID: 9609
	[Token(Token = "0x4002589")]
	public static LayerMask zombieBulletExclude;

	// Token: 0x0400258A RID: 9610
	[Token(Token = "0x400258A")]
	public static LayerMask dreamBulletExclude;

	// Token: 0x0400258B RID: 9611
	[Token(Token = "0x400258B")]
	public static LayerMask plantExclude;

	// Token: 0x0400258C RID: 9612
	[Token(Token = "0x400258C")]
	public static LayerMask zombieExclude;

	// Token: 0x0400258D RID: 9613
	[Token(Token = "0x400258D")]
	public static LayerMask hypnoZombieExclude;

	// Token: 0x0400258E RID: 9614
	[Token(Token = "0x400258E")]
	public static LayerMask BulletLayer;

	// Token: 0x0400258F RID: 9615
	[Token(Token = "0x400258F")]
	public static LayerMask ZombieBulletLayer;

	// Token: 0x04002590 RID: 9616
	[Token(Token = "0x4002590")]
	public static LayerMask DreamInclude;
}
