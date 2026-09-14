using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006CA RID: 1738
[Token(Token = "0x20006CA")]
public class SnowPeaZombie : PeaShooterZ
{
	// Token: 0x06002232 RID: 8754 RVA: 0x000B3790 File Offset: 0x000B1990
	[Token(Token = "0x6002232")]
	[Address(RVA = "0x56FE40", Offset = "0x56E440", VA = "0x18056FE40", Slot = "75")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_snowPea;
	}

	// Token: 0x06002233 RID: 8755 RVA: 0x000B37A0 File Offset: 0x000B19A0
	[Token(Token = "0x6002233")]
	[Address(RVA = "0x550020", Offset = "0x54E620", VA = "0x180550020", Slot = "54")]
	public override void SetCold(float time, int coldLevel = 0, bool fromFreeze = false)
	{
		if (coldLevel > 0)
		{
			base.SetCold(time, coldLevel, fromFreeze);
			return;
		}
	}

	// Token: 0x06002234 RID: 8756 RVA: 0x000B37BC File Offset: 0x000B19BC
	[Token(Token = "0x6002234")]
	[Address(RVA = "0x56FD90", Offset = "0x56E390", VA = "0x18056FD90", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		if (theFreezeLevel > 0)
		{
			base.SetFreeze(time, theFreezeLevel);
			return;
		}
	}

	// Token: 0x06002235 RID: 8757 RVA: 0x000B37D8 File Offset: 0x000B19D8
	[Token(Token = "0x6002235")]
	[Address(RVA = "0x56FDA0", Offset = "0x56E3A0", VA = "0x18056FDA0", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06002236 RID: 8758 RVA: 0x000B3818 File Offset: 0x000B1A18
	[Token(Token = "0x6002236")]
	[Address(RVA = "0x539090", Offset = "0x537690", VA = "0x180539090")]
	public SnowPeaZombie()
	{
	}
}
