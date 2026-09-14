using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000072 RID: 114
[Token(Token = "0x2000072")]
public class DefaultStatus_enter : StateMachineBehaviour
{
	// Token: 0x060001E3 RID: 483 RVA: 0x00006898 File Offset: 0x00004A98
	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x3A7850", Offset = "0x3A5E50", VA = "0x1803A7850", Slot = "4")]
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

	// Token: 0x060001E4 RID: 484 RVA: 0x000068C4 File Offset: 0x00004AC4
	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x3A4B20", Offset = "0x3A3120", VA = "0x1803A4B20")]
	public DefaultStatus_enter()
	{
	}
}
