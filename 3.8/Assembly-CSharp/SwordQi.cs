using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006EB RID: 1771
[Token(Token = "0x20006EB")]
public class SwordQi : MonoBehaviour
{
	// Token: 0x060022F7 RID: 8951 RVA: 0x000B767C File Offset: 0x000B587C
	[Token(Token = "0x60022F7")]
	[Address(RVA = "0x57C290", Offset = "0x57A890", VA = "0x18057C290")]
	private void Awake()
	{
		Rigidbody2D component = base.GetComponent<Rigidbody2D>();
		this.rb = component;
		this.rb.interpolation = (RigidbodyInterpolation2D)((uint)1);
	}

	// Token: 0x060022F8 RID: 8952 RVA: 0x000B76AC File Offset: 0x000B58AC
	[Token(Token = "0x60022F8")]
	[Address(RVA = "0x57C3C0", Offset = "0x57A9C0", VA = "0x18057C3C0")]
	private void Start()
	{
		Rigidbody2D rigidbody2D = this.rb;
	}

	// Token: 0x060022F9 RID: 8953 RVA: 0x000B76C8 File Offset: 0x000B58C8
	[Token(Token = "0x60022F9")]
	[Address(RVA = "0x57C400", Offset = "0x57AA00", VA = "0x18057C400")]
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

	// Token: 0x060022FA RID: 8954 RVA: 0x000B7714 File Offset: 0x000B5914
	[Token(Token = "0x60022FA")]
	[Address(RVA = "0x57C300", Offset = "0x57A900", VA = "0x18057C300")]
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

	// Token: 0x060022FB RID: 8955 RVA: 0x000B773C File Offset: 0x000B593C
	[Token(Token = "0x60022FB")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public SwordQi()
	{
	}

	// Token: 0x04001151 RID: 4433
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001151")]
	public bool free;

	// Token: 0x04001152 RID: 4434
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001152")]
	public int dmg;

	// Token: 0x04001153 RID: 4435
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001153")]
	public int theRow;

	// Token: 0x04001154 RID: 4436
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001154")]
	public float timer;

	// Token: 0x04001155 RID: 4437
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001155")]
	public Vector3 v;

	// Token: 0x04001156 RID: 4438
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001156")]
	private Rigidbody2D rb;
}
