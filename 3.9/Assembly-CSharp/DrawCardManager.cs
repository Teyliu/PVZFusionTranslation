using System;
using System.Collections;
using System.Collections.Generic;
using AlmanacData;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020000AE RID: 174
[Token(Token = "0x20000AE")]
public class DrawCardManager : MonoBehaviour
{
	// Token: 0x0600030A RID: 778 RVA: 0x0000CE70 File Offset: 0x0000B070
	[Token(Token = "0x600030A")]
	[Address(RVA = "0x40CCC0", Offset = "0x40B2C0", VA = "0x18040CCC0")]
	private string GetName()
	{
		int num = (int)this.up;
		PlantInfo plantInfo;
		if (plantInfo == 0)
		{
			return "未命名";
		}
		return plantInfo.name;
	}

	// Token: 0x0600030B RID: 779 RVA: 0x0000CE98 File Offset: 0x0000B098
	[Token(Token = "0x600030B")]
	[Address(RVA = "0x40CC50", Offset = "0x40B250", VA = "0x18040CC50")]
	private void Awake()
	{
		DrawCardManager.Instance = this;
		this.timer = 60f;
		this.InitializePools();
	}

	// Token: 0x0600030C RID: 780 RVA: 0x0000CEBC File Offset: 0x0000B0BC
	[Token(Token = "0x600030C")]
	[Address(RVA = "0x40D5C0", Offset = "0x40BBC0", VA = "0x18040D5C0")]
	private void Start()
	{
		int num;
		do
		{
			num = 0;
			GameObject drawCardsHead = InGameUI.Instance.DrawCardsHead;
			this.textHead = drawCardsHead;
			IEnumerator enumerator = this.textHead.transform.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				bool flag;
				while (!flag)
				{
				}
				List<TextMeshProUGUI> list = this.texts;
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x0600030D RID: 781 RVA: 0x0000CF38 File Offset: 0x0000B138
	[Token(Token = "0x600030D")]
	[Address(RVA = "0x40DBA0", Offset = "0x40C1A0", VA = "0x18040DBA0")]
	private void Update()
	{
		this.textHead.SetActive(true);
		float num = this.timer;
		float deltaTime = Time.deltaTime;
		int num2 = 0;
		this.timer = num;
		if (num2 > (int)num)
		{
			List<PlantType> strongUltiPool = this.StrongUltiPool;
			this.timer = 90f;
			int num3 = strongUltiPool._size;
			num3 = global::UnityEngine.Random.Range(0, num3);
			PlantType plantType = strongUltiPool[num3];
			this.up = plantType;
			int num4 = (int)this.up;
			PlantInfo plantInfo;
			if (plantInfo != 0)
			{
			}
			this.upName = "未命名";
			this.UpdateText();
		}
		float num5 = this.updateTimer;
		float deltaTime2 = Time.deltaTime;
		this.updateTimer = num5;
		this.updateTimer = 1f;
		this.UpdateText();
	}

	// Token: 0x0600030E RID: 782 RVA: 0x0000CFF8 File Offset: 0x0000B1F8
	[Token(Token = "0x600030E")]
	[Address(RVA = "0x40D980", Offset = "0x40BF80", VA = "0x18040D980")]
	private void UpdateText()
	{
		ulong num3;
		do
		{
			int num = this.pullCountSinceLastUlti;
			int num2;
			string text = string.Format("抽取次数：\n{0}/{1}\n", num, num2);
			string text2 = this.upName;
			string text3 = text + "当前up植物：\n" + text2 + "\n";
			string text4 = string.Format("up刷新倒计时：\n{0}", text3);
			string text5 = text3 + text4;
			List<TextMeshProUGUI> list = this.texts;
			bool flag;
			if (flag)
			{
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x0600030F RID: 783 RVA: 0x0000D070 File Offset: 0x0000B270
	[Token(Token = "0x600030F")]
	[Address(RVA = "0x40CFA0", Offset = "0x40B5A0", VA = "0x18040CFA0")]
	public void InitializePools()
	{
		List<PlantType> normalPool = this.GetNormalPool();
		this.NormalPool = normalPool;
		ulong num;
		List<PlantType> allUltimatePlantTypes = TravelHelper.GetAllUltimatePlantTypes(false, num != 0UL);
		this.WeakUltiPool = allUltimatePlantTypes;
		List<PlantType> weakUltiPool = this.WeakUltiPool;
		Predicate<PlantType> <>9__21_ = DrawCardManager.<>c.<>9__21_0;
		if (<>9__21_ == 0)
		{
			DrawCardManager.<>c.<>9__21_0 = delegate(PlantType p)
			{
				bool flag;
				return flag;
			};
		}
		int num2 = weakUltiPool.RemoveAll(<>9__21_);
		ulong num3;
		List<PlantType> allUltimatePlantTypes2 = TravelHelper.GetAllUltimatePlantTypes(num3 != 0UL, num3 != 0UL);
		this.StrongUltiPool = allUltimatePlantTypes2;
		List<PlantType> strongUltiPool = this.StrongUltiPool;
		Predicate<PlantType> predicate;
		if (DrawCardManager.<>c.<>9__21_1 == 0)
		{
			predicate = delegate(PlantType p)
			{
				bool flag2;
				return flag2;
			};
			DrawCardManager.<>c.<>9__21_1 = predicate;
		}
		int num4 = strongUltiPool.RemoveAll(predicate);
		this.pullCountSinceLastUlti = (int)((ulong)0L);
		this.lastPullWasUlti = false;
	}

	// Token: 0x06000310 RID: 784 RVA: 0x0000D12C File Offset: 0x0000B32C
	[Token(Token = "0x6000310")]
	[Address(RVA = "0x40CD30", Offset = "0x40B330", VA = "0x18040CD30")]
	private List<PlantType> GetNormalPool()
	{
		List<PlantType> list;
		ulong num2;
		do
		{
			int num = 0;
			list = new List();
			List<PlantType> allPlants = GameAPP.resourcesManager.allPlants;
			bool flag;
			if (flag)
			{
				if (Lawnf.IsUltiPlant((PlantType)num) || TypeMgr.IsWaterPlant((PlantType)num) || Lawnf.TowerPlant((PlantType)num))
				{
					continue;
				}
				if (num > 1060)
				{
					while (num == 1070)
					{
					}
					while (num == 1120)
					{
					}
				}
				while (num == 1027)
				{
				}
				while (num == 1060)
				{
				}
			}
		}
		while (num2 != (ulong)0L);
		return list;
	}

	// Token: 0x06000311 RID: 785 RVA: 0x0000D1B8 File Offset: 0x0000B3B8
	[Token(Token = "0x6000311")]
	[Address(RVA = "0x40D310", Offset = "0x40B910", VA = "0x18040D310")]
	public List<PlantType> Pull(int pullCount)
	{
		List<PlantType> list = new List();
		int num = 0;
		if (pullCount > 0)
		{
			int num2 = this.pullCountSinceLastUlti;
			if (num2 < 90)
			{
				num2 += -74;
				float num3 = global::UnityEngine.Random.Range((float)0, 1f);
				int num4 = this.NormalPool._size;
				int num5 = global::UnityEngine.Random.Range(0, num4);
				List<PlantType> normalPool = this.NormalPool;
				num4 = num5;
				PlantType plantType = normalPool[num4];
			}
			if ((this.lastPullWasUlti ? 1 : 0) != num)
			{
				PlantType plantType2 = this.UltiPull();
			}
			PlantType plantType3 = this.up;
			this.pullCountSinceLastUlti = num;
			this.lastPullWasUlti = true;
			int size = list._size;
			list._size = num2;
			num++;
		}
		this.UpdateText();
		return list;
	}

	// Token: 0x06000312 RID: 786 RVA: 0x0000D278 File Offset: 0x0000B478
	[Token(Token = "0x6000312")]
	[Address(RVA = "0x40D220", Offset = "0x40B820", VA = "0x18040D220")]
	private PlantType PerformSinglePull()
	{
		int num = this.pullCountSinceLastUlti;
		num++;
		this.pullCountSinceLastUlti = num;
		if (num < 90)
		{
			num += -74;
			float num2 = global::UnityEngine.Random.Range((float)0, 1f);
			float num3;
			if (num3 < num2)
			{
				int num4 = this.NormalPool._size;
				int num5 = global::UnityEngine.Random.Range(0, num4);
				List<PlantType> normalPool = this.NormalPool;
				num4 = num5;
				return normalPool[num4];
			}
		}
		else if (!this.lastPullWasUlti)
		{
			PlantType plantType = this.up;
			this.pullCountSinceLastUlti = (int)((ulong)0L);
			this.lastPullWasUlti = true;
			return plantType;
		}
		return this.UltiPull();
	}

	// Token: 0x06000313 RID: 787 RVA: 0x0000D318 File Offset: 0x0000B518
	[Token(Token = "0x6000313")]
	[Address(RVA = "0x40D880", Offset = "0x40BE80", VA = "0x18040D880")]
	private PlantType UltiPull()
	{
		int num = 0;
		this.pullCountSinceLastUlti = (int)((ulong)0L);
		this.lastPullWasUlti = true;
		float num2 = global::UnityEngine.Random.Range((float)num, 1f);
		if (this.up != PlantType.Peashooter)
		{
			return this.up;
		}
		float num3 = global::UnityEngine.Random.Range((float)0, 1f);
		int num4 = this.StrongUltiPool._size;
		int num5 = global::UnityEngine.Random.Range(0, num4);
		List<PlantType> strongUltiPool = this.StrongUltiPool;
		num4 = num5;
		return strongUltiPool[num4];
	}

	// Token: 0x06000314 RID: 788 RVA: 0x0000D3B0 File Offset: 0x0000B5B0
	[Token(Token = "0x6000314")]
	[Address(RVA = "0x40CF80", Offset = "0x40B580", VA = "0x18040CF80")]
	private PlantType GuaranteedUltiPull()
	{
		if (this.lastPullWasUlti)
		{
			return this.UltiPull();
		}
		PlantType plantType = this.up;
		this.pullCountSinceLastUlti = (int)((ulong)0L);
		this.lastPullWasUlti = true;
		return plantType;
	}

	// Token: 0x06000315 RID: 789 RVA: 0x0000D3E8 File Offset: 0x0000B5E8
	[Token(Token = "0x6000315")]
	[Address(RVA = "0x40D530", Offset = "0x40BB30", VA = "0x18040D530")]
	public void SetUpPlant(PlantType upPlant)
	{
		this.up = upPlant;
		int num = (int)this.up;
		PlantInfo plantInfo;
		if (plantInfo != 0)
		{
		}
		this.upName = "未命名";
		this.UpdateText();
	}

	// Token: 0x06000316 RID: 790 RVA: 0x0000D41C File Offset: 0x0000B61C
	[Token(Token = "0x6000316")]
	[Address(RVA = "0x40DD50", Offset = "0x40C350", VA = "0x18040DD50")]
	public DrawCardManager()
	{
		List<TextMeshProUGUI> list = new List();
		this.texts = list;
		this.upName = "无";
		base..ctor();
	}

	// Token: 0x04000145 RID: 325
	[Token(Token = "0x4000145")]
	public static DrawCardManager Instance;

	// Token: 0x04000146 RID: 326
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000146")]
	private GameObject textHead;

	// Token: 0x04000147 RID: 327
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000147")]
	private readonly List<TextMeshProUGUI> texts;

	// Token: 0x04000148 RID: 328
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000148")]
	public PlantType up;

	// Token: 0x04000149 RID: 329
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000149")]
	private string upName;

	// Token: 0x0400014A RID: 330
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400014A")]
	private float timer;

	// Token: 0x0400014B RID: 331
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400014B")]
	private float updateTimer;

	// Token: 0x0400014C RID: 332
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400014C")]
	private List<PlantType> NormalPool;

	// Token: 0x0400014D RID: 333
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400014D")]
	private List<PlantType> WeakUltiPool;

	// Token: 0x0400014E RID: 334
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400014E")]
	private List<PlantType> StrongUltiPool;

	// Token: 0x0400014F RID: 335
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400014F")]
	private int pullCountSinceLastUlti;

	// Token: 0x04000150 RID: 336
	[Token(Token = "0x4000150")]
	private const float BASE_ULTI_RATE = 0.02f;

	// Token: 0x04000151 RID: 337
	[Token(Token = "0x4000151")]
	private const int PITY_COUNT = 90;

	// Token: 0x04000152 RID: 338
	[Token(Token = "0x4000152")]
	private const int SOFT_PITY_START = 75;

	// Token: 0x04000153 RID: 339
	[Token(Token = "0x4000153")]
	private const float SOFT_PITY_INCREMENT = 0.06f;

	// Token: 0x04000154 RID: 340
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000154")]
	private bool lastPullWasUlti;
}
