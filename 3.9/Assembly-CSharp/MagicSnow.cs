using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200055F RID: 1375
[Token(Token = "0x200055F")]
public class MagicSnow : Shooter
{
	// Token: 0x06001995 RID: 6549 RVA: 0x0008A68C File Offset: 0x0008888C
	[Token(Token = "0x6001995")]
	[Address(RVA = "0x535E60", Offset = "0x534460", VA = "0x180535E60", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)1021));
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)1022)))
		{
			this.weakSign.SetActive(true);
			throw new NullReferenceException();
		}
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)1021)))
		{
			this.weakSign.SetActive(true);
			return;
		}
	}

	// Token: 0x06001996 RID: 6550 RVA: 0x0008A6F0 File Offset: 0x000888F0
	[Token(Token = "0x6001996")]
	[Address(RVA = "0x535BE0", Offset = "0x5341E0", VA = "0x180535BE0", Slot = "68")]
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
		bool flag2;
		if (flag2)
		{
		}
		float value = global::UnityEngine.Random.value;
		bullet.theStatus = (BulletStatus)((ulong)9L);
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		bullet.from = this;
		GameAPP.PlaySound((int)thePlantType, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x06001997 RID: 6551 RVA: 0x0008A7FC File Offset: 0x000889FC
	[Token(Token = "0x6001997")]
	[Address(RVA = "0x535BD0", Offset = "0x5341D0", VA = "0x180535BD0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_extremeSnowPea;
	}

	// Token: 0x06001998 RID: 6552 RVA: 0x0008A80C File Offset: 0x00088A0C
	[Token(Token = "0x6001998")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public MagicSnow()
	{
	}

	// Token: 0x04000EEC RID: 3820
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000EEC")]
	public GameObject weakSign;

	// Token: 0x04000EED RID: 3821
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000EED")]
	public GameObject strongSign;
}
