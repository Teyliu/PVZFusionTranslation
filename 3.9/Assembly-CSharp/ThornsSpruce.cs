using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005BB RID: 1467
[Token(Token = "0x20005BB")]
public class ThornsSpruce : Plant
{
	// Token: 0x06001B17 RID: 6935 RVA: 0x00091250 File Offset: 0x0008F450
	[Token(Token = "0x6001B17")]
	[Address(RVA = "0x54C7C0", Offset = "0x54ADC0", VA = "0x18054C7C0")]
	public void Shoot(Bullet bullet)
	{
		this.anim.SetTrigger("shoot");
		this.theStatus = (PlantStatus)((ulong)25L);
		PlantType fromType = bullet.fromType;
		this.getType = fromType;
	}

	// Token: 0x06001B18 RID: 6936 RVA: 0x0009128C File Offset: 0x0008F48C
	[Token(Token = "0x6001B18")]
	[Address(RVA = "0x54C6D0", Offset = "0x54ACD0", VA = "0x18054C6D0")]
	private void AnimShoot()
	{
		int num = 0;
		this.Shoot(10f, num != 0);
		int num2 = 0;
		int num3 = 0;
		this.Shoot((float)num3, num2 != 0);
		int num4 = 0;
		this.Shoot(-10f, num4 != 0);
		this.Shoot(135f, true);
		this.Shoot(225f, true);
		this.Shoot(180f, true);
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
	}

	// Token: 0x06001B19 RID: 6937 RVA: 0x000912FC File Offset: 0x0008F4FC
	[Token(Token = "0x6001B19")]
	[Address(RVA = "0x54C840", Offset = "0x54AE40", VA = "0x18054C840")]
	private void Shoot(float angle, bool attackPlant)
	{
		CreateBullet instance = CreateBullet.Instance;
		Transform shoot = this.shoot;
		Transform shoot2 = this.shoot;
		Bullet bullet;
		Transform transform = bullet.transform;
		float num = angle * 0.017453292f;
		PlantType plantType = this.getType;
		bullet.fromType = plantType;
		bullet.from = this;
		if (attackPlant)
		{
			int num2 = 0;
			bullet.Damage = num2;
			return;
		}
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		float normalSpeed = bullet.normalSpeed;
		bullet.normalSpeed = normalSpeed;
		throw new NullReferenceException();
	}

	// Token: 0x06001B1A RID: 6938 RVA: 0x00091384 File Offset: 0x0008F584
	[Token(Token = "0x6001B1A")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public ThornsSpruce()
	{
	}

	// Token: 0x04000F1B RID: 3867
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000F1B")]
	private PlantType getType;
}
