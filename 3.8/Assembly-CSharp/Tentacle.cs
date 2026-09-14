using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002DF RID: 735
[Token(Token = "0x20002DF")]
public class Tentacle : MonoBehaviour
{
	// Token: 0x170000B0 RID: 176
	// (get) Token: 0x06000D2B RID: 3371 RVA: 0x0004BF48 File Offset: 0x0004A148
	[Token(Token = "0x170000B0")]
	private PlantType FromType
	{
		[Token(Token = "0x6000D2B")]
		[Address(RVA = "0x3FD5D0", Offset = "0x3FBBD0", VA = "0x1803FD5D0")]
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

	// Token: 0x06000D2C RID: 3372 RVA: 0x0004BF7C File Offset: 0x0004A17C
	[Token(Token = "0x6000D2C")]
	[Address(RVA = "0x3FC250", Offset = "0x3FA850", VA = "0x1803FC250")]
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

	// Token: 0x06000D2D RID: 3373 RVA: 0x0004BFB4 File Offset: 0x0004A1B4
	[Token(Token = "0x6000D2D")]
	[Address(RVA = "0x3FC8E0", Offset = "0x3FAEE0", VA = "0x1803FC8E0")]
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
			float totalFirstHealth = zombie2.TotalFirstHealth;
			PlantType fromType = this.FromType;
		}
		float totalFirstHealth2 = zombie.TotalFirstHealth;
		PlantType fromType2 = this.FromType;
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

	// Token: 0x06000D2E RID: 3374 RVA: 0x0004C190 File Offset: 0x0004A390
	[Token(Token = "0x6000D2E")]
	[Address(RVA = "0x3FC430", Offset = "0x3FAA30", VA = "0x1803FC430")]
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

	// Token: 0x06000D2F RID: 3375 RVA: 0x0004C238 File Offset: 0x0004A438
	[Token(Token = "0x6000D2F")]
	[Address(RVA = "0x3FC590", Offset = "0x3FAB90", VA = "0x1803FC590")]
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

	// Token: 0x06000D30 RID: 3376 RVA: 0x0004C360 File Offset: 0x0004A560
	[Token(Token = "0x6000D30")]
	[Address(RVA = "0x3FCDE0", Offset = "0x3FB3E0", VA = "0x1803FCDE0")]
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
					goto IL_0113;
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
		}
		Func<Zombie, bool> func;
		Zombie mostHealthZombie = Lawnf.GetMostHealthZombie(board, func);
		this.targetZombie = mostHealthZombie;
		float deltaTime = Time.deltaTime;
		this.timer = deltaTime;
		if (deltaTime > 15f)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
		}
		return;
		IL_0113:
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

	// Token: 0x06000D31 RID: 3377 RVA: 0x0004C518 File Offset: 0x0004A718
	[Token(Token = "0x6000D31")]
	[Address(RVA = "0x3FC2C0", Offset = "0x3FA8C0", VA = "0x1803FC2C0")]
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

	// Token: 0x06000D32 RID: 3378 RVA: 0x0004C580 File Offset: 0x0004A780
	[Token(Token = "0x6000D32")]
	[Address(RVA = "0x3FC340", Offset = "0x3FA940", VA = "0x1803FC340")]
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

	// Token: 0x06000D33 RID: 3379 RVA: 0x0004C614 File Offset: 0x0004A814
	[Token(Token = "0x6000D33")]
	[Address(RVA = "0x3FD5B0", Offset = "0x3FBBB0", VA = "0x1803FD5B0")]
	public Tentacle()
	{
	}

	// Token: 0x04000958 RID: 2392
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000958")]
	public Board board;

	// Token: 0x04000959 RID: 2393
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000959")]
	public int waterRow;

	// Token: 0x0400095A RID: 2394
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400095A")]
	public Vector3 waterPosition;

	// Token: 0x0400095B RID: 2395
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400095B")]
	public int damage;

	// Token: 0x0400095C RID: 2396
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400095C")]
	public Zombie targetZombie;

	// Token: 0x0400095D RID: 2397
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400095D")]
	public bool grab;

	// Token: 0x0400095E RID: 2398
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400095E")]
	public UltimateSeaShroom.Status status;

	// Token: 0x0400095F RID: 2399
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400095F")]
	public UltimateSeaShroom plant;

	// Token: 0x04000960 RID: 2400
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000960")]
	private int count = (int)((ulong)1L);

	// Token: 0x04000961 RID: 2401
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000961")]
	private Animator anim;

	// Token: 0x04000962 RID: 2402
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000962")]
	private float timer;

	// Token: 0x04000963 RID: 2403
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000963")]
	private readonly float speed = 6f;

	// Token: 0x04000964 RID: 2404
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000964")]
	private bool eat;
}
