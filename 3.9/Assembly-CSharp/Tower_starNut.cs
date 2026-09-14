using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000611 RID: 1553
[Token(Token = "0x2000611")]
public class Tower_starNut : TowerNut
{
	// Token: 0x06001D2C RID: 7468 RVA: 0x0009B2D0 File Offset: 0x000994D0
	[Token(Token = "0x6001D2C")]
	[Address(RVA = "0x57A580", Offset = "0x578B80", VA = "0x18057A580", Slot = "73")]
	public override void Upgrade(TowerUpgradeType towerUpgradeType)
	{
		if (this != 0)
		{
			if (this != 0)
			{
				if (this != (ulong)1L)
				{
					goto IL_0027;
				}
				base.AttributeCountdown = 1f;
			}
			this.thePlantMaxHealth = this;
			this.thePlantHealth = this;
		}
		IL_0027:
		base.UpdateText();
	}

	// Token: 0x06001D2D RID: 7469 RVA: 0x0009B30C File Offset: 0x0009950C
	[Token(Token = "0x6001D2D")]
	[Address(RVA = "0x57A310", Offset = "0x578910", VA = "0x18057A310", Slot = "39")]
	protected override void AttributeEvent()
	{
		int num = 0;
		ulong num2;
		base.Recover(100f, (DamageType)num, true, num2 != 0UL);
		base.AttributeCountdown = 3f;
	}

	// Token: 0x06001D2E RID: 7470 RVA: 0x0009B338 File Offset: 0x00099538
	[Token(Token = "0x6001D2E")]
	[Address(RVA = "0x57A4D0", Offset = "0x578AD0", VA = "0x18057A4D0", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		this.SetBullet((BulletMoveWay)((uint)5), 30f);
		this.SetBullet((BulletMoveWay)((uint)5), -30f);
		this.SetBullet((BulletMoveWay)((uint)6), 180f);
		this.SetBullet((BulletMoveWay)((uint)5), 90f);
		this.SetBullet((BulletMoveWay)((uint)5), -90f);
	}

	// Token: 0x06001D2F RID: 7471 RVA: 0x0009B388 File Offset: 0x00099588
	[Token(Token = "0x6001D2F")]
	[Address(RVA = "0x57A370", Offset = "0x578970", VA = "0x18057A370")]
	private void SetBullet(BulletMoveWay theMovingWay, float angle)
	{
		Transform shoot = this.shoot;
		Vector3 vector;
		float z = vector.z;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		Transform transform = bullet.transform;
		float num = angle * 0.017453292f;
		int damage = base.Damage;
		bullet.Damage = damage;
	}

	// Token: 0x06001D30 RID: 7472 RVA: 0x0009B3D8 File Offset: 0x000995D8
	[Token(Token = "0x6001D30")]
	[Address(RVA = "0x578AF0", Offset = "0x5770F0", VA = "0x180578AF0")]
	public Tower_starNut()
	{
	}
}
