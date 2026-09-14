using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using GameLevel;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000801 RID: 2049
[Token(Token = "0x2000801")]
public class TravelAdvantureMenu : BaseMenu
{
	// Token: 0x060029CF RID: 10703 RVA: 0x000E4A48 File Offset: 0x000E2C48
	[Token(Token = "0x60029CF")]
	[Address(RVA = "0x647280", Offset = "0x645880", VA = "0x180647280", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		this.InitWeakUltis();
		this.InitStrongUltis();
		this.LookWeak();
	}

	// Token: 0x060029D0 RID: 10704 RVA: 0x000E4A70 File Offset: 0x000E2C70
	[Token(Token = "0x60029D0")]
	[Address(RVA = "0x647F50", Offset = "0x646550", VA = "0x180647F50")]
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

	// Token: 0x060029D1 RID: 10705 RVA: 0x000E4B18 File Offset: 0x000E2D18
	[Token(Token = "0x60029D1")]
	[Address(RVA = "0x6480E0", Offset = "0x6466E0", VA = "0x1806480E0")]
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

	// Token: 0x060029D2 RID: 10706 RVA: 0x000E4BC0 File Offset: 0x000E2DC0
	[Token(Token = "0x60029D2")]
	[Address(RVA = "0x647910", Offset = "0x645F10", VA = "0x180647910")]
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

	// Token: 0x060029D3 RID: 10707 RVA: 0x000E4D70 File Offset: 0x000E2F70
	[Token(Token = "0x60029D3")]
	[Address(RVA = "0x6472C0", Offset = "0x6458C0", VA = "0x1806472C0")]
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

	// Token: 0x060029D4 RID: 10708 RVA: 0x000E4F0C File Offset: 0x000E310C
	[Token(Token = "0x60029D4")]
	[Address(RVA = "0x603FF0", Offset = "0x6025F0", VA = "0x180603FF0")]
	public TravelAdvantureMenu()
	{
	}

	// Token: 0x0400180D RID: 6157
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400180D")]
	public CustomButton_enterGame sampleLevel;

	// Token: 0x0400180E RID: 6158
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400180E")]
	public GameObject samplePage;

	// Token: 0x0400180F RID: 6159
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400180F")]
	public Page weakPage;

	// Token: 0x04001810 RID: 6160
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001810")]
	public Page strongPage;

	// Token: 0x04001811 RID: 6161
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001811")]
	public UIButton lastPage;

	// Token: 0x04001812 RID: 6162
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001812")]
	public UIButton nextPage;
}
