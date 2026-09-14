using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200069C RID: 1692
[Token(Token = "0x200069C")]
public class FlagFootball : ZombieFootball
{
	// Token: 0x06002031 RID: 8241 RVA: 0x000AA8C4 File Offset: 0x000A8AC4
	[Token(Token = "0x6002031")]
	[Address(RVA = "0x5A8390", Offset = "0x5A6990", VA = "0x1805A8390", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)34L);
	}

	// Token: 0x06002032 RID: 8242 RVA: 0x000AA8E4 File Offset: 0x000A8AE4
	[Token(Token = "0x6002032")]
	[Address(RVA = "0x5A8600", Offset = "0x5A6C00", VA = "0x1805A8600", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		float num = this.theOriginSpeed * 1.3f;
		this.theOriginSpeed = num;
	}

	// Token: 0x06002033 RID: 8243 RVA: 0x000AA90C File Offset: 0x000A8B0C
	[Token(Token = "0x6002033")]
	[Address(RVA = "0x5A8520", Offset = "0x5A6B20", VA = "0x1805A8520", Slot = "18")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (this.anim.GetBool("isAttacking"))
		{
			this.anim.SetTrigger("roll");
			base.ChangeStatus((ZombieStatus)((uint)3));
			return;
		}
	}

	// Token: 0x06002034 RID: 8244 RVA: 0x000AA954 File Offset: 0x000A8B54
	[Token(Token = "0x6002034")]
	[Address(RVA = "0x5A83B0", Offset = "0x5A69B0", VA = "0x1805A83B0", Slot = "63")]
	protected override void FirstArmorBroken()
	{
		ulong num2;
		do
		{
			base.FirstArmorBroken();
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

	// Token: 0x06002035 RID: 8245 RVA: 0x000AA994 File Offset: 0x000A8B94
	[Token(Token = "0x6002035")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "76")]
	protected virtual void OnRoll()
	{
	}

	// Token: 0x06002036 RID: 8246 RVA: 0x000AA9A4 File Offset: 0x000A8BA4
	[Token(Token = "0x6002036")]
	[Address(RVA = "0x58B130", Offset = "0x589730", VA = "0x18058B130")]
	public FlagFootball()
	{
	}
}
