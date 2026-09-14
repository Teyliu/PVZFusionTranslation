using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200037E RID: 894
[Token(Token = "0x200037E")]
public class DoomSeaShroom : Plant
{
	// Token: 0x06001068 RID: 4200 RVA: 0x0005E1AC File Offset: 0x0005C3AC
	[Token(Token = "0x6001068")]
	[Address(RVA = "0x431AD0", Offset = "0x4300D0", VA = "0x180431AD0")]
	public void Eat()
	{
		this.anim.SetTrigger("eat");
	}

	// Token: 0x06001069 RID: 4201 RVA: 0x0005E1D0 File Offset: 0x0005C3D0
	[Token(Token = "0x6001069")]
	[Address(RVA = "0x4315F0", Offset = "0x42FBF0", VA = "0x1804315F0")]
	public void AnimShoot()
	{
		Transform shoot = this.shoot;
		Transform axis = this.axis;
		Board instance = Board.Instance;
		Vector3 vector;
		float z = vector.z;
		int num = 0;
		Zombie zombie;
		if (!(zombie != num))
		{
			CreateBullet instance2 = CreateBullet.Instance;
			Transform axis2 = this.axis;
		}
		CreateBullet instance3 = CreateBullet.Instance;
		Vector2 velocity = zombie.Velocity;
		Vector2 colliderPosition = zombie.ColliderPosition;
		float[] array;
		float num2 = array[0];
		Bullet bullet;
		bullet.Vx = num2;
		float num3 = array[1];
		bullet.Vy = num3;
		float num4 = array[1];
		bullet.detaVy = num4;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		GameAPP.PlaySound((int)num3, 0.5f, 1f);
	}

	// Token: 0x0600106A RID: 4202 RVA: 0x0005E294 File Offset: 0x0005C494
	[Token(Token = "0x600106A")]
	[Address(RVA = "0x431A30", Offset = "0x430030", VA = "0x180431A30")]
	private bool CheckZombie(Zombie zombie)
	{
		if (!zombie.isMindControlled)
		{
			int thePlantRow = this.thePlantRow;
			if (zombie.theZombieRow == thePlantRow && Lawnf.InLandStatus(zombie.theStatus))
			{
				Transform axis = zombie.axis;
				Transform axis2 = this.axis;
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600106B RID: 4203 RVA: 0x0005E2E0 File Offset: 0x0005C4E0
	[Token(Token = "0x600106B")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public DoomSeaShroom()
	{
	}
}
