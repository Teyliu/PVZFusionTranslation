using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003D2 RID: 978
[Token(Token = "0x20003D2")]
public class Imitater : Present
{
	// Token: 0x060011E2 RID: 4578 RVA: 0x00064BA0 File Offset: 0x00062DA0
	[Token(Token = "0x60011E2")]
	[Address(RVA = "0x4812D0", Offset = "0x47F8D0", VA = "0x1804812D0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x060011E3 RID: 4579 RVA: 0x00064BC0 File Offset: 0x00062DC0
	[Token(Token = "0x60011E3")]
	[Address(RVA = "0x497310", Offset = "0x495910", VA = "0x180497310", Slot = "56")]
	protected override bool OnStarUp()
	{
		Board board = this.board;
		bool flag;
		return flag;
	}

	// Token: 0x060011E4 RID: 4580 RVA: 0x00064BE0 File Offset: 0x00062DE0
	[Token(Token = "0x60011E4")]
	[Address(RVA = "0x496CE0", Offset = "0x4952E0", VA = "0x180496CE0")]
	private void AnimExplode()
	{
		int num2;
		do
		{
			int num = 0;
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			num2 = 0;
			PlantType thePlantType = this.thePlantType;
			GridSystem gridSystem = this.board.gridSystem;
			int thePlantRow = this.thePlantRow;
			int thePlantColumn = this.thePlantColumn;
			List<Plant> plants = gridSystem.GetGrid(thePlantColumn, thePlantRow).plants;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3) || TypeMgr.RedPlant.Contains(num3))
				{
					continue;
				}
				Board board = this.board;
			}
		}
		while (num2 != 0);
		Action<Plant> action;
		if (Imitater.<>c.<>9__3_0 == 0)
		{
			Imitater.<>c.<>9__3_0 = action;
		}
		DroppedCard droppedCard;
		droppedCard.plantAction = action;
		Camera main = Camera.main;
		Transform transform = droppedCard.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		Vector3 vector3;
		float z3 = vector3.z;
		Camera main2 = Camera.main;
		Vector3 vector4;
		float z4 = vector4.z;
		Transform transform2 = droppedCard.transform;
	}

	// Token: 0x060011E5 RID: 4581 RVA: 0x00064CE0 File Offset: 0x00062EE0
	[Token(Token = "0x60011E5")]
	[Address(RVA = "0x4972B0", Offset = "0x4958B0", VA = "0x1804972B0", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		this.anim.SetTrigger("explode");
	}

	// Token: 0x060011E6 RID: 4582 RVA: 0x00064D0C File Offset: 0x00062F0C
	[Token(Token = "0x60011E6")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public Imitater()
	{
	}

	// Token: 0x04000C28 RID: 3112
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000C28")]
	public bool star;
}
