using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000681 RID: 1665
[Token(Token = "0x2000681")]
public class DoomPaper : ElitePaperZombie
{
	// Token: 0x06001F99 RID: 8089 RVA: 0x000A7FEC File Offset: 0x000A61EC
	[Token(Token = "0x6001F99")]
	[Address(RVA = "0x59F280", Offset = "0x59D880", VA = "0x18059F280", Slot = "10")]
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

	// Token: 0x06001F9A RID: 8090 RVA: 0x000A8014 File Offset: 0x000A6214
	[Token(Token = "0x6001F9A")]
	[Address(RVA = "0x59F220", Offset = "0x59D820", VA = "0x18059F220", Slot = "24")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("shoot");
		this.attributeCountDown = 0.5f;
	}

	// Token: 0x06001F9B RID: 8091 RVA: 0x000A8044 File Offset: 0x000A6244
	[Token(Token = "0x6001F9B")]
	[Address(RVA = "0x58B3E0", Offset = "0x5899E0", VA = "0x18058B3E0", Slot = "66")]
	protected override void SecondArmorBroken()
	{
	}

	// Token: 0x06001F9C RID: 8092 RVA: 0x000A8054 File Offset: 0x000A6254
	[Token(Token = "0x6001F9C")]
	[Address(RVA = "0x59F070", Offset = "0x59D670", VA = "0x18059F070")]
	private void AnimShoot()
	{
		Towards towards = this.towards;
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Transform shoot2 = this.shoot;
		Bullet bullet;
		bullet.Damage = 6;
		bullet.from_zombie = this;
		bullet.shootByZombie = true;
	}

	// Token: 0x06001F9D RID: 8093 RVA: 0x000A809C File Offset: 0x000A629C
	[Token(Token = "0x6001F9D")]
	[Address(RVA = "0x58B130", Offset = "0x589730", VA = "0x18058B130")]
	public DoomPaper()
	{
	}

	// Token: 0x04001126 RID: 4390
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001126")]
	public GameObject head;

	// Token: 0x04001127 RID: 4391
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4001127")]
	public GameObject head_angry;
}
