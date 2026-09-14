using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000592 RID: 1426
[Token(Token = "0x2000592")]
public class SplitPuff : SplitPea
{
	// Token: 0x06001A87 RID: 6791 RVA: 0x0008E770 File Offset: 0x0008C970
	[Token(Token = "0x6001A87")]
	[Address(RVA = "0x542E00", Offset = "0x541400", VA = "0x180542E00", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform child = base.transform.GetChild(1);
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		return bullet;
	}

	// Token: 0x06001A88 RID: 6792 RVA: 0x0008E7AC File Offset: 0x0008C9AC
	[Token(Token = "0x6001A88")]
	[Address(RVA = "0x542F40", Offset = "0x541540", VA = "0x180542F40", Slot = "69")]
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

	// Token: 0x06001A89 RID: 6793 RVA: 0x0008E7F0 File Offset: 0x0008C9F0
	[Token(Token = "0x6001A89")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public SplitPuff()
	{
	}
}
