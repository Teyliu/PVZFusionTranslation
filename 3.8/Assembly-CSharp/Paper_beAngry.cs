using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000076 RID: 118
[Token(Token = "0x2000076")]
public class Paper_beAngry : StateMachineBehaviour
{
	// Token: 0x060001EE RID: 494 RVA: 0x00006B60 File Offset: 0x00004D60
	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x3AF620", Offset = "0x3ADC20", VA = "0x1803AF620", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		animator.GetComponent<Zombie>().ChangeStatus((ZombieStatus)((uint)6));
	}

	// Token: 0x060001EF RID: 495 RVA: 0x00006B84 File Offset: 0x00004D84
	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x3A4B20", Offset = "0x3A3120", VA = "0x1803A4B20")]
	public Paper_beAngry()
	{
	}
}
