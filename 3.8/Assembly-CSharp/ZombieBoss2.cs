using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200072B RID: 1835
[Token(Token = "0x200072B")]
public class ZombieBoss2 : ZombieBoss
{
	// Token: 0x06002555 RID: 9557 RVA: 0x000C46AC File Offset: 0x000C28AC
	[Token(Token = "0x6002555")]
	[Address(RVA = "0x5CE9F0", Offset = "0x5CCFF0", VA = "0x1805CE9F0", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		for (;;)
		{
			int num = this.theHealth;
			num -= theDamage;
			this.theHealth = num;
			bool flag;
			if (!flag)
			{
				break;
			}
			Transform transform = this.head.transform;
			int num2 = 0;
			GameObject gameObject = transform.GetChild(num2).gameObject;
			int num3 = 0;
			gameObject.SetActive(num3 != 0);
			uint num4;
			ulong num5;
			this.head.transform.GetChild((int)num4).gameObject.SetActive(num5 != 0UL);
			uint num6;
			GameObject gameObject2 = this.head.transform.GetChild((int)num6).gameObject;
			int num7 = 0;
			gameObject2.SetActive(num7 != 0);
			SpriteRenderer component = this.thumb.GetComponent<SpriteRenderer>();
			int num8 = 0;
			component.enabled = num8 != 0;
			Transform transform2 = this.thumb.transform;
			int num9 = 0;
			ulong num10;
			transform2.GetChild(num9).gameObject.SetActive(num10 != 0UL);
			uint num11;
			GameObject gameObject3 = this.thumb.transform.GetChild((int)num11).gameObject;
			int num12 = 0;
			gameObject3.SetActive(num12 != 0);
			SpriteRenderer component2 = this.jaw.GetComponent<SpriteRenderer>();
			int num13 = 0;
			component2.enabled = num13 != 0;
			Transform transform3 = this.jaw.transform;
			int num14 = 0;
			ulong num15;
			transform3.GetChild(num14).gameObject.SetActive(num15 != 0UL);
			uint num16;
			GameObject gameObject4 = this.jaw.transform.GetChild((int)num16).gameObject;
			int num17 = 0;
			gameObject4.SetActive(num17 != 0);
			SpriteRenderer component3 = this.hand.GetComponent<SpriteRenderer>();
			int num18 = 0;
			component3.enabled = num18 != 0;
			Transform transform4 = this.hand.transform;
			int num19 = 0;
			ulong num20;
			transform4.GetChild(num19).gameObject.SetActive(num20 != 0UL);
			uint num21;
			GameObject gameObject5 = this.hand.transform.GetChild((int)num21).gameObject;
			int num22 = 0;
			gameObject5.SetActive(num22 != 0);
			Transform transform5 = this.foot_inner.transform;
			int num23 = 0;
			GameObject gameObject6 = transform5.GetChild(num23).gameObject;
			int num24 = 0;
			gameObject6.SetActive(num24 != 0);
			uint num25;
			ulong num26;
			this.foot_inner.transform.GetChild((int)num25).gameObject.SetActive(num26 != 0UL);
			Hammer instance = Hammer.Instance;
			int num27 = 0;
			if (instance != num27)
			{
				goto Block_4;
			}
		}
		Transform transform6 = this.head.transform;
		int num28 = 0;
		GameObject gameObject7 = transform6.GetChild(num28).gameObject;
		int num29 = 0;
		gameObject7.SetActive(num29 != 0);
		uint num30;
		GameObject gameObject8 = this.head.transform.GetChild((int)num30).gameObject;
		int num31 = 0;
		gameObject8.SetActive(num31 != 0);
		uint num32;
		ulong num33;
		this.head.transform.GetChild((int)num32).gameObject.SetActive(num33 != 0UL);
		SpriteRenderer component4 = this.thumb.GetComponent<SpriteRenderer>();
		int num34 = 0;
		component4.enabled = num34 != 0;
		Transform transform7 = this.thumb.transform;
		int num35 = 0;
		GameObject gameObject9 = transform7.GetChild(num35).gameObject;
		int num36 = 0;
		gameObject9.SetActive(num36 != 0);
		uint num37;
		ulong num38;
		this.thumb.transform.GetChild((int)num37).gameObject.SetActive(num38 != 0UL);
		SpriteRenderer component5 = this.jaw.GetComponent<SpriteRenderer>();
		int num39 = 0;
		component5.enabled = num39 != 0;
		Transform transform8 = this.jaw.transform;
		int num40 = 0;
		GameObject gameObject10 = transform8.GetChild(num40).gameObject;
		int num41 = 0;
		gameObject10.SetActive(num41 != 0);
		uint num42;
		ulong num43;
		this.jaw.transform.GetChild((int)num42).gameObject.SetActive(num43 != 0UL);
		SpriteRenderer component6 = this.hand.GetComponent<SpriteRenderer>();
		int num44 = 0;
		component6.enabled = num44 != 0;
		Transform transform9 = this.hand.transform;
		int num45 = 0;
		GameObject gameObject11 = transform9.GetChild(num45).gameObject;
		int num46 = 0;
		gameObject11.SetActive(num46 != 0);
		uint num47;
		ulong num48;
		this.hand.transform.GetChild((int)num47).gameObject.SetActive(num48 != 0UL);
		SpriteRenderer component7 = this.foot_outter.GetComponent<SpriteRenderer>();
		int num49 = 0;
		component7.enabled = num49 != 0;
		Transform transform10 = this.foot_outter.transform;
		int num50 = 0;
		ulong num51;
		transform10.GetChild(num50).gameObject.SetActive(num51 != 0UL);
		uint num52;
		ulong num53;
		this.head.transform.GetChild((int)num52).gameObject.SetActive(num53 != 0UL);
		uint num54;
		ulong num55;
		this.head.transform.GetChild((int)num54).gameObject.SetActive(num55 != 0UL);
		Hammer instance2 = Hammer.Instance;
		int num56 = 0;
		if (instance2 != num56)
		{
			ulong num57;
			Hammer.Instance.gameObject.SetActive(num57 != 0UL);
		}
		Glove instance3 = Glove.Instance;
		int num58 = 0;
		if (instance3 != num58)
		{
			if (!Glove.Instance.gameObject.activeSelf)
			{
				InGameText instance4 = InGameText.Instance;
				int num59 = 0;
				instance4.ShowText("手套已解锁", 3f, num59 != 0);
			}
			ulong num60;
			Glove.Instance.gameObject.SetActive(num60 != 0UL);
		}
		return;
		Block_4:
		if (!Hammer.Instance.gameObject.activeSelf)
		{
			InGameText instance5 = InGameText.Instance;
			int num61 = 0;
			instance5.ShowText("锤子已解锁", 3f, num61 != 0);
		}
		throw new NullReferenceException();
	}

	// Token: 0x06002556 RID: 9558 RVA: 0x000C4B94 File Offset: 0x000C2D94
	[Token(Token = "0x6002556")]
	[Address(RVA = "0x5CE850", Offset = "0x5CCE50", VA = "0x1805CE850", Slot = "75")]
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

	// Token: 0x06002557 RID: 9559 RVA: 0x000C4C04 File Offset: 0x000C2E04
	[Token(Token = "0x6002557")]
	[Address(RVA = "0x5CF650", Offset = "0x5CDC50", VA = "0x1805CF650")]
	public ZombieBoss2()
	{
		this.spawnCount = (int)((ulong)8L);
		this.summonTime = 5f;
		this.ballCountDown = 3f;
		base..ctor();
	}
}
