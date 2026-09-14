using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005E1 RID: 1505
[Token(Token = "0x20005E1")]
public class Tower_waterCan : TowerPlant
{
	// Token: 0x06001C58 RID: 7256 RVA: 0x000973F0 File Offset: 0x000955F0
	[Token(Token = "0x6001C58")]
	[Address(RVA = "0x5158E0", Offset = "0x513EE0", VA = "0x1805158E0", Slot = "74")]
	public override void Upgrade(TowerUpgradeType towerUpgradeType)
	{
		float attackSpeed = this.attackSpeed;
		this.attackSpeed = attackSpeed;
		base.Upgrade(towerUpgradeType);
	}

	// Token: 0x06001C59 RID: 7257 RVA: 0x00097438 File Offset: 0x00095638
	[Token(Token = "0x6001C59")]
	[Address(RVA = "0x5157B0", Offset = "0x513DB0", VA = "0x1805157B0")]
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

	// Token: 0x06001C5A RID: 7258 RVA: 0x00097484 File Offset: 0x00095684
	[Token(Token = "0x6001C5A")]
	[Address(RVA = "0x515330", Offset = "0x513930", VA = "0x180515330", Slot = "72")]
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
			Bullet bullet;
			bullet.from = this;
			Transform shoot4 = this.shoot;
			Vector2 velocity = zombie.Velocity;
			Vector2 colliderPosition = zombie.ColliderPosition;
			float[] array;
			float num2 = array[0];
			bullet.Vx = num2;
			float num3 = array[1];
			bullet.Vy = num3;
			float num4 = array[1];
			bullet.detaVy = num4;
		}
		this.anim.SetTrigger("shoot");
	}

	// Token: 0x06001C5B RID: 7259 RVA: 0x00097540 File Offset: 0x00095740
	[Token(Token = "0x6001C5B")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "70")]
	protected override bool CheckGrave()
	{
		return false;
	}

	// Token: 0x06001C5C RID: 7260 RVA: 0x00097550 File Offset: 0x00095750
	[Token(Token = "0x6001C5C")]
	[Address(RVA = "0x5156C0", Offset = "0x513CC0", VA = "0x1805156C0", Slot = "73")]
	protected override bool CheckZombie(Zombie zombie)
	{
		if (zombie.Column > 2)
		{
		}
		return zombie.theZombieRow <= 2;
	}

	// Token: 0x06001C5D RID: 7261 RVA: 0x0009757C File Offset: 0x0009577C
	[Token(Token = "0x6001C5D")]
	[Address(RVA = "0x50C640", Offset = "0x50AC40", VA = "0x18050C640")]
	public Tower_waterCan()
	{
		this.towards = (Towards)((ulong)1L);
		this.basicDamage = 1f;
		this.attackSpeed = 1f;
		base..ctor();
	}
}
