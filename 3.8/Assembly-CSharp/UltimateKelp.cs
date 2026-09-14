using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005B3 RID: 1459
[Token(Token = "0x20005B3")]
public class UltimateKelp : SuperKelp
{
	// Token: 0x06001B21 RID: 6945 RVA: 0x00091834 File Offset: 0x0008FA34
	[Token(Token = "0x6001B21")]
	[Address(RVA = "0x4FF940", Offset = "0x4FDF40", VA = "0x1804FF940", Slot = "74")]
	protected override void AnimShoot()
	{
		Transform transform = base.transform.Find("Shoot");
		Vector3 vector;
		float z = vector.z;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		int rowNum = this.board.rowNum;
		CreateBullet instance2 = CreateBullet.Instance;
		int num = this.thePlantRow;
		num++;
		int attackDamage2 = this.attackDamage;
		Bullet bullet2;
		bullet2.Damage = attackDamage2;
		CreateBullet instance3 = CreateBullet.Instance;
		int attackDamage3 = this.attackDamage;
		Bullet bullet3;
		bullet3.Damage = attackDamage3;
	}

	// Token: 0x06001B22 RID: 6946 RVA: 0x000918C8 File Offset: 0x0008FAC8
	[Token(Token = "0x6001B22")]
	[Address(RVA = "0x4FFC00", Offset = "0x4FE200", VA = "0x1804FFC00", Slot = "72")]
	protected override IEnumerator Moving()
	{
		UltimateKelp.<Moving>d__1 <Moving>d__;
		<Moving>d__.System.IDisposable.Dispose();
		<Moving>d__.<>1__state = (int)((ulong)0L);
		<Moving>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06001B23 RID: 6947 RVA: 0x000918EC File Offset: 0x0008FAEC
	[Token(Token = "0x6001B23")]
	[Address(RVA = "0x4FFC70", Offset = "0x4FE270", VA = "0x1804FFC70")]
	public UltimateKelp()
	{
	}
}
