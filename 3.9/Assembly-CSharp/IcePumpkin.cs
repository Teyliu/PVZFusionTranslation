using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003CA RID: 970
[Token(Token = "0x20003CA")]
public class IcePumpkin : Pumpkin
{
	// Token: 0x060011C3 RID: 4547 RVA: 0x000644E8 File Offset: 0x000626E8
	[Token(Token = "0x60011C3")]
	[Address(RVA = "0x495940", Offset = "0x493F40", VA = "0x180495940", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountdown = 5f;
	}

	// Token: 0x060011C4 RID: 4548 RVA: 0x00064508 File Offset: 0x00062708
	[Token(Token = "0x60011C4")]
	[Address(RVA = "0x4958F0", Offset = "0x493EF0", VA = "0x1804958F0", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		this.attributeCountdown = 5f;
	}

	// Token: 0x060011C5 RID: 4549 RVA: 0x00064528 File Offset: 0x00062728
	[Token(Token = "0x60011C5")]
	[Address(RVA = "0x495C20", Offset = "0x494220", VA = "0x180495C20", Slot = "28")]
	protected override void ReplaceSprite()
	{
		base.ReplaceSprite();
	}

	// Token: 0x060011C6 RID: 4550 RVA: 0x0006453C File Offset: 0x0006273C
	[Token(Token = "0x60011C6")]
	[Address(RVA = "0x495BB0", Offset = "0x4941B0", VA = "0x180495BB0", Slot = "63")]
	public override bool OnEat(Zombie zombie)
	{
		int num = 0;
		int num2 = 0;
		zombie.SetCold(4f, num2, num != 0);
		int num3 = 0;
		zombie.AddfreezeLevel(5, num3);
		return base.OnEat(zombie);
	}

	// Token: 0x060011C7 RID: 4551 RVA: 0x00064574 File Offset: 0x00062774
	[Token(Token = "0x60011C7")]
	[Address(RVA = "0x495C60", Offset = "0x494260", VA = "0x180495C60")]
	public bool StoragedCool(Vector2 pos)
	{
		int num = 0;
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		Vector3 vector2;
		float z2 = vector2.z;
		Transform axis2 = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		Vector3 vector3;
		float z3 = vector3.z;
		int thePlantRow = this.thePlantRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)85), num, thePlantRow, num3 != 0UL, (float)num2);
		base.UpdateText();
		return true;
	}

	// Token: 0x060011C8 RID: 4552 RVA: 0x000645E0 File Offset: 0x000627E0
	[Token(Token = "0x60011C8")]
	[Address(RVA = "0x495960", Offset = "0x493F60", VA = "0x180495960", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x060011C9 RID: 4553 RVA: 0x00064600 File Offset: 0x00062800
	[Token(Token = "0x60011C9")]
	[Address(RVA = "0x495A30", Offset = "0x494030", VA = "0x180495A30", Slot = "61")]
	public override bool OnClicked(Mouse mouse)
	{
		int num = 0;
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction = board.boardAction;
		Vector3 vector;
		float z = vector.z;
		IcePumpkin.blocked = num != 0;
		base.UpdateText();
		return true;
	}

	// Token: 0x060011CA RID: 4554 RVA: 0x00064648 File Offset: 0x00062848
	[Token(Token = "0x60011CA")]
	[Address(RVA = "0x472EF0", Offset = "0x4714F0", VA = "0x180472EF0")]
	public IcePumpkin()
	{
	}

	// Token: 0x04000C22 RID: 3106
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C22")]
	public GameObject back;

	// Token: 0x04000C23 RID: 3107
	[Token(Token = "0x4000C23")]
	private static bool blocked;
}
