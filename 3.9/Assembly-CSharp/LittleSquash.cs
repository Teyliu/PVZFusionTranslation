using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020002D4 RID: 724
[Token(Token = "0x20002D4")]
public class LittleSquash : MonoBehaviour
{
	// Token: 0x06000CE9 RID: 3305 RVA: 0x00049844 File Offset: 0x00047A44
	[Token(Token = "0x6000CE9")]
	[Address(RVA = "0x4372D0", Offset = "0x4358D0", VA = "0x1804372D0")]
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

	// Token: 0x06000CEA RID: 3306 RVA: 0x000498E0 File Offset: 0x00047AE0
	[Token(Token = "0x6000CEA")]
	[Address(RVA = "0x437FE0", Offset = "0x4365E0", VA = "0x180437FE0")]
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

	// Token: 0x06000CEB RID: 3307 RVA: 0x0004997C File Offset: 0x00047B7C
	[Token(Token = "0x6000CEB")]
	[Address(RVA = "0x4381A0", Offset = "0x4367A0", VA = "0x1804381A0")]
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

	// Token: 0x06000CEC RID: 3308 RVA: 0x000499B4 File Offset: 0x00047BB4
	[Token(Token = "0x6000CEC")]
	[Address(RVA = "0x437940", Offset = "0x435F40", VA = "0x180437940")]
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

	// Token: 0x06000CED RID: 3309 RVA: 0x00049A74 File Offset: 0x00047C74
	[Token(Token = "0x6000CED")]
	[Address(RVA = "0x437770", Offset = "0x435D70", VA = "0x180437770")]
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

	// Token: 0x06000CEE RID: 3310 RVA: 0x00049AF0 File Offset: 0x00047CF0
	[Token(Token = "0x6000CEE")]
	[Address(RVA = "0x4372C0", Offset = "0x4358C0", VA = "0x1804372C0")]
	private void AnimJump()
	{
		this.status = (LittleSquash.Status)((ulong)1L);
	}

	// Token: 0x06000CEF RID: 3311 RVA: 0x00049B08 File Offset: 0x00047D08
	[Token(Token = "0x6000CEF")]
	[Address(RVA = "0x437DA0", Offset = "0x4363A0", VA = "0x180437DA0")]
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

	// Token: 0x06000CF0 RID: 3312 RVA: 0x00049B60 File Offset: 0x00047D60
	[Token(Token = "0x6000CF0")]
	[Address(RVA = "0x436E80", Offset = "0x435480", VA = "0x180436E80")]
	private void AdjustPosition(Vector3 targetPosition)
	{
		Transform transform = this.axis;
		Transform transform2 = base.transform;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06000CF1 RID: 3313 RVA: 0x00049B8C File Offset: 0x00047D8C
	[Token(Token = "0x6000CF1")]
	[Address(RVA = "0x436F80", Offset = "0x435580", VA = "0x180436F80")]
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

	// Token: 0x06000CF2 RID: 3314 RVA: 0x00049C78 File Offset: 0x00047E78
	[Token(Token = "0x6000CF2")]
	[Address(RVA = "0x437450", Offset = "0x435A50", VA = "0x180437450")]
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

	// Token: 0x06000CF3 RID: 3315 RVA: 0x00049CC4 File Offset: 0x00047EC4
	[Token(Token = "0x6000CF3")]
	[Address(RVA = "0x4374F0", Offset = "0x435AF0", VA = "0x1804374F0")]
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

	// Token: 0x06000CF4 RID: 3316 RVA: 0x00049D70 File Offset: 0x00047F70
	[Token(Token = "0x6000CF4")]
	[Address(RVA = "0x438200", Offset = "0x436800", VA = "0x180438200")]
	public LittleSquash()
	{
	}

	// Token: 0x04000904 RID: 2308
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000904")]
	public Transform axis;

	// Token: 0x04000905 RID: 2309
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000905")]
	private Transform shadow;

	// Token: 0x04000906 RID: 2310
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000906")]
	public int theRow;

	// Token: 0x04000907 RID: 2311
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000907")]
	public int theDamage;

	// Token: 0x04000908 RID: 2312
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000908")]
	public PlantType thePlantType;

	// Token: 0x04000909 RID: 2313
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000909")]
	public Board board;

	// Token: 0x0400090A RID: 2314
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400090A")]
	public int maxCrashCount;

	// Token: 0x0400090B RID: 2315
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400090B")]
	private LittleSquash.Status status;

	// Token: 0x0400090C RID: 2316
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400090C")]
	private float timer = 0.3f;

	// Token: 0x0400090D RID: 2317
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400090D")]
	private LayerMask zombieLayer;

	// Token: 0x0400090E RID: 2318
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400090E")]
	private Animator anim;

	// Token: 0x0400090F RID: 2319
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400090F")]
	private Vector3 jumpTargetPosition;

	// Token: 0x04000910 RID: 2320
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000910")]
	private SortingGroup sortingGroup;

	// Token: 0x04000911 RID: 2321
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000911")]
	private int crashCount;

	// Token: 0x04000912 RID: 2322
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000912")]
	private readonly float moveSpeed = 13f;

	// Token: 0x04000913 RID: 2323
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000913")]
	public Action<int, int> crashAction;

	// Token: 0x04000914 RID: 2324
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000914")]
	public Action<int, int> lastAction;

	// Token: 0x020002D5 RID: 725
	[Token(Token = "0x20002D5")]
	private enum Status
	{
		// Token: 0x04000916 RID: 2326
		[Token(Token = "0x4000916")]
		Default,
		// Token: 0x04000917 RID: 2327
		[Token(Token = "0x4000917")]
		Moving,
		// Token: 0x04000918 RID: 2328
		[Token(Token = "0x4000918")]
		Waiting,
		// Token: 0x04000919 RID: 2329
		[Token(Token = "0x4000919")]
		Crashing,
		// Token: 0x0400091A RID: 2330
		[Token(Token = "0x400091A")]
		Crashed
	}
}
