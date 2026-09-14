using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000569 RID: 1385
[Token(Token = "0x2000569")]
public class SquashCorn : Cornpult
{
	// Token: 0x060019B8 RID: 6584 RVA: 0x0008AB08 File Offset: 0x00088D08
	[Token(Token = "0x60019B8")]
	[Address(RVA = "0x4E5EC0", Offset = "0x4E44C0", VA = "0x1804E5EC0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_kernal_squash;
	}

	// Token: 0x060019B9 RID: 6585 RVA: 0x0008AB1C File Offset: 0x00088D1C
	[Token(Token = "0x60019B9")]
	[Address(RVA = "0x4E5E90", Offset = "0x4E4490", VA = "0x1804E5E90", Slot = "79")]
	protected override BulletType GetBulletType2()
	{
		GameObject gameObject = this.butter;
		int num = 0;
		gameObject.SetActive(num != 0);
		return BulletType.Bullet_butter_squash;
	}

	// Token: 0x060019BA RID: 6586 RVA: 0x0008AB44 File Offset: 0x00088D44
	[Token(Token = "0x60019BA")]
	[Address(RVA = "0x4E5ED0", Offset = "0x4E44D0", VA = "0x1804E5ED0", Slot = "45")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		this.thePlantAttackCountDown = num;
		Zombie zombie = base.ThrowerSearchZombie();
		int num2 = 0;
		if (zombie != num2)
		{
			Collider2D col = zombie.col;
			int num3 = 0;
			if (col != num3)
			{
				int butterP = this.butterP;
				int num4 = global::UnityEngine.Random.Range(0, butterP);
				Animator anim = this.anim;
				if (num4 == 0)
				{
					this.butter.SetActive(true);
					return;
				}
				anim.SetTrigger("shoot");
			}
		}
	}

	// Token: 0x060019BB RID: 6587 RVA: 0x0008ABDC File Offset: 0x00088DDC
	[Token(Token = "0x60019BB")]
	[Address(RVA = "0x47E9D0", Offset = "0x47CFD0", VA = "0x18047E9D0")]
	public SquashCorn()
	{
	}

	// Token: 0x04000E48 RID: 3656
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000E48")]
	public GameObject butter;
}
