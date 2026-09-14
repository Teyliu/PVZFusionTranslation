using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000680 RID: 1664
[Token(Token = "0x2000680")]
public class ImpKing : ImpZombie
{
	// Token: 0x06001FF0 RID: 8176 RVA: 0x000A988C File Offset: 0x000A7A8C
	[Token(Token = "0x6001FF0")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "69")]
	public override void BeSmall(float scale = 0.5f)
	{
	}

	// Token: 0x06001FF1 RID: 8177 RVA: 0x000A989C File Offset: 0x000A7A9C
	[Token(Token = "0x6001FF1")]
	[Address(RVA = "0x546D50", Offset = "0x545350", VA = "0x180546D50", Slot = "25")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x06001FF2 RID: 8178 RVA: 0x000A98AC File Offset: 0x000A7AAC
	[Token(Token = "0x6001FF2")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06001FF3 RID: 8179 RVA: 0x000A98BC File Offset: 0x000A7ABC
	[Token(Token = "0x6001FF3")]
	[Address(RVA = "0x5500B0", Offset = "0x54E6B0", VA = "0x1805500B0", Slot = "32")]
	public override int GetDamage(int theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
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
		int num3;
		if (num3 > 5000)
		{
		}
		return 5000;
	}

	// Token: 0x06001FF4 RID: 8180 RVA: 0x000A9900 File Offset: 0x000A7B00
	[Token(Token = "0x6001FF4")]
	[Address(RVA = "0x5503B0", Offset = "0x54E9B0", VA = "0x1805503B0", Slot = "19")]
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

	// Token: 0x06001FF5 RID: 8181 RVA: 0x000A99D0 File Offset: 0x000A7BD0
	[Token(Token = "0x6001FF5")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x06001FF6 RID: 8182 RVA: 0x000A99E0 File Offset: 0x000A7BE0
	[Token(Token = "0x6001FF6")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = false)
	{
	}

	// Token: 0x06001FF7 RID: 8183 RVA: 0x000A99F0 File Offset: 0x000A7BF0
	[Token(Token = "0x6001FF7")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06001FF8 RID: 8184 RVA: 0x000A9A00 File Offset: 0x000A7C00
	[Token(Token = "0x6001FF8")]
	[Address(RVA = "0x5502B0", Offset = "0x54E8B0", VA = "0x1805502B0", Slot = "74")]
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

	// Token: 0x06001FF9 RID: 8185 RVA: 0x000A9A4C File Offset: 0x000A7C4C
	[Token(Token = "0x6001FF9")]
	[Address(RVA = "0x550660", Offset = "0x54EC60", VA = "0x180550660")]
	public ImpKing()
	{
		this.Vy = 1f;
		base..ctor();
	}
}
