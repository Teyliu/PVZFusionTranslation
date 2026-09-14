using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000408 RID: 1032
[Token(Token = "0x2000408")]
public class PresentZombie : Plant
{
	// Token: 0x0600130F RID: 4879 RVA: 0x0006B5B8 File Offset: 0x000697B8
	[Token(Token = "0x600130F")]
	[Address(RVA = "0x45E510", Offset = "0x45CB10", VA = "0x18045E510", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("idle");
	}

	// Token: 0x06001310 RID: 4880 RVA: 0x0006B5E4 File Offset: 0x000697E4
	[Token(Token = "0x6001310")]
	[Address(RVA = "0x45E240", Offset = "0x45C840", VA = "0x18045E240")]
	public void AnimEvent()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		int num = 0;
		base.Die((Plant.DieReason)num);
		GridSystem gridSystem = this.board.gridSystem;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		if (gridSystem.GetGrid(thePlantColumn, thePlantRow).boxType != BoxType.Water)
		{
			Board board = this.board;
			uint num2;
			if (global::UnityEngine.Random.Range(0, (int)num2) == 0)
			{
				Transform axis2 = this.axis;
				CreateZombie instance = CreateZombie.Instance;
				return;
			}
			Transform axis3 = this.axis;
			CreateZombie instance2 = CreateZombie.Instance;
		}
		uint num4;
		int num3 = global::UnityEngine.Random.Range(0, (int)num4);
		if (num3 == 0 || num3 == 0 || num3 == 1)
		{
		}
		Transform axis4 = this.axis;
		CreateZombie instance3 = CreateZombie.Instance;
		throw new NullReferenceException();
	}

	// Token: 0x06001311 RID: 4881 RVA: 0x0006B69C File Offset: 0x0006989C
	[Token(Token = "0x6001311")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public PresentZombie()
	{
	}
}
