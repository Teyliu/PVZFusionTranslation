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

// Token: 0x02000A0A RID: 2570
[Token(Token = "0x2000A0A")]
public class CustomMenuPage_shooting : CustomMenu_page
{
	// Token: 0x060034C5 RID: 13509 RVA: 0x00116790 File Offset: 0x00114990
	[Token(Token = "0x60034C5")]
	[Address(RVA = "0x763690", Offset = "0x761C90", VA = "0x180763690")]
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

	// Token: 0x060034C6 RID: 13510 RVA: 0x00116828 File Offset: 0x00114A28
	[Token(Token = "0x60034C6")]
	[Address(RVA = "0x765760", Offset = "0x763D60", VA = "0x180765760")]
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
	}

	// Token: 0x060034C7 RID: 13511 RVA: 0x001168B8 File Offset: 0x00114AB8
	[Token(Token = "0x60034C7")]
	[Address(RVA = "0x765A70", Offset = "0x764070", VA = "0x180765A70")]
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
		GameAPP.PlaySound(26, 0.5f, 1f);
	}

	// Token: 0x060034C8 RID: 13512 RVA: 0x00116990 File Offset: 0x00114B90
	[Token(Token = "0x60034C8")]
	[Address(RVA = "0x764040", Offset = "0x762640", VA = "0x180764040")]
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

	// Token: 0x060034C9 RID: 13513 RVA: 0x00116AE4 File Offset: 0x00114CE4
	[Token(Token = "0x60034C9")]
	[Address(RVA = "0x7646E0", Offset = "0x762CE0", VA = "0x1807646E0")]
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
			List<PlantEvolutionConfigLoader.PlantConfigEntry> plants = this.config.plants;
			Func<PlantEvolutionConfigLoader.PlantConfigEntry, bool> func = delegate(PlantEvolutionConfigLoader.PlantConfigEntry p)
			{
				CustomMenuPage_shooting <>4__this = this;
				string key = p.key;
				PlantType plantType2 = <>4__this.currentType;
				string text4;
				return string.Equals(key, text4);
			};
			PlantEvolutionConfigLoader.PlantConfigEntry plantConfigEntry = Enumerable.FirstOrDefault<PlantEvolutionConfigLoader.PlantConfigEntry>(plants, func);
			if (plantConfigEntry != 0)
			{
				List<PlantEvolutionConfigLoader.RouteConfig> routes = plantConfigEntry.value.routes;
				int num2 = 0;
				PlantEvolutionConfigLoader.RouteConfig routeConfig = routes[num2];
				List<PlantEvolutionConfigLoader.StageConfig> stages = routeConfig.stages;
				Func<PlantEvolutionConfigLoader.StageConfig, bool> func2 = delegate(PlantEvolutionConfigLoader.StageConfig a)
				{
					string thePlantType2 = thePlantType;
					return string.Equals(a.plantType, thePlantType2);
				};
				if (Enumerable.FirstOrDefault<PlantEvolutionConfigLoader.StageConfig>(stages, func2) == 0)
				{
					string text2;
					new PlantEvolutionConfigLoader.StageConfig().plantType = text2;
					List<PlantEvolutionConfigLoader.StageConfig> stages2 = routeConfig.stages;
					List<int> stageCost = routeConfig.stageCost;
					PlantType plantType = this.currentType;
					string text3;
					this.input_plantType.text = text3;
					this.SearchRoute();
				}
				InGameText instance2 = InGameText.Instance;
				GameAPP.PlaySound(26, 0.5f, 1f);
			}
			GameAPP.PlaySound(26, 0.5f, 1f);
			InGameText instance3 = InGameText.Instance;
		}
	}

	// Token: 0x060034CA RID: 13514 RVA: 0x00116C20 File Offset: 0x00114E20
	[Token(Token = "0x60034CA")]
	[Address(RVA = "0x764BA0", Offset = "0x7631A0", VA = "0x180764BA0")]
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
			this.ClearShow();
		}
	}

	// Token: 0x060034CB RID: 13515 RVA: 0x00116C7C File Offset: 0x00114E7C
	[Token(Token = "0x60034CB")]
	[Address(RVA = "0x764D10", Offset = "0x763310", VA = "0x180764D10")]
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
				goto IL_0244;
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
		int size4 = list._size;
		List<PlantEvolutionConfigLoader.StageConfig> stages = routeConfig.stages;
		int num4;
		if (num2 < num4)
		{
			uint num5;
			Transform child = list[num2].GetChild((int)num5);
			int childCount = child.childCount;
			PlantEvolutionConfigLoader.StageConfig stageConfig = routeConfig.stages[num2];
			int num6 = 0;
			if (int.TryParse(child.GetChild(num6).GetComponentInChildren<TMP_InputField>().m_Text, num))
			{
				stageConfig.attackDamage = num;
			}
			uint num7;
			if (float.TryParse(child.GetChild((int)num7).GetComponentInChildren<TMP_InputField>().m_Text, (float)num))
			{
				stageConfig.attackInterval = (float)num;
			}
			uint num8;
			if (int.TryParse(child.GetChild((int)num8).GetComponentInChildren<TMP_InputField>().m_Text, num))
			{
				stageConfig.maxHealth = num;
			}
			uint num9;
			if (int.TryParse(child.GetChild((int)num9).GetComponentInChildren<TMP_InputField>().m_Text, num))
			{
				stageConfig.attackSpeedAdder = num;
			}
			uint num10;
			if (int.TryParse(child.GetChild((int)num10).GetComponentInChildren<TMP_InputField>().m_Text, num))
			{
				routeConfig.stageCost[num2] = num;
			}
			num2++;
			num2++;
			int num11;
			Debug.LogWarning(string.Format("面板 {0} 的输入框数量不足", num11));
			num2++;
		}
		CustomMenu._levelData.GodShootingConfig = num2;
		InGameText instance2 = InGameText.Instance;
		int num12;
		string text2 = string.Format("保存成功！已更新 {0} 个阶段的数据", num12);
		return;
		IL_0244:
		PlantEvolutionConfigLoader.EvolutionConfig evolutionConfig = this.config;
		InGameText instance3 = InGameText.Instance;
		uint num13;
		GameAPP.PlaySound((int)num13, 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x060034CC RID: 13516 RVA: 0x00116F10 File Offset: 0x00115110
	[Token(Token = "0x60034CC")]
	[Address(RVA = "0x763950", Offset = "0x761F50", VA = "0x180763950")]
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
		GameAPP.PlaySound(26, 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x060034CD RID: 13517 RVA: 0x00116F7C File Offset: 0x0011517C
	[Token(Token = "0x60034CD")]
	[Address(RVA = "0x763DE0", Offset = "0x7623E0", VA = "0x180763DE0")]
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

	// Token: 0x060034CE RID: 13518 RVA: 0x0011704C File Offset: 0x0011524C
	[Token(Token = "0x60034CE")]
	[Address(RVA = "0x763B20", Offset = "0x762120", VA = "0x180763B20")]
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

	// Token: 0x060034CF RID: 13519 RVA: 0x001170CC File Offset: 0x001152CC
	[Token(Token = "0x60034CF")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public CustomMenuPage_shooting()
	{
	}

	// Token: 0x04002626 RID: 9766
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002626")]
	public TMP_InputField input_plantType;

	// Token: 0x04002627 RID: 9767
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002627")]
	public GameObject samplePlantInfo;

	// Token: 0x04002628 RID: 9768
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002628")]
	public RectTransform scollContent;

	// Token: 0x04002629 RID: 9769
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002629")]
	private PlantEvolutionConfigLoader.EvolutionConfig config;

	// Token: 0x0400262A RID: 9770
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400262A")]
	private PlantType currentType;
}
