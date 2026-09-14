using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000604 RID: 1540
[Token(Token = "0x2000604")]
public class TravelSynergyMenu : BaseMenu
{
	// Token: 0x06001D1C RID: 7452 RVA: 0x0009BAD0 File Offset: 0x00099CD0
	[Token(Token = "0x6001D1C")]
	[Address(RVA = "0x524340", Offset = "0x522940", VA = "0x180524340", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		this.InitText();
	}

	// Token: 0x06001D1D RID: 7453 RVA: 0x0009BAEC File Offset: 0x00099CEC
	[Token(Token = "0x6001D1D")]
	[Address(RVA = "0x524360", Offset = "0x522960", VA = "0x180524360")]
	private void InitText()
	{
		ulong num3;
		do
		{
			int num = 0;
			TravelMgr.Instance.UpdateSynergies();
			Transform transform = this.sampleNode.transform;
			SynergyManager instance = SynergyManager.Instance;
			int num2 = 0;
			List<SynergyType> activeSynergies = instance.GetActiveSynergies(num2 != 0);
			TravelSynergyMenu.<>c__DisplayClass5_0 CS$<>8__locals1;
			CS$<>8__locals1.currentActive = activeSynergies;
			List<SynergyType> allSynergyTypes = SynergyManager.Instance.GetAllSynergyTypes();
			Func<SynergyType, bool> func = delegate(SynergyType a)
			{
				List<SynergyType> currentActive = CS$<>8__locals1.currentActive;
				bool flag2;
				return flag2;
			};
			IOrderedEnumerable<SynergyType> orderedEnumerable = Enumerable.OrderByDescending<SynergyType, bool>(allSynergyTypes, func);
			Func<SynergyType, int> <>9__5_ = TravelSynergyMenu.<>c.<>9__5_1;
			if (<>9__5_ == 0)
			{
				Func<SynergyType, int> func2;
				TravelSynergyMenu.<>c.<>9__5_1 = func2;
			}
			List<SynergyType> list = Enumerable.ToList<SynergyType>(Enumerable.ThenByDescending<SynergyType, int>(orderedEnumerable, <>9__5_));
			bool flag;
			if (flag)
			{
				SynergyNode synergyNode = this.sampleNode;
				Transform parent = synergyNode.transform.parent;
				SynergyNode synergyNode2 = global::UnityEngine.Object.Instantiate<SynergyNode>(synergyNode, parent);
				synergyNode2.synergyType = (SynergyType)num;
				List<PlantType> plantsBySynergy = SynergyManager.Instance.GetPlantsBySynergy((SynergyType)num);
				synergyNode2.plantTypes_unlocked = plantsBySynergy;
				List<PlantType> allPlantsBySynergy = SynergyManager.Instance.GetAllPlantsBySynergy((SynergyType)num);
				synergyNode2.plantTypes_all = allPlantsBySynergy;
				synergyNode2.InitNode();
				Transform transform2 = synergyNode2.transform;
				Transform transform3 = synergyNode2.transform;
				List<SynergyNode> list2 = this.nodes;
				int size = list2._size;
				list2._size = transform2;
			}
		}
		while (num3 != (ulong)0L);
		GameObject gameObject;
		global::UnityEngine.Object.Destroy(gameObject);
	}

	// Token: 0x06001D1E RID: 7454 RVA: 0x0009BC70 File Offset: 0x00099E70
	[Token(Token = "0x6001D1E")]
	[Address(RVA = "0x5249C0", Offset = "0x522FC0", VA = "0x1805249C0")]
	public TravelSynergyMenu()
	{
		List<SynergyNode> list = new List();
		this.nodes = list;
		base..ctor();
	}

	// Token: 0x04000F99 RID: 3993
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000F99")]
	public float nodeBaseHeight = 150f;

	// Token: 0x04000F9A RID: 3994
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000F9A")]
	public SynergyNode sampleNode;

	// Token: 0x04000F9B RID: 3995
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000F9B")]
	public RectTransform contant;

	// Token: 0x04000F9C RID: 3996
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000F9C")]
	public List<SynergyNode> nodes;
}
