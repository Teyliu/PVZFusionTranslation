using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000082 RID: 130
[Token(Token = "0x2000082")]
public class Boss_rv : StateMachineBehaviour
{
	// Token: 0x06000209 RID: 521 RVA: 0x00006FF8 File Offset: 0x000051F8
	[Token(Token = "0x6000209")]
	[Address(RVA = "0x3A57C0", Offset = "0x3A3DC0", VA = "0x1803A57C0", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		animator.GetComponent<ZombieBoss>().animRV.gameObject.SetActive(true);
	}

	// Token: 0x0600020A RID: 522 RVA: 0x00007024 File Offset: 0x00005224
	[Token(Token = "0x600020A")]
	[Address(RVA = "0x3A5830", Offset = "0x3A3E30", VA = "0x1803A5830", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		GameObject gameObject = animator.GetComponent<ZombieBoss>().animRV.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
	}

	// Token: 0x0600020B RID: 523 RVA: 0x00007054 File Offset: 0x00005254
	[Token(Token = "0x600020B")]
	[Address(RVA = "0x3A4B20", Offset = "0x3A3120", VA = "0x1803A4B20")]
	public Boss_rv()
	{
	}
}
