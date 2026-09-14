using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006C8 RID: 1736
[Token(Token = "0x20006C8")]
public class SnowMonsterZombie : Zombie
{
	// Token: 0x06002225 RID: 8741 RVA: 0x000B3470 File Offset: 0x000B1670
	[Token(Token = "0x6002225")]
	[Address(RVA = "0x56FBB0", Offset = "0x56E1B0", VA = "0x18056FBB0", Slot = "15")]
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

	// Token: 0x06002226 RID: 8742 RVA: 0x000B34CC File Offset: 0x000B16CC
	[Token(Token = "0x6002226")]
	[Address(RVA = "0x56FB30", Offset = "0x56E130", VA = "0x18056FB30")]
	private void LandEvent()
	{
		this.axis.gameObject.SetActive(true);
	}

	// Token: 0x06002227 RID: 8743 RVA: 0x000B34F0 File Offset: 0x000B16F0
	[Token(Token = "0x6002227")]
	[Address(RVA = "0x56FBA0", Offset = "0x56E1A0", VA = "0x18056FBA0", Slot = "21")]
	protected override void PositionUpdate()
	{
		base.PositionUpdate();
	}

	// Token: 0x06002228 RID: 8744 RVA: 0x000B3508 File Offset: 0x000B1708
	[Token(Token = "0x6002228")]
	[Address(RVA = "0x56FB60", Offset = "0x56E160", VA = "0x18056FB60")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		Plant plant = base.CrashEntity(collision, num != 0, 1f);
	}

	// Token: 0x06002229 RID: 8745 RVA: 0x000B3528 File Offset: 0x000B1728
	[Token(Token = "0x6002229")]
	[Address(RVA = "0x550020", Offset = "0x54E620", VA = "0x180550020", Slot = "54")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
		if (coldLevel > 0)
		{
			base.SetCold(time, coldLevel, freeze);
			return;
		}
	}

	// Token: 0x0600222A RID: 8746 RVA: 0x000B3544 File Offset: 0x000B1744
	[Token(Token = "0x600222A")]
	[Address(RVA = "0x550040", Offset = "0x54E640", VA = "0x180550040", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		if (theFreezeLevel > 0)
		{
			int num = 0;
			base.SetFreeze(time, num);
			return;
		}
	}

	// Token: 0x0600222B RID: 8747 RVA: 0x000B3560 File Offset: 0x000B1760
	[Token(Token = "0x600222B")]
	[Address(RVA = "0x56F610", Offset = "0x56DC10", VA = "0x18056F610", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		for (;;)
		{
			int num = 0;
			int num2 = this.theHealth;
			num2 -= theDamage;
			this.theHealth = num2;
			num2 -= theDamage;
			CrackStatus crackStatus = Lawnf.GetCrackStatus((float)num, (float)theDamage);
			if (crackStatus != CrackStatus.Good)
			{
				if (crackStatus == CrackStatus.Good)
				{
					goto IL_007F;
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
					goto IL_007F;
				}
				goto IL_012B;
			}
			IL_00C0:
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
			IL_007F:
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
				goto IL_00C0;
			}
			goto IL_014F;
		}
		return;
		Block_6:
		throw new NullReferenceException();
		IL_012B:
		throw new NullReferenceException();
		IL_014F:
		throw new NullReferenceException();
	}

	// Token: 0x0600222C RID: 8748 RVA: 0x000B36E0 File Offset: 0x000B18E0
	[Token(Token = "0x600222C")]
	[Address(RVA = "0x56FCA0", Offset = "0x56E2A0", VA = "0x18056FCA0")]
	public SnowMonsterZombie()
	{
	}
}
