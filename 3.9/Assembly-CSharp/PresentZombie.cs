using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000423 RID: 1059
[Token(Token = "0x2000423")]
public class PresentZombie : Plant
{
	// Token: 0x06001385 RID: 4997 RVA: 0x0006D418 File Offset: 0x0006B618
	[Token(Token = "0x6001385")]
	[Address(RVA = "0x4B4A00", Offset = "0x4B3000", VA = "0x1804B4A00", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("idle");
		if (Lawnf.TravelUltimate((UltiBuff)((uint)29)) && global::UnityEngine.Random.Range(0, 10) == 0)
		{
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
		}
	}

	// Token: 0x06001386 RID: 4998 RVA: 0x0006D468 File Offset: 0x0006B668
	[Token(Token = "0x6001386")]
	[Address(RVA = "0x4B4730", Offset = "0x4B2D30", VA = "0x1804B4730")]
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

	// Token: 0x06001387 RID: 4999 RVA: 0x0006D520 File Offset: 0x0006B720
	[Token(Token = "0x6001387")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public PresentZombie()
	{
	}
}
