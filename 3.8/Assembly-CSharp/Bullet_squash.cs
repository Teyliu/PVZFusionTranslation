using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020001AA RID: 426
[Token(Token = "0x20001AA")]
public class Bullet_squash : Bullet
{
	// Token: 0x06000766 RID: 1894 RVA: 0x00026238 File Offset: 0x00024438
	[Token(Token = "0x6000766")]
	[Address(RVA = "0x7E4820", Offset = "0x7E2E20", VA = "0x1807E4820", Slot = "8")]
	public override void InitData()
	{
		base.InitData();
		this.col.enabled = 2.3509887E-38f != null;
		Vector2 gravity = Physics2D.gravity;
		this.detaVy = (float)0;
		float num = global::UnityEngine.Random.Range(1.8f, 2.3509887E-38f);
		this.Vx = num;
	}

	// Token: 0x06000767 RID: 1895 RVA: 0x00026288 File Offset: 0x00024488
	[Token(Token = "0x6000767")]
	[Address(RVA = "0x7E4710", Offset = "0x7E2D10", VA = "0x1807E4710", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int num = 0;
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, fromType, num2 != 0UL);
		base.MoveWay = (BulletMoveWay)((uint)(-1));
		int theZombieRow = zombie.theZombieRow;
		SortingGroup sortingGroup = this.sortingGroup;
		this.theBulletRow = theZombieRow;
		string text = string.Format("bullet{0}", theZombieRow);
		sortingGroup.sortingLayerName = text;
		Collider2D col = this.col;
		int num3 = 0;
		col.enabled = num3 != 0;
		base.PlaySound(zombie);
	}

	// Token: 0x06000768 RID: 1896 RVA: 0x00026308 File Offset: 0x00024508
	[Token(Token = "0x6000768")]
	[Address(RVA = "0x7E4690", Offset = "0x7E2C90", VA = "0x1807E4690", Slot = "18")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x06000769 RID: 1897 RVA: 0x00026334 File Offset: 0x00024534
	[Token(Token = "0x6000769")]
	[Address(RVA = "0x7E48D0", Offset = "0x7E2ED0", VA = "0x1807E48D0", Slot = "12")]
	public override void JumpLand()
	{
		base.JumpLand();
	}

	// Token: 0x0600076A RID: 1898 RVA: 0x00026348 File Offset: 0x00024548
	[Token(Token = "0x600076A")]
	[Address(RVA = "0x7E4480", Offset = "0x7E2A80", VA = "0x1807E4480", Slot = "27")]
	protected virtual void AttackZombie()
	{
		int num = 0;
		Transform transform = base.transform;
		int num2 = this.zombieLayer;
		int num3 = 0;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int theBulletRow = this.theBulletRow;
				PlantType fromType = this.fromType;
			}
			num++;
		}
		if (num3 != 0)
		{
			uint num4;
			GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num4), 0.5f, 1f);
		}
	}

	// Token: 0x0600076B RID: 1899 RVA: 0x000263B4 File Offset: 0x000245B4
	[Token(Token = "0x600076B")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_squash()
	{
	}
}
