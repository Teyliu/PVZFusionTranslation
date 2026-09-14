using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200007E RID: 126
[Token(Token = "0x200007E")]
public class Boss_headAttackOver : StateMachineBehaviour
{
	// Token: 0x06000200 RID: 512 RVA: 0x00006E38 File Offset: 0x00005038
	[Token(Token = "0x6000200")]
	[Address(RVA = "0x3A5440", Offset = "0x3A3A40", VA = "0x1803A5440", Slot = "6")]
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

	// Token: 0x06000201 RID: 513 RVA: 0x00006EB8 File Offset: 0x000050B8
	[Token(Token = "0x6000201")]
	[Address(RVA = "0x3A4B20", Offset = "0x3A3120", VA = "0x1803A4B20")]
	public Boss_headAttackOver()
	{
	}
}
