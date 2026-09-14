using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000077 RID: 119
[Token(Token = "0x2000077")]
public class FootballDrownShoot : StateMachineBehaviour
{
	// Token: 0x060001FC RID: 508 RVA: 0x00006B74 File Offset: 0x00004D74
	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x3F5B10", Offset = "0x3F4110", VA = "0x1803F5B10", Slot = "6")]
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

	// Token: 0x060001FD RID: 509 RVA: 0x00006BDC File Offset: 0x00004DDC
	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x3F0AB0", Offset = "0x3EF0B0", VA = "0x1803F0AB0")]
	public FootballDrownShoot()
	{
	}
}
