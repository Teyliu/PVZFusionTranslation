using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000701 RID: 1793
[Token(Token = "0x2000701")]
public class SnowNormalZombie : ConeZombie
{
	// Token: 0x06002348 RID: 9032 RVA: 0x000B8504 File Offset: 0x000B6704
	[Token(Token = "0x6002348")]
	[Address(RVA = "0x5D3400", Offset = "0x5D1A00", VA = "0x1805D3400", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06002349 RID: 9033 RVA: 0x000B8544 File Offset: 0x000B6744
	[Token(Token = "0x6002349")]
	[Address(RVA = "0x586A30", Offset = "0x585030", VA = "0x180586A30", Slot = "63")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x0600234A RID: 9034 RVA: 0x000B8554 File Offset: 0x000B6754
	[Token(Token = "0x600234A")]
	[Address(RVA = "0x5B3BB0", Offset = "0x5B21B0", VA = "0x1805B3BB0", Slot = "56")]
	public override void SetCold(float time, int coldLevel = 0, bool fromFreeze = false)
	{
		if (coldLevel > 0)
		{
			base.SetCold(time, coldLevel, fromFreeze);
			return;
		}
	}

	// Token: 0x0600234B RID: 9035 RVA: 0x000B8570 File Offset: 0x000B6770
	[Token(Token = "0x600234B")]
	[Address(RVA = "0x5D34A0", Offset = "0x5D1AA0", VA = "0x1805D34A0", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		if (theFreezeLevel > 0)
		{
			base.SetFreeze(time, theFreezeLevel);
			return;
		}
	}

	// Token: 0x0600234C RID: 9036 RVA: 0x000B858C File Offset: 0x000B678C
	[Token(Token = "0x600234C")]
	[Address(RVA = "0x58B130", Offset = "0x589730", VA = "0x18058B130")]
	public SnowNormalZombie()
	{
	}
}
