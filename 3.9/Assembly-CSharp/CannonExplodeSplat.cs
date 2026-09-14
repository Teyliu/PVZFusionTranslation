using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002B9 RID: 697
[Token(Token = "0x20002B9")]
public class CannonExplodeSplat : MonoBehaviour
{
	// Token: 0x06000C48 RID: 3144 RVA: 0x00045FE8 File Offset: 0x000441E8
	[Token(Token = "0x6000C48")]
	[Address(RVA = "0x41E420", Offset = "0x41CA20", VA = "0x18041E420")]
	private void Awake()
	{
		Rigidbody2D component = base.GetComponent<Rigidbody2D>();
		this.rb = component;
		Transform transform = base.transform;
		int num = global::UnityEngine.Random.Range(0, 3);
		transform.GetChild(num).gameObject.SetActive(true);
	}

	// Token: 0x06000C49 RID: 3145 RVA: 0x0004602C File Offset: 0x0004422C
	[Token(Token = "0x6000C49")]
	[Address(RVA = "0x41E4C0", Offset = "0x41CAC0", VA = "0x18041E4C0")]
	private void FixedUpdate()
	{
		Rigidbody2D rigidbody2D = this.rb;
		float rotation = rigidbody2D.rotation;
		Vector2 velocity = this.rb.velocity;
		rigidbody2D.rotation = rotation;
	}

	// Token: 0x06000C4A RID: 3146 RVA: 0x00046060 File Offset: 0x00044260
	[Token(Token = "0x6000C4A")]
	[Address(RVA = "0x41E530", Offset = "0x41CB30", VA = "0x18041E530")]
	private void Update()
	{
		Vector2 velocity = this.rb.velocity;
		Transform transform = base.transform;
		Vector3 vector;
		float y = vector.y;
		Mouse instance = Mouse.Instance;
		Transform transform2 = base.transform;
		float num;
		if (num > y)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			BoardAction boardAction = this.board.boardAction;
			Transform transform3 = base.transform;
			PlantType plantType = this.fromType;
			int num2 = this.damage;
		}
	}

	// Token: 0x06000C4B RID: 3147 RVA: 0x000460DC File Offset: 0x000442DC
	[Token(Token = "0x6000C4B")]
	[Address(RVA = "0x41E6E0", Offset = "0x41CCE0", VA = "0x18041E6E0")]
	public CannonExplodeSplat()
	{
	}

	// Token: 0x04000842 RID: 2114
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000842")]
	public int row;

	// Token: 0x04000843 RID: 2115
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000843")]
	public int damage;

	// Token: 0x04000844 RID: 2116
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000844")]
	public PlantType fromType = (PlantType)((ulong)4294967295L);

	// Token: 0x04000845 RID: 2117
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000845")]
	public Rigidbody2D rb;

	// Token: 0x04000846 RID: 2118
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000846")]
	public Board board;
}
