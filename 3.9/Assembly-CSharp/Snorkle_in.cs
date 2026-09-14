using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200007F RID: 127
[Token(Token = "0x200007F")]
public class Snorkle_in : StateMachineBehaviour
{
	// Token: 0x06000213 RID: 531 RVA: 0x000070F4 File Offset: 0x000052F4
	[Token(Token = "0x6000213")]
	[Address(RVA = "0x3FD220", Offset = "0x3FB820", VA = "0x1803FD220", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		animator.GetComponent<Zombie>().theStatus = (ZombieStatus)((ulong)7L);
	}

	// Token: 0x06000214 RID: 532 RVA: 0x00007118 File Offset: 0x00005318
	[Token(Token = "0x6000214")]
	[Address(RVA = "0x3F0AB0", Offset = "0x3EF0B0", VA = "0x1803F0AB0")]
	public Snorkle_in()
	{
	}
}
