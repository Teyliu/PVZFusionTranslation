using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003D7 RID: 983
[Token(Token = "0x20003D7")]
public class JalaPumpkin : Pumpkin
{
	// Token: 0x060011F0 RID: 4592 RVA: 0x00064EA0 File Offset: 0x000630A0
	[Token(Token = "0x60011F0")]
	[Address(RVA = "0x497AB0", Offset = "0x4960B0", VA = "0x180497AB0", Slot = "28")]
	protected override void ReplaceSprite()
	{
		base.ReplaceSprite();
		GameObject gameObject = this.fire3;
		CrackStatus crackStatus;
		this.CrackStatus = crackStatus;
		bool flag = crackStatus != CrackStatus.Bad;
		gameObject.SetActive(flag);
	}

	// Token: 0x060011F1 RID: 4593 RVA: 0x00064ED8 File Offset: 0x000630D8
	[Token(Token = "0x60011F1")]
	[Address(RVA = "0x497940", Offset = "0x495F40", VA = "0x180497940", Slot = "63")]
	public override bool OnEat(Zombie zombie)
	{
		CrackStatus crackStatus = this.CrackStatus;
		if (crackStatus == CrackStatus.Normal)
		{
		}
		if (crackStatus == CrackStatus.Bad)
		{
		}
		PlantType thePlantType = this.thePlantType;
		zombie.SetJalaed();
		throw new NullReferenceException();
	}

	// Token: 0x060011F2 RID: 4594 RVA: 0x00064F0C File Offset: 0x0006310C
	[Token(Token = "0x60011F2")]
	[Address(RVA = "0x497B30", Offset = "0x496130", VA = "0x180497B30", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)2), action, num != 0);
	}

	// Token: 0x060011F3 RID: 4595 RVA: 0x00064F2C File Offset: 0x0006312C
	[Token(Token = "0x60011F3")]
	[Address(RVA = "0x4976E0", Offset = "0x495CE0", VA = "0x1804976E0", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Action<object> action;
		EventManager.RemoveListener((GameEvent)((uint)2), action);
	}

	// Token: 0x060011F4 RID: 4596 RVA: 0x00064F44 File Offset: 0x00063144
	[Token(Token = "0x60011F4")]
	[Address(RVA = "0x497A00", Offset = "0x496000", VA = "0x180497A00")]
	private void OnZombieDeath(object obj)
	{
		bool flag;
		if (obj != 0 && flag)
		{
			int thePlantRow = this.thePlantRow;
			base.UpdateText();
		}
	}

	// Token: 0x060011F5 RID: 4597 RVA: 0x00064F68 File Offset: 0x00063168
	[Token(Token = "0x60011F5")]
	[Address(RVA = "0x4978B0", Offset = "0x495EB0", VA = "0x1804978B0", Slot = "61")]
	public override bool OnClicked(Mouse mouse)
	{
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		this.attributeCount = (int)((ulong)0L);
		base.UpdateText();
		return true;
	}

	// Token: 0x060011F6 RID: 4598 RVA: 0x00064FA0 File Offset: 0x000631A0
	[Token(Token = "0x60011F6")]
	[Address(RVA = "0x497780", Offset = "0x495D80", VA = "0x180497780", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
	}

	// Token: 0x060011F7 RID: 4599 RVA: 0x00064FB0 File Offset: 0x000631B0
	[Token(Token = "0x60011F7")]
	[Address(RVA = "0x4977A0", Offset = "0x495DA0", VA = "0x1804977A0")]
	public void EatEnergy(int value)
	{
		this.attributeCount = value;
		if (value > 1000000)
		{
			this.attributeCount = (int)((ulong)1000000L);
		}
	}

	// Token: 0x060011F8 RID: 4600 RVA: 0x00064FDC File Offset: 0x000631DC
	[Token(Token = "0x60011F8")]
	[Address(RVA = "0x4977E0", Offset = "0x495DE0", VA = "0x1804977E0", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x060011F9 RID: 4601 RVA: 0x00064FFC File Offset: 0x000631FC
	[Token(Token = "0x60011F9")]
	[Address(RVA = "0x472EF0", Offset = "0x4714F0", VA = "0x180472EF0")]
	public JalaPumpkin()
	{
	}

	// Token: 0x04000C2B RID: 3115
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C2B")]
	public GameObject fire3;

	// Token: 0x04000C2C RID: 3116
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000C2C")]
	public GameObject back;

	// Token: 0x04000C2D RID: 3117
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000C2D")]
	private CrackStatus CrackStatus;
}
