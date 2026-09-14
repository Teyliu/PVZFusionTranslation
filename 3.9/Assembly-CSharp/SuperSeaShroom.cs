using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200046A RID: 1130
[Token(Token = "0x200046A")]
public class SuperSeaShroom : Shooter
{
	// Token: 0x060014D7 RID: 5335 RVA: 0x00073604 File Offset: 0x00071804
	[Token(Token = "0x60014D7")]
	[Address(RVA = "0x4CC190", Offset = "0x4CA790", VA = "0x1804CC190", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 3f;
		this.theStatus = (PlantStatus)((ulong)15L);
	}

	// Token: 0x060014D8 RID: 5336 RVA: 0x0007362C File Offset: 0x0007182C
	[Token(Token = "0x60014D8")]
	[Address(RVA = "0x4CC7C0", Offset = "0x4CADC0", VA = "0x1804CC7C0", Slot = "68")]
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

	// Token: 0x060014D9 RID: 5337 RVA: 0x00073688 File Offset: 0x00071888
	[Token(Token = "0x60014D9")]
	[Address(RVA = "0x4CC7A0", Offset = "0x4CADA0", VA = "0x1804CC7A0", Slot = "44")]
	protected override void PlantShootUpdate()
	{
		base.PlantShootUpdate();
	}

	// Token: 0x060014DA RID: 5338 RVA: 0x0007369C File Offset: 0x0007189C
	[Token(Token = "0x60014DA")]
	[Address(RVA = "0x4CC1D0", Offset = "0x4CA7D0", VA = "0x1804CC1D0", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		this.GrabUpdate();
	}

	// Token: 0x060014DB RID: 5339 RVA: 0x000736B8 File Offset: 0x000718B8
	[Token(Token = "0x60014DB")]
	[Address(RVA = "0x4CC200", Offset = "0x4CA800", VA = "0x1804CC200")]
	private void GrabUpdate()
	{
		int num = 0;
		List<Zombie> list = new List();
		Transform axis = this.axis;
		Vector3 vector;
		float z3 = vector.z;
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
			func2 = delegate(Zombie z)
			{
				int theZombieType = (int)z.theZombieType;
				bool flag2;
				return flag2;
			};
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

	// Token: 0x060014DC RID: 5340 RVA: 0x000737F0 File Offset: 0x000719F0
	[Token(Token = "0x60014DC")]
	[Address(RVA = "0x48D320", Offset = "0x48B920", VA = "0x18048D320", Slot = "39")]
	protected override void AttributeEvent()
	{
		this.theStatus = (PlantStatus)((ulong)0L);
	}

	// Token: 0x060014DD RID: 5341 RVA: 0x00073808 File Offset: 0x00071A08
	[Token(Token = "0x60014DD")]
	[Address(RVA = "0x4CBF20", Offset = "0x4CA520", VA = "0x1804CBF20")]
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

	// Token: 0x060014DE RID: 5342 RVA: 0x000738D4 File Offset: 0x00071AD4
	[Token(Token = "0x60014DE")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public SuperSeaShroom()
	{
	}

	// Token: 0x04000D47 RID: 3399
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000D47")]
	public SortingGroup handGroup;

	// Token: 0x04000D48 RID: 3400
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000D48")]
	public GameObject hand;
}
