using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200068F RID: 1679
[Token(Token = "0x200068F")]
public class Jackson_a : Zombie
{
	// Token: 0x06002069 RID: 8297 RVA: 0x000ABBD0 File Offset: 0x000A9DD0
	[Token(Token = "0x6002069")]
	[Address(RVA = "0x5564D0", Offset = "0x554AD0", VA = "0x1805564D0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)32L);
		this.attributeCountDown = 3f;
	}

	// Token: 0x0600206A RID: 8298 RVA: 0x000ABBF8 File Offset: 0x000A9DF8
	[Token(Token = "0x600206A")]
	[Address(RVA = "0x556B70", Offset = "0x555170", VA = "0x180556B70", Slot = "16")]
	protected override void Update()
	{
		base.Update();
	}

	// Token: 0x0600206B RID: 8299 RVA: 0x000ABC0C File Offset: 0x000A9E0C
	[Token(Token = "0x600206B")]
	[Address(RVA = "0x5565A0", Offset = "0x554BA0", VA = "0x1805565A0", Slot = "74")]
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

	// Token: 0x0600206C RID: 8300 RVA: 0x000ABC64 File Offset: 0x000A9E64
	[Token(Token = "0x600206C")]
	[Address(RVA = "0x556480", Offset = "0x554A80", VA = "0x180556480", Slot = "23")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("summon");
	}

	// Token: 0x0600206D RID: 8301 RVA: 0x000ABC88 File Offset: 0x000A9E88
	[Token(Token = "0x600206D")]
	[Address(RVA = "0x556500", Offset = "0x554B00", VA = "0x180556500", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x0600206E RID: 8302 RVA: 0x000ABCC8 File Offset: 0x000A9EC8
	[Token(Token = "0x600206E")]
	[Address(RVA = "0x556A70", Offset = "0x555070", VA = "0x180556A70")]
	private void TurnBody(float angle)
	{
		Transform axis = this.axis;
		Transform transform = base.transform;
	}

	// Token: 0x0600206F RID: 8303 RVA: 0x000ABCEC File Offset: 0x000A9EEC
	[Token(Token = "0x600206F")]
	[Address(RVA = "0x556300", Offset = "0x554900", VA = "0x180556300", Slot = "75")]
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

	// Token: 0x06002070 RID: 8304 RVA: 0x000ABD4C File Offset: 0x000A9F4C
	[Token(Token = "0x6002070")]
	[Address(RVA = "0x556800", Offset = "0x554E00", VA = "0x180556800")]
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

	// Token: 0x06002071 RID: 8305 RVA: 0x000ABDF0 File Offset: 0x000A9FF0
	[Token(Token = "0x6002071")]
	[Address(RVA = "0x556720", Offset = "0x554D20", VA = "0x180556720")]
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

	// Token: 0x06002072 RID: 8306 RVA: 0x000ABE44 File Offset: 0x000AA044
	[Token(Token = "0x6002072")]
	[Address(RVA = "0x556C00", Offset = "0x555200", VA = "0x180556C00")]
	public Jackson_a()
	{
		Zombie[] array = new Zombie[4];
		this.zombies = array;
		base..ctor();
	}

	// Token: 0x040010D3 RID: 4307
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x40010D3")]
	protected Zombie[] zombies;
}
