using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000224 RID: 548
[Token(Token = "0x2000224")]
public class Bucket : MonoBehaviour, IClickable
{
	// Token: 0x06000966 RID: 2406 RVA: 0x00032CC0 File Offset: 0x00030EC0
	[Token(Token = "0x6000966")]
	[Address(RVA = "0x9018F0", Offset = "0x8FFEF0", VA = "0x1809018F0")]
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

	// Token: 0x06000967 RID: 2407 RVA: 0x00032D34 File Offset: 0x00030F34
	[Token(Token = "0x6000967")]
	[Address(RVA = "0x9024B0", Offset = "0x900AB0", VA = "0x1809024B0", Slot = "6")]
	protected virtual void Start()
	{
		int num;
		do
		{
			num = 0;
			bool flag;
			if (flag && (this.ultimag ? 1 : 0) == num)
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

	// Token: 0x06000968 RID: 2408 RVA: 0x00032E9C File Offset: 0x0003109C
	[Token(Token = "0x6000968")]
	[Address(RVA = "0x902420", Offset = "0x900A20", VA = "0x180902420")]
	public void PutDown()
	{
		base.GetComponent<Collider2D>().enabled = true;
		Transform transform = base.transform;
	}

	// Token: 0x06000969 RID: 2409 RVA: 0x00032EC8 File Offset: 0x000310C8
	[Token(Token = "0x6000969")]
	[Address(RVA = "0x902AA0", Offset = "0x9010A0", VA = "0x180902AA0", Slot = "7")]
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
				Bucket.<Flash>d__18 <Flash>d__;
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

	// Token: 0x0600096A RID: 2410 RVA: 0x00032F70 File Offset: 0x00031170
	[Token(Token = "0x600096A")]
	[Address(RVA = "0x901B10", Offset = "0x900110", VA = "0x180901B10")]
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

	// Token: 0x0600096B RID: 2411 RVA: 0x0003300C File Offset: 0x0003120C
	[Token(Token = "0x600096B")]
	[Address(RVA = "0x902000", Offset = "0x900600", VA = "0x180902000")]
	private IEnumerator Flash()
	{
		Bucket.<Flash>d__18 <Flash>d__;
		<Flash>d__.System.IDisposable.Dispose();
		<Flash>d__.<>1__state = (int)((ulong)0L);
		<Flash>d__.<>4__this = this;
		return null;
	}

	// Token: 0x0600096C RID: 2412 RVA: 0x00033030 File Offset: 0x00031230
	[Token(Token = "0x600096C")]
	[Address(RVA = "0x9021B0", Offset = "0x9007B0", VA = "0x1809021B0")]
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

	// Token: 0x0600096D RID: 2413 RVA: 0x00033118 File Offset: 0x00031318
	[Token(Token = "0x600096D")]
	[Address(RVA = "0x902090", Offset = "0x900690", VA = "0x180902090", Slot = "8")]
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

	// Token: 0x0600096E RID: 2414 RVA: 0x0003318C File Offset: 0x0003138C
	[Token(Token = "0x600096E")]
	[Address(RVA = "0x902C20", Offset = "0x901220", VA = "0x180902C20", Slot = "9")]
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

	// Token: 0x0600096F RID: 2415 RVA: 0x000331DC File Offset: 0x000313DC
	[Token(Token = "0x600096F")]
	[Address(RVA = "0x902070", Offset = "0x900670", VA = "0x180902070", Slot = "5")]
	public bool OnClick(Mouse mouse)
	{
		this.Pick();
		return true;
	}

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x06000970 RID: 2416 RVA: 0x000331F0 File Offset: 0x000313F0
	[Token(Token = "0x170000AE")]
	public int Priority
	{
		[Token(Token = "0x6000970")]
		[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "4")]
		get
		{
			return 4;
		}
	}

	// Token: 0x06000971 RID: 2417 RVA: 0x00033200 File Offset: 0x00031400
	[Token(Token = "0x6000971")]
	[Address(RVA = "0x903560", Offset = "0x901B60", VA = "0x180903560")]
	public Bucket()
	{
	}

	// Token: 0x06000972 RID: 2418 RVA: 0x00033230 File Offset: 0x00031430
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x6000972")]
	[Address(RVA = "0x902DA0", Offset = "0x9013A0", VA = "0x180902DA0")]
	static Bucket()
	{
		Dictionary<ValueTuple<PlantType, BucketType>, PlantType> dictionary = new Dictionary();
		Bucket.Recipes = dictionary;
	}

	// Token: 0x040004C9 RID: 1225
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004C9")]
	public bool ultimag;

	// Token: 0x040004CA RID: 1226
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x40004CA")]
	public bool isLand;

	// Token: 0x040004CB RID: 1227
	[FieldOffset(Offset = "0x22")]
	[Token(Token = "0x40004CB")]
	public bool disappear = true;

	// Token: 0x040004CC RID: 1228
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40004CC")]
	public BucketType theBucketType;

	// Token: 0x040004CD RID: 1229
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004CD")]
	protected Mouse m;

	// Token: 0x040004CE RID: 1230
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004CE")]
	public float existTime;

	// Token: 0x040004CF RID: 1231
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40004CF")]
	protected float gravity = 9.8f;

	// Token: 0x040004D0 RID: 1232
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40004D0")]
	private Vector2 velocity;

	// Token: 0x040004D1 RID: 1233
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40004D1")]
	public Vector2 startPosition;

	// Token: 0x040004D2 RID: 1234
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40004D2")]
	private bool isFlash;

	// Token: 0x040004D3 RID: 1235
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40004D3")]
	private readonly float verticalSpeed = 4f;

	// Token: 0x040004D4 RID: 1236
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40004D4")]
	public Magnetshroom magnetShroom;

	// Token: 0x040004D5 RID: 1237
	[Token(Token = "0x40004D5")]
	public static readonly Dictionary<BucketType, PlantType> ToPlant = new Dictionary();

	// Token: 0x040004D6 RID: 1238
	[Token(Token = "0x40004D6")]
	public static readonly Dictionary<ValueTuple<PlantType, BucketType>, PlantType> Recipes;
}
