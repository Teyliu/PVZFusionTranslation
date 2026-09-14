using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200074A RID: 1866
[Token(Token = "0x200074A")]
public class WaterJackboxJumpZombie : Zombie
{
	// Token: 0x06002577 RID: 9591 RVA: 0x000C23EC File Offset: 0x000C05EC
	[Token(Token = "0x6002577")]
	[Address(RVA = "0x58A4F0", Offset = "0x588AF0", VA = "0x18058A4F0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.inWater = true;
	}

	// Token: 0x06002578 RID: 9592 RVA: 0x000C2408 File Offset: 0x000C0608
	[Token(Token = "0x6002578")]
	[Address(RVA = "0x60B130", Offset = "0x609730", VA = "0x18060B130", Slot = "30")]
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

	// Token: 0x06002579 RID: 9593 RVA: 0x000C2440 File Offset: 0x000C0640
	[Token(Token = "0x6002579")]
	[Address(RVA = "0x589F50", Offset = "0x588550", VA = "0x180589F50", Slot = "28")]
	public override void Die(int reason = 0)
	{
		bool flag = reason != 1;
		base.Die(flag ? 1 : 0);
	}

	// Token: 0x0600257A RID: 9594 RVA: 0x000C2460 File Offset: 0x000C0660
	[Token(Token = "0x600257A")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x0600257B RID: 9595 RVA: 0x000C2470 File Offset: 0x000C0670
	[Token(Token = "0x600257B")]
	[Address(RVA = "0x60B330", Offset = "0x609930", VA = "0x18060B330")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		if (collision.TryGetComponent<Plant>(num))
		{
			Team <Team>k__BackingField = this.<Team>k__BackingField;
			int theZombieRow = this.theZombieRow;
			int num2 = 0;
			this.Die(num2);
			bool flag2;
			bool flag = flag2 + true;
			Board board = this.board;
			bool flag3;
			if (!flag3)
			{
				flag = flag2;
			}
			int num3 = 0;
			if (num < board.rowNum)
			{
				Transform axis = this.axis;
				GameObject gameObject = this.box;
				Vector3 vector;
				float z = vector.z;
				Quaternion identityQuaternion = Quaternion.identityQuaternion;
				Transform transform = this.board.transform;
				GameObject gameObject2;
				JackboxBomb component = gameObject2.GetComponent<JackboxBomb>();
				component.theRow = num;
				bool isMindControlled = this.isMindControlled;
				component.isMindConrolled = isMindControlled;
				Board board2 = this.board;
				component.board = board2;
				float num4 = global::UnityEngine.Random.Range(-3f, 3f);
				int num5 = this.board.rowNum;
				float num6 = global::UnityEngine.Random.Range(5f, 8f);
				num5 -= num;
				long num7 = (long)(((flag + true) ? 1U : 0U) * (uint)500);
				num++;
				bool flag4 = flag + true;
				component.damageToPlant = (int)num7;
				long num8 = (long)((flag4 ? 1U : 0U) * (uint)1800);
				component.damage = (int)num8;
				component.v.z = (float)num3;
				Board board3 = this.board;
			}
		}
	}

	// Token: 0x0600257C RID: 9596 RVA: 0x000C25B4 File Offset: 0x000C07B4
	[Token(Token = "0x600257C")]
	[Address(RVA = "0x60B2A0", Offset = "0x6098A0", VA = "0x18060B2A0", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		Transform axis = this.axis;
	}

	// Token: 0x0600257D RID: 9597 RVA: 0x000C25D4 File Offset: 0x000C07D4
	[Token(Token = "0x600257D")]
	[Address(RVA = "0x60B6F0", Offset = "0x609CF0", VA = "0x18060B6F0")]
	public WaterJackboxJumpZombie()
	{
	}

	// Token: 0x04001295 RID: 4757
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001295")]
	public GameObject box;
}
