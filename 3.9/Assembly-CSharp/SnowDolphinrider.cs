using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006FC RID: 1788
[Token(Token = "0x20006FC")]
public class SnowDolphinrider : DolphinriderZ
{
	// Token: 0x06002323 RID: 8995 RVA: 0x000B7AA0 File Offset: 0x000B5CA0
	[Token(Token = "0x6002323")]
	[Address(RVA = "0x5D13E0", Offset = "0x5CF9E0", VA = "0x1805D13E0", Slot = "76")]
	public override void JumpOver()
	{
		base.JumpOver();
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		Transform transform = base.transform;
		this.towards = (Towards)((ulong)1L);
	}

	// Token: 0x06002324 RID: 8996 RVA: 0x000B7ADC File Offset: 0x000B5CDC
	[Token(Token = "0x6002324")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "77")]
	protected override void JumpFail()
	{
	}

	// Token: 0x06002325 RID: 8997 RVA: 0x000B7AEC File Offset: 0x000B5CEC
	[Token(Token = "0x6002325")]
	[Address(RVA = "0x5D12E0", Offset = "0x5CF8E0", VA = "0x1805D12E0", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[59];
		component.sprite = sprite;
		Transform transform = arm.transform;
	}

	// Token: 0x06002326 RID: 8998 RVA: 0x000B7B24 File Offset: 0x000B5D24
	[Token(Token = "0x6002326")]
	[Address(RVA = "0x5C7DB0", Offset = "0x5C63B0", VA = "0x1805C7DB0")]
	public SnowDolphinrider()
	{
	}
}
