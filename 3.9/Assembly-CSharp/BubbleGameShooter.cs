using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000A5 RID: 165
[Token(Token = "0x20000A5")]
public class BubbleGameShooter : MonoBehaviour
{
	// Token: 0x060002CE RID: 718 RVA: 0x0000BB24 File Offset: 0x00009D24
	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x408270", Offset = "0x406870", VA = "0x180408270")]
	private void Start()
	{
		this.InitBubble();
	}

	// Token: 0x060002CF RID: 719 RVA: 0x0000BB38 File Offset: 0x00009D38
	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x4080E0", Offset = "0x4066E0", VA = "0x1804080E0")]
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

	// Token: 0x060002D0 RID: 720 RVA: 0x0000BBC0 File Offset: 0x00009DC0
	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x408280", Offset = "0x406880", VA = "0x180408280")]
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

	// Token: 0x060002D1 RID: 721 RVA: 0x0000BD10 File Offset: 0x00009F10
	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public BubbleGameShooter()
	{
	}

	// Token: 0x0400011A RID: 282
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400011A")]
	public BubbleGameManager manager;

	// Token: 0x0400011B RID: 283
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400011B")]
	public Vector2 direction;

	// Token: 0x0400011C RID: 284
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400011C")]
	public BubbleGameItem bubble;

	// Token: 0x0400011D RID: 285
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400011D")]
	public Transform shoot;

	// Token: 0x0400011E RID: 286
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400011E")]
	public Transform wait;
}
