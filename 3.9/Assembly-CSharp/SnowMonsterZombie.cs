using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000700 RID: 1792
[Token(Token = "0x2000700")]
public class SnowMonsterZombie : Zombie
{
	// Token: 0x06002340 RID: 9024 RVA: 0x000B8278 File Offset: 0x000B6478
	[Token(Token = "0x6002340")]
	[Address(RVA = "0x5D32C0", Offset = "0x5D18C0", VA = "0x1805D32C0", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		this.anim.SetTrigger("jump");
		base.ChangeStatus((ZombieStatus)((uint)31));
		GameObject gameObject = this.axis.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
		Action action = new Action(this.LandEvent);
		this.defaultAction = action;
	}

	// Token: 0x06002341 RID: 9025 RVA: 0x000B82D4 File Offset: 0x000B64D4
	[Token(Token = "0x6002341")]
	[Address(RVA = "0x5D3240", Offset = "0x5D1840", VA = "0x1805D3240")]
	private void LandEvent()
	{
		this.axis.gameObject.SetActive(true);
	}

	// Token: 0x06002342 RID: 9026 RVA: 0x000B82F8 File Offset: 0x000B64F8
	[Token(Token = "0x6002342")]
	[Address(RVA = "0x5D32B0", Offset = "0x5D18B0", VA = "0x1805D32B0", Slot = "22")]
	protected override void PositionUpdate()
	{
		base.PositionUpdate();
	}

	// Token: 0x06002343 RID: 9027 RVA: 0x000B8310 File Offset: 0x000B6510
	[Token(Token = "0x6002343")]
	[Address(RVA = "0x5D3270", Offset = "0x5D1870", VA = "0x1805D3270")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		Plant plant = base.CrashEntity(collision, num != 0, 1f);
	}

	// Token: 0x06002344 RID: 9028 RVA: 0x000B8330 File Offset: 0x000B6530
	[Token(Token = "0x6002344")]
	[Address(RVA = "0x5B3BB0", Offset = "0x5B21B0", VA = "0x1805B3BB0", Slot = "56")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
		if (coldLevel > 0)
		{
			base.SetCold(time, coldLevel, freeze);
			return;
		}
	}

	// Token: 0x06002345 RID: 9029 RVA: 0x000B834C File Offset: 0x000B654C
	[Token(Token = "0x6002345")]
	[Address(RVA = "0x5B3BD0", Offset = "0x5B21D0", VA = "0x1805B3BD0", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		if (theFreezeLevel > 0)
		{
			int num = 0;
			base.SetFreeze(time, num);
			return;
		}
	}

	// Token: 0x06002346 RID: 9030 RVA: 0x000B8368 File Offset: 0x000B6568
	[Token(Token = "0x6002346")]
	[Address(RVA = "0x5D2D20", Offset = "0x5D1320", VA = "0x1805D2D20", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		for (;;)
		{
			long num = this.theHealth;
			num -= (long)theDamage;
			this.theHealth = num;
			int num2 = 0;
			num -= (long)theDamage;
			CrackStatus crackStatus = Lawnf.GetCrackStatus((float)0, (float)num2);
			if (crackStatus != CrackStatus.Good)
			{
				if (crackStatus == CrackStatus.Good)
				{
					goto IL_0085;
				}
				if (crackStatus != CrackStatus.Normal)
				{
					break;
				}
			}
			else
			{
				List<Transform> changeSprites = this.changeSprites;
				bool flag;
				if (flag)
				{
					SpriteRenderer spriteRenderer;
					ulong num3;
					spriteRenderer.enabled = num3 != 0UL;
					Transform transform;
					GameObject gameObject = transform.gameObject;
					int num4 = 0;
					gameObject.SetActive(num4 != 0);
					Transform transform2;
					GameObject gameObject2 = transform2.gameObject;
					int num5 = 0;
					gameObject2.SetActive(num5 != 0);
				}
				ulong num6;
				if (num6 == (ulong)0L)
				{
					goto IL_0085;
				}
				goto IL_0131;
			}
			IL_00C6:
			bool flag2;
			if (flag2)
			{
				int num7 = 0;
				SpriteRenderer spriteRenderer2;
				spriteRenderer2.enabled = num7 != 0;
				Transform transform3;
				GameObject gameObject3 = transform3.gameObject;
				int num8 = 0;
				gameObject3.SetActive(num8 != 0);
				Transform transform4;
				ulong num9;
				transform4.gameObject.SetActive(num9 != 0UL);
			}
			ulong num10;
			if (num10 == (ulong)0L)
			{
				goto Block_6;
			}
			continue;
			IL_0085:
			bool flag3;
			if (flag3)
			{
				int num11 = 0;
				SpriteRenderer spriteRenderer3;
				spriteRenderer3.enabled = num11 != 0;
				Transform transform5;
				ulong num12;
				transform5.gameObject.SetActive(num12 != 0UL);
				Transform transform6;
				GameObject gameObject4 = transform6.gameObject;
				int num13 = 0;
				gameObject4.SetActive(num13 != 0);
			}
			ulong num14;
			if (num14 == (ulong)0L)
			{
				goto IL_00C6;
			}
			goto IL_0155;
		}
		return;
		Block_6:
		throw new NullReferenceException();
		IL_0131:
		throw new NullReferenceException();
		IL_0155:
		throw new NullReferenceException();
	}

	// Token: 0x06002347 RID: 9031 RVA: 0x000B84F0 File Offset: 0x000B66F0
	[Token(Token = "0x6002347")]
	[Address(RVA = "0x5D33B0", Offset = "0x5D19B0", VA = "0x1805D33B0")]
	public SnowMonsterZombie()
	{
	}
}
