using System;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x02000099 RID: 153
[Token(Token = "0x2000099")]
public class BrickBall : MonoBehaviour, IDamageMaker
{
	// Token: 0x17000077 RID: 119
	// (get) Token: 0x06000296 RID: 662 RVA: 0x0000A6F8 File Offset: 0x000088F8
	// (set) Token: 0x06000297 RID: 663 RVA: 0x0000A710 File Offset: 0x00008910
	[Token(Token = "0x17000077")]
	public Team Team
	{
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "4")]
		get
		{
			return Team.Player;
		}
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x4049E0", Offset = "0x402FE0", VA = "0x1804049E0", Slot = "5")]
		set
		{
			NotImplementedException ex = new NotImplementedException();
		}
	}

	// Token: 0x06000298 RID: 664 RVA: 0x0000A724 File Offset: 0x00008924
	[Token(Token = "0x6000298")]
	[Address(RVA = "0x403D40", Offset = "0x402340", VA = "0x180403D40")]
	private void Awake()
	{
		CircleCollider2D circleCollider2D = this.AddComponent<CircleCollider2D>();
		Rigidbody2D rigidbody2D = this.AddComponent<Rigidbody2D>();
		this.rb = rigidbody2D;
		Rigidbody2D rigidbody2D2 = this.rb;
		int num = 0;
		rigidbody2D2.gravityScale = (float)num;
		this.rb.isKinematic = true;
		this.rb.interpolation = (RigidbodyInterpolation2D)((uint)1);
		this.rb.collisionDetectionMode = (CollisionDetectionMode2D)((uint)1);
	}

	// Token: 0x06000299 RID: 665 RVA: 0x0000A784 File Offset: 0x00008984
	[Token(Token = "0x6000299")]
	[Address(RVA = "0x403F00", Offset = "0x402500", VA = "0x180403F00")]
	private void FixedUpdate()
	{
		Rigidbody2D rigidbody2D = this.rb;
		Vector2 velocity = rigidbody2D.velocity;
		int num = 0;
		float num2;
		rigidbody2D.angularVelocity = num2;
		if (this.isLaunched)
		{
			Vector2 velocity2 = this.rb.velocity;
			Rigidbody2D rigidbody2D2 = this.rb;
			if (0 != 0)
			{
			}
			Vector2 velocity3 = rigidbody2D2.velocity;
			int num3 = 0;
			float num4 = this.speed;
			rigidbody2D2.velocity = num3;
			Vector2 velocity4 = this.rb.velocity;
			Rigidbody2D rigidbody2D3 = this.rb;
			if (rigidbody2D3.velocity < num)
			{
			}
			Rigidbody2D rigidbody2D4 = this.rb;
			int num5 = 0;
			Vector2 velocity5 = rigidbody2D4.velocity;
			rigidbody2D3.velocity = num5;
		}
		Transform transform = base.transform;
		Transform transform2 = this.paddle;
		global::UnityEngine.Object.Destroy(base.gameObject);
		bool flag = BrickManager.Instance.launcher.balls.Remove(this);
	}

	// Token: 0x0600029A RID: 666 RVA: 0x0000A85C File Offset: 0x00008A5C
	[Token(Token = "0x600029A")]
	[Address(RVA = "0x403E40", Offset = "0x402440", VA = "0x180403E40")]
	public void Die()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
		bool flag = BrickManager.Instance.launcher.balls.Remove(this);
	}

	// Token: 0x0600029B RID: 667 RVA: 0x0000A890 File Offset: 0x00008A90
	[Token(Token = "0x600029B")]
	[Address(RVA = "0x404390", Offset = "0x402990", VA = "0x180404390")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		Rigidbody2D rigidbody2D = this.rb;
		int num = 0;
		int num2 = 0;
		Vector2 velocity = rigidbody2D.velocity;
		if (num == 0 && collision.TryGetComponent<Zombie>(num2))
		{
			PlantType plantType = this.thePlantType;
			if (plantType > PlantType.SunNut)
			{
				if (plantType == PlantType.HypnoNut)
				{
					CreateZombie instance = CreateZombie.Instance;
					int num3 = 0;
					Zombie zombie;
					if (!(zombie != num3))
					{
						goto IL_00B1;
					}
					Lawnf.SetZombieHealth(zombie.GetComponent<Zombie>(), 0.25f);
				}
				if (plantType != PlantType.IceNut)
				{
					goto IL_00B1;
				}
			}
			if (plantType == PlantType.CherryNut)
			{
				BoardAction boardAction = Board.Instance.boardAction;
				Transform transform = base.transform;
			}
			if (plantType == PlantType.SunNut)
			{
				CreateItem instance2 = CreateItem.Instance;
				Transform transform2 = base.transform;
				Vector3 vector;
				float z = vector.z;
			}
			IL_00B1:
			ScreenShake.TriggerShake(0.02f);
			Transform transform3 = base.transform;
			Vector2 position = this.rb.position;
			int num4 = 0;
			this.rb.velocity = num4;
		}
	}

	// Token: 0x0600029C RID: 668 RVA: 0x0000A984 File Offset: 0x00008B84
	[Token(Token = "0x600029C")]
	[Address(RVA = "0x404900", Offset = "0x402F00", VA = "0x180404900")]
	private void SimulateCollisionBounce(Collider2D collision)
	{
		Transform transform = base.transform;
		Vector2 position = this.rb.position;
		int num = 0;
		float num2 = this.speed;
		this.rb.velocity = num;
	}

	// Token: 0x0600029D RID: 669 RVA: 0x0000A9C4 File Offset: 0x00008BC4
	[Token(Token = "0x600029D")]
	[Address(RVA = "0x404250", Offset = "0x402850", VA = "0x180404250")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
		Rigidbody2D rigidbody = collision.rigidbody;
		int num = 0;
		bool flag;
		if (rigidbody != num && flag)
		{
			GameAPP.PlaySound(global::UnityEngine.Random.Range(54, 56), 0.5f, 1f);
			ScreenShake.TriggerShake(0.02f);
		}
	}

	// Token: 0x0600029E RID: 670 RVA: 0x0000AA14 File Offset: 0x00008C14
	[Token(Token = "0x600029E")]
	[Address(RVA = "0x403E00", Offset = "0x402400", VA = "0x180403E00", Slot = "6")]
	public bool CanAttack(IDamageable target)
	{
		NotImplementedException ex = new NotImplementedException();
		return false;
	}

	// Token: 0x0600029F RID: 671 RVA: 0x0000AA28 File Offset: 0x00008C28
	[Token(Token = "0x600029F")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public BrickBall()
	{
	}

	// Token: 0x040000E3 RID: 227
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000E3")]
	public PlantType thePlantType;

	// Token: 0x040000E4 RID: 228
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000E4")]
	public Transform paddle;

	// Token: 0x040000E5 RID: 229
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000E5")]
	public Rigidbody2D rb;

	// Token: 0x040000E6 RID: 230
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000E6")]
	public float speed;

	// Token: 0x040000E7 RID: 231
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40000E7")]
	public bool isLaunched;
}
