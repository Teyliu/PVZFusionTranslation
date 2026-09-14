using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000665 RID: 1637
[Token(Token = "0x2000665")]
public class EternalZombie_c : EternalZombie_a
{
	// Token: 0x06001F27 RID: 7975 RVA: 0x000A5CD4 File Offset: 0x000A3ED4
	[Token(Token = "0x6001F27")]
	[Address(RVA = "0x544EF0", Offset = "0x5434F0", VA = "0x180544EF0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		float num = global::UnityEngine.Random.Range(4.4f, 7.54f);
		this.attributeCountDown = num;
	}

	// Token: 0x06001F28 RID: 7976 RVA: 0x000A5D00 File Offset: 0x000A3F00
	[Token(Token = "0x6001F28")]
	[Address(RVA = "0x544E50", Offset = "0x543450", VA = "0x180544E50", Slot = "23")]
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

	// Token: 0x06001F29 RID: 7977 RVA: 0x000A5D4C File Offset: 0x000A3F4C
	[Token(Token = "0x6001F29")]
	[Address(RVA = "0x545020", Offset = "0x543620", VA = "0x180545020")]
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

	// Token: 0x06001F2A RID: 7978 RVA: 0x000A5DA8 File Offset: 0x000A3FA8
	[Token(Token = "0x6001F2A")]
	[Address(RVA = "0x545960", Offset = "0x543F60", VA = "0x180545960")]
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

	// Token: 0x06001F2B RID: 7979 RVA: 0x000A5E90 File Offset: 0x000A4090
	[Token(Token = "0x6001F2B")]
	[Address(RVA = "0x5450E0", Offset = "0x5436E0", VA = "0x1805450E0", Slot = "20")]
	protected override void MoveUpdate()
	{
		base.MoveUpdate();
		Animator anim = this.anim;
		int num = 0;
		anim.SetBool("moving", num != 0);
	}

	// Token: 0x06001F2C RID: 7980 RVA: 0x000A603C File Offset: 0x000A423C
	[Token(Token = "0x6001F2C")]
	[Address(RVA = "0x544F30", Offset = "0x543530", VA = "0x180544F30")]
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

	// Token: 0x06001F2D RID: 7981 RVA: 0x000A6098 File Offset: 0x000A4298
	[Token(Token = "0x6001F2D")]
	[Address(RVA = "0x5456F0", Offset = "0x543CF0", VA = "0x1805456F0")]
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

	// Token: 0x06001F2E RID: 7982 RVA: 0x000A610C File Offset: 0x000A430C
	[Token(Token = "0x6001F2E")]
	[Address(RVA = "0x545CA0", Offset = "0x5442A0", VA = "0x180545CA0")]
	public EternalZombie_c()
	{
		Queue<Plant> queue = new Queue();
		this._targets = queue;
		this.moveDuration = 0.2f;
		this.speed = 10f;
		this.alternateDirection = true;
		base..ctor();
	}

	// Token: 0x0400106D RID: 4205
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x400106D")]
	private readonly Queue<Plant> _targets;

	// Token: 0x0400106E RID: 4206
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x400106E")]
	private Vector2 startPosition;

	// Token: 0x0400106F RID: 4207
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x400106F")]
	private Vector2 targetPosition;

	// Token: 0x04001070 RID: 4208
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4001070")]
	private bool isMovingBetweenPlants;

	// Token: 0x04001071 RID: 4209
	[FieldOffset(Offset = "0x274")]
	[Token(Token = "0x4001071")]
	private int plantsToMoveBetween;

	// Token: 0x04001072 RID: 4210
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001072")]
	private readonly float moveDuration;

	// Token: 0x04001073 RID: 4211
	[FieldOffset(Offset = "0x27C")]
	[Token(Token = "0x4001073")]
	private float moveTimer;

	// Token: 0x04001074 RID: 4212
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4001074")]
	private readonly float speed;

	// Token: 0x04001075 RID: 4213
	[FieldOffset(Offset = "0x284")]
	[Token(Token = "0x4001075")]
	private bool alternateDirection;
}
