using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000708 RID: 1800
[Token(Token = "0x2000708")]
public class Submarine_a : Zombie
{
	// Token: 0x06002374 RID: 9076 RVA: 0x000B925C File Offset: 0x000B745C
	[Token(Token = "0x6002374")]
	[Address(RVA = "0x58A4F0", Offset = "0x588AF0", VA = "0x18058A4F0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.inWater = true;
	}

	// Token: 0x06002375 RID: 9077 RVA: 0x000B9278 File Offset: 0x000B7478
	[Token(Token = "0x6002375")]
	[Address(RVA = "0x5D5E80", Offset = "0x5D4480", VA = "0x1805D5E80", Slot = "30")]
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

	// Token: 0x06002376 RID: 9078 RVA: 0x000B92B0 File Offset: 0x000B74B0
	[Token(Token = "0x6002376")]
	[Address(RVA = "0x5D5FF0", Offset = "0x5D45F0", VA = "0x1805D5FF0", Slot = "29")]
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

	// Token: 0x06002377 RID: 9079 RVA: 0x000B9308 File Offset: 0x000B7508
	[Token(Token = "0x6002377")]
	[Address(RVA = "0x5D5CD0", Offset = "0x5D42D0", VA = "0x1805D5CD0")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		Plant plant = base.CrashEntity(collision, true, 1f);
	}

	// Token: 0x06002378 RID: 9080 RVA: 0x000B9324 File Offset: 0x000B7524
	[Token(Token = "0x6002378")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06002379 RID: 9081 RVA: 0x000B9334 File Offset: 0x000B7534
	[Token(Token = "0x6002379")]
	[Address(RVA = "0x58EA00", Offset = "0x58D000", VA = "0x18058EA00", Slot = "28")]
	public override void Die(int reason = 0)
	{
		base.Die(reason);
	}

	// Token: 0x0600237A RID: 9082 RVA: 0x000B9348 File Offset: 0x000B7548
	[Token(Token = "0x600237A")]
	[Address(RVA = "0x5D61B0", Offset = "0x5D47B0", VA = "0x1805D61B0")]
	public Submarine_a()
	{
	}
}
