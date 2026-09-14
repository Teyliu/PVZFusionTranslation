using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006FE RID: 1790
[Token(Token = "0x20006FE")]
public class SnowGunZombie : Zombie
{
	// Token: 0x0600232C RID: 9004 RVA: 0x000B7C20 File Offset: 0x000B5E20
	[Token(Token = "0x600232C")]
	[Address(RVA = "0x5D19E0", Offset = "0x5CFFE0", VA = "0x1805D19E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 0.5f;
	}

	// Token: 0x0600232D RID: 9005 RVA: 0x000B7C40 File Offset: 0x000B5E40
	[Token(Token = "0x600232D")]
	[Address(RVA = "0x5D1A00", Offset = "0x5D0000", VA = "0x1805D1A00", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x0600232E RID: 9006 RVA: 0x000B7C80 File Offset: 0x000B5E80
	[Token(Token = "0x600232E")]
	[Address(RVA = "0x5D1DB0", Offset = "0x5D03B0", VA = "0x1805D1DB0", Slot = "17")]
	protected override void Update()
	{
		base.Update();
		Transform axis = this.axis;
		float plantMaxVisionX = this.board.plantMaxVisionX;
		this.SearchPlantUpdate();
	}

	// Token: 0x0600232F RID: 9007 RVA: 0x000B7CDC File Offset: 0x000B5EDC
	[Token(Token = "0x600232F")]
	[Address(RVA = "0x5B3BB0", Offset = "0x5B21B0", VA = "0x1805B3BB0", Slot = "56")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
		if (coldLevel > 0)
		{
			base.SetCold(time, coldLevel, freeze);
			return;
		}
	}

	// Token: 0x06002330 RID: 9008 RVA: 0x000B7CF8 File Offset: 0x000B5EF8
	[Token(Token = "0x6002330")]
	[Address(RVA = "0x5B3BD0", Offset = "0x5B21D0", VA = "0x1805B3BD0", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		if (theFreezeLevel > 0)
		{
			int num = 0;
			base.SetFreeze(time, num);
			return;
		}
	}

	// Token: 0x06002331 RID: 9009 RVA: 0x000B7D14 File Offset: 0x000B5F14
	[Token(Token = "0x6002331")]
	[Address(RVA = "0x5D1970", Offset = "0x5CFF70", VA = "0x1805D1970", Slot = "24")]
	protected override void AttributeEvent()
	{
		this.attributeCountDown = 5f;
		if (this.shooting)
		{
			this.anim.SetTrigger("shoot");
			return;
		}
	}

	// Token: 0x06002332 RID: 9010 RVA: 0x000B7D50 File Offset: 0x000B5F50
	[Token(Token = "0x6002332")]
	[Address(RVA = "0x5D16E0", Offset = "0x5CFCE0", VA = "0x1805D16E0")]
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
		Vector2 gravity2 = Physics2D.gravity;
		bullet.acceleration.y = (float)0;
		bullet.velocity = vector;
		GameAPP.PlaySound((int)gravity2.x, 0.5f, 1f);
		GameAPP.PlaySound(68, 0.5f, 1f);
	}

	// Token: 0x06002333 RID: 9011 RVA: 0x000B7DEC File Offset: 0x000B5FEC
	[Token(Token = "0x6002333")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06002334 RID: 9012 RVA: 0x000B7DFC File Offset: 0x000B5FFC
	[Token(Token = "0x6002334")]
	[Address(RVA = "0x5D1AA0", Offset = "0x5D00A0", VA = "0x1805D1AA0")]
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

	// Token: 0x06002335 RID: 9013 RVA: 0x000B7EA4 File Offset: 0x000B60A4
	[Token(Token = "0x6002335")]
	[Address(RVA = "0x5D1E80", Offset = "0x5D0480", VA = "0x1805D1E80")]
	public SnowGunZombie()
	{
	}

	// Token: 0x040011FA RID: 4602
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x40011FA")]
	private bool shooting;

	// Token: 0x040011FB RID: 4603
	[FieldOffset(Offset = "0x27C")]
	[Token(Token = "0x40011FB")]
	private Vector3 targetPosition;
}
