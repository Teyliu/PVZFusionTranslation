using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200044A RID: 1098
[Token(Token = "0x200044A")]
public class SuperSeaShroom : Shooter
{
	// Token: 0x06001447 RID: 5191 RVA: 0x000712D8 File Offset: 0x0006F4D8
	[Token(Token = "0x6001447")]
	[Address(RVA = "0x4748E0", Offset = "0x472EE0", VA = "0x1804748E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 3f;
		this.theStatus = (PlantStatus)((ulong)15L);
	}

	// Token: 0x06001448 RID: 5192 RVA: 0x00071300 File Offset: 0x0006F500
	[Token(Token = "0x6001448")]
	[Address(RVA = "0x474F10", Offset = "0x473510", VA = "0x180474F10", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		PlantType thePlantType = this.thePlantType;
		Bullet bullet;
		bullet.fromType = thePlantType;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		GameAPP.PlaySound(57, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x06001449 RID: 5193 RVA: 0x0007135C File Offset: 0x0006F55C
	[Token(Token = "0x6001449")]
	[Address(RVA = "0x474EF0", Offset = "0x4734F0", VA = "0x180474EF0", Slot = "45")]
	protected override void PlantShootUpdate()
	{
		base.PlantShootUpdate();
	}

	// Token: 0x0600144A RID: 5194 RVA: 0x00071370 File Offset: 0x0006F570
	[Token(Token = "0x600144A")]
	[Address(RVA = "0x474920", Offset = "0x472F20", VA = "0x180474920", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		this.GrabUpdate();
	}

	// Token: 0x0600144B RID: 5195 RVA: 0x0007138C File Offset: 0x0006F58C
	[Token(Token = "0x600144B")]
	[Address(RVA = "0x474950", Offset = "0x472F50", VA = "0x180474950")]
	private void GrabUpdate()
	{
		int num = 0;
		List<Zombie> list = new List();
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			BoxType boxType;
			if (flag && boxType == BoxType.Water)
			{
				int thePlantRow = this.thePlantRow;
				if (base.SearchUniqueZombie(num))
				{
					Zombie targetZombie = this.targetZombie;
					int num3 = 0;
					if (targetZombie == num3)
					{
					}
				}
			}
			num++;
		}
		Func<Zombie, float> func;
		if (SuperSeaShroom.<>c.<>9__6_0 == 0)
		{
			SuperSeaShroom.<>c.<>9__6_0 = func;
		}
		IOrderedEnumerable<Zombie> orderedEnumerable = Enumerable.OrderBy<Zombie, float>(list, func);
		Func<Zombie, bool> func2;
		if (SuperSeaShroom.<>c.<>9__6_1 == 0)
		{
			SuperSeaShroom.<>c.<>9__6_1 = func2;
		}
		IOrderedEnumerable<Zombie> orderedEnumerable2 = Enumerable.OrderBy<Zombie, bool>(list, func2);
		int num4 = 0;
		Zombie zombie = list[num4];
		this.targetZombie = zombie;
		this.anim.SetTrigger("attack");
		Transform transform = this.hand.transform;
		Transform axis2 = this.targetZombie.axis;
		Vector3 vector2;
		float z2 = vector2.z;
		Zombie targetZombie2 = this.targetZombie;
		SortingGroup sortingGroup = this.handGroup;
		int theZombieRow = targetZombie2.theZombieRow;
		string text = string.Format("bullet{0}", theZombieRow);
		sortingGroup.sortingLayerName = text;
	}

	// Token: 0x0600144C RID: 5196 RVA: 0x000714B0 File Offset: 0x0006F6B0
	[Token(Token = "0x600144C")]
	[Address(RVA = "0x439AA0", Offset = "0x4380A0", VA = "0x180439AA0", Slot = "40")]
	protected override void AttributeEvent()
	{
		this.theStatus = (PlantStatus)((ulong)0L);
	}

	// Token: 0x0600144D RID: 5197 RVA: 0x000714C8 File Offset: 0x0006F6C8
	[Token(Token = "0x600144D")]
	[Address(RVA = "0x474670", Offset = "0x472C70", VA = "0x180474670")]
	private void AnimGrab()
	{
		Zombie targetZombie = this.targetZombie;
		int num = 0;
		if (targetZombie != num)
		{
			this.targetZombie.KnockBack(1.5f, (Zombie.KnockBackReason)((uint)3));
			Zombie targetZombie2 = this.targetZombie;
			PlantType thePlantType = this.thePlantType;
			ulong num2;
			targetZombie2.TakeDamage(num, this, (DamageType)((uint)1), thePlantType, num2 != 0UL);
			Zombie targetZombie3 = this.targetZombie;
			int num3 = 0;
			targetZombie3.SetKelped(5f, num3 != 0);
			Zombie targetZombie4 = this.targetZombie;
			int num4 = 0;
			targetZombie4.AddTimer((ZombieTimer)num4, 3f);
			Transform axis = this.targetZombie.axis;
			Vector2 oneVector = Vector2.oneVector;
			Zombie targetZombie5 = this.targetZombie;
			GameAPP.PlaySound((SoundType)((uint)24), 0.5f, 1f);
			this.targetZombie = (ulong)0L;
			this.theStatus = (PlantStatus)((ulong)15L);
		}
	}

	// Token: 0x0600144E RID: 5198 RVA: 0x00071594 File Offset: 0x0006F794
	[Token(Token = "0x600144E")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public SuperSeaShroom()
	{
	}

	// Token: 0x04000CBB RID: 3259
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000CBB")]
	public SortingGroup handGroup;

	// Token: 0x04000CBC RID: 3260
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000CBC")]
	public GameObject hand;
}
