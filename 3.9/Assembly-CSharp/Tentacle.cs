using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002ED RID: 749
[Token(Token = "0x20002ED")]
public class Tentacle : MonoBehaviour
{
	// Token: 0x170000F1 RID: 241
	// (get) Token: 0x06000D6E RID: 3438 RVA: 0x0004CB74 File Offset: 0x0004AD74
	[Token(Token = "0x170000F1")]
	private PlantType FromType
	{
		[Token(Token = "0x6000D6E")]
		[Address(RVA = "0x4411D0", Offset = "0x43F7D0", VA = "0x1804411D0")]
		get
		{
			UltimateSeaShroom ultimateSeaShroom = this.plant;
			int num = 0;
			if (!(ultimateSeaShroom != num))
			{
				return PlantType.Nothing;
			}
			return this.plant.thePlantType;
		}
	}

	// Token: 0x06000D6F RID: 3439 RVA: 0x0004CBA8 File Offset: 0x0004ADA8
	[Token(Token = "0x6000D6F")]
	[Address(RVA = "0x43FE50", Offset = "0x43E450", VA = "0x18043FE50")]
	private void Awake()
	{
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
		if (Lawnf.TravelUltimate((UltiBuff)((uint)44)))
		{
			this.count = (int)((ulong)3L);
			this.eat = true;
		}
	}

	// Token: 0x06000D70 RID: 3440 RVA: 0x0004CBE0 File Offset: 0x0004ADE0
	[Token(Token = "0x6000D70")]
	[Address(RVA = "0x4404E0", Offset = "0x43EAE0", VA = "0x1804404E0")]
	private void Grab()
	{
		Animator animator = this.anim;
		this.grab = true;
		animator.SetTrigger("grab");
		uint num;
		GameAPP.PlaySound((int)num, 0.5f, 1f);
		Zombie zombie = this.targetZombie;
		if (this.status != UltimateSeaShroom.Status.Doom)
		{
			int theZombieType = (int)zombie.theZombieType;
			Zombie zombie2 = this.targetZombie;
			bool flag;
			if (!flag)
			{
				Collider2D col = zombie2.col;
				int num2 = 0;
				if (col != num2)
				{
					Collider2D col2 = this.targetZombie.col;
					int num3 = 0;
					col2.enabled = num3 != 0;
				}
				this.targetZombie.theOriginSpeed = 0f;
				this.targetZombie.tentacle = this;
				int theZombieRow = this.targetZombie.theZombieRow;
				int column = this.targetZombie.Column;
				Board board = this.board;
				int num4 = 0;
				int num5 = 0;
				if (num5 < board.columnNum)
				{
					int num6 = 0;
					Board board2 = this.board;
					if (num6 < board2.rowNum)
					{
						if (board2.gridSystem.GetGrid(num4, num6).boxType == BoxType.Water)
						{
							num4 -= column;
							uint num7;
							if (num6 < (int)num7)
							{
							}
						}
						num6++;
					}
					num4++;
				}
				uint num8;
				if (num8 != (uint)(-1) && num8 != (uint)(-1))
				{
					float boxXFromColumn = Lawnf.GetBoxXFromColumn((int)num8);
					this.waterPosition = boxXFromColumn;
					float landY = Mouse.Instance.GetLandY(boxXFromColumn, (int)num8);
					this.waterPosition.y = landY;
					this.waterRow = (int)num8;
				}
				return;
			}
			long totalFirstHealth = zombie2.TotalFirstHealth;
			PlantType fromType = this.FromType;
		}
		long num9 = zombie.TotalFirstHealth;
		int num10 = this.count;
		int num11 = 0;
		int fromType2 = (int)this.FromType;
		num9 -= (long)num11;
		Board board3 = this.board;
		Zombie zombie3 = this.targetZombie;
		BoardAction boardAction = board3.boardAction;
		int column2 = zombie3.Column;
		Zombie zombie4 = this.targetZombie;
		zombie += zombie;
		PlantType fromType3 = this.FromType;
		global::UnityEngine.Object.Destroy(base.gameObject);
		throw new NullReferenceException();
	}

	// Token: 0x06000D71 RID: 3441 RVA: 0x0004CDD4 File Offset: 0x0004AFD4
	[Token(Token = "0x6000D71")]
	[Address(RVA = "0x440030", Offset = "0x43E630", VA = "0x180440030")]
	private void GetNearestWaterBox(int currentRow, int currentColumn)
	{
		Board board = this.board;
		int num = 0;
		int num2 = 0;
		if (num2 < board.columnNum)
		{
			int num3 = 0;
			Board board2 = this.board;
			if (num3 < board2.rowNum)
			{
				if (board2.gridSystem.GetGrid(num, num3).boxType == BoxType.Water)
				{
					num -= currentColumn;
					uint num4;
					if (num3 < (int)num4)
					{
					}
				}
				num3++;
			}
			num++;
		}
		uint num5;
		if (num5 != (uint)(-1) && num5 != (uint)(-1))
		{
			float boxXFromColumn = Lawnf.GetBoxXFromColumn((int)num5);
			this.waterPosition = boxXFromColumn;
			float landY = Mouse.Instance.GetLandY(boxXFromColumn, (int)num5);
			this.waterPosition.y = landY;
			this.waterRow = (int)num5;
		}
	}

	// Token: 0x06000D72 RID: 3442 RVA: 0x0004CE7C File Offset: 0x0004B07C
	[Token(Token = "0x6000D72")]
	[Address(RVA = "0x440190", Offset = "0x43E790", VA = "0x180440190")]
	private void GrabOver()
	{
		int num = this.count;
		this.count = num;
		global::UnityEngine.Object.Destroy(base.gameObject);
		Animator animator = this.anim;
		this.grab = false;
		animator.Play("idle");
		Zombie zombie = this.targetZombie;
		int num2 = this.waterRow;
		zombie.theZombieRow = num2;
		this.targetZombie.Die(2);
		Transform axis = this.targetZombie.axis;
		Vector3 vector;
		float z = vector.z;
		Vector2 oneVector = Vector2.oneVector;
		GameAPP.PlaySound(75, 0.5f, 1f);
		if (this.status == UltimateSeaShroom.Status.Hypno)
		{
			CreateZombie instance = CreateZombie.Instance;
			Transform transform = base.transform;
			int num3 = 0;
			Zombie zombie2;
			if (zombie2 != num3)
			{
				CherrySubmarine component = zombie2.GetComponent<CherrySubmarine>();
				GameObject body = component.body1;
				int num4 = 0;
				body.SetActive(num4 != 0);
				component.body2.SetActive(true);
				float theOriginSpeed = component.theOriginSpeed;
				component.theOriginSpeed = theOriginSpeed;
			}
		}
		if (this.eat)
		{
			UltimateSeaShroom ultimateSeaShroom = this.plant;
			int num5 = 0;
			if (ultimateSeaShroom != num5)
			{
				this.plant.EatSeaShroom(10);
			}
		}
	}

	// Token: 0x06000D73 RID: 3443 RVA: 0x0004CFA4 File Offset: 0x0004B1A4
	[Token(Token = "0x6000D73")]
	[Address(RVA = "0x4409E0", Offset = "0x43EFE0", VA = "0x1804409E0")]
	private void Update()
	{
		bool flag;
		for (;;)
		{
			Zombie zombie = this.targetZombie;
			int num = 0;
			flag = zombie != num;
			if (!flag)
			{
				break;
			}
			Zombie zombie2 = this.targetZombie;
			ZombieStatus theStatus = zombie2.theStatus;
			if (theStatus > ZombieStatus.Miner_rising)
			{
				if (flag <= true || theStatus == ZombieStatus.Bungi_awake)
				{
					zombie2.theOriginSpeed = 1f;
					this.targetZombie = (ulong)0L;
					if (0 == 1)
					{
						continue;
					}
					while (18446744073709551604UL <= (ulong)1L)
					{
					}
				}
				if (this.status != UltimateSeaShroom.Status.Hypno)
				{
					while (-12 != 0)
					{
					}
				}
				while (-12 == 0)
				{
				}
				Zombie zombie3 = this.targetZombie;
				bool flag2;
				while (!flag2)
				{
				}
				Tentacle tentacle = zombie3.tentacle;
				int num2 = 0;
				if (!(tentacle != num2) || !(this.targetZombie.tentacle != this))
				{
					goto IL_0132;
				}
			}
		}
		int num3 = 0;
		this.grab = flag;
		base.transform.rotation = num3;
		Board board = this.board;
		if (this.status != UltimateSeaShroom.Status.Doom)
		{
			Transform transform = base.transform;
			Func<Zombie, bool> func = new Func(this.CheckZombie);
		}
		Func<Zombie, bool> func2 = new Func(this.CheckZombie);
		Zombie mostHealthZombie = Lawnf.GetMostHealthZombie(board, func2);
		this.targetZombie = mostHealthZombie;
		float deltaTime = Time.deltaTime;
		this.timer = deltaTime;
		if (deltaTime > 15f)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
		}
		return;
		IL_0132:
		if (this.grab)
		{
			Transform transform2 = base.transform;
			Transform transform3 = base.transform;
			Transform transform4 = base.transform;
			int num4 = 0;
			float deltaTime2 = Time.deltaTime;
			Quaternion quaternion = Quaternion.Internal_FromEulerRad(num4);
			Zombie zombie4 = this.targetZombie;
			Transform transform5 = base.transform;
			Transform transform6 = base.transform;
			this.GrabOver();
		}
		Transform axis = this.targetZombie.axis;
		Transform transform7 = base.transform;
		Transform transform8 = base.transform;
		Transform transform9 = base.transform;
		float deltaTime3 = Time.deltaTime;
		Transform transform10 = base.transform;
		this.Grab();
		throw new NullReferenceException();
	}

	// Token: 0x06000D74 RID: 3444 RVA: 0x0004D178 File Offset: 0x0004B378
	[Token(Token = "0x6000D74")]
	[Address(RVA = "0x43FEC0", Offset = "0x43E4C0", VA = "0x18043FEC0")]
	private bool CheckZombie2(Zombie zombie)
	{
		ZombieStatus theStatus = zombie.theStatus;
		if (theStatus <= ZombieStatus.Miner_rising || theStatus == ZombieStatus.Bungi_awake)
		{
			while (theStatus == ZombieStatus.Dying)
			{
			}
		}
		bool isMindControlled = zombie.isMindControlled;
		if (this.status != UltimateSeaShroom.Status.Hypno)
		{
			while (isMindControlled)
			{
			}
			return zombie.beforeDying == isMindControlled;
		}
		while (!isMindControlled)
		{
		}
		while (zombie.beforeDying)
		{
		}
		return zombie.theZombieType != ZombieType.CherrySubmarine;
	}

	// Token: 0x06000D75 RID: 3445 RVA: 0x0004D1E0 File Offset: 0x0004B3E0
	[Token(Token = "0x6000D75")]
	[Address(RVA = "0x43FF40", Offset = "0x43E540", VA = "0x18043FF40")]
	private bool CheckZombie(Zombie zombie)
	{
		for (;;)
		{
			ZombieStatus theStatus = zombie.theStatus;
			if (theStatus > ZombieStatus.Miner_rising)
			{
				if (typeof(global::UnityEngine.Object).TypeHandle > (ulong)3L && theStatus != ZombieStatus.Bungi_awake)
				{
					goto IL_002B;
				}
			}
			while (theStatus == ZombieStatus.Dying)
			{
			}
			while (typeof(global::UnityEngine.Object).TypeHandle <= (ulong)1L)
			{
			}
			IL_002B:
			bool isMindControlled = zombie.isMindControlled;
			if (this.status != UltimateSeaShroom.Status.Hypno)
			{
				while (isMindControlled)
				{
				}
			}
			while (!isMindControlled)
			{
			}
			while (zombie.beforeDying)
			{
			}
			if (zombie.theZombieType != ZombieType.CherrySubmarine)
			{
				Collider2D col = zombie.col;
				int num = 0;
				if (col != num)
				{
					break;
				}
			}
		}
		return zombie.col.enabled;
	}

	// Token: 0x06000D76 RID: 3446 RVA: 0x0004D274 File Offset: 0x0004B474
	[Token(Token = "0x6000D76")]
	[Address(RVA = "0x4411B0", Offset = "0x43F7B0", VA = "0x1804411B0")]
	public Tentacle()
	{
	}

	// Token: 0x04000995 RID: 2453
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000995")]
	public Board board;

	// Token: 0x04000996 RID: 2454
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000996")]
	public int waterRow;

	// Token: 0x04000997 RID: 2455
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000997")]
	public Vector3 waterPosition;

	// Token: 0x04000998 RID: 2456
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000998")]
	public int damage;

	// Token: 0x04000999 RID: 2457
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000999")]
	public Zombie targetZombie;

	// Token: 0x0400099A RID: 2458
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400099A")]
	public bool grab;

	// Token: 0x0400099B RID: 2459
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400099B")]
	public UltimateSeaShroom.Status status;

	// Token: 0x0400099C RID: 2460
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400099C")]
	public UltimateSeaShroom plant;

	// Token: 0x0400099D RID: 2461
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400099D")]
	private int count = (int)((ulong)1L);

	// Token: 0x0400099E RID: 2462
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400099E")]
	private Animator anim;

	// Token: 0x0400099F RID: 2463
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400099F")]
	private float timer;

	// Token: 0x040009A0 RID: 2464
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40009A0")]
	private readonly float speed = 6f;

	// Token: 0x040009A1 RID: 2465
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40009A1")]
	private bool eat;
}
