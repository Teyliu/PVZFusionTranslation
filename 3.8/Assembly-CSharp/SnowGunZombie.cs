using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006C6 RID: 1734
[Token(Token = "0x20006C6")]
public class SnowGunZombie : Zombie
{
	// Token: 0x06002211 RID: 8721 RVA: 0x000B2E2C File Offset: 0x000B102C
	[Token(Token = "0x6002211")]
	[Address(RVA = "0x56DCF0", Offset = "0x56C2F0", VA = "0x18056DCF0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 0.5f;
	}

	// Token: 0x06002212 RID: 8722 RVA: 0x000B2E4C File Offset: 0x000B104C
	[Token(Token = "0x6002212")]
	[Address(RVA = "0x56DD10", Offset = "0x56C310", VA = "0x18056DD10", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06002213 RID: 8723 RVA: 0x000B2E8C File Offset: 0x000B108C
	[Token(Token = "0x6002213")]
	[Address(RVA = "0x56E0C0", Offset = "0x56C6C0", VA = "0x18056E0C0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		Transform axis = this.axis;
		float plantMaxVisionX = this.board.plantMaxVisionX;
		this.SearchPlantUpdate();
	}

	// Token: 0x06002214 RID: 8724 RVA: 0x000B2EE8 File Offset: 0x000B10E8
	[Token(Token = "0x6002214")]
	[Address(RVA = "0x550020", Offset = "0x54E620", VA = "0x180550020", Slot = "54")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
		if (coldLevel > 0)
		{
			base.SetCold(time, coldLevel, freeze);
			return;
		}
	}

	// Token: 0x06002215 RID: 8725 RVA: 0x000B2F04 File Offset: 0x000B1104
	[Token(Token = "0x6002215")]
	[Address(RVA = "0x550040", Offset = "0x54E640", VA = "0x180550040", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		if (theFreezeLevel > 0)
		{
			int num = 0;
			base.SetFreeze(time, num);
			return;
		}
	}

	// Token: 0x06002216 RID: 8726 RVA: 0x000B2F20 File Offset: 0x000B1120
	[Token(Token = "0x6002216")]
	[Address(RVA = "0x56DC80", Offset = "0x56C280", VA = "0x18056DC80", Slot = "23")]
	protected override void AttributeEvent()
	{
		this.attributeCountDown = 1.5f;
		if (this.shooting)
		{
			this.anim.SetTrigger("shoot");
			return;
		}
	}

	// Token: 0x06002217 RID: 8727 RVA: 0x000B2F5C File Offset: 0x000B115C
	[Token(Token = "0x6002217")]
	[Address(RVA = "0x56DA10", Offset = "0x56C010", VA = "0x18056DA10")]
	private void AnimShoot()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Transform shoot2 = this.shoot;
		Bullet bullet;
		Transform transform = bullet.transform;
		Vector3 vector = this.targetPosition;
		Vector3 vector2;
		float y = vector2.y;
		Transform transform2 = bullet.transform;
		Vector2 gravity = Physics2D.gravity;
		bullet.detaVy = (float)0;
		bullet.Vx = vector;
		GameAPP.PlaySound((int)gravity.x, 0.5f, 1f);
		GameAPP.PlaySound(68, 0.5f, 1f);
	}

	// Token: 0x06002218 RID: 8728 RVA: 0x000B2FEC File Offset: 0x000B11EC
	[Token(Token = "0x6002218")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06002219 RID: 8729 RVA: 0x000B2FFC File Offset: 0x000B11FC
	[Token(Token = "0x6002219")]
	[Address(RVA = "0x56DDB0", Offset = "0x56C3B0", VA = "0x18056DDB0")]
	private void SearchPlantUpdate()
	{
		ulong num;
		do
		{
			int columnNum = this.board.columnNum;
			int theZombieRow = this.theZombieRow;
			List<Plant> list = Lawnf.Get1x1Plants(columnNum, theZombieRow);
			bool flag;
			if (flag)
			{
				bool flag2;
				while (flag2)
				{
				}
				Transform shoot = this.shoot;
				if (!this.shooting)
				{
					this.anim.SetBool("standing", true);
					this.shooting = true;
				}
				Vector3 vector;
				float z = vector.z;
				this.targetPosition.z = z;
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x0600221A RID: 8730 RVA: 0x000B30A4 File Offset: 0x000B12A4
	[Token(Token = "0x600221A")]
	[Address(RVA = "0x56E190", Offset = "0x56C790", VA = "0x18056E190")]
	public SnowGunZombie()
	{
	}

	// Token: 0x0400112C RID: 4396
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x400112C")]
	private bool shooting;

	// Token: 0x0400112D RID: 4397
	[FieldOffset(Offset = "0x25C")]
	[Token(Token = "0x400112D")]
	private Vector3 targetPosition;
}
