using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005D5 RID: 1493
[Token(Token = "0x20005D5")]
public class Tower_doomFume : TowerPlant
{
	// Token: 0x06001C00 RID: 7168 RVA: 0x00095628 File Offset: 0x00093828
	[Token(Token = "0x6001C00")]
	[Address(RVA = "0x50EDC0", Offset = "0x50D3C0", VA = "0x18050EDC0", Slot = "74")]
	public override void Upgrade(TowerUpgradeType towerUpgradeType)
	{
		float attackSpeed = this.attackSpeed;
		this.attackSpeed = attackSpeed;
		base.Upgrade(towerUpgradeType);
	}

	// Token: 0x06001C01 RID: 7169 RVA: 0x00095664 File Offset: 0x00093864
	[Token(Token = "0x6001C01")]
	[Address(RVA = "0x50ECA0", Offset = "0x50D2A0", VA = "0x18050ECA0", Slot = "69")]
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

	// Token: 0x06001C02 RID: 7170 RVA: 0x000956B0 File Offset: 0x000938B0
	[Token(Token = "0x6001C02")]
	[Address(RVA = "0x50ED50", Offset = "0x50D350", VA = "0x18050ED50", Slot = "71")]
	public override void Shoot()
	{
		this.anim.SetTrigger("shoot");
		float attackInterval = this.attackInterval;
		this.attackTimer = attackInterval;
		this.theStatus = (PlantStatus)((ulong)15L);
	}

	// Token: 0x06001C03 RID: 7171 RVA: 0x000956EC File Offset: 0x000938EC
	[Token(Token = "0x6001C03")]
	[Address(RVA = "0x50E760", Offset = "0x50CD60", VA = "0x18050E760", Slot = "72")]
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

	// Token: 0x06001C04 RID: 7172 RVA: 0x00095790 File Offset: 0x00093990
	[Token(Token = "0x6001C04")]
	[Address(RVA = "0x50EA30", Offset = "0x50D030", VA = "0x18050EA30")]
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

	// Token: 0x06001C05 RID: 7173 RVA: 0x00095840 File Offset: 0x00093A40
	[Token(Token = "0x6001C05")]
	[Address(RVA = "0x50C640", Offset = "0x50AC40", VA = "0x18050C640")]
	public Tower_doomFume()
	{
		this.towards = (Towards)((ulong)1L);
		this.basicDamage = 1f;
		this.attackSpeed = 1f;
		base..ctor();
	}
}
