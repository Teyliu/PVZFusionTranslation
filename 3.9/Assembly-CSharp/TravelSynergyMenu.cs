using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000639 RID: 1593
[Token(Token = "0x2000639")]
public class TravelSynergyMenu : BaseMenu
{
	// Token: 0x06001E1B RID: 7707 RVA: 0x000A05AC File Offset: 0x0009E7AC
	[Token(Token = "0x6001E1B")]
	[Address(RVA = "0x5843E0", Offset = "0x5829E0", VA = "0x1805843E0", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		this.InitText();
	}

	// Token: 0x06001E1C RID: 7708 RVA: 0x000A05C8 File Offset: 0x0009E7C8
	[Token(Token = "0x6001E1C")]
	[Address(RVA = "0x584400", Offset = "0x582A00", VA = "0x180584400")]
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

	// Token: 0x06001E1D RID: 7709 RVA: 0x000A074C File Offset: 0x0009E94C
	[Token(Token = "0x6001E1D")]
	[Address(RVA = "0x584A60", Offset = "0x583060", VA = "0x180584A60")]
	public TravelSynergyMenu()
	{
		List<SynergyNode> list = new List();
		this.nodes = list;
		base..ctor();
	}

	// Token: 0x04001061 RID: 4193
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001061")]
	public float nodeBaseHeight = 150f;

	// Token: 0x04001062 RID: 4194
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001062")]
	public SynergyNode sampleNode;

	// Token: 0x04001063 RID: 4195
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001063")]
	public RectTransform contant;

	// Token: 0x04001064 RID: 4196
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001064")]
	public List<SynergyNode> nodes;
}
