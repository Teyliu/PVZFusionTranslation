using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200007B RID: 123
[Token(Token = "0x200007B")]
public class Snorkle_out : StateMachineBehaviour
{
	// Token: 0x060001FA RID: 506 RVA: 0x00006D58 File Offset: 0x00004F58
	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x3B0FC0", Offset = "0x3AF5C0", VA = "0x1803B0FC0", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		animator.GetComponent<Zombie>().theStatus = (ZombieStatus)((ulong)0L);
	}

	// Token: 0x060001FB RID: 507 RVA: 0x00006D7C File Offset: 0x00004F7C
	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x3A4B20", Offset = "0x3A3120", VA = "0x1803A4B20")]
	public Snorkle_out()
	{
	}
}
