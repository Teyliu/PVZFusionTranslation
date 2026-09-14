using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200080F RID: 2063
[Token(Token = "0x200080F")]
[RequireComponent(typeof(Animator))]
public class AnimRandomSpeed : MonoBehaviour
{
	// Token: 0x06002A01 RID: 10753 RVA: 0x000E2CF0 File Offset: 0x000E0EF0
	[Token(Token = "0x6002A01")]
	[Address(RVA = "0x68EAE0", Offset = "0x68D0E0", VA = "0x18068EAE0")]
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

	// Token: 0x06002A02 RID: 10754 RVA: 0x000E2D5C File Offset: 0x000E0F5C
	[Token(Token = "0x6002A02")]
	[Address(RVA = "0x68EBD0", Offset = "0x68D1D0", VA = "0x18068EBD0")]
	private void OnEnable()
	{
		Animator animator = this.animator;
		float num = global::UnityEngine.Random.Range((float)0, 1f);
		int num2 = 0;
		animator.Play("idle", num2, num);
	}

	// Token: 0x06002A03 RID: 10755 RVA: 0x000E2D94 File Offset: 0x000E0F94
	[Token(Token = "0x6002A03")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public AnimRandomSpeed()
	{
	}

	// Token: 0x040017FE RID: 6142
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40017FE")]
	private Animator animator;
}
