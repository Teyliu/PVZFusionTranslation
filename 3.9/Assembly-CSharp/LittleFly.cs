using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002D3 RID: 723
[Token(Token = "0x20002D3")]
public class LittleFly : MonoBehaviour
{
	// Token: 0x06000CE0 RID: 3296 RVA: 0x000493E8 File Offset: 0x000475E8
	[Token(Token = "0x6000CE0")]
	[Address(RVA = "0x435BE0", Offset = "0x4341E0", VA = "0x180435BE0", Slot = "4")]
	protected virtual void Awake()
	{
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
		float num = global::UnityEngine.Random.Range(-0.1f, 0.1f);
		float num2 = global::UnityEngine.Random.Range(-0.1f, 0.1f);
		int num3 = 0;
		this.offset.z = (float)num3;
		Board instance = Board.Instance;
		GameObject gameObject = base.gameObject;
		this.SetLayer(gameObject);
		Transform transform = base.transform.Find("Shadow");
		this.axis = transform;
		throw new NullReferenceException();
	}

	// Token: 0x06000CE1 RID: 3297 RVA: 0x00049468 File Offset: 0x00047668
	[Token(Token = "0x6000CE1")]
	[Address(RVA = "0x436890", Offset = "0x434E90", VA = "0x180436890", Slot = "5")]
	protected virtual void Update()
	{
		int num = 0;
		Zombie zombie = this.target;
		int num2 = 0;
		bool flag = zombie == num2;
		int num3 = 0;
		if (!flag)
		{
			if (this.target.TryGetComponent<Collider2D>(num2))
			{
				Zombie zombie2 = this.target;
				if ((zombie2.isMindControlled ? 1 : 0) == num && zombie2.theStatus == ZombieStatus.Flying)
				{
					this.FollowingTarget(num2);
					Transform transform = this.axis;
					Transform transform2 = base.transform;
					Transform transform3 = base.transform;
				}
			}
			this.target = num;
		}
		Zombie zombie3 = this.GetZombie();
		this.target = zombie3;
		this.onTarget = num != 0;
		Transform transform4 = base.transform;
		float num4 = this.offset * 5f;
		Transform transform5 = base.transform;
		Transform transform6 = base.transform;
		Transform transform7 = this.parentPlant.axis;
		float deltaTime = Time.deltaTime;
		Transform transform8 = base.transform;
		Transform transform9 = base.transform;
		float deltaTime2 = Time.deltaTime;
		Transform transform10 = this.axis;
		Transform transform11 = base.transform;
		Transform transform12 = base.transform;
		Vector3 vector;
		float num5 = vector.y;
		if ((this.onTarget ? 1 : 0) != num)
		{
			float num6 = this.shootCountDown;
			if (num6 > (float)num3)
			{
				num5 = num6;
				float deltaTime3 = Time.deltaTime;
				this.shootCountDown = num5;
				this.anim.SetTrigger("shoot");
				this.shootCountDown = 1f;
			}
		}
	}

	// Token: 0x06000CE2 RID: 3298 RVA: 0x000495C0 File Offset: 0x000477C0
	[Token(Token = "0x6000CE2")]
	[Address(RVA = "0x436800", Offset = "0x434E00", VA = "0x180436800")]
	protected void ShootUpdate()
	{
		float num = this.shootCountDown;
		int num2 = 0;
		if (num > (float)num2)
		{
			float deltaTime = Time.deltaTime;
			this.shootCountDown = num;
			this.anim.SetTrigger("shoot");
			this.shootCountDown = 1f;
		}
	}

	// Token: 0x06000CE3 RID: 3299 RVA: 0x0004960C File Offset: 0x0004780C
	[Token(Token = "0x6000CE3")]
	[Address(RVA = "0x435D90", Offset = "0x434390", VA = "0x180435D90")]
	protected void FollowingTarget(Vector3 position)
	{
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		float deltaTime = Time.deltaTime;
		if (0 != 0)
		{
		}
		int num = 0;
		Transform transform3 = base.transform;
		float num2 = (float)(num * (int)57.29578f);
		Transform transform4 = base.transform;
		Transform transform5 = base.transform;
		float deltaTime2 = Time.deltaTime;
		Transform transform6 = base.transform;
		Vector3 vector;
		this.onTarget = vector != null;
	}

	// Token: 0x06000CE4 RID: 3300 RVA: 0x00049680 File Offset: 0x00047880
	[Token(Token = "0x6000CE4")]
	[Address(RVA = "0x4361A0", Offset = "0x4347A0", VA = "0x1804361A0", Slot = "6")]
	protected virtual Zombie GetZombie()
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
				if (!(num != num3))
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
		throw new NullReferenceException();
	}

	// Token: 0x06000CE5 RID: 3301 RVA: 0x000496F0 File Offset: 0x000478F0
	[Token(Token = "0x6000CE5")]
	[Address(RVA = "0x435A60", Offset = "0x434060", VA = "0x180435A60", Slot = "7")]
	protected virtual void AnimShoot()
	{
		Zombie zombie = this.target;
		int num = 0;
		if (zombie != num)
		{
			Transform transform = this.shoot.transform;
			Zombie zombie2 = this.target;
			CreateBullet instance = CreateBullet.Instance;
			Bullet bullet;
			bullet.Damage = 30;
			PlantType plantType = this.fromType;
			bullet.fromType = plantType;
		}
	}

	// Token: 0x06000CE6 RID: 3302 RVA: 0x0004974C File Offset: 0x0004794C
	[Token(Token = "0x6000CE6")]
	[Address(RVA = "0x4364B0", Offset = "0x434AB0", VA = "0x1804364B0")]
	protected void SetLayer(GameObject obj)
	{
		int num;
		do
		{
			num = 0;
			if (string.Equals(obj.name, "Shadow"))
			{
				break;
			}
			if (obj.TryGetComponent<SpriteRenderer>(num))
			{
				int currentBulletNum = Board.Instance.currentBulletNum;
			}
			Transform transform = obj.transform;
			int num2 = 0;
			IEnumerator enumerator = transform.GetEnumerator();
			if (num < num2)
			{
				num += num;
				num++;
			}
			if (num < num)
			{
				num += num;
				num++;
			}
			num += 312;
			GameObject gameObject;
			this.SetLayer(gameObject);
		}
		while (num != 0);
	}

	// Token: 0x06000CE7 RID: 3303 RVA: 0x000497DC File Offset: 0x000479DC
	[Token(Token = "0x6000CE7")]
	[Address(RVA = "0x435D00", Offset = "0x434300", VA = "0x180435D00", Slot = "8")]
	public virtual void Die()
	{
		Board instance = Board.Instance;
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000CE8 RID: 3304 RVA: 0x00049800 File Offset: 0x00047A00
	[Token(Token = "0x6000CE8")]
	[Address(RVA = "0x436E50", Offset = "0x435450", VA = "0x180436E50")]
	public LittleFly()
	{
	}

	// Token: 0x040008F7 RID: 2295
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008F7")]
	protected Zombie target;

	// Token: 0x040008F8 RID: 2296
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008F8")]
	protected float shootCountDown = 1f;

	// Token: 0x040008F9 RID: 2297
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008F9")]
	protected Animator anim;

	// Token: 0x040008FA RID: 2298
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008FA")]
	protected bool onTarget;

	// Token: 0x040008FB RID: 2299
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40008FB")]
	protected readonly float moveSpeed = 6f;

	// Token: 0x040008FC RID: 2300
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008FC")]
	protected readonly float rotationSpeed = 5f;

	// Token: 0x040008FD RID: 2301
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40008FD")]
	protected Vector3 offset;

	// Token: 0x040008FE RID: 2302
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40008FE")]
	protected Transform axis;

	// Token: 0x040008FF RID: 2303
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40008FF")]
	public GameObject shoot;

	// Token: 0x04000900 RID: 2304
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000900")]
	public int theFlyRow;

	// Token: 0x04000901 RID: 2305
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000901")]
	public Plant parentPlant;

	// Token: 0x04000902 RID: 2306
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000902")]
	public float positionOffset;

	// Token: 0x04000903 RID: 2307
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000903")]
	public PlantType fromType = (PlantType)((ulong)4294967295L);
}
