using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005DA RID: 1498
[Token(Token = "0x20005DA")]
public class Tower_scaredyfume : TowerPlant
{
	// Token: 0x06001C1E RID: 7198 RVA: 0x000961C0 File Offset: 0x000943C0
	[Token(Token = "0x6001C1E")]
	[Address(RVA = "0x5116E0", Offset = "0x50FCE0", VA = "0x1805116E0", Slot = "72")]
	public override void AnimShoot()
	{
		Transform shoot = this.shoot;
		Vector3 vector;
		float z = vector.z;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		bullet.Damage = 9;
		GameAPP.PlaySound(57, 0.5f, 1f);
	}

	// Token: 0x06001C1F RID: 7199 RVA: 0x00096204 File Offset: 0x00094404
	[Token(Token = "0x6001C1F")]
	[Address(RVA = "0x511340", Offset = "0x50F940", VA = "0x180511340")]
	private void AnimShoot2()
	{
		Transform shoot = this.shoot;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = GameAPP.particlePrefab[19];
		int num = 0;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		Renderer component = gameObject2.GetComponent<ParticleSystem>().GetComponent<Renderer>();
		int thePlantRow = this.thePlantRow;
		string text = string.Format("particle{0}", component);
		component.sortingLayerName = text;
		GameAPP.PlaySound(58, 0.5f, 1f);
		int size = this.board.zombieArray._size;
		int num2 = size - 1;
		if (size > 0)
		{
			Zombie zombie = this.board.zombieArray[num2];
			if (this.FumeCheckZombie(zombie))
			{
				PlantType thePlantType = this.thePlantType;
			}
		}
		gameObject2.transform.Rotate((float)num, 180f, (float)num);
	}

	// Token: 0x06001C20 RID: 7200 RVA: 0x000962E0 File Offset: 0x000944E0
	[Token(Token = "0x6001C20")]
	[Address(RVA = "0x511C70", Offset = "0x510270", VA = "0x180511C70", Slot = "74")]
	public override void Upgrade(TowerUpgradeType towerUpgradeType)
	{
		float num = this.attackRange;
		this.attackRange = num;
		float attackSpeed = this.attackSpeed;
		this.attackSpeed = attackSpeed;
		float basicDamage = this.basicDamage;
		this.basicDamage = basicDamage;
		base.Upgrade(towerUpgradeType);
	}

	// Token: 0x06001C21 RID: 7201 RVA: 0x00096320 File Offset: 0x00094520
	[Token(Token = "0x6001C21")]
	[Address(RVA = "0x511B10", Offset = "0x510110", VA = "0x180511B10", Slot = "71")]
	public override void Shoot()
	{
		Transform axis = this.axis;
		Board board = this.board;
		int num = 0;
		Zombie zombie;
		if (!(zombie == num))
		{
			this.anim.SetTrigger("shoot2");
			return;
		}
		this.anim.SetTrigger("shoot");
	}

	// Token: 0x06001C22 RID: 7202 RVA: 0x00096374 File Offset: 0x00094574
	[Token(Token = "0x6001C22")]
	[Address(RVA = "0x511920", Offset = "0x50FF20", VA = "0x180511920")]
	private bool FumeCheckZombie(Zombie zombie)
	{
		int num = 0;
		if (zombie != num)
		{
			int thePlantRow = this.thePlantRow;
			if (zombie.theZombieRow == thePlantRow && !zombie.isMindControlled && Lawnf.InLandStatus(zombie.theStatus))
			{
				Transform axis = zombie.axis;
				Transform axis2 = this.axis;
				Transform axis3 = zombie.axis;
				Transform axis4 = this.axis;
				return true;
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001C23 RID: 7203 RVA: 0x00096400 File Offset: 0x00094600
	[Token(Token = "0x6001C23")]
	[Address(RVA = "0x511800", Offset = "0x50FE00", VA = "0x180511800")]
	public void AttackZombie()
	{
		int size = this.board.zombieArray._size;
		int num = size - 1;
		if (size > 0)
		{
			Zombie zombie = this.board.zombieArray[num];
			if (this.FumeCheckZombie(zombie))
			{
				PlantType thePlantType = this.thePlantType;
			}
		}
	}

	// Token: 0x06001C24 RID: 7204 RVA: 0x00096450 File Offset: 0x00094650
	[Token(Token = "0x6001C24")]
	[Address(RVA = "0x511D00", Offset = "0x510300", VA = "0x180511D00")]
	public Tower_scaredyfume()
	{
		this.towards = (Towards)((ulong)1L);
		this.basicDamage = 1f;
		this.attackSpeed = 1f;
		base..ctor();
	}

	// Token: 0x04000F06 RID: 3846
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000F06")]
	private float attackRange = 7f;
}
