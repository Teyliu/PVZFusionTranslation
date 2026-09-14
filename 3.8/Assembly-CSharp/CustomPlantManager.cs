using System;
using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x0200073A RID: 1850
[Token(Token = "0x200073A")]
public class CustomPlantManager : MonoBehaviour
{
	// Token: 0x060025A6 RID: 9638 RVA: 0x000C677C File Offset: 0x000C497C
	[Token(Token = "0x60025A6")]
	[Address(RVA = "0x5C0B10", Offset = "0x5BF110", VA = "0x1805C0B10")]
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

	// Token: 0x060025A7 RID: 9639 RVA: 0x000C67AC File Offset: 0x000C49AC
	[Token(Token = "0x60025A7")]
	[Address(RVA = "0x5C1810", Offset = "0x5BFE10", VA = "0x1805C1810")]
	private void Update()
	{
		TextMeshProUGUI textMeshProUGUI = this.abilityText;
		int num = this.CalculateAbility();
		string text = string.Format("当前能力值：{0}/100", num);
		textMeshProUGUI.text = text;
	}

	// Token: 0x060025A8 RID: 9640 RVA: 0x000C67E0 File Offset: 0x000C49E0
	[Token(Token = "0x60025A8")]
	[Address(RVA = "0x5C0C00", Offset = "0x5BF200", VA = "0x1805C0C00")]
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

	// Token: 0x060025A9 RID: 9641 RVA: 0x000C6854 File Offset: 0x000C4A54
	[Token(Token = "0x60025A9")]
	[Address(RVA = "0x5C0E30", Offset = "0x5BF430", VA = "0x1805C0E30")]
	public bool CheckSave()
	{
		return this.CalculateAbility() <= 100;
	}

	// Token: 0x060025AA RID: 9642 RVA: 0x000C6870 File Offset: 0x000C4A70
	[Token(Token = "0x60025AA")]
	[Address(RVA = "0x5C1180", Offset = "0x5BF780", VA = "0x1805C1180")]
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

	// Token: 0x060025AB RID: 9643 RVA: 0x000C695C File Offset: 0x000C4B5C
	[Token(Token = "0x60025AB")]
	[Address(RVA = "0x5C0E50", Offset = "0x5BF450", VA = "0x1805C0E50")]
	public static SavedCustomPlantData GetData()
	{
		string text = Path.Combine(SaveInfo.GetDataPath(), "CustomPlantData.json");
		if (!File.Exists(text))
		{
		}
		return JsonUtility.FromJson<SavedCustomPlantData>(File.ReadAllText(text));
	}

	// Token: 0x060025AC RID: 9644 RVA: 0x000C6994 File Offset: 0x000C4B94
	[Token(Token = "0x60025AC")]
	[Address(RVA = "0x5C10E0", Offset = "0x5BF6E0", VA = "0x1805C10E0")]
	public static void InitPlants()
	{
		SavedCustomPlantData data = CustomPlantManager.GetData();
		if (data == 0)
		{
			List<CustomPlant> list = new List();
		}
		CustomPlantManager.plants = data.customPlants;
	}

	// Token: 0x060025AD RID: 9645 RVA: 0x000C69C0 File Offset: 0x000C4BC0
	[Token(Token = "0x60025AD")]
	[Address(RVA = "0x5C1660", Offset = "0x5BFC60", VA = "0x1805C1660")]
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

	// Token: 0x060025AE RID: 9646 RVA: 0x000C6A2C File Offset: 0x000C4C2C
	[Token(Token = "0x60025AE")]
	[Address(RVA = "0x5C0F80", Offset = "0x5BF580", VA = "0x1805C0F80")]
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

	// Token: 0x060025AF RID: 9647 RVA: 0x000C6A64 File Offset: 0x000C4C64
	[Token(Token = "0x60025AF")]
	[Address(RVA = "0x5C14D0", Offset = "0x5BFAD0", VA = "0x1805C14D0")]
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

	// Token: 0x060025B0 RID: 9648 RVA: 0x000C6AC0 File Offset: 0x000C4CC0
	[Token(Token = "0x60025B0")]
	[Address(RVA = "0x5C0F10", Offset = "0x5BF510", VA = "0x1805C0F10")]
	private static string GetPath()
	{
		return Path.Combine(SaveInfo.GetDataPath(), "CustomPlantData.json");
	}

	// Token: 0x060025B1 RID: 9649 RVA: 0x000C6AE0 File Offset: 0x000C4CE0
	[Token(Token = "0x60025B1")]
	[Address(RVA = "0x5C18B0", Offset = "0x5BFEB0", VA = "0x1805C18B0")]
	public CustomPlantManager()
	{
	}

	// Token: 0x040012F7 RID: 4855
	[Token(Token = "0x40012F7")]
	public static List<CustomPlant> plants;

	// Token: 0x040012F8 RID: 4856
	[Token(Token = "0x40012F8")]
	public static CustomPlantManager Instance;

	// Token: 0x040012F9 RID: 4857
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40012F9")]
	public PlantType thePlantType;

	// Token: 0x040012FA RID: 4858
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40012FA")]
	public readonly int maxAbility = (int)((ulong)100L);

	// Token: 0x040012FB RID: 4859
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40012FB")]
	public TextMeshProUGUI abilityText;

	// Token: 0x040012FC RID: 4860
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40012FC")]
	public TMP_InputField attackDamage;

	// Token: 0x040012FD RID: 4861
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40012FD")]
	public TMP_InputField attackInterval;

	// Token: 0x040012FE RID: 4862
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40012FE")]
	public TMP_InputField theHealthText;

	// Token: 0x040012FF RID: 4863
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40012FF")]
	public TMP_InputField theCD;

	// Token: 0x04001300 RID: 4864
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001300")]
	public TMP_InputField theSun;
}
