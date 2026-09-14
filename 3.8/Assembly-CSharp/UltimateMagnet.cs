using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000481 RID: 1153
[Token(Token = "0x2000481")]
public class UltimateMagnet : LanternMagnet
{
	// Token: 0x0600157A RID: 5498 RVA: 0x00076E78 File Offset: 0x00075078
	[Token(Token = "0x600157A")]
	[Address(RVA = "0x48ED60", Offset = "0x48D360", VA = "0x18048ED60", Slot = "78")]
	protected override void SetRange()
	{
		base.SetRange();
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)26)))
		{
			float attrackRange = this.attrackRange;
			this.attrackRange = attrackRange;
		}
	}

	// Token: 0x0600157B RID: 5499 RVA: 0x00076EA4 File Offset: 0x000750A4
	[Token(Token = "0x600157B")]
	[Address(RVA = "0x48EA00", Offset = "0x48D000", VA = "0x18048EA00", Slot = "70")]
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

	// Token: 0x0600157C RID: 5500 RVA: 0x00076F4C File Offset: 0x0007514C
	[Token(Token = "0x600157C")]
	[Address(RVA = "0x48E610", Offset = "0x48CC10", VA = "0x18048E610", Slot = "72")]
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

	// Token: 0x0600157D RID: 5501 RVA: 0x000770B4 File Offset: 0x000752B4
	[Token(Token = "0x600157D")]
	[Address(RVA = "0x48E3D0", Offset = "0x48C9D0", VA = "0x18048E3D0")]
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

	// Token: 0x0600157E RID: 5502 RVA: 0x00077190 File Offset: 0x00075390
	[Token(Token = "0x600157E")]
	[Address(RVA = "0x48E020", Offset = "0x48C620", VA = "0x18048E020")]
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

	// Token: 0x0600157F RID: 5503 RVA: 0x000771CC File Offset: 0x000753CC
	[Token(Token = "0x600157F")]
	[Address(RVA = "0x48EDA0", Offset = "0x48D3A0", VA = "0x18048EDA0")]
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

	// Token: 0x06001580 RID: 5504 RVA: 0x00077274 File Offset: 0x00075474
	[Token(Token = "0x6001580")]
	[Address(RVA = "0x48E110", Offset = "0x48C710", VA = "0x18048E110", Slot = "73")]
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

	// Token: 0x06001581 RID: 5505 RVA: 0x00077340 File Offset: 0x00075540
	[Token(Token = "0x6001581")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "40")]
	protected override void AttributeEvent()
	{
	}

	// Token: 0x06001582 RID: 5506 RVA: 0x00077350 File Offset: 0x00075550
	[Token(Token = "0x6001582")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
	}

	// Token: 0x06001583 RID: 5507 RVA: 0x00077360 File Offset: 0x00075560
	[Token(Token = "0x6001583")]
	[Address(RVA = "0x48F140", Offset = "0x48D740", VA = "0x18048F140", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		this.BucketsUpdate();
		List<UltimateMagnet.AttrackedBucket> list = this.buckets;
		bool flag;
		this.anim.SetBool("attracking", flag);
	}

	// Token: 0x06001584 RID: 5508 RVA: 0x0007739C File Offset: 0x0007559C
	[Token(Token = "0x6001584")]
	[Address(RVA = "0x48F200", Offset = "0x48D800", VA = "0x18048F200")]
	public UltimateMagnet()
	{
		List<UltimateMagnet.AttrackedBucket> list = new List();
		this.buckets = list;
		List<UltimateMagnet.AttrackedBucket> list2 = new List();
		this.bullets = list2;
		base..ctor();
	}

	// Token: 0x04000D1D RID: 3357
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000D1D")]
	private readonly float period = 3f;

	// Token: 0x04000D1E RID: 3358
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000D1E")]
	private readonly List<UltimateMagnet.AttrackedBucket> buckets;

	// Token: 0x04000D1F RID: 3359
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x4000D1F")]
	private readonly List<UltimateMagnet.AttrackedBucket> bullets;

	// Token: 0x02000482 RID: 1154
	[Token(Token = "0x2000482")]
	private class AttrackedBucket
	{
		// Token: 0x06001585 RID: 5509 RVA: 0x000773D4 File Offset: 0x000755D4
		[Token(Token = "0x6001585")]
		[Address(RVA = "0x482FB0", Offset = "0x4815B0", VA = "0x180482FB0")]
		public AttrackedBucket(Transform centerPoint, float radius, Bucket bucket, float angularSpeed)
		{
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x00077400 File Offset: 0x00075600
		[Token(Token = "0x6001586")]
		[Address(RVA = "0x482DD0", Offset = "0x4813D0", VA = "0x180482DD0")]
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

		// Token: 0x06001587 RID: 5511 RVA: 0x000774B4 File Offset: 0x000756B4
		[Token(Token = "0x6001587")]
		[Address(RVA = "0x482A50", Offset = "0x481050", VA = "0x180482A50")]
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

		// Token: 0x04000D20 RID: 3360
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000D20")]
		public Bucket bucket = bucket;

		// Token: 0x04000D21 RID: 3361
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000D21")]
		public Vector2 targetPosition;

		// Token: 0x04000D22 RID: 3362
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000D22")]
		public bool die;

		// Token: 0x04000D23 RID: 3363
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000D23")]
		public int damage;

		// Token: 0x04000D24 RID: 3364
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000D24")]
		public int count;

		// Token: 0x04000D25 RID: 3365
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000D25")]
		public float angle;

		// Token: 0x04000D26 RID: 3366
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000D26")]
		public float existTimer;

		// Token: 0x04000D27 RID: 3367
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000D27")]
		private readonly Transform centerPoint = centerPoint;

		// Token: 0x04000D28 RID: 3368
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000D28")]
		private readonly float radius = radius;

		// Token: 0x04000D29 RID: 3369
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4000D29")]
		private readonly float angularSpeed = (float)0;
	}
}
