using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004E2 RID: 1250
[Token(Token = "0x20004E2")]
public class DoomGatling : Shooter
{
	// Token: 0x06001788 RID: 6024 RVA: 0x00080AAC File Offset: 0x0007ECAC
	[Token(Token = "0x6001788")]
	[Address(RVA = "0x4A1A40", Offset = "0x4A0040", VA = "0x1804A1A40", Slot = "69")]
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

	// Token: 0x06001789 RID: 6025 RVA: 0x00080B78 File Offset: 0x0007ED78
	[Token(Token = "0x6001789")]
	[Address(RVA = "0x499DE0", Offset = "0x4983E0", VA = "0x180499DE0")]
	public DoomGatling()
	{
		this.dreamTime = 0.1f;
		base..ctor();
	}

	// Token: 0x04000DBF RID: 3519
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000DBF")]
	private int doomTimes;
}
