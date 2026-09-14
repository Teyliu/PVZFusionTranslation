using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200042F RID: 1071
[Token(Token = "0x200042F")]
public class SeaChomper : Chomper
{
	// Token: 0x1700013C RID: 316
	// (get) Token: 0x060013BD RID: 5053 RVA: 0x0006E7C8 File Offset: 0x0006C9C8
	// (set) Token: 0x060013BE RID: 5054 RVA: 0x0006E7DC File Offset: 0x0006C9DC
	[Token(Token = "0x1700013C")]
	public override float ChompRange
	{
		[Token(Token = "0x60013BD")]
		[Address(RVA = "0x4BB270", Offset = "0x4B9870", VA = "0x1804BB270", Slot = "68")]
		get
		{
			float num;
			return num;
		}
		[Token(Token = "0x60013BE")]
		[Address(RVA = "0x468010", Offset = "0x466610", VA = "0x180468010", Slot = "69")]
		set
		{
			this.<ChompRange>k__BackingField = value;
		}
	}

	// Token: 0x060013BF RID: 5055 RVA: 0x0006E7F0 File Offset: 0x0006C9F0
	[Token(Token = "0x60013BF")]
	[Address(RVA = "0x4BB0A0", Offset = "0x4B96A0", VA = "0x1804BB0A0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.UpdateScale();
	}

	// Token: 0x060013C0 RID: 5056 RVA: 0x0006E80C File Offset: 0x0006CA0C
	[Token(Token = "0x60013C0")]
	[Address(RVA = "0x4BB0C0", Offset = "0x4B96C0", VA = "0x1804BB0C0", Slot = "70")]
	protected override void Swallow()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x060013C1 RID: 5057 RVA: 0x0006E82C File Offset: 0x0006CA2C
	[Token(Token = "0x60013C1")]
	[Address(RVA = "0x4BB180", Offset = "0x4B9780", VA = "0x1804BB180")]
	private void UpdateScale()
	{
		int attributeCount = this.attributeCount;
		uint num;
		num -= (uint)attributeCount;
		float num3;
		float num2 = Mathf.Min(num3, 0.5f);
		this.isShort = false;
	}

	// Token: 0x060013C2 RID: 5058 RVA: 0x0006E858 File Offset: 0x0006CA58
	[Token(Token = "0x60013C2")]
	[Address(RVA = "0x4BAEF0", Offset = "0x4B94F0", VA = "0x1804BAEF0", Slot = "73")]
	public override void BiteEvent()
	{
		Zombie targetZombie = this.targetZombie;
		int num = 0;
		if (targetZombie != num)
		{
			int theZombieType = (int)this.targetZombie.theZombieType;
			bool flag;
			if (flag)
			{
			}
			int theZombieType2 = (int)this.targetZombie.theZombieType;
			bool flag2;
			if (!flag2 && this.targetZombie.theStatus > ZombieStatus.Pol_run)
			{
				Zombie targetZombie2 = this.targetZombie;
				if (targetZombie2.isMindControlled || !targetZombie2.beforeDying)
				{
				}
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x060013C3 RID: 5059 RVA: 0x0006E8CC File Offset: 0x0006CACC
	[Token(Token = "0x60013C3")]
	[Address(RVA = "0x458C10", Offset = "0x457210", VA = "0x180458C10")]
	public SeaChomper()
	{
	}
}
