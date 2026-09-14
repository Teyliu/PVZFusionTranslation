using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003A0 RID: 928
[Token(Token = "0x20003A0")]
public class HypnoEmperor : Plant
{
	// Token: 0x0600110D RID: 4365 RVA: 0x0006117C File Offset: 0x0005F37C
	[Token(Token = "0x600110D")]
	[Address(RVA = "0x43B370", Offset = "0x439970", VA = "0x18043B370", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.attributeCountdown = 30f;
		if (!Lawnf.TravelAdvanced(AdvBuff.撒豆成兵))
		{
			Board board = this.board;
		}
		this.attributeCountdown = 10f;
	}

	// Token: 0x0600110E RID: 4366 RVA: 0x000611BC File Offset: 0x0005F3BC
	[Token(Token = "0x600110E")]
	[Address(RVA = "0x43AE90", Offset = "0x439490", VA = "0x18043AE90", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		this.attributeCountdown = 30f;
		if (!Lawnf.TravelAdvanced(AdvBuff.撒豆成兵))
		{
			Board board = this.board;
		}
		this.attributeCountdown = 10f;
		this.anim.SetTrigger("summon");
		GameAPP.PlaySound(83, 0.5f, 1f);
	}

	// Token: 0x0600110F RID: 4367 RVA: 0x00061220 File Offset: 0x0005F420
	[Token(Token = "0x600110F")]
	[Address(RVA = "0x43B830", Offset = "0x439E30", VA = "0x18043B830", Slot = "16")]
	protected override void Update()
	{
		base.Update();
	}

	// Token: 0x06001110 RID: 4368 RVA: 0x00061234 File Offset: 0x0005F434
	[Token(Token = "0x6001110")]
	[Address(RVA = "0x43B3C0", Offset = "0x4399C0", VA = "0x18043B3C0", Slot = "69")]
	protected virtual void Summon()
	{
		if (!Lawnf.EveBalaced())
		{
			if (!Lawnf.TravelAdvanced((AdvBuff)((uint)1)))
			{
				List<ZombieType> list = new List();
			}
			List<ZombieType> list2 = new List();
			List<ZombieType> list3;
			if (Lawnf.TravelAdvanced((AdvBuff)((uint)12012)))
			{
				list3 = new List();
			}
			Board board = this.board;
			int num = 0;
			int thePlantRow = this.thePlantRow;
			this.SetZombie((ZombieType)((uint)200), list3, thePlantRow);
			int num2 = this.thePlantRow;
			num2++;
			this.SetZombie((ZombieType)((uint)200), list3, num2);
			int thePlantRow2 = this.thePlantRow;
			this.SetZombie((ZombieType)((uint)200), list3, thePlantRow2);
			int thePlantRow3 = this.thePlantRow;
			this.SetZombie((ZombieType)((uint)200), list3, thePlantRow3);
			num++;
			return;
		}
		Transform axis = this.axis;
		CreateZombie instance = CreateZombie.Instance;
		throw new NullReferenceException();
	}

	// Token: 0x06001111 RID: 4369 RVA: 0x00061304 File Offset: 0x0005F504
	[Token(Token = "0x6001111")]
	[Address(RVA = "0x43B120", Offset = "0x439720", VA = "0x18043B120")]
	private void SetZombie(ZombieType waterZombie, List<ZombieType> landZombies, int row)
	{
		Board board = this.board;
		int rowNum = board.rowNum;
		int num = 0;
		int thePlantColumn = this.thePlantColumn;
		if (board.GetBoxType(thePlantColumn, num) != BoxType.Water)
		{
			ZombieType random = ListExtensions.GetRandom<ZombieType>(landZombies);
			Transform axis = this.axis;
			CreateZombie instance = CreateZombie.Instance;
			int num2 = 0;
			Zombie zombie;
			if (zombie != num2)
			{
				ZombieType theZombieType = zombie.theZombieType;
				if (theZombieType == ZombieType.CherryPaperZombie || theZombieType == ZombieType.CherryPaperZ95)
				{
				}
				if (this.onSummon != 0)
				{
				}
			}
			return;
		}
		Transform axis2 = this.axis;
		CreateZombie instance2 = CreateZombie.Instance;
		throw new NullReferenceException();
	}

	// Token: 0x06001112 RID: 4370 RVA: 0x00061394 File Offset: 0x0005F594
	[Token(Token = "0x6001112")]
	[Address(RVA = "0x43B760", Offset = "0x439D60", VA = "0x18043B760")]
	private void Summon_skin()
	{
		this.Summon();
		Transform axis = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		int num = 0;
		int num2 = 0;
		int thePlantRow = this.thePlantRow;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)99), num, thePlantRow, num3 != 0UL, (float)num2);
	}

	// Token: 0x06001113 RID: 4371 RVA: 0x000613DC File Offset: 0x0005F5DC
	[Token(Token = "0x6001113")]
	[Address(RVA = "0x43AF60", Offset = "0x439560", VA = "0x18043AF60", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		ulong num;
		do
		{
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get3x3Plants(this.thePlantColumn, thePlantRow);
			bool flag;
			if (flag)
			{
				GameAPP.PlaySound(83, 0.5f, 1f);
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06001114 RID: 4372 RVA: 0x0006142C File Offset: 0x0005F62C
	[Token(Token = "0x6001114")]
	[Address(RVA = "0x43B870", Offset = "0x439E70", VA = "0x18043B870")]
	public HypnoEmperor()
	{
	}

	// Token: 0x04000BA4 RID: 2980
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000BA4")]
	public int restHealth = (int)((ulong)5L);

	// Token: 0x04000BA5 RID: 2981
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000BA5")]
	public Action<Zombie> onSummon;
}
