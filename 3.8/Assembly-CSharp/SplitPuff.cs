using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000562 RID: 1378
[Token(Token = "0x2000562")]
public class SplitPuff : SplitPea
{
	// Token: 0x060019A7 RID: 6567 RVA: 0x0008A6BC File Offset: 0x000888BC
	[Token(Token = "0x60019A7")]
	[Address(RVA = "0x4E4990", Offset = "0x4E2F90", VA = "0x1804E4990", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform child = base.transform.GetChild(1);
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		return bullet;
	}

	// Token: 0x060019A8 RID: 6568 RVA: 0x0008A6F8 File Offset: 0x000888F8
	[Token(Token = "0x60019A8")]
	[Address(RVA = "0x4E4AD0", Offset = "0x4E30D0", VA = "0x1804E4AD0", Slot = "70")]
	protected override Bullet Shoot2()
	{
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		return bullet;
	}

	// Token: 0x060019A9 RID: 6569 RVA: 0x0008A73C File Offset: 0x0008893C
	[Token(Token = "0x60019A9")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public SplitPuff()
	{
	}
}
