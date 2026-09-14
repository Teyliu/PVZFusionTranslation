using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006BE RID: 1726
[Token(Token = "0x20006BE")]
public class IronPeaZ : PeaShooterZ
{
	// Token: 0x06002136 RID: 8502 RVA: 0x000AF270 File Offset: 0x000AD470
	[Token(Token = "0x6002136")]
	[Address(RVA = "0x5B63C0", Offset = "0x5B49C0", VA = "0x1805B63C0", Slot = "78")]
	protected override int GetBulletDamage()
	{
		return base.GetBulletDamage();
	}

	// Token: 0x06002137 RID: 8503 RVA: 0x000AF284 File Offset: 0x000AD484
	[Token(Token = "0x6002137")]
	[Address(RVA = "0x3F9920", Offset = "0x3F7F20", VA = "0x1803F9920", Slot = "77")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_ironPea;
	}

	// Token: 0x06002138 RID: 8504 RVA: 0x000AF294 File Offset: 0x000AD494
	[Token(Token = "0x6002138")]
	[Address(RVA = "0x5B63E0", Offset = "0x5B49E0", VA = "0x1805B63E0", Slot = "34")]
	protected override void LoseHeadEvent()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = Resources.Load<GameObject>("Items/Bucket");
		Board board = this.board;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = board.transform;
	}

	// Token: 0x06002139 RID: 8505 RVA: 0x000AF2DC File Offset: 0x000AD4DC
	[Token(Token = "0x6002139")]
	[Address(RVA = "0x59B660", Offset = "0x599C60", VA = "0x18059B660")]
	public IronPeaZ()
	{
	}
}
