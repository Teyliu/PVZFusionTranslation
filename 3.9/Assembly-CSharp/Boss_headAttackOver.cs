using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000083 RID: 131
[Token(Token = "0x2000083")]
public class Boss_headAttackOver : StateMachineBehaviour
{
	// Token: 0x0600021B RID: 539 RVA: 0x0000720C File Offset: 0x0000540C
	[Token(Token = "0x600021B")]
	[Address(RVA = "0x3F13D0", Offset = "0x3EF9D0", VA = "0x1803F13D0", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		ZombieBoss component = animator.GetComponent<ZombieBoss>();
		Animator anim = component.anim;
		component.spawnCount = component;
		anim.SetTrigger("head_leave");
		Transform transform = component.eyes.transform;
		int num = 0;
		GameObject gameObject = transform.GetChild(num).gameObject;
		int num2 = 0;
		gameObject.SetActive(num2 != 0);
		GameObject gameObject2 = component.eyes.transform.GetChild(1).gameObject;
		int num3 = 0;
		gameObject2.SetActive(num3 != 0);
	}

	// Token: 0x0600021C RID: 540 RVA: 0x0000728C File Offset: 0x0000548C
	[Token(Token = "0x600021C")]
	[Address(RVA = "0x3F0AB0", Offset = "0x3EF0B0", VA = "0x1803F0AB0")]
	public Boss_headAttackOver()
	{
	}
}
