using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020002C6 RID: 710
[Token(Token = "0x20002C6")]
public class LittleSquash : MonoBehaviour
{
	// Token: 0x06000CA6 RID: 3238 RVA: 0x00048C58 File Offset: 0x00046E58
	[Token(Token = "0x6000CA6")]
	[Address(RVA = "0x3E6790", Offset = "0x3E4D90", VA = "0x1803E6790")]
	private void Awake()
	{
		Transform transform = base.transform.Find("axis");
		this.axis = transform;
		Transform transform2 = base.transform.Find("Shadow");
		this.shadow = transform2;
		this.status = (LittleSquash.Status)((ulong)0L);
		LayerMask layerMask = LayerMask.GetMask(new string[] { "Zombie" });
		this.zombieLayer = layerMask;
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
		SortingGroup component2 = base.GetComponent<SortingGroup>();
		this.sortingGroup = component2;
		this.maxCrashCount = (int)((ulong)6L);
	}

	// Token: 0x06000CA7 RID: 3239 RVA: 0x00048CF4 File Offset: 0x00046EF4
	[Token(Token = "0x6000CA7")]
	[Address(RVA = "0x3E74A0", Offset = "0x3E5AA0", VA = "0x1803E74A0")]
	private void Start()
	{
		Transform transform = this.axis;
		Transform transform2 = this.axis;
		Mouse instance = Mouse.Instance;
		int num = this.theRow;
		SortingGroup sortingGroup = this.sortingGroup;
		string text = string.Format("bullet{0}", num);
		sortingGroup.sortingLayerName = text;
		Board instance2 = Board.Instance;
		SortingGroup sortingGroup2 = this.sortingGroup;
		int currentBulletNum = instance2.currentBulletNum;
		sortingGroup2.sortingOrder = currentBulletNum;
		Board board = this.board;
		int num2 = 0;
		if (board == num2)
		{
			Board instance3 = Board.Instance;
			this.board = instance3;
		}
	}

	// Token: 0x06000CA8 RID: 3240 RVA: 0x00048D90 File Offset: 0x00046F90
	[Token(Token = "0x6000CA8")]
	[Address(RVA = "0x3E7660", Offset = "0x3E5C60", VA = "0x1803E7660")]
	private void Update()
	{
		float num = this.timer;
		int num2 = 0;
		if (num > (float)num2)
		{
			float deltaTime = Time.deltaTime;
			this.timer = num;
			this.NextStatus();
		}
		this.PositionUpdate();
	}

	// Token: 0x06000CA9 RID: 3241 RVA: 0x00048DC8 File Offset: 0x00046FC8
	[Token(Token = "0x6000CA9")]
	[Address(RVA = "0x3E6E00", Offset = "0x3E5400", VA = "0x1803E6E00")]
	private void PositionUpdate()
	{
		LittleSquash.Status status = this.status;
		if (status == LittleSquash.Status.Moving)
		{
			Transform transform = this.axis;
			Transform transform2 = this.axis;
			float deltaTime = Time.deltaTime;
			Transform transform3 = this.axis;
			float deltaTime2 = Time.deltaTime;
			this.timer = 0.2f;
			this.status = (LittleSquash.Status)((ulong)2L);
		}
		if (status == LittleSquash.Status.Crashing)
		{
			Transform transform4 = this.axis;
			Mouse instance = Mouse.Instance;
			Transform transform5 = this.axis;
			Vector3 vector;
			float num = vector.y;
			float num2;
			if (num > num2)
			{
				Transform transform6 = base.transform;
				num = Time.deltaTime;
			}
			Transform transform7 = this.axis;
			Transform transform8 = this.axis;
		}
		Transform transform9 = this.shadow;
		Transform transform10 = this.shadow;
		Mouse instance2 = Mouse.Instance;
	}

	// Token: 0x06000CAA RID: 3242 RVA: 0x00048E88 File Offset: 0x00047088
	[Token(Token = "0x6000CAA")]
	[Address(RVA = "0x3E6C30", Offset = "0x3E5230", VA = "0x1803E6C30")]
	private void NextStatus()
	{
		LittleSquash.Status status = this.status;
		if (status == LittleSquash.Status.Default)
		{
			Zombie zombie = this.SearchZombie();
			int num = 0;
			if (!(zombie != num))
			{
				Transform transform = this.axis;
			}
			Transform transform2 = zombie.axis;
			Vector2 velocity = zombie.Velocity;
			this.anim.SetTrigger("jump");
			return;
		}
		while (status != LittleSquash.Status.Waiting)
		{
		}
		Animator animator = this.anim;
		this.status = (LittleSquash.Status)((ulong)3L);
		animator.SetTrigger("pop");
	}

	// Token: 0x06000CAB RID: 3243 RVA: 0x00048F04 File Offset: 0x00047104
	[Token(Token = "0x6000CAB")]
	[Address(RVA = "0x3E6780", Offset = "0x3E4D80", VA = "0x1803E6780")]
	private void AnimJump()
	{
		this.status = (LittleSquash.Status)((ulong)1L);
	}

	// Token: 0x06000CAC RID: 3244 RVA: 0x00048F1C File Offset: 0x0004711C
	[Token(Token = "0x6000CAC")]
	[Address(RVA = "0x3E7260", Offset = "0x3E5860", VA = "0x1803E7260")]
	private Zombie SearchZombie()
	{
		Transform transform = this.axis;
		int num = 0;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int num3 = this.theRow;
				if (!Lawnf.InDodgeStatus((ZombieStatus)num))
				{
					Transform transform2 = this.axis;
				}
			}
			num++;
		}
		throw new IndexOutOfRangeException();
	}

	// Token: 0x06000CAD RID: 3245 RVA: 0x00048F74 File Offset: 0x00047174
	[Token(Token = "0x6000CAD")]
	[Address(RVA = "0x3E6340", Offset = "0x3E4940", VA = "0x1803E6340")]
	private void AdjustPosition(Vector3 targetPosition)
	{
		Transform transform = this.axis;
		Transform transform2 = base.transform;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06000CAE RID: 3246 RVA: 0x00048FA0 File Offset: 0x000471A0
	[Token(Token = "0x6000CAE")]
	[Address(RVA = "0x3E6440", Offset = "0x3E4A40", VA = "0x1803E6440")]
	private void AnimCrash()
	{
		Transform transform = this.axis;
		int num = 0;
		Vector3 vector;
		float z = vector.z;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int num3 = this.theRow;
				if (!Lawnf.InDodgeStatus((ZombieStatus)num))
				{
					PlantType plantType = this.thePlantType;
				}
			}
			num++;
		}
		if (this.crashAction != 0)
		{
		}
		uint num4;
		GameAPP.PlaySound((int)num4, 0.3f, 1f);
		int num5 = this.maxCrashCount;
		this.status = (LittleSquash.Status)num;
		this.timer = 0.3f;
		if (this.crashCount < num5)
		{
			if (this.thePlantType == PlantType.NuclearSquash)
			{
				Board board = this.board;
				Transform transform2 = this.axis;
				BoardAction boardAction = board.boardAction;
				PlantType plantType2 = this.thePlantType;
				int num6 = this.theDamage;
			}
			return;
		}
		global::UnityEngine.Object.Destroy(base.gameObject);
		if (this.lastAction != 0)
		{
		}
		this.LastEvent();
		throw new NullReferenceException();
	}

	// Token: 0x06000CAF RID: 3247 RVA: 0x0004908C File Offset: 0x0004728C
	[Token(Token = "0x6000CAF")]
	[Address(RVA = "0x3E6910", Offset = "0x3E4F10", VA = "0x1803E6910")]
	private void CrashEvent()
	{
		if (this.thePlantType == PlantType.NuclearSquash)
		{
			Board board = this.board;
			Transform transform = this.axis;
			BoardAction boardAction = board.boardAction;
			PlantType plantType = this.thePlantType;
			int num = this.theDamage;
		}
	}

	// Token: 0x06000CB0 RID: 3248 RVA: 0x000490D8 File Offset: 0x000472D8
	[Token(Token = "0x6000CB0")]
	[Address(RVA = "0x3E69B0", Offset = "0x3E4FB0", VA = "0x1803E69B0")]
	private void LastEvent()
	{
		if (this.thePlantType == PlantType.NuclearSquash)
		{
			Board board = this.board;
			Transform transform = this.axis;
			BoardAction boardAction = board.boardAction;
			Vector3 vector;
			float z = vector.z;
			PlantType plantType = this.thePlantType;
			int num = 0;
			int num2 = this.theDamage;
			CreateBullet instance = CreateBullet.Instance;
			Transform transform2 = base.transform;
			Transform transform3 = base.transform;
			int num3 = this.theDamage;
			Bullet bullet;
			bullet.Damage = num3;
			Transform transform4 = bullet.transform;
			num += 30;
			bullet.normalSpeed = 10f;
			PlantType plantType2 = this.thePlantType;
			bullet.fromType = plantType2;
		}
	}

	// Token: 0x06000CB1 RID: 3249 RVA: 0x00049184 File Offset: 0x00047384
	[Token(Token = "0x6000CB1")]
	[Address(RVA = "0x3E76C0", Offset = "0x3E5CC0", VA = "0x1803E76C0")]
	public LittleSquash()
	{
	}

	// Token: 0x040008C7 RID: 2247
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008C7")]
	public Transform axis;

	// Token: 0x040008C8 RID: 2248
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008C8")]
	private Transform shadow;

	// Token: 0x040008C9 RID: 2249
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008C9")]
	public int theRow;

	// Token: 0x040008CA RID: 2250
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40008CA")]
	public int theDamage;

	// Token: 0x040008CB RID: 2251
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008CB")]
	public PlantType thePlantType;

	// Token: 0x040008CC RID: 2252
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008CC")]
	public Board board;

	// Token: 0x040008CD RID: 2253
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40008CD")]
	public int maxCrashCount;

	// Token: 0x040008CE RID: 2254
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40008CE")]
	private LittleSquash.Status status;

	// Token: 0x040008CF RID: 2255
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40008CF")]
	private float timer = 0.3f;

	// Token: 0x040008D0 RID: 2256
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40008D0")]
	private LayerMask zombieLayer;

	// Token: 0x040008D1 RID: 2257
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40008D1")]
	private Animator anim;

	// Token: 0x040008D2 RID: 2258
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40008D2")]
	private Vector3 jumpTargetPosition;

	// Token: 0x040008D3 RID: 2259
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40008D3")]
	private SortingGroup sortingGroup;

	// Token: 0x040008D4 RID: 2260
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40008D4")]
	private int crashCount;

	// Token: 0x040008D5 RID: 2261
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x40008D5")]
	private readonly float moveSpeed = 13f;

	// Token: 0x040008D6 RID: 2262
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40008D6")]
	public Action<int, int> crashAction;

	// Token: 0x040008D7 RID: 2263
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40008D7")]
	public Action<int, int> lastAction;

	// Token: 0x020002C7 RID: 711
	[Token(Token = "0x20002C7")]
	private enum Status
	{
		// Token: 0x040008D9 RID: 2265
		[Token(Token = "0x40008D9")]
		Default,
		// Token: 0x040008DA RID: 2266
		[Token(Token = "0x40008DA")]
		Moving,
		// Token: 0x040008DB RID: 2267
		[Token(Token = "0x40008DB")]
		Waiting,
		// Token: 0x040008DC RID: 2268
		[Token(Token = "0x40008DC")]
		Crashing,
		// Token: 0x040008DD RID: 2269
		[Token(Token = "0x40008DD")]
		Crashed
	}
}
