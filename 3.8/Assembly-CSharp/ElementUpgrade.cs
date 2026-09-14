using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001FD RID: 509
[Token(Token = "0x20001FD")]
public class ElementUpgrade : SpecialCard
{
	// Token: 0x0600089C RID: 2204 RVA: 0x0002CBAC File Offset: 0x0002ADAC
	[Token(Token = "0x600089C")]
	[Address(RVA = "0x868E70", Offset = "0x867470", VA = "0x180868E70", Slot = "10")]
	public override void ClickedEvent()
	{
		int num2;
		do
		{
			int num = 0;
			List<CardUI> cardsOnBelt = ConveyManager.Instance.cardsOnBelt;
			num2 = 0;
			bool flag;
			if (flag)
			{
				if (num != 0)
				{
					while (num != 0)
					{
					}
				}
				this.UpgradeCard(num);
			}
		}
		while (num2 != 0);
		GameObject gameObject;
		global::UnityEngine.Object.Destroy(gameObject);
		GameAPP.PlaySound(125, 0.5f, 1f);
	}

	// Token: 0x0600089D RID: 2205 RVA: 0x0002CC04 File Offset: 0x0002AE04
	[Token(Token = "0x600089D")]
	[Address(RVA = "0x8691E0", Offset = "0x8677E0", VA = "0x1808691E0")]
	public static void OnElementUpgrade()
	{
		ElementUpgrade.BuildDirectUpgradeCache();
		ElementUpgrade.BuildAllUpgradePathsCache();
	}

	// Token: 0x0600089E RID: 2206 RVA: 0x0002CC20 File Offset: 0x0002AE20
	[Token(Token = "0x600089E")]
	[Address(RVA = "0x868940", Offset = "0x866F40", VA = "0x180868940")]
	private static void BuildDirectUpgradeCache()
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			ElementUpgrade._directUpgradeCache = new Dictionary();
			HashSet<PlantType> hashSet = new HashSet(GameAPP.resourcesManager.allPlants);
			bool flag;
			if (flag)
			{
				HashSet<PlantType> hashSet2 = new HashSet();
				bool flag2;
				if (flag2)
				{
					int num3 = 0;
					if (!MixData.TryGetMix((PlantType)num, (PlantType)num, (PlantType)num2, num3 != 0))
					{
						continue;
					}
					bool flag3 = hashSet2.Add(num2);
				}
				if (num2 != 0)
				{
					goto IL_00DD;
				}
				Dictionary<PlantType, List<PlantType>> directUpgradeCache = ElementUpgrade._directUpgradeCache;
				List<PlantType> list = Enumerable.ToList<PlantType>(hashSet2);
				directUpgradeCache[num] = list;
			}
		}
		while (num2 != 0);
		ElementUpgrade.ProcessRecipesUpgrades();
		List<PlantType> list2 = Enumerable.ToList<PlantType>(Enumerable.Distinct<PlantType>(PineFurnace.mixDic.Values));
		ElementUpgrade._directUpgradeCache[(uint)35] = list2;
		ElementUpgrade.AddAToB((PlantType)((uint)23), (PlantType)((uint)976));
		ElementUpgrade.AddAToB((PlantType)((uint)1034), (PlantType)((uint)1443));
		ElementUpgrade.AddAToB((PlantType)((uint)241), (PlantType)((uint)1443));
		return;
		IL_00DD:
		throw new NullReferenceException();
	}

	// Token: 0x0600089F RID: 2207 RVA: 0x0002CD18 File Offset: 0x0002AF18
	[Token(Token = "0x600089F")]
	[Address(RVA = "0x869200", Offset = "0x867800", VA = "0x180869200")]
	private static void ProcessRecipesUpgrades()
	{
		int num;
		do
		{
			num = 0;
			Dictionary<ValueTuple<PlantType, BucketType>, PlantType> recipes = Bucket.Recipes;
			bool flag;
			if (flag)
			{
				Dictionary<PlantType, List<PlantType>> directUpgradeCache = ElementUpgrade._directUpgradeCache;
				bool flag2;
				if (!flag2)
				{
					List<PlantType> list = new List();
					Dictionary<PlantType, List<PlantType>> directUpgradeCache2 = ElementUpgrade._directUpgradeCache;
				}
				bool flag3;
				while (flag3)
				{
				}
			}
		}
		while (num != 0);
	}

	// Token: 0x060008A0 RID: 2208 RVA: 0x0002CD70 File Offset: 0x0002AF70
	[Token(Token = "0x60008A0")]
	[Address(RVA = "0x8694B0", Offset = "0x867AB0", VA = "0x1808694B0")]
	private static void ProcessSpecialUpgrades()
	{
		List<PlantType> list = Enumerable.ToList<PlantType>(Enumerable.Distinct<PlantType>(PineFurnace.mixDic.Values));
		ElementUpgrade._directUpgradeCache[(uint)35] = list;
		ElementUpgrade.AddAToB((PlantType)((uint)23), (PlantType)((uint)976));
		ElementUpgrade.AddAToB((PlantType)((uint)1034), (PlantType)((uint)1443));
		ElementUpgrade.AddAToB((PlantType)((uint)241), (PlantType)((uint)1443));
	}

	// Token: 0x060008A1 RID: 2209 RVA: 0x0002CDD8 File Offset: 0x0002AFD8
	[Token(Token = "0x60008A1")]
	[Address(RVA = "0x868290", Offset = "0x866890", VA = "0x180868290")]
	private static void AddAToB(PlantType basic, PlantType advanced)
	{
		Dictionary<PlantType, List<PlantType>> directUpgradeCache = ElementUpgrade._directUpgradeCache;
		bool flag;
		if (!flag)
		{
			Dictionary<PlantType, List<PlantType>> directUpgradeCache2 = ElementUpgrade._directUpgradeCache;
			int size = new List()._size;
			return;
		}
		bool flag2;
		while (flag2)
		{
		}
		int num = (int)(advanced + 1);
		throw new NullReferenceException();
	}

	// Token: 0x060008A2 RID: 2210 RVA: 0x0002CE20 File Offset: 0x0002B020
	[Token(Token = "0x60008A2")]
	[Address(RVA = "0x868480", Offset = "0x866A80", VA = "0x180868480")]
	private static void BuildAllUpgradePathsCache()
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			ElementUpgrade._allUpgradePathsCache = new Dictionary();
			Dictionary<PlantType, List<PlantType>>.KeyCollection keys = ElementUpgrade._directUpgradeCache.Keys;
			bool flag;
			if (flag)
			{
				HashSet<PlantType> hashSet = new HashSet();
				Stack<PlantType> stack = new Stack();
				stack.Push(num);
				PlantType plantType = stack.Pop();
				Dictionary<PlantType, List<PlantType>> directUpgradeCache = ElementUpgrade._directUpgradeCache;
				bool flag2;
				while (!flag2)
				{
				}
				bool flag3;
				if (flag3)
				{
					if (!hashSet.Add(num))
					{
						continue;
					}
					stack.Push(num);
				}
				if (num2 != 0)
				{
					goto IL_008C;
				}
				bool flag4 = hashSet.Remove(num);
				ElementUpgrade._allUpgradePathsCache[num] = hashSet;
			}
		}
		while (num2 != 0);
		return;
		IL_008C:
		throw new NullReferenceException();
	}

	// Token: 0x060008A3 RID: 2211 RVA: 0x0002CED8 File Offset: 0x0002B0D8
	[Token(Token = "0x60008A3")]
	[Address(RVA = "0x869080", Offset = "0x867680", VA = "0x180869080")]
	public static List<PlantType> GetPossibleUpgradeTypes(PlantType plantType, bool includeIndirect)
	{
		int num = 0;
		if (!includeIndirect)
		{
			Dictionary<PlantType, List<PlantType>> directUpgradeCache = ElementUpgrade._directUpgradeCache;
			bool flag;
			if (flag)
			{
				return new List(num);
			}
		}
		else
		{
			Dictionary<PlantType, HashSet<PlantType>> allUpgradePathsCache = ElementUpgrade._allUpgradePathsCache;
			bool flag2;
			if (flag2)
			{
				return Enumerable.ToList<PlantType>(num);
			}
		}
		return new List();
	}

	// Token: 0x060008A4 RID: 2212 RVA: 0x0002CF24 File Offset: 0x0002B124
	[Token(Token = "0x60008A4")]
	[Address(RVA = "0x8695E0", Offset = "0x867BE0", VA = "0x1808695E0")]
	private void UpgradeCard(CardUI card)
	{
		Dictionary<PlantType, HashSet<PlantType>> allUpgradePathsCache = ElementUpgrade._allUpgradePathsCache;
		bool flag;
		if (flag)
		{
			if (ElementUpgrade.<>c.<>9__10_0 == 0)
			{
				ElementUpgrade.<>c.<>9__10_0 = delegate(PlantType c)
				{
					bool flag2;
					return flag2;
				};
			}
			IEnumerable<PlantType> enumerable;
			List<PlantType> list = Enumerable.ToList<PlantType>(enumerable);
			PlantType plantType;
			card.thePlantType = plantType;
			card.ChangeCardSprite();
			ParticleManager instance = ParticleManager.Instance;
			Transform transform = card.transform;
		}
	}

	// Token: 0x060008A5 RID: 2213 RVA: 0x0002CF8C File Offset: 0x0002B18C
	[Token(Token = "0x60008A5")]
	[Address(RVA = "0x8516E0", Offset = "0x84FCE0", VA = "0x1808516E0")]
	public ElementUpgrade()
	{
		this.d = 1f;
		base..ctor();
	}

	// Token: 0x0400043F RID: 1087
	[Token(Token = "0x400043F")]
	private static Dictionary<PlantType, List<PlantType>> _directUpgradeCache;

	// Token: 0x04000440 RID: 1088
	[Token(Token = "0x4000440")]
	private static Dictionary<PlantType, HashSet<PlantType>> _allUpgradePathsCache;
}
