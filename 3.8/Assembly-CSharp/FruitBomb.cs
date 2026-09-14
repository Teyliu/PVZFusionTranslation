using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000AF RID: 175
[Token(Token = "0x20000AF")]
public class FruitBomb : MonoBehaviour
{
	// Token: 0x06000314 RID: 788 RVA: 0x0000D8D8 File Offset: 0x0000BAD8
	[Token(Token = "0x6000314")]
	[Address(RVA = "0x3C1BE0", Offset = "0x3C01E0", VA = "0x1803C1BE0")]
	private void Awake()
	{
		Rigidbody2D component = base.GetComponent<Rigidbody2D>();
		this.rb = component;
	}

	// Token: 0x06000315 RID: 789 RVA: 0x0000D8F4 File Offset: 0x0000BAF4
	[Token(Token = "0x6000315")]
	[Address(RVA = "0x3C1EA0", Offset = "0x3C04A0", VA = "0x1803C1EA0")]
	private void OnTriggerEnter2D(Collider2D other)
	{
		FruitBlade component = other.GetComponent<FruitBlade>();
		if (component && !component.auto)
		{
			BoardAction boardAction = Board.Instance.boardAction;
			Transform transform = base.transform;
			Vector3 vector;
			float z = vector.z;
			Mouse instance = Mouse.Instance;
			Transform transform2 = base.transform;
			Transform transform3 = base.transform;
			FruitNinjaManager.Instance.LoseScore(50f);
			global::UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000316 RID: 790 RVA: 0x0000D970 File Offset: 0x0000BB70
	[Token(Token = "0x6000316")]
	[Address(RVA = "0x3C1C30", Offset = "0x3C0230", VA = "0x1803C1C30")]
	private void Explode()
	{
		BoardAction boardAction = Board.Instance.boardAction;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		Mouse instance = Mouse.Instance;
		Transform transform2 = base.transform;
		Transform transform3 = base.transform;
		FruitNinjaManager.Instance.LoseScore(50f);
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000317 RID: 791 RVA: 0x0000D9D4 File Offset: 0x0000BBD4
	[Token(Token = "0x6000317")]
	[Address(RVA = "0x3C1E40", Offset = "0x3C0440", VA = "0x1803C1E40")]
	private void OnBecameInvisible()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000318 RID: 792 RVA: 0x0000D9EC File Offset: 0x0000BBEC
	[Token(Token = "0x6000318")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public FruitBomb()
	{
	}

	// Token: 0x0400016A RID: 362
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400016A")]
	public GameObject explosionPrefab;

	// Token: 0x0400016B RID: 363
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400016B")]
	public Rigidbody2D rb;
}
