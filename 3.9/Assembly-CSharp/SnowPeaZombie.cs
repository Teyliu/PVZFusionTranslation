using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000702 RID: 1794
[Token(Token = "0x2000702")]
public class SnowPeaZombie : PeaShooterZ
{
	// Token: 0x0600234D RID: 9037 RVA: 0x000B85A0 File Offset: 0x000B67A0
	[Token(Token = "0x600234D")]
	[Address(RVA = "0x5D3550", Offset = "0x5D1B50", VA = "0x1805D3550", Slot = "77")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_snowPea;
	}

	// Token: 0x0600234E RID: 9038 RVA: 0x000B85B0 File Offset: 0x000B67B0
	[Token(Token = "0x600234E")]
	[Address(RVA = "0x5B3BB0", Offset = "0x5B21B0", VA = "0x1805B3BB0", Slot = "56")]
	public override void SetCold(float time, int coldLevel = 0, bool fromFreeze = false)
	{
		if (coldLevel > 0)
		{
			base.SetCold(time, coldLevel, fromFreeze);
			return;
		}
	}

	// Token: 0x0600234F RID: 9039 RVA: 0x000B85CC File Offset: 0x000B67CC
	[Token(Token = "0x600234F")]
	[Address(RVA = "0x5D34A0", Offset = "0x5D1AA0", VA = "0x1805D34A0", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		if (theFreezeLevel > 0)
		{
			base.SetFreeze(time, theFreezeLevel);
			return;
		}
	}

	// Token: 0x06002350 RID: 9040 RVA: 0x000B85E8 File Offset: 0x000B67E8
	[Token(Token = "0x6002350")]
	[Address(RVA = "0x5D34B0", Offset = "0x5D1AB0", VA = "0x1805D34B0", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06002351 RID: 9041 RVA: 0x000B8628 File Offset: 0x000B6828
	[Token(Token = "0x6002351")]
	[Address(RVA = "0x5C80C0", Offset = "0x5C66C0", VA = "0x1805C80C0")]
	public SnowPeaZombie()
	{
	}
}
