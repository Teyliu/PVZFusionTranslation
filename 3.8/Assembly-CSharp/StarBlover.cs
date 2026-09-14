using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000431 RID: 1073
[Token(Token = "0x2000431")]
public class StarBlover : Blover
{
	// Token: 0x060013CC RID: 5068 RVA: 0x0006F1F8 File Offset: 0x0006D3F8
	[Token(Token = "0x60013CC")]
	[Address(RVA = "0x46E3A0", Offset = "0x46C9A0", VA = "0x18046E3A0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		if (AdvantureConfig.data.GetResult((AdvantureLevel)((uint)41), (MissionResult)((uint)1)))
		{
			this.theStatus = (PlantStatus)((ulong)25L);
		}
	}

	// Token: 0x060013CD RID: 5069 RVA: 0x0006F230 File Offset: 0x0006D430
	[Token(Token = "0x60013CD")]
	[Address(RVA = "0x46E250", Offset = "0x46C850", VA = "0x18046E250", Slot = "69")]
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

	// Token: 0x060013CE RID: 5070 RVA: 0x0006F2A0 File Offset: 0x0006D4A0
	[Token(Token = "0x60013CE")]
	[Address(RVA = "0x46E5A0", Offset = "0x46CBA0", VA = "0x18046E5A0", Slot = "17")]
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
					}
				}
				num++;
			}
		}
		this.SetAccelerateTime();
	}

	// Token: 0x060013CF RID: 5071 RVA: 0x0006F314 File Offset: 0x0006D514
	[Token(Token = "0x60013CF")]
	[Address(RVA = "0x46EDF0", Offset = "0x46D3F0", VA = "0x18046EDF0", Slot = "71")]
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

	// Token: 0x060013D0 RID: 5072 RVA: 0x0006F384 File Offset: 0x0006D584
	[Token(Token = "0x60013D0")]
	[Address(RVA = "0x46E070", Offset = "0x46C670", VA = "0x18046E070")]
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

	// Token: 0x060013D1 RID: 5073 RVA: 0x0006F3DC File Offset: 0x0006D5DC
	[Token(Token = "0x60013D1")]
	[Address(RVA = "0x46EC40", Offset = "0x46D240", VA = "0x18046EC40")]
	protected void RemoveNode(Bullet_star starBullet)
	{
		bool flag = this.starBullets.Remove(starBullet);
	}

	// Token: 0x060013D2 RID: 5074 RVA: 0x0006F3FC File Offset: 0x0006D5FC
	[Token(Token = "0x60013D2")]
	[Address(RVA = "0x46F270", Offset = "0x46D870", VA = "0x18046F270", Slot = "16")]
	protected override void Update()
	{
		base.Update();
	}

	// Token: 0x060013D3 RID: 5075 RVA: 0x0006F410 File Offset: 0x0006D610
	[Token(Token = "0x60013D3")]
	[Address(RVA = "0x46EFB0", Offset = "0x46D5B0", VA = "0x18046EFB0", Slot = "72")]
	protected virtual void StarsUpdate()
	{
		ulong num3;
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
				AdvantureMission.TryAddCount((AdvantureLevel)((uint)41));
				this.RemoveNode(num);
				float deltaTime = Time.deltaTime;
				this.RotateOnCircle(num);
				this.MoveToCircle(num);
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x060013D4 RID: 5076 RVA: 0x0006F488 File Offset: 0x0006D688
	[Token(Token = "0x60013D4")]
	[Address(RVA = "0x46E7B0", Offset = "0x46CDB0", VA = "0x18046E7B0")]
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

	// Token: 0x060013D5 RID: 5077 RVA: 0x0006F52C File Offset: 0x0006D72C
	[Token(Token = "0x60013D5")]
	[Address(RVA = "0x46ECA0", Offset = "0x46D2A0", VA = "0x18046ECA0")]
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

	// Token: 0x060013D6 RID: 5078 RVA: 0x0006F5A4 File Offset: 0x0006D7A4
	[Token(Token = "0x60013D6")]
	[Address(RVA = "0x46E430", Offset = "0x46CA30", VA = "0x18046E430", Slot = "53")]
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

	// Token: 0x060013D7 RID: 5079 RVA: 0x0006F5E4 File Offset: 0x0006D7E4
	[Token(Token = "0x60013D7")]
	[Address(RVA = "0x46F2A0", Offset = "0x46D8A0", VA = "0x18046F2A0")]
	public StarBlover()
	{
		List<Bullet_star> list = new List();
		this.starBullets = list;
		this.radius = 0.8f;
		this.transitionSpeed = 6f;
		this.maxBullets = (int)((ulong)20L);
		base..ctor();
	}

	// Token: 0x04000C94 RID: 3220
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C94")]
	private bool attracting;

	// Token: 0x04000C95 RID: 3221
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000C95")]
	protected List<Bullet_star> starBullets;

	// Token: 0x04000C96 RID: 3222
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000C96")]
	[SerializeField]
	private Vector2 center;

	// Token: 0x04000C97 RID: 3223
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000C97")]
	private readonly float radius;

	// Token: 0x04000C98 RID: 3224
	[FieldOffset(Offset = "0x234")]
	[Token(Token = "0x4000C98")]
	private readonly float transitionSpeed;

	// Token: 0x04000C99 RID: 3225
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000C99")]
	private GameObject head;

	// Token: 0x04000C9A RID: 3226
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000C9A")]
	protected int maxBullets;
}
