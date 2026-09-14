using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004FD RID: 1277
[Token(Token = "0x20004FD")]
public class GatlingDoomScaredy : ScaredyDoom
{
	// Token: 0x060017D8 RID: 6104 RVA: 0x00081D28 File Offset: 0x0007FF28
	[Token(Token = "0x60017D8")]
	[Address(RVA = "0x4C9150", Offset = "0x4C7750", VA = "0x1804C9150", Slot = "69")]
	protected override Bullet Shoot1()
	{
		float thePlantAttackInterval = this.thePlantAttackInterval;
		if (thePlantAttackInterval <= 0.2f)
		{
			this.thePlantAttackInterval = 0.2f;
		}
		this.thePlantAttackInterval = thePlantAttackInterval;
		this.anim.SetFloat("ShootSpeed", 1f);
		Transform transform = base.transform.Find("Shoot");
		int num = 0;
		Transform child = transform.GetChild(num);
		int num2 = this.doomTimes;
		num2++;
		this.doomTimes = num2;
		CreateBullet instance = CreateBullet.Instance;
		uint num3;
		int num4;
		if (num2 < (int)num3)
		{
			num4 = this.attackDamage;
			Bullet bullet;
			bullet.Damage = num4;
		}
		int num5 = 0;
		num4 += num4;
		Bullet bullet2;
		bullet2.Damage = num4;
		bullet2.theStatus = (BulletStatus)((ulong)6L);
		this.doomTimes = num5;
		bool flag;
		if (!flag)
		{
			float num6 = this.thePlantAttackInterval * 3f;
			this.thePlantAttackCountDown = num6;
		}
		PlantType thePlantType = this.thePlantType;
		bullet2.fromType = thePlantType;
		GameAPP.PlaySound((int)thePlantType, 0.5f, 1f);
		return bullet2;
	}

	// Token: 0x060017D9 RID: 6105 RVA: 0x00081E2C File Offset: 0x0008002C
	[Token(Token = "0x60017D9")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public GatlingDoomScaredy()
	{
	}

	// Token: 0x04000DCC RID: 3532
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000DCC")]
	protected int doomTimes;

	// Token: 0x04000DCD RID: 3533
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000DCD")]
	protected float timer;
}
