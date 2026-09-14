using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007A8 RID: 1960
[Token(Token = "0x20007A8")]
public class Weapon_torch : PlayerWeapon
{
	// Token: 0x060027CA RID: 10186 RVA: 0x000D804C File Offset: 0x000D624C
	[Token(Token = "0x60027CA")]
	[Address(RVA = "0x619640", Offset = "0x617C40", VA = "0x180619640", Slot = "10")]
	protected override void Shoot()
	{
		uint num;
		uint num2;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num, (int)num2), 0.5f, 1f);
		Transform transform = base.transform;
		int num3 = 0;
		Vector3 vector;
		float z = vector.z;
		int num4 = this.shootCount;
		num4++;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int num5 = 0;
		int attackDamage = base.AttackDamage;
		Player player = this.player;
		Bullet bullet;
		bullet.Damage = num5;
		bullet.fromType = (PlantType)((ulong)18L);
		Transform transform2 = bullet.transform;
		num3++;
	}

	// Token: 0x060027CB RID: 10187 RVA: 0x000D80DC File Offset: 0x000D62DC
	[Token(Token = "0x60027CB")]
	[Address(RVA = "0x619620", Offset = "0x617C20", VA = "0x180619620", Slot = "11")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_firePea_yellow;
	}

	// Token: 0x060027CC RID: 10188 RVA: 0x000D80EC File Offset: 0x000D62EC
	[Token(Token = "0x60027CC")]
	[Address(RVA = "0x614310", Offset = "0x612910", VA = "0x180614310")]
	public Weapon_torch()
	{
	}
}
