using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005CD RID: 1485
[Token(Token = "0x20005CD")]
public class TowerPlant : Plant
{
	// Token: 0x17000141 RID: 321
	// (get) Token: 0x06001BC5 RID: 7109 RVA: 0x0009498C File Offset: 0x00092B8C
	[Token(Token = "0x17000141")]
	public int Damage
	{
		[Token(Token = "0x6001BC5")]
		[Address(RVA = "0x50D3E0", Offset = "0x50B9E0", VA = "0x18050D3E0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000142 RID: 322
	// (get) Token: 0x06001BC6 RID: 7110 RVA: 0x0009499C File Offset: 0x00092B9C
	[Token(Token = "0x17000142")]
	public BulletMoveWay TowardsMoveWay
	{
		[Token(Token = "0x6001BC6")]
		[Address(RVA = "0x50D400", Offset = "0x50BA00", VA = "0x18050D400")]
		get
		{
			return BulletMoveWay.MoveRight;
		}
	}

	// Token: 0x06001BC7 RID: 7111 RVA: 0x000949B4 File Offset: 0x00092BB4
	[Token(Token = "0x6001BC7")]
	[Address(RVA = "0x50C690", Offset = "0x50AC90", VA = "0x18050C690", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.SetSpeed(1f);
	}

	// Token: 0x06001BC8 RID: 7112 RVA: 0x000949D4 File Offset: 0x00092BD4
	[Token(Token = "0x6001BC8")]
	[Address(RVA = "0x50CF40", Offset = "0x50B540", VA = "0x18050CF40", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		float thePlantAttackInterval = this.thePlantAttackInterval;
		this.attackInterval = thePlantAttackInterval;
	}

	// Token: 0x06001BC9 RID: 7113 RVA: 0x000949F8 File Offset: 0x00092BF8
	[Token(Token = "0x6001BC9")]
	[Address(RVA = "0x50CD00", Offset = "0x50B300", VA = "0x18050CD00")]
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

	// Token: 0x06001BCA RID: 7114 RVA: 0x00094A4C File Offset: 0x00092C4C
	[Token(Token = "0x6001BCA")]
	[Address(RVA = "0x413080", Offset = "0x411680", VA = "0x180413080", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
		}
	}

	// Token: 0x06001BCB RID: 7115 RVA: 0x00094A68 File Offset: 0x00092C68
	[Token(Token = "0x6001BCB")]
	[Address(RVA = "0x50CE00", Offset = "0x50B400", VA = "0x18050CE00", Slot = "69")]
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

	// Token: 0x06001BCC RID: 7116 RVA: 0x00094AB8 File Offset: 0x00092CB8
	[Token(Token = "0x6001BCC")]
	[Address(RVA = "0x50CF00", Offset = "0x50B500", VA = "0x18050CF00", Slot = "47")]
	protected override bool Shootable()
	{
		while (!base.Shootable())
		{
		}
		return true;
	}

	// Token: 0x06001BCD RID: 7117 RVA: 0x00094AD0 File Offset: 0x00092CD0
	[Token(Token = "0x6001BCD")]
	[Address(RVA = "0x50C6C0", Offset = "0x50ACC0", VA = "0x18050C6C0", Slot = "70")]
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

	// Token: 0x06001BCE RID: 7118 RVA: 0x00094B44 File Offset: 0x00092D44
	[Token(Token = "0x6001BCE")]
	[Address(RVA = "0x50CEB0", Offset = "0x50B4B0", VA = "0x18050CEB0", Slot = "71")]
	public virtual void Shoot()
	{
		this.anim.SetTrigger("shoot");
	}

	// Token: 0x06001BCF RID: 7119 RVA: 0x00094B68 File Offset: 0x00092D68
	[Token(Token = "0x6001BCF")]
	[Address(RVA = "0x50CB80", Offset = "0x50B180", VA = "0x18050CB80")]
	public void SetSpeed(float value)
	{
		Animator anim = this.anim;
		this.attackSpeed = value;
		AnimatorControllerParameter[] parameters = anim.parameters;
		Func<AnimatorControllerParameter, bool> <>9__18_ = TowerPlant.<>c.<>9__18_0;
		if (<>9__18_ == 0)
		{
			Func<AnimatorControllerParameter, bool> func;
			TowerPlant.<>c.<>9__18_0 = func;
		}
		if (Enumerable.Any<AnimatorControllerParameter>(parameters, <>9__18_))
		{
			this.anim.SetFloat("attackSpeed", value);
		}
	}

	// Token: 0x06001BD0 RID: 7120 RVA: 0x00094BBC File Offset: 0x00092DBC
	[Token(Token = "0x6001BD0")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "72")]
	public virtual void AnimShoot()
	{
	}

	// Token: 0x06001BD1 RID: 7121 RVA: 0x00094BCC File Offset: 0x00092DCC
	[Token(Token = "0x6001BD1")]
	[Address(RVA = "0x50C9D0", Offset = "0x50AFD0", VA = "0x18050C9D0", Slot = "44")]
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

	// Token: 0x06001BD2 RID: 7122 RVA: 0x00094C20 File Offset: 0x00092E20
	[Token(Token = "0x6001BD2")]
	[Address(RVA = "0x50C8A0", Offset = "0x50AEA0", VA = "0x18050C8A0", Slot = "73")]
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

	// Token: 0x06001BD3 RID: 7123 RVA: 0x00094C84 File Offset: 0x00092E84
	[Token(Token = "0x6001BD3")]
	[Address(RVA = "0x50C670", Offset = "0x50AC70", VA = "0x18050C670")]
	protected void AddDamage(float value)
	{
		this.basicDamage = value;
	}

	// Token: 0x06001BD4 RID: 7124 RVA: 0x00094C98 File Offset: 0x00092E98
	[Token(Token = "0x6001BD4")]
	[Address(RVA = "0x50CF70", Offset = "0x50B570", VA = "0x18050CF70", Slot = "74")]
	public virtual void Upgrade(TowerUpgradeType towerUpgradeType)
	{
		this.upgradeType = towerUpgradeType;
		if (towerUpgradeType == TowerUpgradeType.Upgraded)
		{
			GameObject gameObject = GameAPP.itemPrefab[43];
		}
		GameObject gameObject2 = GameAPP.itemPrefab[45];
		int num = 0;
		if (gameObject2 != num)
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
			GameObject gameObject3;
			this.levelIcon = gameObject3;
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

	// Token: 0x06001BD5 RID: 7125 RVA: 0x00094D98 File Offset: 0x00092F98
	[Token(Token = "0x6001BD5")]
	[Address(RVA = "0x50C9A0", Offset = "0x50AFA0", VA = "0x18050C9A0", Slot = "75")]
	public virtual string GetUniqueText()
	{
		return "";
	}

	// Token: 0x06001BD6 RID: 7126 RVA: 0x00094DAC File Offset: 0x00092FAC
	[Token(Token = "0x6001BD6")]
	[Address(RVA = "0x50C640", Offset = "0x50AC40", VA = "0x18050C640")]
	public TowerPlant()
	{
	}

	// Token: 0x04000EEC RID: 3820
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000EEC")]
	public Towards towards = (Towards)((ulong)1L);

	// Token: 0x04000EED RID: 3821
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x4000EED")]
	public TowerUpgradeType upgradeType;

	// Token: 0x04000EEE RID: 3822
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000EEE")]
	public float basicDamage = 1f;

	// Token: 0x04000EEF RID: 3823
	[FieldOffset(Offset = "0x224")]
	[Token(Token = "0x4000EEF")]
	public float attackSpeed = 1f;

	// Token: 0x04000EF0 RID: 3824
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000EF0")]
	public float attackTimer;

	// Token: 0x04000EF1 RID: 3825
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000EF1")]
	public float attackInterval;
}
