using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020006EB RID: 1771
[Token(Token = "0x20006EB")]
public class Pickaxe_c : Pickaxe_b
{
	// Token: 0x0600229C RID: 8860 RVA: 0x000B5618 File Offset: 0x000B3818
	[Token(Token = "0x600229C")]
	[Address(RVA = "0x5C9EC0", Offset = "0x5C84C0", VA = "0x1805C9EC0", Slot = "10")]
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

	// Token: 0x0600229D RID: 8861 RVA: 0x000B569C File Offset: 0x000B389C
	[Token(Token = "0x600229D")]
	[Address(RVA = "0x5C9B10", Offset = "0x5C8110", VA = "0x1805C9B10", Slot = "24")]
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

	// Token: 0x0600229E RID: 8862 RVA: 0x000B5718 File Offset: 0x000B3918
	[Token(Token = "0x600229E")]
	[Address(RVA = "0x5C9FE0", Offset = "0x5C85E0", VA = "0x1805C9FE0")]
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

	// Token: 0x0600229F RID: 8863 RVA: 0x000B5790 File Offset: 0x000B3990
	[Token(Token = "0x600229F")]
	[Address(RVA = "0x5C9FB0", Offset = "0x5C85B0", VA = "0x1805C9FB0", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		base.DieEvent(reason);
		if (!this.a)
		{
			this.RiseEvent();
			return;
		}
	}

	// Token: 0x060022A0 RID: 8864 RVA: 0x000B57B4 File Offset: 0x000B39B4
	[Token(Token = "0x60022A0")]
	[Address(RVA = "0x5CA2B0", Offset = "0x5C88B0", VA = "0x1805CA2B0")]
	public Pickaxe_c()
	{
		List<ZombieType> list = new List();
		this.zombieTypes = list;
		this.digSpeed = 40f;
		base..ctor();
	}

	// Token: 0x040011DF RID: 4575
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x40011DF")]
	private readonly List<ZombieType> zombieTypes;

	// Token: 0x040011E0 RID: 4576
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x40011E0")]
	private bool a;
}
