using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000632 RID: 1586
[Token(Token = "0x2000632")]
public class BoatImp : Zombie
{
	// Token: 0x06001E0A RID: 7690 RVA: 0x000A0A90 File Offset: 0x0009EC90
	[Token(Token = "0x6001E0A")]
	[Address(RVA = "0x533810", Offset = "0x531E10", VA = "0x180533810", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.inWater = true;
	}

	// Token: 0x06001E0B RID: 7691 RVA: 0x000A0AAC File Offset: 0x0009ECAC
	[Token(Token = "0x6001E0B")]
	[Address(RVA = "0x533CF0", Offset = "0x5322F0", VA = "0x180533CF0")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		if (this.anim.GetBool("isAttacking"))
		{
			this.anim.SetTrigger("pop");
		}
		Plant plant = base.CrashEntity(collision, true, 1f);
	}

	// Token: 0x06001E0C RID: 7692 RVA: 0x000A0AF4 File Offset: 0x0009ECF4
	[Token(Token = "0x6001E0C")]
	[Address(RVA = "0x533830", Offset = "0x531E30", VA = "0x180533830", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		ulong num2;
		do
		{
			List<Transform> changeSprites = this.changeSprites;
			bool flag;
			if (flag)
			{
				int num = 0;
				GameObject gameObject;
				Lawnf.ChangeSprite((float)num2, (float)num, gameObject);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06001E0D RID: 7693 RVA: 0x000A0B30 File Offset: 0x0009ED30
	[Token(Token = "0x6001E0D")]
	[Address(RVA = "0x533BA0", Offset = "0x5321A0", VA = "0x180533BA0")]
	protected int GetZombieRow()
	{
		List<int> list = new List();
		Board board = this.board;
		int num = this.theZombieRow;
		if (num < board.rowNum)
		{
			BoxType[] roadType = this.board.roadType;
			Board board2 = this.board;
			num++;
		}
		return this.theZombieRow;
	}

	// Token: 0x06001E0E RID: 7694 RVA: 0x000A0B9C File Offset: 0x0009ED9C
	[Token(Token = "0x6001E0E")]
	[Address(RVA = "0x533430", Offset = "0x531A30", VA = "0x180533430", Slot = "74")]
	protected virtual void AnimPop()
	{
		Transform shoot = this.shoot;
		Vector3 vector;
		float z = vector.z;
		List<int> list = new List();
		Board board = this.board;
		int num = this.theZombieRow;
		if (num < board.rowNum)
		{
			BoxType[] roadType = this.board.roadType;
			if ("{il2cpp array field local9->}" != (ulong)1L)
			{
			}
			Board board2 = this.board;
			num++;
		}
		int num2 = list._size;
		num2 = global::UnityEngine.Random.Range(0, num2);
		int num3 = list[num2];
		CreateZombie instance = CreateZombie.Instance;
		Zombie zombie;
		Transform transform = zombie.transform;
		Transform transform2 = zombie.transform;
		ImpZombie component = zombie.GetComponent<ImpZombie>();
		Transform axis = component.axis;
		Transform axis2 = this.axis;
		component.Thrown();
		int theZombieRow = this.theZombieRow;
		component.fromRow = theZombieRow;
		uint num4;
		uint num5;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num4, (int)num5), 0.5f, 1f);
	}

	// Token: 0x06001E0F RID: 7695 RVA: 0x000A0C88 File Offset: 0x0009EE88
	[Token(Token = "0x6001E0F")]
	[Address(RVA = "0x530300", Offset = "0x52E900", VA = "0x180530300")]
	private void AnimPopOver()
	{
	}

	// Token: 0x06001E10 RID: 7696 RVA: 0x000A0C98 File Offset: 0x0009EE98
	[Token(Token = "0x6001E10")]
	[Address(RVA = "0x533B60", Offset = "0x532160", VA = "0x180533B60", Slot = "27")]
	public override void Die(int reason = 0)
	{
		int reason2 = this.GetReason(reason);
		base.Die(reason);
	}

	// Token: 0x06001E11 RID: 7697 RVA: 0x000A0CB8 File Offset: 0x0009EEB8
	[Token(Token = "0x6001E11")]
	[Address(RVA = "0x533B90", Offset = "0x532190", VA = "0x180533B90", Slot = "75")]
	protected virtual int GetReason(int reason)
	{
		bool flag = reason != 1;
		return 0;
	}

	// Token: 0x06001E12 RID: 7698 RVA: 0x000A0CD0 File Offset: 0x0009EED0
	[Token(Token = "0x6001E12")]
	[Address(RVA = "0x5339A0", Offset = "0x531FA0", VA = "0x1805339A0", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		GameAPP.PlaySound(43, 0.5f, 1f);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = GameAPP.particlePrefab[34];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
	}

	// Token: 0x06001E13 RID: 7699 RVA: 0x000A0D28 File Offset: 0x0009EF28
	[Token(Token = "0x6001E13")]
	[Address(RVA = "0x533DA0", Offset = "0x5323A0", VA = "0x180533DA0")]
	public BoatImp()
	{
	}
}
