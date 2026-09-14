using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000601 RID: 1537
[Token(Token = "0x2000601")]
public class TravelLookBuff : TravelBuffOptionButton
{
	// Token: 0x06001CFF RID: 7423 RVA: 0x0009AEB8 File Offset: 0x000990B8
	[Token(Token = "0x6001CFF")]
	[Address(RVA = "0x521BC0", Offset = "0x5201C0", VA = "0x180521BC0", Slot = "11")]
	public override void SetBuff(object buff, bool refresh = false)
	{
		this.set = true;
		this.buff = buff;
		string text = this.manager.GetText(buff);
		this.introduce.text = text;
		if (refresh)
		{
			base.SetPlant();
		}
		if (!TravelLookMenu.Instance.showAll && buff != 0 && buff != 0)
		{
			object obj;
			if (obj <= (ulong)13L || obj != (ulong)21L)
			{
			}
			TravelData data = this.manager.data;
			this.SetText("已满级");
			return;
		}
		List<TravelDebuff> travelDebuffs = this.manager.data.travelDebuffs;
		TravelData data2 = this.manager.data;
		int num;
		bool flag = num != 0;
		this.SetText(flag, num);
	}

	// Token: 0x06001D00 RID: 7424 RVA: 0x0009AFB8 File Offset: 0x000991B8
	[Token(Token = "0x6001D00")]
	[Address(RVA = "0x5213B0", Offset = "0x51F9B0", VA = "0x1805213B0", Slot = "9")]
	protected override void OnMouseUpAsButton()
	{
		object buff;
		for (;;)
		{
			base.OnMouseUpAsButton();
			TravelLookMenu instance = TravelLookMenu.Instance;
			buff = this.buff;
			if (!instance.showAll)
			{
				break;
			}
			if (buff == 0)
			{
				return;
			}
			if (buff != 0)
			{
				goto IL_01D0;
			}
			if (buff == 0)
			{
				goto Block_11;
			}
		}
		if (buff == 0)
		{
			return;
		}
		if (buff == 0)
		{
			if (buff == 0)
			{
				return;
			}
			object obj = buff;
			if (obj <= (ulong)13L || obj != (ulong)21L)
			{
			}
			TravelData data = this.manager.data;
			int num;
			bool flag;
			if (num < 2 && flag)
			{
				TravelMgr manager = this.manager;
				List<AdvBuff> advBuffs = TravelMgr.Instance.data.advBuffs;
				this.SetText("已满级");
				return;
			}
		}
		bool flag2;
		if (!flag2)
		{
			uint num2;
			GameAPP.PlaySound((int)num2, 0.5f, 1f);
			return;
		}
		Dictionary<TravelDebuff, ValueTuple<string, ZombieType>> debuffData = TravelDictionary.debuffData;
		bool flag3;
		if (!flag3)
		{
			List<TravelDebuff> travelDebuffs = this.manager.data.travelDebuffs;
			List<AdvBuff> advBuffs2 = this.manager.data.advBuffs;
			this.SetText("已消除");
			return;
		}
		uint num3;
		GameAPP.PlaySound((int)num3, 0.5f, 1f);
		InGameText instance2 = InGameText.Instance;
		int num4 = 0;
		instance2.ShowText("不可净化领袖词条", 3f, num4 != 0);
		return;
		Block_11:
		if (buff == 0)
		{
			if (buff == 0)
			{
				return;
			}
			List<TravelDebuff> travelDebuffs2 = this.manager.data.travelDebuffs;
			TravelMgr manager2 = this.manager;
			bool flag4;
			if (!flag4)
			{
				uint num5;
				this.SetText(num5 != 0U, (int)num5);
				return;
			}
			bool callsDirty = this.clickEvent.m_CallsDirty;
		}
		int num6;
		if (num6 != 0)
		{
			if (num6 != 0)
			{
				while (num6 != 1)
				{
				}
				List<UltiBuff> ultiBuffs = this.manager.data.ultiBuffs;
				List<UltiBuff> ultiBuffs_lv = this.manager.data.ultiBuffs_lv2;
			}
			TravelMgr manager3 = this.manager;
		}
		TravelMgr manager4 = this.manager;
		List<AdvBuff> advBuffs3 = this.manager.data.advBuffs;
		TravelMgr manager5 = this.manager;
		bool flag5;
		if (!flag5)
		{
		}
		List<AdvBuff> advBuffs4 = manager5.data.advBuffs;
		IL_01D0:
		List<TravelUnlocks> unlockedPlants = this.manager.data.unlockedPlants;
		TravelMgr manager6 = this.manager;
		bool flag6;
		if (!flag6)
		{
		}
		List<TravelUnlocks> unlockedPlants2 = manager6.data.unlockedPlants;
		throw new NullReferenceException();
	}

	// Token: 0x06001D01 RID: 7425 RVA: 0x0009B1C8 File Offset: 0x000993C8
	[Token(Token = "0x6001D01")]
	[Address(RVA = "0x5212B0", Offset = "0x51F8B0", VA = "0x1805212B0", Slot = "10")]
	public override void Clear()
	{
		GameObject show = this.show;
		int num = 0;
		if (show != num)
		{
			global::UnityEngine.Object.Destroy(this.show);
		}
		this.introduce.text = "无";
		int num2 = 0;
		base.SetBackground((TravelBuffOptionButton.BgType)num2);
		this.set = false;
		this.SetText("不可升级");
	}

	// Token: 0x06001D02 RID: 7426 RVA: 0x0009B224 File Offset: 0x00099424
	[Token(Token = "0x6001D02")]
	[Address(RVA = "0x522250", Offset = "0x520850", VA = "0x180522250")]
	private void SetText(string text)
	{
		Transform transform = this.rectTransform.transform;
		int num = 0;
		TextMeshProUGUI component = transform.GetChild(num).GetComponent<TextMeshProUGUI>();
		TextMeshProUGUI component2 = this.rectTransform.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
		component.text = text;
		throw new NullReferenceException();
	}

	// Token: 0x06001D03 RID: 7427 RVA: 0x0009B270 File Offset: 0x00099470
	[Token(Token = "0x6001D03")]
	[Address(RVA = "0x521FD0", Offset = "0x5205D0", VA = "0x180521FD0")]
	private void SetText(bool have, int level = 1)
	{
		Transform transform = this.rectTransform.transform;
		int num = 0;
		TextMeshProUGUI component = transform.GetChild(num).GetComponent<TextMeshProUGUI>();
		TextMeshProUGUI component2 = this.rectTransform.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
		if (!have)
		{
			component.text = "已关闭";
		}
		component.text = "已开启";
		object buff = this.buff;
		if (buff != 0 && buff != 0)
		{
			string text = component.text;
			string text2 = string.Format("（{0}级）", text);
			string text3 = text + text2;
			component.text = text3;
		}
		string text4 = component.text;
		throw new NullReferenceException();
	}

	// Token: 0x06001D04 RID: 7428 RVA: 0x0009B314 File Offset: 0x00099514
	[Token(Token = "0x6001D04")]
	[Address(RVA = "0x51C260", Offset = "0x51A860", VA = "0x18051C260")]
	public TravelLookBuff()
	{
	}
}
