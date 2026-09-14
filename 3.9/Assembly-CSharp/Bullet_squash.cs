using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020001B1 RID: 433
[Token(Token = "0x20001B1")]
public class Bullet_squash : Bullet
{
	// Token: 0x06000773 RID: 1907 RVA: 0x00025B28 File Offset: 0x00023D28
	[Token(Token = "0x6000773")]
	[Address(RVA = "0x811F20", Offset = "0x810520", VA = "0x180811F20", Slot = "9")]
	public override void InitData()
	{
		base.InitData();
		this.col.enabled = 2.3509887E-38f != null;
		Vector2 gravity = Physics2D.gravity;
		this.velocity.y = (float)0;
		float num = global::UnityEngine.Random.Range(1.8f, 2.3509887E-38f);
		this.velocity = num;
	}

	// Token: 0x06000774 RID: 1908 RVA: 0x00025B7C File Offset: 0x00023D7C
	[Token(Token = "0x6000774")]
	[Address(RVA = "0x811DC0", Offset = "0x8103C0", VA = "0x180811DC0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int num = 0;
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, fromType, num2 != 0UL);
		base.MoveWay = (BulletMoveWay)((uint)15);
		this.velocity = (ulong)1075838976L;
		Vector2 gravity = Physics2D.gravity;
		this.acceleration.y = (float)0;
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

	// Token: 0x06000775 RID: 1909 RVA: 0x00025C20 File Offset: 0x00023E20
	[Token(Token = "0x6000775")]
	[Address(RVA = "0x811D40", Offset = "0x810340", VA = "0x180811D40", Slot = "17")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x06000776 RID: 1910 RVA: 0x00025C4C File Offset: 0x00023E4C
	[Token(Token = "0x6000776")]
	[Address(RVA = "0x811FC0", Offset = "0x8105C0", VA = "0x180811FC0", Slot = "13")]
	public override void JumpLand()
	{
		base.JumpLand();
	}

	// Token: 0x06000777 RID: 1911 RVA: 0x00025C60 File Offset: 0x00023E60
	[Token(Token = "0x6000777")]
	[Address(RVA = "0x811B30", Offset = "0x810130", VA = "0x180811B30", Slot = "25")]
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

	// Token: 0x06000778 RID: 1912 RVA: 0x00025CCC File Offset: 0x00023ECC
	[Token(Token = "0x6000778")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_squash()
	{
	}
}
