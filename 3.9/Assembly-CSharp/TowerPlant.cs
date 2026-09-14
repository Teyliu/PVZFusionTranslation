using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000602 RID: 1538
[Token(Token = "0x2000602")]
public class TowerPlant : Plant
{
	// Token: 0x17000187 RID: 391
	// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x00099590 File Offset: 0x00097790
	[Token(Token = "0x17000187")]
	public int Damage
	{
		[Token(Token = "0x6001CC4")]
		[Address(RVA = "0x55E630", Offset = "0x55CC30", VA = "0x18055E630")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000188 RID: 392
	// (get) Token: 0x06001CC5 RID: 7365 RVA: 0x000995A0 File Offset: 0x000977A0
	[Token(Token = "0x17000188")]
	public BulletMoveWay TowardsMoveWay
	{
		[Token(Token = "0x6001CC5")]
		[Address(RVA = "0x55E650", Offset = "0x55CC50", VA = "0x18055E650")]
		get
		{
			return BulletMoveWay.MoveRight;
		}
	}

	// Token: 0x06001CC6 RID: 7366 RVA: 0x000995B8 File Offset: 0x000977B8
	[Token(Token = "0x6001CC6")]
	[Address(RVA = "0x55D8E0", Offset = "0x55BEE0", VA = "0x18055D8E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.SetSpeed(1f);
	}

	// Token: 0x06001CC7 RID: 7367 RVA: 0x000995D8 File Offset: 0x000977D8
	[Token(Token = "0x6001CC7")]
	[Address(RVA = "0x55E190", Offset = "0x55C790", VA = "0x18055E190", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		float thePlantAttackInterval = this.thePlantAttackInterval;
		this.attackInterval = thePlantAttackInterval;
	}

	// Token: 0x06001CC8 RID: 7368 RVA: 0x000995FC File Offset: 0x000977FC
	[Token(Token = "0x6001CC8")]
	[Address(RVA = "0x55DF50", Offset = "0x55C550", VA = "0x18055DF50")]
	public void SetTowards(Towards towards)
	{
		this.towards = towards;
		if (towards != Towards.Left)
		{
			Transform transform = base.transform;
		}
		Transform transform2 = base.transform;
		Transform parent = this.healthSlider.transform.parent;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		parent.rotation = identityQuaternion;
	}

	// Token: 0x06001CC9 RID: 7369 RVA: 0x00099650 File Offset: 0x00097850
	[Token(Token = "0x6001CC9")]
	[Address(RVA = "0x468B30", Offset = "0x467130", VA = "0x180468B30", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
		}
	}

	// Token: 0x06001CCA RID: 7370 RVA: 0x0009966C File Offset: 0x0009786C
	[Token(Token = "0x6001CCA")]
	[Address(RVA = "0x55E050", Offset = "0x55C650", VA = "0x18055E050", Slot = "68")]
	protected virtual void ShootUpdate()
	{
		float num = this.attackTimer;
		float deltaTime = Time.deltaTime;
		this.attackTimer = num;
		float num2 = global::UnityEngine.Random.Range(0.95f, 1.05f);
		this.attackTimer = num2;
		if (this.Shootable())
		{
			this.Shoot();
		}
	}

	// Token: 0x06001CCB RID: 7371 RVA: 0x000996BC File Offset: 0x000978BC
	[Token(Token = "0x6001CCB")]
	[Address(RVA = "0x55E150", Offset = "0x55C750", VA = "0x18055E150", Slot = "46")]
	protected override bool Shootable()
	{
		while (!base.Shootable())
		{
		}
		return true;
	}

	// Token: 0x06001CCC RID: 7372 RVA: 0x000996D4 File Offset: 0x000978D4
	[Token(Token = "0x6001CCC")]
	[Address(RVA = "0x55D910", Offset = "0x55BF10", VA = "0x18055D910", Slot = "69")]
	protected virtual bool CheckGrave()
	{
		for (;;)
		{
			int num = 0;
			List<GridItem> griditemArray = this.board.griditemArray;
			bool flag;
			ulong num3;
			if (flag)
			{
				int num2 = 0;
				if (num != num2)
				{
					break;
				}
			}
			else if (num3 == (ulong)0L)
			{
				goto Block_4;
			}
		}
		int thePlantRow = this.thePlantRow;
		if (this.towards == Towards.Right)
		{
			int thePlantColumn = this.thePlantColumn;
		}
		while (this.towards != Towards.Left)
		{
		}
		int thePlantColumn2 = this.thePlantColumn;
		return true;
		Block_4:
		throw new NullReferenceException();
	}

	// Token: 0x06001CCD RID: 7373 RVA: 0x00099748 File Offset: 0x00097948
	[Token(Token = "0x6001CCD")]
	[Address(RVA = "0x55E100", Offset = "0x55C700", VA = "0x18055E100", Slot = "70")]
	public virtual void Shoot()
	{
		this.anim.SetTrigger("shoot");
	}

	// Token: 0x06001CCE RID: 7374 RVA: 0x0009976C File Offset: 0x0009796C
	[Token(Token = "0x6001CCE")]
	[Address(RVA = "0x55DDD0", Offset = "0x55C3D0", VA = "0x18055DDD0")]
	public void SetSpeed(float value)
	{
		Animator anim = this.anim;
		this.attackSpeed = value;
		AnimatorControllerParameter[] parameters = anim.parameters;
		Func<AnimatorControllerParameter, bool> <>9__18_ = TowerPlant.<>c.<>9__18_0;
		if (<>9__18_ == 0)
		{
			TowerPlant.<>c.<>9__18_0 = (AnimatorControllerParameter param) => string.Equals(param.name, "attackSpeed");
		}
		if (Enumerable.Any<AnimatorControllerParameter>(parameters, <>9__18_))
		{
			this.anim.SetFloat("attackSpeed", value);
		}
	}

	// Token: 0x06001CCF RID: 7375 RVA: 0x000997D0 File Offset: 0x000979D0
	[Token(Token = "0x6001CCF")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "71")]
	public virtual void AnimShoot()
	{
	}

	// Token: 0x06001CD0 RID: 7376 RVA: 0x000997E0 File Offset: 0x000979E0
	[Token(Token = "0x6001CD0")]
	[Address(RVA = "0x55DC20", Offset = "0x55C220", VA = "0x18055DC20", Slot = "43")]
	protected override GameObject SearchZombie()
	{
		for (;;)
		{
			int num = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			ulong num3;
			if (flag)
			{
				int num2 = 0;
				if (num != num2 && this.CheckZombie(num))
				{
					break;
				}
			}
			else if (num3 == (ulong)0L)
			{
				goto Block_3;
			}
		}
		GameObject gameObject;
		return gameObject;
		Block_3:
		throw new NullReferenceException();
	}

	// Token: 0x06001CD1 RID: 7377 RVA: 0x00099834 File Offset: 0x00097A34
	[Token(Token = "0x6001CD1")]
	[Address(RVA = "0x55DAF0", Offset = "0x55C0F0", VA = "0x18055DAF0", Slot = "72")]
	protected virtual bool CheckZombie(Zombie zombie)
	{
		int thePlantRow = this.thePlantRow;
		if (zombie.theZombieRow == thePlantRow && base.SearchUniqueZombie(zombie))
		{
			Transform axis = zombie.axis;
			Transform axis2 = this.axis;
			if (this.towards == Towards.Left)
			{
				Transform axis3 = zombie.axis;
				Transform axis4 = this.axis;
			}
			Vector3 vector;
			return vector != 0;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001CD2 RID: 7378 RVA: 0x00099898 File Offset: 0x00097A98
	[Token(Token = "0x6001CD2")]
	[Address(RVA = "0x55D8C0", Offset = "0x55BEC0", VA = "0x18055D8C0")]
	protected void AddDamage(float value)
	{
		this.basicDamage = value;
	}

	// Token: 0x06001CD3 RID: 7379 RVA: 0x000998AC File Offset: 0x00097AAC
	[Token(Token = "0x6001CD3")]
	[Address(RVA = "0x55E1C0", Offset = "0x55C7C0", VA = "0x18055E1C0", Slot = "73")]
	public virtual void Upgrade(TowerUpgradeType towerUpgradeType)
	{
		this.upgradeType = towerUpgradeType;
		if (towerUpgradeType == TowerUpgradeType.Upgraded)
		{
			GameObject[] itemPrefab = GameAPP.itemPrefab;
		}
		GameObject gameObject;
		if (typeof(global::UnityEngine.Object).TypeHandle <= (ulong)1L)
		{
			gameObject = GameAPP.itemPrefab[45];
		}
		int num = 0;
		if (gameObject != num)
		{
			GameObject levelIcon = this.levelIcon;
			int num2 = 0;
			if (levelIcon != num2)
			{
				global::UnityEngine.Object.Destroy(this.levelIcon);
			}
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			GameObject gameObject2;
			this.levelIcon = gameObject2;
			Transform transform = this.levelIcon.transform;
			Vector3 vector2;
			float z2 = vector2.z;
			Transform transform2 = this.levelIcon.transform;
			Vector3 vector3;
			float z3 = vector3.z;
			Transform transform3 = this.levelIcon.transform;
			Vector3 vector4;
			float z4 = vector4.z;
			Transform transform4 = this.levelIcon.transform;
			Transform transform5 = base.transform;
			transform4.parentInternal = transform5;
		}
		float num3 = this.attackSpeed;
		this.SetSpeed(num3);
	}

	// Token: 0x06001CD4 RID: 7380 RVA: 0x000999B0 File Offset: 0x00097BB0
	[Token(Token = "0x6001CD4")]
	[Address(RVA = "0x55DBF0", Offset = "0x55C1F0", VA = "0x18055DBF0", Slot = "74")]
	public virtual string GetUniqueText()
	{
		return "";
	}

	// Token: 0x06001CD5 RID: 7381 RVA: 0x000999C4 File Offset: 0x00097BC4
	[Token(Token = "0x6001CD5")]
	[Address(RVA = "0x55D890", Offset = "0x55BE90", VA = "0x18055D890")]
	public TowerPlant()
	{
	}

	// Token: 0x04000FB4 RID: 4020
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000FB4")]
	public Towards towards = (Towards)((ulong)1L);

	// Token: 0x04000FB5 RID: 4021
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x4000FB5")]
	public TowerUpgradeType upgradeType;

	// Token: 0x04000FB6 RID: 4022
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000FB6")]
	public float basicDamage = 1f;

	// Token: 0x04000FB7 RID: 4023
	[FieldOffset(Offset = "0x224")]
	[Token(Token = "0x4000FB7")]
	public float attackSpeed = 1f;

	// Token: 0x04000FB8 RID: 4024
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000FB8")]
	public float attackTimer;

	// Token: 0x04000FB9 RID: 4025
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000FB9")]
	public float attackInterval;
}
