using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000094 RID: 148
[Token(Token = "0x2000094")]
public class BilliardBall : MonoBehaviour, IDamageMaker
{
	// Token: 0x17000076 RID: 118
	// (get) Token: 0x06000279 RID: 633 RVA: 0x00009C7C File Offset: 0x00007E7C
	// (set) Token: 0x0600027A RID: 634 RVA: 0x00009C94 File Offset: 0x00007E94
	[Token(Token = "0x17000076")]
	public Team Team
	{
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "4")]
		get
		{
			return Team.Player;
		}
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x4028B0", Offset = "0x400EB0", VA = "0x1804028B0", Slot = "5")]
		set
		{
			NotImplementedException ex = new NotImplementedException();
		}
	}

	// Token: 0x0600027B RID: 635 RVA: 0x00009CA8 File Offset: 0x00007EA8
	[Token(Token = "0x600027B")]
	[Address(RVA = "0x401B40", Offset = "0x400140", VA = "0x180401B40")]
	private void Awake()
	{
		Rigidbody2D component = base.GetComponent<Rigidbody2D>();
		this.rb = component;
		Transform transform = base.transform.Find("Shadow");
		this.axis = transform;
		Transform transform2 = base.transform;
		int num = 0;
		SpriteRenderer component2 = transform2.GetChild(num).GetComponent<SpriteRenderer>();
		this.r = component2;
		throw new NullReferenceException();
	}

	// Token: 0x0600027C RID: 636 RVA: 0x00009D00 File Offset: 0x00007F00
	[Token(Token = "0x600027C")]
	[Address(RVA = "0x401C20", Offset = "0x400220", VA = "0x180401C20")]
	public void Hit(Vector2 rodPositon, float force)
	{
		GameAPP.PlaySound(53, 0.5f, 1f);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		Board instance = Board.Instance;
		Rigidbody2D rigidbody2D = this.rb;
		int num = 0;
		float num2 = force * 90f;
		rigidbody2D.velocity = num;
	}

	// Token: 0x0600027D RID: 637 RVA: 0x00009D58 File Offset: 0x00007F58
	[Token(Token = "0x600027D")]
	[Address(RVA = "0x4024B0", Offset = "0x400AB0", VA = "0x1804024B0")]
	private void Update()
	{
		Vector2 velocity = this.rb.velocity;
		Rigidbody2D rigidbody2D = this.rb;
		this.v = velocity;
		this.v.y = (float)0;
		Vector2 velocity2 = rigidbody2D.velocity;
		Rigidbody2D rigidbody2D2 = this.rb;
		Rigidbody2D rigidbody2D3 = this.rb;
		Vector2 velocity3 = rigidbody2D3.velocity;
		Vector2 velocity4 = this.rb.velocity;
		int num = 0;
		rigidbody2D3.angularVelocity = (float)num;
		Transform transform = this.axis;
		Transform transform2 = base.transform;
		Vector3 vector;
		float z = vector.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform3 = this.axis;
		Mouse instance = Mouse.Instance;
		Transform transform4 = this.axis;
		SpriteRenderer spriteRenderer = this.r;
		int num2;
		string text = string.Format("plant{0}", num2);
		spriteRenderer.sortingLayerName = text;
	}

	// Token: 0x0600027E RID: 638 RVA: 0x00009E28 File Offset: 0x00008028
	[Token(Token = "0x600027E")]
	[Address(RVA = "0x401D70", Offset = "0x400370", VA = "0x180401D70")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
		Vector2 velocity = this.rb.velocity;
		if (0 == 0)
		{
			Rigidbody2D rigidbody2D = this.rb;
			int num = 0;
			Vector2 velocity2 = rigidbody2D.velocity;
			if (rigidbody2D == 0)
			{
				this.rb.velocity = num;
			}
			Rigidbody2D rigidbody2D2 = this.rb;
			int num2 = 0;
			Vector2 velocity3 = rigidbody2D2.velocity;
			if (rigidbody2D2 == 0)
			{
				this.rb.velocity = num2;
			}
		}
	}

	// Token: 0x0600027F RID: 639 RVA: 0x00009E94 File Offset: 0x00008094
	[Token(Token = "0x600027F")]
	[Address(RVA = "0x401EB0", Offset = "0x4004B0", VA = "0x180401EB0")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		int num = 0;
		bool flag;
		if (flag)
		{
			Vector2 velocity = this.rb.velocity;
			if (num == 0)
			{
				Vector2 velocity2 = this.rb.velocity;
				if (this.theBallType <= BilliardBall.BilliardBallType.Sun)
				{
					BoardAction boardAction = Board.Instance.boardAction;
					CreateZombie instance = CreateZombie.Instance;
					Zombie zombie;
					Lawnf.SetZombieHealth(zombie.GetComponent<Zombie>(), 0.3f);
					CreateItem instance2 = CreateItem.Instance;
					Transform transform = instance.transform;
					Transform transform2 = instance.transform;
					Transform transform3 = instance.transform;
					Vector3 vector;
					float z = vector.z;
				}
				uint num2;
				uint num3;
				GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num2, (int)num3), 0.5f, 1f);
				ScreenShake.TriggerShake(0.02f);
			}
		}
	}

	// Token: 0x06000280 RID: 640 RVA: 0x00009F50 File Offset: 0x00008150
	[Token(Token = "0x6000280")]
	[Address(RVA = "0x3F1E60", Offset = "0x3F0460", VA = "0x1803F1E60", Slot = "6")]
	public bool CanAttack(IDamageable target)
	{
		return true;
	}

	// Token: 0x06000281 RID: 641 RVA: 0x00009F60 File Offset: 0x00008160
	[Token(Token = "0x6000281")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public BilliardBall()
	{
	}

	// Token: 0x040000C4 RID: 196
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000C4")]
	public Rigidbody2D rb;

	// Token: 0x040000C5 RID: 197
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000C5")]
	private Vector2 v;

	// Token: 0x040000C6 RID: 198
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000C6")]
	private Transform axis;

	// Token: 0x040000C7 RID: 199
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000C7")]
	private SpriteRenderer r;

	// Token: 0x040000C8 RID: 200
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000C8")]
	public BilliardBall.BilliardBallType theBallType;

	// Token: 0x02000095 RID: 149
	[Token(Token = "0x2000095")]
	public enum BilliardBallType
	{
		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		Normal,
		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		Cherry,
		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		Ice,
		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		Iron,
		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		Hypno,
		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		Sun
	}
}
