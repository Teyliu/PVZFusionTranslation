using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000613 RID: 1555
[Token(Token = "0x2000613")]
public class Tower_sunShroom : TowerProducer
{
	// Token: 0x06001D3F RID: 7487 RVA: 0x0009B814 File Offset: 0x00099A14
	[Token(Token = "0x6001D3F")]
	[Address(RVA = "0x57A640", Offset = "0x578C40", VA = "0x18057A640", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (PlantStatus)((ulong)34L);
		base.AttributeCountdown = 120f;
	}

	// Token: 0x06001D40 RID: 7488 RVA: 0x0009B83C File Offset: 0x00099A3C
	[Token(Token = "0x6001D40")]
	[Address(RVA = "0x57A620", Offset = "0x578C20", VA = "0x18057A620", Slot = "39")]
	protected override void AttributeEvent()
	{
		this.Grow();
	}

	// Token: 0x06001D41 RID: 7489 RVA: 0x0009B854 File Offset: 0x00099A54
	[Token(Token = "0x6001D41")]
	[Address(RVA = "0x57A680", Offset = "0x578C80", VA = "0x18057A680")]
	private void Grow()
	{
		Animator anim = this.anim;
		this.theStatus = (PlantStatus)((ulong)0L);
		anim.SetTrigger("grow");
		GameAPP.PlaySound(56, 0.5f, 1f);
	}

	// Token: 0x06001D42 RID: 7490 RVA: 0x0009B894 File Offset: 0x00099A94
	[Token(Token = "0x6001D42")]
	[Address(RVA = "0x57A710", Offset = "0x578D10", VA = "0x18057A710", Slot = "75")]
	protected override void ProduceSun()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.3f, 1f);
		CreateItem instance = CreateItem.Instance;
		CreateItem instance2 = CreateItem.Instance;
	}

	// Token: 0x06001D43 RID: 7491 RVA: 0x0009B8DC File Offset: 0x00099ADC
	[Token(Token = "0x6001D43")]
	[Address(RVA = "0x57A8F0", Offset = "0x578EF0", VA = "0x18057A8F0", Slot = "73")]
	public override void Upgrade(TowerUpgradeType towerUpgradeType)
	{
		this.Grow();
		this.ProduceSun();
		float attackSpeed = this.attackSpeed;
		this.attackSpeed = attackSpeed;
	}

	// Token: 0x06001D44 RID: 7492 RVA: 0x0009B904 File Offset: 0x00099B04
	[Token(Token = "0x6001D44")]
	[Address(RVA = "0x578AF0", Offset = "0x5770F0", VA = "0x180578AF0")]
	public Tower_sunShroom()
	{
	}
}
