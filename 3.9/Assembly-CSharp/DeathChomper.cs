using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000382 RID: 898
[Token(Token = "0x2000382")]
public class DeathChomper : Plant
{
	// Token: 0x06001080 RID: 4224 RVA: 0x0005E2AC File Offset: 0x0005C4AC
	[Token(Token = "0x6001080")]
	[Address(RVA = "0x47F750", Offset = "0x47DD50", VA = "0x18047F750", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		Animator anim = this.anim;
		this.theStatus = (PlantStatus)((ulong)22L);
		anim.Play("rest");
		base.AttributeCountdown = 15f;
	}

	// Token: 0x06001081 RID: 4225 RVA: 0x0005E2EC File Offset: 0x0005C4EC
	[Token(Token = "0x6001081")]
	[Address(RVA = "0x47F3D0", Offset = "0x47D9D0", VA = "0x18047F3D0", Slot = "39")]
	protected override void AttributeEvent()
	{
		Animator anim = this.anim;
		this.theStatus = (PlantStatus)((ulong)0L);
		anim.SetTrigger("recover");
	}

	// Token: 0x06001082 RID: 4226 RVA: 0x0005E31C File Offset: 0x0005C51C
	[Token(Token = "0x6001082")]
	[Address(RVA = "0x47F430", Offset = "0x47DA30", VA = "0x18047F430")]
	public void Bite()
	{
		Animator anim = this.anim;
		this.theStatus = (PlantStatus)((ulong)22L);
		anim.SetTrigger("bite");
		base.AttributeCountdown = 1f;
	}

	// Token: 0x06001083 RID: 4227 RVA: 0x0005E358 File Offset: 0x0005C558
	[Token(Token = "0x6001083")]
	[Address(RVA = "0x47F1B0", Offset = "0x47D7B0", VA = "0x18047F1B0")]
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

	// Token: 0x06001084 RID: 4228 RVA: 0x0005E434 File Offset: 0x0005C634
	[Token(Token = "0x6001084")]
	[Address(RVA = "0x47F4A0", Offset = "0x47DAA0", VA = "0x18047F4A0")]
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

	// Token: 0x06001085 RID: 4229 RVA: 0x0005E47C File Offset: 0x0005C67C
	[Token(Token = "0x6001085")]
	[Address(RVA = "0x47F560", Offset = "0x47DB60", VA = "0x18047F560")]
	public static void KillPlants(List<Plant> plants)
	{
		bool flag;
		bool flag2;
		ulong num;
		while ((flag && global::UnityEngine.Random.Range(0, 2) != 0 && !flag2 && !Lawnf.TravelAdvanced((AdvBuff)((uint)28))) || num != (ulong)0L)
		{
		}
	}

	// Token: 0x06001086 RID: 4230 RVA: 0x0005E4C0 File Offset: 0x0005C6C0
	[Token(Token = "0x6001086")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public DeathChomper()
	{
	}
}
