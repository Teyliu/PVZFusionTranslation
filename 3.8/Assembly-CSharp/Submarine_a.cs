using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006D0 RID: 1744
[Token(Token = "0x20006D0")]
public class Submarine_a : Zombie
{
	// Token: 0x0600225A RID: 8794 RVA: 0x000B449C File Offset: 0x000B269C
	[Token(Token = "0x600225A")]
	[Address(RVA = "0x533810", Offset = "0x531E10", VA = "0x180533810", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.inWater = true;
	}

	// Token: 0x0600225B RID: 8795 RVA: 0x000B44B8 File Offset: 0x000B26B8
	[Token(Token = "0x600225B")]
	[Address(RVA = "0x572810", Offset = "0x570E10", VA = "0x180572810", Slot = "29")]
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

	// Token: 0x0600225C RID: 8796 RVA: 0x000B44F4 File Offset: 0x000B26F4
	[Token(Token = "0x600225C")]
	[Address(RVA = "0x572980", Offset = "0x570F80", VA = "0x180572980", Slot = "28")]
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

	// Token: 0x0600225D RID: 8797 RVA: 0x000B454C File Offset: 0x000B274C
	[Token(Token = "0x600225D")]
	[Address(RVA = "0x572660", Offset = "0x570C60", VA = "0x180572660")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		Plant plant = base.CrashEntity(collision, true, 1f);
	}

	// Token: 0x0600225E RID: 8798 RVA: 0x000B4568 File Offset: 0x000B2768
	[Token(Token = "0x600225E")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x0600225F RID: 8799 RVA: 0x000B4578 File Offset: 0x000B2778
	[Token(Token = "0x600225F")]
	[Address(RVA = "0x537D20", Offset = "0x536320", VA = "0x180537D20", Slot = "27")]
	public override void Die(int reason = 0)
	{
		base.Die(reason);
	}

	// Token: 0x06002260 RID: 8800 RVA: 0x000B458C File Offset: 0x000B278C
	[Token(Token = "0x6002260")]
	[Address(RVA = "0x572B40", Offset = "0x571140", VA = "0x180572B40")]
	public Submarine_a()
	{
	}
}
