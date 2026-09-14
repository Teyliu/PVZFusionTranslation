using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007D6 RID: 2006
[Token(Token = "0x20007D6")]
[RequireComponent(typeof(Animator))]
public class AnimRandomSpeed : MonoBehaviour
{
	// Token: 0x060028D2 RID: 10450 RVA: 0x000DDD00 File Offset: 0x000DBF00
	[Token(Token = "0x60028D2")]
	[Address(RVA = "0x62B1E0", Offset = "0x6297E0", VA = "0x18062B1E0")]
	private void Awake()
	{
		Animator component = base.GetComponent<Animator>();
		this.animator = component;
		Animator animator = this.animator;
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		animator.SetFloat("Speed", num);
		Animator animator2 = this.animator;
		float num2 = global::UnityEngine.Random.Range((float)0, 1f);
		int num3 = 0;
		animator2.Play("idle", num3, num2);
	}

	// Token: 0x060028D3 RID: 10451 RVA: 0x000DDD6C File Offset: 0x000DBF6C
	[Token(Token = "0x60028D3")]
	[Address(RVA = "0x62B2D0", Offset = "0x6298D0", VA = "0x18062B2D0")]
	private void OnEnable()
	{
		Animator animator = this.animator;
		float num = global::UnityEngine.Random.Range((float)0, 1f);
		int num2 = 0;
		animator.Play("idle", num2, num);
	}

	// Token: 0x060028D4 RID: 10452 RVA: 0x000DDDA4 File Offset: 0x000DBFA4
	[Token(Token = "0x60028D4")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public AnimRandomSpeed()
	{
	}

	// Token: 0x04001722 RID: 5922
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001722")]
	private Animator animator;
}
