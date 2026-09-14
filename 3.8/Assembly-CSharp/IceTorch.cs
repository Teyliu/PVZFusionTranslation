using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003BB RID: 955
[Token(Token = "0x20003BB")]
public class IceTorch : TorchWood
{
	// Token: 0x0600117C RID: 4476 RVA: 0x00063248 File Offset: 0x00061448
	[Token(Token = "0x600117C")]
	[Address(RVA = "0x444690", Offset = "0x442C90", VA = "0x180444690", Slot = "69")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
		int num = 0;
		if (base.PumpkinType != PlantType.TorchPumpkin && collision.TryGetComponent<Bullet>(num))
		{
			bool flag = base.CheckFire(num);
			if (flag)
			{
				if (this > (ulong)15L)
				{
					if (flag <= true)
					{
						CreateBullet instance = CreateBullet.Instance;
						Bullet bullet;
						bullet._damage = (int)((ulong)20L);
					}
					if (this == (ulong)134L)
					{
						CreateBullet instance2 = CreateBullet.Instance;
					}
					if (this != (ulong)136L)
					{
						return;
					}
					CreateBullet instance3 = CreateBullet.Instance;
				}
				if (this != 0)
				{
					while (this != (ulong)15L)
					{
					}
					BoardAction boardAction = this.board.boardAction;
					throw new NullReferenceException();
				}
				CreateBullet instance4 = CreateBullet.Instance;
				Bullet bullet2;
				bullet2.theExistTime = instance4;
				bullet2.torchWood = this;
				bullet2.shootByZombie = bullet2 != null;
				if (bullet2 == 0)
				{
					bullet2.normalSpeed = 6f;
				}
			}
		}
	}

	// Token: 0x0600117D RID: 4477 RVA: 0x00063314 File Offset: 0x00061514
	[Token(Token = "0x600117D")]
	[Address(RVA = "0x444B60", Offset = "0x443160", VA = "0x180444B60")]
	private void TurnAtoB(Bullet bullet, BulletType newBulletType, int damage)
	{
		CreateBullet instance = CreateBullet.Instance;
		Transform transform = bullet.transform;
		Transform transform2 = bullet.transform;
		BulletMoveWay moveWay = bullet._moveWay;
		float theExistTime = bullet.theExistTime;
		float normalSpeed = bullet.normalSpeed;
		BulletStatus theStatus = bullet.theStatus;
		bool shootByZombie = bullet.shootByZombie;
		bullet.Die();
	}

	// Token: 0x0600117E RID: 4478 RVA: 0x00063370 File Offset: 0x00061570
	[Token(Token = "0x600117E")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public IceTorch()
	{
	}
}
