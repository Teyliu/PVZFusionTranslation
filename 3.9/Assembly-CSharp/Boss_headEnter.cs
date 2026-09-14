using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000084 RID: 132
[Token(Token = "0x2000084")]
public class Boss_headEnter : StateMachineBehaviour
{
	// Token: 0x0600021D RID: 541 RVA: 0x000072A0 File Offset: 0x000054A0
	[Token(Token = "0x600021D")]
	[Address(RVA = "0x3F1500", Offset = "0x3EFB00", VA = "0x1803F1500", Slot = "6")]
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

	// Token: 0x0600021E RID: 542 RVA: 0x000072F8 File Offset: 0x000054F8
	[Token(Token = "0x600021E")]
	[Address(RVA = "0x3F0AB0", Offset = "0x3EF0B0", VA = "0x1803F0AB0")]
	public Boss_headEnter()
	{
	}
}
