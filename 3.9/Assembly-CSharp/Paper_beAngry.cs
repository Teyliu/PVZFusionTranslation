using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200007B RID: 123
[Token(Token = "0x200007B")]
public class Paper_beAngry : StateMachineBehaviour
{
	// Token: 0x06000209 RID: 521 RVA: 0x00006F34 File Offset: 0x00005134
	[Token(Token = "0x6000209")]
	[Address(RVA = "0x3FB8E0", Offset = "0x3F9EE0", VA = "0x1803FB8E0", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		animator.GetComponent<Zombie>().ChangeStatus((ZombieStatus)((uint)6));
	}

	// Token: 0x0600020A RID: 522 RVA: 0x00006F58 File Offset: 0x00005158
	[Token(Token = "0x600020A")]
	[Address(RVA = "0x3F0AB0", Offset = "0x3EF0B0", VA = "0x1803F0AB0")]
	public Paper_beAngry()
	{
	}
}
