using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200069B RID: 1691
[Token(Token = "0x200069B")]
public class EternalZombie_c : EternalZombie_a
{
	// Token: 0x06002029 RID: 8233 RVA: 0x000AA44C File Offset: 0x000A864C
	[Token(Token = "0x6002029")]
	[Address(RVA = "0x5A7510", Offset = "0x5A5B10", VA = "0x1805A7510", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		float num = global::UnityEngine.Random.Range(4.4f, 7.54f);
		this.attributeCountDown = num;
	}

	// Token: 0x0600202A RID: 8234 RVA: 0x000AA478 File Offset: 0x000A8678
	[Token(Token = "0x600202A")]
	[Address(RVA = "0x5A7470", Offset = "0x5A5A70", VA = "0x1805A7470", Slot = "24")]
	protected override void AttributeEvent()
	{
		if (base.Column > 4)
		{
			this.anim.SetTrigger("quickMove");
			float num = global::UnityEngine.Random.Range(4.4f, 7.54f);
			this.attributeCountDown = num;
			this.SearchPlant();
			return;
		}
	}

	// Token: 0x0600202B RID: 8235 RVA: 0x000AA4C4 File Offset: 0x000A86C4
	[Token(Token = "0x600202B")]
	[Address(RVA = "0x5A7640", Offset = "0x5A5C40", VA = "0x1805A7640")]
	private void EnterMoving()
	{
		GameAPP.PlaySound(42, 0.3f, 1.6f);
		base.ChangeStatus((ZombieStatus)((uint)33));
		Queue<Plant> targets = this._targets;
		this.isMovingBetweenPlants = true;
		int num;
		this.plantsToMoveBetween = num;
		this.moveTimer = 0f;
		this.alternateDirection = true;
		this.SetNextTargetPosition();
	}

	// Token: 0x0600202C RID: 8236 RVA: 0x000AA520 File Offset: 0x000A8720
	[Token(Token = "0x600202C")]
	[Address(RVA = "0x5A7F80", Offset = "0x5A6580", VA = "0x1805A7F80")]
	private void SetNextTargetPosition()
	{
		Queue<Plant> targets = this._targets;
		if (this.plantsToMoveBetween > 0)
		{
			Plant plant = targets.Peek();
			int num = 0;
			bool flag = plant == num;
			if (!flag)
			{
				Transform axis = plant.axis;
				if (this.alternateDirection == flag)
				{
					Vector3 vector;
					float z = vector.z;
					Transform axis2 = plant.axis;
				}
				Vector3 vector2;
				float z2 = vector2.z;
				Transform axis3 = plant.axis;
				Vector3 vector3;
				float z3 = vector3.z;
				this.targetPosition = 0;
				this.targetPosition.y = (float)0;
				bool flag2 = !this.alternateDirection;
				this.alternateDirection = flag2;
				return;
			}
		}
		Transform axis4 = this.axis;
		Vector3 vector4;
		float z4 = vector4.z;
		Transform axis5 = this.axis;
		this.targetPosition.y = 0f;
		Mouse instance = Mouse.Instance;
		float num2;
		this.targetPosition.y = num2;
		this.isMovingBetweenPlants = false;
	}

	// Token: 0x0600202D RID: 8237 RVA: 0x000AA608 File Offset: 0x000A8808
	[Token(Token = "0x600202D")]
	[Address(RVA = "0x5A7700", Offset = "0x5A5D00", VA = "0x1805A7700", Slot = "21")]
	protected override void MoveUpdate()
	{
		base.MoveUpdate();
		Animator anim = this.anim;
		int num = 0;
		anim.SetBool("moving", num != 0);
	}

	// Token: 0x0600202E RID: 8238 RVA: 0x000AA7B4 File Offset: 0x000A89B4
	[Token(Token = "0x600202E")]
	[Address(RVA = "0x5A7550", Offset = "0x5A5B50", VA = "0x1805A7550")]
	private void EndSpecialMove()
	{
		int num = 0;
		base.ChangeStatus((ZombieStatus)num);
		Animator anim = this.anim;
		int num2 = 0;
		anim.SetBool("moving", num2 != 0);
		Transform axis = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		int num3 = 0;
		int num4 = 0;
		ulong num5;
		Particle particle = instance.SetParticle(ParticleType.RandomCloud, num3, 11, num5 != 0UL, (float)num4);
	}

	// Token: 0x0600202F RID: 8239 RVA: 0x000AA810 File Offset: 0x000A8A10
	[Token(Token = "0x600202F")]
	[Address(RVA = "0x5A7D10", Offset = "0x5A6310", VA = "0x1805A7D10")]
	private void SearchPlant()
	{
		ulong num4;
		do
		{
			int num = 0;
			this._targets.Clear();
			int num2 = 0;
			int column = base.Column;
			if (num2 >= 4)
			{
				break;
			}
			int theZombieRow = this.theZombieRow;
			List<Plant> list = Lawnf.Get1x1Plants(column, theZombieRow);
			bool flag;
			if (flag)
			{
				int num3 = 0;
				Plant plant;
				if (!(plant == num3))
				{
				}
				this._targets.Enqueue(num);
				num2++;
			}
		}
		while (num4 != (ulong)0L);
	}

	// Token: 0x06002030 RID: 8240 RVA: 0x000AA884 File Offset: 0x000A8A84
	[Token(Token = "0x6002030")]
	[Address(RVA = "0x5A82C0", Offset = "0x5A68C0", VA = "0x1805A82C0")]
	public EternalZombie_c()
	{
		Queue<Plant> queue = new Queue();
		this._targets = queue;
		this.moveDuration = 0.2f;
		this.speed = 10f;
		this.alternateDirection = true;
		base..ctor();
	}

	// Token: 0x04001139 RID: 4409
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001139")]
	private readonly Queue<Plant> _targets;

	// Token: 0x0400113A RID: 4410
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x400113A")]
	private Vector2 startPosition;

	// Token: 0x0400113B RID: 4411
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x400113B")]
	private Vector2 targetPosition;

	// Token: 0x0400113C RID: 4412
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x400113C")]
	private bool isMovingBetweenPlants;

	// Token: 0x0400113D RID: 4413
	[FieldOffset(Offset = "0x294")]
	[Token(Token = "0x400113D")]
	private int plantsToMoveBetween;

	// Token: 0x0400113E RID: 4414
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x400113E")]
	private readonly float moveDuration;

	// Token: 0x0400113F RID: 4415
	[FieldOffset(Offset = "0x29C")]
	[Token(Token = "0x400113F")]
	private float moveTimer;

	// Token: 0x04001140 RID: 4416
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x4001140")]
	private readonly float speed;

	// Token: 0x04001141 RID: 4417
	[FieldOffset(Offset = "0x2A4")]
	[Token(Token = "0x4001141")]
	private bool alternateDirection;
}
