using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000815 RID: 2069
[Token(Token = "0x2000815")]
public class AdvantureMissionMenu : BaseMenu
{
	// Token: 0x06002A31 RID: 10801 RVA: 0x000E439C File Offset: 0x000E259C
	[Token(Token = "0x6002A31")]
	[Address(RVA = "0x6819F0", Offset = "0x67FFF0", VA = "0x1806819F0", Slot = "6")]
	protected override void Awake()
	{
		base.GetCol();
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
		this.InitText();
	}

	// Token: 0x06002A32 RID: 10802 RVA: 0x000E43C4 File Offset: 0x000E25C4
	[Token(Token = "0x6002A32")]
	[Address(RVA = "0x681A60", Offset = "0x680060", VA = "0x180681A60")]
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

	// Token: 0x06002A33 RID: 10803 RVA: 0x000E44B4 File Offset: 0x000E26B4
	[Token(Token = "0x6002A33")]
	[Address(RVA = "0x681EA0", Offset = "0x6804A0", VA = "0x180681EA0")]
	public void SwitchAward(AdvantureAwardButton award)
	{
		List<MissionData> missionDatas = AdvantureConfig.data.missionDatas;
		Func<MissionData, bool> func = delegate(MissionData item)
		{
			AdvantureAwardButton award4 = award;
			AdvantureLevel level2 = item.level;
			return award4.level == level2;
		};
		MissionData missionData = Enumerable.FirstOrDefault<MissionData>(missionDatas, func);
		if (missionData != 0)
		{
			AdvantureAwardButton award2 = award;
			MissionResult missionResult;
			if (missionResult != MissionResult.First || missionData.unlockedResult.Contains((uint)2))
			{
				if (missionResult != MissionResult.Second)
				{
					InGameText instance = InGameText.Instance;
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

	// Token: 0x06002A34 RID: 10804 RVA: 0x000E4594 File Offset: 0x000E2794
	[Token(Token = "0x6002A34")]
	[Address(RVA = "0x667800", Offset = "0x665E00", VA = "0x180667800")]
	public AdvantureMissionMenu()
	{
	}

	// Token: 0x04001824 RID: 6180
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001824")]
	public TextMeshProUGUI sampleText;

	// Token: 0x04001825 RID: 6181
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001825")]
	public RectTransform contant;
}
