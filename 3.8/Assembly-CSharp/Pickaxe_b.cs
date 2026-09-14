using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020006B3 RID: 1715
[Token(Token = "0x20006B3")]
public class Pickaxe_b : Pickaxe_a
{
	// Token: 0x0600217C RID: 8572 RVA: 0x000B07A4 File Offset: 0x000AE9A4
	[Token(Token = "0x600217C")]
	[Address(RVA = "0x565E30", Offset = "0x564430", VA = "0x180565E30", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		SortingGroup component = this.progressText.GetComponent<SortingGroup>();
		this.textGroup = component;
		this.textGroup.sortAtRoot = true;
		GameObject gameObject = this.progressText.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
		this.theStatus = (ZombieStatus)((ulong)12L);
		int num2 = global::UnityEngine.Random.Range(2, 9);
		float digSpeed = this.digSpeed;
		this.targetColumn = num2;
		this.digSpeed = digSpeed;
	}

	// Token: 0x0600217D RID: 8573 RVA: 0x000B081C File Offset: 0x000AEA1C
	[Token(Token = "0x600217D")]
	[Address(RVA = "0x566210", Offset = "0x564810", VA = "0x180566210", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		Board board = this.board;
		int num = global::UnityEngine.Random.Range(4, 9);
		this.targetColumn = num;
	}

	// Token: 0x0600217E RID: 8574 RVA: 0x000B0850 File Offset: 0x000AEA50
	[Token(Token = "0x600217E")]
	[Address(RVA = "0x565F10", Offset = "0x564510", VA = "0x180565F10", Slot = "22")]
	protected override void OnFixedUpdate()
	{
		base.OnFixedUpdate();
	}

	// Token: 0x0600217F RID: 8575 RVA: 0x000B0864 File Offset: 0x000AEA64
	[Token(Token = "0x600217F")]
	[Address(RVA = "0x566170", Offset = "0x564770", VA = "0x180566170", Slot = "74")]
	protected virtual void RiseUpdate()
	{
		int column = base.Column;
	}

	// Token: 0x06002180 RID: 8576 RVA: 0x000B087C File Offset: 0x000AEA7C
	[Token(Token = "0x6002180")]
	[Address(RVA = "0x5661B0", Offset = "0x5647B0", VA = "0x1805661B0", Slot = "75")]
	protected virtual void Rise()
	{
		this.anim.SetTrigger("rise");
		base.ChangeStatus((ZombieStatus)((uint)13));
	}

	// Token: 0x06002181 RID: 8577 RVA: 0x000B08A8 File Offset: 0x000AEAA8
	[Token(Token = "0x6002181")]
	[Address(RVA = "0x5538B0", Offset = "0x551EB0", VA = "0x1805538B0", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return base.CanAttack(target);
	}

	// Token: 0x06002182 RID: 8578 RVA: 0x000B08C0 File Offset: 0x000AEAC0
	[Token(Token = "0x6002182")]
	[Address(RVA = "0x565F40", Offset = "0x564540", VA = "0x180565F40")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int theZombieRow;
		for (;;)
		{
			int num = 0;
			bool flag;
			if (!flag)
			{
				return;
			}
			theZombieRow = this.theZombieRow;
			if (theZombieRow > 922)
			{
				break;
			}
			if (num != 911)
			{
				while (num != 922)
				{
				}
			}
			bool flag2;
			if (flag2)
			{
				this.Rise();
			}
			ulong num2;
			if (num2 == (ulong)0L)
			{
				goto Block_5;
			}
		}
		if (theZombieRow == 925 || theZombieRow == 935 || theZombieRow == 1099)
		{
			this.Rise();
		}
		return;
		Block_5:
		throw new NullReferenceException();
	}

	// Token: 0x06002183 RID: 8579 RVA: 0x000B0938 File Offset: 0x000AEB38
	[Token(Token = "0x6002183")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10")]
	private void RiseEvent()
	{
	}

	// Token: 0x06002184 RID: 8580 RVA: 0x000B0948 File Offset: 0x000AEB48
	[Token(Token = "0x6002184")]
	[Address(RVA = "0x565DD0", Offset = "0x5643D0", VA = "0x180565DD0")]
	public Pickaxe_b()
	{
		this.digSpeed = 40f;
		base..ctor();
	}

	// Token: 0x04001111 RID: 4369
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4001111")]
	protected int targetColumn;
}
