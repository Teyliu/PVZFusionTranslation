using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200021F RID: 543
[Token(Token = "0x200021F")]
public class Bucket : MonoBehaviour, IClickable
{
	// Token: 0x06000950 RID: 2384 RVA: 0x00032E90 File Offset: 0x00031090
	[Token(Token = "0x6000950")]
	[Address(RVA = "0x871C10", Offset = "0x870210", VA = "0x180871C10")]
	private bool AutoStorage(PlantType plantType)
	{
		int num = 0;
		Board instance = Board.Instance;
		Plant plant = Enumerable.FirstOrDefault<Plant>(Lawnf.GetPlants((PlantType)((uint)5002), instance, num != 0));
		int num2 = 0;
		if (plant != num2)
		{
			ParticleManager instance2 = ParticleManager.Instance;
			Transform transform = base.transform;
			int num3 = 0;
			int num4 = 0;
			ulong num5;
			Particle particle = instance2.SetParticle(ParticleType.RandomCloud, num3, 11, num5 != 0UL, (float)num4);
			global::UnityEngine.Object.Destroy(base.gameObject);
			return true;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000951 RID: 2385 RVA: 0x00032F04 File Offset: 0x00031104
	[Token(Token = "0x6000951")]
	[Address(RVA = "0x8727D0", Offset = "0x870DD0", VA = "0x1808727D0", Slot = "6")]
	protected virtual void Start()
	{
		int num;
		do
		{
			num = 0;
			bool flag;
			if (flag)
			{
				Dictionary<BucketType, PlantType> toPlant = Bucket.ToPlant;
				BucketType bucketType = this.theBucketType;
				if (toPlant.TryGetValue(bucketType, num) && this.AutoStorage((PlantType)num))
				{
					return;
				}
			}
			Transform transform = base.transform;
			Vector3 vector;
			float z = vector.z;
			float num2 = global::UnityEngine.Random.Range(-1.5f, 1.5f);
			this.velocity = num2;
			float num3 = this.verticalSpeed;
			this.velocity.y = num3;
			Mouse instance = Mouse.Instance;
			this.m = instance;
			Board instance2 = Board.Instance;
			int num4 = Board.Instance.theTotalNumOfCoin;
			if (num4 > 1000)
			{
				ulong num5;
				num5 += num5;
				long num6 = (long)(num5 * (ulong)((uint)1000));
				num4 = (int)((long)num4 + num6);
			}
			if (base.TryGetComponent<SpriteRenderer>(num))
			{
			}
			if (base.transform.childCount == 0)
			{
				break;
			}
			if (base.transform.GetEnumerator() != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				bool flag2;
				while (!flag2)
				{
				}
			}
			int num7;
			if (num7 != 0)
			{
			}
		}
		while (num != 0);
		Vector3 vector2;
		float z2 = vector2.z;
		float boardMinX = Board.Instance.boardMinX;
		float boardMinY = Board.Instance.boardMinY;
		Board instance3 = Board.Instance;
		Transform transform2;
		transform2.position = num;
	}

	// Token: 0x06000952 RID: 2386 RVA: 0x00033060 File Offset: 0x00031260
	[Token(Token = "0x6000952")]
	[Address(RVA = "0x872740", Offset = "0x870D40", VA = "0x180872740")]
	public void PutDown()
	{
		base.GetComponent<Collider2D>().enabled = true;
		Transform transform = base.transform;
	}

	// Token: 0x06000953 RID: 2387 RVA: 0x0003308C File Offset: 0x0003128C
	[Token(Token = "0x6000953")]
	[Address(RVA = "0x872D80", Offset = "0x871380", VA = "0x180872D80", Slot = "7")]
	protected virtual void Update()
	{
		this.PositionUpdate();
		if (this.disappear)
		{
			Board instance = Board.Instance;
			float deltaTime = Time.deltaTime;
			this.existTime = deltaTime;
			if (deltaTime > 4f && !this.isFlash)
			{
				this.isFlash = true;
				Bucket.<Flash>d__17 <Flash>d__;
				<Flash>d__.System.IDisposable.Dispose();
				<Flash>d__.<>1__state = (int)((ulong)0L);
				<Flash>d__.<>4__this = this;
				Coroutine coroutine = base.StartCoroutine(<Flash>d__);
			}
			if (this.existTime > 8f)
			{
				GameObject theItemOnMouse = this.m.theItemOnMouse;
				GameObject gameObject = base.gameObject;
				if (theItemOnMouse != gameObject)
				{
					this.Die();
				}
			}
		}
	}

	// Token: 0x06000954 RID: 2388 RVA: 0x00033134 File Offset: 0x00031334
	[Token(Token = "0x6000954")]
	[Address(RVA = "0x871E30", Offset = "0x870430", VA = "0x180871E30")]
	private void Die()
	{
		ulong num5;
		do
		{
			int num = 0;
			List<Plant> list = new List();
			List<Plant> list2 = new List();
			List<Plant> plantArray = Board.Instance.boardEntity.plantArray;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				bool flag2 = num != num2;
				while (!flag2)
				{
				}
				if (flag2)
				{
				}
				while (!flag2)
				{
				}
			}
			ulong num3;
			if (num3 != (ulong)0L)
			{
				goto IL_0081;
			}
			bool flag3;
			if (flag3)
			{
			}
			ulong num4;
			if (num4 != (ulong)0L)
			{
				goto IL_0087;
			}
			bool flag4;
			if (flag4)
			{
			}
		}
		while (num5 != (ulong)0L);
		GameObject gameObject;
		global::UnityEngine.Object.Destroy(gameObject);
		return;
		IL_0081:
		throw new NullReferenceException();
		IL_0087:
		throw new NullReferenceException();
	}

	// Token: 0x06000955 RID: 2389 RVA: 0x000331D0 File Offset: 0x000313D0
	[Token(Token = "0x6000955")]
	[Address(RVA = "0x872320", Offset = "0x870920", VA = "0x180872320")]
	private IEnumerator Flash()
	{
		Bucket.<Flash>d__17 <Flash>d__;
		<Flash>d__.System.IDisposable.Dispose();
		<Flash>d__.<>1__state = (int)((ulong)0L);
		<Flash>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000956 RID: 2390 RVA: 0x000331F4 File Offset: 0x000313F4
	[Token(Token = "0x6000956")]
	[Address(RVA = "0x8724D0", Offset = "0x870AD0", VA = "0x1808724D0")]
	protected void PositionUpdate()
	{
		if (!this.isLand)
		{
			float y = this.velocity.y;
			float deltaTime = Time.deltaTime;
			this.velocity.y = y;
			Transform transform = base.transform;
			float deltaTime2 = Time.deltaTime;
			Transform transform2 = base.transform;
			Vector3 vector;
			if (this.startPosition.y <= vector.y)
			{
				Transform transform3 = base.transform;
				Vector3 vector2;
				if (Board.Instance.boardMinY <= vector2.y)
				{
					return;
				}
			}
			this.isLand = true;
			Transform transform4 = base.transform;
			Vector3 vector3;
			float boardMinY;
			if (Board.Instance.boardMinY > vector3.y)
			{
				Transform transform5 = base.transform;
				Transform transform6 = base.transform;
				boardMinY = Board.Instance.boardMinY;
			}
			Transform transform7 = base.transform;
			this.startPosition = boardMinY;
			this.startPosition.y = boardMinY;
		}
	}

	// Token: 0x06000957 RID: 2391 RVA: 0x000332DC File Offset: 0x000314DC
	[Token(Token = "0x6000957")]
	[Address(RVA = "0x8723B0", Offset = "0x8709B0", VA = "0x1808723B0", Slot = "8")]
	public virtual void Pick()
	{
		Mouse mouse = this.m;
		this.isLand = true;
		GameObject gameObject = base.gameObject;
		mouse.theItemOnMouse = gameObject;
		this.m.thePlantOnGlove = (ulong)0L;
		this.m.thePlantTypeOnMouse = (PlantType)((ulong)4294967295L);
		Collider2D component = base.GetComponent<Collider2D>();
		int num = 0;
		component.enabled = num != 0;
		GameObject gameObject2 = base.gameObject;
		bool flag;
		if (flag)
		{
		}
	}

	// Token: 0x06000958 RID: 2392 RVA: 0x00033350 File Offset: 0x00031550
	[Token(Token = "0x6000958")]
	[Address(RVA = "0x872F00", Offset = "0x871500", VA = "0x180872F00", Slot = "9")]
	public virtual void Use()
	{
		ulong num;
		do
		{
			Mouse mouse = this.m;
			int theMouseRow = mouse.theMouseRow;
			List<Plant> list = Lawnf.Get1x1Plants(mouse.theMouseColumn, theMouseRow);
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
		Collider2D collider2D;
		collider2D.enabled = true;
	}

	// Token: 0x06000959 RID: 2393 RVA: 0x000333A0 File Offset: 0x000315A0
	[Token(Token = "0x6000959")]
	[Address(RVA = "0x872390", Offset = "0x870990", VA = "0x180872390", Slot = "5")]
	public bool OnClick(Mouse mouse)
	{
		this.Pick();
		return true;
	}

	// Token: 0x17000071 RID: 113
	// (get) Token: 0x0600095A RID: 2394 RVA: 0x000333B4 File Offset: 0x000315B4
	[Token(Token = "0x17000071")]
	public int Priority
	{
		[Token(Token = "0x600095A")]
		[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "4")]
		get
		{
			return 4;
		}
	}

	// Token: 0x0600095B RID: 2395 RVA: 0x000333C4 File Offset: 0x000315C4
	[Token(Token = "0x600095B")]
	[Address(RVA = "0x873840", Offset = "0x871E40", VA = "0x180873840")]
	public Bucket()
	{
	}

	// Token: 0x0600095C RID: 2396 RVA: 0x000333F4 File Offset: 0x000315F4
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x600095C")]
	[Address(RVA = "0x873080", Offset = "0x871680", VA = "0x180873080")]
	static Bucket()
	{
		Dictionary<ValueTuple<PlantType, BucketType>, PlantType> dictionary = new Dictionary();
		Bucket.Recipes = dictionary;
	}

	// Token: 0x040004C4 RID: 1220
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004C4")]
	public bool isLand;

	// Token: 0x040004C5 RID: 1221
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x40004C5")]
	public bool disappear = true;

	// Token: 0x040004C6 RID: 1222
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40004C6")]
	public BucketType theBucketType;

	// Token: 0x040004C7 RID: 1223
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004C7")]
	protected Mouse m;

	// Token: 0x040004C8 RID: 1224
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004C8")]
	public float existTime;

	// Token: 0x040004C9 RID: 1225
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40004C9")]
	protected float gravity = 9.8f;

	// Token: 0x040004CA RID: 1226
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40004CA")]
	private Vector2 velocity;

	// Token: 0x040004CB RID: 1227
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40004CB")]
	public Vector2 startPosition;

	// Token: 0x040004CC RID: 1228
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40004CC")]
	private bool isFlash;

	// Token: 0x040004CD RID: 1229
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40004CD")]
	private readonly float verticalSpeed = 4f;

	// Token: 0x040004CE RID: 1230
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40004CE")]
	public Magnetshroom magnetShroom;

	// Token: 0x040004CF RID: 1231
	[Token(Token = "0x40004CF")]
	public static readonly Dictionary<BucketType, PlantType> ToPlant = new Dictionary();

	// Token: 0x040004D0 RID: 1232
	[Token(Token = "0x40004D0")]
	public static readonly Dictionary<ValueTuple<PlantType, BucketType>, PlantType> Recipes;
}
