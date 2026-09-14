using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200038E RID: 910
[Token(Token = "0x200038E")]
public class DoomSeaShroom : Plant
{
	// Token: 0x060010B4 RID: 4276 RVA: 0x0005F1F4 File Offset: 0x0005D3F4
	[Token(Token = "0x60010B4")]
	[Address(RVA = "0x482360", Offset = "0x480960", VA = "0x180482360")]
	public void Eat()
	{
		this.anim.SetTrigger("eat");
	}

	// Token: 0x060010B5 RID: 4277 RVA: 0x0005F218 File Offset: 0x0005D418
	[Token(Token = "0x60010B5")]
	[Address(RVA = "0x481F10", Offset = "0x480510", VA = "0x180481F10")]
	public void AnimShoot()
	{
		Transform shoot = this.shoot;
		Transform axis = this.axis;
		Board instance = Board.Instance;
		Vector3 vector;
		float z = vector.z;
		Func<Zombie, bool> func = new Func(this.CheckZombie);
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
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		GameAPP.PlaySound((int)colliderPosition.x, 0.5f, 1f);
	}

	// Token: 0x060010B6 RID: 4278 RVA: 0x0005F2B8 File Offset: 0x0005D4B8
	[Token(Token = "0x60010B6")]
	[Address(RVA = "0x4822C0", Offset = "0x4808C0", VA = "0x1804822C0")]
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

	// Token: 0x060010B7 RID: 4279 RVA: 0x0005F304 File Offset: 0x0005D504
	[Token(Token = "0x60010B7")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public DoomSeaShroom()
	{
	}
}
