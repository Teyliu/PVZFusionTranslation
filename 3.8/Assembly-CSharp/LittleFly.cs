using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002C5 RID: 709
[Token(Token = "0x20002C5")]
public class LittleFly : MonoBehaviour
{
	// Token: 0x06000C9D RID: 3229 RVA: 0x000487FC File Offset: 0x000469FC
	[Token(Token = "0x6000C9D")]
	[Address(RVA = "0x3E50A0", Offset = "0x3E36A0", VA = "0x1803E50A0", Slot = "4")]
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

	// Token: 0x06000C9E RID: 3230 RVA: 0x0004887C File Offset: 0x00046A7C
	[Token(Token = "0x6000C9E")]
	[Address(RVA = "0x3E5D50", Offset = "0x3E4350", VA = "0x1803E5D50", Slot = "5")]
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

	// Token: 0x06000C9F RID: 3231 RVA: 0x000489D4 File Offset: 0x00046BD4
	[Token(Token = "0x6000C9F")]
	[Address(RVA = "0x3E5CC0", Offset = "0x3E42C0", VA = "0x1803E5CC0")]
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

	// Token: 0x06000CA0 RID: 3232 RVA: 0x00048A20 File Offset: 0x00046C20
	[Token(Token = "0x6000CA0")]
	[Address(RVA = "0x3E5250", Offset = "0x3E3850", VA = "0x1803E5250")]
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

	// Token: 0x06000CA1 RID: 3233 RVA: 0x00048A94 File Offset: 0x00046C94
	[Token(Token = "0x6000CA1")]
	[Address(RVA = "0x3E5660", Offset = "0x3E3C60", VA = "0x1803E5660", Slot = "6")]
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

	// Token: 0x06000CA2 RID: 3234 RVA: 0x00048B04 File Offset: 0x00046D04
	[Token(Token = "0x6000CA2")]
	[Address(RVA = "0x3E4F20", Offset = "0x3E3520", VA = "0x1803E4F20", Slot = "7")]
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

	// Token: 0x06000CA3 RID: 3235 RVA: 0x00048B60 File Offset: 0x00046D60
	[Token(Token = "0x6000CA3")]
	[Address(RVA = "0x3E5970", Offset = "0x3E3F70", VA = "0x1803E5970")]
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

	// Token: 0x06000CA4 RID: 3236 RVA: 0x00048BF0 File Offset: 0x00046DF0
	[Token(Token = "0x6000CA4")]
	[Address(RVA = "0x3E51C0", Offset = "0x3E37C0", VA = "0x1803E51C0", Slot = "8")]
	public virtual void Die()
	{
		Board instance = Board.Instance;
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000CA5 RID: 3237 RVA: 0x00048C14 File Offset: 0x00046E14
	[Token(Token = "0x6000CA5")]
	[Address(RVA = "0x3E6310", Offset = "0x3E4910", VA = "0x1803E6310")]
	public LittleFly()
	{
	}

	// Token: 0x040008BA RID: 2234
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008BA")]
	protected Zombie target;

	// Token: 0x040008BB RID: 2235
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008BB")]
	protected float shootCountDown = 1f;

	// Token: 0x040008BC RID: 2236
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008BC")]
	protected Animator anim;

	// Token: 0x040008BD RID: 2237
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008BD")]
	protected bool onTarget;

	// Token: 0x040008BE RID: 2238
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40008BE")]
	protected readonly float moveSpeed = 6f;

	// Token: 0x040008BF RID: 2239
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008BF")]
	protected readonly float rotationSpeed = 5f;

	// Token: 0x040008C0 RID: 2240
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40008C0")]
	protected Vector3 offset;

	// Token: 0x040008C1 RID: 2241
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40008C1")]
	protected Transform axis;

	// Token: 0x040008C2 RID: 2242
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40008C2")]
	public GameObject shoot;

	// Token: 0x040008C3 RID: 2243
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40008C3")]
	public int theFlyRow;

	// Token: 0x040008C4 RID: 2244
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40008C4")]
	public Plant parentPlant;

	// Token: 0x040008C5 RID: 2245
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40008C5")]
	public float positionOffset;

	// Token: 0x040008C6 RID: 2246
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40008C6")]
	public PlantType fromType = (PlantType)((ulong)4294967295L);
}
