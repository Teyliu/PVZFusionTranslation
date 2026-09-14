using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200033E RID: 830
[Token(Token = "0x200033E")]
public class PeaChomper : Chomper
{
	// Token: 0x06000F22 RID: 3874 RVA: 0x00057F04 File Offset: 0x00056104
	[Token(Token = "0x6000F22")]
	[Address(RVA = "0x466E80", Offset = "0x465480", VA = "0x180466E80", Slot = "38")]
	protected override void OnUpdate()
	{
		float attributeCountdown = this.attributeCountdown;
		int num = 0;
		if (attributeCountdown > (float)num)
		{
		}
	}

	// Token: 0x06000F23 RID: 3875 RVA: 0x00057F20 File Offset: 0x00056120
	[Token(Token = "0x6000F23")]
	[Address(RVA = "0x466CD0", Offset = "0x4652D0", VA = "0x180466CD0", Slot = "76")]
	public virtual Bullet AnimShoot()
	{
		Transform transform = base.transform.Find("Shoot").transform;
		CreateBullet instance = CreateBullet.Instance;
		PlantType thePlantType = this.thePlantType;
		Bullet bullet;
		bullet.fromType = thePlantType;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		return bullet;
	}

	// Token: 0x06000F24 RID: 3876 RVA: 0x00057F78 File Offset: 0x00056178
	[Token(Token = "0x6000F24")]
	[Address(RVA = "0x466E40", Offset = "0x465440", VA = "0x180466E40", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.AttributeEvent();
		this.theStatus = (PlantStatus)((ulong)0L);
	}

	// Token: 0x06000F25 RID: 3877 RVA: 0x00057F94 File Offset: 0x00056194
	[Token(Token = "0x6000F25")]
	[Address(RVA = "0x466E60", Offset = "0x465460", VA = "0x180466E60", Slot = "75")]
	protected override void ChompBack()
	{
		base.ChompBack();
		this.theStatus = (PlantStatus)((ulong)0L);
	}

	// Token: 0x06000F26 RID: 3878 RVA: 0x00057FB0 File Offset: 0x000561B0
	[Token(Token = "0x6000F26")]
	[Address(RVA = "0x458C10", Offset = "0x457210", VA = "0x180458C10")]
	public PeaChomper()
	{
	}
}
