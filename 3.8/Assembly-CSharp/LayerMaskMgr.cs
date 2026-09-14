using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020009AD RID: 2477
[Token(Token = "0x20009AD")]
public class LayerMaskMgr
{
	// Token: 0x060032CB RID: 13003 RVA: 0x0010DA7C File Offset: 0x0010BC7C
	[Token(Token = "0x60032CB")]
	[Address(RVA = "0x702ED0", Offset = "0x7014D0", VA = "0x180702ED0")]
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

	// Token: 0x060032CC RID: 13004 RVA: 0x0010DBFC File Offset: 0x0010BDFC
	[Token(Token = "0x60032CC")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public LayerMaskMgr()
	{
	}

	// Token: 0x04002476 RID: 9334
	[Token(Token = "0x4002476")]
	public static LayerMask plantBulletExclude;

	// Token: 0x04002477 RID: 9335
	[Token(Token = "0x4002477")]
	public static LayerMask zombieBulletExclude;

	// Token: 0x04002478 RID: 9336
	[Token(Token = "0x4002478")]
	public static LayerMask dreamBulletExclude;

	// Token: 0x04002479 RID: 9337
	[Token(Token = "0x4002479")]
	public static LayerMask plantExclude;

	// Token: 0x0400247A RID: 9338
	[Token(Token = "0x400247A")]
	public static LayerMask zombieExclude;

	// Token: 0x0400247B RID: 9339
	[Token(Token = "0x400247B")]
	public static LayerMask hypnoZombieExclude;

	// Token: 0x0400247C RID: 9340
	[Token(Token = "0x400247C")]
	public static LayerMask BulletLayer;

	// Token: 0x0400247D RID: 9341
	[Token(Token = "0x400247D")]
	public static LayerMask ZombieBulletLayer;

	// Token: 0x0400247E RID: 9342
	[Token(Token = "0x400247E")]
	public static LayerMask DreamInclude;
}
