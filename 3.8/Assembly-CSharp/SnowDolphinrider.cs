using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006C4 RID: 1732
[Token(Token = "0x20006C4")]
public class SnowDolphinrider : DolphinriderZ
{
	// Token: 0x06002208 RID: 8712 RVA: 0x000B2CAC File Offset: 0x000B0EAC
	[Token(Token = "0x6002208")]
	[Address(RVA = "0x56D720", Offset = "0x56BD20", VA = "0x18056D720", Slot = "74")]
	public override void JumpOver()
	{
		base.JumpOver();
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		Transform transform = base.transform;
		this.towards = (Towards)((ulong)1L);
	}

	// Token: 0x06002209 RID: 8713 RVA: 0x000B2CE8 File Offset: 0x000B0EE8
	[Token(Token = "0x6002209")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "75")]
	protected override void JumpFail()
	{
	}

	// Token: 0x0600220A RID: 8714 RVA: 0x000B2CF8 File Offset: 0x000B0EF8
	[Token(Token = "0x600220A")]
	[Address(RVA = "0x56D620", Offset = "0x56BC20", VA = "0x18056D620", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[59];
		component.sprite = sprite;
		Transform transform = arm.transform;
	}

	// Token: 0x0600220B RID: 8715 RVA: 0x000B2D30 File Offset: 0x000B0F30
	[Token(Token = "0x600220B")]
	[Address(RVA = "0x564500", Offset = "0x562B00", VA = "0x180564500")]
	public SnowDolphinrider()
	{
	}
}
