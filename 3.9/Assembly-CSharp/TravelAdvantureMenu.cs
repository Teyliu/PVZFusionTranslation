using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using GameLevel;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x0200083C RID: 2108
[Token(Token = "0x200083C")]
public class TravelAdvantureMenu : BaseMenu
{
	// Token: 0x06002B05 RID: 11013 RVA: 0x000E9AC0 File Offset: 0x000E7CC0
	[Token(Token = "0x6002B05")]
	[Address(RVA = "0x6ABA20", Offset = "0x6AA020", VA = "0x1806ABA20", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		this.InitWeakUltis();
		this.InitStrongUltis();
		this.LookWeak();
	}

	// Token: 0x06002B06 RID: 11014 RVA: 0x000E9AE8 File Offset: 0x000E7CE8
	[Token(Token = "0x6002B06")]
	[Address(RVA = "0x6AC6F0", Offset = "0x6AACF0", VA = "0x1806AC6F0")]
	public void LookUlti()
	{
		this.strongPage.gameObject.SetActive(true);
		GameObject gameObject = this.weakPage.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
		this.lastPage.clickEvent.RemoveAllListeners();
		UnityEvent clickEvent = this.lastPage.clickEvent;
		UnityAction unityAction = new UnityAction(this.strongPage.LastPage);
		clickEvent.AddListener(unityAction);
		this.nextPage.clickEvent.RemoveAllListeners();
		UnityEvent clickEvent2 = this.nextPage.clickEvent;
		UnityAction unityAction2 = new UnityAction(this.strongPage.NextPage);
		clickEvent2.AddListener(unityAction2);
	}

	// Token: 0x06002B07 RID: 11015 RVA: 0x000E9B90 File Offset: 0x000E7D90
	[Token(Token = "0x6002B07")]
	[Address(RVA = "0x6AC880", Offset = "0x6AAE80", VA = "0x1806AC880")]
	public void LookWeak()
	{
		GameObject gameObject = this.strongPage.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
		this.weakPage.gameObject.SetActive(true);
		this.lastPage.clickEvent.RemoveAllListeners();
		UnityEvent clickEvent = this.lastPage.clickEvent;
		UnityAction unityAction = new UnityAction(this.weakPage.LastPage);
		clickEvent.AddListener(unityAction);
		this.nextPage.clickEvent.RemoveAllListeners();
		UnityEvent clickEvent2 = this.nextPage.clickEvent;
		UnityAction unityAction2 = new UnityAction(this.weakPage.NextPage);
		clickEvent2.AddListener(unityAction2);
	}

	// Token: 0x06002B08 RID: 11016 RVA: 0x000E9C38 File Offset: 0x000E7E38
	[Token(Token = "0x6002B08")]
	[Address(RVA = "0x6AC0B0", Offset = "0x6AA6B0", VA = "0x1806AC0B0")]
	private void InitWeakUltis()
	{
		ulong num;
		this.sampleLevel.gameObject.SetActive(num != 0UL);
		ulong num2;
		this.samplePage.SetActive(num2 != 0UL);
		Page page = this.weakPage;
		int num3 = 0;
		GameObject gameObject = this.samplePage;
		Transform transform = page.transform;
		Transform transform2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform).transform;
		TravelAdvanture[] enumValues = global::Core.Lawnf.GetEnumValues<TravelAdvanture>();
		int num4 = 0;
		int num5 = 0;
		if (num4 < enumValues.Length)
		{
			bool flag;
			global::GameLevel.LevelData level;
			if (flag && level.LevelNumber < 1000)
			{
				CustomButton_enterGame customButton_enterGame = global::UnityEngine.Object.Instantiate<CustomButton_enterGame>(this.sampleLevel, transform2);
				UnityEvent theEvent_up = customButton_enterGame.theEvent_up;
				customButton_enterGame.useOriginalAction = true;
				UnityAction unityAction = delegate
				{
					int levelNumber = level.LevelNumber;
					int num9 = 0;
					UIMgr.EnterGame((LevelType)((uint)5), levelNumber, -1, num9);
				};
				theEvent_up.AddListener(unityAction);
				UnityEvent theEvent_up2 = customButton_enterGame.theEvent_up;
				UnityAction <>9__9_ = TravelAdvantureMenu.<>c.<>9__9_1;
				if (<>9__9_ == 0)
				{
					TravelAdvantureMenu.<>c.<>9__9_1 = delegate
					{
						CursorChange.SetDefaultCursor();
					};
				}
				theEvent_up2.AddListener(<>9__9_);
				string text;
				object obj = Enum.Parse(typeof(PlantType), text);
				GameObject trophy = customButton_enterGame.trophy;
				HashSet<TravelAdvanture> travelLevelCompleted_runTime = GameAPP.config.travelLevelCompleted_runTime;
				bool flag2;
				trophy.SetActive(flag2);
				num3++;
				if (num3 == 28)
				{
					Page page2 = this.weakPage;
					GameObject gameObject2 = this.samplePage;
					Transform transform3 = page2.transform;
					GameObject gameObject3 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject2, transform3).transform.gameObject;
					int num6 = 0;
					gameObject3.SetActive(num6 != 0);
				}
			}
			num5++;
		}
		GameObject gameObject4 = this.sampleLevel.gameObject;
		int num7 = 0;
		gameObject4.SetActive(num7 != 0);
		GameObject gameObject5 = this.samplePage;
		int num8 = 0;
		gameObject5.SetActive(num8 != 0);
	}

	// Token: 0x06002B09 RID: 11017 RVA: 0x000E9DE8 File Offset: 0x000E7FE8
	[Token(Token = "0x6002B09")]
	[Address(RVA = "0x6ABA60", Offset = "0x6AA060", VA = "0x1806ABA60")]
	private void InitStrongUltis()
	{
		ulong num;
		this.sampleLevel.gameObject.SetActive(num != 0UL);
		ulong num2;
		this.samplePage.SetActive(num2 != 0UL);
		Page page = this.strongPage;
		int num3 = 0;
		GameObject gameObject = this.samplePage;
		Transform transform = page.transform;
		Transform transform2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform).transform;
		TravelAdvanture[] enumValues = global::Core.Lawnf.GetEnumValues<TravelAdvanture>();
		int num4 = 0;
		int num5 = 0;
		if (num4 < enumValues.Length)
		{
			bool flag;
			if (flag)
			{
			}
			CustomButton_enterGame customButton_enterGame = global::UnityEngine.Object.Instantiate<CustomButton_enterGame>(this.sampleLevel, transform2);
			UnityEvent theEvent_up = customButton_enterGame.theEvent_up;
			customButton_enterGame.useOriginalAction = true;
			int levelNumber;
			UnityAction unityAction = delegate
			{
				int levelNumber2 = levelNumber;
				int num9 = 0;
				UIMgr.EnterGame((LevelType)((uint)5), levelNumber2, -1, num9);
			};
			theEvent_up.AddListener(unityAction);
			UnityEvent theEvent_up2 = customButton_enterGame.theEvent_up;
			UnityAction unityAction2;
			if (TravelAdvantureMenu.<>c.<>9__10_1 == 0)
			{
				unityAction2 = delegate
				{
					CursorChange.SetDefaultCursor();
				};
				TravelAdvantureMenu.<>c.<>9__10_1 = unityAction2;
			}
			theEvent_up2.AddListener(unityAction2);
			string text;
			object obj = Enum.Parse(typeof(PlantType), text);
			GameObject trophy = customButton_enterGame.trophy;
			HashSet<TravelAdvanture> travelLevelCompleted_runTime = GameAPP.config.travelLevelCompleted_runTime;
			bool flag2;
			trophy.SetActive(flag2);
			num3++;
			if (num3 == 28)
			{
				Page page2 = this.strongPage;
				GameObject gameObject2 = this.samplePage;
				Transform transform3 = page2.transform;
				GameObject gameObject3 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject2, transform3).transform.gameObject;
				int num6 = 0;
				gameObject3.SetActive(num6 != 0);
			}
			num5++;
		}
		GameObject gameObject4 = this.sampleLevel.gameObject;
		int num7 = 0;
		gameObject4.SetActive(num7 != 0);
		GameObject gameObject5 = this.samplePage;
		int num8 = 0;
		gameObject5.SetActive(num8 != 0);
	}

	// Token: 0x06002B0A RID: 11018 RVA: 0x000E9F84 File Offset: 0x000E8184
	[Token(Token = "0x6002B0A")]
	[Address(RVA = "0x667800", Offset = "0x665E00", VA = "0x180667800")]
	public TravelAdvantureMenu()
	{
	}

	// Token: 0x040018F8 RID: 6392
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40018F8")]
	public CustomButton_enterGame sampleLevel;

	// Token: 0x040018F9 RID: 6393
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40018F9")]
	public GameObject samplePage;

	// Token: 0x040018FA RID: 6394
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40018FA")]
	public Page weakPage;

	// Token: 0x040018FB RID: 6395
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40018FB")]
	public Page strongPage;

	// Token: 0x040018FC RID: 6396
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40018FC")]
	public UIButton lastPage;

	// Token: 0x040018FD RID: 6397
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40018FD")]
	public UIButton nextPage;
}
