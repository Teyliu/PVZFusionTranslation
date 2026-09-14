using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005A4 RID: 1444
[Token(Token = "0x20005A4")]
public class UltimateDoomGatling : Shooter
{
	// Token: 0x06001AD4 RID: 6868 RVA: 0x0008FEE8 File Offset: 0x0008E0E8
	[Token(Token = "0x6001AD4")]
	[Address(RVA = "0x4FBC50", Offset = "0x4FA250", VA = "0x1804FBC50", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		int num = this.attributeCount;
		num++;
		this.attributeCount = num;
		CreateBullet instance = CreateBullet.Instance;
		uint num2;
		if (num < (int)num2)
		{
			int attackDamage = this.attackDamage;
			Bullet bullet;
			bullet.Damage = attackDamage;
		}
		int num3 = 0;
		num2 += num2;
		Bullet bullet2;
		bullet2.Damage = (int)num2;
		bullet2.theStatus = (BulletStatus)((ulong)6L);
		this.attributeCount = num3;
		bool flag;
		if (!flag)
		{
			float num4 = this.thePlantAttackInterval * 3f;
			this.thePlantAttackCountDown = num4;
		}
		PlantType thePlantType = this.thePlantType;
		bullet2.fromType = thePlantType;
		GameAPP.PlaySound((int)thePlantType, 0.5f, 1f);
		return bullet2;
	}

	// Token: 0x06001AD5 RID: 6869 RVA: 0x0008FFA0 File Offset: 0x0008E1A0
	[Token(Token = "0x6001AD5")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public UltimateDoomGatling()
	{
	}
}
