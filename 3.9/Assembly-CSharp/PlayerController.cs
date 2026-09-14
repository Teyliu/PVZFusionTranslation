using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020007D1 RID: 2001
[Token(Token = "0x20007D1")]
public class PlayerController : MonoBehaviour
{
	// Token: 0x060028AD RID: 10413 RVA: 0x000DB514 File Offset: 0x000D9714
	[Token(Token = "0x60028AD")]
	[Address(RVA = "0x667AD0", Offset = "0x6660D0", VA = "0x180667AD0")]
	private void Awake()
	{
		SortingGroup component = base.GetComponent<SortingGroup>();
		this.sortingGroup = component;
		Rigidbody2D component2 = base.GetComponent<Rigidbody2D>();
		this.rb = component2;
	}

	// Token: 0x060028AE RID: 10414 RVA: 0x000DB540 File Offset: 0x000D9740
	[Token(Token = "0x60028AE")]
	[Address(RVA = "0x667D00", Offset = "0x666300", VA = "0x180667D00")]
	private void Update()
	{
		this.InputUpdate();
	}

	// Token: 0x060028AF RID: 10415 RVA: 0x000DB554 File Offset: 0x000D9754
	[Token(Token = "0x60028AF")]
	[Address(RVA = "0x667B50", Offset = "0x666150", VA = "0x180667B50")]
	private void InputUpdate()
	{
		Rigidbody2D rigidbody2D = this.rb;
		if (Lawnf.GetKey((KeyCode)((uint)119)))
		{
			Rigidbody2D rigidbody2D2 = this.rb;
			int num = 0;
			Vector2 velocity = rigidbody2D2.velocity;
			rigidbody2D2.velocity = num;
		}
		if (Lawnf.GetKey((KeyCode)((uint)97)))
		{
			Rigidbody2D rigidbody2D3 = this.rb;
			int num2 = 0;
			Vector2 velocity2 = rigidbody2D3.velocity;
			rigidbody2D3.velocity = num2;
		}
		if (Lawnf.GetKey((KeyCode)((uint)115)))
		{
			Rigidbody2D rigidbody2D4 = this.rb;
			int num3 = 0;
			Vector2 velocity3 = rigidbody2D4.velocity;
			rigidbody2D4.velocity = num3;
		}
		if (Lawnf.GetKey((KeyCode)((uint)100)))
		{
			Rigidbody2D rigidbody2D5 = this.rb;
			int num4 = 0;
			Vector2 velocity4 = rigidbody2D5.velocity;
			rigidbody2D5.velocity = num4;
		}
	}

	// Token: 0x060028B0 RID: 10416 RVA: 0x000DB60C File Offset: 0x000D980C
	[Token(Token = "0x60028B0")]
	[Address(RVA = "0x667D10", Offset = "0x666310", VA = "0x180667D10")]
	public PlayerController()
	{
	}

	// Token: 0x040016BA RID: 5818
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40016BA")]
	public SortingGroup sortingGroup;

	// Token: 0x040016BB RID: 5819
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40016BB")]
	private Rigidbody2D rb;

	// Token: 0x040016BC RID: 5820
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40016BC")]
	private float moveSpeed = 5f;
}
