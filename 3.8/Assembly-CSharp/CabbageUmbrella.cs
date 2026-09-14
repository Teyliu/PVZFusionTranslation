using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000353 RID: 851
[Token(Token = "0x2000353")]
public class CabbageUmbrella : CornUmbrella
{
	// Token: 0x06000F92 RID: 3986 RVA: 0x0005A3F8 File Offset: 0x000585F8
	[Token(Token = "0x6000F92")]
	[Address(RVA = "0x41DE30", Offset = "0x41C430", VA = "0x18041DE30")]
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

	// Token: 0x06000F93 RID: 3987 RVA: 0x0005A458 File Offset: 0x00058658
	[Token(Token = "0x6000F93")]
	[Address(RVA = "0x41DD80", Offset = "0x41C380", VA = "0x18041DD80", Slot = "70")]
	protected override void BlockEffect(Zombie zombie)
	{
		Plant umbrellaPot = base.UmbrellaPot;
		int num = 0;
		if (!(umbrellaPot == num))
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000F94 RID: 3988 RVA: 0x0005A480 File Offset: 0x00058680
	[Token(Token = "0x6000F94")]
	[Address(RVA = "0x41DB20", Offset = "0x41C120", VA = "0x18041DB20")]
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

	// Token: 0x06000F95 RID: 3989 RVA: 0x0005A514 File Offset: 0x00058714
	[Token(Token = "0x6000F95")]
	[Address(RVA = "0x41DFB0", Offset = "0x41C5B0", VA = "0x18041DFB0")]
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

	// Token: 0x06000F96 RID: 3990 RVA: 0x0005A5A0 File Offset: 0x000587A0
	[Token(Token = "0x6000F96")]
	[Address(RVA = "0x41C050", Offset = "0x41A650", VA = "0x18041C050")]
	public CabbageUmbrella()
	{
	}
}
