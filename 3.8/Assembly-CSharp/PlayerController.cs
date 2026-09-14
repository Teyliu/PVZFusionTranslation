using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000798 RID: 1944
[Token(Token = "0x2000798")]
public class PlayerController : MonoBehaviour
{
	// Token: 0x0600277E RID: 10110 RVA: 0x000D652C File Offset: 0x000D472C
	[Token(Token = "0x600277E")]
	[Address(RVA = "0x6042C0", Offset = "0x6028C0", VA = "0x1806042C0")]
	private void Awake()
	{
		SortingGroup component = base.GetComponent<SortingGroup>();
		this.sortingGroup = component;
		Rigidbody2D component2 = base.GetComponent<Rigidbody2D>();
		this.rb = component2;
	}

	// Token: 0x0600277F RID: 10111 RVA: 0x000D6558 File Offset: 0x000D4758
	[Token(Token = "0x600277F")]
	[Address(RVA = "0x6044F0", Offset = "0x602AF0", VA = "0x1806044F0")]
	private void Update()
	{
		this.InputUpdate();
	}

	// Token: 0x06002780 RID: 10112 RVA: 0x000D656C File Offset: 0x000D476C
	[Token(Token = "0x6002780")]
	[Address(RVA = "0x604340", Offset = "0x602940", VA = "0x180604340")]
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

	// Token: 0x06002781 RID: 10113 RVA: 0x000D6624 File Offset: 0x000D4824
	[Token(Token = "0x6002781")]
	[Address(RVA = "0x604500", Offset = "0x602B00", VA = "0x180604500")]
	public PlayerController()
	{
	}

	// Token: 0x040015DE RID: 5598
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40015DE")]
	public SortingGroup sortingGroup;

	// Token: 0x040015DF RID: 5599
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40015DF")]
	private Rigidbody2D rb;

	// Token: 0x040015E0 RID: 5600
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40015E0")]
	private float moveSpeed = 5f;
}
