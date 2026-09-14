using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000291 RID: 657
[Token(Token = "0x2000291")]
public class Mower : MonoBehaviour
{
	// Token: 0x170000D9 RID: 217
	// (get) Token: 0x06000BDE RID: 3038 RVA: 0x00043C2C File Offset: 0x00041E2C
	[Token(Token = "0x170000D9")]
	public int Column
	{
		[Token(Token = "0x6000BDE")]
		[Address(RVA = "0x424970", Offset = "0x422F70", VA = "0x180424970")]
		get
		{
			Transform transform = this.axis;
			int num;
			return num;
		}
	}

	// Token: 0x06000BDF RID: 3039 RVA: 0x00043C4C File Offset: 0x00041E4C
	[Token(Token = "0x6000BDF")]
	[Address(RVA = "0x424000", Offset = "0x422600", VA = "0x180424000", Slot = "4")]
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

	// Token: 0x06000BE0 RID: 3040 RVA: 0x00043CBC File Offset: 0x00041EBC
	[Token(Token = "0x6000BE0")]
	[Address(RVA = "0x424830", Offset = "0x422E30", VA = "0x180424830", Slot = "5")]
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

	// Token: 0x06000BE1 RID: 3041 RVA: 0x00043D10 File Offset: 0x00041F10
	[Token(Token = "0x6000BE1")]
	[Address(RVA = "0x424290", Offset = "0x422890", VA = "0x180424290")]
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

	// Token: 0x06000BE2 RID: 3042 RVA: 0x00043DC8 File Offset: 0x00041FC8
	[Token(Token = "0x6000BE2")]
	[Address(RVA = "0x4241E0", Offset = "0x4227E0", VA = "0x1804241E0")]
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

	// Token: 0x06000BE3 RID: 3043 RVA: 0x00043DFC File Offset: 0x00041FFC
	[Token(Token = "0x6000BE3")]
	[Address(RVA = "0x4244A0", Offset = "0x422AA0", VA = "0x1804244A0")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			if (collision > (ulong)46L)
			{
				if (collision == (ulong)228L || flag <= true)
				{
					return;
				}
				if (flag <= true)
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

	// Token: 0x06000BE4 RID: 3044 RVA: 0x00043EF0 File Offset: 0x000420F0
	[Token(Token = "0x6000BE4")]
	[Address(RVA = "0x423FC0", Offset = "0x4225C0", VA = "0x180423FC0", Slot = "6")]
	protected virtual void AttackZombie(Zombie zombie)
	{
		throw new NullReferenceException();
	}

	// Token: 0x06000BE5 RID: 3045 RVA: 0x00043F04 File Offset: 0x00042104
	[Token(Token = "0x6000BE5")]
	[Address(RVA = "0x424720", Offset = "0x422D20", VA = "0x180424720")]
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

	// Token: 0x06000BE6 RID: 3046 RVA: 0x00043F8C File Offset: 0x0004218C
	[Token(Token = "0x6000BE6")]
	[Address(RVA = "0x424130", Offset = "0x422730", VA = "0x180424130")]
	public void Die()
	{
		bool flag = Board.Instance.mowerArray.Remove(this);
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000BE7 RID: 3047 RVA: 0x00043FBC File Offset: 0x000421BC
	[Token(Token = "0x6000BE7")]
	[Address(RVA = "0x424960", Offset = "0x422F60", VA = "0x180424960")]
	public Mower()
	{
	}

	// Token: 0x040007D9 RID: 2009
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007D9")]
	public int theMowerRow;

	// Token: 0x040007DA RID: 2010
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40007DA")]
	public MowerType theMowerType;

	// Token: 0x040007DB RID: 2011
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007DB")]
	public Transform axis;

	// Token: 0x040007DC RID: 2012
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40007DC")]
	public bool started;

	// Token: 0x040007DD RID: 2013
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40007DD")]
	public Board board;

	// Token: 0x040007DE RID: 2014
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40007DE")]
	private readonly float speed = 5f;

	// Token: 0x040007DF RID: 2015
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40007DF")]
	private Rigidbody2D rb;

	// Token: 0x040007E0 RID: 2016
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40007E0")]
	protected Animator anim;

	// Token: 0x040007E1 RID: 2017
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40007E1")]
	protected LayerMask zombieLayer;
}
