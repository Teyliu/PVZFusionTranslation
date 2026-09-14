using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006CB RID: 1739
[Token(Token = "0x20006CB")]
public class Kirov_a : Zombie, IAirCrashable
{
	// Token: 0x170001A6 RID: 422
	// (get) Token: 0x060021AB RID: 8619 RVA: 0x000B1378 File Offset: 0x000AF578
	[Token(Token = "0x170001A6")]
	public virtual float CrashNeedCount
	{
		[Token(Token = "0x60021AB")]
		[Address(RVA = "0x5BD8A0", Offset = "0x5BBEA0", VA = "0x1805BD8A0", Slot = "80")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170001A7 RID: 423
	// (get) Token: 0x060021AC RID: 8620 RVA: 0x000B138C File Offset: 0x000AF58C
	// (set) Token: 0x060021AD RID: 8621 RVA: 0x000B13A0 File Offset: 0x000AF5A0
	[Token(Token = "0x170001A7")]
	public float CurrentCount
	{
		[Token(Token = "0x60021AC")]
		[Address(RVA = "0x5BD8B0", Offset = "0x5BBEB0", VA = "0x1805BD8B0", Slot = "77")]
		get;
		[Token(Token = "0x60021AD")]
		[Address(RVA = "0x5BD8C0", Offset = "0x5BBEC0", VA = "0x1805BD8C0", Slot = "78")]
		set;
	}

	// Token: 0x060021AE RID: 8622 RVA: 0x000B13B4 File Offset: 0x000AF5B4
	[Token(Token = "0x60021AE")]
	[Address(RVA = "0x5BD750", Offset = "0x5BBD50", VA = "0x1805BD750", Slot = "79")]
	public void OnCrash(float value)
	{
		this.<CurrentCount>k__BackingField = value;
		float crashNeedCount = this.CrashNeedCount;
		this.anim.SetTrigger("crash");
		global::UnityEngine.Object.Destroy(this.col);
		GameAPP.PlaySound(83, 1f, 1f);
		this.beforeDying = true;
	}

	// Token: 0x060021AF RID: 8623 RVA: 0x000B1408 File Offset: 0x000AF608
	[Token(Token = "0x60021AF")]
	[Address(RVA = "0x5BD3F0", Offset = "0x5BB9F0", VA = "0x1805BD3F0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 1.5f;
		this.theStatus = (ZombieStatus)((ulong)10L);
	}

	// Token: 0x060021B0 RID: 8624 RVA: 0x000B1430 File Offset: 0x000AF630
	[Token(Token = "0x60021B0")]
	[Address(RVA = "0x5BD420", Offset = "0x5BBA20", VA = "0x1805BD420", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		ulong num2;
		do
		{
			List<Transform> changeSprites = this.changeSprites;
			bool flag;
			if (flag)
			{
				int num = 0;
				GameObject gameObject;
				Lawnf.ChangeSprite((float)0, (float)num, gameObject);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x060021B1 RID: 8625 RVA: 0x000B1468 File Offset: 0x000AF668
	[Token(Token = "0x60021B1")]
	[Address(RVA = "0x5BD0A0", Offset = "0x5BB6A0", VA = "0x1805BD0A0", Slot = "24")]
	protected override void AttributeEvent()
	{
		Transform axis = this.axis;
		int num = 0;
		this.attributeCountDown = 1.5f;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int theZombieRow = this.theZombieRow;
				if ((num <= 10 || (num != 12 && 18446744073709551596UL > (ulong)4L)) && num != 1 && num != 10)
				{
					goto IL_0080;
				}
			}
			num++;
			LayerMask plantLayer = this.plantLayer;
			Collider2D[] array2;
			if (num >= array2.Length)
			{
				return;
			}
			bool flag2;
			if (flag2)
			{
				int theZombieRow2 = this.theZombieRow;
				bool flag3;
				if (!flag3)
				{
					goto IL_0080;
				}
			}
			num++;
			IL_0080:
			this.AnimShoot();
			GameAPP.PlaySound(flag2 ? 1 : 0, 0.5f, 1f);
		}
	}

	// Token: 0x060021B2 RID: 8626 RVA: 0x000B1514 File Offset: 0x000AF714
	[Token(Token = "0x60021B2")]
	[Address(RVA = "0x5BCDF0", Offset = "0x5BB3F0", VA = "0x1805BCDF0")]
	private void AnimShoot()
	{
		this.anim.SetTrigger("shoot");
		GameObject[] itemPrefab = GameAPP.itemPrefab;
		Transform shoot = this.shoot;
		GameObject gameObject = itemPrefab[3];
		Vector3 vector;
		float z = vector.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		KirovBomb kirovBomb = gameObject2.AddComponent<KirovBomb>();
		int theZombieRow = this.theZombieRow;
		kirovBomb.bombRow = theZombieRow;
		bool isMindControlled = this.isMindControlled;
		kirovBomb.fromHypno = isMindControlled;
		SpriteRenderer component = gameObject2.GetComponent<SpriteRenderer>();
		int theZombieRow2 = this.theZombieRow;
		string text = string.Format("bullet{0}", component);
		component.sortingLayerName = text;
	}

	// Token: 0x060021B3 RID: 8627 RVA: 0x000B15BC File Offset: 0x000AF7BC
	[Token(Token = "0x60021B3")]
	[Address(RVA = "0x5BD590", Offset = "0x5BBB90", VA = "0x1805BD590", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		GameAPP.PlaySound(43, 0.5f, 1f);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = GameAPP.particlePrefab[34];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
	}

	// Token: 0x060021B4 RID: 8628 RVA: 0x000B1614 File Offset: 0x000AF814
	[Token(Token = "0x60021B4")]
	[Address(RVA = "0x589F50", Offset = "0x588550", VA = "0x180589F50", Slot = "28")]
	public override void Die(int reason = 0)
	{
		bool flag = reason != 1;
		base.Die(flag ? 1 : 0);
	}

	// Token: 0x060021B5 RID: 8629 RVA: 0x000B1634 File Offset: 0x000AF834
	[Token(Token = "0x60021B5")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x060021B6 RID: 8630 RVA: 0x000B1644 File Offset: 0x000AF844
	[Token(Token = "0x60021B6")]
	[Address(RVA = "0x58E820", Offset = "0x58CE20", VA = "0x18058E820")]
	private void CrashEvent()
	{
	}

	// Token: 0x060021B7 RID: 8631 RVA: 0x000B1654 File Offset: 0x000AF854
	[Token(Token = "0x60021B7")]
	[Address(RVA = "0x5BD850", Offset = "0x5BBE50", VA = "0x1805BD850")]
	public Kirov_a()
	{
	}
}
