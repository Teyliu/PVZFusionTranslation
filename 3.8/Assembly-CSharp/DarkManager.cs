using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000824 RID: 2084
[Token(Token = "0x2000824")]
public class DarkManager : MonoBehaviour
{
	// Token: 0x06002A57 RID: 10839 RVA: 0x000E7C48 File Offset: 0x000E5E48
	[Token(Token = "0x6002A57")]
	[Address(RVA = "0x64CFD0", Offset = "0x64B5D0", VA = "0x18064CFD0")]
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

	// Token: 0x06002A58 RID: 10840 RVA: 0x000E7C7C File Offset: 0x000E5E7C
	[Token(Token = "0x6002A58")]
	[Address(RVA = "0x64D040", Offset = "0x64B640", VA = "0x18064D040")]
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

	// Token: 0x06002A59 RID: 10841 RVA: 0x000E7D14 File Offset: 0x000E5F14
	[Token(Token = "0x6002A59")]
	[Address(RVA = "0x64D120", Offset = "0x64B720", VA = "0x18064D120")]
	public DarkManager()
	{
	}

	// Token: 0x040018AE RID: 6318
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40018AE")]
	public bool isEnter;

	// Token: 0x040018AF RID: 6319
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40018AF")]
	private SpriteRenderer r;

	// Token: 0x040018B0 RID: 6320
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40018B0")]
	private Color color;

	// Token: 0x040018B1 RID: 6321
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40018B1")]
	private float existTime;
}
