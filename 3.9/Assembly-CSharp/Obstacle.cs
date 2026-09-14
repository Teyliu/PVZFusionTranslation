using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006DF RID: 1759
[Token(Token = "0x20006DF")]
public class Obstacle : MonoBehaviour
{
	// Token: 0x06002244 RID: 8772 RVA: 0x000B40A0 File Offset: 0x000B22A0
	[Token(Token = "0x6002244")]
	[Address(RVA = "0x5C5230", Offset = "0x5C3830", VA = "0x1805C5230", Slot = "4")]
	protected virtual void Awake()
	{
		GameObject gameObject = base.gameObject;
		this.GetSpriteRenderers(gameObject);
	}

	// Token: 0x06002245 RID: 8773 RVA: 0x000B40BC File Offset: 0x000B22BC
	[Token(Token = "0x6002245")]
	[Address(RVA = "0x5C5020", Offset = "0x5C3620", VA = "0x1805C5020", Slot = "5")]
	protected virtual void AddToList()
	{
		int num = 0;
		List<Obstacle> zombieBalls = Board.Instance.zombieBalls;
		Board instance = Board.Instance;
		Obstacle obstacle = instance.zombieBalls[num];
		int num2 = 0;
		if (!(obstacle == num2))
		{
			num++;
			Board instance2 = Board.Instance;
		}
		Board.Instance.zombieBalls[num] = this;
	}

	// Token: 0x06002246 RID: 8774 RVA: 0x000B4128 File Offset: 0x000B2328
	[Token(Token = "0x6002246")]
	[Address(RVA = "0x5C5340", Offset = "0x5C3940", VA = "0x1805C5340")]
	private void GetSpriteRenderers(GameObject obj)
	{
		int num = 0;
		if (obj.TryGetComponent<SpriteRenderer>(num))
		{
			List<SpriteRenderer> list = this.spriteRenderers;
			int num2 = list._size + 1;
			list._size = num2;
		}
		int childCount = obj.transform.childCount;
		if (num < childCount)
		{
			GameObject gameObject = obj.transform.GetChild(num).gameObject;
			this.GetSpriteRenderers(gameObject);
			num++;
		}
	}

	// Token: 0x06002247 RID: 8775 RVA: 0x000B4190 File Offset: 0x000B2390
	[Token(Token = "0x6002247")]
	[Address(RVA = "0x5C5270", Offset = "0x5C3870", VA = "0x1805C5270")]
	private void FixedUpdate()
	{
		float num = this.flashTime;
		int num2 = 0;
		if (num > (float)num2)
		{
			if (num > 0.2f || num > (float)num2)
			{
				float num3 = num * -30f;
				this.SetBrightness(num3);
			}
			float num4 = this.flashTime;
			this.flashTime = num4;
			if (num == (float)num2)
			{
				GameMaterial.SetBrightness(this.spriteRenderers, 1f);
			}
		}
	}

	// Token: 0x06002248 RID: 8776 RVA: 0x000B41E8 File Offset: 0x000B23E8
	[Token(Token = "0x6002248")]
	[Address(RVA = "0x5C5270", Offset = "0x5C3870", VA = "0x1805C5270")]
	private void FlashUpdate()
	{
		float num = this.flashTime;
		int num2 = 0;
		if (num > (float)num2)
		{
			if (num > 0.2f || num > (float)num2)
			{
				float num3 = num * -30f;
				this.SetBrightness(num3);
			}
			float num4 = this.flashTime;
			this.flashTime = num4;
			if (num == (float)num2)
			{
				GameMaterial.SetBrightness(this.spriteRenderers, 1f);
			}
		}
	}

	// Token: 0x06002249 RID: 8777 RVA: 0x000B4240 File Offset: 0x000B2440
	[Token(Token = "0x6002249")]
	[Address(RVA = "0x5C55D0", Offset = "0x5C3BD0", VA = "0x1805C55D0")]
	protected void SetBrightness(float b)
	{
		GameMaterial.SetBrightness(this.spriteRenderers, b);
	}

	// Token: 0x0600224A RID: 8778 RVA: 0x000B425C File Offset: 0x000B245C
	[Token(Token = "0x600224A")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "6")]
	public virtual void Die()
	{
	}

	// Token: 0x0600224B RID: 8779 RVA: 0x000B426C File Offset: 0x000B246C
	[Token(Token = "0x600224B")]
	[Address(RVA = "0x5C54A0", Offset = "0x5C3AA0", VA = "0x1805C54A0")]
	private void OnDestroy()
	{
		ulong num2;
		do
		{
			int num = 0;
			List<SpriteRenderer> list = this.spriteRenderers;
			bool flag;
			if (flag)
			{
				global::UnityEngine.Object.DestroyImmediate(num);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x0600224C RID: 8780 RVA: 0x000B4298 File Offset: 0x000B2498
	[Token(Token = "0x600224C")]
	[Address(RVA = "0x5C5630", Offset = "0x5C3C30", VA = "0x1805C5630")]
	public Obstacle()
	{
		List<SpriteRenderer> list = new List();
		this.spriteRenderers = list;
		base..ctor();
	}

	// Token: 0x040011BE RID: 4542
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40011BE")]
	public Obstacle.ObstacleType obstacleType;

	// Token: 0x040011BF RID: 4543
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40011BF")]
	public int theBallRow;

	// Token: 0x040011C0 RID: 4544
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40011C0")]
	protected float flashTime;

	// Token: 0x040011C1 RID: 4545
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40011C1")]
	private readonly List<SpriteRenderer> spriteRenderers;

	// Token: 0x020006E0 RID: 1760
	[Token(Token = "0x20006E0")]
	public enum ObstacleType
	{
		// Token: 0x040011C3 RID: 4547
		[Token(Token = "0x40011C3")]
		FireBall,
		// Token: 0x040011C4 RID: 4548
		[Token(Token = "0x40011C4")]
		IceBall,
		// Token: 0x040011C5 RID: 4549
		[Token(Token = "0x40011C5")]
		SilverZombie,
		// Token: 0x040011C6 RID: 4550
		[Token(Token = "0x40011C6")]
		GoldZombie,
		// Token: 0x040011C7 RID: 4551
		[Token(Token = "0x40011C7")]
		BigWeapon
	}
}
