using System;
using System.Collections.Generic;
using com.cyborgAssets.inspectorButtonPro;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020007D9 RID: 2009
[Token(Token = "0x20007D9")]
public class AdvantureEvolutionMenu : BaseMenu
{
	// Token: 0x060028E6 RID: 10470 RVA: 0x000DE0B0 File Offset: 0x000DC2B0
	[Token(Token = "0x60028E6")]
	[Address(RVA = "0x61B2C0", Offset = "0x6198C0", VA = "0x18061B2C0")]
	[ProButton]
	public void Save()
	{
		PlantDevelopData plantDevelopData = AdvantureConfig.data.plantDevelopData;
		CustomizedPlant customizedPlant = this.customizedPlant;
		plantDevelopData.CustomizePlant(customizedPlant);
	}

	// Token: 0x060028E7 RID: 10471 RVA: 0x000DE0DC File Offset: 0x000DC2DC
	[Token(Token = "0x60028E7")]
	[Address(RVA = "0x61A660", Offset = "0x618C60", VA = "0x18061A660", Slot = "6")]
	protected override void Awake()
	{
		base.GetCol();
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
		int num = 0;
		this.SetPlant((PlantType)num);
		TextMeshProUGUI textMeshProUGUI = this.normalStarCount;
		AdvantureData data = AdvantureConfig.data;
		string text2;
		string text = "：" + text2;
		textMeshProUGUI.text = text;
		TextMeshProUGUI textMeshProUGUI2 = this.hardStarCount;
		AdvantureData data2 = AdvantureConfig.data;
		string text4;
		string text3 = "：" + text4;
		throw new NullReferenceException();
	}

	// Token: 0x060028E8 RID: 10472 RVA: 0x000DE14C File Offset: 0x000DC34C
	[Token(Token = "0x60028E8")]
	[Address(RVA = "0x61AE90", Offset = "0x619490", VA = "0x18061AE90")]
	public void RollEvolution()
	{
		int num = 0;
		AdvantureData data = AdvantureConfig.data;
		int num2 = (int)this.thePlantType;
		PlantDataManager.PlantData plantData;
		if (plantData != 0)
		{
			CustomizedPlant customizedPlant = new CustomizedPlant();
			PlantDevelopData plantDevelopData = AdvantureConfig.data.plantDevelopData;
			PlantType plantType = this.thePlantType;
			if (!plantDevelopData.TryGetCustomizedPlant(plantType, num))
			{
				CustomizedPlant originalData = this.GetOriginalData();
			}
			customizedPlant.Copy(num);
			float attackInterval = plantData.attackInterval;
			int num3 = 0;
			float num4 = attackInterval * 0.25f;
			float num5 = global::UnityEngine.Random.Range((float)num3, 0.1f);
			customizedPlant.theHealth = num;
			int num6 = plantData.maxHealth;
			int num7 = 0;
			customizedPlant.theHealth = num6;
			float num8 = global::UnityEngine.Random.Range((float)num7, 0.1f);
			customizedPlant.attackDamage = num6;
			num6 = plantData.attackDamage;
			int num9 = 0;
			customizedPlant.attackDamage = num6;
			float num10 = global::UnityEngine.Random.Range(-0.1f, (float)num9) * customizedPlant.attackInterval;
			customizedPlant.attackInterval = num10;
			if (num4 <= num10)
			{
				float attackInterval2 = plantData.attackInterval;
				if (num10 <= attackInterval2)
				{
					goto IL_00F3;
				}
			}
			num10 = num4;
			IL_00F3:
			customizedPlant.attackInterval = num10;
			CustomizedPlant customizedPlant2 = this.customizedPlant;
			int theHealth = customizedPlant.theHealth;
			customizedPlant2.theHealth = theHealth;
			CustomizedPlant customizedPlant3 = this.customizedPlant;
			int attackDamage = customizedPlant.attackDamage;
			customizedPlant3.attackDamage = attackDamage;
			CustomizedPlant customizedPlant4 = this.customizedPlant;
			float attackInterval3 = customizedPlant.attackInterval;
			customizedPlant4.attackInterval = attackInterval3;
			this.UseRolledData();
			AdvantureData data2 = AdvantureConfig.data;
			TextMeshProUGUI textMeshProUGUI = this.normalStarCount;
			AdvantureData data3 = AdvantureConfig.data;
			string text2;
			string text = "：" + text2;
			textMeshProUGUI.text = text;
			return;
		}
		PlantType plantType2 = this.thePlantType;
		Debug.LogError(string.Format("无法获取植物 {0} 的原始数据", plantType2));
		uint num11;
		GameAPP.PlaySound((int)num11, 0.5f, 1f);
		InGameText instance = InGameText.Instance;
		int num12 = 0;
		instance.ShowText("星星不足", 3f, num12 != 0);
		throw new NullReferenceException();
	}

	// Token: 0x060028E9 RID: 10473 RVA: 0x000DE328 File Offset: 0x000DC528
	[Token(Token = "0x60028E9")]
	[Address(RVA = "0x61AB20", Offset = "0x619120", VA = "0x18061AB20")]
	public void RollEvolutionGood()
	{
		int num = 0;
		AdvantureData data = AdvantureConfig.data;
		CustomizedPlant customizedPlant = new CustomizedPlant();
		PlantDevelopData plantDevelopData = AdvantureConfig.data.plantDevelopData;
		PlantType plantType = this.thePlantType;
		if (!plantDevelopData.TryGetCustomizedPlant(plantType, num))
		{
			CustomizedPlant originalData = this.GetOriginalData();
		}
		customizedPlant.Copy(num);
		int num2 = 0;
		float strikeRate = customizedPlant.strikeRate;
		int num3 = 0;
		float num4 = global::UnityEngine.Random.Range((float)num2, 0.1f);
		int num5 = 0;
		customizedPlant.strikeRate = strikeRate;
		float strikeDamage = customizedPlant.strikeDamage;
		float num6 = global::UnityEngine.Random.Range((float)num5, 0.3f);
		int num7 = 0;
		customizedPlant.strikeDamage = strikeDamage;
		float damageMultiplier = customizedPlant.damageMultiplier;
		float num8 = global::UnityEngine.Random.Range((float)num7, 0.15f);
		customizedPlant.damageMultiplier = damageMultiplier;
		float strikeRate2 = customizedPlant.strikeRate;
		int num9;
		if (num3 > (int)strikeRate2 || strikeRate2 > 1f)
		{
			num9 = 0;
		}
		float strikeDamage2 = customizedPlant.strikeDamage;
		customizedPlant.strikeRate = (float)num9;
		int num10;
		if (num3 > (int)strikeDamage2 || strikeDamage2 > 3f)
		{
			num10 = 0;
		}
		customizedPlant.strikeDamage = (float)num10;
		float damageMultiplier2 = customizedPlant.damageMultiplier;
		int num11;
		if (num3 > (int)damageMultiplier2 || damageMultiplier2 > 1.5f)
		{
			num11 = 0;
		}
		customizedPlant.damageMultiplier = (float)num11;
		this.customizedPlant.strikeRate = (float)num9;
		CustomizedPlant customizedPlant2 = this.customizedPlant;
		float strikeDamage3 = customizedPlant.strikeDamage;
		customizedPlant2.strikeDamage = strikeDamage3;
		CustomizedPlant customizedPlant3 = this.customizedPlant;
		float damageMultiplier3 = customizedPlant.damageMultiplier;
		customizedPlant3.damageMultiplier = damageMultiplier3;
		this.UseRolledData();
		AdvantureData data2 = AdvantureConfig.data;
		TextMeshProUGUI textMeshProUGUI = this.hardStarCount;
		AdvantureData data3 = AdvantureConfig.data;
		string text2;
		string text = "：" + text2;
		textMeshProUGUI.text = text;
	}

	// Token: 0x060028EA RID: 10474 RVA: 0x000DE4E8 File Offset: 0x000DC6E8
	[Token(Token = "0x60028EA")]
	[Address(RVA = "0x61BA10", Offset = "0x61A010", VA = "0x18061BA10")]
	private void UpdateText(CustomizedPlant data, TextMeshProUGUI textMesh)
	{
		ulong num2;
		do
		{
			CustomizedPlant originalData = this.GetOriginalData();
			int theHealth = data.theHealth;
			string text = string.Format("生命值：{0}", originalData);
			textMesh.text = text;
			string text3;
			string text2 = textMesh.text + text3 + "\n";
			textMesh.text = text2;
			string text4 = textMesh.text;
			int attackDamage = data.attackDamage;
			string text5 = string.Format("攻击力：{0}", text4);
			string text6 = text4 + text5;
			textMesh.text = text6;
			string text8;
			string text7 = textMesh.text + text8 + "\n";
			textMesh.text = text7;
			string text9 = textMesh.text;
			float attackInterval = data.attackInterval;
			string text10 = string.Format("攻击间隔：{0:F2}秒", text9);
			string text11 = text9 + text10;
			textMesh.text = text11;
			string text12 = textMesh.text;
			float attackInterval2 = data.attackInterval;
			ulong num;
			string diffText = this.GetDiffText(attackInterval2, num != 0UL);
			string text13 = text12 + diffText + "\n";
			textMesh.text = text13;
			string text14 = textMesh.text;
			int cost = data.cost;
			string text15 = string.Format("价格：{0}\n", text14);
			string text16 = text14 + text15;
			textMesh.text = text16;
			string text17 = textMesh.text;
			float cd = data.cd;
			string text18 = string.Format("冷却：{0:F1}秒\n", text17);
			string text19 = text17 + text18;
			textMesh.text = text19;
			string text20 = textMesh.text;
			float strikeRate = data.strikeRate;
			string text21 = string.Format("暴击率：{0:F1}%", text20);
			string text22 = text20 + text21;
			textMesh.text = text22;
			string text23 = textMesh.text;
			float strikeRate2 = data.strikeRate;
			string percentDiffText = this.GetPercentDiffText(strikeRate2);
			string text24 = text23 + percentDiffText + "\n";
			textMesh.text = text24;
			string text25 = textMesh.text;
			float strikeDamage = data.strikeDamage;
			string text26 = string.Format("暴击伤害：{0:F1}%", text25);
			string text27 = text25 + text26;
			textMesh.text = text27;
			string text28 = textMesh.text;
			float strikeDamage2 = data.strikeDamage;
			string percentDiffText2 = this.GetPercentDiffText(strikeDamage2);
			string text29 = text28 + percentDiffText2 + "\n";
			textMesh.text = text29;
			string text30 = textMesh.text;
			float damageMultiplier = data.damageMultiplier;
			string text31 = string.Format("伤害加成：{0:F1}%", text30);
			string text32 = text30 + text31;
			textMesh.text = text32;
			string text33 = textMesh.text;
			float damageMultiplier2 = data.damageMultiplier;
			string percentDiffText3 = this.GetPercentDiffText(damageMultiplier2);
			string text34 = text33 + percentDiffText3 + "\n";
			textMesh.text = text34;
			string text35 = textMesh.text + "赋能：";
			textMesh.text = text35;
			List<Empowerment> empowerments = data.empowerments;
			bool flag;
			if (flag)
			{
				string text37;
				string text36 = textMesh.text + text37 + " ";
				textMesh.text = text36;
			}
		}
		while (num2 != (ulong)0L);
		string text38 = textMesh.text + "无";
		textMesh.text = text38;
	}

	// Token: 0x060028EB RID: 10475 RVA: 0x000DE7E4 File Offset: 0x000DC9E4
	[Token(Token = "0x60028EB")]
	[Address(RVA = "0x61A7E0", Offset = "0x618DE0", VA = "0x18061A7E0")]
	private string GetDiffText(float diff, bool reverseColor = false)
	{
		int num = 0;
		if (reverseColor)
		{
		}
		string text = "";
		if (diff > (float)num)
		{
			text = "+";
		}
		if (diff == (float)num)
		{
			return string.Format(" <color={0}>({1}{2:F0})</color>", "blue", text, "");
		}
		return "";
	}

	// Token: 0x060028EC RID: 10476 RVA: 0x000DE82C File Offset: 0x000DCA2C
	[Token(Token = "0x60028EC")]
	[Address(RVA = "0x61AA10", Offset = "0x619010", VA = "0x18061AA10")]
	private string GetPercentDiffText(float diff)
	{
		return string.Format(" <color={0}>({1}{2:F1}%)</color>", "blue", "+", "");
	}

	// Token: 0x060028ED RID: 10477 RVA: 0x000DE85C File Offset: 0x000DCA5C
	[Token(Token = "0x60028ED")]
	[Address(RVA = "0x619F90", Offset = "0x618590", VA = "0x180619F90")]
	private void ApplyFromDataOrigin(CustomizedPlant data)
	{
		ulong num4;
		do
		{
			TextMeshProUGUI textMeshProUGUI = this.dataText;
			int theHealth = data.theHealth;
			string text = string.Format("生命值：{0}\n", theHealth);
			textMeshProUGUI.text = text;
			TextMeshProUGUI textMeshProUGUI2 = this.dataText;
			string text2 = textMeshProUGUI2.text;
			int attackDamage = data.attackDamage;
			string text3 = string.Format("攻击力：{0}\n", text2);
			string text4 = text2 + text3;
			textMeshProUGUI2.text = text4;
			TextMeshProUGUI textMeshProUGUI3 = this.dataText;
			string text5 = textMeshProUGUI3.text;
			float attackInterval = data.attackInterval;
			string text6 = string.Format("攻击间隔：{0}秒\n", text5);
			string text7 = text5 + text6;
			textMeshProUGUI3.text = text7;
			TextMeshProUGUI textMeshProUGUI4 = this.dataText;
			string text8 = textMeshProUGUI4.text;
			int cost = data.cost;
			string text9 = string.Format("价格：{0}\n", text8);
			string text10 = text8 + text9;
			textMeshProUGUI4.text = text10;
			TextMeshProUGUI textMeshProUGUI5 = this.dataText;
			string text11 = textMeshProUGUI5.text;
			float cd = data.cd;
			string text12 = string.Format("冷却：{0}秒\n", text11);
			string text13 = text11 + text12;
			textMeshProUGUI5.text = text13;
			TextMeshProUGUI textMeshProUGUI6 = this.dataText;
			string text14 = textMeshProUGUI6.text;
			float num = data.strikeRate * 100f;
			string text15 = string.Format("暴击率：{0:F1}%\n", text14);
			string text16 = text14 + text15;
			textMeshProUGUI6.text = text16;
			TextMeshProUGUI textMeshProUGUI7 = this.dataText;
			string text17 = textMeshProUGUI7.text;
			float num2 = data.strikeDamage * 100f;
			string text18 = string.Format("暴击伤害：{0:F1}%\n", text17);
			string text19 = text17 + text18;
			textMeshProUGUI7.text = text19;
			TextMeshProUGUI textMeshProUGUI8 = this.dataText;
			string text20 = textMeshProUGUI8.text;
			float num3 = data.damageMultiplier * 100f;
			string text21 = string.Format("伤害加成：{0:F1}%\n", text20);
			string text22 = text20 + text21;
			textMeshProUGUI8.text = text22;
			TextMeshProUGUI textMeshProUGUI9 = this.dataText;
			string text23 = textMeshProUGUI9.text + "赋能：";
			textMeshProUGUI9.text = text23;
			List<Empowerment> empowerments = data.empowerments;
			bool flag;
			if (flag)
			{
				TextMeshProUGUI textMeshProUGUI10 = this.dataText;
				string text25;
				string text24 = textMeshProUGUI10.text + text25;
				textMeshProUGUI10.text = text24;
			}
		}
		while (num4 != (ulong)0L);
		TextMeshProUGUI textMeshProUGUI11 = this.dataText;
		string text26 = textMeshProUGUI11.text + "无";
		textMeshProUGUI11.text = text26;
	}

	// Token: 0x060028EE RID: 10478 RVA: 0x000DEACC File Offset: 0x000DCCCC
	[Token(Token = "0x60028EE")]
	[Address(RVA = "0x61C320", Offset = "0x61A920", VA = "0x18061C320")]
	public void UseRolledData()
	{
		PlantDevelopData plantDevelopData = AdvantureConfig.data.plantDevelopData;
		CustomizedPlant customizedPlant = this.customizedPlant;
		plantDevelopData.CustomizePlant(customizedPlant);
		TextMeshProUGUI textMeshProUGUI = this.dataText_new;
		CustomizedPlant customizedPlant2 = this.customizedPlant;
		this.UpdateText(customizedPlant2, textMeshProUGUI);
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x060028EF RID: 10479 RVA: 0x000DEB18 File Offset: 0x000DCD18
	[Token(Token = "0x60028EF")]
	[Address(RVA = "0x61B660", Offset = "0x619C60", VA = "0x18061B660")]
	private void SetPlant(PlantType thePlantType)
	{
		int num;
		do
		{
			num = 0;
			this.thePlantType = thePlantType;
			PlantDevelopData plantDevelopData = AdvantureConfig.data.plantDevelopData;
			bool flag;
			if (!flag)
			{
				CustomizedPlant originalData = this.GetOriginalData();
				this.customizedPlant = originalData;
			}
			this.customizedPlant.Copy(num);
			GameObject gameObject = this.plantObject;
			int num2 = 0;
			if (gameObject != num2)
			{
				global::UnityEngine.Object.Destroy(this.plantObject);
			}
			bool flag2;
			if (!flag2)
			{
			}
			Transform transform = this.axis2;
			Vector3 vector;
			float z = vector.z;
			GameObject gameObject2;
			this.plantObject = gameObject2;
			this.plantObject.AddComponent<SortingGroup>().sortingLayerName = "UI";
			Transform transform2 = this.plantObject.transform;
			Transform transform3 = base.transform;
			transform2.parentInternal = transform3;
			List<TextMeshProUGUI> list = this.plantName;
			bool flag3;
			if (flag3)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x060028F0 RID: 10480 RVA: 0x000DEBF8 File Offset: 0x000DCDF8
	[Token(Token = "0x60028F0")]
	[Address(RVA = "0x61B340", Offset = "0x619940", VA = "0x18061B340")]
	private void SetPlant2(PlantType thePlantType)
	{
		ulong num2;
		do
		{
			GameObject gameObject = this.plantObject_new;
			int num = 0;
			if (gameObject != num)
			{
				global::UnityEngine.Object.Destroy(this.plantObject_new);
			}
			bool flag;
			if (!flag)
			{
			}
			Transform transform = this.axis2_new;
			Vector3 vector;
			float z = vector.z;
			GameObject gameObject2;
			this.plantObject_new = gameObject2;
			this.plantObject_new.AddComponent<SortingGroup>().sortingLayerName = "UI";
			Transform transform2 = this.plantObject_new.transform;
			Transform transform3 = base.transform;
			transform2.parentInternal = transform3;
			List<TextMeshProUGUI> list = this.plantName_new;
			bool flag2;
			if (flag2)
			{
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x060028F1 RID: 10481 RVA: 0x000DECA0 File Offset: 0x000DCEA0
	[Token(Token = "0x60028F1")]
	[Address(RVA = "0x61A950", Offset = "0x618F50", VA = "0x18061A950")]
	private CustomizedPlant GetOriginalData()
	{
		int num = (int)this.thePlantType;
		CustomizedPlant customizedPlant = new CustomizedPlant();
		PlantType plantType = this.thePlantType;
		customizedPlant.thePlantType = plantType;
		PlantDataManager.PlantData plantData;
		int attackDamage = plantData.attackDamage;
		customizedPlant.attackDamage = attackDamage;
		float attackInterval = plantData.attackInterval;
		customizedPlant.attackInterval = attackInterval;
		int maxHealth = plantData.maxHealth;
		customizedPlant.theHealth = maxHealth;
		float cd = plantData.cd;
		customizedPlant.cd = cd;
		int cost = plantData.cost;
		customizedPlant.cost = cost;
		return customizedPlant;
	}

	// Token: 0x060028F2 RID: 10482 RVA: 0x000DED24 File Offset: 0x000DCF24
	[Token(Token = "0x60028F2")]
	[Address(RVA = "0x61C3B0", Offset = "0x61A9B0", VA = "0x18061C3B0")]
	public AdvantureEvolutionMenu()
	{
		List<TextMeshProUGUI> list = new List();
		this.plantName = list;
		List<TextMeshProUGUI> list2 = new List();
		this.plantName_new = list2;
		base..ctor();
	}

	// Token: 0x0400172A RID: 5930
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400172A")]
	public PlantType thePlantType;

	// Token: 0x0400172B RID: 5931
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400172B")]
	public CustomizedPlant customizedPlant;

	// Token: 0x0400172C RID: 5932
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400172C")]
	public CustomizedPlant rolledCustomizedPlant;

	// Token: 0x0400172D RID: 5933
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400172D")]
	[Header("原来的植物")]
	public Transform axis;

	// Token: 0x0400172E RID: 5934
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400172E")]
	public Transform axis2;

	// Token: 0x0400172F RID: 5935
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400172F")]
	public List<TextMeshProUGUI> plantName;

	// Token: 0x04001730 RID: 5936
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001730")]
	public TextMeshProUGUI dataText;

	// Token: 0x04001731 RID: 5937
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001731")]
	public GameObject plantObject;

	// Token: 0x04001732 RID: 5938
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001732")]
	[Header("超进化植物")]
	public Transform axis_new;

	// Token: 0x04001733 RID: 5939
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001733")]
	public Transform axis2_new;

	// Token: 0x04001734 RID: 5940
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001734")]
	public List<TextMeshProUGUI> plantName_new;

	// Token: 0x04001735 RID: 5941
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001735")]
	public TextMeshProUGUI dataText_new;

	// Token: 0x04001736 RID: 5942
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001736")]
	public GameObject plantObject_new;

	// Token: 0x04001737 RID: 5943
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4001737")]
	public TextMeshProUGUI normalStarCount;

	// Token: 0x04001738 RID: 5944
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4001738")]
	public TextMeshProUGUI hardStarCount;
}
