using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000589 RID: 1417
[Token(Token = "0x2000589")]
public class SniperPea : Shooter
{
	// Token: 0x06001A50 RID: 6736 RVA: 0x0008D408 File Offset: 0x0008B608
	[Token(Token = "0x6001A50")]
	[Address(RVA = "0x53F240", Offset = "0x53D840", VA = "0x18053F240", Slot = "10")]
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

	// Token: 0x06001A51 RID: 6737 RVA: 0x0008D474 File Offset: 0x0008B674
	[Token(Token = "0x6001A51")]
	[Address(RVA = "0x53FAD0", Offset = "0x53E0D0", VA = "0x18053FAD0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		this.AcPositionUpdate();
	}

	// Token: 0x06001A52 RID: 6738 RVA: 0x0008D490 File Offset: 0x0008B690
	[Token(Token = "0x6001A52")]
	[Address(RVA = "0x53F320", Offset = "0x53D920", VA = "0x18053F320", Slot = "17")]
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

	// Token: 0x06001A53 RID: 6739 RVA: 0x0008D4C0 File Offset: 0x0008B6C0
	[Token(Token = "0x6001A53")]
	[Address(RVA = "0x53F3E0", Offset = "0x53D9E0", VA = "0x18053F3E0", Slot = "44")]
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

	// Token: 0x06001A54 RID: 6740 RVA: 0x0008D518 File Offset: 0x0008B718
	[Token(Token = "0x6001A54")]
	[Address(RVA = "0x53EDE0", Offset = "0x53D3E0", VA = "0x18053EDE0")]
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

	// Token: 0x06001A55 RID: 6741 RVA: 0x0008D620 File Offset: 0x0008B820
	[Token(Token = "0x6001A55")]
	[Address(RVA = "0x53F8D0", Offset = "0x53DED0", VA = "0x18053F8D0", Slot = "68")]
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

	// Token: 0x06001A56 RID: 6742 RVA: 0x0008D70C File Offset: 0x0008B90C
	[Token(Token = "0x6001A56")]
	[Address(RVA = "0x53F070", Offset = "0x53D670", VA = "0x18053F070", Slot = "72")]
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

	// Token: 0x06001A57 RID: 6743 RVA: 0x0008D75C File Offset: 0x0008B95C
	[Token(Token = "0x6001A57")]
	[Address(RVA = "0x53F570", Offset = "0x53DB70", VA = "0x18053F570", Slot = "43")]
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

	// Token: 0x06001A58 RID: 6744 RVA: 0x0008D810 File Offset: 0x0008BA10
	[Token(Token = "0x6001A58")]
	[Address(RVA = "0x53F4D0", Offset = "0x53DAD0", VA = "0x18053F4D0", Slot = "47")]
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

	// Token: 0x06001A59 RID: 6745 RVA: 0x0008D870 File Offset: 0x0008BA70
	[Token(Token = "0x6001A59")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public SniperPea()
	{
	}

	// Token: 0x04000EFF RID: 3839
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000EFF")]
	private int attackCount;

	// Token: 0x04000F00 RID: 3840
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000F00")]
	protected GameObject ac;

	// Token: 0x04000F01 RID: 3841
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000F01")]
	protected SortingGroup r;
}
