using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200057B RID: 1403
[Token(Token = "0x200057B")]
public class SuperGatlingPeaMine : SuperSnowGatling
{
	// Token: 0x060019EA RID: 6634 RVA: 0x0008B834 File Offset: 0x00089A34
	[Token(Token = "0x60019EA")]
	[Address(RVA = "0x4E8F30", Offset = "0x4E7530", VA = "0x1804E8F30", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		bool flag = Lawnf.TravelUltimate((UltiBuff)((uint)50));
		return BulletType.Bullet_potato_explode;
	}

	// Token: 0x060019EB RID: 6635 RVA: 0x0008B850 File Offset: 0x00089A50
	[Token(Token = "0x60019EB")]
	[Address(RVA = "0x4E8950", Offset = "0x4E6F50", VA = "0x1804E8950", Slot = "40")]
	protected override void AttributeEvent()
	{
		float timer = this.timer;
		int num = this.attackDamage;
		float num2 = timer * 45f;
		bool flag;
		if (flag)
		{
			num += num;
		}
		int bulletType = (int)this.GetBulletType();
		CreateBullet instance = CreateBullet.Instance;
		Transform shoot = this.shoot;
		Transform shoot2 = this.shoot;
		Bullet bullet;
		bullet.Damage = num;
		Transform shoot3 = this.shoot;
		CreateBullet instance2 = CreateBullet.Instance;
		Transform shoot4 = this.shoot;
		Bullet bullet2;
		bullet2.Damage = num;
		Transform transform = bullet2.transform;
		float num3 = num2 * 0.017453292f;
		Transform shoot5 = this.shoot;
		CreateBullet instance3 = CreateBullet.Instance;
		Transform shoot6 = this.shoot;
		Bullet bullet3;
		bullet3.Damage = num;
		Transform transform2 = bullet3.transform;
		float num4 = num2 * 0.017453292f;
		Quaternion quaternion;
		GameAPP.PlaySound((int)quaternion.x, 0.5f, 1f);
		int num5 = 0;
		base.AttributeCountdown = (float)num5;
		Animator anim = this.anim;
		int num6 = 0;
		anim.SetBool("shooting", num6 != 0);
	}

	// Token: 0x060019EC RID: 6636 RVA: 0x0008B954 File Offset: 0x00089B54
	[Token(Token = "0x60019EC")]
	[Address(RVA = "0x4E8F60", Offset = "0x4E7560", VA = "0x1804E8F60", Slot = "69")]
	protected override Bullet Shoot1()
	{
		float timer = this.timer;
		int num = 0;
		if (timer <= (float)num)
		{
			return base.Shoot1();
		}
		return null;
	}

	// Token: 0x060019ED RID: 6637 RVA: 0x0008B978 File Offset: 0x00089B78
	[Token(Token = "0x60019ED")]
	[Address(RVA = "0x4E8F80", Offset = "0x4E7580", VA = "0x1804E8F80", Slot = "73")]
	protected override void SuperShoot(float timer = 5f)
	{
		int num4;
		do
		{
			int num = 0;
			this.timer = timer;
			this.flashCountDown = timer;
			this.AttributeEvent();
			this.anim.SetBool("shooting", true);
			int num2 = 0;
			ulong num3;
			base.Recover(timer, (DamageType)num2, true, num3 != 0UL);
			num4 = 0;
			this.attributeCount = num4;
			int num5 = 0;
			Board board = this.board;
			List<Plant> plants = Lawnf.GetPlants(this.thePlantType, board, num5 != 0);
			bool flag;
			if (flag)
			{
				while (num == 0)
				{
				}
				while (num == 0)
				{
				}
				while (num != 0)
				{
				}
				if (!(num != this))
				{
					continue;
				}
			}
		}
		while (num4 != 0);
	}

	// Token: 0x060019EE RID: 6638 RVA: 0x0008BA04 File Offset: 0x00089C04
	[Token(Token = "0x60019EE")]
	[Address(RVA = "0x4E8DA0", Offset = "0x4E73A0", VA = "0x1804E8DA0", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		PlantType thePlantType = this.thePlantType;
		Transform axis2 = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		int num = 0;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)8), num, 11, num3 != 0UL, (float)num2);
		GameAPP.PlaySound(47, 0.5f, 1f);
		ScreenShake.TriggerShake(0.15f);
	}

	// Token: 0x060019EF RID: 6639 RVA: 0x0008BA74 File Offset: 0x00089C74
	[Token(Token = "0x60019EF")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public SuperGatlingPeaMine()
	{
	}
}
