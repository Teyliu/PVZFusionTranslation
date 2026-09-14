using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000387 RID: 903
[Token(Token = "0x2000387")]
public class DoomBlover : Blover
{
	// Token: 0x06001092 RID: 4242 RVA: 0x0005EAC8 File Offset: 0x0005CCC8
	[Token(Token = "0x6001092")]
	[Address(RVA = "0x480D10", Offset = "0x47F310", VA = "0x180480D10", Slot = "68")]
	protected override void AnimBlow()
	{
		GameAPP.PlaySound(87, 0.5f, 1f);
		base.BlowZombie();
		GameObject fog = this.board.fog;
		int num = 0;
		if (fog != num)
		{
			FogMgr.Instance.Blown();
		}
		base.Invoke("DelayDie", 1f);
		this.theStatus = (PlantStatus)((ulong)25L);
	}

	// Token: 0x06001093 RID: 4243 RVA: 0x0005EB30 File Offset: 0x0005CD30
	[Token(Token = "0x6001093")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20")]
	protected new void DelayDie()
	{
	}

	// Token: 0x06001094 RID: 4244 RVA: 0x0005EB40 File Offset: 0x0005CD40
	[Token(Token = "0x6001094")]
	[Address(RVA = "0x4811A0", Offset = "0x47F7A0", VA = "0x1804811A0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
		}
	}

	// Token: 0x06001095 RID: 4245 RVA: 0x0005EB60 File Offset: 0x0005CD60
	[Token(Token = "0x6001095")]
	[Address(RVA = "0x481100", Offset = "0x47F700", VA = "0x180481100", Slot = "70")]
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

	// Token: 0x06001096 RID: 4246 RVA: 0x0005EBC0 File Offset: 0x0005CDC0
	[Token(Token = "0x6001096")]
	[Address(RVA = "0x480E30", Offset = "0x47F430", VA = "0x180480E30", Slot = "71")]
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
				Vector3 vector;
				float z = vector.z;
			}
		}
		while (num2 != 0);
		if (num != 0)
		{
			GameAPP.PlaySound(70, 0.5f, 1f);
		}
	}

	// Token: 0x06001097 RID: 4247 RVA: 0x0005EC20 File Offset: 0x0005CE20
	[Token(Token = "0x6001097")]
	[Address(RVA = "0x4811F0", Offset = "0x47F7F0", VA = "0x1804811F0")]
	public DoomBlover()
	{
	}

	// Token: 0x04000BCB RID: 3019
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000BCB")]
	private float timer = 1f;

	// Token: 0x04000BCC RID: 3020
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x4000BCC")]
	private float attackCount;
}
