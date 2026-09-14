using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200070B RID: 1803
[Token(Token = "0x200070B")]
public class Submarine_c : Submarine_b
{
	// Token: 0x06002381 RID: 9089 RVA: 0x000B94DC File Offset: 0x000B76DC
	[Token(Token = "0x6002381")]
	[Address(RVA = "0x5D6920", Offset = "0x5D4F20", VA = "0x1805D6920", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.inWater = true;
		this.attributeCountDown = 1.5f;
		this.theStatus = (ZombieStatus)((ulong)7L);
	}

	// Token: 0x06002382 RID: 9090 RVA: 0x000B950C File Offset: 0x000B770C
	[Token(Token = "0x6002382")]
	[Address(RVA = "0x5D68C0", Offset = "0x5D4EC0", VA = "0x1805D68C0", Slot = "24")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("shoot");
		this.attributeCountDown = 1.5f;
	}

	// Token: 0x06002383 RID: 9091 RVA: 0x000B953C File Offset: 0x000B773C
	[Token(Token = "0x6002383")]
	[Address(RVA = "0x5D6950", Offset = "0x5D4F50", VA = "0x1805D6950", Slot = "18")]
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

	// Token: 0x06002384 RID: 9092 RVA: 0x000B95A0 File Offset: 0x000B77A0
	[Token(Token = "0x6002384")]
	[Address(RVA = "0x5D6AA0", Offset = "0x5D50A0", VA = "0x1805D6AA0")]
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

	// Token: 0x06002385 RID: 9093 RVA: 0x000B9624 File Offset: 0x000B7824
	[Token(Token = "0x6002385")]
	[Address(RVA = "0x5D66F0", Offset = "0x5D4CF0", VA = "0x1805D66F0", Slot = "76")]
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

	// Token: 0x06002386 RID: 9094 RVA: 0x000B9684 File Offset: 0x000B7884
	[Token(Token = "0x6002386")]
	[Address(RVA = "0x5D6CF0", Offset = "0x5D52F0", VA = "0x1805D6CF0")]
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

	// Token: 0x06002387 RID: 9095 RVA: 0x000B96E4 File Offset: 0x000B78E4
	[Token(Token = "0x6002387")]
	[Address(RVA = "0x5D61B0", Offset = "0x5D47B0", VA = "0x1805D61B0")]
	public Submarine_c()
	{
	}

	// Token: 0x04001202 RID: 4610
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4001202")]
	public Transform shoot2;
}
