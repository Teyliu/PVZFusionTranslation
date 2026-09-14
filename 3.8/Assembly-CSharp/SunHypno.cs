using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004B5 RID: 1205
[Token(Token = "0x20004B5")]
public class SunHypno : Producer
{
	// Token: 0x060016BD RID: 5821 RVA: 0x0007D484 File Offset: 0x0007B684
	[Token(Token = "0x60016BD")]
	[Address(RVA = "0x4AA8D0", Offset = "0x4A8ED0", VA = "0x1804AA8D0", Slot = "52")]
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

	// Token: 0x060016BE RID: 5822 RVA: 0x0007D4EC File Offset: 0x0007B6EC
	[Token(Token = "0x60016BE")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public SunHypno()
	{
	}

	// Token: 0x04000D9D RID: 3485
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000D9D")]
	public GameObject jumpSunPrefab;
}
