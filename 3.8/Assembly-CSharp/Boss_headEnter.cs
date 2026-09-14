using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200007F RID: 127
[Token(Token = "0x200007F")]
public class Boss_headEnter : StateMachineBehaviour
{
	// Token: 0x06000202 RID: 514 RVA: 0x00006ECC File Offset: 0x000050CC
	[Token(Token = "0x6000202")]
	[Address(RVA = "0x3A5570", Offset = "0x3A3B70", VA = "0x1803A5570", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		ZombieBoss component = animator.GetComponent<ZombieBoss>();
		component.bossStatus = (ZombieBoss.BossStatus)((ulong)6L);
		component.theStatus = (ZombieStatus)((ulong)0L);
		component.ballCountDown = 3f;
		Collider2D col = component.col;
		int num = 0;
		if (col != num)
		{
			component.col.enabled = true;
			return;
		}
	}

	// Token: 0x06000203 RID: 515 RVA: 0x00006F24 File Offset: 0x00005124
	[Token(Token = "0x6000203")]
	[Address(RVA = "0x3A4B20", Offset = "0x3A3120", VA = "0x1803A4B20")]
	public Boss_headEnter()
	{
	}
}
