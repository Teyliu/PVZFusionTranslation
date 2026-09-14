using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200050A RID: 1290
[Token(Token = "0x200050A")]
public class DoomGatling : Shooter
{
	// Token: 0x0600183F RID: 6207 RVA: 0x00083D00 File Offset: 0x00081F00
	[Token(Token = "0x600183F")]
	[Address(RVA = "0x521570", Offset = "0x51FB70", VA = "0x180521570", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform transform = base.transform.Find("GatlingPea_head");
		int num = 0;
		Transform child = transform.GetChild(num);
		int num2 = this.doomTimes;
		num2++;
		this.doomTimes = num2;
		CreateBullet instance = CreateBullet.Instance;
		uint num3;
		if (num2 < (int)num3)
		{
			int attackDamage = this.attackDamage;
			Bullet bullet;
			bullet.Damage = attackDamage;
		}
		int num4 = 0;
		num3 += num3;
		Bullet bullet2;
		bullet2.Damage = (int)num3;
		bullet2.theStatus = (BulletStatus)((ulong)6L);
		this.doomTimes = num4;
		bool flag;
		if (!flag)
		{
			float num5 = this.thePlantAttackInterval * 3f;
			this.thePlantAttackCountDown = num5;
		}
		PlantType thePlantType = this.thePlantType;
		bullet2.fromType = thePlantType;
		GameAPP.PlaySound((int)thePlantType, 0.5f, 1f);
		return bullet2;
	}

	// Token: 0x06001840 RID: 6208 RVA: 0x00083DCC File Offset: 0x00081FCC
	[Token(Token = "0x6001840")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public DoomGatling()
	{
	}

	// Token: 0x04000E66 RID: 3686
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E66")]
	private int doomTimes;
}
