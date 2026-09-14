using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200058A RID: 1418
[Token(Token = "0x200058A")]
public class ThornsSpruce : Plant
{
	// Token: 0x06001A31 RID: 6705 RVA: 0x0008CEC8 File Offset: 0x0008B0C8
	[Token(Token = "0x6001A31")]
	[Address(RVA = "0x4EC950", Offset = "0x4EAF50", VA = "0x1804EC950")]
	public void Shoot(Bullet bullet)
	{
		this.anim.SetTrigger("shoot");
		this.theStatus = (PlantStatus)((ulong)25L);
		PlantType fromType = bullet.fromType;
		this.getType = fromType;
	}

	// Token: 0x06001A32 RID: 6706 RVA: 0x0008CF04 File Offset: 0x0008B104
	[Token(Token = "0x6001A32")]
	[Address(RVA = "0x4EC860", Offset = "0x4EAE60", VA = "0x1804EC860")]
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

	// Token: 0x06001A33 RID: 6707 RVA: 0x0008CF74 File Offset: 0x0008B174
	[Token(Token = "0x6001A33")]
	[Address(RVA = "0x4EC9D0", Offset = "0x4EAFD0", VA = "0x1804EC9D0")]
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

	// Token: 0x06001A34 RID: 6708 RVA: 0x0008CFFC File Offset: 0x0008B1FC
	[Token(Token = "0x6001A34")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public ThornsSpruce()
	{
	}

	// Token: 0x04000E5C RID: 3676
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000E5C")]
	private PlantType getType;
}
