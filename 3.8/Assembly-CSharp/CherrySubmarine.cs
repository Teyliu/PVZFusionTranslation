using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200063F RID: 1599
[Token(Token = "0x200063F")]
public class CherrySubmarine : Zombie
{
	// Token: 0x06001E5E RID: 7774 RVA: 0x000A27AC File Offset: 0x000A09AC
	[Token(Token = "0x6001E5E")]
	[Address(RVA = "0x539430", Offset = "0x537A30", VA = "0x180539430", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.inWater = true;
		float num;
		this.theOriginSpeed = num;
	}

	// Token: 0x06001E5F RID: 7775 RVA: 0x000A27D0 File Offset: 0x000A09D0
	[Token(Token = "0x6001E5F")]
	[Address(RVA = "0x5390A0", Offset = "0x5376A0", VA = "0x1805390A0", Slot = "29")]
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

	// Token: 0x06001E60 RID: 7776 RVA: 0x000A280C File Offset: 0x000A0A0C
	[Token(Token = "0x6001E60")]
	[Address(RVA = "0x539400", Offset = "0x537A00", VA = "0x180539400", Slot = "55")]
	public override void SetKelped(float time, bool land = false)
	{
		base.SetKelped(time, land);
		this.kelpTimes = (int)((ulong)15L);
	}

	// Token: 0x06001E61 RID: 7777 RVA: 0x000A282C File Offset: 0x000A0A2C
	[Token(Token = "0x6001E61")]
	[Address(RVA = "0x539210", Offset = "0x537810", VA = "0x180539210", Slot = "28")]
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

	// Token: 0x06001E62 RID: 7778 RVA: 0x000A2884 File Offset: 0x000A0A84
	[Token(Token = "0x6001E62")]
	[Address(RVA = "0x5393D0", Offset = "0x5379D0", VA = "0x1805393D0")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		Plant plant = base.CrashEntity(collision, true, 0.3f);
	}

	// Token: 0x06001E63 RID: 7779 RVA: 0x000A28A0 File Offset: 0x000A0AA0
	[Token(Token = "0x6001E63")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06001E64 RID: 7780 RVA: 0x000A28B0 File Offset: 0x000A0AB0
	[Token(Token = "0x6001E64")]
	[Address(RVA = "0x537D20", Offset = "0x536320", VA = "0x180537D20", Slot = "27")]
	public override void Die(int reason = 0)
	{
		base.Die(reason);
	}

	// Token: 0x06001E65 RID: 7781 RVA: 0x000A28C4 File Offset: 0x000A0AC4
	[Token(Token = "0x6001E65")]
	[Address(RVA = "0x539470", Offset = "0x537A70", VA = "0x180539470")]
	public CherrySubmarine()
	{
	}

	// Token: 0x0400104E RID: 4174
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x400104E")]
	public GameObject body1;

	// Token: 0x0400104F RID: 4175
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x400104F")]
	public GameObject body2;
}
