using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000553 RID: 1363
[Token(Token = "0x2000553")]
public class ScaredyShroom : Shooter
{
	// Token: 0x0600194F RID: 6479 RVA: 0x00088B20 File Offset: 0x00086D20
	[Token(Token = "0x600194F")]
	[Address(RVA = "0x4DEFB0", Offset = "0x4DD5B0", VA = "0x1804DEFB0", Slot = "17")]
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

	// Token: 0x06001950 RID: 6480 RVA: 0x00088B5C File Offset: 0x00086D5C
	[Token(Token = "0x6001950")]
	[Address(RVA = "0x4DF040", Offset = "0x4DD640", VA = "0x1804DF040", Slot = "73")]
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

	// Token: 0x06001951 RID: 6481 RVA: 0x00088BD8 File Offset: 0x00086DD8
	[Token(Token = "0x6001951")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "74")]
	protected virtual void ScaredEvent()
	{
	}

	// Token: 0x06001952 RID: 6482 RVA: 0x00088BE8 File Offset: 0x00086DE8
	[Token(Token = "0x6001952")]
	[Address(RVA = "0x4DF250", Offset = "0x4DD850", VA = "0x1804DF250", Slot = "69")]
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

	// Token: 0x06001953 RID: 6483 RVA: 0x00088C50 File Offset: 0x00086E50
	[Token(Token = "0x6001953")]
	[Address(RVA = "0x4DF3B0", Offset = "0x4DD9B0", VA = "0x1804DF3B0", Slot = "47")]
	protected override bool Shootable()
	{
		Board board = this.board;
		return base.Shootable();
	}

	// Token: 0x06001954 RID: 6484 RVA: 0x00088C74 File Offset: 0x00086E74
	[Token(Token = "0x6001954")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public ScaredyShroom()
	{
	}
}
