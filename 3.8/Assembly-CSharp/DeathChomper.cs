using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000372 RID: 882
[Token(Token = "0x2000372")]
public class DeathChomper : Plant
{
	// Token: 0x06001034 RID: 4148 RVA: 0x0005D318 File Offset: 0x0005B518
	[Token(Token = "0x6001034")]
	[Address(RVA = "0x42EF90", Offset = "0x42D590", VA = "0x18042EF90", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		Animator anim = this.anim;
		this.theStatus = (PlantStatus)((ulong)22L);
		anim.Play("rest");
		base.AttributeCountdown = 15f;
	}

	// Token: 0x06001035 RID: 4149 RVA: 0x0005D358 File Offset: 0x0005B558
	[Token(Token = "0x6001035")]
	[Address(RVA = "0x42EC10", Offset = "0x42D210", VA = "0x18042EC10", Slot = "40")]
	protected override void AttributeEvent()
	{
		Animator anim = this.anim;
		this.theStatus = (PlantStatus)((ulong)0L);
		anim.SetTrigger("recover");
	}

	// Token: 0x06001036 RID: 4150 RVA: 0x0005D388 File Offset: 0x0005B588
	[Token(Token = "0x6001036")]
	[Address(RVA = "0x42EC70", Offset = "0x42D270", VA = "0x18042EC70")]
	public void Bite()
	{
		Animator anim = this.anim;
		this.theStatus = (PlantStatus)((ulong)22L);
		anim.SetTrigger("bite");
		base.AttributeCountdown = 1f;
	}

	// Token: 0x06001037 RID: 4151 RVA: 0x0005D3C4 File Offset: 0x0005B5C4
	[Token(Token = "0x6001037")]
	[Address(RVA = "0x42E9F0", Offset = "0x42CFF0", VA = "0x18042E9F0")]
	private void AnimBite()
	{
		GameAPP.PlaySound(49, 0.5f, 1f);
		int num = this.thePlantColumn;
		int thePlantRow = this.thePlantRow;
		num++;
		List<Plant> list = Lawnf.Get1x1Plants(num, thePlantRow);
		Predicate<Plant> predicate;
		int num2 = list.RemoveAll(predicate);
		DeathChomper.KillPlants(list);
		base.AttributeCountdown = 30f;
		int columnNum = this.board.columnNum;
		int num3 = 0;
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int num4 = this.thePlantColumn;
		num4++;
		int attackDamage = this.attackDamage;
		BoardAction boardAction2 = this.board.boardAction;
		PlantType thePlantType2 = this.thePlantType;
		int num5 = 0;
		int attackDamage2 = this.attackDamage;
		int thePlantRow2 = this.thePlantRow;
		ulong num6;
		boardAction2.CreateFireLine(thePlantRow2, attackDamage2, num5 != 0, num3 != 0, num6 != 0UL, num3, thePlantType2);
		Transform shoot = this.shoot;
	}

	// Token: 0x06001038 RID: 4152 RVA: 0x0005D4A0 File Offset: 0x0005B6A0
	[Token(Token = "0x6001038")]
	[Address(RVA = "0x42ECE0", Offset = "0x42D2E0", VA = "0x18042ECE0")]
	private static void KillPlant(Plant plant)
	{
		int num = 0;
		plant.Die((Plant.DieReason)num);
		if (global::UnityEngine.Random.Range(0, 2) == 0 || plant.HasBuff((EffectType)((uint)103)) || Lawnf.TravelAdvanced((AdvBuff)((uint)28)))
		{
			Transform axis = plant.axis;
			return;
		}
	}

	// Token: 0x06001039 RID: 4153 RVA: 0x0005D4E8 File Offset: 0x0005B6E8
	[Token(Token = "0x6001039")]
	[Address(RVA = "0x42EDA0", Offset = "0x42D3A0", VA = "0x18042EDA0")]
	public static void KillPlants(List<Plant> plants)
	{
		bool flag;
		bool flag2;
		ulong num;
		while ((flag && global::UnityEngine.Random.Range(0, 2) != 0 && !flag2 && !Lawnf.TravelAdvanced((AdvBuff)((uint)28))) || num != (ulong)0L)
		{
		}
	}

	// Token: 0x0600103A RID: 4154 RVA: 0x0005D52C File Offset: 0x0005B72C
	[Token(Token = "0x600103A")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public DeathChomper()
	{
	}
}
