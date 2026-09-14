using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200067E RID: 1662
[Token(Token = "0x200067E")]
public class DolphinGatlingZombie : PeaDolphinriderZombie
{
	// Token: 0x06001F86 RID: 8070 RVA: 0x000A7A10 File Offset: 0x000A5C10
	[Token(Token = "0x6001F86")]
	[Address(RVA = "0x59DF20", Offset = "0x59C520", VA = "0x18059DF20", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		GameAPP.PlaySound(78, 1f, 1f);
		Animator anim = this.anim;
		this.theStatus = (ZombieStatus)((ulong)8L);
		anim.Play("ride");
		this.inWater = true;
		base.SetMaskLayer();
		GameObject gameObject = this.head1;
		this.attributeCountDown = 0.5f;
		int num = 0;
		if (gameObject != num)
		{
			this.head1.SetActive(true);
		}
		GameObject gameObject2 = this.head2;
		int num2 = 0;
		if (gameObject2 != num2)
		{
			GameObject gameObject3 = this.head2;
			int num3 = 0;
			gameObject3.SetActive(num3 != 0);
		}
	}

	// Token: 0x06001F87 RID: 8071 RVA: 0x000A7AC4 File Offset: 0x000A5CC4
	[Token(Token = "0x6001F87")]
	[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "79")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_superCherry;
	}

	// Token: 0x06001F88 RID: 8072 RVA: 0x000A7AD4 File Offset: 0x000A5CD4
	[Token(Token = "0x6001F88")]
	[Address(RVA = "0x59DF10", Offset = "0x59C510", VA = "0x18059DF10", Slot = "78")]
	protected override int GetDamage()
	{
		return 300;
	}

	// Token: 0x06001F89 RID: 8073 RVA: 0x000A7AE8 File Offset: 0x000A5CE8
	[Token(Token = "0x6001F89")]
	[Address(RVA = "0x59DE30", Offset = "0x59C430", VA = "0x18059DE30", Slot = "24")]
	protected override void AttributeEvent()
	{
		GameObject gameObject = this.head1;
		int num = 0;
		if (gameObject != num)
		{
			this.head1.SetActive(true);
		}
		GameObject gameObject2 = this.head2;
		int num2 = 0;
		if (gameObject2 != num2)
		{
			GameObject gameObject3 = this.head2;
			int num3 = 0;
			gameObject3.SetActive(num3 != 0);
		}
		base.AttributeEvent();
		this.attributeCountDown = 1.5f;
	}

	// Token: 0x06001F8A RID: 8074 RVA: 0x000A7B54 File Offset: 0x000A5D54
	[Token(Token = "0x6001F8A")]
	[Address(RVA = "0x59E0F0", Offset = "0x59C6F0", VA = "0x18059E0F0")]
	public DolphinGatlingZombie()
	{
	}

	// Token: 0x04001120 RID: 4384
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x4001120")]
	public GameObject head1;

	// Token: 0x04001121 RID: 4385
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x4001121")]
	public GameObject head2;
}
