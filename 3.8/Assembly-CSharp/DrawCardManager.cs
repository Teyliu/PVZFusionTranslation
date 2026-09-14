using System;
using System.Collections;
using System.Collections.Generic;
using AlmanacData;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020000A9 RID: 169
[Token(Token = "0x20000A9")]
public class DrawCardManager : MonoBehaviour
{
	// Token: 0x060002EF RID: 751 RVA: 0x0000CAD4 File Offset: 0x0000ACD4
	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x3BFF10", Offset = "0x3BE510", VA = "0x1803BFF10")]
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

	// Token: 0x060002F0 RID: 752 RVA: 0x0000CAFC File Offset: 0x0000ACFC
	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x3BFEA0", Offset = "0x3BE4A0", VA = "0x1803BFEA0")]
	private void Awake()
	{
		DrawCardManager.Instance = this;
		this.timer = 60f;
		this.InitializePools();
	}

	// Token: 0x060002F1 RID: 753 RVA: 0x0000CB20 File Offset: 0x0000AD20
	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x3C0810", Offset = "0x3BEE10", VA = "0x1803C0810")]
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

	// Token: 0x060002F2 RID: 754 RVA: 0x0000CB9C File Offset: 0x0000AD9C
	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x3C0DF0", Offset = "0x3BF3F0", VA = "0x1803C0DF0")]
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

	// Token: 0x060002F3 RID: 755 RVA: 0x0000CC5C File Offset: 0x0000AE5C
	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x3C0BD0", Offset = "0x3BF1D0", VA = "0x1803C0BD0")]
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

	// Token: 0x060002F4 RID: 756 RVA: 0x0000CCD4 File Offset: 0x0000AED4
	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x3C01F0", Offset = "0x3BE7F0", VA = "0x1803C01F0")]
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

	// Token: 0x060002F5 RID: 757 RVA: 0x0000CD90 File Offset: 0x0000AF90
	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x3BFF80", Offset = "0x3BE580", VA = "0x1803BFF80")]
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

	// Token: 0x060002F6 RID: 758 RVA: 0x0000CE1C File Offset: 0x0000B01C
	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x3C0560", Offset = "0x3BEB60", VA = "0x1803C0560")]
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

	// Token: 0x060002F7 RID: 759 RVA: 0x0000CEDC File Offset: 0x0000B0DC
	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x3C0470", Offset = "0x3BEA70", VA = "0x1803C0470")]
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

	// Token: 0x060002F8 RID: 760 RVA: 0x0000CF7C File Offset: 0x0000B17C
	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x3C0AD0", Offset = "0x3BF0D0", VA = "0x1803C0AD0")]
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

	// Token: 0x060002F9 RID: 761 RVA: 0x0000D014 File Offset: 0x0000B214
	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x3C01D0", Offset = "0x3BE7D0", VA = "0x1803C01D0")]
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

	// Token: 0x060002FA RID: 762 RVA: 0x0000D04C File Offset: 0x0000B24C
	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x3C0780", Offset = "0x3BED80", VA = "0x1803C0780")]
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

	// Token: 0x060002FB RID: 763 RVA: 0x0000D080 File Offset: 0x0000B280
	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x3C0FA0", Offset = "0x3BF5A0", VA = "0x1803C0FA0")]
	public DrawCardManager()
	{
		List<TextMeshProUGUI> list = new List();
		this.texts = list;
		this.upName = "无";
		base..ctor();
	}

	// Token: 0x04000138 RID: 312
	[Token(Token = "0x4000138")]
	public static DrawCardManager Instance;

	// Token: 0x04000139 RID: 313
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000139")]
	private GameObject textHead;

	// Token: 0x0400013A RID: 314
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400013A")]
	private readonly List<TextMeshProUGUI> texts;

	// Token: 0x0400013B RID: 315
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400013B")]
	public PlantType up;

	// Token: 0x0400013C RID: 316
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400013C")]
	private string upName;

	// Token: 0x0400013D RID: 317
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400013D")]
	private float timer;

	// Token: 0x0400013E RID: 318
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400013E")]
	private float updateTimer;

	// Token: 0x0400013F RID: 319
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400013F")]
	private List<PlantType> NormalPool;

	// Token: 0x04000140 RID: 320
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000140")]
	private List<PlantType> WeakUltiPool;

	// Token: 0x04000141 RID: 321
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000141")]
	private List<PlantType> StrongUltiPool;

	// Token: 0x04000142 RID: 322
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000142")]
	private int pullCountSinceLastUlti;

	// Token: 0x04000143 RID: 323
	[Token(Token = "0x4000143")]
	private const float BASE_ULTI_RATE = 0.02f;

	// Token: 0x04000144 RID: 324
	[Token(Token = "0x4000144")]
	private const int PITY_COUNT = 90;

	// Token: 0x04000145 RID: 325
	[Token(Token = "0x4000145")]
	private const int SOFT_PITY_START = 75;

	// Token: 0x04000146 RID: 326
	[Token(Token = "0x4000146")]
	private const float SOFT_PITY_INCREMENT = 0.06f;

	// Token: 0x04000147 RID: 327
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000147")]
	private bool lastPullWasUlti;
}
