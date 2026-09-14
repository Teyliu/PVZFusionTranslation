using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000172 RID: 370
[Token(Token = "0x2000172")]
public class Bullet_melonCannon : Bullet_cannon
{
	// Token: 0x06000690 RID: 1680 RVA: 0x00021E94 File Offset: 0x00020094
	[Token(Token = "0x6000690")]
	[Address(RVA = "0x804FF0", Offset = "0x8035F0", VA = "0x180804FF0", Slot = "9")]
	public override void InitData()
	{
		base.InitData();
		float num = global::UnityEngine.Random.Range(-360f, 360f);
		Collider2D col = this.col;
		this.rotateSpeed = num;
		int num2 = 0;
		col.enabled = num2 != 0;
	}

	// Token: 0x06000691 RID: 1681 RVA: 0x00021ED4 File Offset: 0x000200D4
	[Token(Token = "0x6000691")]
	[Address(RVA = "0x805040", Offset = "0x803640", VA = "0x180805040", Slot = "12")]
	protected override void Update()
	{
		base.Update();
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num).GetChild(1);
		float deltaTime = Time.deltaTime;
		int num2 = 0;
		int num3 = 0;
		child.Rotate((float)num3, (float)num2, deltaTime);
	}

	// Token: 0x06000692 RID: 1682 RVA: 0x00021F20 File Offset: 0x00020120
	[Token(Token = "0x6000692")]
	[Address(RVA = "0x6E2090", Offset = "0x6E0690", VA = "0x1806E2090")]
	public Bullet_melonCannon()
	{
	}

	// Token: 0x0400038A RID: 906
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x400038A")]
	private float rotateSpeed;
}
