using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005E8 RID: 1512
[Token(Token = "0x20005E8")]
public class UltimateMelon : SuperMelon
{
	// Token: 0x06001C25 RID: 7205 RVA: 0x00096648 File Offset: 0x00094848
	[Token(Token = "0x6001C25")]
	[Address(RVA = "0x567900", Offset = "0x565F00", VA = "0x180567900", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.SetShoot();
		this.attributeCount = (int)((ulong)42L);
	}

	// Token: 0x06001C26 RID: 7206 RVA: 0x0009666C File Offset: 0x0009486C
	[Token(Token = "0x6001C26")]
	[Address(RVA = "0x568120", Offset = "0x566720", VA = "0x180568120", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_ultimateMelon;
	}

	// Token: 0x06001C27 RID: 7207 RVA: 0x0009667C File Offset: 0x0009487C
	[Token(Token = "0x6001C27")]
	[Address(RVA = "0x568130", Offset = "0x566730", VA = "0x180568130", Slot = "54")]
	public override void OnCreate(int theColumn, int theRow)
	{
		ulong num;
		PotEffects.CornPotEffect(this, theColumn, theRow, 4, (int)num);
		PotEffects.MelonPotEffect(this, theColumn, theRow);
	}

	// Token: 0x06001C28 RID: 7208 RVA: 0x0009669C File Offset: 0x0009489C
	[Token(Token = "0x6001C28")]
	[Address(RVA = "0x5681B0", Offset = "0x5667B0", VA = "0x1805681B0", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
	}

	// Token: 0x06001C29 RID: 7209 RVA: 0x000966AC File Offset: 0x000948AC
	[Token(Token = "0x6001C29")]
	[Address(RVA = "0x568230", Offset = "0x566830", VA = "0x180568230", Slot = "77")]
	protected override void UniqueEffect(Bullet bullet)
	{
		Bullet_superMelon component = bullet.GetComponent<Bullet_superMelon>();
		int butterP = this.butterP;
		component.p = butterP;
		int num = global::UnityEngine.Random.Range(0, 100);
		this.thePlantAttackCountDown = 0.2f;
		List<Zombie> zombieList = this.zombieList;
		int size = zombieList._size;
		zombieList._size = (int)((ulong)0L);
		if (size > 0)
		{
		}
		int num2 = global::UnityEngine.Random.Range(0, 100);
		if (Lawnf.TravelUltimate((UltiBuff)((uint)12)))
		{
			this.ExtraShoot();
		}
	}

	// Token: 0x06001C2A RID: 7210 RVA: 0x00096724 File Offset: 0x00094924
	[Token(Token = "0x6001C2A")]
	[Address(RVA = "0x567940", Offset = "0x565F40", VA = "0x180567940")]
	private void ExtraShoot()
	{
		int num7;
		do
		{
			int num = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			int num2 = 0;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				int thePlantRow = this.thePlantRow;
				if (!Thrower.ThrowSearchZombie(num))
				{
					continue;
				}
				Transform axis = this.axis;
				List<Zombie> zombieList = this.zombieList;
			}
			if (num2 != 0)
			{
				goto IL_00D7;
			}
			int num4 = 0;
			int num5 = 0;
			Plant plant;
			if (plant != num5)
			{
				Transform axis2 = plant.axis;
				Vector3 vector;
				float z = vector.z;
				bool flag2;
				if (flag2)
				{
					CreateBullet instance = CreateBullet.Instance;
					int num6 = 0;
					Bullet bullet;
					bullet.fromType = (PlantType)num6;
				}
				if (num4 != 0)
				{
					goto IL_00F5;
				}
				num7 = 0;
			}
			bool flag3;
			if (flag3)
			{
				CreateBullet instance2 = CreateBullet.Instance;
				int num8 = 0;
				Bullet bullet2;
				bullet2.Damage = num;
				bullet2.fromType = (PlantType)num8;
			}
		}
		while (num7 != 0);
		return;
		IL_00D7:
		throw new NullReferenceException();
		IL_00F5:
		throw new NullReferenceException();
	}

	// Token: 0x06001C2B RID: 7211 RVA: 0x00096834 File Offset: 0x00094A34
	[Token(Token = "0x6001C2B")]
	[Address(RVA = "0x4D6B50", Offset = "0x4D5150", VA = "0x1804D6B50")]
	public UltimateMelon()
	{
	}
}
