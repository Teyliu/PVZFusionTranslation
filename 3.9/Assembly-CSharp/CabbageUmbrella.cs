using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000363 RID: 867
[Token(Token = "0x2000363")]
public class CabbageUmbrella : CornUmbrella
{
	// Token: 0x06000FDE RID: 4062 RVA: 0x0005B378 File Offset: 0x00059578
	[Token(Token = "0x6000FDE")]
	[Address(RVA = "0x474CF0", Offset = "0x4732F0", VA = "0x180474CF0")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		if (flag && collision == this)
		{
			int thePlantRow = this.thePlantRow;
			Team <Team>k__BackingField = this.<Team>k__BackingField;
			this.anim.SetTrigger("block2");
			this.blocking = true;
			GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		}
	}

	// Token: 0x06000FDF RID: 4063 RVA: 0x0005B3D8 File Offset: 0x000595D8
	[Token(Token = "0x6000FDF")]
	[Address(RVA = "0x474C40", Offset = "0x473240", VA = "0x180474C40", Slot = "70")]
	protected override void BlockEffect(Zombie zombie)
	{
		Plant umbrellaPot = base.UmbrellaPot;
		int num = 0;
		if (!(umbrellaPot == num))
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000FE0 RID: 4064 RVA: 0x0005B400 File Offset: 0x00059600
	[Token(Token = "0x6000FE0")]
	[Address(RVA = "0x4749E0", Offset = "0x472FE0", VA = "0x1804749E0")]
	private void AdjustBulletSpeed(Bullet bullet)
	{
		int num = 0;
		Zombie zombie = this.UmbrellaSearchZombie();
		int num2 = 0;
		if (zombie != num2)
		{
			Collider2D col = zombie.col;
			int num3 = 0;
			if (col != num3)
			{
				int num4 = 0;
				bullet.ThrowTo(zombie, num4, num);
				bullet.umbrellaed = true;
				int theZombieRow = zombie.theZombieRow;
				bullet.theBulletRow = theZombieRow;
				if (bullet.theBulletType == BulletType.Bullet_sunCabbage)
				{
					CreateItem instance = CreateItem.Instance;
					Transform transform = bullet.transform;
					Vector3 vector;
					float z = vector.z;
				}
				return;
			}
		}
		int num5 = 0;
		bullet.ThrowToNull(num5, num);
	}

	// Token: 0x06000FE1 RID: 4065 RVA: 0x0005B494 File Offset: 0x00059694
	[Token(Token = "0x6000FE1")]
	[Address(RVA = "0x474E70", Offset = "0x473470", VA = "0x180474E70")]
	protected Zombie UmbrellaSearchZombie()
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			Plant umbrellaPot = base.UmbrellaPot;
			int num3 = 0;
			bool flag = umbrellaPot == num3;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag2;
			if (flag2)
			{
				int num4 = 0;
				if (!(num != num4))
				{
					continue;
				}
				float vision = this.vision;
				if (!Thrower.ThrowSearchZombie(num))
				{
					continue;
				}
				Transform axis = this.axis;
			}
		}
		while (num2 != 0);
		throw new NullReferenceException();
	}

	// Token: 0x06000FE2 RID: 4066 RVA: 0x0005B520 File Offset: 0x00059720
	[Token(Token = "0x6000FE2")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public CabbageUmbrella()
	{
	}
}
