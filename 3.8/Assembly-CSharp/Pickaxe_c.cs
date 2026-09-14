using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020006B4 RID: 1716
[Token(Token = "0x20006B4")]
public class Pickaxe_c : Pickaxe_b
{
	// Token: 0x06002185 RID: 8581 RVA: 0x000B0968 File Offset: 0x000AEB68
	[Token(Token = "0x6002185")]
	[Address(RVA = "0x566610", Offset = "0x564C10", VA = "0x180566610", Slot = "10")]
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
		this.attributeCountDown = 0.03f;
		this.digSpeed = digSpeed;
	}

	// Token: 0x06002186 RID: 8582 RVA: 0x000B09EC File Offset: 0x000AEBEC
	[Token(Token = "0x6002186")]
	[Address(RVA = "0x566260", Offset = "0x564860", VA = "0x180566260", Slot = "23")]
	protected override void AttributeEvent()
	{
		ulong num;
		do
		{
			List<Zombie> allZombies = Lawnf.GetAllZombies(false);
			bool flag;
			if (flag)
			{
				int theZombieRow = this.theZombieRow;
				Transform axis = this.axis;
				bool flag2;
				while (flag2)
				{
				}
				bool flag3;
				while (flag3)
				{
				}
				bool flag4;
				while (flag4)
				{
				}
				ZombieType theZombieType = this.theZombieType;
				List<ZombieType> list = this.zombieTypes;
			}
		}
		while (num != (ulong)0L);
		ParticleManager instance = ParticleManager.Instance;
	}

	// Token: 0x06002187 RID: 8583 RVA: 0x000B0A68 File Offset: 0x000AEC68
	[Token(Token = "0x6002187")]
	[Address(RVA = "0x566730", Offset = "0x564D30", VA = "0x180566730")]
	private void RiseEvent()
	{
		int num;
		do
		{
			List<ZombieType> list = this.zombieTypes;
			num = 0;
			bool flag;
			if (flag)
			{
				CreateZombie instance = CreateZombie.Instance;
				Transform axis = this.axis;
				int num2 = 0;
				Zombie zombie;
				if (!(zombie != num2))
				{
					continue;
				}
				this.board.SetHealthInTravel(zombie);
			}
		}
		while (num != 0);
		ParticleManager instance2 = ParticleManager.Instance;
	}

	// Token: 0x06002188 RID: 8584 RVA: 0x000B0AE0 File Offset: 0x000AECE0
	[Token(Token = "0x6002188")]
	[Address(RVA = "0x566700", Offset = "0x564D00", VA = "0x180566700", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		base.DieEvent(reason);
		if (!this.a)
		{
			this.RiseEvent();
			return;
		}
	}

	// Token: 0x06002189 RID: 8585 RVA: 0x000B0B04 File Offset: 0x000AED04
	[Token(Token = "0x6002189")]
	[Address(RVA = "0x566A00", Offset = "0x565000", VA = "0x180566A00")]
	public Pickaxe_c()
	{
		List<ZombieType> list = new List();
		this.zombieTypes = list;
		this.digSpeed = 40f;
		base..ctor();
	}

	// Token: 0x04001112 RID: 4370
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001112")]
	private readonly List<ZombieType> zombieTypes;

	// Token: 0x04001113 RID: 4371
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4001113")]
	private bool a;
}
