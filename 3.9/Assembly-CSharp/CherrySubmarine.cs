using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000675 RID: 1653
[Token(Token = "0x2000675")]
public class CherrySubmarine : Zombie
{
	// Token: 0x06001F60 RID: 8032 RVA: 0x000A6EFC File Offset: 0x000A50FC
	[Token(Token = "0x6001F60")]
	[Address(RVA = "0x59BA00", Offset = "0x59A000", VA = "0x18059BA00", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		this.inWater = true;
		float num;
		this.theOriginSpeed = num;
	}

	// Token: 0x06001F61 RID: 8033 RVA: 0x000A6F20 File Offset: 0x000A5120
	[Token(Token = "0x6001F61")]
	[Address(RVA = "0x59B670", Offset = "0x599C70", VA = "0x18059B670", Slot = "30")]
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

	// Token: 0x06001F62 RID: 8034 RVA: 0x000A6F58 File Offset: 0x000A5158
	[Token(Token = "0x6001F62")]
	[Address(RVA = "0x59B9D0", Offset = "0x599FD0", VA = "0x18059B9D0", Slot = "57")]
	public override void SetKelped(float time, bool land = false)
	{
		base.SetKelped(time, land);
		this.kelpTimes = (int)((ulong)15L);
	}

	// Token: 0x06001F63 RID: 8035 RVA: 0x000A6F78 File Offset: 0x000A5178
	[Token(Token = "0x6001F63")]
	[Address(RVA = "0x59B7E0", Offset = "0x599DE0", VA = "0x18059B7E0", Slot = "29")]
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

	// Token: 0x06001F64 RID: 8036 RVA: 0x000A6FD0 File Offset: 0x000A51D0
	[Token(Token = "0x6001F64")]
	[Address(RVA = "0x59B9A0", Offset = "0x599FA0", VA = "0x18059B9A0")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		Plant plant = base.CrashEntity(collision, true, 0.3f);
	}

	// Token: 0x06001F65 RID: 8037 RVA: 0x000A6FEC File Offset: 0x000A51EC
	[Token(Token = "0x6001F65")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06001F66 RID: 8038 RVA: 0x000A6FFC File Offset: 0x000A51FC
	[Token(Token = "0x6001F66")]
	[Address(RVA = "0x58EA00", Offset = "0x58D000", VA = "0x18058EA00", Slot = "28")]
	public override void Die(int reason = 0)
	{
		base.Die(reason);
	}

	// Token: 0x06001F67 RID: 8039 RVA: 0x000A7010 File Offset: 0x000A5210
	[Token(Token = "0x6001F67")]
	[Address(RVA = "0x59BA40", Offset = "0x59A040", VA = "0x18059BA40")]
	public CherrySubmarine()
	{
	}

	// Token: 0x0400111A RID: 4378
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x400111A")]
	public GameObject body1;

	// Token: 0x0400111B RID: 4379
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x400111B")]
	public GameObject body2;
}
