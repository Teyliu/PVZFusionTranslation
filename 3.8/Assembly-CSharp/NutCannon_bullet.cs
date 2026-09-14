using System;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x020000D8 RID: 216
[Token(Token = "0x20000D8")]
public class NutCannon_bullet : MonoBehaviour
{
	// Token: 0x0600041E RID: 1054 RVA: 0x000150D0 File Offset: 0x000132D0
	[Token(Token = "0x600041E")]
	[Address(RVA = "0x4BEF00", Offset = "0x4BD500", VA = "0x1804BEF00")]
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
	}

	// Token: 0x0600041F RID: 1055 RVA: 0x00015194 File Offset: 0x00013394
	[Token(Token = "0x600041F")]
	[Address(RVA = "0x4BEBA0", Offset = "0x4BD1A0", VA = "0x1804BEBA0")]
	public void Launch()
	{
		this.launched = true;
		Transform transform = base.transform;
		Transform transform2 = Board.Instance.transform;
		transform.parentInternal = transform2;
	}

	// Token: 0x06000420 RID: 1056 RVA: 0x000151C8 File Offset: 0x000133C8
	[Token(Token = "0x6000420")]
	[Address(RVA = "0x4BE7A0", Offset = "0x4BCDA0", VA = "0x1804BE7A0")]
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

	// Token: 0x06000421 RID: 1057 RVA: 0x000152A8 File Offset: 0x000134A8
	[Token(Token = "0x6000421")]
	[Address(RVA = "0x4BE740", Offset = "0x4BCD40", VA = "0x1804BE740")]
	private void Die()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000422 RID: 1058 RVA: 0x000152C0 File Offset: 0x000134C0
	[Token(Token = "0x6000422")]
	[Address(RVA = "0x4BEC20", Offset = "0x4BD220", VA = "0x1804BEC20")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		if (this.launched && flag)
		{
			Physics2D.IgnoreCollision(this.col, collision);
			int num;
			GameAPP.PlaySound(num, 0.5f, 1f);
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			Transform transform3 = base.transform;
			Transform transform4 = base.transform;
			Vector3 vector;
			float z = vector.z;
			Transform transform5 = base.transform;
			Vector3 vector2;
			if (vector2.z > 330f)
			{
				Transform transform6 = base.transform;
				Transform transform7 = base.transform;
				Transform transform8 = base.transform;
			}
		}
	}

	// Token: 0x06000423 RID: 1059 RVA: 0x0001535C File Offset: 0x0001355C
	[Token(Token = "0x6000423")]
	[Address(RVA = "0x4BF120", Offset = "0x4BD720", VA = "0x1804BF120")]
	public NutCannon_bullet()
	{
	}

	// Token: 0x04000238 RID: 568
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000238")]
	public PlantType thePlantType;

	// Token: 0x04000239 RID: 569
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000239")]
	private float maxX;

	// Token: 0x0400023A RID: 570
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400023A")]
	private float minX;

	// Token: 0x0400023B RID: 571
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400023B")]
	private float maxY;

	// Token: 0x0400023C RID: 572
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400023C")]
	private float minY;

	// Token: 0x0400023D RID: 573
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400023D")]
	private int damage = (int)((ulong)300L);

	// Token: 0x0400023E RID: 574
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400023E")]
	private float moveSpeed = 12f;

	// Token: 0x0400023F RID: 575
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400023F")]
	private bool launched;

	// Token: 0x04000240 RID: 576
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000240")]
	private BoxCollider2D col;

	// Token: 0x04000241 RID: 577
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000241")]
	private Rigidbody2D rb;
}
