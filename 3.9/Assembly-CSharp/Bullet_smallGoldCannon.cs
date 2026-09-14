using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001A3 RID: 419
[Token(Token = "0x20001A3")]
public class Bullet_smallGoldCannon : Bullet
{
	// Token: 0x06000740 RID: 1856 RVA: 0x00024C0C File Offset: 0x00022E0C
	[Token(Token = "0x6000740")]
	[Address(RVA = "0x80DD90", Offset = "0x80C390", VA = "0x18080DD90", Slot = "9")]
	public override void InitData()
	{
		base.InitData();
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		child.rotation = identityQuaternion;
		Collider2D col = this.col;
		int num2 = 0;
		col.enabled = num2 != 0;
	}

	// Token: 0x06000741 RID: 1857 RVA: 0x00024C58 File Offset: 0x00022E58
	[Token(Token = "0x6000741")]
	[Address(RVA = "0x80DC30", Offset = "0x80C230", VA = "0x18080DC30", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		PlantType fromType = this.fromType;
		Transform transform2 = base.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		ScreenShake.TriggerShake(0.15f);
		GameAPP.PlaySound(41, 0.5f, 1f);
		base.Die();
	}

	// Token: 0x06000742 RID: 1858 RVA: 0x00024CB4 File Offset: 0x00022EB4
	[Token(Token = "0x6000742")]
	[Address(RVA = "0x80DAA0", Offset = "0x80C0A0", VA = "0x18080DAA0", Slot = "15")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		Vector2 velocity = this.rb.velocity;
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		Transform transform2 = base.transform;
		int num2 = 0;
		Transform child2 = transform2.GetChild(num2);
		float num4;
		float num3 = num4 * 0.017453292f;
		float deltaTime = Time.deltaTime;
	}

	// Token: 0x06000743 RID: 1859 RVA: 0x00024D18 File Offset: 0x00022F18
	[Token(Token = "0x6000743")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_smallGoldCannon()
	{
	}
}
