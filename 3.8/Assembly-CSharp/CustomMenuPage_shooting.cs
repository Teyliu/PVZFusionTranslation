using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Core;
using Cpp2IlInjected;
using PlantEvolution;
using TMPro;
using UnityEngine;

// Token: 0x020009CE RID: 2510
[Token(Token = "0x20009CE")]
public class CustomMenuPage_shooting : CustomMenu_page
{
	// Token: 0x06003391 RID: 13201 RVA: 0x00111748 File Offset: 0x0010F948
	[Token(Token = "0x6003391")]
	[Address(RVA = "0x6FE270", Offset = "0x6FC870", VA = "0x1806FE270")]
	private void Awake()
	{
		ulong num2;
		do
		{
			PlantEvolutionConfigLoader.EvolutionConfig godShootingConfig = CustomMenu._levelData.GodShootingConfig;
			this.config = godShootingConfig;
			if (this.config == (ulong)0L)
			{
				PlantEvolutionConfigLoader.EvolutionConfig evolutionConfig = new PlantEvolutionConfigLoader.EvolutionConfig();
				List<PlantEvolutionConfigLoader.PlantConfigEntry> list = new List();
				evolutionConfig.plants = list;
				this.config = evolutionConfig;
			}
			GameObject gameObject = this.samplePlantInfo;
			int num = 0;
			gameObject.SetActive(num != 0);
			List<PlantEvolutionConfigLoader.PlantConfigEntry> plants = this.config.plants;
			bool flag;
			if (flag)
			{
				bool flag2;
				while (!flag2)
				{
				}
				string text;
				this.input_plantType.text = text;
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06003392 RID: 13202 RVA: 0x001117E0 File Offset: 0x0010F9E0
	[Token(Token = "0x6003392")]
	[Address(RVA = "0x700280", Offset = "0x6FE880", VA = "0x180700280")]
	public void SearchAllRoute()
	{
		ulong num3;
		do
		{
			int num = 0;
			List<PlantEvolutionConfigLoader.PlantConfigEntry> plants = this.config.plants;
			PlantEvolutionConfigLoader.EvolutionConfig evolutionConfig = this.config;
			bool flag;
			if (flag)
			{
				bool flag2;
				while (!flag2)
				{
				}
				string name = global::Lawnf.GetName((PlantType)num);
				int num2;
				string text = string.Format("{0}({1}) ", name, num2);
				string text2 = "当前全部基础植物：" + text;
			}
		}
		while (num3 != (ulong)0L);
		InGameText instance = InGameText.Instance;
		int num4 = 0;
		string text3;
		instance.ShowText(text3, 5f, num4 != 0);
	}

	// Token: 0x06003393 RID: 13203 RVA: 0x00111898 File Offset: 0x0010FA98
	[Token(Token = "0x6003393")]
	[Address(RVA = "0x700570", Offset = "0x6FEB70", VA = "0x180700570")]
	public void SearchRoute()
	{
		int num;
		do
		{
			num = 0;
			if (!this.CheckInput((PlantType)num))
			{
				return;
			}
			this.ClearShow();
			List<PlantEvolutionConfigLoader.PlantConfigEntry> plants = this.config.plants;
			bool flag;
			if (flag)
			{
				bool flag2;
				while (!flag2)
				{
				}
				PlantEvolutionConfigLoader.RouteConfig routeConfig;
				PlantEvolutionConfigLoader.StageConfig stageConfig = routeConfig.stages[num];
				int num2 = routeConfig.stageCost[num];
				PlantType plantType = Enum.Parse<PlantType>(stageConfig.plantType);
				num++;
				List<PlantEvolutionConfigLoader.StageConfig> stages = routeConfig.stages;
			}
		}
		while (num != 0);
		InGameText instance = InGameText.Instance;
		int num3 = 0;
		instance.ShowText("已有编号中未包含此植物，点击“新建路线”新建一个", 3f, num3 != 0);
		GameAPP.PlaySound(26, 0.5f, 1f);
	}

	// Token: 0x06003394 RID: 13204 RVA: 0x00111988 File Offset: 0x0010FB88
	[Token(Token = "0x6003394")]
	[Address(RVA = "0x6FEC10", Offset = "0x6FD210", VA = "0x1806FEC10")]
	public void CreateRoute()
	{
		int num;
		do
		{
			num = 0;
			if (!this.CheckInput((PlantType)num))
			{
				return;
			}
			List<PlantEvolutionConfigLoader.PlantConfigEntry> plants = this.config.plants;
			bool flag;
			if (flag)
			{
				bool flag2;
				while (!flag2)
				{
				}
				InGameText instance = InGameText.Instance;
				int num2 = 0;
				instance.ShowText("已经有该路线了，点击“查询路线”操作", 3f, num2 != 0);
				GameAPP.PlaySound(26, 0.5f, 1f);
			}
		}
		while (num != 0);
		PlantEvolutionConfigLoader.PlantConfigEntry plantConfigEntry = new PlantEvolutionConfigLoader.PlantConfigEntry();
		string text;
		plantConfigEntry.key = text;
		PlantEvolutionConfigLoader.PlantEvolutionConfig plantEvolutionConfig = new PlantEvolutionConfigLoader.PlantEvolutionConfig();
		plantEvolutionConfig.basePlant = text;
		plantConfigEntry.value = plantEvolutionConfig;
		plantConfigEntry.value = plantEvolutionConfig;
		PlantEvolutionConfigLoader.PlantEvolutionConfig value = plantConfigEntry.value;
		List<PlantEvolutionConfigLoader.RouteConfig> list = new List();
		value.routes = list;
		PlantEvolutionConfigLoader.RouteConfig routeConfig = new PlantEvolutionConfigLoader.RouteConfig();
		string text2 = "自定义路线：" + text;
		routeConfig.routeName = text2;
		List<PlantEvolutionConfigLoader.StageConfig> list2 = new List();
		routeConfig.stages = list2;
		List<int> list3 = new List();
		routeConfig.stageCost = list3;
		List<PlantEvolutionConfigLoader.RouteConfig> routes = plantConfigEntry.value.routes;
		int size = routes._size;
		routes._size = list3;
		PlantEvolutionConfigLoader.StageConfig stageConfig = new PlantEvolutionConfigLoader.StageConfig();
		stageConfig.plantType = text;
		List<PlantEvolutionConfigLoader.StageConfig> stages = routeConfig.stages;
		List<int> stageCost = routeConfig.stageCost;
		int size2 = stageCost._size;
		stageCost._size = stageConfig;
	}

	// Token: 0x06003395 RID: 13205 RVA: 0x00111AF0 File Offset: 0x0010FCF0
	[Token(Token = "0x6003395")]
	[Address(RVA = "0x6FF2A0", Offset = "0x6FD8A0", VA = "0x1806FF2A0")]
	public void CreateStage()
	{
		int num = 0;
		if (this.CheckInput((PlantType)num))
		{
			string text;
			string thePlantType = text;
			if (this.currentType == PlantType.Nothing)
			{
				GameAPP.PlaySound(26, 0.5f, 1f);
				InGameText instance = InGameText.Instance;
				throw new NullReferenceException();
			}
			Func<PlantEvolutionConfigLoader.PlantConfigEntry, bool> func;
			PlantEvolutionConfigLoader.PlantConfigEntry plantConfigEntry = Enumerable.FirstOrDefault<PlantEvolutionConfigLoader.PlantConfigEntry>(this.config.plants, func);
			if (plantConfigEntry != 0)
			{
				List<PlantEvolutionConfigLoader.RouteConfig> routes = plantConfigEntry.value.routes;
				int num2 = 0;
				PlantEvolutionConfigLoader.RouteConfig routeConfig = routes[num2];
				Func<PlantEvolutionConfigLoader.StageConfig, bool> func2;
				if (Enumerable.FirstOrDefault<PlantEvolutionConfigLoader.StageConfig>(routeConfig.stages, func2) == 0)
				{
					string text2;
					new PlantEvolutionConfigLoader.StageConfig().plantType = text2;
					List<PlantEvolutionConfigLoader.StageConfig> stages = routeConfig.stages;
					List<int> stageCost = routeConfig.stageCost;
					PlantType plantType = this.currentType;
					string text3;
					this.input_plantType.text = text3;
					this.SearchRoute();
				}
				InGameText instance2 = InGameText.Instance;
				int num3 = 0;
				instance2.ShowText("请勿新增重复植物", 3f, num3 != 0);
				GameAPP.PlaySound(26, 0.5f, 1f);
			}
			GameAPP.PlaySound(26, 0.5f, 1f);
			InGameText instance3 = InGameText.Instance;
			int num4 = 0;
			instance3.ShowText("路线异常，请检查存档文件", 3f, num4 != 0);
		}
	}

	// Token: 0x06003396 RID: 13206 RVA: 0x00111C34 File Offset: 0x0010FE34
	[Token(Token = "0x6003396")]
	[Address(RVA = "0x6FF730", Offset = "0x6FDD30", VA = "0x1806FF730")]
	public void DeleteRoute()
	{
		bool flag;
		if (flag)
		{
			Predicate<PlantEvolutionConfigLoader.PlantConfigEntry> predicate;
			int num = this.config.plants.RemoveAll(predicate);
			InGameText instance = InGameText.Instance;
			PlantType inputType;
			string name = global::Lawnf.GetName(inputType);
			string text = "已移除路线：" + name;
			int num2 = 0;
			instance.ShowText(text, 3f, num2 != 0);
			this.ClearShow();
		}
	}

	// Token: 0x06003397 RID: 13207 RVA: 0x00111CA4 File Offset: 0x0010FEA4
	[Token(Token = "0x6003397")]
	[Address(RVA = "0x6FF890", Offset = "0x6FDE90", VA = "0x1806FF890")]
	public void SaveCurent()
	{
		int num;
		PlantEvolutionConfigLoader.PlantConfigEntry plantConfigEntry;
		List<Transform> list;
		do
		{
			num = 0;
			if (!this.CheckInput((PlantType)num))
			{
				return;
			}
			List<PlantEvolutionConfigLoader.PlantConfigEntry> plants = this.config.plants;
			plantConfigEntry = this.config.plants[num];
			if (!Enum.TryParse<PlantType>(plantConfigEntry.key, (PlantType)num))
			{
				goto IL_0280;
			}
			List<PlantEvolutionConfigLoader.RouteConfig> routes = plantConfigEntry.value.routes;
			list = new List();
			IEnumerator enumerator = this.samplePlantInfo.transform.parent.GetEnumerator();
			if (enumerator != 0)
			{
				GameObject gameObject = this.samplePlantInfo;
				GameObject gameObject2;
				if (!(gameObject2 != gameObject))
				{
					continue;
				}
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
		int num2 = 0;
		List<PlantEvolutionConfigLoader.RouteConfig> routes2 = plantConfigEntry.value.routes;
		int num3 = 0;
		PlantEvolutionConfigLoader.RouteConfig routeConfig = routes2[num3];
		int size = routeConfig.stages._size;
		InGameText instance = InGameText.Instance;
		int size2 = list._size;
		int size3 = routeConfig.stages._size;
		string text = string.Format("警告：面板数量({0})与阶段数量({1})不匹配", instance, instance);
		int num4 = 0;
		instance.ShowText(text, 3f, num4 != 0);
		int size4 = list._size;
		List<PlantEvolutionConfigLoader.StageConfig> stages = routeConfig.stages;
		int num5;
		if (num2 < num5)
		{
			uint num6;
			Transform child = list[num2].GetChild((int)num6);
			int childCount = child.childCount;
			PlantEvolutionConfigLoader.StageConfig stageConfig = routeConfig.stages[num2];
			int num7 = 0;
			if (int.TryParse(child.GetChild(num7).GetComponentInChildren<TMP_InputField>().m_Text, num))
			{
				stageConfig.attackDamage = num;
			}
			uint num8;
			if (float.TryParse(child.GetChild((int)num8).GetComponentInChildren<TMP_InputField>().m_Text, (float)num))
			{
				stageConfig.attackInterval = (float)num;
			}
			uint num9;
			if (int.TryParse(child.GetChild((int)num9).GetComponentInChildren<TMP_InputField>().m_Text, num))
			{
				stageConfig.maxHealth = num;
			}
			uint num10;
			if (int.TryParse(child.GetChild((int)num10).GetComponentInChildren<TMP_InputField>().m_Text, num))
			{
				stageConfig.attackSpeedAdder = num;
			}
			uint num11;
			if (int.TryParse(child.GetChild((int)num11).GetComponentInChildren<TMP_InputField>().m_Text, num))
			{
				routeConfig.stageCost[num2] = num;
			}
			num2++;
			num2++;
			int num12;
			Debug.LogWarning(string.Format("面板 {0} 的输入框数量不足", num12));
			num2++;
		}
		CustomMenu._levelData.GodShootingConfig = num2;
		InGameText instance2 = InGameText.Instance;
		int num13;
		string text2 = string.Format("保存成功！已更新 {0} 个阶段的数据", num13);
		int num14 = 0;
		instance2.ShowText(text2, 4f, num14 != 0);
		return;
		IL_0280:
		PlantEvolutionConfigLoader.EvolutionConfig evolutionConfig = this.config;
		InGameText instance3 = InGameText.Instance;
		int num15 = 0;
		instance3.ShowText("未找到该植物的路线配置", 3f, num15 != 0);
		uint num16;
		GameAPP.PlaySound((int)num16, 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x06003398 RID: 13208 RVA: 0x00111F88 File Offset: 0x00110188
	[Token(Token = "0x6003398")]
	[Address(RVA = "0x6FE530", Offset = "0x6FCB30", VA = "0x1806FE530")]
	private bool CheckInput([Out] PlantType thePlantType)
	{
		ulong num;
		if (int.TryParse(this.input_plantType.m_Text, (int)num))
		{
			int num2;
			if (Enum.IsDefined(typeof(PlantType), num2))
			{
				thePlantType.value__ = (int)num;
				return true;
			}
			InGameText instance = InGameText.Instance;
		}
		InGameText instance2 = InGameText.Instance;
		int num3 = 0;
		instance2.ShowText("输入植物类型不合法，请输入正整数", 3f, num3 != 0);
		GameAPP.PlaySound(26, 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x06003399 RID: 13209 RVA: 0x00112008 File Offset: 0x00110208
	[Token(Token = "0x6003399")]
	[Address(RVA = "0x6FE9B0", Offset = "0x6FCFB0", VA = "0x1806FE9B0")]
	private void CreatePlantInfoEditor(PlantType thePlantType, PlantEvolutionConfigLoader.StageConfig config, int cost)
	{
		ulong num;
		this.samplePlantInfo.SetActive(num != 0UL);
		GameObject gameObject = this.samplePlantInfo;
		Transform parent = gameObject.transform.parent;
		GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, parent);
		GameObject gameObject3 = this.samplePlantInfo;
		int num2 = 0;
		gameObject3.SetActive(num2 != 0);
		Transform transform = gameObject2.transform;
		int num3 = 0;
		string text;
		transform.GetChild(num3).GetComponent<TextMeshProUGUI>().text = text;
		uint num4;
		Transform child = gameObject2.transform.GetChild((int)num4);
		int num5 = 0;
		int childCount = child.childCount;
		if (num5 < childCount)
		{
			TMP_InputField componentInChildren = child.GetChild(num5).GetComponentInChildren<TMP_InputField>();
			if (num5 == 0 || num5 == 0 || num5 == 0 || num5 == 0 || num5 == 1)
			{
				string text2;
				componentInChildren.text = text2;
			}
			num5++;
		}
	}

	// Token: 0x0600339A RID: 13210 RVA: 0x001120D8 File Offset: 0x001102D8
	[Token(Token = "0x600339A")]
	[Address(RVA = "0x6FE6F0", Offset = "0x6FCCF0", VA = "0x1806FE6F0")]
	private void ClearShow()
	{
		int num;
		do
		{
			num = 0;
			IEnumerator enumerator = this.samplePlantInfo.transform.parent.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				enumerator += enumerator;
				GameObject gameObject = this.samplePlantInfo;
				GameObject gameObject2;
				if (!(gameObject2 != gameObject))
				{
					continue;
				}
				GameObject gameObject3;
				global::UnityEngine.Object.Destroy(gameObject3);
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x0600339B RID: 13211 RVA: 0x00112158 File Offset: 0x00110358
	[Token(Token = "0x600339B")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public CustomMenuPage_shooting()
	{
	}

	// Token: 0x04002514 RID: 9492
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002514")]
	public TMP_InputField input_plantType;

	// Token: 0x04002515 RID: 9493
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002515")]
	public GameObject samplePlantInfo;

	// Token: 0x04002516 RID: 9494
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002516")]
	public RectTransform scollContent;

	// Token: 0x04002517 RID: 9495
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002517")]
	private PlantEvolutionConfigLoader.EvolutionConfig config;

	// Token: 0x04002518 RID: 9496
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002518")]
	private PlantType currentType;
}
