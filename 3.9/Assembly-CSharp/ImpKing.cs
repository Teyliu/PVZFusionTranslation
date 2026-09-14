using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006B6 RID: 1718
[Token(Token = "0x20006B6")]
public class ImpKing : ImpZombie
{
	// Token: 0x060020F2 RID: 8434 RVA: 0x000AE19C File Offset: 0x000AC39C
	[Token(Token = "0x60020F2")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "71")]
	public override void BeSmall(float scale = 0.5f)
	{
	}

	// Token: 0x060020F3 RID: 8435 RVA: 0x000AE1AC File Offset: 0x000AC3AC
	[Token(Token = "0x60020F3")]
	[Address(RVA = "0x5A9020", Offset = "0x5A7620", VA = "0x1805A9020", Slot = "26")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x060020F4 RID: 8436 RVA: 0x000AE1BC File Offset: 0x000AC3BC
	[Token(Token = "0x60020F4")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x060020F5 RID: 8437 RVA: 0x000AE1CC File Offset: 0x000AC3CC
	[Token(Token = "0x60020F5")]
	[Address(RVA = "0x5B3C40", Offset = "0x5B2240", VA = "0x1805B3C40", Slot = "33")]
	public override long GetDamage(long theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		int num;
		bool flag;
		ulong num2;
		do
		{
			num = 0;
			HashSet<ZombieType> leaderZombies = TypeMgr.LeaderZombies;
		}
		while ((flag && !base.CheckExist((ZombieType)num)) || num2 != (ulong)0L);
		throw new NullReferenceException();
	}

	// Token: 0x060020F6 RID: 8438 RVA: 0x000AE204 File Offset: 0x000AC404
	[Token(Token = "0x60020F6")]
	[Address(RVA = "0x5B3F40", Offset = "0x5B2540", VA = "0x1805B3F40", Slot = "20")]
	protected override void OverRangeDie()
	{
		Transform axis = this.axis;
		List<int> list = new List();
		Board board = this.board;
		int num = 0;
		int num2 = 0;
		if (num < board.rowNum)
		{
			BoxType[] roadType = this.board.roadType;
			Board board2 = this.board;
			num2++;
			uint num3;
			num3 += (uint)4;
		}
		int num4 = list._size;
		int num5 = 0;
		CreateZombie instance = CreateZombie.Instance;
		num4 = global::UnityEngine.Random.Range(num5, num4);
		num4 = list[num4];
		int num6 = 0;
		Zombie zombie;
		if (zombie != num6)
		{
			Board board3 = this.board;
			Zombie component = zombie.GetComponent<Zombie>();
			board3.SetHealthInTravel(component);
		}
		uint num7;
		base.Die((int)num7);
		Transform axis2 = this.axis;
		float deadLeft = this.deadLeft;
		uint num8;
		base.Die((int)num8);
	}

	// Token: 0x060020F7 RID: 8439 RVA: 0x000AE2D4 File Offset: 0x000AC4D4
	[Token(Token = "0x60020F7")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x060020F8 RID: 8440 RVA: 0x000AE2E4 File Offset: 0x000AC4E4
	[Token(Token = "0x60020F8")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = false)
	{
	}

	// Token: 0x060020F9 RID: 8441 RVA: 0x000AE2F4 File Offset: 0x000AC4F4
	[Token(Token = "0x60020F9")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x060020FA RID: 8442 RVA: 0x000AE304 File Offset: 0x000AC504
	[Token(Token = "0x60020FA")]
	[Address(RVA = "0x5B3E40", Offset = "0x5B2440", VA = "0x1805B3E40", Slot = "76")]
	protected override void Land()
	{
		int num = 0;
		base.ChangeStatus((ZombieStatus)num);
		Rigidbody2D rb = this.rb;
		this.towards = (Towards)((ulong)1L);
		Transform transform = base.transform;
		float num2 = this.theOriginSpeed * 3f;
		this.theOriginSpeed = num2;
	}

	// Token: 0x060020FB RID: 8443 RVA: 0x000AE350 File Offset: 0x000AC550
	[Token(Token = "0x60020FB")]
	[Address(RVA = "0x5B41F0", Offset = "0x5B27F0", VA = "0x1805B41F0")]
	public ImpKing()
	{
		this.Vy = 1f;
		base..ctor();
	}
}
