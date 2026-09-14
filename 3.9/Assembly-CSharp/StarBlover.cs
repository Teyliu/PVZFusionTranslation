using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000450 RID: 1104
[Token(Token = "0x2000450")]
public class StarBlover : Blover
{
	// Token: 0x06001456 RID: 5206 RVA: 0x00071488 File Offset: 0x0006F688
	[Token(Token = "0x6001456")]
	[Address(RVA = "0x4C5AE0", Offset = "0x4C40E0", VA = "0x1804C5AE0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		if (AdvantureConfig.data.GetResult((AdvantureLevel)((uint)41), (MissionResult)((uint)1)))
		{
			this.theStatus = (PlantStatus)((ulong)25L);
		}
	}

	// Token: 0x06001457 RID: 5207 RVA: 0x000714C0 File Offset: 0x0006F6C0
	[Token(Token = "0x6001457")]
	[Address(RVA = "0x4C5990", Offset = "0x4C3F90", VA = "0x1804C5990", Slot = "68")]
	protected override void AnimBlow()
	{
		GameAPP.PlaySound(87, 0.5f, 1f);
		base.BlowZombie();
		GameObject fog = this.board.fog;
		int num = 0;
		if (fog != num)
		{
			FogMgr.Instance.Blown();
		}
		this.attracting = true;
		GameObject gameObject = base.transform.Find("Blover_head").gameObject;
		this.head = gameObject;
		throw new NullReferenceException();
	}

	// Token: 0x06001458 RID: 5208 RVA: 0x00071530 File Offset: 0x0006F730
	[Token(Token = "0x6001458")]
	[Address(RVA = "0x4C5CE0", Offset = "0x4C42E0", VA = "0x1804C5CE0", Slot = "17")]
	protected override void FixedUpdate()
	{
		int num = 0;
		if ((this.attracting ? 1 : 0) != num)
		{
			Transform transform = this.head.transform;
			LayerMask bulletLayer = this.bulletLayer;
			this.center.y = (float)0;
			int num2 = bulletLayer;
			Collider2D[] array;
			if (num < array.Length)
			{
				bool flag;
				if (flag)
				{
					Team <Team>k__BackingField = this.<Team>k__BackingField;
					if (this.AddNode(num))
					{
						List<BulletHitFilter> list = new List(num);
						num += 208;
					}
				}
				num++;
			}
		}
		this.SetAccelerateTime();
	}

	// Token: 0x06001459 RID: 5209 RVA: 0x000715B4 File Offset: 0x0006F7B4
	[Token(Token = "0x6001459")]
	[Address(RVA = "0x4C65D0", Offset = "0x4C4BD0", VA = "0x1804C65D0", Slot = "70")]
	protected virtual void SetAccelerateTime()
	{
		ulong num3;
		do
		{
			int num = 0;
			GridSystem gridSystem = this.board.gridSystem;
			int thePlantRow = this.thePlantRow;
			int thePlantColumn = this.thePlantColumn;
			List<Plant> plants = gridSystem.GetGrid(thePlantColumn, thePlantRow).plants;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				this.maxBullets = (int)((ulong)80L);
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x0600145A RID: 5210 RVA: 0x00071624 File Offset: 0x0006F824
	[Token(Token = "0x600145A")]
	[Address(RVA = "0x4C57B0", Offset = "0x4C3DB0", VA = "0x1804C57B0")]
	private bool AddNode(Bullet_star starBullet)
	{
		List<Bullet_star> list = this.starBullets;
		Predicate<Bullet_star> <>9__11_ = StarBlover.<>c.<>9__11_0;
		if (<>9__11_ == 0)
		{
			Predicate<Bullet_star> predicate;
			StarBlover.<>c.<>9__11_0 = predicate;
		}
		int num = list.RemoveAll(<>9__11_);
		List<Bullet_star> list2 = this.starBullets;
		int num2 = this.maxBullets;
		int size = list2._size;
		ulong num3;
		list2._size = (int)num3;
		throw new NullReferenceException();
	}

	// Token: 0x0600145B RID: 5211 RVA: 0x0007167C File Offset: 0x0006F87C
	[Token(Token = "0x600145B")]
	[Address(RVA = "0x4C6420", Offset = "0x4C4A20", VA = "0x1804C6420")]
	protected void RemoveNode(Bullet_star starBullet)
	{
		bool flag = this.starBullets.Remove(starBullet);
	}

	// Token: 0x0600145C RID: 5212 RVA: 0x0007169C File Offset: 0x0006F89C
	[Token(Token = "0x600145C")]
	[Address(RVA = "0x4C6AC0", Offset = "0x4C50C0", VA = "0x1804C6AC0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
	}

	// Token: 0x0600145D RID: 5213 RVA: 0x000716B0 File Offset: 0x0006F8B0
	[Token(Token = "0x600145D")]
	[Address(RVA = "0x4C6790", Offset = "0x4C4D90", VA = "0x1804C6790", Slot = "71")]
	protected virtual void StarsUpdate()
	{
		ulong num4;
		do
		{
			int num = 0;
			List<Bullet_star> list = Enumerable.ToList<Bullet_star>(this.starBullets);
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				int num3 = 0;
				AdvantureMission.TryAddCount((AdvantureLevel)((uint)41));
				List<BulletHitFilter> list2 = new List(num3);
				this.RemoveNode(num);
				float deltaTime = Time.deltaTime;
				this.RotateOnCircle(num);
				this.MoveToCircle(num);
			}
		}
		while (num4 != (ulong)0L);
	}

	// Token: 0x0600145E RID: 5214 RVA: 0x00071734 File Offset: 0x0006F934
	[Token(Token = "0x600145E")]
	[Address(RVA = "0x4C5F90", Offset = "0x4C4590", VA = "0x1804C5F90")]
	protected void MoveToCircle(Bullet_star star)
	{
		Transform transform = star.transform;
		Vector3 vector;
		float z = vector.z;
		float num = Vector2.zeroVector * this.radius;
		float num2;
		star.targetPosition.y = num2;
		star.targetPosition = num;
		Transform transform2 = star.transform;
		Transform transform3 = star.transform;
		float num3 = this.transitionSpeed;
		num = Time.deltaTime;
		if (0 == 0)
		{
		}
		Transform transform4 = star.transform;
		Transform transform5 = star.transform;
		Vector3 vector2;
		float y = vector2.y;
		Transform transform6 = star.transform;
		star.angle = y;
		star.movingToCircle = false;
	}

	// Token: 0x0600145F RID: 5215 RVA: 0x000717D8 File Offset: 0x0006F9D8
	[Token(Token = "0x600145F")]
	[Address(RVA = "0x4C6480", Offset = "0x4C4A80", VA = "0x1804C6480")]
	protected void RotateOnCircle(Bullet_star star)
	{
		float angularSpeed = star.angularSpeed;
		float deltaTime = Time.deltaTime;
		star.angle = angularSpeed;
		float angularSpeed2 = star.angularSpeed;
		float deltaTime2 = Time.deltaTime;
		star.angularSpeed = angularSpeed2;
		star.angularSpeed = -6f;
		float angle = star.angle;
		star.angle = angle;
		Transform transform = star.transform;
		Transform transform2 = star.transform;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06001460 RID: 5216 RVA: 0x00071850 File Offset: 0x0006FA50
	[Token(Token = "0x6001460")]
	[Address(RVA = "0x4C5B70", Offset = "0x4C4170", VA = "0x1804C5B70", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		ulong num3;
		do
		{
			int num = 0;
			List<Bullet_star> list = this.starBullets;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06001461 RID: 5217 RVA: 0x00071890 File Offset: 0x0006FA90
	[Token(Token = "0x6001461")]
	[Address(RVA = "0x4C6AF0", Offset = "0x4C50F0", VA = "0x1804C6AF0")]
	public StarBlover()
	{
		List<Bullet_star> list = new List();
		this.starBullets = list;
		this.radius = 0.8f;
		this.transitionSpeed = 6f;
		this.maxBullets = (int)((ulong)20L);
		base..ctor();
	}

	// Token: 0x04000D1E RID: 3358
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000D1E")]
	private bool attracting;

	// Token: 0x04000D1F RID: 3359
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000D1F")]
	protected List<Bullet_star> starBullets;

	// Token: 0x04000D20 RID: 3360
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000D20")]
	[SerializeField]
	private Vector2 center;

	// Token: 0x04000D21 RID: 3361
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000D21")]
	private readonly float radius;

	// Token: 0x04000D22 RID: 3362
	[FieldOffset(Offset = "0x234")]
	[Token(Token = "0x4000D22")]
	private readonly float transitionSpeed;

	// Token: 0x04000D23 RID: 3363
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000D23")]
	private GameObject head;

	// Token: 0x04000D24 RID: 3364
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000D24")]
	protected int maxBullets;
}
