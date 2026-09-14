using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000668 RID: 1640
[Token(Token = "0x2000668")]
public class BoatImp : Zombie
{
	// Token: 0x06001F0C RID: 7948 RVA: 0x000A51E4 File Offset: 0x000A33E4
	[Token(Token = "0x6001F0C")]
	[Address(RVA = "0x58A4F0", Offset = "0x588AF0", VA = "0x18058A4F0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.inWater = true;
	}

	// Token: 0x06001F0D RID: 7949 RVA: 0x000A5200 File Offset: 0x000A3400
	[Token(Token = "0x6001F0D")]
	[Address(RVA = "0x58A9D0", Offset = "0x588FD0", VA = "0x18058A9D0")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		if (this.anim.GetBool("isAttacking"))
		{
			this.anim.SetTrigger("pop");
		}
		Plant plant = base.CrashEntity(collision, true, 1f);
	}

	// Token: 0x06001F0E RID: 7950 RVA: 0x000A5248 File Offset: 0x000A3448
	[Token(Token = "0x6001F0E")]
	[Address(RVA = "0x58A510", Offset = "0x588B10", VA = "0x18058A510", Slot = "30")]
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
				Lawnf.ChangeSprite((float)0, (float)num, gameObject);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06001F0F RID: 7951 RVA: 0x000A5280 File Offset: 0x000A3480
	[Token(Token = "0x6001F0F")]
	[Address(RVA = "0x58A880", Offset = "0x588E80", VA = "0x18058A880")]
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

	// Token: 0x06001F10 RID: 7952 RVA: 0x000A52EC File Offset: 0x000A34EC
	[Token(Token = "0x6001F10")]
	[Address(RVA = "0x58A110", Offset = "0x588710", VA = "0x18058A110", Slot = "76")]
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

	// Token: 0x06001F11 RID: 7953 RVA: 0x000A53D8 File Offset: 0x000A35D8
	[Token(Token = "0x6001F11")]
	[Address(RVA = "0x586E80", Offset = "0x585480", VA = "0x180586E80")]
	private void AnimPopOver()
	{
	}

	// Token: 0x06001F12 RID: 7954 RVA: 0x000A53E8 File Offset: 0x000A35E8
	[Token(Token = "0x6001F12")]
	[Address(RVA = "0x58A840", Offset = "0x588E40", VA = "0x18058A840", Slot = "28")]
	public override void Die(int reason = 0)
	{
		int reason2 = this.GetReason(reason);
		base.Die(reason);
	}

	// Token: 0x06001F13 RID: 7955 RVA: 0x000A5408 File Offset: 0x000A3608
	[Token(Token = "0x6001F13")]
	[Address(RVA = "0x58A870", Offset = "0x588E70", VA = "0x18058A870", Slot = "77")]
	protected virtual int GetReason(int reason)
	{
		bool flag = reason != 1;
		return 0;
	}

	// Token: 0x06001F14 RID: 7956 RVA: 0x000A5420 File Offset: 0x000A3620
	[Token(Token = "0x6001F14")]
	[Address(RVA = "0x58A680", Offset = "0x588C80", VA = "0x18058A680", Slot = "29")]
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

	// Token: 0x06001F15 RID: 7957 RVA: 0x000A5478 File Offset: 0x000A3678
	[Token(Token = "0x6001F15")]
	[Address(RVA = "0x58AA80", Offset = "0x589080", VA = "0x18058AA80")]
	public BoatImp()
	{
	}
}
