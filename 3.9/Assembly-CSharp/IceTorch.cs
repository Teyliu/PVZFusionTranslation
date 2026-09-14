using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003CF RID: 975
[Token(Token = "0x20003CF")]
public class IceTorch : TorchWood
{
	// Token: 0x060011D8 RID: 4568 RVA: 0x00064868 File Offset: 0x00062A68
	[Token(Token = "0x60011D8")]
	[Address(RVA = "0x4965E0", Offset = "0x494BE0", VA = "0x1804965E0", Slot = "68")]
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

	// Token: 0x060011D9 RID: 4569 RVA: 0x00064934 File Offset: 0x00062B34
	[Token(Token = "0x60011D9")]
	[Address(RVA = "0x496AB0", Offset = "0x4950B0", VA = "0x180496AB0")]
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

	// Token: 0x060011DA RID: 4570 RVA: 0x00064990 File Offset: 0x00062B90
	[Token(Token = "0x60011DA")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public IceTorch()
	{
	}
}
