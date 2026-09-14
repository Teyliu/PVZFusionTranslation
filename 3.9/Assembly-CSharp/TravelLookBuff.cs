using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000636 RID: 1590
[Token(Token = "0x2000636")]
public class TravelLookBuff : TravelBuffOptionButton
{
	// Token: 0x06001DFE RID: 7678 RVA: 0x0009F9C0 File Offset: 0x0009DBC0
	[Token(Token = "0x6001DFE")]
	[Address(RVA = "0x581C50", Offset = "0x580250", VA = "0x180581C50", Slot = "11")]
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

	// Token: 0x06001DFF RID: 7679 RVA: 0x0009FAC0 File Offset: 0x0009DCC0
	[Token(Token = "0x6001DFF")]
	[Address(RVA = "0x581440", Offset = "0x57FA40", VA = "0x180581440", Slot = "9")]
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
				goto IL_01BA;
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
				uint num4;
				this.SetText(num4 != 0U, (int)num4);
				return;
			}
			bool callsDirty = this.clickEvent.m_CallsDirty;
		}
		int num5;
		if (num5 != 0)
		{
			if (num5 != 0)
			{
				while (num5 != 1)
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
		IL_01BA:
		List<TravelUnlocks> unlockedPlants = this.manager.data.unlockedPlants;
		TravelMgr manager6 = this.manager;
		bool flag6;
		if (!flag6)
		{
		}
		List<TravelUnlocks> unlockedPlants2 = manager6.data.unlockedPlants;
		throw new NullReferenceException();
	}

	// Token: 0x06001E00 RID: 7680 RVA: 0x0009FCBC File Offset: 0x0009DEBC
	[Token(Token = "0x6001E00")]
	[Address(RVA = "0x581340", Offset = "0x57F940", VA = "0x180581340", Slot = "10")]
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

	// Token: 0x06001E01 RID: 7681 RVA: 0x0009FD18 File Offset: 0x0009DF18
	[Token(Token = "0x6001E01")]
	[Address(RVA = "0x5822E0", Offset = "0x5808E0", VA = "0x1805822E0")]
	private void SetText(string text)
	{
		Transform transform = this.rectTransform.transform;
		int num = 0;
		TextMeshProUGUI component = transform.GetChild(num).GetComponent<TextMeshProUGUI>();
		TextMeshProUGUI component2 = this.rectTransform.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
		component.text = text;
		throw new NullReferenceException();
	}

	// Token: 0x06001E02 RID: 7682 RVA: 0x0009FD64 File Offset: 0x0009DF64
	[Token(Token = "0x6001E02")]
	[Address(RVA = "0x582060", Offset = "0x580660", VA = "0x180582060")]
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

	// Token: 0x06001E03 RID: 7683 RVA: 0x0009FE08 File Offset: 0x0009E008
	[Token(Token = "0x6001E03")]
	[Address(RVA = "0x5763F0", Offset = "0x5749F0", VA = "0x1805763F0")]
	public TravelLookBuff()
	{
	}
}
