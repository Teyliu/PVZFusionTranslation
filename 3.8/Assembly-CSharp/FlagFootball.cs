using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000666 RID: 1638
[Token(Token = "0x2000666")]
public class FlagFootball : ZombieFootball
{
	// Token: 0x06001F2F RID: 7983 RVA: 0x000A614C File Offset: 0x000A434C
	[Token(Token = "0x6001F2F")]
	[Address(RVA = "0x546210", Offset = "0x544810", VA = "0x180546210", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)34L);
	}

	// Token: 0x06001F30 RID: 7984 RVA: 0x000A616C File Offset: 0x000A436C
	[Token(Token = "0x6001F30")]
	[Address(RVA = "0x546480", Offset = "0x544A80", VA = "0x180546480", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		float num = this.theOriginSpeed * 1.3f;
		this.theOriginSpeed = num;
	}

	// Token: 0x06001F31 RID: 7985 RVA: 0x000A6194 File Offset: 0x000A4394
	[Token(Token = "0x6001F31")]
	[Address(RVA = "0x5463A0", Offset = "0x5449A0", VA = "0x1805463A0", Slot = "17")]
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

	// Token: 0x06001F32 RID: 7986 RVA: 0x000A61DC File Offset: 0x000A43DC
	[Token(Token = "0x6001F32")]
	[Address(RVA = "0x546230", Offset = "0x544830", VA = "0x180546230", Slot = "61")]
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

	// Token: 0x06001F33 RID: 7987 RVA: 0x000A621C File Offset: 0x000A441C
	[Token(Token = "0x6001F33")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "74")]
	protected virtual void OnRoll()
	{
	}

	// Token: 0x06001F34 RID: 7988 RVA: 0x000A622C File Offset: 0x000A442C
	[Token(Token = "0x6001F34")]
	[Address(RVA = "0x534450", Offset = "0x532A50", VA = "0x180534450")]
	public FlagFootball()
	{
	}
}
