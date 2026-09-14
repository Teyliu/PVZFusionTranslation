using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000616 RID: 1558
[Token(Token = "0x2000616")]
public class Tower_waterCan : TowerPlant
{
	// Token: 0x06001D57 RID: 7511 RVA: 0x0009BF90 File Offset: 0x0009A190
	[Token(Token = "0x6001D57")]
	[Address(RVA = "0x57D110", Offset = "0x57B710", VA = "0x18057D110", Slot = "73")]
	public override void Upgrade(TowerUpgradeType towerUpgradeType)
	{
		float attackSpeed = this.attackSpeed;
		this.attackSpeed = attackSpeed;
		base.Upgrade(towerUpgradeType);
	}

	// Token: 0x06001D58 RID: 7512 RVA: 0x0009BFD8 File Offset: 0x0009A1D8
	[Token(Token = "0x6001D58")]
	[Address(RVA = "0x57CFE0", Offset = "0x57B5E0", VA = "0x18057CFE0")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		if (flag && collision == this)
		{
			this.anim.SetTrigger("shoot");
			float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
			this.attackTimer = num;
		}
	}

	// Token: 0x06001D59 RID: 7513 RVA: 0x0009C024 File Offset: 0x0009A224
	[Token(Token = "0x6001D59")]
	[Address(RVA = "0x57CBE0", Offset = "0x57B1E0", VA = "0x18057CBE0", Slot = "71")]
	public override void AnimShoot()
	{
		Transform shoot = this.shoot;
		Board board = this.board;
		Vector3 vector;
		float z = vector.z;
		int num = 0;
		Zombie zombie;
		if (zombie != num)
		{
			Transform shoot2 = this.shoot;
			CreateBullet instance = CreateBullet.Instance;
			Transform shoot3 = this.shoot;
			int damage = base.Damage;
			Bullet bullet;
			bullet.Damage = damage;
			bullet.from = this;
			Transform shoot4 = this.shoot;
			Vector2 velocity = zombie.Velocity;
			GameAPP.PlaySound((int)zombie.ColliderPosition.x, 0.5f, 1f);
		}
		this.anim.SetTrigger("shoot");
	}

	// Token: 0x06001D5A RID: 7514 RVA: 0x0009C0C8 File Offset: 0x0009A2C8
	[Token(Token = "0x6001D5A")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "69")]
	protected override bool CheckGrave()
	{
		return false;
	}

	// Token: 0x06001D5B RID: 7515 RVA: 0x0009C0D8 File Offset: 0x0009A2D8
	[Token(Token = "0x6001D5B")]
	[Address(RVA = "0x57CEF0", Offset = "0x57B4F0", VA = "0x18057CEF0", Slot = "72")]
	protected override bool CheckZombie(Zombie zombie)
	{
		if (zombie.Column > 2)
		{
		}
		return zombie.theZombieRow <= 2;
	}

	// Token: 0x06001D5C RID: 7516 RVA: 0x0009C104 File Offset: 0x0009A304
	[Token(Token = "0x6001D5C")]
	[Address(RVA = "0x578AF0", Offset = "0x5770F0", VA = "0x180578AF0")]
	public Tower_waterCan()
	{
	}
}
