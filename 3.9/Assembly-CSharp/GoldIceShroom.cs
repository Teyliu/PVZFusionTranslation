using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003A7 RID: 935
[Token(Token = "0x20003A7")]
public class GoldIceShroom : IceShroom
{
	// Token: 0x06001125 RID: 4389 RVA: 0x000614AC File Offset: 0x0005F6AC
	[Token(Token = "0x6001125")]
	[Address(RVA = "0x48B840", Offset = "0x489E40", VA = "0x18048B840", Slot = "68")]
	protected override void Explode()
	{
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction = board.boardAction;
	}

	// Token: 0x06001126 RID: 4390 RVA: 0x000614D8 File Offset: 0x0005F6D8
	[Token(Token = "0x6001126")]
	[Address(RVA = "0x48B8B0", Offset = "0x489EB0", VA = "0x18048B8B0", Slot = "42")]
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

	// Token: 0x06001127 RID: 4391 RVA: 0x0006154C File Offset: 0x0005F74C
	[Token(Token = "0x6001127")]
	[Address(RVA = "0x48B420", Offset = "0x489A20", VA = "0x18048B420", Slot = "41")]
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

	// Token: 0x06001128 RID: 4392 RVA: 0x000615F8 File Offset: 0x0005F7F8
	[Token(Token = "0x6001128")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public GoldIceShroom()
	{
	}
}
