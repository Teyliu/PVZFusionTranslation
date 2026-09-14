using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200028B RID: 651
[Token(Token = "0x200028B")]
public class Mower : MonoBehaviour
{
	// Token: 0x1700009B RID: 155
	// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x00043DC0 File Offset: 0x00041FC0
	[Token(Token = "0x1700009B")]
	public int Column
	{
		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0x3D7220", Offset = "0x3D5820", VA = "0x1803D7220")]
		get
		{
			Transform transform = this.axis;
			int num;
			return num;
		}
	}

	// Token: 0x06000BC3 RID: 3011 RVA: 0x00043DE0 File Offset: 0x00041FE0
	[Token(Token = "0x6000BC3")]
	[Address(RVA = "0x3D68B0", Offset = "0x3D4EB0", VA = "0x1803D68B0", Slot = "4")]
	protected virtual void Awake()
	{
		LayerMask layerMask = LayerMask.GetMask(new string[] { "Zombie" });
		this.zombieLayer = layerMask;
		Rigidbody2D component = base.GetComponent<Rigidbody2D>();
		this.rb = component;
		Animator component2 = base.GetComponent<Animator>();
		this.anim = component2;
		Transform transform = base.transform.Find("Shadow");
		this.axis = transform;
		throw new NullReferenceException();
	}

	// Token: 0x06000BC4 RID: 3012 RVA: 0x00043E50 File Offset: 0x00042050
	[Token(Token = "0x6000BC4")]
	[Address(RVA = "0x3D70E0", Offset = "0x3D56E0", VA = "0x1803D70E0", Slot = "5")]
	protected virtual void Update()
	{
		if (this.started)
		{
			Transform transform = this.axis;
			float boardMaxX = Board.Instance.boardMaxX;
			this.MoveWaterUpdate();
			return;
		}
	}

	// Token: 0x06000BC5 RID: 3013 RVA: 0x00043EA4 File Offset: 0x000420A4
	[Token(Token = "0x6000BC5")]
	[Address(RVA = "0x3D6B40", Offset = "0x3D5140", VA = "0x1803D6B40")]
	public void MoveWaterUpdate()
	{
		bool @bool = this.anim.GetBool("inWater");
		Transform transform = this.axis;
		Board board = this.board;
		int num = this.theMowerRow;
		int num2;
		bool flag = board.GetBoxType(num2, num) == BoxType.Water;
		if (@bool != flag)
		{
			Transform transform2 = this.axis;
			Vector3 vector;
			float z = vector.z;
			int num3 = 0;
			Transform transform3 = this.axis;
			ParticleManager instance = ParticleManager.Instance;
			int num4 = 0;
			int num5 = this.theMowerRow;
			ulong num6;
			Particle particle = instance.SetParticle((ParticleType)((uint)32), num4, num5, num6 != 0UL, (float)num3);
			GameAPP.PlaySound((SoundType)((uint)24), 0.5f, 1f);
		}
		this.anim.SetBool("inWater", flag);
	}

	// Token: 0x06000BC6 RID: 3014 RVA: 0x00043F5C File Offset: 0x0004215C
	[Token(Token = "0x6000BC6")]
	[Address(RVA = "0x3D6A90", Offset = "0x3D5090", VA = "0x1803D6A90")]
	private void FixedUpdate()
	{
		Board instance = Board.Instance;
		if (this.started)
		{
			Transform transform = this.axis;
			Rigidbody2D rigidbody2D = this.rb;
			return;
		}
	}

	// Token: 0x06000BC7 RID: 3015 RVA: 0x00043F90 File Offset: 0x00042190
	[Token(Token = "0x6000BC7")]
	[Address(RVA = "0x3D6D50", Offset = "0x3D5350", VA = "0x1803D6D50")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			if (collision > (ulong)46L)
			{
				if (flag <= true || flag <= true)
				{
					return;
				}
				if (collision == (ulong)260L)
				{
					return;
				}
			}
			else if (flag)
			{
				return;
			}
			int num = this.theMowerRow;
			if (!this.started)
			{
				if (collision == (ulong)45L)
				{
					return;
				}
				if (collision != (ulong)63L)
				{
					BoardStatistics boardStatistics = this.board.boardStatistics;
					MowerType mowerType = this.theMowerType;
					if (mowerType != MowerType.LawnMower)
					{
						if (mowerType == MowerType.LawnMower || mowerType == MowerType.LawnMower)
						{
							return;
						}
						if (mowerType != MowerType.PoolMower)
						{
							goto IL_008E;
						}
					}
					uint num2;
					GameAPP.PlaySound((int)num2, 0.5f, 1f);
					IL_008E:
					Board board = this.board;
					BoardSpawner boardSpawner = board.boardSpawner;
					int theWave = board.theWave;
					int num3 = this.theMowerRow;
					boardSpawner.MowerStart(num3, theWave);
					Animator animator = this.anim;
					this.started = true;
					animator.SetTrigger("move");
					Rigidbody2D rigidbody2D = this.rb;
					return;
				}
			}
			return;
		}
	}

	// Token: 0x06000BC8 RID: 3016 RVA: 0x00044084 File Offset: 0x00042284
	[Token(Token = "0x6000BC8")]
	[Address(RVA = "0x3D6870", Offset = "0x3D4E70", VA = "0x1803D6870", Slot = "6")]
	protected virtual void AttackZombie(Zombie zombie)
	{
		throw new NullReferenceException();
	}

	// Token: 0x06000BC9 RID: 3017 RVA: 0x00044098 File Offset: 0x00042298
	[Token(Token = "0x6000BC9")]
	[Address(RVA = "0x3D6FD0", Offset = "0x3D55D0", VA = "0x1803D6FD0")]
	public void StartMove()
	{
		MowerType mowerType = this.theMowerType;
		if (mowerType != MowerType.LawnMower)
		{
			if (mowerType == MowerType.LawnMower || mowerType == MowerType.LawnMower)
			{
				throw new NullReferenceException();
			}
			if (mowerType != MowerType.PoolMower)
			{
				goto IL_0027;
			}
		}
		uint num;
		GameAPP.PlaySound((int)num, 0.5f, 1f);
		IL_0027:
		Board board = this.board;
		BoardSpawner boardSpawner = board.boardSpawner;
		int theWave = board.theWave;
		int num2 = this.theMowerRow;
		boardSpawner.MowerStart(num2, theWave);
		Animator animator = this.anim;
		this.started = true;
		animator.SetTrigger("move");
		Rigidbody2D rigidbody2D = this.rb;
	}

	// Token: 0x06000BCA RID: 3018 RVA: 0x00044120 File Offset: 0x00042320
	[Token(Token = "0x6000BCA")]
	[Address(RVA = "0x3D69E0", Offset = "0x3D4FE0", VA = "0x1803D69E0")]
	public void Die()
	{
		bool flag = Board.Instance.mowerArray.Remove(this);
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000BCB RID: 3019 RVA: 0x00044150 File Offset: 0x00042350
	[Token(Token = "0x6000BCB")]
	[Address(RVA = "0x3D7210", Offset = "0x3D5810", VA = "0x1803D7210")]
	public Mower()
	{
	}

	// Token: 0x040007CD RID: 1997
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007CD")]
	public int theMowerRow;

	// Token: 0x040007CE RID: 1998
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40007CE")]
	public MowerType theMowerType;

	// Token: 0x040007CF RID: 1999
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007CF")]
	public Transform axis;

	// Token: 0x040007D0 RID: 2000
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40007D0")]
	public bool started;

	// Token: 0x040007D1 RID: 2001
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40007D1")]
	public Board board;

	// Token: 0x040007D2 RID: 2002
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40007D2")]
	private readonly float speed = 5f;

	// Token: 0x040007D3 RID: 2003
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40007D3")]
	private Rigidbody2D rb;

	// Token: 0x040007D4 RID: 2004
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40007D4")]
	protected Animator anim;

	// Token: 0x040007D5 RID: 2005
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40007D5")]
	protected LayerMask zombieLayer;
}
