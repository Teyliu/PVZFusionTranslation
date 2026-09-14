using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000087 RID: 135
[Token(Token = "0x2000087")]
public class Boss_rv : StateMachineBehaviour
{
	// Token: 0x06000224 RID: 548 RVA: 0x000073CC File Offset: 0x000055CC
	[Token(Token = "0x6000224")]
	[Address(RVA = "0x3F1750", Offset = "0x3EFD50", VA = "0x1803F1750", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		animator.GetComponent<ZombieBoss>().animRV.gameObject.SetActive(true);
	}

	// Token: 0x06000225 RID: 549 RVA: 0x000073F8 File Offset: 0x000055F8
	[Token(Token = "0x6000225")]
	[Address(RVA = "0x3F17C0", Offset = "0x3EFDC0", VA = "0x1803F17C0", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		GameObject gameObject = animator.GetComponent<ZombieBoss>().animRV.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
	}

	// Token: 0x06000226 RID: 550 RVA: 0x00007428 File Offset: 0x00005628
	[Token(Token = "0x6000226")]
	[Address(RVA = "0x3F0AB0", Offset = "0x3EF0B0", VA = "0x1803F0AB0")]
	public Boss_rv()
	{
	}
}
