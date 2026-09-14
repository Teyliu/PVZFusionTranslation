using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006D3 RID: 1747
[Token(Token = "0x20006D3")]
public class Submarine_c : Submarine_b
{
	// Token: 0x06002267 RID: 8807 RVA: 0x000B4720 File Offset: 0x000B2920
	[Token(Token = "0x6002267")]
	[Address(RVA = "0x5732B0", Offset = "0x5718B0", VA = "0x1805732B0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.inWater = true;
		this.attributeCountDown = 1.5f;
		this.theStatus = (ZombieStatus)((ulong)7L);
	}

	// Token: 0x06002268 RID: 8808 RVA: 0x000B4750 File Offset: 0x000B2950
	[Token(Token = "0x6002268")]
	[Address(RVA = "0x573250", Offset = "0x571850", VA = "0x180573250", Slot = "23")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("shoot");
		this.attributeCountDown = 1.5f;
	}

	// Token: 0x06002269 RID: 8809 RVA: 0x000B4780 File Offset: 0x000B2980
	[Token(Token = "0x6002269")]
	[Address(RVA = "0x5732E0", Offset = "0x5718E0", VA = "0x1805732E0", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		Transform axis = this.axis;
		float boxXFromColumn = Lawnf.GetBoxXFromColumn(this.board.columnNum);
		Plant plant = this.SearchPlant();
		int num = 0;
		if (!(plant != num))
		{
		}
		int num2 = 0;
		base.ChangeStatus((ZombieStatus)num2);
		bool flag;
		this.anim.SetBool("rise", flag);
	}

	// Token: 0x0600226A RID: 8810 RVA: 0x000B47E4 File Offset: 0x000B29E4
	[Token(Token = "0x600226A")]
	[Address(RVA = "0x573430", Offset = "0x571A30", VA = "0x180573430")]
	private Plant SearchPlant()
	{
		int num2;
		ulong num4;
		do
		{
			int num = 0;
			num2 = 0;
			Board board = this.board;
			if (num2 >= board.columnNum)
			{
				goto IL_005D;
			}
			GridSystem gridSystem = board.gridSystem;
			int theZombieRow = this.theZombieRow;
			List<Plant> plants = gridSystem.GetGrid(num2, theZombieRow).plants;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				Transform axis = this.axis;
			}
		}
		while (num4 != (ulong)0L);
		num2++;
		IL_005D:
		throw new NullReferenceException();
	}

	// Token: 0x0600226B RID: 8811 RVA: 0x000B4868 File Offset: 0x000B2A68
	[Token(Token = "0x600226B")]
	[Address(RVA = "0x573080", Offset = "0x571680", VA = "0x180573080", Slot = "74")]
	protected override void AnimShoot()
	{
		Plant plant = this.SearchPlant();
		int num = 0;
		if (plant != num)
		{
			Transform shoot = this.shoot;
			Vector3 vector;
			float z = vector.z;
			Transform axis = plant.axis;
			Vector3 vector2;
			float z2 = vector2.z;
			Transform transform = this.shoot2;
			Vector3 vector3;
			float z3 = vector3.z;
			Transform axis2 = plant.axis;
		}
	}

	// Token: 0x0600226C RID: 8812 RVA: 0x000B48C8 File Offset: 0x000B2AC8
	[Token(Token = "0x600226C")]
	[Address(RVA = "0x573680", Offset = "0x571C80", VA = "0x180573680")]
	private void SetBullet(Vector2 startPosition, Vector2 targetPosition)
	{
		CreateZombie instance = CreateZombie.Instance;
		Zombie zombie;
		ProjectileZombie component = zombie.GetComponent<ProjectileZombie>();
		Transform transform = component.transform;
		Vector2 vector;
		component.v = vector;
		component.v.y = (float)0;
		component.a = (ulong)0L;
		component.a.y = -5f;
	}

	// Token: 0x0600226D RID: 8813 RVA: 0x000B4928 File Offset: 0x000B2B28
	[Token(Token = "0x600226D")]
	[Address(RVA = "0x572B40", Offset = "0x571140", VA = "0x180572B40")]
	public Submarine_c()
	{
	}

	// Token: 0x04001135 RID: 4405
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x4001135")]
	public Transform shoot2;
}
