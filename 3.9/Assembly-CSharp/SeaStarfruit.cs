using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000587 RID: 1415
[Token(Token = "0x2000587")]
public class SeaStarfruit : StarFruit
{
	// Token: 0x06001A48 RID: 6728 RVA: 0x0008D21C File Offset: 0x0008B41C
	[Token(Token = "0x6001A48")]
	[Address(RVA = "0x53E9D0", Offset = "0x53CFD0", VA = "0x18053E9D0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		base.AttributeCountdown = 60f;
	}

	// Token: 0x06001A49 RID: 6729 RVA: 0x0008D23C File Offset: 0x0008B43C
	[Token(Token = "0x6001A49")]
	[Address(RVA = "0x53E770", Offset = "0x53CD70", VA = "0x18053E770", Slot = "39")]
	protected override void AttributeEvent()
	{
		if (this.growLevel == 0)
		{
			this.anim.SetTrigger("grow");
			GameAPP.PlaySound(56, 0.5f, 1f);
			return;
		}
	}

	// Token: 0x06001A4A RID: 6730 RVA: 0x0008D27C File Offset: 0x0008B47C
	[Token(Token = "0x6001A4A")]
	[Address(RVA = "0x53E810", Offset = "0x53CE10", VA = "0x18053E810")]
	public void Grow()
	{
		this.anim.SetTrigger("grow");
		GameAPP.PlaySound(56, 0.5f, 1f);
	}

	// Token: 0x06001A4B RID: 6731 RVA: 0x0008D2B0 File Offset: 0x0008B4B0
	[Token(Token = "0x6001A4B")]
	[Address(RVA = "0x53E8A0", Offset = "0x53CEA0", VA = "0x18053E8A0", Slot = "72")]
	protected override void SetBullet(Transform _transform, BulletMoveWay theMovingWay)
	{
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		Transform transform = bullet.transform;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x06001A4C RID: 6732 RVA: 0x0008D2F8 File Offset: 0x0008B4F8
	[Token(Token = "0x6001A4C")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public SeaStarfruit()
	{
	}

	// Token: 0x04000EFE RID: 3838
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000EFE")]
	private int growLevel;
}
