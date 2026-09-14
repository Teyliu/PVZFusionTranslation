using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020007DC RID: 2012
[Token(Token = "0x20007DC")]
public class AdvantureMissionMenu : BaseMenu
{
	// Token: 0x06002902 RID: 10498 RVA: 0x000DF40C File Offset: 0x000DD60C
	[Token(Token = "0x6002902")]
	[Address(RVA = "0x61E100", Offset = "0x61C700", VA = "0x18061E100", Slot = "6")]
	protected override void Awake()
	{
		base.GetCol();
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
		this.InitText();
	}

	// Token: 0x06002903 RID: 10499 RVA: 0x000DF434 File Offset: 0x000DD634
	[Token(Token = "0x6002903")]
	[Address(RVA = "0x61E170", Offset = "0x61C770", VA = "0x18061E170")]
	private void InitText()
	{
		int num;
		do
		{
			num = 0;
			List<MissionData> missionDatas = AdvantureConfig.data.missionDatas;
			Func<MissionData, AdvantureLevel> <>9__3_ = AdvantureMissionMenu.<>c.<>9__3_0;
			if (<>9__3_ == 0)
			{
				Func<MissionData, AdvantureLevel> func;
				AdvantureMissionMenu.<>c.<>9__3_0 = func;
			}
			List<MissionData> list = Enumerable.ToList<MissionData>(Enumerable.OrderBy<MissionData, AdvantureLevel>(missionDatas, <>9__3_));
			bool flag;
			if (flag)
			{
				TextMeshProUGUI textMeshProUGUI = this.sampleText;
				Transform parent = textMeshProUGUI.transform.parent;
				TextMeshProUGUI textMeshProUGUI2 = global::UnityEngine.Object.Instantiate<TextMeshProUGUI>(textMeshProUGUI, parent);
				AdvantureAwardButton component = textMeshProUGUI2.GetComponent<AdvantureAwardButton>();
				component.level = textMeshProUGUI2;
				component.result = textMeshProUGUI2;
				component.UpdateText();
				num++;
			}
		}
		while (num != 0);
		TextMeshProUGUI textMeshProUGUI3;
		if (num == 0)
		{
			Transform transform;
			Transform parent2 = transform.parent;
			textMeshProUGUI3.text = "通关主线关卡，完成任务获取奖励";
		}
		GameObject gameObject = textMeshProUGUI3.gameObject;
		global::UnityEngine.Object.Destroy(gameObject);
		long num2 = (long)(num * (int)((uint)255));
	}

	// Token: 0x06002904 RID: 10500 RVA: 0x000DF524 File Offset: 0x000DD724
	[Token(Token = "0x6002904")]
	[Address(RVA = "0x61E5B0", Offset = "0x61CBB0", VA = "0x18061E5B0")]
	public void SwitchAward(AdvantureAwardButton award)
	{
		Func<MissionData, bool> func;
		MissionData missionData = Enumerable.FirstOrDefault<MissionData>(AdvantureConfig.data.missionDatas, func);
		if (missionData != 0)
		{
			AdvantureAwardButton award2 = award;
			MissionResult missionResult;
			if (missionResult != MissionResult.First || missionData.unlockedResult.Contains((uint)2))
			{
				if (missionResult != MissionResult.Second)
				{
					InGameText instance = InGameText.Instance;
					int num = 0;
					instance.ShowText("你还没有解锁过另一个奖励", 1f, num != 0);
					GameAPP.PlaySound(26, 0.5f, 1f);
					return;
				}
				if (missionData.unlockedResult.Contains((uint)1))
				{
				}
			}
			AdvantureAwardButton award3 = award;
			List<MissionResult> unlockedResult = missionData.unlockedResult;
			MissionResult result = award3.result;
			AdvantureData data = AdvantureConfig.data;
			AdvantureLevel level = award.level;
			MissionResult missionResult2;
			award.result = missionResult2;
			award.UpdateText();
		}
	}

	// Token: 0x06002905 RID: 10501 RVA: 0x000DF608 File Offset: 0x000DD808
	[Token(Token = "0x6002905")]
	[Address(RVA = "0x603FF0", Offset = "0x6025F0", VA = "0x180603FF0")]
	public AdvantureMissionMenu()
	{
	}

	// Token: 0x04001748 RID: 5960
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001748")]
	public TextMeshProUGUI sampleText;

	// Token: 0x04001749 RID: 5961
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001749")]
	public RectTransform contant;
}
