using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000764 RID: 1892
[Token(Token = "0x2000764")]
public class ZombieBoss2 : ZombieBoss
{
	// Token: 0x0600267A RID: 9850 RVA: 0x000C95F0 File Offset: 0x000C77F0
	[Token(Token = "0x600267A")]
	[Address(RVA = "0x62FD50", Offset = "0x62E350", VA = "0x18062FD50", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		for (;;)
		{
			long num = this.theHealth;
			num -= (long)theDamage;
			this.theHealth = num;
			int num2 = 0;
			int num3 = 0;
			if (!global::Core.Lawnf.ValueBetween((float)0, (float)num3, (float)num2))
			{
				break;
			}
			Transform transform = this.head.transform;
			int num4 = 0;
			GameObject gameObject = transform.GetChild(num4).gameObject;
			int num5 = 0;
			gameObject.SetActive(num5 != 0);
			uint num6;
			ulong num7;
			this.head.transform.GetChild((int)num6).gameObject.SetActive(num7 != 0UL);
			uint num8;
			GameObject gameObject2 = this.head.transform.GetChild((int)num8).gameObject;
			int num9 = 0;
			gameObject2.SetActive(num9 != 0);
			SpriteRenderer component = this.thumb.GetComponent<SpriteRenderer>();
			int num10 = 0;
			component.enabled = num10 != 0;
			Transform transform2 = this.thumb.transform;
			int num11 = 0;
			ulong num12;
			transform2.GetChild(num11).gameObject.SetActive(num12 != 0UL);
			uint num13;
			GameObject gameObject3 = this.thumb.transform.GetChild((int)num13).gameObject;
			int num14 = 0;
			gameObject3.SetActive(num14 != 0);
			SpriteRenderer component2 = this.jaw.GetComponent<SpriteRenderer>();
			int num15 = 0;
			component2.enabled = num15 != 0;
			Transform transform3 = this.jaw.transform;
			int num16 = 0;
			ulong num17;
			transform3.GetChild(num16).gameObject.SetActive(num17 != 0UL);
			uint num18;
			GameObject gameObject4 = this.jaw.transform.GetChild((int)num18).gameObject;
			int num19 = 0;
			gameObject4.SetActive(num19 != 0);
			SpriteRenderer component3 = this.hand.GetComponent<SpriteRenderer>();
			int num20 = 0;
			component3.enabled = num20 != 0;
			Transform transform4 = this.hand.transform;
			int num21 = 0;
			ulong num22;
			transform4.GetChild(num21).gameObject.SetActive(num22 != 0UL);
			uint num23;
			GameObject gameObject5 = this.hand.transform.GetChild((int)num23).gameObject;
			int num24 = 0;
			gameObject5.SetActive(num24 != 0);
			Transform transform5 = this.foot_inner.transform;
			int num25 = 0;
			GameObject gameObject6 = transform5.GetChild(num25).gameObject;
			int num26 = 0;
			gameObject6.SetActive(num26 != 0);
			uint num27;
			ulong num28;
			this.foot_inner.transform.GetChild((int)num27).gameObject.SetActive(num28 != 0UL);
			Hammer instance = Hammer.Instance;
			int num29 = 0;
			if (instance != num29)
			{
				goto Block_4;
			}
		}
		Transform transform6 = this.head.transform;
		int num30 = 0;
		GameObject gameObject7 = transform6.GetChild(num30).gameObject;
		int num31 = 0;
		gameObject7.SetActive(num31 != 0);
		uint num32;
		GameObject gameObject8 = this.head.transform.GetChild((int)num32).gameObject;
		int num33 = 0;
		gameObject8.SetActive(num33 != 0);
		uint num34;
		ulong num35;
		this.head.transform.GetChild((int)num34).gameObject.SetActive(num35 != 0UL);
		SpriteRenderer component4 = this.thumb.GetComponent<SpriteRenderer>();
		int num36 = 0;
		component4.enabled = num36 != 0;
		Transform transform7 = this.thumb.transform;
		int num37 = 0;
		GameObject gameObject9 = transform7.GetChild(num37).gameObject;
		int num38 = 0;
		gameObject9.SetActive(num38 != 0);
		uint num39;
		ulong num40;
		this.thumb.transform.GetChild((int)num39).gameObject.SetActive(num40 != 0UL);
		SpriteRenderer component5 = this.jaw.GetComponent<SpriteRenderer>();
		int num41 = 0;
		component5.enabled = num41 != 0;
		Transform transform8 = this.jaw.transform;
		int num42 = 0;
		GameObject gameObject10 = transform8.GetChild(num42).gameObject;
		int num43 = 0;
		gameObject10.SetActive(num43 != 0);
		uint num44;
		ulong num45;
		this.jaw.transform.GetChild((int)num44).gameObject.SetActive(num45 != 0UL);
		SpriteRenderer component6 = this.hand.GetComponent<SpriteRenderer>();
		int num46 = 0;
		component6.enabled = num46 != 0;
		Transform transform9 = this.hand.transform;
		int num47 = 0;
		GameObject gameObject11 = transform9.GetChild(num47).gameObject;
		int num48 = 0;
		gameObject11.SetActive(num48 != 0);
		uint num49;
		ulong num50;
		this.hand.transform.GetChild((int)num49).gameObject.SetActive(num50 != 0UL);
		SpriteRenderer component7 = this.foot_outter.GetComponent<SpriteRenderer>();
		int num51 = 0;
		component7.enabled = num51 != 0;
		Transform transform10 = this.foot_outter.transform;
		int num52 = 0;
		ulong num53;
		transform10.GetChild(num52).gameObject.SetActive(num53 != 0UL);
		uint num54;
		ulong num55;
		this.head.transform.GetChild((int)num54).gameObject.SetActive(num55 != 0UL);
		uint num56;
		ulong num57;
		this.head.transform.GetChild((int)num56).gameObject.SetActive(num57 != 0UL);
		Hammer instance2 = Hammer.Instance;
		int num58 = 0;
		if (instance2 != num58)
		{
			ulong num59;
			Hammer.Instance.gameObject.SetActive(num59 != 0UL);
		}
		Glove instance3 = Glove.Instance;
		int num60 = 0;
		if (instance3 != num60)
		{
			if (!Glove.Instance.gameObject.activeSelf)
			{
				InGameText instance4 = InGameText.Instance;
			}
			ulong num61;
			Glove.Instance.gameObject.SetActive(num61 != 0UL);
		}
		return;
		Block_4:
		if (!Hammer.Instance.gameObject.activeSelf)
		{
			InGameText instance5 = InGameText.Instance;
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600267B RID: 9851 RVA: 0x000C9ABC File Offset: 0x000C7CBC
	[Token(Token = "0x600267B")]
	[Address(RVA = "0x62FBB0", Offset = "0x62E1B0", VA = "0x18062FBB0", Slot = "77")]
	protected override void AnimRv()
	{
		base.AnimRv();
		ConveyManager instance = ConveyManager.Instance;
		int num = 0;
		if (instance != num)
		{
			int size = ConveyManager.Instance.cardsOnBelt._size;
			int num2 = size - 1;
			if (size > 0)
			{
				CardUI cardUI = ConveyManager.Instance.cardsOnBelt[num2];
				int num3 = 0;
				if (!(cardUI != num3) || cardUI != 0)
				{
				}
				if (num2 > 0)
				{
				}
			}
		}
	}

	// Token: 0x0600267C RID: 9852 RVA: 0x000C9B2C File Offset: 0x000C7D2C
	[Token(Token = "0x600267C")]
	[Address(RVA = "0x6309F0", Offset = "0x62EFF0", VA = "0x1806309F0")]
	public ZombieBoss2()
	{
		this.spawnCount = (int)((ulong)8L);
		this.summonTime = 5f;
		this.ballCountDown = 3f;
		base..ctor();
	}
}
