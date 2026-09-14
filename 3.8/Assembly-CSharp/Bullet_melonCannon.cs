using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200016C RID: 364
[Token(Token = "0x200016C")]
public class Bullet_melonCannon : Bullet_cannon
{
	// Token: 0x06000685 RID: 1669 RVA: 0x000224E0 File Offset: 0x000206E0
	[Token(Token = "0x6000685")]
	[Address(RVA = "0x6C9F70", Offset = "0x6C8570", VA = "0x1806C9F70", Slot = "8")]
	public override void InitData()
	{
		base.InitData();
		GameObject gameObject = this.shadow.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
		Collider2D col = this.col;
		int num2 = 0;
		col.enabled = num2 != 0;
		float num3 = global::UnityEngine.Random.Range(-360f, 360f);
		Collider2D col2 = this.col;
		this.rotateSpeed = num3;
		int num4 = 0;
		col2.enabled = num4 != 0;
	}

	// Token: 0x06000686 RID: 1670 RVA: 0x0002254C File Offset: 0x0002074C
	[Token(Token = "0x6000686")]
	[Address(RVA = "0x6CA000", Offset = "0x6C8600", VA = "0x1806CA000", Slot = "11")]
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

	// Token: 0x06000687 RID: 1671 RVA: 0x00022598 File Offset: 0x00020798
	[Token(Token = "0x6000687")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_melonCannon()
	{
	}

	// Token: 0x04000381 RID: 897
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000381")]
	private float rotateSpeed;
}
