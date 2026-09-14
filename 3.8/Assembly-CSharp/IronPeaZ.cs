using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000688 RID: 1672
[Token(Token = "0x2000688")]
public class IronPeaZ : PeaShooterZ
{
	// Token: 0x06002034 RID: 8244 RVA: 0x000AA948 File Offset: 0x000A8B48
	[Token(Token = "0x6002034")]
	[Address(RVA = "0x552820", Offset = "0x550E20", VA = "0x180552820", Slot = "76")]
	protected override int GetBulletDamage()
	{
		return base.GetBulletDamage();
	}

	// Token: 0x06002035 RID: 8245 RVA: 0x000AA95C File Offset: 0x000A8B5C
	[Token(Token = "0x6002035")]
	[Address(RVA = "0x3ADAB0", Offset = "0x3AC0B0", VA = "0x1803ADAB0", Slot = "75")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_ironPea;
	}

	// Token: 0x06002036 RID: 8246 RVA: 0x000AA96C File Offset: 0x000A8B6C
	[Token(Token = "0x6002036")]
	[Address(RVA = "0x552840", Offset = "0x550E40", VA = "0x180552840", Slot = "33")]
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

	// Token: 0x06002037 RID: 8247 RVA: 0x000AA9B4 File Offset: 0x000A8BB4
	[Token(Token = "0x6002037")]
	[Address(RVA = "0x539090", Offset = "0x537690", VA = "0x180539090")]
	public IronPeaZ()
	{
	}
}
