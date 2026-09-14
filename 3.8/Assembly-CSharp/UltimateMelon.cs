using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005B7 RID: 1463
[Token(Token = "0x20005B7")]
public class UltimateMelon : SuperMelon
{
	// Token: 0x06001B3A RID: 6970 RVA: 0x0009217C File Offset: 0x0009037C
	[Token(Token = "0x6001B3A")]
	[Address(RVA = "0x500AC0", Offset = "0x4FF0C0", VA = "0x180500AC0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCount = (int)((ulong)42L);
	}

	// Token: 0x06001B3B RID: 6971 RVA: 0x0009219C File Offset: 0x0009039C
	[Token(Token = "0x6001B3B")]
	[Address(RVA = "0x5012C0", Offset = "0x4FF8C0", VA = "0x1805012C0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_ultimateMelon;
	}

	// Token: 0x06001B3C RID: 6972 RVA: 0x000921AC File Offset: 0x000903AC
	[Token(Token = "0x6001B3C")]
	[Address(RVA = "0x5012D0", Offset = "0x4FF8D0", VA = "0x1805012D0", Slot = "55")]
	public override void OnCreate(int theColumn, int theRow)
	{
		ulong num;
		PotEffects.CornPotEffect(this, theColumn, theRow, 4, (int)num);
		PotEffects.MelonPotEffect(this, theColumn, theRow);
	}

	// Token: 0x06001B3D RID: 6973 RVA: 0x000921CC File Offset: 0x000903CC
	[Token(Token = "0x6001B3D")]
	[Address(RVA = "0x501350", Offset = "0x4FF950", VA = "0x180501350", Slot = "54")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
	}

	// Token: 0x06001B3E RID: 6974 RVA: 0x000921DC File Offset: 0x000903DC
	[Token(Token = "0x6001B3E")]
	[Address(RVA = "0x5013D0", Offset = "0x4FF9D0", VA = "0x1805013D0", Slot = "78")]
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

	// Token: 0x06001B3F RID: 6975 RVA: 0x00092254 File Offset: 0x00090454
	[Token(Token = "0x6001B3F")]
	[Address(RVA = "0x500AE0", Offset = "0x4FF0E0", VA = "0x180500AE0")]
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

	// Token: 0x06001B40 RID: 6976 RVA: 0x00092364 File Offset: 0x00090564
	[Token(Token = "0x6001B40")]
	[Address(RVA = "0x47E9D0", Offset = "0x47CFD0", VA = "0x18047E9D0")]
	public UltimateMelon()
	{
	}
}
