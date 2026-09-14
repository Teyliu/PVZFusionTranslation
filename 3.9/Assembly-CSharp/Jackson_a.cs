using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006C6 RID: 1734
[Token(Token = "0x20006C6")]
public class Jackson_a : Zombie
{
	// Token: 0x06002180 RID: 8576 RVA: 0x000B0800 File Offset: 0x000AEA00
	[Token(Token = "0x6002180")]
	[Address(RVA = "0x5BA970", Offset = "0x5B8F70", VA = "0x1805BA970", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)32L);
		this.attributeCountDown = 3f;
	}

	// Token: 0x06002181 RID: 8577 RVA: 0x000B0828 File Offset: 0x000AEA28
	[Token(Token = "0x6002181")]
	[Address(RVA = "0x5BB010", Offset = "0x5B9610", VA = "0x1805BB010", Slot = "17")]
	protected override void Update()
	{
		base.Update();
	}

	// Token: 0x06002182 RID: 8578 RVA: 0x000B083C File Offset: 0x000AEA3C
	[Token(Token = "0x6002182")]
	[Address(RVA = "0x5BAA40", Offset = "0x5B9040", VA = "0x1805BAA40", Slot = "76")]
	protected virtual void CheckLose()
	{
		Transform axis = this.axis;
		Transform axis2 = this.axis;
		Transform axis3 = this.axis;
		Transform axis4 = this.axis;
		int num = this.theZombieRow;
		num++;
		bool flag;
		this.anim.SetBool("loseDancer", flag);
	}

	// Token: 0x06002183 RID: 8579 RVA: 0x000B0894 File Offset: 0x000AEA94
	[Token(Token = "0x6002183")]
	[Address(RVA = "0x5BA920", Offset = "0x5B8F20", VA = "0x1805BA920", Slot = "24")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("summon");
	}

	// Token: 0x06002184 RID: 8580 RVA: 0x000B08B8 File Offset: 0x000AEAB8
	[Token(Token = "0x6002184")]
	[Address(RVA = "0x5BA9A0", Offset = "0x5B8FA0", VA = "0x1805BA9A0", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06002185 RID: 8581 RVA: 0x000B08F8 File Offset: 0x000AEAF8
	[Token(Token = "0x6002185")]
	[Address(RVA = "0x5BAF10", Offset = "0x5B9510", VA = "0x1805BAF10")]
	private void TurnBody(float angle)
	{
		Transform axis = this.axis;
		Transform transform = base.transform;
	}

	// Token: 0x06002186 RID: 8582 RVA: 0x000B091C File Offset: 0x000AEB1C
	[Token(Token = "0x6002186")]
	[Address(RVA = "0x5BA7A0", Offset = "0x5B8DA0", VA = "0x1805BA7A0", Slot = "77")]
	protected virtual void AnimSummon()
	{
		GameAPP.PlaySound(69, 0.5f, 1f);
		int num = 0;
		base.ChangeStatus((ZombieStatus)num);
		Transform axis = this.axis;
		Transform axis2 = this.axis;
		Transform axis3 = this.axis;
		Transform axis4 = this.axis;
		int num2 = this.theZombieRow;
		num2++;
	}

	// Token: 0x06002187 RID: 8583 RVA: 0x000B097C File Offset: 0x000AEB7C
	[Token(Token = "0x6002187")]
	[Address(RVA = "0x5BACA0", Offset = "0x5B92A0", VA = "0x1805BACA0")]
	protected void SetZombie(float x, int row, int index)
	{
		int num = 0;
		if (this.CheckSummon(x, row, index))
		{
			Zombie zombie = CreateZombie.Instance.SetZombie(row, (ZombieType)((uint)217), x, num != 0);
			Zombie zombie2 = CreateZombie.Instance.SetZombieWithMindControl(row, (ZombieType)((uint)217), x, num != 0);
			int num2 = 0;
			if (zombie2 != num2)
			{
				Zombie[] array = this.zombies;
				if (zombie2 != 0)
				{
				}
				array[0] = zombie2;
				this.board.SetHealthInTravel(zombie2);
				ParticleManager instance = ParticleManager.Instance;
				Transform axis = zombie2.axis;
				int num3 = 0;
				int num4 = 0;
				ulong num5;
				Particle particle = instance.SetParticle((ParticleType)((uint)11), num3, index, num5 != 0UL, (float)num4);
			}
		}
	}

	// Token: 0x06002188 RID: 8584 RVA: 0x000B0A20 File Offset: 0x000AEC20
	[Token(Token = "0x6002188")]
	[Address(RVA = "0x5BABC0", Offset = "0x5B91C0", VA = "0x1805BABC0")]
	protected bool CheckSummon(float x, int row, int index)
	{
		Board board = this.board;
		if (row < board.rowNum)
		{
			int columnFromX = Lawnf.GetColumnFromX(x);
			if (board.GetBoxType(columnFromX, row) != BoxType.Water)
			{
				Zombie zombie = this.zombies[index];
				int num = 0;
				bool flag = zombie == num;
			}
		}
		throw new IndexOutOfRangeException();
	}

	// Token: 0x06002189 RID: 8585 RVA: 0x000B0A74 File Offset: 0x000AEC74
	[Token(Token = "0x6002189")]
	[Address(RVA = "0x5BB0A0", Offset = "0x5B96A0", VA = "0x1805BB0A0")]
	public Jackson_a()
	{
		Zombie[] array = new Zombie[4];
		this.zombies = array;
		base..ctor();
	}

	// Token: 0x040011A0 RID: 4512
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x40011A0")]
	protected Zombie[] zombies;
}
