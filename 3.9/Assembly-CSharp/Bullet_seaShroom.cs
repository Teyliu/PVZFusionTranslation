using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000195 RID: 405
[Token(Token = "0x2000195")]
public class Bullet_seaShroom : Bullet_squash
{
	// Token: 0x0600070A RID: 1802 RVA: 0x00023E18 File Offset: 0x00022018
	[Token(Token = "0x600070A")]
	[Address(RVA = "0x6E4FB0", Offset = "0x6E35B0", VA = "0x1806E4FB0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		this.spriteObject = child;
		throw new NullReferenceException();
	}

	// Token: 0x0600070B RID: 1803 RVA: 0x00023E48 File Offset: 0x00022048
	[Token(Token = "0x600070B")]
	[Address(RVA = "0x80B830", Offset = "0x809E30", VA = "0x18080B830", Slot = "13")]
	public override void JumpLand()
	{
		GameAPP.PlaySound((SoundType)((uint)24), 0.5f, 1f);
		Transform transform = base.transform;
		Vector2 oneVector = Vector2.oneVector;
		Plant from = this.from;
		int num = 0;
		if (!(from != num) || this.from != 0)
		{
		}
		base.Die();
	}

	// Token: 0x0600070C RID: 1804 RVA: 0x00023EA0 File Offset: 0x000220A0
	[Token(Token = "0x600070C")]
	[Address(RVA = "0x80B790", Offset = "0x809D90", VA = "0x18080B790", Slot = "15")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		Vector2 velocity = this.velocity;
		int num = 0;
		if (velocity <= num)
		{
			Transform transform = this.spriteObject;
			float fixedDeltaTime = Time.fixedDeltaTime;
		}
		Transform transform2 = this.spriteObject;
		float num2 = Time.fixedDeltaTime * -300f;
		int num3 = 0;
		int num4 = 0;
		transform2.Rotate((float)num4, (float)num3, num2);
	}

	// Token: 0x0600070D RID: 1805 RVA: 0x00023F04 File Offset: 0x00022104
	[Token(Token = "0x600070D")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_seaShroom()
	{
	}

	// Token: 0x04000394 RID: 916
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000394")]
	private Transform spriteObject;
}
