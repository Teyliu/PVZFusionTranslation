using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000379 RID: 889
[Token(Token = "0x2000379")]
public class DoomChomper : Chomper
{
	// Token: 0x06001052 RID: 4178 RVA: 0x0005DD44 File Offset: 0x0005BF44
	[Token(Token = "0x6001052")]
	[Address(RVA = "0x430BA0", Offset = "0x42F1A0", VA = "0x180430BA0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.swallowMaxCountDown = 60f;
	}

	// Token: 0x06001053 RID: 4179 RVA: 0x0005DD64 File Offset: 0x0005BF64
	[Token(Token = "0x6001053")]
	[Address(RVA = "0x430BC0", Offset = "0x42F1C0", VA = "0x180430BC0", Slot = "73")]
	public override void BiteEvent()
	{
		base.BiteEvent();
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)12004)))
		{
			DoomChomper.<Explode>d__3 <Explode>d__;
			<Explode>d__.System.IDisposable.Dispose();
			<Explode>d__.<>1__state = (int)((ulong)0L);
			<Explode>d__.<>4__this = this;
			Coroutine coroutine = base.StartCoroutine(<Explode>d__);
		}
	}

	// Token: 0x06001054 RID: 4180 RVA: 0x0005DDA4 File Offset: 0x0005BFA4
	[Token(Token = "0x6001054")]
	[Address(RVA = "0x430C50", Offset = "0x42F250", VA = "0x180430C50", Slot = "74")]
	protected override void Chomp(Zombie zombie)
	{
		zombie.Die(2);
		float swallowMaxCountDown = this.swallowMaxCountDown;
		base.AttributeCountdown = swallowMaxCountDown;
		int num = 0;
		this.canToChew = true;
		this.targetZombie = num;
		this.theStatus = (PlantStatus)((ulong)22L);
		GameAPP.PlaySound(49, 0.5f, 1f);
		Board board = this.board;
		int columnNum = board.columnNum;
		BoardAction boardAction = board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int num2 = this.thePlantColumn;
		num2++;
		int attackDamage = this.attackDamage;
	}

	// Token: 0x06001055 RID: 4181 RVA: 0x0005DE54 File Offset: 0x0005C054
	[Token(Token = "0x6001055")]
	[Address(RVA = "0x430E20", Offset = "0x42F420", VA = "0x180430E20")]
	private IEnumerator Explode()
	{
		DoomChomper.<Explode>d__3 <Explode>d__;
		<Explode>d__.System.IDisposable.Dispose();
		<Explode>d__.<>1__state = (int)((ulong)0L);
		<Explode>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06001056 RID: 4182 RVA: 0x0005DE78 File Offset: 0x0005C078
	[Token(Token = "0x6001056")]
	[Address(RVA = "0x430E90", Offset = "0x42F490", VA = "0x180430E90")]
	public DoomChomper()
	{
	}
}
