using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200039F RID: 927
[Token(Token = "0x200039F")]
public class FrozenPear : Plant
{
	// Token: 0x06001108 RID: 4360 RVA: 0x00060D48 File Offset: 0x0005EF48
	[Token(Token = "0x6001108")]
	[Address(RVA = "0x4812D0", Offset = "0x47F8D0", VA = "0x1804812D0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x06001109 RID: 4361 RVA: 0x00060D68 File Offset: 0x0005EF68
	[Token(Token = "0x6001109")]
	[Address(RVA = "0x4898E0", Offset = "0x487EE0", VA = "0x1804898E0", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x0600110A RID: 4362 RVA: 0x00060DAC File Offset: 0x0005EFAC
	[Token(Token = "0x600110A")]
	[Address(RVA = "0x489A30", Offset = "0x488030", VA = "0x180489A30", Slot = "28")]
	protected override void ReplaceSprite()
	{
		int thePlantMaxHealth = this.thePlantMaxHealth;
		ulong num;
		this.changeSprite.GetComponent<SpriteRenderer>().enabled = num != 0UL;
		Transform transform = this.changeSprite.transform;
		int num2 = 0;
		GameObject gameObject = transform.GetChild(num2).gameObject;
		int num3 = 0;
		gameObject.SetActive(num3 != 0);
	}

	// Token: 0x0600110B RID: 4363 RVA: 0x00060E3C File Offset: 0x0005F03C
	[Token(Token = "0x600110B")]
	[Address(RVA = "0x489990", Offset = "0x487F90", VA = "0x180489990")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int thePlantRow = this.thePlantRow;
			this.theStatus = (PlantStatus)((ulong)24L);
		}
	}

	// Token: 0x0600110C RID: 4364 RVA: 0x00060E68 File Offset: 0x0005F068
	[Token(Token = "0x600110C")]
	[Address(RVA = "0x489970", Offset = "0x487F70", VA = "0x180489970", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		this.theStatus = (PlantStatus)((ulong)0L);
	}

	// Token: 0x0600110D RID: 4365 RVA: 0x00060E84 File Offset: 0x0005F084
	[Token(Token = "0x600110D")]
	[Address(RVA = "0x489790", Offset = "0x487D90", VA = "0x180489790")]
	private void AnimShoot()
	{
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction = board.boardAction;
		int attackDamage = this.attackDamage;
		PlantType thePlantType = this.thePlantType;
	}

	// Token: 0x0600110E RID: 4366 RVA: 0x00060EC0 File Offset: 0x0005F0C0
	[Token(Token = "0x600110E")]
	[Address(RVA = "0x489730", Offset = "0x487D30", VA = "0x180489730")]
	private void Action(Zombie zombie)
	{
		int num = 0;
		int num2 = 0;
		zombie.SetCold(15f, num2, num != 0);
		int num3 = 0;
		zombie.AddfreezeLevel(35, num3);
	}

	// Token: 0x0600110F RID: 4367 RVA: 0x00060EF0 File Offset: 0x0005F0F0
	[Token(Token = "0x600110F")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public FrozenPear()
	{
	}

	// Token: 0x04000BF1 RID: 3057
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000BF1")]
	public GameObject changeSprite;
}
