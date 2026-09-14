using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000528 RID: 1320
[Token(Token = "0x2000528")]
public class GatlingDoomScaredy : ScaredyDoom
{
	// Token: 0x060018A1 RID: 6305 RVA: 0x00085568 File Offset: 0x00083768
	[Token(Token = "0x60018A1")]
	[Address(RVA = "0x525470", Offset = "0x523A70", VA = "0x180525470", Slot = "68")]
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

	// Token: 0x060018A2 RID: 6306 RVA: 0x0008566C File Offset: 0x0008386C
	[Token(Token = "0x60018A2")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public GatlingDoomScaredy()
	{
	}

	// Token: 0x04000E7B RID: 3707
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E7B")]
	protected int doomTimes;

	// Token: 0x04000E7C RID: 3708
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000E7C")]
	protected float timer;
}
