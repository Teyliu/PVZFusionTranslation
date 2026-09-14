using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003C2 RID: 962
[Token(Token = "0x20003C2")]
public class JalaMine : Plant
{
	// Token: 0x06001192 RID: 4498 RVA: 0x000637B8 File Offset: 0x000619B8
	[Token(Token = "0x6001192")]
	[Address(RVA = "0x445420", Offset = "0x443A20", VA = "0x180445420", Slot = "52")]
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

	// Token: 0x06001193 RID: 4499 RVA: 0x0006386C File Offset: 0x00061A6C
	[Token(Token = "0x6001193")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public JalaMine()
	{
	}
}
