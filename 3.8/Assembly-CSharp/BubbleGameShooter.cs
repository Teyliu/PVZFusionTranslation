using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000A0 RID: 160
[Token(Token = "0x20000A0")]
public class BubbleGameShooter : MonoBehaviour
{
	// Token: 0x060002B3 RID: 691 RVA: 0x0000B778 File Offset: 0x00009978
	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x3BB4C0", Offset = "0x3B9AC0", VA = "0x1803BB4C0")]
	private void Start()
	{
		this.InitBubble();
	}

	// Token: 0x060002B4 RID: 692 RVA: 0x0000B78C File Offset: 0x0000998C
	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x3BB330", Offset = "0x3B9930", VA = "0x1803BB330")]
	private void InitBubble()
	{
		BubbleGameManager bubbleGameManager = this.manager;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		BubbleGameItem bubbleGameItem;
		this.bubble = bubbleGameItem;
		Transform transform2 = this.bubble.transform;
		Transform transform3 = this.wait;
		transform2.parentInternal = transform3;
		Transform transform4 = this.bubble.transform;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		this.bubble.onShooter = true;
		Collider2D col = this.bubble.col;
		int num = 0;
		col.enabled = num != 0;
	}

	// Token: 0x060002B5 RID: 693 RVA: 0x0000B814 File Offset: 0x00009A14
	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x3BB4D0", Offset = "0x3B9AD0", VA = "0x1803BB4D0")]
	private void Update()
	{
		Camera main = Camera.main;
		float z = Input.mousePosition.z;
		Transform transform = this.shoot;
		Vector3 vector;
		float z2 = vector.z;
		Vector3 vector2;
		float z3 = vector2.z;
		int num = 0;
		Transform transform2 = base.transform;
		int num2 = 0;
		transform2.GetChild(num2).rotation = num2;
		int num3 = 0;
		this.direction = num;
		if (Input.GetMouseButtonDown(num3))
		{
			Queue<BubbleGameItem> destoryBubbles = this.manager.destoryBubbles;
			if (!Board.Instance.over)
			{
				Transform transform3 = this.bubble.transform;
				Transform transform4 = Board.Instance.transform;
				transform3.parentInternal = transform4;
				Transform transform5 = this.bubble.transform;
				Transform transform6 = this.shoot;
				Rigidbody2D rb = this.bubble.rb;
				int num4 = 0;
				rb.isKinematic = num4 != 0;
				BubbleGameItem bubbleGameItem = this.bubble;
				Vector2 vector3 = this.direction;
				float y = this.direction.y;
				bubbleGameItem.rb.AddForce(num4, (ForceMode2D)((uint)1));
				this.bubble.rb.interpolation = (RigidbodyInterpolation2D)((uint)1);
				this.bubble.col.enabled = true;
				this.InitBubble();
				GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
			}
		}
	}

	// Token: 0x060002B6 RID: 694 RVA: 0x0000B964 File Offset: 0x00009B64
	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public BubbleGameShooter()
	{
	}

	// Token: 0x0400010D RID: 269
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400010D")]
	public BubbleGameManager manager;

	// Token: 0x0400010E RID: 270
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400010E")]
	public Vector2 direction;

	// Token: 0x0400010F RID: 271
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400010F")]
	public BubbleGameItem bubble;

	// Token: 0x04000110 RID: 272
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000110")]
	public Transform shoot;

	// Token: 0x04000111 RID: 273
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000111")]
	public Transform wait;
}
