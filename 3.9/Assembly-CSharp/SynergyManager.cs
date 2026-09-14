using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000A19 RID: 2585
[Token(Token = "0x2000A19")]
public class SynergyManager : MonoBehaviour
{
	// Token: 0x1700025D RID: 605
	// (get) Token: 0x06003516 RID: 13590 RVA: 0x0011931C File Offset: 0x0011751C
	[Token(Token = "0x1700025D")]
	public static SynergyManager Instance
	{
		[Token(Token = "0x6003516")]
		[Address(RVA = "0x7826F0", Offset = "0x780CF0", VA = "0x1807826F0")]
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

	// Token: 0x06003517 RID: 13591 RVA: 0x00119364 File Offset: 0x00117564
	[Token(Token = "0x6003517")]
	[Address(RVA = "0x7802C0", Offset = "0x77E8C0", VA = "0x1807802C0")]
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

	// Token: 0x06003518 RID: 13592 RVA: 0x001193AC File Offset: 0x001175AC
	[Token(Token = "0x6003518")]
	[Address(RVA = "0x780D00", Offset = "0x77F300", VA = "0x180780D00")]
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

	// Token: 0x06003519 RID: 13593 RVA: 0x00119D7C File Offset: 0x00117F7C
	[Token(Token = "0x6003519")]
	[Address(RVA = "0x77FFB0", Offset = "0x77E5B0", VA = "0x18077FFB0")]
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

	// Token: 0x0600351A RID: 13594 RVA: 0x00119E0C File Offset: 0x0011800C
	[Token(Token = "0x600351A")]
	[Address(RVA = "0x7807B0", Offset = "0x77EDB0", VA = "0x1807807B0")]
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

	// Token: 0x0600351B RID: 13595 RVA: 0x00119E64 File Offset: 0x00118064
	[Token(Token = "0x600351B")]
	[Address(RVA = "0x780970", Offset = "0x77EF70", VA = "0x180780970")]
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

	// Token: 0x0600351C RID: 13596 RVA: 0x00119EA0 File Offset: 0x001180A0
	[Token(Token = "0x600351C")]
	[Address(RVA = "0x781D30", Offset = "0x780330", VA = "0x180781D30")]
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
				goto IL_0110;
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
					goto IL_011C;
				}
			}
			if (num3 != 0)
			{
				goto IL_012E;
			}
			num4 = 0;
			Func<KeyValuePair<SynergyType, List<PlantType>>, bool> func;
			if (SynergyManager.<>c.<>9__11_0 == 0)
			{
				func = delegate(KeyValuePair<SynergyType, List<PlantType>> kvp)
				{
					bool flag6;
					return flag6;
				};
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
		IL_0110:
		throw new NullReferenceException();
		IL_011C:
		throw new NullReferenceException();
		IL_012E:
		throw new NullReferenceException();
	}

	// Token: 0x0600351D RID: 13597 RVA: 0x00119FE4 File Offset: 0x001181E4
	[Token(Token = "0x600351D")]
	[Address(RVA = "0x780430", Offset = "0x77EA30", VA = "0x180780430")]
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

	// Token: 0x0600351E RID: 13598 RVA: 0x0011A048 File Offset: 0x00118248
	[Token(Token = "0x600351E")]
	[Address(RVA = "0x781C00", Offset = "0x780200", VA = "0x180781C00")]
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

	// Token: 0x0600351F RID: 13599 RVA: 0x0011A084 File Offset: 0x00118284
	[Token(Token = "0x600351F")]
	[Address(RVA = "0x780B70", Offset = "0x77F170", VA = "0x180780B70")]
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

	// Token: 0x06003520 RID: 13600 RVA: 0x0011A0D4 File Offset: 0x001182D4
	[Token(Token = "0x6003520")]
	[Address(RVA = "0x780C60", Offset = "0x77F260", VA = "0x180780C60")]
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

	// Token: 0x06003521 RID: 13601 RVA: 0x0011A104 File Offset: 0x00118304
	[Token(Token = "0x6003521")]
	[Address(RVA = "0x780A70", Offset = "0x77F070", VA = "0x180780A70")]
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

	// Token: 0x06003522 RID: 13602 RVA: 0x0011A140 File Offset: 0x00118340
	[Token(Token = "0x6003522")]
	[Address(RVA = "0x7806B0", Offset = "0x77ECB0", VA = "0x1807806B0")]
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

	// Token: 0x06003523 RID: 13603 RVA: 0x0011A17C File Offset: 0x0011837C
	[Token(Token = "0x6003523")]
	[Address(RVA = "0x7803E0", Offset = "0x77E9E0", VA = "0x1807803E0")]
	public void ClearAllSynergies()
	{
		this._activeSynergies.Clear();
	}

	// Token: 0x06003524 RID: 13604 RVA: 0x0011A19C File Offset: 0x0011839C
	[Token(Token = "0x6003524")]
	[Address(RVA = "0x782600", Offset = "0x780C00", VA = "0x180782600")]
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

	// Token: 0x0400267A RID: 9850
	[Token(Token = "0x400267A")]
	private static SynergyManager _instance;

	// Token: 0x0400267B RID: 9851
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400267B")]
	private readonly Dictionary<PlantType, List<SynergyType>> _plantSynergies;

	// Token: 0x0400267C RID: 9852
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400267C")]
	private readonly Dictionary<SynergyType, List<PlantType>> _activeSynergies;

	// Token: 0x0400267D RID: 9853
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400267D")]
	private readonly Dictionary<SynergyType, List<PlantType>> _allSynergies;
}
