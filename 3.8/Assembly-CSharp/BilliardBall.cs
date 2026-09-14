using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200008F RID: 143
[Token(Token = "0x200008F")]
public class BilliardBall : MonoBehaviour, IDamageMaker
{
	// Token: 0x17000039 RID: 57
	// (get) Token: 0x0600025E RID: 606 RVA: 0x00009904 File Offset: 0x00007B04
	// (set) Token: 0x0600025F RID: 607 RVA: 0x0000991C File Offset: 0x00007B1C
	[Token(Token = "0x17000039")]
	public Team Team
	{
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "4")]
		get
		{
			return Team.Player;
		}
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x3B5B20", Offset = "0x3B4120", VA = "0x1803B5B20", Slot = "5")]
		set
		{
			NotImplementedException ex = new NotImplementedException();
		}
	}

	// Token: 0x06000260 RID: 608 RVA: 0x00009930 File Offset: 0x00007B30
	[Token(Token = "0x6000260")]
	[Address(RVA = "0x3B4DB0", Offset = "0x3B33B0", VA = "0x1803B4DB0")]
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

	// Token: 0x06000261 RID: 609 RVA: 0x00009988 File Offset: 0x00007B88
	[Token(Token = "0x6000261")]
	[Address(RVA = "0x3B4E90", Offset = "0x3B3490", VA = "0x1803B4E90")]
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

	// Token: 0x06000262 RID: 610 RVA: 0x000099E0 File Offset: 0x00007BE0
	[Token(Token = "0x6000262")]
	[Address(RVA = "0x3B5720", Offset = "0x3B3D20", VA = "0x1803B5720")]
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

	// Token: 0x06000263 RID: 611 RVA: 0x00009AB0 File Offset: 0x00007CB0
	[Token(Token = "0x6000263")]
	[Address(RVA = "0x3B4FE0", Offset = "0x3B35E0", VA = "0x1803B4FE0")]
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

	// Token: 0x06000264 RID: 612 RVA: 0x00009B1C File Offset: 0x00007D1C
	[Token(Token = "0x6000264")]
	[Address(RVA = "0x3B5120", Offset = "0x3B3720", VA = "0x1803B5120")]
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

	// Token: 0x06000265 RID: 613 RVA: 0x00009BD8 File Offset: 0x00007DD8
	[Token(Token = "0x6000265")]
	[Address(RVA = "0x3A5ED0", Offset = "0x3A44D0", VA = "0x1803A5ED0", Slot = "6")]
	public bool CanAttack(IDamageable target)
	{
		return true;
	}

	// Token: 0x06000266 RID: 614 RVA: 0x00009BE8 File Offset: 0x00007DE8
	[Token(Token = "0x6000266")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public BilliardBall()
	{
	}

	// Token: 0x040000B7 RID: 183
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000B7")]
	public Rigidbody2D rb;

	// Token: 0x040000B8 RID: 184
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000B8")]
	private Vector2 v;

	// Token: 0x040000B9 RID: 185
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000B9")]
	private Transform axis;

	// Token: 0x040000BA RID: 186
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000BA")]
	private SpriteRenderer r;

	// Token: 0x040000BB RID: 187
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000BB")]
	public BilliardBall.BilliardBallType theBallType;

	// Token: 0x02000090 RID: 144
	[Token(Token = "0x2000090")]
	public enum BilliardBallType
	{
		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		Normal,
		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		Cherry,
		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		Ice,
		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		Iron,
		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		Hypno,
		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		Sun
	}
}
