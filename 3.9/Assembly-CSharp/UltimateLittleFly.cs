using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004A1 RID: 1185
[Token(Token = "0x20004A1")]
public class UltimateLittleFly : LittleFly
{
	// Token: 0x0600160B RID: 5643 RVA: 0x000792B8 File Offset: 0x000774B8
	[Token(Token = "0x600160B")]
	[Address(RVA = "0x4E64C0", Offset = "0x4E4AC0", VA = "0x1804E64C0", Slot = "4")]
	protected override void Awake()
	{
		base.Awake();
		LayerMask layerMask = LayerMask.GetMask(new string[] { "Zombie" });
		this.layerMask = layerMask;
	}

	// Token: 0x0600160C RID: 5644 RVA: 0x000792F8 File Offset: 0x000774F8
	[Token(Token = "0x600160C")]
	[Address(RVA = "0x4E6C20", Offset = "0x4E5220", VA = "0x1804E6C20", Slot = "5")]
	protected override void Update()
	{
		Zombie target = this.target;
		int num = 0;
		if (!(target == num))
		{
			if (this.target.TryGetComponent<Collider2D>(num))
			{
				Zombie target2 = this.target;
				if (this.CheckZombie(target2))
				{
					Transform axis = this.axis;
					Transform transform = base.transform;
					Transform transform2 = base.transform;
				}
			}
			this.target = (ulong)0L;
		}
		Zombie zombie = this.GetZombie();
		this.target = zombie;
		this.onTarget = false;
		Transform transform3 = base.transform;
		float num2 = this.offset * 5f;
		Transform transform4 = base.transform;
		Transform transform5 = base.transform;
		Transform axis2 = this.parentPlant.axis;
		Vector3 vector;
		float z = vector.z;
		float deltaTime = Time.deltaTime;
		if (0 == 0)
		{
		}
		Transform transform6 = base.transform;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		float deltaTime2 = Time.deltaTime;
		Transform axis3 = this.axis;
		Transform transform7 = base.transform;
		Transform transform8 = base.transform;
		Quaternion identityQuaternion2 = Quaternion.identityQuaternion;
		base.ShootUpdate();
	}

	// Token: 0x0600160D RID: 5645 RVA: 0x0007940C File Offset: 0x0007760C
	[Token(Token = "0x600160D")]
	[Address(RVA = "0x4E5F20", Offset = "0x4E4520", VA = "0x1804E5F20", Slot = "7")]
	protected override void AnimShoot()
	{
		Zombie target = this.target;
		int num = 0;
		int num2 = 0;
		bool flag = target != num2;
		GameObject shoot = this.shoot;
		if (!flag)
		{
			Transform transform = shoot.transform;
			int num3 = this.layerMask;
			RaycastHit2D[] array;
			if (num >= array.Length)
			{
				goto IL_012C;
			}
			int num4 = 0;
			Collider2D collider2D;
			bool flag2 = collider2D.TryGetComponent<Zombie>(num4);
			if (flag2)
			{
				if (collider2D > (ulong)12L)
				{
					if (flag2 <= true || collider2D == (ulong)27L)
					{
						goto IL_00A2;
					}
					if (collider2D != (ulong)44L)
					{
						goto IL_009A;
					}
					num++;
				}
				if (18446744073709551615UL == (ulong)4294967293L || (18446744073709551609UL <= (ulong)5L && this.small))
				{
					goto IL_00A2;
				}
				IL_009A:
				this.AttackZombie(num4);
			}
			IL_00A2:
			num++;
		}
		Transform transform2 = shoot.transform;
		int num5 = this.layerMask;
		RaycastHit2D[] array2;
		if (num < array2.Length)
		{
			int num6 = 0;
			Collider2D collider2D2;
			if (collider2D2.TryGetComponent<Zombie>(num6))
			{
				int theZombieRow = this.target.theZombieRow;
				if (collider2D2 > (ulong)12L)
				{
					if (theZombieRow <= 4 || collider2D2 == (ulong)27L)
					{
						goto IL_0128;
					}
					if (collider2D2 != (ulong)44L)
					{
						goto IL_0120;
					}
					num++;
				}
				if (18446744073709551615UL == (ulong)4294967293L || (18446744073709551609UL <= (ulong)5L && this.small))
				{
					goto IL_0128;
				}
				IL_0120:
				this.AttackZombie(num6);
			}
			IL_0128:
			num++;
		}
		IL_012C:
		uint num7;
		GameAPP.PlaySound((int)num7, 1f, float.MaxValue);
	}

	// Token: 0x0600160E RID: 5646 RVA: 0x00079560 File Offset: 0x00077760
	[Token(Token = "0x600160E")]
	[Address(RVA = "0x4E63B0", Offset = "0x4E49B0", VA = "0x1804E63B0")]
	private void AttackZombie(Zombie zombie)
	{
		Plant parentPlant = this.parentPlant;
		int num = 0;
		if (parentPlant != num)
		{
			Plant parentPlant2 = this.parentPlant;
		}
		if (Lawnf.TravelUltimate((UltiBuff)((uint)25)))
		{
		}
		int num2 = 0;
		PlantType fromType = this.fromType;
		ulong num3;
		zombie.TakeDamage(200, num2, (DamageType)((uint)1), fromType, num3 != 0UL);
		int num4 = 0;
		int num5 = 0;
		zombie.ModifyArmor((ArmorBonus)((uint)4), -200f, num5 != 0, (float)num4);
	}

	// Token: 0x0600160F RID: 5647 RVA: 0x000795CC File Offset: 0x000777CC
	[Token(Token = "0x600160F")]
	[Address(RVA = "0x4E68E0", Offset = "0x4E4EE0", VA = "0x1804E68E0", Slot = "6")]
	protected override Zombie GetZombie()
	{
		int num2;
		Zombie flyingZombie;
		do
		{
			int num = 0;
			num2 = 0;
			flyingZombie = this.GetFlyingZombie();
			int num3 = 0;
			if (flyingZombie != num3)
			{
				break;
			}
			List<Zombie> zombieArray = Board.Instance.zombieArray;
			bool flag;
			if (flag)
			{
				int num4 = 0;
				if (!(num != num4) || !this.CheckZombie(num))
				{
					continue;
				}
				bool flag2;
				while (!flag2)
				{
				}
				Transform transform = base.transform;
				Transform transform2 = base.transform;
			}
		}
		while (num2 != 0);
		return flyingZombie;
	}

	// Token: 0x06001610 RID: 5648 RVA: 0x00079660 File Offset: 0x00077860
	[Token(Token = "0x6001610")]
	[Address(RVA = "0x4E65F0", Offset = "0x4E4BF0", VA = "0x1804E65F0")]
	private Zombie GetFlyingZombie()
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			List<Zombie> zombieArray = Board.Instance.zombieArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3) || !this.CheckZombie(num))
				{
					continue;
				}
				bool flag2;
				while (!flag2)
				{
				}
				Transform transform = base.transform;
				int theFlyRow = this.theFlyRow;
			}
		}
		while (num2 != 0);
		throw new NullReferenceException();
	}

	// Token: 0x06001611 RID: 5649 RVA: 0x000796D0 File Offset: 0x000778D0
	[Token(Token = "0x6001611")]
	[Address(RVA = "0x4E6560", Offset = "0x4E4B60", VA = "0x1804E6560")]
	protected bool CheckZombie(Zombie zombie)
	{
		if (zombie.isMindControlled)
		{
			goto IL_001F;
		}
		ZombieStatus theStatus = zombie.theStatus;
		if (theStatus > ZombieStatus.Miner_digging)
		{
			if (theStatus == ZombieStatus.Legion_fall || theStatus == ZombieStatus.Bungi_awake)
			{
				goto IL_001F;
			}
			goto IL_0033;
		}
		IL_0021:
		int num;
		while (num == -3)
		{
		}
		if (num <= 5)
		{
			while (this.small)
			{
			}
			goto IL_0033;
		}
		goto IL_0033;
		IL_001F:
		num = 0;
		goto IL_0021;
		IL_0033:
		throw new NullReferenceException();
	}

	// Token: 0x06001612 RID: 5650 RVA: 0x00079718 File Offset: 0x00077918
	[Token(Token = "0x6001612")]
	[Address(RVA = "0x4E72E0", Offset = "0x4E58E0", VA = "0x1804E72E0")]
	public UltimateLittleFly()
	{
	}

	// Token: 0x04000DB4 RID: 3508
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000DB4")]
	private LayerMask layerMask;

	// Token: 0x04000DB5 RID: 3509
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000DB5")]
	public bool small;
}
