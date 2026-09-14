using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200055A RID: 1370
[Token(Token = "0x200055A")]
public class SniperPea : Shooter
{
	// Token: 0x06001974 RID: 6516 RVA: 0x00089498 File Offset: 0x00087698
	[Token(Token = "0x6001974")]
	[Address(RVA = "0x4E1130", Offset = "0x4DF730", VA = "0x1804E1130", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		Transform transform = base.transform;
		int num = 0;
		GameObject gameObject = transform.GetChild(num).gameObject;
		this.ac = gameObject;
		GameObject gameObject2 = this.ac;
		int num2 = 0;
		gameObject2.SetActive(num2 != 0);
		SortingGroup sortingGroup = this.ac.AddComponent<SortingGroup>();
		this.r = sortingGroup;
		this.r.sortAtRoot = true;
	}

	// Token: 0x06001975 RID: 6517 RVA: 0x00089504 File Offset: 0x00087704
	[Token(Token = "0x6001975")]
	[Address(RVA = "0x4E19C0", Offset = "0x4DFFC0", VA = "0x1804E19C0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		this.AcPositionUpdate();
	}

	// Token: 0x06001976 RID: 6518 RVA: 0x00089520 File Offset: 0x00087720
	[Token(Token = "0x6001976")]
	[Address(RVA = "0x4E1210", Offset = "0x4DF810", VA = "0x1804E1210", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		Zombie targetZombie = this.targetZombie;
		int num = 0;
		if (targetZombie == num)
		{
			GameObject gameObject = this.SearchZombie();
		}
	}

	// Token: 0x06001977 RID: 6519 RVA: 0x00089550 File Offset: 0x00087750
	[Token(Token = "0x6001977")]
	[Address(RVA = "0x4E12D0", Offset = "0x4DF8D0", VA = "0x1804E12D0", Slot = "45")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		Zombie targetZombie = this.targetZombie;
		this.thePlantAttackCountDown = num;
		int num2 = 0;
		if (targetZombie != num2)
		{
			this.anim.SetTrigger("shoot");
			return;
		}
	}

	// Token: 0x06001978 RID: 6520 RVA: 0x000895A8 File Offset: 0x000877A8
	[Token(Token = "0x6001978")]
	[Address(RVA = "0x4E0CD0", Offset = "0x4DF2D0", VA = "0x1804E0CD0")]
	private void AcPositionUpdate()
	{
		Zombie targetZombie = this.targetZombie;
		int num = 0;
		if (targetZombie != num)
		{
			Zombie targetZombie2 = this.targetZombie;
			if (targetZombie2.theStatus != ZombieStatus.Dying)
			{
				Collider2D col = targetZombie2.col;
				int num2 = 0;
				if (col != num2)
				{
					Transform axis = this.targetZombie.axis;
					Transform axis2 = this.axis;
					this.ac.SetActive(true);
					Zombie targetZombie3 = this.targetZombie;
					SortingGroup sortingGroup = this.r;
					int theZombieRow = targetZombie3.theZombieRow;
					string text = string.Format("bullet{0}", theZombieRow);
					sortingGroup.sortingLayerName = text;
					Transform transform = this.ac.transform;
					Collider2D col2 = this.targetZombie.col;
					Transform transform2 = this.ac.transform;
					float num3 = Time.deltaTime * 94.24778f;
					int num4 = 0;
					int num5 = 0;
					transform2.Rotate((float)num5, (float)num4, num3);
					return;
				}
			}
		}
		GameObject gameObject = this.ac;
		int num6 = 0;
		gameObject.SetActive(num6 != 0);
	}

	// Token: 0x06001979 RID: 6521 RVA: 0x000896B0 File Offset: 0x000878B0
	[Token(Token = "0x6001979")]
	[Address(RVA = "0x4E17C0", Offset = "0x4DFDC0", VA = "0x1804E17C0", Slot = "69")]
	protected override Bullet Shoot1()
	{
		GameAPP.PlaySound(40, 0.2f, 1f);
		bool flag = Lawnf.TravelUltimate((UltiBuff)((uint)51));
		Zombie targetZombie = this.targetZombie;
		int num = 0;
		int num2 = 0;
		if (targetZombie != num2)
		{
			Zombie targetZombie2 = this.targetZombie;
			if (!this.SearchUniqueZombie(targetZombie2))
			{
				GameObject gameObject = this.SearchZombie();
				int num3 = 0;
				if (!(gameObject != num3))
				{
					goto IL_008F;
				}
			}
			int num4 = this.attackCount;
			Zombie targetZombie3 = this.targetZombie;
			num4++;
			this.attackCount = num4;
			if (targetZombie2 != 0)
			{
			}
			this.AttackZombie(targetZombie3, 1000000, (DamageType)((uint)14));
			IL_008F:
			Zombie targetZombie4 = this.targetZombie;
			if (targetZombie4.theStatus == ZombieStatus.Dying || targetZombie4.beforeDying)
			{
				this.targetZombie = (ulong)0L;
			}
		}
		bool flag2 = Lawnf.TravelUltimate((UltiBuff)((uint)50));
		if (num != (flag2 ? 1 : 0))
		{
			this.anim.SetTrigger("shoot");
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600197A RID: 6522 RVA: 0x0008979C File Offset: 0x0008799C
	[Token(Token = "0x600197A")]
	[Address(RVA = "0x4E0F60", Offset = "0x4DF560", VA = "0x1804E0F60", Slot = "73")]
	protected virtual void AttackZombie(Zombie zombie, int damage, DamageType theDamageType = DamageType.Shieldless)
	{
		PlantType thePlantType = this.thePlantType;
		GameObject gameObject = GameAPP.particlePrefab[0];
		Transform transform = this.ac.transform;
		Vector3 vector;
		float z = vector.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform2 = this.board.transform;
	}

	// Token: 0x0600197B RID: 6523 RVA: 0x000897EC File Offset: 0x000879EC
	[Token(Token = "0x600197B")]
	[Address(RVA = "0x4E1460", Offset = "0x4DFA60", VA = "0x1804E1460", Slot = "44")]
	protected override GameObject SearchZombie()
	{
		int num;
		int num2;
		do
		{
			num = 0;
			List<Zombie> zombieList = this.zombieList;
			int size = zombieList._size;
			num2 = 0;
			zombieList._size = num2;
			if (size > 0)
			{
			}
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				float vision = this.vision;
				Transform axis = this.axis;
				if (!this.SearchUniqueZombie(num))
				{
					continue;
				}
				Transform axis2 = this.axis;
			}
		}
		while (num2 != 0);
		int num4 = 0;
		if (!(num != num4))
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600197C RID: 6524 RVA: 0x000898A0 File Offset: 0x00087AA0
	[Token(Token = "0x600197C")]
	[Address(RVA = "0x4E13C0", Offset = "0x4DF9C0", VA = "0x1804E13C0", Slot = "48")]
	protected override bool SearchUniqueZombie(Zombie zombie)
	{
		int num = 0;
		bool flag = zombie == num;
		if (!flag && zombie.isMindControlled == flag && zombie.beforeDying == flag)
		{
			ZombieStatus theStatus = zombie.theStatus;
			if (theStatus > ZombieStatus.Snokle_inWater)
			{
				if (theStatus != ZombieStatus.Miner_digging && flag > true && theStatus != ZombieStatus.Bungi_awake)
				{
					return true;
				}
			}
		}
		IL_003B:
		while (zombie == (ulong)1L)
		{
		}
		while (zombie == (ulong)7L)
		{
		}
		return true;
		goto IL_003B;
	}

	// Token: 0x0600197D RID: 6525 RVA: 0x00089900 File Offset: 0x00087B00
	[Token(Token = "0x600197D")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public SniperPea()
	{
	}

	// Token: 0x04000E41 RID: 3649
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E41")]
	private int attackCount;

	// Token: 0x04000E42 RID: 3650
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000E42")]
	protected GameObject ac;

	// Token: 0x04000E43 RID: 3651
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000E43")]
	protected SortingGroup r;
}
