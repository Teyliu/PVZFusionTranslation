using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003B4 RID: 948
[Token(Token = "0x20003B4")]
public class HypnoEmperor : Plant
{
	// Token: 0x06001169 RID: 4457 RVA: 0x000627D4 File Offset: 0x000609D4
	[Token(Token = "0x6001169")]
	[Address(RVA = "0x48EBC0", Offset = "0x48D1C0", VA = "0x18048EBC0", Slot = "15")]
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

	// Token: 0x0600116A RID: 4458 RVA: 0x00062814 File Offset: 0x00060A14
	[Token(Token = "0x600116A")]
	[Address(RVA = "0x48E6E0", Offset = "0x48CCE0", VA = "0x18048E6E0", Slot = "39")]
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

	// Token: 0x0600116B RID: 4459 RVA: 0x00062878 File Offset: 0x00060A78
	[Token(Token = "0x600116B")]
	[Address(RVA = "0x48F080", Offset = "0x48D680", VA = "0x18048F080", Slot = "16")]
	protected override void Update()
	{
		base.Update();
	}

	// Token: 0x0600116C RID: 4460 RVA: 0x0006288C File Offset: 0x00060A8C
	[Token(Token = "0x600116C")]
	[Address(RVA = "0x48EC10", Offset = "0x48D210", VA = "0x18048EC10", Slot = "68")]
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

	// Token: 0x0600116D RID: 4461 RVA: 0x0006295C File Offset: 0x00060B5C
	[Token(Token = "0x600116D")]
	[Address(RVA = "0x48E970", Offset = "0x48CF70", VA = "0x18048E970")]
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

	// Token: 0x0600116E RID: 4462 RVA: 0x000629EC File Offset: 0x00060BEC
	[Token(Token = "0x600116E")]
	[Address(RVA = "0x48EFB0", Offset = "0x48D5B0", VA = "0x18048EFB0")]
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

	// Token: 0x0600116F RID: 4463 RVA: 0x00062A34 File Offset: 0x00060C34
	[Token(Token = "0x600116F")]
	[Address(RVA = "0x48E7B0", Offset = "0x48CDB0", VA = "0x18048E7B0", Slot = "51")]
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

	// Token: 0x06001170 RID: 4464 RVA: 0x00062A84 File Offset: 0x00060C84
	[Token(Token = "0x6001170")]
	[Address(RVA = "0x48F0C0", Offset = "0x48D6C0", VA = "0x18048F0C0")]
	public HypnoEmperor()
	{
	}

	// Token: 0x04000C0A RID: 3082
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C0A")]
	public int restHealth = (int)((ulong)5L);

	// Token: 0x04000C0B RID: 3083
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000C0B")]
	public Action<Zombie> onSummon;
}
