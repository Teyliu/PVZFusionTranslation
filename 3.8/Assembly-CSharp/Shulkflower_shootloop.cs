using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000079 RID: 121
[Token(Token = "0x2000079")]
public class Shulkflower_shootloop : StateMachineBehaviour
{
	// Token: 0x060001F5 RID: 501 RVA: 0x00006CC4 File Offset: 0x00004EC4
	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x3B0EA0", Offset = "0x3AF4A0", VA = "0x1803B0EA0", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		animator.GetComponent<Plant>().theStatus = (PlantStatus)((ulong)10L);
	}

	// Token: 0x060001F6 RID: 502 RVA: 0x00006CE8 File Offset: 0x00004EE8
	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x3B0F00", Offset = "0x3AF500", VA = "0x1803B0F00", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		animator.GetComponent<Plant>().theStatus = (PlantStatus)((ulong)0L);
	}

	// Token: 0x060001F7 RID: 503 RVA: 0x00006D0C File Offset: 0x00004F0C
	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x3A4B20", Offset = "0x3A3120", VA = "0x1803A4B20")]
	public Shulkflower_shootloop()
	{
	}
}
