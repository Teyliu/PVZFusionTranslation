using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000648 RID: 1608
[Token(Token = "0x2000648")]
public class DolphinGatlingZombie : PeaDolphinriderZombie
{
	// Token: 0x06001E84 RID: 7812 RVA: 0x000A32C0 File Offset: 0x000A14C0
	[Token(Token = "0x6001E84")]
	[Address(RVA = "0x53B930", Offset = "0x539F30", VA = "0x18053B930", Slot = "15")]
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

	// Token: 0x06001E85 RID: 7813 RVA: 0x000A3374 File Offset: 0x000A1574
	[Token(Token = "0x6001E85")]
	[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "77")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_superCherry;
	}

	// Token: 0x06001E86 RID: 7814 RVA: 0x000A3384 File Offset: 0x000A1584
	[Token(Token = "0x6001E86")]
	[Address(RVA = "0x53B920", Offset = "0x539F20", VA = "0x18053B920", Slot = "76")]
	protected override int GetDamage()
	{
		return 300;
	}

	// Token: 0x06001E87 RID: 7815 RVA: 0x000A3398 File Offset: 0x000A1598
	[Token(Token = "0x6001E87")]
	[Address(RVA = "0x53B840", Offset = "0x539E40", VA = "0x18053B840", Slot = "23")]
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

	// Token: 0x06001E88 RID: 7816 RVA: 0x000A3404 File Offset: 0x000A1604
	[Token(Token = "0x6001E88")]
	[Address(RVA = "0x53BB00", Offset = "0x53A100", VA = "0x18053BB00")]
	public DolphinGatlingZombie()
	{
	}

	// Token: 0x04001054 RID: 4180
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001054")]
	public GameObject head1;

	// Token: 0x04001055 RID: 4181
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4001055")]
	public GameObject head2;
}
