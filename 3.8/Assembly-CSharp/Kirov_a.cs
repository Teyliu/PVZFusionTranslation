using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000694 RID: 1684
[Token(Token = "0x2000694")]
public class Kirov_a : Zombie, IAirCrashable
{
	// Token: 0x17000160 RID: 352
	// (get) Token: 0x06002094 RID: 8340 RVA: 0x000AC730 File Offset: 0x000AA930
	[Token(Token = "0x17000160")]
	public virtual float CrashNeedCount
	{
		[Token(Token = "0x6002094")]
		[Address(RVA = "0x55AB60", Offset = "0x559160", VA = "0x18055AB60", Slot = "78")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000161 RID: 353
	// (get) Token: 0x06002095 RID: 8341 RVA: 0x000AC744 File Offset: 0x000AA944
	// (set) Token: 0x06002096 RID: 8342 RVA: 0x000AC758 File Offset: 0x000AA958
	[Token(Token = "0x17000161")]
	public float CurrentCount
	{
		[Token(Token = "0x6002095")]
		[Address(RVA = "0x55AB70", Offset = "0x559170", VA = "0x18055AB70", Slot = "75")]
		get;
		[Token(Token = "0x6002096")]
		[Address(RVA = "0x55AB80", Offset = "0x559180", VA = "0x18055AB80", Slot = "76")]
		set;
	}

	// Token: 0x06002097 RID: 8343 RVA: 0x000AC76C File Offset: 0x000AA96C
	[Token(Token = "0x6002097")]
	[Address(RVA = "0x55AA20", Offset = "0x559020", VA = "0x18055AA20", Slot = "77")]
	public void OnCrash(float value)
	{
		this.<CurrentCount>k__BackingField = value;
		float crashNeedCount = this.CrashNeedCount;
		this.anim.SetTrigger("crash");
		global::UnityEngine.Object.Destroy(this.col);
		GameAPP.PlaySound(83, 1f, 1f);
	}

	// Token: 0x06002098 RID: 8344 RVA: 0x000AC7BC File Offset: 0x000AA9BC
	[Token(Token = "0x6002098")]
	[Address(RVA = "0x55A6C0", Offset = "0x558CC0", VA = "0x18055A6C0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 1.5f;
		this.theStatus = (ZombieStatus)((ulong)10L);
	}

	// Token: 0x06002099 RID: 8345 RVA: 0x000AC7E4 File Offset: 0x000AA9E4
	[Token(Token = "0x6002099")]
	[Address(RVA = "0x55A6F0", Offset = "0x558CF0", VA = "0x18055A6F0", Slot = "29")]
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
				Lawnf.ChangeSprite((float)num2, (float)num, gameObject);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x0600209A RID: 8346 RVA: 0x000AC820 File Offset: 0x000AAA20
	[Token(Token = "0x600209A")]
	[Address(RVA = "0x55A370", Offset = "0x558970", VA = "0x18055A370", Slot = "23")]
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

	// Token: 0x0600209B RID: 8347 RVA: 0x000AC8CC File Offset: 0x000AAACC
	[Token(Token = "0x600209B")]
	[Address(RVA = "0x55A0C0", Offset = "0x5586C0", VA = "0x18055A0C0")]
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

	// Token: 0x0600209C RID: 8348 RVA: 0x000AC974 File Offset: 0x000AAB74
	[Token(Token = "0x600209C")]
	[Address(RVA = "0x55A860", Offset = "0x558E60", VA = "0x18055A860", Slot = "28")]
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

	// Token: 0x0600209D RID: 8349 RVA: 0x000AC9CC File Offset: 0x000AABCC
	[Token(Token = "0x600209D")]
	[Address(RVA = "0x533270", Offset = "0x531870", VA = "0x180533270", Slot = "27")]
	public override void Die(int reason = 0)
	{
		bool flag = reason != 1;
		base.Die(flag ? 1 : 0);
	}

	// Token: 0x0600209E RID: 8350 RVA: 0x000AC9EC File Offset: 0x000AABEC
	[Token(Token = "0x600209E")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x0600209F RID: 8351 RVA: 0x000AC9FC File Offset: 0x000AABFC
	[Token(Token = "0x600209F")]
	[Address(RVA = "0x537B40", Offset = "0x536140", VA = "0x180537B40")]
	private void CrashEvent()
	{
	}

	// Token: 0x060020A0 RID: 8352 RVA: 0x000ACA0C File Offset: 0x000AAC0C
	[Token(Token = "0x60020A0")]
	[Address(RVA = "0x55AB10", Offset = "0x559110", VA = "0x18055AB10")]
	public Kirov_a()
	{
	}
}
