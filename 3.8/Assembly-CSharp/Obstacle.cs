using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006A8 RID: 1704
[Token(Token = "0x20006A8")]
public class Obstacle : MonoBehaviour
{
	// Token: 0x0600212D RID: 8493 RVA: 0x000AF3F4 File Offset: 0x000AD5F4
	[Token(Token = "0x600212D")]
	[Address(RVA = "0x562440", Offset = "0x560A40", VA = "0x180562440", Slot = "4")]
	protected virtual void Awake()
	{
		GameObject gameObject = base.gameObject;
		this.GetSpriteRenderers(gameObject);
	}

	// Token: 0x0600212E RID: 8494 RVA: 0x000AF410 File Offset: 0x000AD610
	[Token(Token = "0x600212E")]
	[Address(RVA = "0x562230", Offset = "0x560830", VA = "0x180562230", Slot = "5")]
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

	// Token: 0x0600212F RID: 8495 RVA: 0x000AF47C File Offset: 0x000AD67C
	[Token(Token = "0x600212F")]
	[Address(RVA = "0x562550", Offset = "0x560B50", VA = "0x180562550")]
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

	// Token: 0x06002130 RID: 8496 RVA: 0x000AF4E4 File Offset: 0x000AD6E4
	[Token(Token = "0x6002130")]
	[Address(RVA = "0x562480", Offset = "0x560A80", VA = "0x180562480")]
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

	// Token: 0x06002131 RID: 8497 RVA: 0x000AF53C File Offset: 0x000AD73C
	[Token(Token = "0x6002131")]
	[Address(RVA = "0x562480", Offset = "0x560A80", VA = "0x180562480")]
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

	// Token: 0x06002132 RID: 8498 RVA: 0x000AF594 File Offset: 0x000AD794
	[Token(Token = "0x6002132")]
	[Address(RVA = "0x5627E0", Offset = "0x560DE0", VA = "0x1805627E0")]
	protected void SetBrightness(float b)
	{
		GameMaterial.SetBrightness(this.spriteRenderers, b);
	}

	// Token: 0x06002133 RID: 8499 RVA: 0x000AF5B0 File Offset: 0x000AD7B0
	[Token(Token = "0x6002133")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "6")]
	public virtual void Die()
	{
	}

	// Token: 0x06002134 RID: 8500 RVA: 0x000AF5C0 File Offset: 0x000AD7C0
	[Token(Token = "0x6002134")]
	[Address(RVA = "0x5626B0", Offset = "0x560CB0", VA = "0x1805626B0")]
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

	// Token: 0x06002135 RID: 8501 RVA: 0x000AF5EC File Offset: 0x000AD7EC
	[Token(Token = "0x6002135")]
	[Address(RVA = "0x562840", Offset = "0x560E40", VA = "0x180562840")]
	public Obstacle()
	{
		List<SpriteRenderer> list = new List();
		this.spriteRenderers = list;
		base..ctor();
	}

	// Token: 0x040010F1 RID: 4337
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40010F1")]
	public Obstacle.ObstacleType obstacleType;

	// Token: 0x040010F2 RID: 4338
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40010F2")]
	public int theBallRow;

	// Token: 0x040010F3 RID: 4339
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40010F3")]
	protected float flashTime;

	// Token: 0x040010F4 RID: 4340
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40010F4")]
	private readonly List<SpriteRenderer> spriteRenderers;

	// Token: 0x020006A9 RID: 1705
	[Token(Token = "0x20006A9")]
	public enum ObstacleType
	{
		// Token: 0x040010F6 RID: 4342
		[Token(Token = "0x40010F6")]
		FireBall,
		// Token: 0x040010F7 RID: 4343
		[Token(Token = "0x40010F7")]
		IceBall,
		// Token: 0x040010F8 RID: 4344
		[Token(Token = "0x40010F8")]
		SilverZombie,
		// Token: 0x040010F9 RID: 4345
		[Token(Token = "0x40010F9")]
		GoldZombie,
		// Token: 0x040010FA RID: 4346
		[Token(Token = "0x40010FA")]
		BigWeapon
	}
}
