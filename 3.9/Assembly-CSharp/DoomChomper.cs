using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000389 RID: 905
[Token(Token = "0x2000389")]
public class DoomChomper : Chomper
{
	// Token: 0x0600109E RID: 4254 RVA: 0x0005ED0C File Offset: 0x0005CF0C
	[Token(Token = "0x600109E")]
	[Address(RVA = "0x481490", Offset = "0x47FA90", VA = "0x180481490", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.swallowMaxCountDown = 60f;
	}

	// Token: 0x0600109F RID: 4255 RVA: 0x0005ED2C File Offset: 0x0005CF2C
	[Token(Token = "0x600109F")]
	[Address(RVA = "0x4814B0", Offset = "0x47FAB0", VA = "0x1804814B0", Slot = "73")]
	public override void BiteEvent()
	{
		Zombie targetZombie = this.targetZombie;
		int num = 0;
		if (targetZombie != num)
		{
			int theZombieType = (int)this.targetZombie.theZombieType;
			Zombie targetZombie2 = this.targetZombie;
			bool flag;
			if (!flag)
			{
				if (targetZombie2.theStatus <= ZombieStatus.Pol_run || targetZombie2.isMindControlled || targetZombie2.beforeDying)
				{
					goto IL_0069;
				}
				this.Chomp(targetZombie2);
			}
			PlantType thePlantType = this.thePlantType;
			ulong num2;
			targetZombie2.TakeDamage(40, this, (DamageType)((uint)4), thePlantType, num2 != 0UL);
		}
		IL_0069:
		base.ChompBack();
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)12004)))
		{
			DoomChomper.<Explode>d__3 <Explode>d__;
			<Explode>d__.System.IDisposable.Dispose();
			<Explode>d__.<>1__state = (int)((ulong)0L);
			<Explode>d__.<>4__this = this;
			Coroutine coroutine = base.StartCoroutine(<Explode>d__);
		}
	}

	// Token: 0x060010A0 RID: 4256 RVA: 0x0005EDE0 File Offset: 0x0005CFE0
	[Token(Token = "0x60010A0")]
	[Address(RVA = "0x481670", Offset = "0x47FC70", VA = "0x180481670", Slot = "74")]
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

	// Token: 0x060010A1 RID: 4257 RVA: 0x0005EE90 File Offset: 0x0005D090
	[Token(Token = "0x60010A1")]
	[Address(RVA = "0x481840", Offset = "0x47FE40", VA = "0x180481840")]
	private IEnumerator Explode()
	{
		DoomChomper.<Explode>d__3 <Explode>d__;
		<Explode>d__.System.IDisposable.Dispose();
		<Explode>d__.<>1__state = (int)((ulong)0L);
		<Explode>d__.<>4__this = this;
		return null;
	}

	// Token: 0x060010A2 RID: 4258 RVA: 0x0005EEB4 File Offset: 0x0005D0B4
	[Token(Token = "0x60010A2")]
	[Address(RVA = "0x4717B0", Offset = "0x46FDB0", VA = "0x1804717B0")]
	public DoomChomper()
	{
		this.swallowMaxCountDown = 40f;
		this.<ChompRange>k__BackingField = 2f;
		base..ctor();
	}
}
