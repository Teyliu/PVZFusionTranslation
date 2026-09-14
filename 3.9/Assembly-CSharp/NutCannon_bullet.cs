using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel.RogueShooting;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x020000DD RID: 221
[Token(Token = "0x20000DD")]
public class NutCannon_bullet : MonoBehaviour
{
	// Token: 0x06000439 RID: 1081 RVA: 0x000154C4 File Offset: 0x000136C4
	[Token(Token = "0x6000439")]
	[Address(RVA = "0x4FEC70", Offset = "0x4FD270", VA = "0x1804FEC70")]
	private void Start()
	{
		Transform transform = base.transform;
		int num = 0;
		BoxCollider2D boxCollider2D = transform.GetChild(num).AddComponent<BoxCollider2D>();
		this.col = boxCollider2D;
		this.col.isTrigger = true;
		Rigidbody2D rigidbody2D = this.AddComponent<Rigidbody2D>();
		this.rb = rigidbody2D;
		this.rb.interpolation = (RigidbodyInterpolation2D)((uint)1);
		this.rb.isKinematic = true;
		float boardMaxX = Board.Instance.boardMaxX;
		this.maxX = boardMaxX;
		float boardMinX = Board.Instance.boardMinX;
		this.minX = boardMinX;
		Mouse instance = Mouse.Instance;
		Transform transform2 = base.transform;
		float num2;
		this.maxY = num2;
		Mouse instance2 = Mouse.Instance;
		Transform transform3 = base.transform;
		Board instance3 = Board.Instance;
		float num3;
		this.minY = num3;
		Board instance4 = Board.Instance;
		ShootingManager instance5 = ShootingManager.Instance;
		long num4;
		this.damage = (int)num4;
		if (instance5.stage == 2)
		{
			this.damage = (int)num4;
			return;
		}
		long num5 = instance4 * (uint)28;
		this.damage = (int)num5;
	}

	// Token: 0x0600043A RID: 1082 RVA: 0x000155C0 File Offset: 0x000137C0
	[Token(Token = "0x600043A")]
	[Address(RVA = "0x4FE620", Offset = "0x4FCC20", VA = "0x1804FE620")]
	public void Launch()
	{
		this.launched = true;
		Transform transform = base.transform;
		Transform transform2 = Board.Instance.transform;
		transform.parentInternal = transform2;
	}

	// Token: 0x0600043B RID: 1083 RVA: 0x000155F4 File Offset: 0x000137F4
	[Token(Token = "0x600043B")]
	[Address(RVA = "0x4FE220", Offset = "0x4FC820", VA = "0x1804FE220")]
	private void FixedUpdate()
	{
		if (this.launched)
		{
			Transform transform = base.transform;
			Vector3 vector;
			float z = vector.z;
			if (z > 180f)
			{
			}
			Rigidbody2D rigidbody2D = this.rb;
			Transform transform2 = base.transform;
			int num = 0;
			float num2 = this.moveSpeed;
			rigidbody2D.velocity = num;
			Transform transform3 = base.transform;
			Vector3 vector2;
			if (vector2.y > this.maxY)
			{
				Transform transform4 = base.transform;
				Transform transform5 = base.transform;
				Transform transform6 = base.transform;
			}
			Transform transform7 = base.transform;
			Vector3 vector3;
			if (this.minY > vector3.y)
			{
				Transform transform8 = base.transform;
				Transform transform9 = base.transform;
				Transform transform10 = base.transform;
			}
			Transform transform11 = base.transform;
			Transform transform12 = base.transform;
			float num3 = this.minX;
			global::UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600043C RID: 1084 RVA: 0x000156D4 File Offset: 0x000138D4
	[Token(Token = "0x600043C")]
	[Address(RVA = "0x4FE1C0", Offset = "0x4FC7C0", VA = "0x1804FE1C0")]
	private void Die()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x0600043D RID: 1085 RVA: 0x000156EC File Offset: 0x000138EC
	[Token(Token = "0x600043D")]
	[Address(RVA = "0x4FE6A0", Offset = "0x4FCCA0", VA = "0x1804FE6A0")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		int num = 0;
		bool flag;
		if ((this.launched ? 1 : 0) != num && flag)
		{
			Physics2D.IgnoreCollision(this.col, collision);
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			Transform transform3 = base.transform;
			Transform transform4 = base.transform;
			Transform transform5 = base.transform;
			Vector3 vector;
			if (vector.z > 330f)
			{
				Transform transform6 = base.transform;
				Transform transform7 = base.transform;
				Transform transform8 = base.transform;
			}
			Board instance = Board.Instance;
			int num2 = 0;
			if (instance != num2)
			{
				PlantType plantType = this.thePlantType;
				if (plantType > PlantType.HypnoNut)
				{
					if (plantType == PlantType.IceNut)
					{
						return;
					}
					if (typeof(Physics2D).TypeHandle == (ulong)1235L)
					{
						int num3 = this.damage;
					}
					while (typeof(Physics2D).TypeHandle != (ulong)1236L)
					{
					}
					int num4 = this.damage;
				}
				Crater crater;
				if (crater == (ulong)1003L)
				{
					List<SpriteRenderer> r = crater._r;
					int num5 = this.damage;
				}
				BombCherry bombCherry;
				while (bombCherry != (ulong)1147L)
				{
				}
				throw new NullReferenceException();
			}
		}
	}

	// Token: 0x0600043E RID: 1086 RVA: 0x000157F4 File Offset: 0x000139F4
	[Token(Token = "0x600043E")]
	[Address(RVA = "0x4FEF00", Offset = "0x4FD500", VA = "0x1804FEF00")]
	public NutCannon_bullet()
	{
	}

	// Token: 0x04000246 RID: 582
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000246")]
	public PlantType thePlantType;

	// Token: 0x04000247 RID: 583
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000247")]
	private float maxX;

	// Token: 0x04000248 RID: 584
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000248")]
	private float minX;

	// Token: 0x04000249 RID: 585
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000249")]
	private float maxY;

	// Token: 0x0400024A RID: 586
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400024A")]
	private float minY;

	// Token: 0x0400024B RID: 587
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400024B")]
	private int damage = (int)((ulong)300L);

	// Token: 0x0400024C RID: 588
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400024C")]
	private float moveSpeed = 12f;

	// Token: 0x0400024D RID: 589
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400024D")]
	private bool launched;

	// Token: 0x0400024E RID: 590
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400024E")]
	private BoxCollider2D col;

	// Token: 0x0400024F RID: 591
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400024F")]
	private Rigidbody2D rb;
}
