using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000B4 RID: 180
[Token(Token = "0x20000B4")]
public class FruitBomb : MonoBehaviour
{
	// Token: 0x0600032F RID: 815 RVA: 0x0000DC78 File Offset: 0x0000BE78
	[Token(Token = "0x600032F")]
	[Address(RVA = "0x40E990", Offset = "0x40CF90", VA = "0x18040E990")]
	private void Awake()
	{
		Rigidbody2D component = base.GetComponent<Rigidbody2D>();
		this.rb = component;
	}

	// Token: 0x06000330 RID: 816 RVA: 0x0000DC94 File Offset: 0x0000BE94
	[Token(Token = "0x6000330")]
	[Address(RVA = "0x40EC50", Offset = "0x40D250", VA = "0x18040EC50")]
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

	// Token: 0x06000331 RID: 817 RVA: 0x0000DD10 File Offset: 0x0000BF10
	[Token(Token = "0x6000331")]
	[Address(RVA = "0x40E9E0", Offset = "0x40CFE0", VA = "0x18040E9E0")]
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

	// Token: 0x06000332 RID: 818 RVA: 0x0000DD74 File Offset: 0x0000BF74
	[Token(Token = "0x6000332")]
	[Address(RVA = "0x40EBF0", Offset = "0x40D1F0", VA = "0x18040EBF0")]
	private void OnBecameInvisible()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000333 RID: 819 RVA: 0x0000DD8C File Offset: 0x0000BF8C
	[Token(Token = "0x6000333")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public FruitBomb()
	{
	}

	// Token: 0x04000177 RID: 375
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000177")]
	public GameObject explosionPrefab;

	// Token: 0x04000178 RID: 376
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000178")]
	public Rigidbody2D rb;
}
