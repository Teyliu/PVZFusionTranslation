using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200060A RID: 1546
[Token(Token = "0x200060A")]
public class Tower_doomFume : TowerPlant
{
	// Token: 0x06001CFF RID: 7423 RVA: 0x0009A240 File Offset: 0x00098440
	[Token(Token = "0x6001CFF")]
	[Address(RVA = "0x560010", Offset = "0x55E610", VA = "0x180560010", Slot = "73")]
	public override void Upgrade(TowerUpgradeType towerUpgradeType)
	{
		float attackSpeed = this.attackSpeed;
		this.attackSpeed = attackSpeed;
		base.Upgrade(towerUpgradeType);
	}

	// Token: 0x06001D00 RID: 7424 RVA: 0x0009A27C File Offset: 0x0009847C
	[Token(Token = "0x6001D00")]
	[Address(RVA = "0x55FEF0", Offset = "0x55E4F0", VA = "0x18055FEF0", Slot = "68")]
	protected override void ShootUpdate()
	{
		float attackTimer = this.attackTimer;
		int num = 0;
		if (attackTimer > (float)num)
		{
			float deltaTime = Time.deltaTime;
			this.attackTimer = attackTimer;
			this.anim.SetTrigger("backToIdle");
			this.attackTimer = 0f;
		}
	}

	// Token: 0x06001D01 RID: 7425 RVA: 0x0009A2C8 File Offset: 0x000984C8
	[Token(Token = "0x6001D01")]
	[Address(RVA = "0x55FFA0", Offset = "0x55E5A0", VA = "0x18055FFA0", Slot = "70")]
	public override void Shoot()
	{
		this.anim.SetTrigger("shoot");
		float attackInterval = this.attackInterval;
		this.attackTimer = attackInterval;
		this.theStatus = (PlantStatus)((ulong)15L);
	}

	// Token: 0x06001D02 RID: 7426 RVA: 0x0009A304 File Offset: 0x00098504
	[Token(Token = "0x6001D02")]
	[Address(RVA = "0x55F9B0", Offset = "0x55DFB0", VA = "0x18055F9B0", Slot = "71")]
	public override void AnimShoot()
	{
		Transform shoot = this.shoot;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = GameAPP.particlePrefab[31];
		Transform transform = this.board.transform;
		GameObject gameObject2;
		Renderer component = gameObject2.GetComponent<ParticleSystem>().GetComponent<Renderer>();
		int thePlantRow = this.thePlantRow;
		string text = string.Format("particle{0}", component);
		component.sortingLayerName = text;
		Transform transform2 = gameObject2.transform;
		int num = 0;
		int num2 = 0;
		transform2.Rotate((float)num2, 180f, (float)num);
		GameAPP.PlaySound(58, 0.5f, 1f);
		this.AttackZombie();
	}

	// Token: 0x06001D03 RID: 7427 RVA: 0x0009A3A8 File Offset: 0x000985A8
	[Token(Token = "0x6001D03")]
	[Address(RVA = "0x55FC80", Offset = "0x55E280", VA = "0x18055FC80")]
	private void AttackZombie()
	{
		Board board = this.board;
		int num = 0;
		int size = board.zombieArray._size;
		int num2 = size - 1;
		if (size > 0)
		{
			Zombie zombie = this.board.zombieArray[num2];
			int num3 = 0;
			if (zombie != num3)
			{
				Transform axis = zombie.axis;
				Transform axis2 = this.axis;
				Transform axis3 = this.axis;
				if (base.SearchUniqueZombie(zombie))
				{
					int thePlantRow = this.thePlantRow;
					if (zombie.theZombieRow == thePlantRow)
					{
						PlantType thePlantType = this.thePlantType;
					}
				}
			}
			if (num != 0)
			{
				GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
			}
		}
	}

	// Token: 0x06001D04 RID: 7428 RVA: 0x0009A458 File Offset: 0x00098658
	[Token(Token = "0x6001D04")]
	[Address(RVA = "0x55D890", Offset = "0x55BE90", VA = "0x18055D890")]
	public Tower_doomFume()
	{
		this.towards = (Towards)((ulong)1L);
		this.basicDamage = 1f;
		this.attackSpeed = 1f;
		base..ctor();
	}
}
