using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200059F RID: 1439
[Token(Token = "0x200059F")]
public class StarfruitPickaxe : StarFruit
{
	// Token: 0x06001AA8 RID: 6824 RVA: 0x0008F034 File Offset: 0x0008D234
	[Token(Token = "0x6001AA8")]
	[Address(RVA = "0x545BA0", Offset = "0x5441A0", VA = "0x180545BA0", Slot = "72")]
	protected override void SetBullet(Transform _transform, BulletMoveWay theMovingWay)
	{
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		Transform transform = bullet.transform;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x06001AA9 RID: 6825 RVA: 0x0008F07C File Offset: 0x0008D27C
	[Token(Token = "0x6001AA9")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06001AAA RID: 6826 RVA: 0x0008F08C File Offset: 0x0008D28C
	[Token(Token = "0x6001AAA")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public StarfruitPickaxe()
	{
	}
}
