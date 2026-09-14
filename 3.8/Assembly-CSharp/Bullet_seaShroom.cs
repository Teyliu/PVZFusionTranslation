using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200018E RID: 398
[Token(Token = "0x200018E")]
public class Bullet_seaShroom : Bullet_squash
{
	// Token: 0x060006FD RID: 1789 RVA: 0x000244D8 File Offset: 0x000226D8
	[Token(Token = "0x60006FD")]
	[Address(RVA = "0x6BA0C0", Offset = "0x6B86C0", VA = "0x1806BA0C0", Slot = "9")]
	protected override void Awake()
	{
		base.Awake();
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		this.spriteObject = child;
		throw new NullReferenceException();
	}

	// Token: 0x060006FE RID: 1790 RVA: 0x00024508 File Offset: 0x00022708
	[Token(Token = "0x60006FE")]
	[Address(RVA = "0x7DE0C0", Offset = "0x7DC6C0", VA = "0x1807DE0C0", Slot = "12")]
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

	// Token: 0x060006FF RID: 1791 RVA: 0x00024560 File Offset: 0x00022760
	[Token(Token = "0x60006FF")]
	[Address(RVA = "0x7DE020", Offset = "0x7DC620", VA = "0x1807DE020", Slot = "16")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		float vx = this.Vx;
		int num = 0;
		if (vx <= (float)num)
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

	// Token: 0x06000700 RID: 1792 RVA: 0x000245C4 File Offset: 0x000227C4
	[Token(Token = "0x6000700")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_seaShroom()
	{
	}

	// Token: 0x0400038B RID: 907
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x400038B")]
	private Transform spriteObject;
}
