using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200016A RID: 362
[Token(Token = "0x200016A")]
public class Bullet_lourCactus : Bullet
{
	// Token: 0x06000676 RID: 1654 RVA: 0x0002175C File Offset: 0x0001F95C
	[Token(Token = "0x6000676")]
	[Address(RVA = "0x6F49E0", Offset = "0x6F2FE0", VA = "0x1806F49E0", Slot = "9")]
	public override void InitData()
	{
		base.InitData();
		this.lourTimer = 0f;
	}

	// Token: 0x06000677 RID: 1655 RVA: 0x0002177C File Offset: 0x0001F97C
	[Token(Token = "0x6000677")]
	[Address(RVA = "0x6F4A00", Offset = "0x6F3000", VA = "0x1806F4A00", Slot = "12")]
	protected override void Update()
	{
		base.Update();
		float deltaTime = Time.deltaTime;
		this.lourTimer = deltaTime;
		if (deltaTime > 0.2f)
		{
			int num = 0;
			base.MoveWay = (BulletMoveWay)num;
		}
	}

	// Token: 0x06000678 RID: 1656 RVA: 0x000217B0 File Offset: 0x0001F9B0
	[Token(Token = "0x6000678")]
	[Address(RVA = "0x6F4900", Offset = "0x6F2F00", VA = "0x1806F4900", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		bool beforeDying = zombie.beforeDying;
		long theHealth = zombie.theHealth;
		base.HitZombie(zombie);
		if ((!beforeDying && zombie.beforeDying != beforeDying) || !zombie.beforeDying)
		{
			CattailLour cattailLour = this.lour;
			int num = 0;
			if (cattailLour != num)
			{
				CattailLour cattailLour2 = this.lour;
				int num2 = 0;
				cattailLour2.Supply(num2 != 0);
			}
		}
	}

	// Token: 0x06000679 RID: 1657 RVA: 0x00021818 File Offset: 0x0001FA18
	[Token(Token = "0x6000679")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_lourCactus()
	{
	}

	// Token: 0x0400037D RID: 893
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x400037D")]
	public CattailLour lour;

	// Token: 0x0400037E RID: 894
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x400037E")]
	private float lourTimer;
}
