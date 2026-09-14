using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200007D RID: 125
[Token(Token = "0x200007D")]
public class State_scaredyPotato : StateMachineBehaviour
{
	// Token: 0x0600020D RID: 525 RVA: 0x00006FB4 File Offset: 0x000051B4
	[Token(Token = "0x600020D")]
	[Address(RVA = "0x3FD840", Offset = "0x3FBE40", VA = "0x1803FD840", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		Transform transform = animator.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		int num2 = 0;
		GameObject gameObject = child.GetChild(num2).gameObject;
		int num3 = 0;
		gameObject.SetActive(num3 != 0);
		Transform transform2 = animator.transform;
		int num4 = 0;
		transform2.GetChild(num4).GetChild(1).gameObject.SetActive(true);
	}

	// Token: 0x0600020E RID: 526 RVA: 0x0000701C File Offset: 0x0000521C
	[Token(Token = "0x600020E")]
	[Address(RVA = "0x3FD910", Offset = "0x3FBF10", VA = "0x1803FD910", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		Transform transform = animator.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		int num2 = 0;
		child.GetChild(num2).gameObject.SetActive(true);
		Transform transform2 = animator.transform;
		int num3 = 0;
		GameObject gameObject = transform2.GetChild(num3).GetChild(1).gameObject;
		int num4 = 0;
		gameObject.SetActive(num4 != 0);
	}

	// Token: 0x0600020F RID: 527 RVA: 0x00007084 File Offset: 0x00005284
	[Token(Token = "0x600020F")]
	[Address(RVA = "0x3F0AB0", Offset = "0x3EF0B0", VA = "0x1803F0AB0")]
	public State_scaredyPotato()
	{
	}
}
