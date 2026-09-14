using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using GameLevel;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000A05 RID: 2565
[Token(Token = "0x2000A05")]
public class CustomMenuPage_initZombies : CustomMenu_page
{
	// Token: 0x1700025C RID: 604
	// (get) Token: 0x060034B0 RID: 13488 RVA: 0x00116104 File Offset: 0x00114304
	[Token(Token = "0x1700025C")]
	private int Row
	{
		[Token(Token = "0x60034B0")]
		[Address(RVA = "0x763640", Offset = "0x761C40", VA = "0x180763640")]
		get
		{
			ulong num;
			if (!int.TryParse(this.input.m_Text, (int)num))
			{
				return -1;
			}
			throw new NullReferenceException();
		}
	}

	// Token: 0x060034B1 RID: 13489 RVA: 0x00116130 File Offset: 0x00114330
	[Token(Token = "0x60034B1")]
	[Address(RVA = "0x763110", Offset = "0x761710", VA = "0x180763110", Slot = "4")]
	public override void LoadOriginalSettings()
	{
		this.UpdateWaveText();
	}

	// Token: 0x060034B2 RID: 13490 RVA: 0x00116144 File Offset: 0x00114344
	[Token(Token = "0x60034B2")]
	[Address(RVA = "0x7632B0", Offset = "0x7618B0", VA = "0x1807632B0")]
	private void UpdateWaveText()
	{
		int num;
		do
		{
			num = 0;
			TextMeshProUGUI textMeshProUGUI = this.currentWaveText;
			int num2 = this.currentWave;
			string text = string.Format("第{0}波", num2);
			textMeshProUGUI.text = text;
			IEnumerator enumerator = this.content2.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				GameObject gameObject;
				global::UnityEngine.Object.Destroy(gameObject);
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
		Func<OrderedSpawn, bool> func;
		OrderedSpawn orderedSpawn = Enumerable.FirstOrDefault<OrderedSpawn>(CustomMenu._levelData.orderedSpawns, func);
		if (orderedSpawn != 0)
		{
			List<ZombieSpawnData> zombies = orderedSpawn.Zombies;
		}
	}

	// Token: 0x060034B3 RID: 13491 RVA: 0x001161E8 File Offset: 0x001143E8
	[Token(Token = "0x60034B3")]
	[Address(RVA = "0x762330", Offset = "0x760930", VA = "0x180762330")]
	public void AddWave()
	{
		int num = this.currentWave;
		num++;
		this.currentWave = num;
		SerializedLevelData levelData = CustomMenu._levelData;
		if (num > levelData.maxWave)
		{
			if ((ulong)1L == 0UL)
			{
			}
			int maxWave = CustomMenu._levelData.maxWave;
			this.currentWave = maxWave;
		}
		this.UpdateWaveText();
	}

	// Token: 0x060034B4 RID: 13492 RVA: 0x0011623C File Offset: 0x0011443C
	[Token(Token = "0x60034B4")]
	[Address(RVA = "0x763270", Offset = "0x761870", VA = "0x180763270")]
	public void SubWave()
	{
		int num = this.currentWave;
		this.currentWave = num;
		if (num < 1)
		{
			this.currentWave = (int)((ulong)1L);
		}
		this.UpdateWaveText();
	}

	// Token: 0x060034B5 RID: 13493 RVA: 0x0011626C File Offset: 0x0011446C
	[Token(Token = "0x60034B5")]
	[Address(RVA = "0x762B00", Offset = "0x761100", VA = "0x180762B00", Slot = "5")]
	public override void InitPage()
	{
		ulong num3;
		do
		{
			GameObject gameObject = Resources.Load<GameObject>("UI/Cards/Prefab/SampleCard");
			int num = 0;
			if (gameObject == num)
			{
				break;
			}
			int num2 = GameAPP.resourcesManager.zombiePrefabs.Count;
			RectTransform rectTransform = this.content;
			num2++;
			Dictionary<ZombieType, GameObject> zombiePrefabs = GameAPP.resourcesManager.zombiePrefabs;
			bool flag;
			if (flag)
			{
				CustomMenuPage_initZombies.<>c__DisplayClass13_0 CS$<>8__locals1;
				CS$<>8__locals1.<>4__this = this;
				CS$<>8__locals1.cardPrefab = gameObject;
				GameObject cardPrefab = CS$<>8__locals1.cardPrefab;
				Transform transform = this.content.transform;
				TheCard component = global::UnityEngine.Object.Instantiate<GameObject>(cardPrefab, transform).GetComponent<TheCard>();
				component.isZombieCard = true;
				UnityAction<TheCard> unityAction;
				component.clickEvent.AddListener(unityAction);
			}
		}
		while (num3 != (ulong)0L);
		Debug.LogError("无法加载卡片预制体");
	}

	// Token: 0x060034B6 RID: 13494 RVA: 0x00116348 File Offset: 0x00114548
	[Token(Token = "0x60034B6")]
	[Address(RVA = "0x762F40", Offset = "0x761540", VA = "0x180762F40")]
	private void InitShowedZombieCards(List<ZombieSpawnData> zombies)
	{
		ulong num3;
		do
		{
			int num = 0;
			GameObject gameObject = Resources.Load<GameObject>("UI/Cards/Prefab/SampleCard");
			int num2 = 0;
			if (gameObject == num2)
			{
				break;
			}
			bool flag;
			if (flag)
			{
				this.CreateShowCard(num, gameObject);
			}
		}
		while (num3 != (ulong)0L);
		Debug.LogError("无法加载卡片预制体");
	}

	// Token: 0x060034B7 RID: 13495 RVA: 0x00116390 File Offset: 0x00114590
	[Token(Token = "0x60034B7")]
	[Address(RVA = "0x762980", Offset = "0x760F80", VA = "0x180762980")]
	private void CreateZombieCard(ZombieType zombieType, GameObject cardPrefab)
	{
		RectTransform rectTransform = this.content;
		GameObject cardPrefab2 = cardPrefab;
		Transform transform = rectTransform.transform;
		TheCard component = global::UnityEngine.Object.Instantiate<GameObject>(cardPrefab2, transform).GetComponent<TheCard>();
		UnityEvent<TheCard> clickEvent = component.clickEvent;
		component.theZombieType = zombieType;
		component.isZombieCard = true;
		UnityAction<TheCard> unityAction;
		clickEvent.AddListener(unityAction);
	}

	// Token: 0x060034B8 RID: 13496 RVA: 0x00116404 File Offset: 0x00114604
	[Token(Token = "0x60034B8")]
	[Address(RVA = "0x762710", Offset = "0x760D10", VA = "0x180762710")]
	private void CreateShowCard(ZombieSpawnData data, GameObject cardPrefab)
	{
		Transform transform = this.content2.transform;
		TheCard component = global::UnityEngine.Object.Instantiate<GameObject>(cardPrefab, transform).GetComponent<TheCard>();
		ZombieSpawnData data2 = data;
		ZombieType zombieType;
		component.theZombieType = zombieType;
		component.isZombieCard = true;
		ZombieSpawnData data3 = data;
		int num = data3.row;
		TextMeshProUGUI costText = component.costText;
		num++;
		string text = string.Format("第{0}行", data3);
		costText.text = text;
		UnityAction<TheCard> unityAction;
		component.clickEvent.AddListener(unityAction);
		RectTransform rectTransform = this.content2;
		int num2 = 0;
		int num3 = rectTransform.childCount;
		RectTransform rectTransform2 = this.content2;
		num3 += num2;
		num3++;
		rectTransform2.sizeDelta = num2;
	}

	// Token: 0x060034B9 RID: 13497 RVA: 0x001164D0 File Offset: 0x001146D0
	[Token(Token = "0x60034B9")]
	[Address(RVA = "0x763120", Offset = "0x761720", VA = "0x180763120")]
	private void RemoveZombieTypeFromWave(ZombieSpawnData data, int wave)
	{
		List<OrderedSpawn> orderedSpawns = CustomMenu._levelData.orderedSpawns;
		Func<OrderedSpawn, bool> func = delegate(OrderedSpawn a)
		{
			int wave2 = wave;
			return a.wave == wave2;
		};
		OrderedSpawn orderedSpawn = Enumerable.FirstOrDefault<OrderedSpawn>(orderedSpawns, func);
		if (orderedSpawn != 0)
		{
			bool flag = orderedSpawn.Zombies.Remove(data);
		}
	}

	// Token: 0x060034BA RID: 13498 RVA: 0x00116524 File Offset: 0x00114724
	[Token(Token = "0x60034BA")]
	[Address(RVA = "0x7623F0", Offset = "0x7609F0", VA = "0x1807623F0")]
	private ZombieSpawnData AddZombieTypeToWave(ZombieType zombieType, int wave)
	{
		List<OrderedSpawn> orderedSpawns = CustomMenu._levelData.orderedSpawns;
		Func<OrderedSpawn, bool> func = delegate(OrderedSpawn a)
		{
			int wave3 = wave;
			return a.wave == wave3;
		};
		OrderedSpawn orderedSpawn = Enumerable.FirstOrDefault<OrderedSpawn>(orderedSpawns, func);
		if (orderedSpawn == 0)
		{
			OrderedSpawn orderedSpawn2 = new OrderedSpawn();
			int wave2 = wave;
			orderedSpawn2.wave = wave2;
			List<OrderedSpawn> orderedSpawns2 = CustomMenu._levelData.orderedSpawns;
			int size = orderedSpawns2._size;
			orderedSpawns2._size = typeof(CustomMenu).TypeHandle;
		}
		string text = this.input.m_Text;
		ulong num;
		if (!int.TryParse(text, (int)num))
		{
		}
		ZombieSpawnData zombieSpawnData;
		zombieSpawnData.row = (int)num;
		int size2 = orderedSpawn.Zombies._size;
		return zombieSpawnData;
	}

	// Token: 0x060034BB RID: 13499 RVA: 0x001165D8 File Offset: 0x001147D8
	[Token(Token = "0x60034BB")]
	[Address(RVA = "0x763630", Offset = "0x761C30", VA = "0x180763630")]
	public CustomMenuPage_initZombies()
	{
	}

	// Token: 0x0400261B RID: 9755
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400261B")]
	public RectTransform content;

	// Token: 0x0400261C RID: 9756
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400261C")]
	public RectTransform content2;

	// Token: 0x0400261D RID: 9757
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400261D")]
	public TextMeshProUGUI currentWaveText;

	// Token: 0x0400261E RID: 9758
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400261E")]
	private int currentWave = (int)((ulong)1L);

	// Token: 0x0400261F RID: 9759
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400261F")]
	public TMP_InputField input;
}
