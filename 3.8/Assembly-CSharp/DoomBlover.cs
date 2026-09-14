using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000377 RID: 887
[Token(Token = "0x2000377")]
public class DoomBlover : Blover
{
	// Token: 0x06001046 RID: 4166 RVA: 0x0005DB34 File Offset: 0x0005BD34
	[Token(Token = "0x6001046")]
	[Address(RVA = "0x430550", Offset = "0x42EB50", VA = "0x180430550", Slot = "69")]
	protected override void AnimBlow()
	{
		base.AnimBlow();
		this.theStatus = (PlantStatus)((ulong)25L);
	}

	// Token: 0x06001047 RID: 4167 RVA: 0x0005DB54 File Offset: 0x0005BD54
	[Token(Token = "0x6001047")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10")]
	protected new void DelayDie()
	{
	}

	// Token: 0x06001048 RID: 4168 RVA: 0x0005DB64 File Offset: 0x0005BD64
	[Token(Token = "0x6001048")]
	[Address(RVA = "0x4308D0", Offset = "0x42EED0", VA = "0x1804308D0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
		}
	}

	// Token: 0x06001049 RID: 4169 RVA: 0x0005DB84 File Offset: 0x0005BD84
	[Token(Token = "0x6001049")]
	[Address(RVA = "0x430830", Offset = "0x42EE30", VA = "0x180430830", Slot = "71")]
	protected virtual void KeepEffect()
	{
		float num = this.timer;
		float deltaTime = Time.deltaTime;
		int num2 = 0;
		this.timer = num;
		if (num2 > (int)num)
		{
			float num3 = this.attackCount;
			this.attackCount = num3;
			this.BlowEffect();
			float num4 = this.attackCount;
			this.timer = 1f;
			int num5 = 0;
			base.Die((Plant.DieReason)num5);
		}
	}

	// Token: 0x0600104A RID: 4170 RVA: 0x0005DBE4 File Offset: 0x0005BDE4
	[Token(Token = "0x600104A")]
	[Address(RVA = "0x430570", Offset = "0x42EB70", VA = "0x180430570", Slot = "72")]
	protected virtual void BlowEffect()
	{
		int num;
		int num2;
		do
		{
			num = 0;
			List<Zombie> allZombies = Lawnf.GetAllZombies(false);
			num2 = 0;
			bool flag;
			if (flag)
			{
				while (flag <= true)
				{
				}
				int num3 = this.attackDamage;
				bool flag2;
				if (!flag2)
				{
				}
				num3 += num3;
				Vector3 vector;
				float z = vector.z;
			}
		}
		while (num2 != 0);
		if (num != 0)
		{
			uint num4;
			GameAPP.PlaySound((int)num4, 0.5f, 1f);
		}
	}

	// Token: 0x0600104B RID: 4171 RVA: 0x0005DC58 File Offset: 0x0005BE58
	[Token(Token = "0x600104B")]
	[Address(RVA = "0x41CBF0", Offset = "0x41B1F0", VA = "0x18041CBF0")]
	public DoomBlover()
	{
	}

	// Token: 0x04000B7B RID: 2939
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000B7B")]
	private float timer = 1f;

	// Token: 0x04000B7C RID: 2940
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x4000B7C")]
	private float attackCount;
}
