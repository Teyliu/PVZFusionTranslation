using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000790 RID: 1936
[Token(Token = "0x2000790")]
public class GardenBoundary : MonoBehaviour
{
	// Token: 0x06002758 RID: 10072 RVA: 0x000D067C File Offset: 0x000CE87C
	[Token(Token = "0x6002758")]
	[Address(RVA = "0x63E7A0", Offset = "0x63CDA0", VA = "0x18063E7A0")]
	private void FixedUpdate()
	{
		if (this.playerIn)
		{
			float deltaTime = Time.deltaTime;
			GardenPlayer gardenPlayer = this.player;
			this.timer = deltaTime;
			float num = deltaTime * gardenPlayer.moveSpeed;
			Rigidbody2D rb = gardenPlayer.rb;
			return;
		}
	}

	// Token: 0x06002759 RID: 10073 RVA: 0x000D06C4 File Offset: 0x000CE8C4
	[Token(Token = "0x6002759")]
	[Address(RVA = "0x63E820", Offset = "0x63CE20", VA = "0x18063E820")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			ulong num;
			this.player = num;
			this.playerIn = true;
			this.timer = 0f;
			InGameText instance = InGameText.Instance;
		}
	}

	// Token: 0x0600275A RID: 10074 RVA: 0x000D0700 File Offset: 0x000CE900
	[Token(Token = "0x600275A")]
	[Address(RVA = "0x63E8F0", Offset = "0x63CEF0", VA = "0x18063E8F0")]
	private void OnTriggerExit2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			this.playerIn = false;
			this.player = (ulong)0L;
			this.timer = 0f;
		}
	}

	// Token: 0x0600275B RID: 10075 RVA: 0x000D0734 File Offset: 0x000CE934
	[Token(Token = "0x600275B")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public GardenBoundary()
	{
	}

	// Token: 0x0400149F RID: 5279
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400149F")]
	public GardenPlayer player;

	// Token: 0x040014A0 RID: 5280
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40014A0")]
	public Vector2 forceDirection;

	// Token: 0x040014A1 RID: 5281
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40014A1")]
	private bool playerIn;

	// Token: 0x040014A2 RID: 5282
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40014A2")]
	private float timer;
}
