using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020009DD RID: 2525
[Token(Token = "0x20009DD")]
public class SynergyManager : MonoBehaviour
{
	// Token: 0x17000215 RID: 533
	// (get) Token: 0x060033E2 RID: 13282 RVA: 0x001143B8 File Offset: 0x001125B8
	[Token(Token = "0x17000215")]
	public static SynergyManager Instance
	{
		[Token(Token = "0x60033E2")]
		[Address(RVA = "0x71D180", Offset = "0x71B780", VA = "0x18071D180")]
		get
		{
			SynergyManager instance = SynergyManager._instance;
			int num = 0;
			if (instance == num)
			{
				GameObject gameObject = new GameObject("SynergyManager");
				SynergyManager._instance = gameObject.AddComponent<SynergyManager>();
				global::UnityEngine.Object.DontDestroyOnLoad(gameObject);
			}
			return SynergyManager._instance;
		}
	}

	// Token: 0x060033E3 RID: 13283 RVA: 0x00114400 File Offset: 0x00112600
	[Token(Token = "0x60033E3")]
	[Address(RVA = "0x71AD50", Offset = "0x719350", VA = "0x18071AD50")]
	private void Awake()
	{
		SynergyManager instance = SynergyManager._instance;
		int num = 0;
		if (instance != num && SynergyManager._instance != this)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		SynergyManager._instance = this;
		this.InitializePlantSynergies();
	}

	// Token: 0x060033E4 RID: 13284 RVA: 0x00114448 File Offset: 0x00112648
	[Token(Token = "0x60033E4")]
	[Address(RVA = "0x71B790", Offset = "0x719D90", VA = "0x18071B790")]
	private void InitializePlantSynergies()
	{
		this._plantSynergies.Clear();
		this.AddPlantSynergy((PlantType)((uint)900), (SynergyType)((uint)2));
		this.AddPlantSynergy((PlantType)((uint)900), (SynergyType)((uint)18));
		this.AddPlantSynergy((PlantType)((uint)901), (SynergyType)((uint)1));
		this.AddPlantSynergy((PlantType)((uint)901), (SynergyType)((uint)9));
		this.AddPlantSynergy((PlantType)((uint)901), (SynergyType)((uint)8));
		this.AddPlantSynergy((PlantType)((uint)902), (SynergyType)((uint)3));
		this.AddPlantSynergy((PlantType)((uint)902), (SynergyType)((uint)9));
		this.AddPlantSynergy((PlantType)((uint)902), (SynergyType)((uint)17));
		this.AddPlantSynergy((PlantType)((uint)903), (SynergyType)((uint)1));
		this.AddPlantSynergy((PlantType)((uint)903), (SynergyType)((uint)12));
		this.AddPlantSynergy((PlantType)((uint)904), (SynergyType)((uint)2));
		this.AddPlantSynergy((PlantType)((uint)904), (SynergyType)((uint)15));
		this.AddPlantSynergy((PlantType)((uint)904), (SynergyType)((uint)13));
		this.AddPlantSynergy((PlantType)((uint)905), (SynergyType)((uint)1));
		this.AddPlantSynergy((PlantType)((uint)905), (SynergyType)((uint)11));
		this.AddPlantSynergy((PlantType)((uint)906), (SynergyType)((uint)3));
		this.AddPlantSynergy((PlantType)((uint)906), (SynergyType)((uint)14));
		this.AddPlantSynergy((PlantType)((uint)907), (SynergyType)((uint)1));
		this.AddPlantSynergy((PlantType)((uint)907), (SynergyType)((uint)9));
		this.AddPlantSynergy((PlantType)((uint)908), (SynergyType)((uint)2));
		this.AddPlantSynergy((PlantType)((uint)908), (SynergyType)((uint)15));
		this.AddPlantSynergy((PlantType)((uint)901), (SynergyType)((uint)8));
		this.AddPlantSynergy((PlantType)((uint)909), (SynergyType)((uint)7));
		this.AddPlantSynergy((PlantType)((uint)909), (SynergyType)((uint)10));
		this.AddPlantSynergy((PlantType)((uint)901), (SynergyType)((uint)8));
		this.AddPlantSynergy((PlantType)((uint)910), (SynergyType)((uint)2));
		this.AddPlantSynergy((PlantType)((uint)910), (SynergyType)((uint)15));
		this.AddPlantSynergy((PlantType)((uint)910), (SynergyType)((uint)9));
		this.AddPlantSynergy((PlantType)((uint)911), (SynergyType)((uint)4));
		this.AddPlantSynergy((PlantType)((uint)911), (SynergyType)((uint)10));
		this.AddPlantSynergy((PlantType)((uint)913), (SynergyType)((uint)3));
		this.AddPlantSynergy((PlantType)((uint)913), (SynergyType)((uint)12));
		this.AddPlantSynergy((PlantType)((uint)914), (SynergyType)((uint)5));
		this.AddPlantSynergy((PlantType)((uint)914), (SynergyType)((uint)16));
		this.AddPlantSynergy((PlantType)((uint)915), (SynergyType)((uint)5));
		this.AddPlantSynergy((PlantType)((uint)915), (SynergyType)((uint)15));
		this.AddPlantSynergy((PlantType)((uint)915), (SynergyType)((uint)9));
		this.AddPlantSynergy((PlantType)((uint)916), (SynergyType)((uint)5));
		this.AddPlantSynergy((PlantType)((uint)916), (SynergyType)((uint)11));
		this.AddPlantSynergy((PlantType)((uint)917), (SynergyType)((uint)2));
		this.AddPlantSynergy((PlantType)((uint)917), (SynergyType)((uint)18));
		this.AddPlantSynergy((PlantType)((uint)917), (SynergyType)((uint)9));
		this.AddPlantSynergy((PlantType)((uint)919), (SynergyType)((uint)3));
		this.AddPlantSynergy((PlantType)((uint)919), (SynergyType)((uint)17));
		this.AddPlantSynergy((PlantType)((uint)919), (SynergyType)((uint)13));
		this.AddPlantSynergy((PlantType)((uint)920), (SynergyType)((uint)7));
		this.AddPlantSynergy((PlantType)((uint)920), (SynergyType)((uint)10));
		this.AddPlantSynergy((PlantType)((uint)921), (SynergyType)((uint)1));
		this.AddPlantSynergy((PlantType)((uint)921), (SynergyType)((uint)16));
		this.AddPlantSynergy((PlantType)((uint)921), (SynergyType)((uint)12));
		this.AddPlantSynergy((PlantType)((uint)922), (SynergyType)((uint)4));
		this.AddPlantSynergy((PlantType)((uint)922), (SynergyType)((uint)10));
		this.AddPlantSynergy((PlantType)((uint)922), (SynergyType)((uint)9));
		this.AddPlantSynergy((PlantType)((uint)923), (SynergyType)((uint)5));
		this.AddPlantSynergy((PlantType)((uint)923), (SynergyType)((uint)11));
		this.AddPlantSynergy((PlantType)((uint)924), (SynergyType)((uint)2));
		this.AddPlantSynergy((PlantType)((uint)924), (SynergyType)((uint)10));
		this.AddPlantSynergy((PlantType)((uint)925), (SynergyType)((uint)1));
		this.AddPlantSynergy((PlantType)((uint)925), (SynergyType)((uint)12));
		this.AddPlantSynergy((PlantType)((uint)926), (SynergyType)((uint)3));
		this.AddPlantSynergy((PlantType)((uint)926), (SynergyType)((uint)8));
		this.AddPlantSynergy((PlantType)((uint)927), (SynergyType)((uint)1));
		this.AddPlantSynergy((PlantType)((uint)927), (SynergyType)((uint)8));
		this.AddPlantSynergy((PlantType)((uint)928), (SynergyType)((uint)2));
		this.AddPlantSynergy((PlantType)((uint)928), (SynergyType)((uint)18));
		this.AddPlantSynergy((PlantType)((uint)928), (SynergyType)((uint)9));
		this.AddPlantSynergy((PlantType)((uint)929), (SynergyType)((uint)2));
		this.AddPlantSynergy((PlantType)((uint)929), (SynergyType)((uint)11));
		this.AddPlantSynergy((PlantType)((uint)929), (SynergyType)((uint)8));
		this.AddPlantSynergy((PlantType)((uint)930), (SynergyType)((uint)2));
		this.AddPlantSynergy((PlantType)((uint)930), (SynergyType)((uint)9));
		this.AddPlantSynergy((PlantType)((uint)930), (SynergyType)((uint)8));
		this.AddPlantSynergy((PlantType)((uint)931), (SynergyType)((uint)3));
		this.AddPlantSynergy((PlantType)((uint)931), (SynergyType)((uint)14));
		this.AddPlantSynergy((PlantType)((uint)932), (SynergyType)((uint)3));
		this.AddPlantSynergy((PlantType)((uint)932), (SynergyType)((uint)11));
		this.AddPlantSynergy((PlantType)((uint)933), (SynergyType)((uint)4));
		this.AddPlantSynergy((PlantType)((uint)933), (SynergyType)((uint)15));
		this.AddPlantSynergy((PlantType)((uint)933), (SynergyType)((uint)13));
		this.AddPlantSynergy((PlantType)((uint)934), (SynergyType)((uint)7));
		this.AddPlantSynergy((PlantType)((uint)934), (SynergyType)((uint)11));
		this.AddPlantSynergy((PlantType)((uint)934), (SynergyType)((uint)8));
		this.AddPlantSynergy((PlantType)((uint)935), (SynergyType)((uint)3));
		this.AddPlantSynergy((PlantType)((uint)935), (SynergyType)((uint)10));
		this.AddPlantSynergy((PlantType)((uint)936), (SynergyType)((uint)5));
		this.AddPlantSynergy((PlantType)((uint)936), (SynergyType)((uint)11));
		this.AddPlantSynergy((PlantType)((uint)937), (SynergyType)((uint)5));
		this.AddPlantSynergy((PlantType)((uint)937), (SynergyType)((uint)4));
		this.AddPlantSynergy((PlantType)((uint)938), (SynergyType)((uint)2));
		this.AddPlantSynergy((PlantType)((uint)938), (SynergyType)((uint)18));
		this.AddPlantSynergy((PlantType)((uint)938), (SynergyType)((uint)11));
		this.AddPlantSynergy((PlantType)((uint)939), (SynergyType)((uint)1));
		this.AddPlantSynergy((PlantType)((uint)939), (SynergyType)((uint)9));
		this.AddPlantSynergy((PlantType)((uint)939), (SynergyType)((uint)8));
		this.AddPlantSynergy((PlantType)((uint)940), (SynergyType)((uint)5));
		this.AddPlantSynergy((PlantType)((uint)940), (SynergyType)((uint)17));
		this.AddPlantSynergy((PlantType)((uint)940), (SynergyType)((uint)16));
		this.AddPlantSynergy((PlantType)((uint)942), (SynergyType)((uint)4));
		this.AddPlantSynergy((PlantType)((uint)942), (SynergyType)((uint)10));
		this.AddPlantSynergy((PlantType)((uint)943), (SynergyType)((uint)7));
		this.AddPlantSynergy((PlantType)((uint)943), (SynergyType)((uint)9));
		this.AddPlantSynergy((PlantType)((uint)944), (SynergyType)((uint)4));
		this.AddPlantSynergy((PlantType)((uint)944), (SynergyType)((uint)10));
		this.AddPlantSynergy((PlantType)((uint)944), (SynergyType)((uint)9));
		this.AddPlantSynergy((PlantType)((uint)945), (SynergyType)((uint)7));
		this.AddPlantSynergy((PlantType)((uint)945), (SynergyType)((uint)12));
		this.AddPlantSynergy((PlantType)((uint)946), (SynergyType)((uint)1));
		this.AddPlantSynergy((PlantType)((uint)946), (SynergyType)((uint)13));
		this.AddPlantSynergy((PlantType)((uint)947), (SynergyType)((uint)6));
		this.AddPlantSynergy((PlantType)((uint)947), (SynergyType)((uint)15));
		this.AddPlantSynergy((PlantType)((uint)948), (SynergyType)((uint)4));
		this.AddPlantSynergy((PlantType)((uint)948), (SynergyType)((uint)17));
		this.AddPlantSynergy((PlantType)((uint)949), (SynergyType)((uint)4));
		this.AddPlantSynergy((PlantType)((uint)949), (SynergyType)((uint)15));
		this.AddPlantSynergy((PlantType)((uint)950), (SynergyType)((uint)11));
		this.AddPlantSynergy((PlantType)((uint)951), (SynergyType)((uint)1));
		this.AddPlantSynergy((PlantType)((uint)951), (SynergyType)((uint)12));
		this.AddPlantSynergy((PlantType)((uint)952), (SynergyType)((uint)5));
		this.AddPlantSynergy((PlantType)((uint)952), (SynergyType)((uint)16));
		this.AddPlantSynergy((PlantType)((uint)953), (SynergyType)((uint)5));
		this.AddPlantSynergy((PlantType)((uint)953), (SynergyType)((uint)9));
		this.AddPlantSynergy((PlantType)((uint)953), (SynergyType)((uint)17));
		this.AddPlantSynergy((PlantType)((uint)954), (SynergyType)((uint)1));
		this.AddPlantSynergy((PlantType)((uint)954), (SynergyType)((uint)11));
		this.AddPlantSynergy((PlantType)((uint)955), (SynergyType)((uint)7));
		this.AddPlantSynergy((PlantType)((uint)955), (SynergyType)((uint)8));
		this.AddPlantSynergy((PlantType)((uint)957), (SynergyType)((uint)7));
		this.AddPlantSynergy((PlantType)((uint)957), (SynergyType)((uint)15));
		this.AddPlantSynergy((PlantType)((uint)957), (SynergyType)((uint)8));
		this.AddPlantSynergy((PlantType)((uint)958), (SynergyType)((uint)17));
		this.AddPlantSynergy((PlantType)((uint)959), (SynergyType)((uint)1));
		this.AddPlantSynergy((PlantType)((uint)959), (SynergyType)((uint)9));
		this.AddPlantSynergy((PlantType)((uint)960), (SynergyType)((uint)4));
		this.AddPlantSynergy((PlantType)((uint)961), (SynergyType)((uint)4));
		this.AddPlantSynergy((PlantType)((uint)961), (SynergyType)((uint)10));
		this.AddPlantSynergy((PlantType)((uint)962), (SynergyType)((uint)3));
		this.AddPlantSynergy((PlantType)((uint)962), (SynergyType)((uint)17));
		this.AddPlantSynergy((PlantType)((uint)963), (SynergyType)((uint)1));
		this.AddPlantSynergy((PlantType)((uint)963), (SynergyType)((uint)11));
		this.AddPlantSynergy((PlantType)((uint)964), (SynergyType)((uint)5));
		this.AddPlantSynergy((PlantType)((uint)964), (SynergyType)((uint)15));
		this.AddPlantSynergy((PlantType)((uint)964), (SynergyType)((uint)9));
		this.AddPlantSynergy((PlantType)((uint)965), (SynergyType)((uint)3));
		this.AddPlantSynergy((PlantType)((uint)965), (SynergyType)((uint)9));
		this.AddPlantSynergy((PlantType)((uint)966), (SynergyType)((uint)5));
		this.AddPlantSynergy((PlantType)((uint)966), (SynergyType)((uint)9));
		this.AddPlantSynergy((PlantType)((uint)966), (SynergyType)((uint)8));
		this.AddPlantSynergy((PlantType)((uint)967), (SynergyType)((uint)4));
		this.AddPlantSynergy((PlantType)((uint)967), (SynergyType)((uint)10));
		this.AddPlantSynergy((PlantType)((uint)968), (SynergyType)((uint)3));
		this.AddPlantSynergy((PlantType)((uint)968), (SynergyType)((uint)17));
		this.AddPlantSynergy((PlantType)((uint)969), (SynergyType)((uint)3));
		this.AddPlantSynergy((PlantType)((uint)969), (SynergyType)((uint)17));
		this.AddPlantSynergy((PlantType)((uint)970), (SynergyType)((uint)3));
		this.AddPlantSynergy((PlantType)((uint)970), (SynergyType)((uint)14));
		this.AddPlantSynergy((PlantType)((uint)971), (SynergyType)((uint)1));
		this.AddPlantSynergy((PlantType)((uint)971), (SynergyType)((uint)9));
		this.AddPlantSynergy((PlantType)((uint)972), (SynergyType)((uint)2));
		this.AddPlantSynergy((PlantType)((uint)972), (SynergyType)((uint)9));
		this.AddPlantSynergy((PlantType)((uint)972), (SynergyType)((uint)8));
		this.AddPlantSynergy((PlantType)((uint)973), (SynergyType)((uint)4));
		this.AddPlantSynergy((PlantType)((uint)973), (SynergyType)((uint)16));
		this.AddPlantSynergy((PlantType)((uint)974), (SynergyType)((uint)4));
		this.AddPlantSynergy((PlantType)((uint)974), (SynergyType)((uint)10));
		this.AddPlantSynergy((PlantType)((uint)974), (SynergyType)((uint)11));
		this.AddPlantSynergy((PlantType)((uint)975), (SynergyType)((uint)4));
		this.AddPlantSynergy((PlantType)((uint)975), (SynergyType)((uint)15));
		this.AddPlantSynergy((PlantType)((uint)976), (SynergyType)((uint)4));
		this.AddPlantSynergy((PlantType)((uint)976), (SynergyType)((uint)10));
		this.AddPlantSynergy((PlantType)((uint)977), (SynergyType)((uint)3));
		this.AddPlantSynergy((PlantType)((uint)977), (SynergyType)((uint)12));
	}

	// Token: 0x060033E5 RID: 13285 RVA: 0x00114E18 File Offset: 0x00113018
	[Token(Token = "0x60033E5")]
	[Address(RVA = "0x71AA40", Offset = "0x719040", VA = "0x18071AA40")]
	private void AddPlantSynergy(PlantType plantType, SynergyType synergyType)
	{
		Dictionary<PlantType, List<SynergyType>> plantSynergies = this._plantSynergies;
		bool flag;
		if (!flag)
		{
			Dictionary<PlantType, List<SynergyType>> plantSynergies2 = this._plantSynergies;
			List<SynergyType> list = new List();
		}
		Dictionary<PlantType, List<SynergyType>> plantSynergies3 = this._plantSynergies;
		bool flag2;
		if (!flag2)
		{
			Dictionary<PlantType, List<SynergyType>> plantSynergies4 = this._plantSynergies;
			List<SynergyType> list2;
			int size = list2._size;
		}
		Dictionary<SynergyType, List<PlantType>> allSynergies = this._allSynergies;
		bool flag3;
		if (!flag3)
		{
			Dictionary<SynergyType, List<PlantType>> allSynergies2 = this._allSynergies;
			List<PlantType> list3 = new List();
		}
		Dictionary<SynergyType, List<PlantType>> allSynergies3 = this._allSynergies;
		bool flag4;
		if (!flag4)
		{
			Dictionary<SynergyType, List<PlantType>> allSynergies4 = this._allSynergies;
			List<PlantType> list4;
			int size2 = list4._size;
		}
	}

	// Token: 0x060033E6 RID: 13286 RVA: 0x00114EA8 File Offset: 0x001130A8
	[Token(Token = "0x60033E6")]
	[Address(RVA = "0x71B240", Offset = "0x719840", VA = "0x18071B240")]
	public List<SynergyType> GetAllSynergyTypes()
	{
		IEnumerable<SynergyType> enumerable = Enumerable.Cast<SynergyType>(Enum.GetValues(typeof(SynergyType)));
		Func<SynergyType, bool> <>9__9_ = SynergyManager.<>c.<>9__9_0;
		if (<>9__9_ == 0)
		{
			SynergyManager.<>c.<>9__9_0 = (SynergyType s) => s != SynergyType.None;
		}
		return Enumerable.ToList<SynergyType>(Enumerable.Where<SynergyType>(enumerable, <>9__9_));
	}

	// Token: 0x060033E7 RID: 13287 RVA: 0x00114F00 File Offset: 0x00113100
	[Token(Token = "0x60033E7")]
	[Address(RVA = "0x71B400", Offset = "0x719A00", VA = "0x18071B400")]
	public List<SynergyType> GetPlantSynergies(PlantType plantType)
	{
		Dictionary<PlantType, List<SynergyType>> plantSynergies = this._plantSynergies;
		bool flag;
		if (!flag)
		{
			return new List();
		}
		Dictionary<PlantType, List<SynergyType>> plantSynergies2 = this._plantSynergies;
		List<SynergyType> list;
		return new List(list);
	}

	// Token: 0x060033E8 RID: 13288 RVA: 0x00114F3C File Offset: 0x0011313C
	[Token(Token = "0x60033E8")]
	[Address(RVA = "0x71C7C0", Offset = "0x71ADC0", VA = "0x18071C7C0")]
	public void UpdateActiveSynergies(List<PlantType> currentPlants)
	{
		int num4;
		do
		{
			int num = 0;
			this._activeSynergies.Clear();
			IEnumerable<SynergyType> enumerable = Enumerable.Cast<SynergyType>(Enum.GetValues(typeof(SynergyType)));
			Func<SynergyType, bool> <>9__9_ = SynergyManager.<>c.<>9__9_0;
			if (<>9__9_ == 0)
			{
				SynergyManager.<>c.<>9__9_0 = (SynergyType s) => s != SynergyType.None;
			}
			List<SynergyType> list = Enumerable.ToList<SynergyType>(Enumerable.Where<SynergyType>(enumerable, <>9__9_));
			int num2 = 0;
			bool flag;
			if (flag)
			{
				Dictionary<SynergyType, List<PlantType>> activeSynergies = this._activeSynergies;
				List<PlantType> list2 = new List();
				activeSynergies[num] = list2;
			}
			if (num2 != 0)
			{
				goto IL_00FB;
			}
			int num3 = 0;
			bool flag2;
			List<SynergyType> list5;
			if (flag2)
			{
				bool flag3;
				if (!flag3)
				{
					List<SynergyType> list3 = new List();
				}
				List<SynergyType> list4 = new List(list5);
				bool flag4;
				if (flag4)
				{
				}
				if (num3 != 0)
				{
					goto IL_0107;
				}
			}
			if (num3 != 0)
			{
				goto IL_0119;
			}
			num4 = 0;
			Func<KeyValuePair<SynergyType, List<PlantType>>, bool> func;
			if (SynergyManager.<>c.<>9__11_0 == 0)
			{
				SynergyManager.<>c.<>9__11_0 = func;
			}
			IEnumerable<KeyValuePair<SynergyType, List<PlantType>>> enumerable2 = Enumerable.Where<KeyValuePair<SynergyType, List<PlantType>>>(list5, func);
			Func<KeyValuePair<SynergyType, List<PlantType>>, SynergyType> func2;
			if (SynergyManager.<>c.<>9__11_1 == 0)
			{
				SynergyManager.<>c.<>9__11_1 = func2;
			}
			List<SynergyType> list6 = Enumerable.ToList<SynergyType>(Enumerable.Select<KeyValuePair<SynergyType, List<PlantType>>, SynergyType>(enumerable2, func2));
			bool flag5;
			if (flag5)
			{
			}
		}
		while (num4 != 0);
		return;
		IL_00FB:
		throw new NullReferenceException();
		IL_0107:
		throw new NullReferenceException();
		IL_0119:
		throw new NullReferenceException();
	}

	// Token: 0x060033E9 RID: 13289 RVA: 0x00115068 File Offset: 0x00113268
	[Token(Token = "0x60033E9")]
	[Address(RVA = "0x71AEC0", Offset = "0x7194C0", VA = "0x18071AEC0")]
	public List<SynergyType> GetActiveSynergies(bool all = false)
	{
		int num;
		List<SynergyType> list;
		do
		{
			num = 0;
			list = new List();
			Dictionary<SynergyType, List<PlantType>> activeSynergies = this._activeSynergies;
			bool flag;
			if (flag)
			{
				if (!TravelMgr.SynergysData.TryGetValue(num, num))
				{
					continue;
				}
				while ((uint)1 == 0U)
				{
				}
			}
		}
		while (num != 0);
		return list;
	}

	// Token: 0x060033EA RID: 13290 RVA: 0x001150CC File Offset: 0x001132CC
	[Token(Token = "0x60033EA")]
	[Address(RVA = "0x71C690", Offset = "0x71AC90", VA = "0x18071C690")]
	public bool IsSynergyActive(SynergyType synergyType, [Out] List<PlantType> plants)
	{
		Dictionary<SynergyType, List<PlantType>> activeSynergies = this._activeSynergies;
		bool flag;
		if (!flag)
		{
			List<PlantType> list = new List();
		}
		Dictionary<SynergyType, List<PlantType>> activeSynergies2 = this._activeSynergies;
		List<PlantType> list3;
		List<PlantType> list2 = new List(list3);
		return true;
	}

	// Token: 0x060033EB RID: 13291 RVA: 0x00115108 File Offset: 0x00113308
	[Token(Token = "0x60033EB")]
	[Address(RVA = "0x71B600", Offset = "0x719C00", VA = "0x18071B600")]
	public int GetSynergyLevel(SynergyType synergyType, int[] thresholds)
	{
		Dictionary<SynergyType, List<PlantType>> activeSynergies = this._activeSynergies;
		bool flag;
		if (flag)
		{
			Dictionary<SynergyType, List<PlantType>> activeSynergies2 = this._activeSynergies;
			List<PlantType> list;
			int size = list._size;
			int length = thresholds.Length;
			int length2 = thresholds.Length;
		}
		return 0;
	}

	// Token: 0x060033EC RID: 13292 RVA: 0x00115158 File Offset: 0x00113358
	[Token(Token = "0x60033EC")]
	[Address(RVA = "0x71B6F0", Offset = "0x719CF0", VA = "0x18071B6F0")]
	public int GetSynergyPlantCount(SynergyType synergyType)
	{
		Dictionary<SynergyType, List<PlantType>> activeSynergies = this._activeSynergies;
		bool flag;
		if (!flag)
		{
			return 0;
		}
		Dictionary<SynergyType, List<PlantType>> activeSynergies2 = this._activeSynergies;
		List<PlantType> list;
		return list._size;
	}

	// Token: 0x060033ED RID: 13293 RVA: 0x00115188 File Offset: 0x00113388
	[Token(Token = "0x60033ED")]
	[Address(RVA = "0x71B500", Offset = "0x719B00", VA = "0x18071B500")]
	public List<PlantType> GetPlantsBySynergy(SynergyType synergyType)
	{
		Dictionary<SynergyType, List<PlantType>> activeSynergies = this._activeSynergies;
		bool flag;
		if (!flag)
		{
			return new List();
		}
		Dictionary<SynergyType, List<PlantType>> activeSynergies2 = this._activeSynergies;
		List<PlantType> list;
		return new List(list);
	}

	// Token: 0x060033EE RID: 13294 RVA: 0x001151C4 File Offset: 0x001133C4
	[Token(Token = "0x60033EE")]
	[Address(RVA = "0x71B140", Offset = "0x719740", VA = "0x18071B140")]
	public List<PlantType> GetAllPlantsBySynergy(SynergyType synergyType)
	{
		Dictionary<SynergyType, List<PlantType>> allSynergies = this._allSynergies;
		bool flag;
		if (!flag)
		{
			return new List();
		}
		Dictionary<SynergyType, List<PlantType>> allSynergies2 = this._allSynergies;
		List<PlantType> list;
		return new List(list);
	}

	// Token: 0x060033EF RID: 13295 RVA: 0x00115200 File Offset: 0x00113400
	[Token(Token = "0x60033EF")]
	[Address(RVA = "0x71AE70", Offset = "0x719470", VA = "0x18071AE70")]
	public void ClearAllSynergies()
	{
		this._activeSynergies.Clear();
	}

	// Token: 0x060033F0 RID: 13296 RVA: 0x00115220 File Offset: 0x00113420
	[Token(Token = "0x60033F0")]
	[Address(RVA = "0x71D090", Offset = "0x71B690", VA = "0x18071D090")]
	public SynergyManager()
	{
		Dictionary<PlantType, List<SynergyType>> dictionary = new Dictionary();
		this._plantSynergies = dictionary;
		Dictionary<SynergyType, List<PlantType>> dictionary2 = new Dictionary();
		this._activeSynergies = dictionary2;
		Dictionary<SynergyType, List<PlantType>> dictionary3 = new Dictionary();
		this._allSynergies = dictionary3;
		base..ctor();
	}

	// Token: 0x04002568 RID: 9576
	[Token(Token = "0x4002568")]
	private static SynergyManager _instance;

	// Token: 0x04002569 RID: 9577
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002569")]
	private readonly Dictionary<PlantType, List<SynergyType>> _plantSynergies;

	// Token: 0x0400256A RID: 9578
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400256A")]
	private readonly Dictionary<SynergyType, List<PlantType>> _activeSynergies;

	// Token: 0x0400256B RID: 9579
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400256B")]
	private readonly Dictionary<SynergyType, List<PlantType>> _allSynergies;
}
