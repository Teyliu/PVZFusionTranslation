using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000204 RID: 516
[Token(Token = "0x2000204")]
public class ElementUpgrade : SpecialCard
{
	// Token: 0x060008B6 RID: 2230 RVA: 0x0002CBD8 File Offset: 0x0002ADD8
	[Token(Token = "0x60008B6")]
	[Address(RVA = "0x8F7BC0", Offset = "0x8F61C0", VA = "0x1808F7BC0", Slot = "10")]
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

	// Token: 0x060008B7 RID: 2231 RVA: 0x0002CC30 File Offset: 0x0002AE30
	[Token(Token = "0x60008B7")]
	[Address(RVA = "0x8F7F30", Offset = "0x8F6530", VA = "0x1808F7F30")]
	public static void OnElementUpgrade()
	{
		ElementUpgrade.BuildDirectUpgradeCache();
		ElementUpgrade.BuildAllUpgradePathsCache();
	}

	// Token: 0x060008B8 RID: 2232 RVA: 0x0002CC4C File Offset: 0x0002AE4C
	[Token(Token = "0x60008B8")]
	[Address(RVA = "0x8F7690", Offset = "0x8F5C90", VA = "0x1808F7690")]
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

	// Token: 0x060008B9 RID: 2233 RVA: 0x0002CD44 File Offset: 0x0002AF44
	[Token(Token = "0x60008B9")]
	[Address(RVA = "0x8F7F50", Offset = "0x8F6550", VA = "0x1808F7F50")]
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

	// Token: 0x060008BA RID: 2234 RVA: 0x0002CD9C File Offset: 0x0002AF9C
	[Token(Token = "0x60008BA")]
	[Address(RVA = "0x8F8200", Offset = "0x8F6800", VA = "0x1808F8200")]
	private static void ProcessSpecialUpgrades()
	{
		List<PlantType> list = Enumerable.ToList<PlantType>(Enumerable.Distinct<PlantType>(PineFurnace.mixDic.Values));
		ElementUpgrade._directUpgradeCache[(uint)35] = list;
		ElementUpgrade.AddAToB((PlantType)((uint)23), (PlantType)((uint)976));
		ElementUpgrade.AddAToB((PlantType)((uint)1034), (PlantType)((uint)1443));
		ElementUpgrade.AddAToB((PlantType)((uint)241), (PlantType)((uint)1443));
	}

	// Token: 0x060008BB RID: 2235 RVA: 0x0002CE04 File Offset: 0x0002B004
	[Token(Token = "0x60008BB")]
	[Address(RVA = "0x8F6FE0", Offset = "0x8F55E0", VA = "0x1808F6FE0")]
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

	// Token: 0x060008BC RID: 2236 RVA: 0x0002CE4C File Offset: 0x0002B04C
	[Token(Token = "0x60008BC")]
	[Address(RVA = "0x8F71D0", Offset = "0x8F57D0", VA = "0x1808F71D0")]
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

	// Token: 0x060008BD RID: 2237 RVA: 0x0002CF04 File Offset: 0x0002B104
	[Token(Token = "0x60008BD")]
	[Address(RVA = "0x8F7DD0", Offset = "0x8F63D0", VA = "0x1808F7DD0")]
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

	// Token: 0x060008BE RID: 2238 RVA: 0x0002CF50 File Offset: 0x0002B150
	[Token(Token = "0x60008BE")]
	[Address(RVA = "0x8F8330", Offset = "0x8F6930", VA = "0x1808F8330")]
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

	// Token: 0x060008BF RID: 2239 RVA: 0x0002CFB8 File Offset: 0x0002B1B8
	[Token(Token = "0x60008BF")]
	[Address(RVA = "0x8DF910", Offset = "0x8DDF10", VA = "0x1808DF910")]
	public ElementUpgrade()
	{
		this.d = 1f;
		base..ctor();
	}

	// Token: 0x04000449 RID: 1097
	[Token(Token = "0x4000449")]
	private static Dictionary<PlantType, List<PlantType>> _directUpgradeCache;

	// Token: 0x0400044A RID: 1098
	[Token(Token = "0x400044A")]
	private static Dictionary<PlantType, HashSet<PlantType>> _allUpgradePathsCache;
}
