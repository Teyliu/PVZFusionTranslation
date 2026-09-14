using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000394 RID: 916
[Token(Token = "0x2000394")]
public class GoldIceShroom : IceShroom
{
	// Token: 0x060010CB RID: 4299 RVA: 0x0005FF8C File Offset: 0x0005E18C
	[Token(Token = "0x60010CB")]
	[Address(RVA = "0x437F40", Offset = "0x436540", VA = "0x180437F40", Slot = "69")]
	protected override void Explode()
	{
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction = board.boardAction;
	}

	// Token: 0x060010CC RID: 4300 RVA: 0x0005FFB8 File Offset: 0x0005E1B8
	[Token(Token = "0x60010CC")]
	[Address(RVA = "0x437FA0", Offset = "0x4365A0", VA = "0x180437FA0", Slot = "43")]
	public override bool SuperSkill()
	{
		float flashCountDown = this.flashCountDown;
		int num = 0;
		if (flashCountDown <= (float)num)
		{
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			int num2 = 0;
			ulong num3;
			base.Recover(z, (DamageType)num2, true, num3 != 0UL);
			GameAPP.PlaySound(66, 0.5f, 1f);
			this.anim.SetTrigger("super");
			this.flashCountDown = 2f;
			return true;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060010CD RID: 4301 RVA: 0x0006002C File Offset: 0x0005E22C
	[Token(Token = "0x60010CD")]
	[Address(RVA = "0x437B20", Offset = "0x436120", VA = "0x180437B20", Slot = "42")]
	protected override void AnimSuperShoot()
	{
		Transform axis = this.axis;
		int num = 0;
		Vector3 vector;
		float z = vector.z;
		ParticleManager instance = ParticleManager.Instance;
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
		Transform axis2 = this.axis;
		int num3 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag && Lawnf.InLandStatus((ZombieStatus)num))
			{
				PlantType thePlantType = this.thePlantType;
				CreateBullet instance2 = CreateBullet.Instance;
				uint num4;
				num4 += num4;
				Bullet bullet;
				bullet.Damage = (int)num4;
				PlantType thePlantType2 = this.thePlantType;
				bullet.fromType = thePlantType2;
				bullet.targetZombie = num;
			}
			num++;
		}
	}

	// Token: 0x060010CE RID: 4302 RVA: 0x000600D8 File Offset: 0x0005E2D8
	[Token(Token = "0x60010CE")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public GoldIceShroom()
	{
	}
}
