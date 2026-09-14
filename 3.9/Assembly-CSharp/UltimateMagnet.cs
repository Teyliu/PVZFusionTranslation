using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004A3 RID: 1187
[Token(Token = "0x20004A3")]
public class UltimateMagnet : LanternMagnet
{
	// Token: 0x0600161A RID: 5658 RVA: 0x000797F4 File Offset: 0x000779F4
	[Token(Token = "0x600161A")]
	[Address(RVA = "0x4E82E0", Offset = "0x4E68E0", VA = "0x1804E82E0", Slot = "77")]
	protected override void SetRange()
	{
		base.SetRange();
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)26)))
		{
			float attrackRange = this.attrackRange;
			this.attrackRange = attrackRange;
		}
	}

	// Token: 0x0600161B RID: 5659 RVA: 0x00079820 File Offset: 0x00077A20
	[Token(Token = "0x600161B")]
	[Address(RVA = "0x4E7F80", Offset = "0x4E6580", VA = "0x1804E7F80", Slot = "69")]
	protected override void SearchZombieWithIron()
	{
		int num = 0;
		bool flag;
		if (flag)
		{
			Transform axis = this.axis;
			LayerMask magnetLayer = this.magnetLayer;
			float attrackRange = this.attrackRange;
			int num2 = magnetLayer;
			Collider2D[] array;
			if (num < array.Length)
			{
				bool flag2;
				bool flag3;
				if (flag2)
				{
					float rangeRow = this.rangeRow;
					if (base.TryAttrackZombie(num))
					{
						num++;
						if (num > 3)
						{
							return;
						}
					}
				}
				else if (flag3)
				{
					float rangeRow2 = this.rangeRow;
					this.attrackType = (BucketType)((ulong)7L);
					GameObject gameObject2;
					GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(gameObject2);
					Bucket bucket = this.AttrackItem(gameObject, num);
				}
				num++;
			}
			base.AttributeCountdown = 0.5f;
		}
		base.SearchZombieWithIron();
	}

	// Token: 0x0600161C RID: 5660 RVA: 0x000798C8 File Offset: 0x00077AC8
	[Token(Token = "0x600161C")]
	[Address(RVA = "0x4E7B90", Offset = "0x4E6190", VA = "0x1804E7B90", Slot = "71")]
	protected override bool MoreAttrack(Zombie zombie)
	{
		ZombieType theZombieType = zombie.theZombieType;
		if (theZombieType > ZombieType.JackboxJumpZombie)
		{
			if (typeof(PogoZombie).TypeHandle <= (ulong)3L || typeof(PogoZombie).TypeHandle <= (ulong)2L)
			{
				goto IL_0130;
			}
			if (typeof(PogoZombie).TypeHandle > (ulong)2L)
			{
				goto IL_014B;
			}
			List<GameObject> theUniqueItems = zombie.theUniqueItems;
			int num = 0;
			GameObject gameObject = theUniqueItems[num];
			int num2 = 0;
			if (!(gameObject != num2))
			{
				goto IL_014B;
			}
			this.attrackType = (BucketType)((ulong)2L);
			List<GameObject> theUniqueItems2 = zombie.theUniqueItems;
			int num3 = 0;
			GameObject gameObject2 = theUniqueItems2[num3];
			int theZombieRow = zombie.theZombieRow;
			Bucket bucket = this.AttrackItem(gameObject2, theZombieRow);
		}
		if (typeof(PogoZombie).TypeHandle != 0)
		{
			if (typeof(PogoZombie).TypeHandle == 0)
			{
				goto IL_014B;
			}
			if (typeof(PogoZombie).TypeHandle != 0)
			{
				if (typeof(PogoZombie).TypeHandle == 0)
				{
					goto IL_014B;
				}
				if (typeof(PogoZombie).TypeHandle != (ulong)1L)
				{
					if (theZombieType != ZombieType.JackboxJumpZombie)
					{
						goto IL_014B;
					}
					List<GameObject> theUniqueItems3 = zombie.theUniqueItems;
					int num4 = 0;
					GameObject gameObject3 = theUniqueItems3[num4];
					int num5 = 0;
					if (!(gameObject3 != num5))
					{
						goto IL_014B;
					}
					this.attrackType = (BucketType)((ulong)2L);
					List<GameObject> theUniqueItems4 = zombie.theUniqueItems;
					int num6 = 0;
					GameObject gameObject4 = theUniqueItems4[num6];
					int theZombieRow2 = zombie.theZombieRow;
					Bucket bucket2 = this.AttrackItem(gameObject4, theZombieRow2);
				}
				this.attrackType = (BucketType)((ulong)2L);
			}
		}
		IL_0130:
		base.AttributeCountdown = 0.5f;
		PlantType thePlantType = this.thePlantType;
		bool flag;
		if (flag)
		{
		}
		IL_014B:
		return base.DetactiveEnermy();
	}

	// Token: 0x0600161D RID: 5661 RVA: 0x00079A30 File Offset: 0x00077C30
	[Token(Token = "0x600161D")]
	[Address(RVA = "0x4E7950", Offset = "0x4E5F50", VA = "0x1804E7950")]
	private void BucketsUpdate()
	{
		int size = this.buckets._size;
		int num = size - 1;
		if (size > 0)
		{
			UltimateMagnet.AttrackedBucket attrackedBucket = this.buckets[num];
			if (attrackedBucket != 0)
			{
				Bucket bucket = attrackedBucket.bucket;
				int num2 = 0;
				if (!(bucket == num2))
				{
					attrackedBucket.Update();
					if (attrackedBucket.existTimer <= 3f)
					{
						goto IL_0073;
					}
					this.buckets.RemoveAt(num);
					this.AddToBullets(attrackedBucket);
					this.Shoot(attrackedBucket);
				}
			}
			this.buckets.RemoveAt(num);
		}
		IL_0073:
		int size2 = this.bullets._size;
		int num3 = size2 - 1;
		if (size2 > 0)
		{
			UltimateMagnet.AttrackedBucket attrackedBucket2 = this.bullets[num3];
			attrackedBucket2.BulletUpdate();
			if (attrackedBucket2.die)
			{
				this.bullets.RemoveAt(num3);
				global::UnityEngine.Object.Destroy(attrackedBucket2.bucket.gameObject);
			}
		}
	}

	// Token: 0x0600161E RID: 5662 RVA: 0x00079B0C File Offset: 0x00077D0C
	[Token(Token = "0x600161E")]
	[Address(RVA = "0x4E75A0", Offset = "0x4E5BA0", VA = "0x1804E75A0")]
	private void AddToBullets(UltimateMagnet.AttrackedBucket bucket)
	{
		List<UltimateMagnet.AttrackedBucket> list = this.bullets;
		int num = 0;
		UltimateMagnet.AttrackedBucket attrackedBucket = list[num];
		List<UltimateMagnet.AttrackedBucket> list2 = this.bullets;
		if (attrackedBucket != 0)
		{
			num++;
		}
		list2[num] = bucket;
	}

	// Token: 0x0600161F RID: 5663 RVA: 0x00079B48 File Offset: 0x00077D48
	[Token(Token = "0x600161F")]
	[Address(RVA = "0x4E8320", Offset = "0x4E6920", VA = "0x1804E8320")]
	private void Shoot(UltimateMagnet.AttrackedBucket bucket)
	{
		ulong num3;
		do
		{
			int num = 0;
			int attackDamage = this.attackDamage;
			bucket.damage = attackDamage;
			Transform shoot = this.shoot;
			Vector3 vector;
			float z = vector.z;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				if (!base.AttackLandZombie(num))
				{
				}
				bool flag2;
				while (!flag2)
				{
				}
				bool flag3;
				while (!flag3)
				{
				}
				Transform transform = bucket.bucket.transform;
				Vector3 vector2;
				float z2 = vector2.z;
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06001620 RID: 5664 RVA: 0x00079BF0 File Offset: 0x00077DF0
	[Token(Token = "0x6001620")]
	[Address(RVA = "0x4E7690", Offset = "0x4E5C90", VA = "0x1804E7690", Slot = "72")]
	protected override Bucket AttrackItem(GameObject item, int theRow)
	{
		Bucket bucket = base.AttrackItem(item, theRow);
		int num = 0;
		if (bucket != num)
		{
			Transform shoot = this.shoot;
			float num2 = this.period;
			UltimateMagnet.AttrackedBucket attrackedBucket;
			attrackedBucket.centerPoint = shoot;
			attrackedBucket.radius = 1f;
			attrackedBucket.bucket = bucket;
			attrackedBucket.angularSpeed = 6.2831855f;
			List<UltimateMagnet.AttrackedBucket> list = this.buckets;
			List<UltimateMagnet.AttrackedBucket> list2 = this.buckets;
			int num3 = 0;
			UltimateMagnet.AttrackedBucket attrackedBucket2 = list2[num3];
			List<UltimateMagnet.AttrackedBucket> list3 = this.buckets;
			int num4 = 0;
			if (num4 > (int)num2 || num2 > 6.2831855f)
			{
			}
			this.buckets[1].angle = (float)num4;
			List<UltimateMagnet.AttrackedBucket> list4 = this.buckets;
			global::UnityEngine.Object.Destroy(bucket.GetComponent<Collider2D>());
			base.AttributeCountdown = 0.5f;
		}
		return bucket;
	}

	// Token: 0x06001621 RID: 5665 RVA: 0x00079CBC File Offset: 0x00077EBC
	[Token(Token = "0x6001621")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "39")]
	protected override void AttributeEvent()
	{
	}

	// Token: 0x06001622 RID: 5666 RVA: 0x00079CCC File Offset: 0x00077ECC
	[Token(Token = "0x6001622")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
	}

	// Token: 0x06001623 RID: 5667 RVA: 0x00079CDC File Offset: 0x00077EDC
	[Token(Token = "0x6001623")]
	[Address(RVA = "0x4E86C0", Offset = "0x4E6CC0", VA = "0x1804E86C0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		this.BucketsUpdate();
		List<UltimateMagnet.AttrackedBucket> list = this.buckets;
		bool flag;
		this.anim.SetBool("attracking", flag);
	}

	// Token: 0x06001624 RID: 5668 RVA: 0x00079D18 File Offset: 0x00077F18
	[Token(Token = "0x6001624")]
	[Address(RVA = "0x4E8780", Offset = "0x4E6D80", VA = "0x1804E8780")]
	public UltimateMagnet()
	{
		List<UltimateMagnet.AttrackedBucket> list = new List();
		this.buckets = list;
		List<UltimateMagnet.AttrackedBucket> list2 = new List();
		this.bullets = list2;
		base..ctor();
	}

	// Token: 0x04000DB6 RID: 3510
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000DB6")]
	private readonly float period = 3f;

	// Token: 0x04000DB7 RID: 3511
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000DB7")]
	private readonly List<UltimateMagnet.AttrackedBucket> buckets;

	// Token: 0x04000DB8 RID: 3512
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x4000DB8")]
	private readonly List<UltimateMagnet.AttrackedBucket> bullets;

	// Token: 0x020004A4 RID: 1188
	[Token(Token = "0x20004A4")]
	private class AttrackedBucket
	{
		// Token: 0x06001625 RID: 5669 RVA: 0x00079D50 File Offset: 0x00077F50
		[Token(Token = "0x6001625")]
		[Address(RVA = "0x4D8F40", Offset = "0x4D7540", VA = "0x1804D8F40")]
		public AttrackedBucket(Transform centerPoint, float radius, Bucket bucket, float angularSpeed)
		{
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x00079D7C File Offset: 0x00077F7C
		[Token(Token = "0x6001626")]
		[Address(RVA = "0x4D8D60", Offset = "0x4D7360", VA = "0x1804D8D60")]
		public void Update()
		{
			float num = this.angle;
			float deltaTime = Time.deltaTime;
			float num2 = this.existTimer;
			this.angle = deltaTime;
			float deltaTime2 = Time.deltaTime;
			Transform transform = this.centerPoint;
			this.existTimer = deltaTime2;
			int num3 = 0;
			if (!(transform == num3))
			{
				Transform transform2 = this.centerPoint;
				Transform transform3 = this.centerPoint;
				Transform transform4 = this.bucket.transform;
				Transform transform5 = this.bucket.transform;
				Vector3 vector;
				float z = vector.z;
				float deltaTime3 = Time.deltaTime;
				int num4 = 0;
				float num5 = deltaTime3 * 10f;
				if (num4 > (int)num5 || num5 > 1f)
				{
				}
			}
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x00079E30 File Offset: 0x00078030
		[Token(Token = "0x6001627")]
		[Address(RVA = "0x4D89E0", Offset = "0x4D6FE0", VA = "0x1804D89E0")]
		public void BulletUpdate()
		{
			Transform transform = this.bucket.transform;
			Vector3 vector;
			float z = vector.z;
			Transform transform2 = this.bucket.transform;
			float deltaTime = Time.deltaTime;
			Transform transform3 = this.bucket.transform;
			Vector3 vector2;
			float z2 = vector2.z;
			float timeScale = Time.timeScale;
			Mouse instance = Mouse.Instance;
			Transform transform4 = this.bucket.transform;
			Transform transform5 = this.bucket.transform;
			BoardAction boardAction = Board.Instance.boardAction;
			Transform transform6 = this.bucket.transform;
			int num = this.damage;
			this.die = true;
		}

		// Token: 0x04000DB9 RID: 3513
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000DB9")]
		public Bucket bucket = bucket;

		// Token: 0x04000DBA RID: 3514
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000DBA")]
		public Vector2 targetPosition;

		// Token: 0x04000DBB RID: 3515
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000DBB")]
		public bool die;

		// Token: 0x04000DBC RID: 3516
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000DBC")]
		public int damage;

		// Token: 0x04000DBD RID: 3517
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000DBD")]
		public int count;

		// Token: 0x04000DBE RID: 3518
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000DBE")]
		public float angle;

		// Token: 0x04000DBF RID: 3519
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000DBF")]
		public float existTimer;

		// Token: 0x04000DC0 RID: 3520
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000DC0")]
		private readonly Transform centerPoint = centerPoint;

		// Token: 0x04000DC1 RID: 3521
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000DC1")]
		private readonly float radius = radius;

		// Token: 0x04000DC2 RID: 3522
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4000DC2")]
		private readonly float angularSpeed = (float)0;
	}
}
