using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000457 RID: 1111
[Token(Token = "0x2000457")]
public class ThreeNut : Shooter
{
	// Token: 0x0600147D RID: 5245 RVA: 0x000722CC File Offset: 0x000704CC
	[Token(Token = "0x600147D")]
	[Address(RVA = "0x478510", Offset = "0x476B10", VA = "0x180478510", Slot = "69")]
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
				bullet.penetrationTimes = (int)((ulong)7L);
			}
			bullet.penetrationTimes = (int)((ulong)5L);
		}
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		bullet.penetrationTimes = (int)((ulong)3L);
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		GameAPP.PlaySound((int)thePlantType, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x0600147E RID: 5246 RVA: 0x00072370 File Offset: 0x00070570
	[Token(Token = "0x600147E")]
	[Address(RVA = "0x41A120", Offset = "0x418720", VA = "0x18041A120", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x0600147F RID: 5247 RVA: 0x00072380 File Offset: 0x00070580
	[Token(Token = "0x600147F")]
	[Address(RVA = "0x478460", Offset = "0x476A60", VA = "0x180478460", Slot = "29")]
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

	// Token: 0x06001480 RID: 5248 RVA: 0x000723CC File Offset: 0x000705CC
	[Token(Token = "0x6001480")]
	[Address(RVA = "0x4783A0", Offset = "0x4769A0", VA = "0x1804783A0", Slot = "26")]
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

	// Token: 0x06001481 RID: 5249 RVA: 0x00072418 File Offset: 0x00070618
	[Token(Token = "0x6001481")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public ThreeNut()
	{
	}

	// Token: 0x04000CC7 RID: 3271
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000CC7")]
	private CrackStatus crack;
}
