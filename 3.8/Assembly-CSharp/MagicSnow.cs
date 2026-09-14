using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000532 RID: 1330
[Token(Token = "0x2000532")]
public class MagicSnow : Shooter
{
	// Token: 0x060018C5 RID: 6341 RVA: 0x000869C8 File Offset: 0x00084BC8
	[Token(Token = "0x60018C5")]
	[Address(RVA = "0x4D5550", Offset = "0x4D3B50", VA = "0x1804D5550", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)1022));
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)1023)))
		{
			this.weakSign.SetActive(true);
			throw new NullReferenceException();
		}
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)1022)))
		{
			this.weakSign.SetActive(true);
			return;
		}
	}

	// Token: 0x060018C6 RID: 6342 RVA: 0x00086A2C File Offset: 0x00084C2C
	[Token(Token = "0x60018C6")]
	[Address(RVA = "0x4D5300", Offset = "0x4D3900", VA = "0x1804D5300", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		GameObject gameObject = this.strongSign;
		int num = 0;
		Bullet bullet;
		if (!gameObject.activeSelf)
		{
			GameObject gameObject2 = this.weakSign;
			int num2 = 0;
			if (!gameObject2.activeSelf)
			{
				int attackDamage = this.attackDamage;
				bullet.Damage = attackDamage;
				bullet.attributeCount = (int)((ulong)4L);
			}
			num2 += num2;
			bullet.Damage = num2;
			bullet.attributeCount = (int)((ulong)6L);
		}
		num += num;
		bullet.Damage = num;
		bullet.attributeCount = (int)((ulong)8L);
		bool flag;
		if (flag)
		{
			GameObject gameObject3 = this.strongSign;
			if (gameObject3.activeSelf)
			{
				bullet.attributeCount = gameObject3;
			}
		}
		float value = global::UnityEngine.Random.value;
		float num3;
		if (num3 > value)
		{
			bullet.theStatus = (BulletStatus)((ulong)9L);
		}
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		bullet.from = this;
		GameAPP.PlaySound((int)thePlantType, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x060018C7 RID: 6343 RVA: 0x00086B38 File Offset: 0x00084D38
	[Token(Token = "0x60018C7")]
	[Address(RVA = "0x4D52F0", Offset = "0x4D38F0", VA = "0x1804D52F0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_extremeSnowPea;
	}

	// Token: 0x060018C8 RID: 6344 RVA: 0x00086B48 File Offset: 0x00084D48
	[Token(Token = "0x60018C8")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public MagicSnow()
	{
	}

	// Token: 0x04000E31 RID: 3633
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E31")]
	public GameObject weakSign;

	// Token: 0x04000E32 RID: 3634
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000E32")]
	public GameObject strongSign;
}
