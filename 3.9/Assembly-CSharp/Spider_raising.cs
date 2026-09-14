using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000081 RID: 129
[Token(Token = "0x2000081")]
public class Spider_raising : StateMachineBehaviour
{
	// Token: 0x06000217 RID: 535 RVA: 0x00007164 File Offset: 0x00005364
	[Token(Token = "0x6000217")]
	[Address(RVA = "0x3FD670", Offset = "0x3FBC70", VA = "0x1803FD670", Slot = "6")]
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

	// Token: 0x06000218 RID: 536 RVA: 0x000071CC File Offset: 0x000053CC
	[Token(Token = "0x6000218")]
	[Address(RVA = "0x3F0AB0", Offset = "0x3EF0B0", VA = "0x1803F0AB0")]
	public Spider_raising()
	{
	}
}
