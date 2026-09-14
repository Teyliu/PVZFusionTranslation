using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006C8 RID: 1736
[Token(Token = "0x20006C8")]
public class Jackson_c : Jackson_b
{
	// Token: 0x06002190 RID: 8592 RVA: 0x000B0C48 File Offset: 0x000AEE48
	[Token(Token = "0x6002190")]
	[Address(RVA = "0x5BB870", Offset = "0x5B9E70", VA = "0x1805BB870", Slot = "10")]
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

	// Token: 0x06002191 RID: 8593 RVA: 0x000B0CB0 File Offset: 0x000AEEB0
	[Token(Token = "0x6002191")]
	[Address(RVA = "0x5BB5C0", Offset = "0x5B9BC0", VA = "0x1805BB5C0", Slot = "77")]
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

	// Token: 0x06002192 RID: 8594 RVA: 0x000B0D54 File Offset: 0x000AEF54
	[Token(Token = "0x6002192")]
	[Address(RVA = "0x5BB960", Offset = "0x5B9F60", VA = "0x1805BB960", Slot = "76")]
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

	// Token: 0x06002193 RID: 8595 RVA: 0x000B0DE4 File Offset: 0x000AEFE4
	[Token(Token = "0x6002193")]
	[Address(RVA = "0x5BB0A0", Offset = "0x5B96A0", VA = "0x1805BB0A0")]
	public Jackson_c()
	{
		Zombie[] array = new Zombie[4];
		this.zombies = array;
		base..ctor();
	}
}
