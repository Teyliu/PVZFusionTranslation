using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000073 RID: 115
[Token(Token = "0x2000073")]
public class FootballDrownShoot : StateMachineBehaviour
{
	// Token: 0x060001E5 RID: 485 RVA: 0x000068D8 File Offset: 0x00004AD8
	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x3A9D10", Offset = "0x3A8310", VA = "0x1803A9D10", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		Zombie component = animator.GetComponent<Zombie>();
		if (component.theStatus != ZombieStatus.Dying)
		{
			ulong num;
			if (Board.Instance.enermyCountDic.TryGetValue((uint)218, num) && !component.beforeDying && !component.isMindControlled)
			{
				animator.Play("throw");
			}
			return;
		}
		animator.SetTrigger("GoDie");
	}

	// Token: 0x060001E6 RID: 486 RVA: 0x00006940 File Offset: 0x00004B40
	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x3A4B20", Offset = "0x3A3120", VA = "0x1803A4B20")]
	public FootballDrownShoot()
	{
	}
}
