using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200038C RID: 908
[Token(Token = "0x200038C")]
public class FrozenPear : Plant
{
	// Token: 0x060010AE RID: 4270 RVA: 0x0005F7FC File Offset: 0x0005D9FC
	[Token(Token = "0x60010AE")]
	[Address(RVA = "0x4309E0", Offset = "0x42EFE0", VA = "0x1804309E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x060010AF RID: 4271 RVA: 0x0005F81C File Offset: 0x0005DA1C
	[Token(Token = "0x60010AF")]
	[Address(RVA = "0x436040", Offset = "0x434640", VA = "0x180436040", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x060010B0 RID: 4272 RVA: 0x0005F860 File Offset: 0x0005DA60
	[Token(Token = "0x60010B0")]
	[Address(RVA = "0x436190", Offset = "0x434790", VA = "0x180436190", Slot = "29")]
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

	// Token: 0x060010B1 RID: 4273 RVA: 0x0005F8F0 File Offset: 0x0005DAF0
	[Token(Token = "0x60010B1")]
	[Address(RVA = "0x4360F0", Offset = "0x4346F0", VA = "0x1804360F0")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int thePlantRow = this.thePlantRow;
			this.theStatus = (PlantStatus)((ulong)24L);
		}
	}

	// Token: 0x060010B2 RID: 4274 RVA: 0x0005F91C File Offset: 0x0005DB1C
	[Token(Token = "0x60010B2")]
	[Address(RVA = "0x4360D0", Offset = "0x4346D0", VA = "0x1804360D0", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		this.theStatus = (PlantStatus)((ulong)0L);
	}

	// Token: 0x060010B3 RID: 4275 RVA: 0x0005F938 File Offset: 0x0005DB38
	[Token(Token = "0x60010B3")]
	[Address(RVA = "0x435EF0", Offset = "0x4344F0", VA = "0x180435EF0")]
	private void AnimShoot()
	{
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction = board.boardAction;
		int attackDamage = this.attackDamage;
		PlantType thePlantType = this.thePlantType;
	}

	// Token: 0x060010B4 RID: 4276 RVA: 0x0005F974 File Offset: 0x0005DB74
	[Token(Token = "0x60010B4")]
	[Address(RVA = "0x435E90", Offset = "0x434490", VA = "0x180435E90")]
	private void Action(Zombie zombie)
	{
		int num = 0;
		int num2 = 0;
		zombie.SetCold(15f, num2, num != 0);
		int num3 = 0;
		zombie.AddfreezeLevel(35, num3);
	}

	// Token: 0x060010B5 RID: 4277 RVA: 0x0005F9A4 File Offset: 0x0005DBA4
	[Token(Token = "0x60010B5")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public FrozenPear()
	{
	}

	// Token: 0x04000B96 RID: 2966
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000B96")]
	public GameObject changeSprite;
}
