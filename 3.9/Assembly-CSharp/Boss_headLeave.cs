using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000085 RID: 133
[Token(Token = "0x2000085")]
public class Boss_headLeave : StateMachineBehaviour
{
	// Token: 0x0600021F RID: 543 RVA: 0x0000730C File Offset: 0x0000550C
	[Token(Token = "0x600021F")]
	[Address(RVA = "0x3F15D0", Offset = "0x3EFBD0", VA = "0x1803F15D0", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		ZombieBoss component = animator.GetComponent<ZombieBoss>();
		Collider2D col = component.col;
		component.bossStatus = (ZombieBoss.BossStatus)((ulong)7L);
		component.theStatus = (ZombieStatus)((ulong)21L);
		int num = 0;
		col.enabled = num != 0;
		bool flag = component.RemoveBuff((EffectType)((uint)2));
		bool flag2 = component.RemoveBuff((EffectType)((uint)10));
	}

	// Token: 0x06000220 RID: 544 RVA: 0x00007360 File Offset: 0x00005560
	[Token(Token = "0x6000220")]
	[Address(RVA = "0x3F1670", Offset = "0x3EFC70", VA = "0x1803F1670", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		ZombieBoss component = animator.GetComponent<ZombieBoss>();
		component.bossStatus = (ZombieBoss.BossStatus)((ulong)1L);
		component.Skill();
	}

	// Token: 0x06000221 RID: 545 RVA: 0x0000738C File Offset: 0x0000558C
	[Token(Token = "0x6000221")]
	[Address(RVA = "0x3F0AB0", Offset = "0x3EF0B0", VA = "0x1803F0AB0")]
	public Boss_headLeave()
	{
	}
}
