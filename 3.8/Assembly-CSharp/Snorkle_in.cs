using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200007A RID: 122
[Token(Token = "0x200007A")]
public class Snorkle_in : StateMachineBehaviour
{
	// Token: 0x060001F8 RID: 504 RVA: 0x00006D20 File Offset: 0x00004F20
	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x3B0F60", Offset = "0x3AF560", VA = "0x1803B0F60", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		animator.GetComponent<Zombie>().theStatus = (ZombieStatus)((ulong)7L);
	}

	// Token: 0x060001F9 RID: 505 RVA: 0x00006D44 File Offset: 0x00004F44
	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x3A4B20", Offset = "0x3A3120", VA = "0x1803A4B20")]
	public Snorkle_in()
	{
	}
}
