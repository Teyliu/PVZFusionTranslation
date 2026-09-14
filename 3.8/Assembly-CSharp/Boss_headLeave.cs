using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000080 RID: 128
[Token(Token = "0x2000080")]
public class Boss_headLeave : StateMachineBehaviour
{
	// Token: 0x06000204 RID: 516 RVA: 0x00006F38 File Offset: 0x00005138
	[Token(Token = "0x6000204")]
	[Address(RVA = "0x3A5640", Offset = "0x3A3C40", VA = "0x1803A5640", Slot = "4")]
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

	// Token: 0x06000205 RID: 517 RVA: 0x00006F8C File Offset: 0x0000518C
	[Token(Token = "0x6000205")]
	[Address(RVA = "0x3A56E0", Offset = "0x3A3CE0", VA = "0x1803A56E0", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		ZombieBoss component = animator.GetComponent<ZombieBoss>();
		component.bossStatus = (ZombieBoss.BossStatus)((ulong)1L);
		component.Skill();
	}

	// Token: 0x06000206 RID: 518 RVA: 0x00006FB8 File Offset: 0x000051B8
	[Token(Token = "0x6000206")]
	[Address(RVA = "0x3A4B20", Offset = "0x3A3120", VA = "0x1803A4B20")]
	public Boss_headLeave()
	{
	}
}
