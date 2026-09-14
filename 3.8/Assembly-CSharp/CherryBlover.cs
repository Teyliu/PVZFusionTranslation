using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200035F RID: 863
[Token(Token = "0x200035F")]
public class CherryBlover : Plant
{
	// Token: 0x06000FCA RID: 4042 RVA: 0x0005B394 File Offset: 0x00059594
	[Token(Token = "0x6000FCA")]
	[Address(RVA = "0x4219E0", Offset = "0x41FFE0", VA = "0x1804219E0", Slot = "10")]
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

	// Token: 0x06000FCB RID: 4043 RVA: 0x0005B3E4 File Offset: 0x000595E4
	[Token(Token = "0x6000FCB")]
	[Address(RVA = "0x421B90", Offset = "0x420190", VA = "0x180421B90", Slot = "17")]
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

	// Token: 0x06000FCC RID: 4044 RVA: 0x0005B460 File Offset: 0x00059660
	[Token(Token = "0x6000FCC")]
	[Address(RVA = "0x4223D0", Offset = "0x4209D0", VA = "0x1804223D0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		this.MoveUpdate();
	}

	// Token: 0x06000FCD RID: 4045 RVA: 0x0005B47C File Offset: 0x0005967C
	[Token(Token = "0x6000FCD")]
	[Address(RVA = "0x421DE0", Offset = "0x4203E0", VA = "0x180421DE0")]
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

	// Token: 0x06000FCE RID: 4046 RVA: 0x0005B5EC File Offset: 0x000597EC
	[Token(Token = "0x6000FCE")]
	[Address(RVA = "0x421AF0", Offset = "0x4200F0", VA = "0x180421AF0")]
	private void Explode(int row)
	{
		Board board = this.board;
		Transform transform = this.head;
		BoardAction boardAction = board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int attackDamage = this.attackDamage;
	}

	// Token: 0x06000FCF RID: 4047 RVA: 0x0005B628 File Offset: 0x00059828
	[Token(Token = "0x6000FCF")]
	[Address(RVA = "0x422390", Offset = "0x420990", VA = "0x180422390", Slot = "54")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		base.Dispose();
		this.targetZombie = (ulong)0L;
	}

	// Token: 0x06000FD0 RID: 4048 RVA: 0x0005B644 File Offset: 0x00059844
	[Token(Token = "0x6000FD0")]
	[Address(RVA = "0x421830", Offset = "0x41FE30", VA = "0x180421830")]
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

	// Token: 0x06000FD1 RID: 4049 RVA: 0x0005B68C File Offset: 0x0005988C
	[Token(Token = "0x6000FD1")]
	[Address(RVA = "0x421A60", Offset = "0x420060", VA = "0x180421A60")]
	private bool CheckZombie(Zombie zombie)
	{
		if (!zombie.isMindControlled && !zombie.beforeDying)
		{
			int theZombieRow = zombie.theZombieRow;
			return Lawnf.InLandStatus(zombie.theStatus);
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000FD2 RID: 4050 RVA: 0x0005B6C8 File Offset: 0x000598C8
	[Token(Token = "0x6000FD2")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public CherryBlover()
	{
	}

	// Token: 0x04000B58 RID: 2904
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000B58")]
	private Transform head;

	// Token: 0x04000B59 RID: 2905
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000B59")]
	private Vector3 headOriginalPosition;
}
