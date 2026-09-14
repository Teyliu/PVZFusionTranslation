using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200007E RID: 126
[Token(Token = "0x200007E")]
public class Shulkflower_shootloop : StateMachineBehaviour
{
	// Token: 0x06000210 RID: 528 RVA: 0x00007098 File Offset: 0x00005298
	[Token(Token = "0x6000210")]
	[Address(RVA = "0x3FD160", Offset = "0x3FB760", VA = "0x1803FD160", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		animator.GetComponent<Plant>().theStatus = (PlantStatus)((ulong)10L);
	}

	// Token: 0x06000211 RID: 529 RVA: 0x000070BC File Offset: 0x000052BC
	[Token(Token = "0x6000211")]
	[Address(RVA = "0x3FD1C0", Offset = "0x3FB7C0", VA = "0x1803FD1C0", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		animator.GetComponent<Plant>().theStatus = (PlantStatus)((ulong)0L);
	}

	// Token: 0x06000212 RID: 530 RVA: 0x000070E0 File Offset: 0x000052E0
	[Token(Token = "0x6000212")]
	[Address(RVA = "0x3F0AB0", Offset = "0x3EF0B0", VA = "0x1803F0AB0")]
	public Shulkflower_shootloop()
	{
	}
}
