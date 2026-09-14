using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000757 RID: 1879
[Token(Token = "0x2000757")]
public class GardenBoundary : MonoBehaviour
{
	// Token: 0x06002631 RID: 9777 RVA: 0x000CB5D8 File Offset: 0x000C97D8
	[Token(Token = "0x6002631")]
	[Address(RVA = "0x5DB8A0", Offset = "0x5D9EA0", VA = "0x1805DB8A0")]
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

	// Token: 0x06002632 RID: 9778 RVA: 0x000CB620 File Offset: 0x000C9820
	[Token(Token = "0x6002632")]
	[Address(RVA = "0x5DB920", Offset = "0x5D9F20", VA = "0x1805DB920")]
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
			int num2 = 0;
			instance.ShowText("前面的区域，以后再来探索吧", 3f, num2 != 0);
		}
	}

	// Token: 0x06002633 RID: 9779 RVA: 0x000CB670 File Offset: 0x000C9870
	[Token(Token = "0x6002633")]
	[Address(RVA = "0x5DB9E0", Offset = "0x5D9FE0", VA = "0x1805DB9E0")]
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

	// Token: 0x06002634 RID: 9780 RVA: 0x000CB6A4 File Offset: 0x000C98A4
	[Token(Token = "0x6002634")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public GardenBoundary()
	{
	}

	// Token: 0x040013C7 RID: 5063
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40013C7")]
	public GardenPlayer player;

	// Token: 0x040013C8 RID: 5064
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40013C8")]
	public Vector2 forceDirection;

	// Token: 0x040013C9 RID: 5065
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40013C9")]
	private bool playerIn;

	// Token: 0x040013CA RID: 5066
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40013CA")]
	private float timer;
}
