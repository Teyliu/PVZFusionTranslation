using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005D5 RID: 1493
[Token(Token = "0x20005D5")]
public class UltimateDoomGatling : Shooter
{
	// Token: 0x06001BBA RID: 7098 RVA: 0x000942A0 File Offset: 0x000924A0
	[Token(Token = "0x6001BBA")]
	[Address(RVA = "0x5591E0", Offset = "0x5577E0", VA = "0x1805591E0", Slot = "68")]
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

	// Token: 0x06001BBB RID: 7099 RVA: 0x00094358 File Offset: 0x00092558
	[Token(Token = "0x6001BBB")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public UltimateDoomGatling()
	{
	}
}
