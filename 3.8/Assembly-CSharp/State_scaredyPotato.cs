using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000078 RID: 120
[Token(Token = "0x2000078")]
public class State_scaredyPotato : StateMachineBehaviour
{
	// Token: 0x060001F2 RID: 498 RVA: 0x00006BE0 File Offset: 0x00004DE0
	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x3B1580", Offset = "0x3AFB80", VA = "0x1803B1580", Slot = "4")]
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

	// Token: 0x060001F3 RID: 499 RVA: 0x00006C48 File Offset: 0x00004E48
	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x3B1650", Offset = "0x3AFC50", VA = "0x1803B1650", Slot = "6")]
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

	// Token: 0x060001F4 RID: 500 RVA: 0x00006CB0 File Offset: 0x00004EB0
	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x3A4B20", Offset = "0x3A3120", VA = "0x1803A4B20")]
	public State_scaredyPotato()
	{
	}
}
