using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000477 RID: 1143
[Token(Token = "0x2000477")]
public class ThreeNut : Shooter
{
	// Token: 0x0600150D RID: 5389 RVA: 0x00074624 File Offset: 0x00072824
	[Token(Token = "0x600150D")]
	[Address(RVA = "0x4CFDD0", Offset = "0x4CE3D0", VA = "0x1804CFDD0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		CrackStatus crackStatus = this.crack;
		Bullet bullet;
		if (crackStatus != CrackStatus.Good)
		{
			if (crackStatus != CrackStatus.Good)
			{
				if (crackStatus != CrackStatus.Normal)
				{
				}
				int num = this.attackDamage;
				num += num;
				bullet.Damage = num;
				bullet.maxHitCount = (int)((ulong)7L);
			}
			bullet.maxHitCount = (int)((ulong)5L);
		}
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		bullet.maxHitCount = (int)((ulong)3L);
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		GameAPP.PlaySound((int)thePlantType, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x0600150E RID: 5390 RVA: 0x000746C8 File Offset: 0x000728C8
	[Token(Token = "0x600150E")]
	[Address(RVA = "0x466C80", Offset = "0x465280", VA = "0x180466C80", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x0600150F RID: 5391 RVA: 0x000746D8 File Offset: 0x000728D8
	[Token(Token = "0x600150F")]
	[Address(RVA = "0x4CFD20", Offset = "0x4CE320", VA = "0x1804CFD20", Slot = "28")]
	protected override void ReplaceSprite()
	{
		CrackStatus crackStatus;
		this.crack = crackStatus;
		if (crackStatus != CrackStatus.Good)
		{
			if (crackStatus == CrackStatus.Good)
			{
				this.anim.SetTrigger("fall1");
				return;
			}
			if (crackStatus == CrackStatus.Normal)
			{
				this.anim.SetTrigger("fall2");
				return;
			}
		}
	}

	// Token: 0x06001510 RID: 5392 RVA: 0x00074724 File Offset: 0x00072924
	[Token(Token = "0x6001510")]
	[Address(RVA = "0x4CFC60", Offset = "0x4CE260", VA = "0x1804CFC60", Slot = "25")]
	public override void Recover(float health, DamageType damageType = DamageType.Normal, bool particle = true, bool continuous = false)
	{
		CrackStatus crackStatus = this.crack;
		if (crackStatus != CrackStatus.Good)
		{
			if (crackStatus != CrackStatus.Good)
			{
				if (crackStatus != CrackStatus.Normal)
				{
					goto IL_0039;
				}
				int thePlantHealth = this.thePlantHealth;
			}
			int num = this.thePlantMaxHealth;
			int thePlantHealth2 = this.thePlantHealth;
			num += num;
			this.thePlantHealth = thePlantHealth2;
		}
		IL_0039:
		this.ReplaceSprite();
	}

	// Token: 0x06001511 RID: 5393 RVA: 0x00074770 File Offset: 0x00072970
	[Token(Token = "0x6001511")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public ThreeNut()
	{
	}

	// Token: 0x04000D53 RID: 3411
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000D53")]
	private CrackStatus crack;
}
