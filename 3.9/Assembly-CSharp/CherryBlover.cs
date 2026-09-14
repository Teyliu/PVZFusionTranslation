using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200036F RID: 879
[Token(Token = "0x200036F")]
public class CherryBlover : Plant
{
	// Token: 0x06001016 RID: 4118 RVA: 0x0005C354 File Offset: 0x0005A554
	[Token(Token = "0x6001016")]
	[Address(RVA = "0x478930", Offset = "0x476F30", VA = "0x180478930", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		this.head = child;
		Transform transform2 = this.head;
		Vector3 vector;
		float z = vector.z;
		this.headOriginalPosition.z = z;
	}

	// Token: 0x06001017 RID: 4119 RVA: 0x0005C3A4 File Offset: 0x0005A5A4
	[Token(Token = "0x6001017")]
	[Address(RVA = "0x478AE0", Offset = "0x4770E0", VA = "0x180478AE0", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (base.Active)
		{
			Zombie targetZombie = this.targetZombie;
			int num = 0;
			bool flag = targetZombie == num;
			if (flag && !flag)
			{
				Transform axis = this.axis;
				int num2 = 0;
				int num3 = this.zombieLayer;
				Collider2D[] array;
				if (num2 < array.Length)
				{
					bool flag2;
					if (flag2 && Lawnf.InLandStatus((ZombieStatus)num2))
					{
						this.targetZombie = num2;
					}
					num2++;
				}
			}
		}
	}

	// Token: 0x06001018 RID: 4120 RVA: 0x0005C420 File Offset: 0x0005A620
	[Token(Token = "0x6001018")]
	[Address(RVA = "0x479320", Offset = "0x477920", VA = "0x180479320", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		this.MoveUpdate();
	}

	// Token: 0x06001019 RID: 4121 RVA: 0x0005C43C File Offset: 0x0005A63C
	[Token(Token = "0x6001019")]
	[Address(RVA = "0x478D30", Offset = "0x477330", VA = "0x180478D30")]
	private void MoveUpdate()
	{
		Zombie targetZombie = this.targetZombie;
		int num = 0;
		if (!(targetZombie != num))
		{
			Transform transform = this.head;
			Transform transform2 = this.head;
			float deltaTime = Time.deltaTime;
			Transform transform3 = this.head;
			Vector3 position = transform2.position;
			Transform transform4 = this.head;
			float z = this.headOriginalPosition.z;
			return;
		}
		Zombie targetZombie2 = this.targetZombie;
		if (!targetZombie2.isMindControlled && !targetZombie2.beforeDying)
		{
			int theZombieRow = targetZombie2.theZombieRow;
			if (Lawnf.InLandStatus(targetZombie2.theStatus))
			{
				Collider2D col = this.targetZombie.col;
				int num2 = 0;
				if (col != num2)
				{
					Collider2D col2 = this.targetZombie.col;
					if (col2.enabled)
					{
						Collider2D col3 = this.targetZombie.col;
						Bounds bounds = col2.bounds;
						Transform transform5 = this.head;
						Transform transform6 = this.head;
						float deltaTime2 = Time.deltaTime;
						Transform transform7 = this.head;
						Vector3 position2 = transform6.position;
						Zombie targetZombie3 = this.targetZombie;
						Board board = this.board;
						Transform transform8 = this.head;
						BoardAction boardAction = board.boardAction;
						Vector3 position3 = transform6.position;
						PlantType thePlantType = this.thePlantType;
						int attackDamage = this.attackDamage;
						base.AttributeCountdown = 15f;
					}
				}
			}
		}
		int num3 = 0;
		this.targetZombie = num3;
		throw new NullReferenceException();
	}

	// Token: 0x0600101A RID: 4122 RVA: 0x0005C5AC File Offset: 0x0005A7AC
	[Token(Token = "0x600101A")]
	[Address(RVA = "0x478A40", Offset = "0x477040", VA = "0x180478A40")]
	private void Explode(int row)
	{
		Board board = this.board;
		Transform transform = this.head;
		BoardAction boardAction = board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int attackDamage = this.attackDamage;
	}

	// Token: 0x0600101B RID: 4123 RVA: 0x0005C5E8 File Offset: 0x0005A7E8
	[Token(Token = "0x600101B")]
	[Address(RVA = "0x4792E0", Offset = "0x4778E0", VA = "0x1804792E0", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		base..ctor();
		this.targetZombie = (ulong)0L;
	}

	// Token: 0x0600101C RID: 4124 RVA: 0x0005C604 File Offset: 0x0005A804
	[Token(Token = "0x600101C")]
	[Address(RVA = "0x478780", Offset = "0x476D80", VA = "0x180478780")]
	private void AttackUpdate()
	{
		Transform axis = this.axis;
		int num = 0;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			bool flag2;
			if (flag && flag2)
			{
				this.targetZombie = num;
			}
			num++;
		}
	}

	// Token: 0x0600101D RID: 4125 RVA: 0x0005C64C File Offset: 0x0005A84C
	[Token(Token = "0x600101D")]
	[Address(RVA = "0x4789B0", Offset = "0x476FB0", VA = "0x1804789B0")]
	private bool CheckZombie(Zombie zombie)
	{
		if (!zombie.isMindControlled && !zombie.beforeDying)
		{
			int theZombieRow = zombie.theZombieRow;
			return Lawnf.InLandStatus(zombie.theStatus);
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600101E RID: 4126 RVA: 0x0005C688 File Offset: 0x0005A888
	[Token(Token = "0x600101E")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public CherryBlover()
	{
	}

	// Token: 0x04000BA9 RID: 2985
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000BA9")]
	private Transform head;

	// Token: 0x04000BAA RID: 2986
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000BAA")]
	private Vector3 headOriginalPosition;
}
