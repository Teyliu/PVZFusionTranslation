using System;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x02000094 RID: 148
[Token(Token = "0x2000094")]
public class BrickBall : MonoBehaviour, IDamageMaker
{
	// Token: 0x1700003A RID: 58
	// (get) Token: 0x0600027B RID: 635 RVA: 0x0000A398 File Offset: 0x00008598
	// (set) Token: 0x0600027C RID: 636 RVA: 0x0000A3B0 File Offset: 0x000085B0
	[Token(Token = "0x1700003A")]
	public Team Team
	{
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "4")]
		get
		{
			return Team.Player;
		}
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x3B7C40", Offset = "0x3B6240", VA = "0x1803B7C40", Slot = "5")]
		set
		{
			NotImplementedException ex = new NotImplementedException();
		}
	}

	// Token: 0x0600027D RID: 637 RVA: 0x0000A3C4 File Offset: 0x000085C4
	[Token(Token = "0x600027D")]
	[Address(RVA = "0x3B6FA0", Offset = "0x3B55A0", VA = "0x1803B6FA0")]
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

	// Token: 0x0600027E RID: 638 RVA: 0x0000A424 File Offset: 0x00008624
	[Token(Token = "0x600027E")]
	[Address(RVA = "0x3B7160", Offset = "0x3B5760", VA = "0x1803B7160")]
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

	// Token: 0x0600027F RID: 639 RVA: 0x0000A4FC File Offset: 0x000086FC
	[Token(Token = "0x600027F")]
	[Address(RVA = "0x3B70A0", Offset = "0x3B56A0", VA = "0x1803B70A0")]
	public void Die()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
		bool flag = BrickManager.Instance.launcher.balls.Remove(this);
	}

	// Token: 0x06000280 RID: 640 RVA: 0x0000A530 File Offset: 0x00008730
	[Token(Token = "0x6000280")]
	[Address(RVA = "0x3B75F0", Offset = "0x3B5BF0", VA = "0x1803B75F0")]
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

	// Token: 0x06000281 RID: 641 RVA: 0x0000A624 File Offset: 0x00008824
	[Token(Token = "0x6000281")]
	[Address(RVA = "0x3B7B60", Offset = "0x3B6160", VA = "0x1803B7B60")]
	private void SimulateCollisionBounce(Collider2D collision)
	{
		Transform transform = base.transform;
		Vector2 position = this.rb.position;
		int num = 0;
		float num2 = this.speed;
		this.rb.velocity = num;
	}

	// Token: 0x06000282 RID: 642 RVA: 0x0000A664 File Offset: 0x00008864
	[Token(Token = "0x6000282")]
	[Address(RVA = "0x3B74B0", Offset = "0x3B5AB0", VA = "0x1803B74B0")]
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

	// Token: 0x06000283 RID: 643 RVA: 0x0000A6B4 File Offset: 0x000088B4
	[Token(Token = "0x6000283")]
	[Address(RVA = "0x3B7060", Offset = "0x3B5660", VA = "0x1803B7060", Slot = "6")]
	public bool CanAttack(IDamageable target)
	{
		NotImplementedException ex = new NotImplementedException();
		return false;
	}

	// Token: 0x06000284 RID: 644 RVA: 0x0000A6C8 File Offset: 0x000088C8
	[Token(Token = "0x6000284")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public BrickBall()
	{
	}

	// Token: 0x040000D6 RID: 214
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000D6")]
	public PlantType thePlantType;

	// Token: 0x040000D7 RID: 215
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000D7")]
	public Transform paddle;

	// Token: 0x040000D8 RID: 216
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000D8")]
	public Rigidbody2D rb;

	// Token: 0x040000D9 RID: 217
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000D9")]
	public float speed;

	// Token: 0x040000DA RID: 218
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40000DA")]
	public bool isLaunched;
}
