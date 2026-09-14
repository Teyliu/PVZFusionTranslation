using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000558 RID: 1368
[Token(Token = "0x2000558")]
public class SeaStarfruit : StarFruit
{
	// Token: 0x0600196C RID: 6508 RVA: 0x000892AC File Offset: 0x000874AC
	[Token(Token = "0x600196C")]
	[Address(RVA = "0x4E08C0", Offset = "0x4DEEC0", VA = "0x1804E08C0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		base.AttributeCountdown = 60f;
	}

	// Token: 0x0600196D RID: 6509 RVA: 0x000892CC File Offset: 0x000874CC
	[Token(Token = "0x600196D")]
	[Address(RVA = "0x4E0660", Offset = "0x4DEC60", VA = "0x1804E0660", Slot = "40")]
	protected override void AttributeEvent()
	{
		if (this.growLevel == 0)
		{
			this.anim.SetTrigger("grow");
			GameAPP.PlaySound(56, 0.5f, 1f);
			return;
		}
	}

	// Token: 0x0600196E RID: 6510 RVA: 0x0008930C File Offset: 0x0008750C
	[Token(Token = "0x600196E")]
	[Address(RVA = "0x4E0700", Offset = "0x4DED00", VA = "0x1804E0700")]
	public void Grow()
	{
		this.anim.SetTrigger("grow");
		GameAPP.PlaySound(56, 0.5f, 1f);
	}

	// Token: 0x0600196F RID: 6511 RVA: 0x00089340 File Offset: 0x00087540
	[Token(Token = "0x600196F")]
	[Address(RVA = "0x4E0790", Offset = "0x4DED90", VA = "0x1804E0790", Slot = "73")]
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

	// Token: 0x06001970 RID: 6512 RVA: 0x00089388 File Offset: 0x00087588
	[Token(Token = "0x6001970")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public SeaStarfruit()
	{
	}

	// Token: 0x04000E40 RID: 3648
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E40")]
	private int growLevel;
}
