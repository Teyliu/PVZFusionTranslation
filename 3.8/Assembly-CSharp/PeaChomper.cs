using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200032E RID: 814
[Token(Token = "0x200032E")]
public class PeaChomper : Chomper
{
	// Token: 0x06000ED8 RID: 3800 RVA: 0x00056EC0 File Offset: 0x000550C0
	[Token(Token = "0x6000ED8")]
	[Address(RVA = "0x428370", Offset = "0x426970", VA = "0x180428370", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		float attributeCountdown = this.attributeCountdown;
		int num = 0;
		if (attributeCountdown > (float)num)
		{
		}
	}

	// Token: 0x06000ED9 RID: 3801 RVA: 0x00056EE0 File Offset: 0x000550E0
	[Token(Token = "0x6000ED9")]
	[Address(RVA = "0x428120", Offset = "0x426720", VA = "0x180428120")]
	public Bullet AnimShoot()
	{
		Transform transform = base.transform.Find("Shoot").transform;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		return bullet;
	}

	// Token: 0x06000EDA RID: 3802 RVA: 0x00056F24 File Offset: 0x00055124
	[Token(Token = "0x6000EDA")]
	[Address(RVA = "0x428280", Offset = "0x426880", VA = "0x180428280", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.Swallow();
		AdvantureMission.TryAddCount((AdvantureLevel)((uint)6));
		this.theStatus = (PlantStatus)((ulong)0L);
	}

	// Token: 0x06000EDB RID: 3803 RVA: 0x00056F48 File Offset: 0x00055148
	[Token(Token = "0x6000EDB")]
	[Address(RVA = "0x4282C0", Offset = "0x4268C0", VA = "0x1804282C0", Slot = "75")]
	protected override void ChompBack()
	{
		GameAPP.PlaySound(49, 0.5f, 1f);
		this.targetZombie = (ulong)0L;
		this.anim.SetTrigger("back");
		this.theStatus = (PlantStatus)((ulong)0L);
	}

	// Token: 0x06000EDC RID: 3804 RVA: 0x00056F90 File Offset: 0x00055190
	[Token(Token = "0x6000EDC")]
	[Address(RVA = "0x41A920", Offset = "0x418F20", VA = "0x18041A920")]
	public PeaChomper()
	{
		this.swallowMaxCountDown = 40f;
		base..ctor();
	}
}
