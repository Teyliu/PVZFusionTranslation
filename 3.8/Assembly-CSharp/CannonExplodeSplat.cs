using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002AE RID: 686
[Token(Token = "0x20002AE")]
public class CannonExplodeSplat : MonoBehaviour
{
	// Token: 0x06000C1F RID: 3103 RVA: 0x00045CC0 File Offset: 0x00043EC0
	[Token(Token = "0x6000C1F")]
	[Address(RVA = "0x3D15C0", Offset = "0x3CFBC0", VA = "0x1803D15C0")]
	private void Awake()
	{
		Rigidbody2D component = base.GetComponent<Rigidbody2D>();
		this.rb = component;
		Transform transform = base.transform;
		int num = global::UnityEngine.Random.Range(0, 3);
		transform.GetChild(num).gameObject.SetActive(true);
	}

	// Token: 0x06000C20 RID: 3104 RVA: 0x00045D04 File Offset: 0x00043F04
	[Token(Token = "0x6000C20")]
	[Address(RVA = "0x3D1660", Offset = "0x3CFC60", VA = "0x1803D1660")]
	private void FixedUpdate()
	{
		Rigidbody2D rigidbody2D = this.rb;
		float rotation = rigidbody2D.rotation;
		Vector2 velocity = this.rb.velocity;
		rigidbody2D.rotation = rotation;
	}

	// Token: 0x06000C21 RID: 3105 RVA: 0x00045D38 File Offset: 0x00043F38
	[Token(Token = "0x6000C21")]
	[Address(RVA = "0x3D16D0", Offset = "0x3CFCD0", VA = "0x1803D16D0")]
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

	// Token: 0x06000C22 RID: 3106 RVA: 0x00045DB4 File Offset: 0x00043FB4
	[Token(Token = "0x6000C22")]
	[Address(RVA = "0x3D1880", Offset = "0x3CFE80", VA = "0x1803D1880")]
	public CannonExplodeSplat()
	{
	}

	// Token: 0x04000823 RID: 2083
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000823")]
	public int row;

	// Token: 0x04000824 RID: 2084
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000824")]
	public int damage;

	// Token: 0x04000825 RID: 2085
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000825")]
	public PlantType fromType = (PlantType)((ulong)4294967295L);

	// Token: 0x04000826 RID: 2086
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000826")]
	public Rigidbody2D rb;

	// Token: 0x04000827 RID: 2087
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000827")]
	public Board board;
}
