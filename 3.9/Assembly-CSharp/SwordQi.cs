using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000723 RID: 1827
[Token(Token = "0x2000723")]
public class SwordQi : MonoBehaviour
{
	// Token: 0x06002413 RID: 9235 RVA: 0x000BC4C0 File Offset: 0x000BA6C0
	[Token(Token = "0x6002413")]
	[Address(RVA = "0x5F6870", Offset = "0x5F4E70", VA = "0x1805F6870")]
	private void Awake()
	{
		Rigidbody2D component = base.GetComponent<Rigidbody2D>();
		this.rb = component;
		this.rb.interpolation = (RigidbodyInterpolation2D)((uint)1);
	}

	// Token: 0x06002414 RID: 9236 RVA: 0x000BC4F0 File Offset: 0x000BA6F0
	[Token(Token = "0x6002414")]
	[Address(RVA = "0x5F69A0", Offset = "0x5F4FA0", VA = "0x1805F69A0")]
	private void Start()
	{
		Rigidbody2D rigidbody2D = this.rb;
	}

	// Token: 0x06002415 RID: 9237 RVA: 0x000BC50C File Offset: 0x000BA70C
	[Token(Token = "0x6002415")]
	[Address(RVA = "0x5F69E0", Offset = "0x5F4FE0", VA = "0x1805F69E0")]
	private void Update()
	{
		float num = this.timer;
		float deltaTime = Time.deltaTime;
		this.timer = num;
		GameObject gameObject = base.gameObject;
		int num2 = 0;
		global::UnityEngine.Object.Destroy(gameObject);
		this.rb.velocity = num2;
	}

	// Token: 0x06002416 RID: 9238 RVA: 0x000BC558 File Offset: 0x000BA758
	[Token(Token = "0x6002416")]
	[Address(RVA = "0x5F68E0", Offset = "0x5F4EE0", VA = "0x1805F68E0")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int num = this.theRow;
			if (this.free)
			{
			}
		}
	}

	// Token: 0x06002417 RID: 9239 RVA: 0x000BC580 File Offset: 0x000BA780
	[Token(Token = "0x6002417")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public SwordQi()
	{
	}

	// Token: 0x0400121E RID: 4638
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400121E")]
	public bool free;

	// Token: 0x0400121F RID: 4639
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400121F")]
	public int dmg;

	// Token: 0x04001220 RID: 4640
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001220")]
	public int theRow;

	// Token: 0x04001221 RID: 4641
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001221")]
	public float timer;

	// Token: 0x04001222 RID: 4642
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001222")]
	public Vector3 v;

	// Token: 0x04001223 RID: 4643
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001223")]
	private Rigidbody2D rb;
}
