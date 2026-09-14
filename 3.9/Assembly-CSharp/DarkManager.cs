using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000860 RID: 2144
[Token(Token = "0x2000860")]
public class DarkManager : MonoBehaviour
{
	// Token: 0x06002B89 RID: 11145 RVA: 0x000ECA84 File Offset: 0x000EAC84
	[Token(Token = "0x6002B89")]
	[Address(RVA = "0x6B0D70", Offset = "0x6AF370", VA = "0x1806B0D70")]
	private void Start()
	{
		SpriteRenderer component = base.GetComponent<SpriteRenderer>();
		this.r = component;
		if (this.isEnter)
		{
			return;
		}
		int num = 0;
		this.color.a = (float)num;
	}

	// Token: 0x06002B8A RID: 11146 RVA: 0x000ECAB8 File Offset: 0x000EACB8
	[Token(Token = "0x6002B8A")]
	[Address(RVA = "0x6B0DE0", Offset = "0x6AF3E0", VA = "0x1806B0DE0")]
	private void Update()
	{
		float deltaTime = Time.deltaTime;
		this.existTime = deltaTime;
		float a = this.color.a;
		int num = 0;
		if ((this.isEnter ? 1 : 0) == num)
		{
			float num2 = Time.deltaTime * 1.5f;
			this.color.a = num2;
		}
		float deltaTime2 = Time.deltaTime;
		this.color.a = a;
		SpriteRenderer spriteRenderer = this.r;
		Color color = this.color;
		spriteRenderer.color = color;
		if (this.existTime > 1f)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06002B8B RID: 11147 RVA: 0x000ECB50 File Offset: 0x000EAD50
	[Token(Token = "0x6002B8B")]
	[Address(RVA = "0x6B0EC0", Offset = "0x6AF4C0", VA = "0x1806B0EC0")]
	public DarkManager()
	{
	}

	// Token: 0x0400199C RID: 6556
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400199C")]
	public bool isEnter;

	// Token: 0x0400199D RID: 6557
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400199D")]
	private SpriteRenderer r;

	// Token: 0x0400199E RID: 6558
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400199E")]
	private Color color;

	// Token: 0x0400199F RID: 6559
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400199F")]
	private float existTime;
}
