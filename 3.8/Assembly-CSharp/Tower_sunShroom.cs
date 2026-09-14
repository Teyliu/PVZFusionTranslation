using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005DE RID: 1502
[Token(Token = "0x20005DE")]
public class Tower_sunShroom : TowerProducer
{
	// Token: 0x06001C40 RID: 7232 RVA: 0x00096C84 File Offset: 0x00094E84
	[Token(Token = "0x6001C40")]
	[Address(RVA = "0x512D00", Offset = "0x511300", VA = "0x180512D00", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.SetSpeed(1f);
		this.theStatus = (PlantStatus)((ulong)34L);
		base.AttributeCountdown = 120f;
	}

	// Token: 0x06001C41 RID: 7233 RVA: 0x00096CB8 File Offset: 0x00094EB8
	[Token(Token = "0x6001C41")]
	[Address(RVA = "0x512CE0", Offset = "0x5112E0", VA = "0x180512CE0", Slot = "40")]
	protected override void AttributeEvent()
	{
		this.Grow();
	}

	// Token: 0x06001C42 RID: 7234 RVA: 0x00096CD0 File Offset: 0x00094ED0
	[Token(Token = "0x6001C42")]
	[Address(RVA = "0x512D50", Offset = "0x511350", VA = "0x180512D50")]
	private void Grow()
	{
		Animator anim = this.anim;
		this.theStatus = (PlantStatus)((ulong)0L);
		anim.SetTrigger("grow");
		GameAPP.PlaySound(56, 0.5f, 1f);
	}

	// Token: 0x06001C43 RID: 7235 RVA: 0x00096D10 File Offset: 0x00094F10
	[Token(Token = "0x6001C43")]
	[Address(RVA = "0x512DE0", Offset = "0x5113E0", VA = "0x180512DE0", Slot = "76")]
	protected override void ProduceSun()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.3f, 1f);
		CreateItem instance = CreateItem.Instance;
		CreateItem instance2 = CreateItem.Instance;
	}

	// Token: 0x06001C44 RID: 7236 RVA: 0x00096D58 File Offset: 0x00094F58
	[Token(Token = "0x6001C44")]
	[Address(RVA = "0x512FC0", Offset = "0x5115C0", VA = "0x180512FC0", Slot = "74")]
	public override void Upgrade(TowerUpgradeType towerUpgradeType)
	{
		this.Grow();
		this.ProduceSun();
		float attackSpeed = this.attackSpeed;
		this.attackSpeed = attackSpeed;
	}

	// Token: 0x06001C45 RID: 7237 RVA: 0x00096D80 File Offset: 0x00094F80
	[Token(Token = "0x6001C45")]
	[Address(RVA = "0x50C640", Offset = "0x50AC40", VA = "0x18050C640")]
	public Tower_sunShroom()
	{
		this.towards = (Towards)((ulong)1L);
		this.basicDamage = 1f;
		this.attackSpeed = 1f;
		base..ctor();
	}
}
