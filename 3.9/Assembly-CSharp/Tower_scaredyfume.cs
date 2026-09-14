using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200060F RID: 1551
[Token(Token = "0x200060F")]
public class Tower_scaredyfume : TowerPlant
{
	// Token: 0x06001D1D RID: 7453 RVA: 0x0009ADC0 File Offset: 0x00098FC0
	[Token(Token = "0x6001D1D")]
	[Address(RVA = "0x579090", Offset = "0x577690", VA = "0x180579090", Slot = "71")]
	public override void AnimShoot()
	{
		Transform shoot = this.shoot;
		Vector3 vector;
		float z = vector.z;
		CreateBullet instance = CreateBullet.Instance;
		int damage = base.Damage;
		Bullet bullet;
		bullet.Damage = damage;
		GameAPP.PlaySound(57, 0.5f, 1f);
	}

	// Token: 0x06001D1E RID: 7454 RVA: 0x0009AE0C File Offset: 0x0009900C
	[Token(Token = "0x6001D1E")]
	[Address(RVA = "0x578CF0", Offset = "0x5772F0", VA = "0x180578CF0")]
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
				int damage = base.Damage;
				PlantType thePlantType = this.thePlantType;
			}
		}
		gameObject2.transform.Rotate((float)num, 180f, (float)num);
	}

	// Token: 0x06001D1F RID: 7455 RVA: 0x0009AEEC File Offset: 0x000990EC
	[Token(Token = "0x6001D1F")]
	[Address(RVA = "0x579610", Offset = "0x577C10", VA = "0x180579610", Slot = "73")]
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

	// Token: 0x06001D20 RID: 7456 RVA: 0x0009AF2C File Offset: 0x0009912C
	[Token(Token = "0x6001D20")]
	[Address(RVA = "0x5794B0", Offset = "0x577AB0", VA = "0x1805794B0", Slot = "70")]
	public override void Shoot()
	{
		Transform axis = this.axis;
		Board board = this.board;
		Func<Zombie, bool> func = new Func(this.FumeCheckZombie);
		int num = 0;
		Zombie zombie;
		if (!(zombie == num))
		{
			this.anim.SetTrigger("shoot2");
			return;
		}
		this.anim.SetTrigger("shoot");
	}

	// Token: 0x06001D21 RID: 7457 RVA: 0x0009AF8C File Offset: 0x0009918C
	[Token(Token = "0x6001D21")]
	[Address(RVA = "0x5792C0", Offset = "0x5778C0", VA = "0x1805792C0")]
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

	// Token: 0x06001D22 RID: 7458 RVA: 0x0009B018 File Offset: 0x00099218
	[Token(Token = "0x6001D22")]
	[Address(RVA = "0x5791C0", Offset = "0x5777C0", VA = "0x1805791C0")]
	public void AttackZombie()
	{
		int size = this.board.zombieArray._size;
		int num = size - 1;
		if (size > 0)
		{
			Zombie zombie = this.board.zombieArray[num];
			if (this.FumeCheckZombie(zombie))
			{
				int damage = base.Damage;
				PlantType thePlantType = this.thePlantType;
			}
		}
	}

	// Token: 0x06001D23 RID: 7459 RVA: 0x0009B070 File Offset: 0x00099270
	[Token(Token = "0x6001D23")]
	[Address(RVA = "0x5796A0", Offset = "0x577CA0", VA = "0x1805796A0")]
	public Tower_scaredyfume()
	{
	}

	// Token: 0x04000FCE RID: 4046
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000FCE")]
	private float attackRange = 7f;
}
