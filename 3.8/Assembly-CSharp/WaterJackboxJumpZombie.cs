using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000711 RID: 1809
[Token(Token = "0x2000711")]
public class WaterJackboxJumpZombie : Zombie
{
	// Token: 0x06002457 RID: 9303 RVA: 0x000BD600 File Offset: 0x000BB800
	[Token(Token = "0x6002457")]
	[Address(RVA = "0x533810", Offset = "0x531E10", VA = "0x180533810", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.inWater = true;
	}

	// Token: 0x06002458 RID: 9304 RVA: 0x000BD61C File Offset: 0x000BB81C
	[Token(Token = "0x6002458")]
	[Address(RVA = "0x591010", Offset = "0x58F610", VA = "0x180591010", Slot = "29")]
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

	// Token: 0x06002459 RID: 9305 RVA: 0x000BD658 File Offset: 0x000BB858
	[Token(Token = "0x6002459")]
	[Address(RVA = "0x533270", Offset = "0x531870", VA = "0x180533270", Slot = "27")]
	public override void Die(int reason = 0)
	{
		bool flag = reason != 1;
		base.Die(flag ? 1 : 0);
	}

	// Token: 0x0600245A RID: 9306 RVA: 0x000BD678 File Offset: 0x000BB878
	[Token(Token = "0x600245A")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x0600245B RID: 9307 RVA: 0x000BD688 File Offset: 0x000BB888
	[Token(Token = "0x600245B")]
	[Address(RVA = "0x591210", Offset = "0x58F810", VA = "0x180591210")]
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

	// Token: 0x0600245C RID: 9308 RVA: 0x000BD7CC File Offset: 0x000BB9CC
	[Token(Token = "0x600245C")]
	[Address(RVA = "0x591180", Offset = "0x58F780", VA = "0x180591180", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		Transform axis = this.axis;
	}

	// Token: 0x0600245D RID: 9309 RVA: 0x000BD7EC File Offset: 0x000BB9EC
	[Token(Token = "0x600245D")]
	[Address(RVA = "0x5915D0", Offset = "0x58FBD0", VA = "0x1805915D0")]
	public WaterJackboxJumpZombie()
	{
	}

	// Token: 0x040011C3 RID: 4547
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x40011C3")]
	public GameObject box;
}
