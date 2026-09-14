using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003BE RID: 958
[Token(Token = "0x20003BE")]
public class Imitater : Present
{
	// Token: 0x06001186 RID: 4486 RVA: 0x00063580 File Offset: 0x00061780
	[Token(Token = "0x6001186")]
	[Address(RVA = "0x4309E0", Offset = "0x42EFE0", VA = "0x1804309E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x06001187 RID: 4487 RVA: 0x000635A0 File Offset: 0x000617A0
	[Token(Token = "0x6001187")]
	[Address(RVA = "0x4453C0", Offset = "0x4439C0", VA = "0x1804453C0", Slot = "57")]
	protected override bool OnStarUp()
	{
		Board board = this.board;
		bool flag;
		return flag;
	}

	// Token: 0x06001188 RID: 4488 RVA: 0x000635C0 File Offset: 0x000617C0
	[Token(Token = "0x6001188")]
	[Address(RVA = "0x444D90", Offset = "0x443390", VA = "0x180444D90")]
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

	// Token: 0x06001189 RID: 4489 RVA: 0x000636C0 File Offset: 0x000618C0
	[Token(Token = "0x6001189")]
	[Address(RVA = "0x445360", Offset = "0x443960", VA = "0x180445360", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		this.anim.SetTrigger("explode");
	}

	// Token: 0x0600118A RID: 4490 RVA: 0x000636EC File Offset: 0x000618EC
	[Token(Token = "0x600118A")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public Imitater()
	{
	}

	// Token: 0x04000BC2 RID: 3010
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000BC2")]
	public bool star;
}
