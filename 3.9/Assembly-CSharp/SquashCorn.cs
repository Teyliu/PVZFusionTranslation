using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000599 RID: 1433
[Token(Token = "0x2000599")]
public class SquashCorn : Cornpult
{
	// Token: 0x06001A98 RID: 6808 RVA: 0x0008EBBC File Offset: 0x0008CDBC
	[Token(Token = "0x6001A98")]
	[Address(RVA = "0x544330", Offset = "0x542930", VA = "0x180544330", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_kernal_squash;
	}

	// Token: 0x06001A99 RID: 6809 RVA: 0x0008EBD0 File Offset: 0x0008CDD0
	[Token(Token = "0x6001A99")]
	[Address(RVA = "0x544300", Offset = "0x542900", VA = "0x180544300", Slot = "78")]
	protected override BulletType GetBulletType2()
	{
		GameObject gameObject = this.butter;
		int num = 0;
		gameObject.SetActive(num != 0);
		return BulletType.Bullet_butter_squash;
	}

	// Token: 0x06001A9A RID: 6810 RVA: 0x0008EBF8 File Offset: 0x0008CDF8
	[Token(Token = "0x6001A9A")]
	[Address(RVA = "0x544340", Offset = "0x542940", VA = "0x180544340", Slot = "44")]
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

	// Token: 0x06001A9B RID: 6811 RVA: 0x0008EC90 File Offset: 0x0008CE90
	[Token(Token = "0x6001A9B")]
	[Address(RVA = "0x4D6B50", Offset = "0x4D5150", VA = "0x1804D6B50")]
	public SquashCorn()
	{
	}

	// Token: 0x04000F06 RID: 3846
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000F06")]
	public GameObject butter;
}
