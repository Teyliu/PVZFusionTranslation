using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000582 RID: 1410
[Token(Token = "0x2000582")]
public class ScaredyShroom : Shooter
{
	// Token: 0x06001A2B RID: 6699 RVA: 0x0008CA8C File Offset: 0x0008AC8C
	[Token(Token = "0x6001A2B")]
	[Address(RVA = "0x53D0B0", Offset = "0x53B6B0", VA = "0x18053D0B0", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (base.PumpkinType != PlantType.ScaredyPumpkin)
		{
		}
		Animator anim = this.anim;
		int num = 0;
		anim.SetBool("NearZombie", num != 0);
	}

	// Token: 0x06001A2C RID: 6700 RVA: 0x0008CAC8 File Offset: 0x0008ACC8
	[Token(Token = "0x6001A2C")]
	[Address(RVA = "0x53D140", Offset = "0x53B740", VA = "0x18053D140", Slot = "72")]
	protected virtual void GetNearZombies()
	{
		Transform axis = this.axis;
		int num = 0;
		Transform axis2 = this.axis;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (!flag || flag > true)
			{
			}
			num++;
			ulong num3;
			this.anim.SetBool("NearZombie", num3 != 0UL);
			this.ScaredEvent();
			return;
		}
		Animator anim = this.anim;
		int num4 = 0;
		anim.SetBool("NearZombie", num4 != 0);
		throw new NullReferenceException();
	}

	// Token: 0x06001A2D RID: 6701 RVA: 0x0008CB44 File Offset: 0x0008AD44
	[Token(Token = "0x6001A2D")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	protected virtual void ScaredEvent()
	{
	}

	// Token: 0x06001A2E RID: 6702 RVA: 0x0008CB54 File Offset: 0x0008AD54
	[Token(Token = "0x6001A2E")]
	[Address(RVA = "0x53D350", Offset = "0x53B950", VA = "0x18053D350", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform transform = base.transform.Find("Shoot").transform;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		GameAPP.PlaySound(57, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x06001A2F RID: 6703 RVA: 0x0008CBBC File Offset: 0x0008ADBC
	[Token(Token = "0x6001A2F")]
	[Address(RVA = "0x53D4B0", Offset = "0x53BAB0", VA = "0x18053D4B0", Slot = "46")]
	protected override bool Shootable()
	{
		Board board = this.board;
		return base.Shootable();
	}

	// Token: 0x06001A30 RID: 6704 RVA: 0x0008CBE0 File Offset: 0x0008ADE0
	[Token(Token = "0x6001A30")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public ScaredyShroom()
	{
	}
}
