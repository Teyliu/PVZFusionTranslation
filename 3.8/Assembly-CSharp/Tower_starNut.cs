using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005DC RID: 1500
[Token(Token = "0x20005DC")]
public class Tower_starNut : TowerNut
{
	// Token: 0x06001C2D RID: 7213 RVA: 0x00096704 File Offset: 0x00094904
	[Token(Token = "0x6001C2D")]
	[Address(RVA = "0x512C40", Offset = "0x511240", VA = "0x180512C40", Slot = "74")]
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

	// Token: 0x06001C2E RID: 7214 RVA: 0x00096740 File Offset: 0x00094940
	[Token(Token = "0x6001C2E")]
	[Address(RVA = "0x5129C0", Offset = "0x510FC0", VA = "0x1805129C0", Slot = "40")]
	protected override void AttributeEvent()
	{
		int num = 0;
		ulong num2;
		base.Recover(100f, (DamageType)num, true, num2 != 0UL);
		base.AttributeCountdown = 3f;
	}

	// Token: 0x06001C2F RID: 7215 RVA: 0x0009676C File Offset: 0x0009496C
	[Token(Token = "0x6001C2F")]
	[Address(RVA = "0x512B80", Offset = "0x511180", VA = "0x180512B80", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		base.ReplaceSprite();
		this.SetBullet((BulletMoveWay)((uint)2), 30f);
		this.SetBullet((BulletMoveWay)((uint)2), -30f);
		this.SetBullet((BulletMoveWay)((uint)9), 180f);
		this.SetBullet((BulletMoveWay)((uint)2), 90f);
		this.SetBullet((BulletMoveWay)((uint)2), -90f);
	}

	// Token: 0x06001C30 RID: 7216 RVA: 0x000967C4 File Offset: 0x000949C4
	[Token(Token = "0x6001C30")]
	[Address(RVA = "0x512A20", Offset = "0x511020", VA = "0x180512A20")]
	private void SetBullet(BulletMoveWay theMovingWay, float angle)
	{
		Transform shoot = this.shoot;
		Vector3 vector;
		float z = vector.z;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		Transform transform = bullet.transform;
		float num = angle * 0.017453292f;
	}

	// Token: 0x06001C31 RID: 7217 RVA: 0x00096804 File Offset: 0x00094A04
	[Token(Token = "0x6001C31")]
	[Address(RVA = "0x50C640", Offset = "0x50AC40", VA = "0x18050C640")]
	public Tower_starNut()
	{
		this.towards = (Towards)((ulong)1L);
		this.basicDamage = 1f;
		this.attackSpeed = 1f;
		base..ctor();
	}
}
