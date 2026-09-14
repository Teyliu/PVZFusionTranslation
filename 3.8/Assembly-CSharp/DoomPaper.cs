using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200064B RID: 1611
[Token(Token = "0x200064B")]
public class DoomPaper : ElitePaperZombie
{
	// Token: 0x06001E97 RID: 7831 RVA: 0x000A389C File Offset: 0x000A1A9C
	[Token(Token = "0x6001E97")]
	[Address(RVA = "0x53CC90", Offset = "0x53B290", VA = "0x18053CC90", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		Action action = delegate
		{
			GameObject gameObject = this.head;
			int num = 0;
			if (gameObject != num)
			{
				GameObject gameObject2 = this.head;
				int num2 = 0;
				gameObject2.SetActive(num2 != 0);
			}
			GameObject gameObject3 = this.head_angry;
			int num3 = 0;
			if (gameObject3 != num3)
			{
				this.head_angry.SetActive(true);
			}
			this.attributeCountDown = 0.1f;
		};
		this.defaultAction = action;
	}

	// Token: 0x06001E98 RID: 7832 RVA: 0x000A38C4 File Offset: 0x000A1AC4
	[Token(Token = "0x6001E98")]
	[Address(RVA = "0x53CC30", Offset = "0x53B230", VA = "0x18053CC30", Slot = "23")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("shoot");
		this.attributeCountDown = 0.5f;
	}

	// Token: 0x06001E99 RID: 7833 RVA: 0x000A38F4 File Offset: 0x000A1AF4
	[Token(Token = "0x6001E99")]
	[Address(RVA = "0x534700", Offset = "0x532D00", VA = "0x180534700", Slot = "64")]
	protected override void SecondArmorBroken()
	{
	}

	// Token: 0x06001E9A RID: 7834 RVA: 0x000A3904 File Offset: 0x000A1B04
	[Token(Token = "0x6001E9A")]
	[Address(RVA = "0x53CA80", Offset = "0x53B080", VA = "0x18053CA80")]
	private void AnimShoot()
	{
		Towards towards = this.towards;
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Transform shoot2 = this.shoot;
		Bullet bullet;
		bullet.Damage = 9;
		bullet.from_zombie = this;
		bullet.shootByZombie = true;
	}

	// Token: 0x06001E9B RID: 7835 RVA: 0x000A3950 File Offset: 0x000A1B50
	[Token(Token = "0x6001E9B")]
	[Address(RVA = "0x534450", Offset = "0x532A50", VA = "0x180534450")]
	public DoomPaper()
	{
	}

	// Token: 0x0400105A RID: 4186
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x400105A")]
	public GameObject head;

	// Token: 0x0400105B RID: 4187
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x400105B")]
	public GameObject head_angry;
}
