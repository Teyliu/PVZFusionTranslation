using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200007C RID: 124
[Token(Token = "0x200007C")]
public class Spider_raising : StateMachineBehaviour
{
	// Token: 0x060001FC RID: 508 RVA: 0x00006D90 File Offset: 0x00004F90
	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x3B13B0", Offset = "0x3AF9B0", VA = "0x1803B13B0", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		Zombie component = animator.GetComponent<Zombie>();
		component.ChangeStatus((ZombieStatus)((uint)10));
		GameAPP.PlaySound(43, 0.5f, 1f);
		GameObject[] particlePrefab = GameAPP.particlePrefab;
		Transform axis = component.axis;
		GameObject gameObject = particlePrefab[34];
		Vector3 vector;
		float z = vector.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = component.board.transform;
	}

	// Token: 0x060001FD RID: 509 RVA: 0x00006DF8 File Offset: 0x00004FF8
	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x3A4B20", Offset = "0x3A3120", VA = "0x1803A4B20")]
	public Spider_raising()
	{
	}
}
