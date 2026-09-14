using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003D6 RID: 982
[Token(Token = "0x20003D6")]
public class JalaMine : Plant
{
	// Token: 0x060011EE RID: 4590 RVA: 0x00064DD8 File Offset: 0x00062FD8
	[Token(Token = "0x60011EE")]
	[Address(RVA = "0x497380", Offset = "0x495980", VA = "0x180497380", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Transform axis = this.axis;
		int num = 0;
		Vector3 vector;
		float z = vector.z;
		PlantType thePlantType = this.thePlantType;
		Transform axis2 = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
		ScreenShake.TriggerShake(0.15f);
		int num3 = this.board.columnNum;
		num3 += num3;
		CreatePlant instance2 = CreatePlant.Instance;
		int num4 = this.thePlantColumn;
		uint num5;
		num4 += (int)num5;
		num++;
		uint num6;
		num6 -= num5;
		int num7 = 0;
		Plant plant;
		if (plant != num7 && plant != 0)
		{
			plant.AttributeCountdown = 5f;
		}
	}

	// Token: 0x060011EF RID: 4591 RVA: 0x00064E8C File Offset: 0x0006308C
	[Token(Token = "0x60011EF")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public JalaMine()
	{
	}
}
