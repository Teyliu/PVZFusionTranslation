using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000080 RID: 128
[Token(Token = "0x2000080")]
public class Snorkle_out : StateMachineBehaviour
{
	// Token: 0x06000215 RID: 533 RVA: 0x0000712C File Offset: 0x0000532C
	[Token(Token = "0x6000215")]
	[Address(RVA = "0x3FD280", Offset = "0x3FB880", VA = "0x1803FD280", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		animator.GetComponent<Zombie>().theStatus = (ZombieStatus)((ulong)0L);
	}

	// Token: 0x06000216 RID: 534 RVA: 0x00007150 File Offset: 0x00005350
	[Token(Token = "0x6000216")]
	[Address(RVA = "0x3F0AB0", Offset = "0x3EF0B0", VA = "0x1803F0AB0")]
	public Snorkle_out()
	{
	}
}
