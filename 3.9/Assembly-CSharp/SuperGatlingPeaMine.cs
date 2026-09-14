using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005AC RID: 1452
[Token(Token = "0x20005AC")]
public class SuperGatlingPeaMine : SuperSnowGatling
{
	// Token: 0x06001AD0 RID: 6864 RVA: 0x0008FBCC File Offset: 0x0008DDCC
	[Token(Token = "0x6001AD0")]
	[Address(RVA = "0x548DA0", Offset = "0x5473A0", VA = "0x180548DA0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		bool flag = Lawnf.TravelUltimate((UltiBuff)((uint)50));
		return BulletType.Bullet_potato_explode;
	}

	// Token: 0x06001AD1 RID: 6865 RVA: 0x0008FBE8 File Offset: 0x0008DDE8
	[Token(Token = "0x6001AD1")]
	[Address(RVA = "0x5487C0", Offset = "0x546DC0", VA = "0x1805487C0", Slot = "39")]
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

	// Token: 0x06001AD2 RID: 6866 RVA: 0x0008FCEC File Offset: 0x0008DEEC
	[Token(Token = "0x6001AD2")]
	[Address(RVA = "0x548DD0", Offset = "0x5473D0", VA = "0x180548DD0", Slot = "68")]
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

	// Token: 0x06001AD3 RID: 6867 RVA: 0x0008FD10 File Offset: 0x0008DF10
	[Token(Token = "0x6001AD3")]
	[Address(RVA = "0x548DF0", Offset = "0x5473F0", VA = "0x180548DF0", Slot = "72")]
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

	// Token: 0x06001AD4 RID: 6868 RVA: 0x0008FD9C File Offset: 0x0008DF9C
	[Token(Token = "0x6001AD4")]
	[Address(RVA = "0x548C10", Offset = "0x547210", VA = "0x180548C10", Slot = "51")]
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

	// Token: 0x06001AD5 RID: 6869 RVA: 0x0008FE0C File Offset: 0x0008E00C
	[Token(Token = "0x6001AD5")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public SuperGatlingPeaMine()
	{
	}
}
