using System;
using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000773 RID: 1907
[Token(Token = "0x2000773")]
public class CustomPlantManager : MonoBehaviour
{
	// Token: 0x060026CB RID: 9931 RVA: 0x000CB660 File Offset: 0x000C9860
	[Token(Token = "0x60026CB")]
	[Address(RVA = "0x621690", Offset = "0x61FC90", VA = "0x180621690")]
	private void Awake()
	{
		CustomPlantManager.Instance = this;
		SavedCustomPlantData data = CustomPlantManager.GetData();
		if (data == 0)
		{
			List<CustomPlant> list = new List();
		}
		CustomPlantManager.plants = data.customPlants;
	}

	// Token: 0x060026CC RID: 9932 RVA: 0x000CB690 File Offset: 0x000C9890
	[Token(Token = "0x60026CC")]
	[Address(RVA = "0x622390", Offset = "0x620990", VA = "0x180622390")]
	private void Update()
	{
		TextMeshProUGUI textMeshProUGUI = this.abilityText;
		int num = this.CalculateAbility();
		string text = string.Format("当前能力值：{0}/100", num);
		textMeshProUGUI.text = text;
	}

	// Token: 0x060026CD RID: 9933 RVA: 0x000CB6C4 File Offset: 0x000C98C4
	[Token(Token = "0x60026CD")]
	[Address(RVA = "0x621780", Offset = "0x61FD80", VA = "0x180621780")]
	private int CalculateAbility()
	{
		int num = 0;
		string text = this.attackDamage.m_Text;
		bool flag = int.TryParse(this.attackInterval.m_Text, num);
		bool flag2 = int.TryParse(this.theHealthText.m_Text, num);
		string text2 = this.theCD.m_Text;
		string text3 = this.theSun.m_Text;
		bool flag3;
		if (flag == flag3)
		{
			return 0;
		}
		if (flag == flag3 || flag != flag3)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x060026CE RID: 9934 RVA: 0x000CB738 File Offset: 0x000C9938
	[Token(Token = "0x60026CE")]
	[Address(RVA = "0x6219B0", Offset = "0x61FFB0", VA = "0x1806219B0")]
	public bool CheckSave()
	{
		return this.CalculateAbility() <= 100;
	}

	// Token: 0x060026CF RID: 9935 RVA: 0x000CB754 File Offset: 0x000C9954
	[Token(Token = "0x60026CF")]
	[Address(RVA = "0x621D00", Offset = "0x620300", VA = "0x180621D00")]
	public static void SaveData(CustomPlant plant)
	{
		List<CustomPlant> list = CustomPlantManager.plants;
		int size = list._size;
		list._size = (int)((ulong)0L);
		if (size > 0)
		{
		}
		PlantType plantType = plant.thePlantType;
		SavedCustomPlantData data = CustomPlantManager.GetData();
		if (data != 0)
		{
			CustomPlantManager.plants = data.customPlants;
		}
		int size2 = CustomPlantManager.plants._size;
		int num = size2 - 1;
		if (size2 > 0 && CustomPlantManager.plants[num].thePlantType == plantType)
		{
			CustomPlantManager.plants.RemoveAt(num);
		}
		int size3 = CustomPlantManager.plants._size;
		SavedCustomPlantData savedCustomPlantData = new SavedCustomPlantData();
		List<CustomPlant> list2 = CustomPlantManager.plants;
		savedCustomPlantData.customPlants = list2;
		string text = JsonUtility.ToJson(savedCustomPlantData);
		DirectoryInfo directoryInfo = Directory.CreateDirectory(Path.GetDirectoryName(Path.Combine(SaveInfo.GetDataPath(), "CustomPlantData.json")));
		File.WriteAllText(Path.Combine(SaveInfo.GetDataPath(), "CustomPlantData.json"), text);
	}

	// Token: 0x060026D0 RID: 9936 RVA: 0x000CB840 File Offset: 0x000C9A40
	[Token(Token = "0x60026D0")]
	[Address(RVA = "0x6219D0", Offset = "0x61FFD0", VA = "0x1806219D0")]
	public static SavedCustomPlantData GetData()
	{
		string text = Path.Combine(SaveInfo.GetDataPath(), "CustomPlantData.json");
		if (!File.Exists(text))
		{
		}
		return JsonUtility.FromJson<SavedCustomPlantData>(File.ReadAllText(text));
	}

	// Token: 0x060026D1 RID: 9937 RVA: 0x000CB878 File Offset: 0x000C9A78
	[Token(Token = "0x60026D1")]
	[Address(RVA = "0x621C60", Offset = "0x620260", VA = "0x180621C60")]
	public static void InitPlants()
	{
		SavedCustomPlantData data = CustomPlantManager.GetData();
		if (data == 0)
		{
			List<CustomPlant> list = new List();
		}
		CustomPlantManager.plants = data.customPlants;
	}

	// Token: 0x060026D2 RID: 9938 RVA: 0x000CB8A4 File Offset: 0x000C9AA4
	[Token(Token = "0x60026D2")]
	[Address(RVA = "0x6221E0", Offset = "0x6207E0", VA = "0x1806221E0")]
	public static bool SetCustomPlant(Plant plant)
	{
		bool flag;
		for (;;)
		{
			CustomPlantManager.InitPlants();
			List<CustomPlant> list = CustomPlantManager.plants;
			if (flag)
			{
				break;
			}
			ulong num;
			if (num == (ulong)0L)
			{
				goto Block_1;
			}
		}
		while ((flag ? PlantType.SunFlower : PlantType.Peashooter) != plant.thePlantType)
		{
		}
		plant.attackDamage = (flag ? 1 : 0);
		plant.thePlantMaxHealth = (flag ? 1 : 0);
		plant.thePlantHealth = (flag ? 1 : 0);
		plant.thePlantAttackInterval = flag;
		return true;
		Block_1:
		throw new NullReferenceException();
	}

	// Token: 0x060026D3 RID: 9939 RVA: 0x000CB910 File Offset: 0x000C9B10
	[Token(Token = "0x60026D3")]
	[Address(RVA = "0x621B00", Offset = "0x620100", VA = "0x180621B00")]
	public static CustomPlant GetPlantData(PlantType thePlantType)
	{
		ulong num;
		do
		{
			List<CustomPlant> list = CustomPlantManager.plants;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
		throw new NullReferenceException();
	}

	// Token: 0x060026D4 RID: 9940 RVA: 0x000CB948 File Offset: 0x000C9B48
	[Token(Token = "0x60026D4")]
	[Address(RVA = "0x622050", Offset = "0x620650", VA = "0x180622050")]
	public static bool SetCustomCard(CardUI card)
	{
		bool flag;
		for (;;)
		{
			CustomPlantManager.InitPlants();
			List<CustomPlant> list = CustomPlantManager.plants;
			if (flag)
			{
				break;
			}
			ulong num;
			if (num == (ulong)0L)
			{
				goto Block_1;
			}
		}
		while ((flag ? PlantType.SunFlower : PlantType.Peashooter) != card.thePlantType)
		{
		}
		card.theSeedCost = (flag ? 1 : 0);
		card.fullCD = flag;
		return true;
		Block_1:
		throw new NullReferenceException();
	}

	// Token: 0x060026D5 RID: 9941 RVA: 0x000CB9A4 File Offset: 0x000C9BA4
	[Token(Token = "0x60026D5")]
	[Address(RVA = "0x621A90", Offset = "0x620090", VA = "0x180621A90")]
	private static string GetPath()
	{
		return Path.Combine(SaveInfo.GetDataPath(), "CustomPlantData.json");
	}

	// Token: 0x060026D6 RID: 9942 RVA: 0x000CB9C4 File Offset: 0x000C9BC4
	[Token(Token = "0x60026D6")]
	[Address(RVA = "0x622430", Offset = "0x620A30", VA = "0x180622430")]
	public CustomPlantManager()
	{
	}

	// Token: 0x040013CD RID: 5069
	[Token(Token = "0x40013CD")]
	public static List<CustomPlant> plants;

	// Token: 0x040013CE RID: 5070
	[Token(Token = "0x40013CE")]
	public static CustomPlantManager Instance;

	// Token: 0x040013CF RID: 5071
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40013CF")]
	public PlantType thePlantType;

	// Token: 0x040013D0 RID: 5072
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40013D0")]
	public readonly int maxAbility = (int)((ulong)100L);

	// Token: 0x040013D1 RID: 5073
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40013D1")]
	public TextMeshProUGUI abilityText;

	// Token: 0x040013D2 RID: 5074
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40013D2")]
	public TMP_InputField attackDamage;

	// Token: 0x040013D3 RID: 5075
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40013D3")]
	public TMP_InputField attackInterval;

	// Token: 0x040013D4 RID: 5076
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40013D4")]
	public TMP_InputField theHealthText;

	// Token: 0x040013D5 RID: 5077
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40013D5")]
	public TMP_InputField theCD;

	// Token: 0x040013D6 RID: 5078
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40013D6")]
	public TMP_InputField theSun;
}
