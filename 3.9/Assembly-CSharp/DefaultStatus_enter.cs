using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000076 RID: 118
[Token(Token = "0x2000076")]
public class DefaultStatus_enter : StateMachineBehaviour
{
	// Token: 0x060001FA RID: 506 RVA: 0x00006B34 File Offset: 0x00004D34
	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x3F3670", Offset = "0x3F1C70", VA = "0x1803F3670", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		int num = 0;
		if (!animator.TryGetComponent<Plant>(num))
		{
			if (animator.TryGetComponent<Zombie>(num))
			{
			}
			return;
		}
	}

	// Token: 0x060001FB RID: 507 RVA: 0x00006B60 File Offset: 0x00004D60
	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x3F0AB0", Offset = "0x3EF0B0", VA = "0x1803F0AB0")]
	public DefaultStatus_enter()
	{
	}
}
