using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000661 RID: 1633
[Token(Token = "0x2000661")]
public class BlackFootballZombie_c2 : BlackFootballZombie_b
{
	// Token: 0x06001EE3 RID: 7907 RVA: 0x000A4884 File Offset: 0x000A2A84
	[Token(Token = "0x6001EE3")]
	[Address(RVA = "0x588A00", Offset = "0x587000", VA = "0x180588A00", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 0.1f;
	}

	// Token: 0x06001EE4 RID: 7908 RVA: 0x000A48A4 File Offset: 0x000A2AA4
	[Token(Token = "0x6001EE4")]
	[Address(RVA = "0x588960", Offset = "0x586F60", VA = "0x180588960", Slot = "24")]
	protected override void AttributeEvent()
	{
		float theSpeed = this.theSpeed;
		if (0 > (int)theSpeed || theSpeed > 1f)
		{
		}
		this.anim.SetTrigger("shoot");
	}

	// Token: 0x06001EE5 RID: 7909 RVA: 0x000A48E0 File Offset: 0x000A2AE0
	[Token(Token = "0x6001EE5")]
	[Address(RVA = "0x5887B0", Offset = "0x586DB0", VA = "0x1805887B0")]
	private void AnimShoot()
	{
		Transform shoot = this.shoot;
		int num = 0;
		if (!(shoot == num))
		{
			Transform shoot2 = this.shoot;
			CreateBullet instance = CreateBullet.Instance;
			Bullet bullet;
			bullet.Damage = 80;
			bullet.fromType = (PlantType)((ulong)268L);
		}
	}

	// Token: 0x06001EE6 RID: 7910 RVA: 0x000A4934 File Offset: 0x000A2B34
	[Token(Token = "0x6001EE6")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "56")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
	}

	// Token: 0x06001EE7 RID: 7911 RVA: 0x000A4944 File Offset: 0x000A2B44
	[Token(Token = "0x6001EE7")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x06001EE8 RID: 7912 RVA: 0x000A4954 File Offset: 0x000A2B54
	[Token(Token = "0x6001EE8")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06001EE9 RID: 7913 RVA: 0x000A4964 File Offset: 0x000A2B64
	[Token(Token = "0x6001EE9")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x06001EEA RID: 7914 RVA: 0x000A4974 File Offset: 0x000A2B74
	[Token(Token = "0x6001EEA")]
	[Address(RVA = "0x588630", Offset = "0x586C30", VA = "0x180588630")]
	public BlackFootballZombie_c2()
	{
	}
}
