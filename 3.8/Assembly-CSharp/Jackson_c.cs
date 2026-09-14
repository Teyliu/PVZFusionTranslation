using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000691 RID: 1681
[Token(Token = "0x2000691")]
public class Jackson_c : Jackson_b
{
	// Token: 0x06002079 RID: 8313 RVA: 0x000AC018 File Offset: 0x000AA218
	[Token(Token = "0x6002079")]
	[Address(RVA = "0x5573D0", Offset = "0x5559D0", VA = "0x1805573D0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)32L);
		this.attributeCountDown = 3f;
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		int num2 = 0;
		ParticleSystem component = child.GetChild(num2).GetComponent<ParticleSystem>();
		this.particle = component;
		Zombie[] array = new Zombie[8];
		this.zombies = array;
		throw new NullReferenceException();
	}

	// Token: 0x0600207A RID: 8314 RVA: 0x000AC080 File Offset: 0x000AA280
	[Token(Token = "0x600207A")]
	[Address(RVA = "0x557120", Offset = "0x555720", VA = "0x180557120", Slot = "75")]
	protected override void AnimSummon()
	{
		Board board = this.board;
		GameAPP.PlaySound(69, 0.5f, 1f);
		int num = 0;
		base.ChangeStatus((ZombieStatus)num);
		Transform axis = this.axis;
		int num2 = this.theZombieRow;
		num2++;
		Transform axis2 = this.axis;
		Transform axis3 = this.axis;
		int num3 = this.theZombieRow;
		num3++;
		Transform axis4 = this.axis;
		Transform axis5 = this.axis;
		Transform axis6 = this.axis;
		int num4 = this.theZombieRow;
		num4++;
		Transform axis7 = this.axis;
		Transform axis8 = this.axis;
	}

	// Token: 0x0600207B RID: 8315 RVA: 0x000AC124 File Offset: 0x000AA324
	[Token(Token = "0x600207B")]
	[Address(RVA = "0x5574C0", Offset = "0x555AC0", VA = "0x1805574C0", Slot = "74")]
	protected override void CheckLose()
	{
		Transform axis = this.axis;
		int num = this.theZombieRow;
		num++;
		Transform axis2 = this.axis;
		Transform axis3 = this.axis;
		int num2 = this.theZombieRow;
		num2++;
		Transform axis4 = this.axis;
		Transform axis5 = this.axis;
		Transform axis6 = this.axis;
		int num3 = this.theZombieRow;
		num3++;
		Transform axis7 = this.axis;
		Transform axis8 = this.axis;
		bool flag;
		this.anim.SetBool("loseDancer", flag);
	}

	// Token: 0x0600207C RID: 8316 RVA: 0x000AC1B4 File Offset: 0x000AA3B4
	[Token(Token = "0x600207C")]
	[Address(RVA = "0x556C00", Offset = "0x555200", VA = "0x180556C00")]
	public Jackson_c()
	{
		Zombie[] array = new Zombie[4];
		this.zombies = array;
		base..ctor();
	}
}
