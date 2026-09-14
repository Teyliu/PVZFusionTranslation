using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004D9 RID: 1241
[Token(Token = "0x20004D9")]
public class SunHypno : Producer
{
	// Token: 0x06001766 RID: 5990 RVA: 0x000800DC File Offset: 0x0007E2DC
	[Token(Token = "0x6001766")]
	[Address(RVA = "0x516500", Offset = "0x514B00", VA = "0x180516500", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Transform axis = this.axis;
		GameObject gameObject = this.jumpSunPrefab;
		Vector3 vector;
		float z = vector.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		JumpSun component = gameObject2.GetComponent<JumpSun>();
		Board board = this.board;
		component.board = board;
		int attackDamage = this.attackDamage;
		component.damage = attackDamage;
	}

	// Token: 0x06001767 RID: 5991 RVA: 0x00080144 File Offset: 0x0007E344
	[Token(Token = "0x6001767")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public SunHypno()
	{
	}

	// Token: 0x04000E36 RID: 3638
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000E36")]
	public GameObject jumpSunPrefab;
}
