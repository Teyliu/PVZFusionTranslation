using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200019C RID: 412
[Token(Token = "0x200019C")]
public class Bullet_smallGoldCannon : Bullet
{
	// Token: 0x06000733 RID: 1843 RVA: 0x000252D4 File Offset: 0x000234D4
	[Token(Token = "0x6000733")]
	[Address(RVA = "0x7E0650", Offset = "0x7DEC50", VA = "0x1807E0650", Slot = "8")]
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

	// Token: 0x06000734 RID: 1844 RVA: 0x00025320 File Offset: 0x00023520
	[Token(Token = "0x6000734")]
	[Address(RVA = "0x7E04F0", Offset = "0x7DEAF0", VA = "0x1807E04F0", Slot = "18")]
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

	// Token: 0x06000735 RID: 1845 RVA: 0x0002537C File Offset: 0x0002357C
	[Token(Token = "0x6000735")]
	[Address(RVA = "0x7E0360", Offset = "0x7DE960", VA = "0x1807E0360", Slot = "16")]
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

	// Token: 0x06000736 RID: 1846 RVA: 0x000253E0 File Offset: 0x000235E0
	[Token(Token = "0x6000736")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_smallGoldCannon()
	{
	}
}
