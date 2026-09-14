using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020006EA RID: 1770
[Token(Token = "0x20006EA")]
public class Pickaxe_b : Pickaxe_a
{
	// Token: 0x06002293 RID: 8851 RVA: 0x000B5454 File Offset: 0x000B3654
	[Token(Token = "0x6002293")]
	[Address(RVA = "0x5C96E0", Offset = "0x5C7CE0", VA = "0x1805C96E0", Slot = "10")]
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

	// Token: 0x06002294 RID: 8852 RVA: 0x000B54CC File Offset: 0x000B36CC
	[Token(Token = "0x6002294")]
	[Address(RVA = "0x5C9AC0", Offset = "0x5C80C0", VA = "0x1805C9AC0", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		Board board = this.board;
		int num = global::UnityEngine.Random.Range(4, 9);
		this.targetColumn = num;
	}

	// Token: 0x06002295 RID: 8853 RVA: 0x000B5500 File Offset: 0x000B3700
	[Token(Token = "0x6002295")]
	[Address(RVA = "0x5C97C0", Offset = "0x5C7DC0", VA = "0x1805C97C0", Slot = "23")]
	protected override void OnFixedUpdate()
	{
		base.OnFixedUpdate();
	}

	// Token: 0x06002296 RID: 8854 RVA: 0x000B5514 File Offset: 0x000B3714
	[Token(Token = "0x6002296")]
	[Address(RVA = "0x5C9A20", Offset = "0x5C8020", VA = "0x1805C9A20", Slot = "76")]
	protected virtual void RiseUpdate()
	{
		int column = base.Column;
	}

	// Token: 0x06002297 RID: 8855 RVA: 0x000B552C File Offset: 0x000B372C
	[Token(Token = "0x6002297")]
	[Address(RVA = "0x5C9A60", Offset = "0x5C8060", VA = "0x1805C9A60", Slot = "77")]
	protected virtual void Rise()
	{
		this.anim.SetTrigger("rise");
		base.ChangeStatus((ZombieStatus)((uint)13));
	}

	// Token: 0x06002298 RID: 8856 RVA: 0x000B5558 File Offset: 0x000B3758
	[Token(Token = "0x6002298")]
	[Address(RVA = "0x5B7450", Offset = "0x5B5A50", VA = "0x1805B7450", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return base.CanAttack(target);
	}

	// Token: 0x06002299 RID: 8857 RVA: 0x000B5570 File Offset: 0x000B3770
	[Token(Token = "0x6002299")]
	[Address(RVA = "0x5C97F0", Offset = "0x5C7DF0", VA = "0x1805C97F0")]
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

	// Token: 0x0600229A RID: 8858 RVA: 0x000B55E8 File Offset: 0x000B37E8
	[Token(Token = "0x600229A")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20")]
	private void RiseEvent()
	{
	}

	// Token: 0x0600229B RID: 8859 RVA: 0x000B55F8 File Offset: 0x000B37F8
	[Token(Token = "0x600229B")]
	[Address(RVA = "0x5C9680", Offset = "0x5C7C80", VA = "0x1805C9680")]
	public Pickaxe_b()
	{
		this.digSpeed = 40f;
		base..ctor();
	}

	// Token: 0x040011DE RID: 4574
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x40011DE")]
	protected int targetColumn;
}
