using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using GameLevel;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020009C9 RID: 2505
[Token(Token = "0x20009C9")]
public class CustomMenuPage_initZombies : CustomMenu_page
{
	// Token: 0x17000214 RID: 532
	// (get) Token: 0x0600337C RID: 13180 RVA: 0x001110F0 File Offset: 0x0010F2F0
	[Token(Token = "0x17000214")]
	private int Row
	{
		[Token(Token = "0x600337C")]
		[Address(RVA = "0x6FE220", Offset = "0x6FC820", VA = "0x1806FE220")]
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

	// Token: 0x0600337D RID: 13181 RVA: 0x0011111C File Offset: 0x0010F31C
	[Token(Token = "0x600337D")]
	[Address(RVA = "0x6FDCF0", Offset = "0x6FC2F0", VA = "0x1806FDCF0", Slot = "4")]
	public override void LoadOriginalSettings()
	{
		this.UpdateWaveText();
	}

	// Token: 0x0600337E RID: 13182 RVA: 0x00111130 File Offset: 0x0010F330
	[Token(Token = "0x600337E")]
	[Address(RVA = "0x6FDE90", Offset = "0x6FC490", VA = "0x1806FDE90")]
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

	// Token: 0x0600337F RID: 13183 RVA: 0x001111D4 File Offset: 0x0010F3D4
	[Token(Token = "0x600337F")]
	[Address(RVA = "0x6FCF10", Offset = "0x6FB510", VA = "0x1806FCF10")]
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

	// Token: 0x06003380 RID: 13184 RVA: 0x00111228 File Offset: 0x0010F428
	[Token(Token = "0x6003380")]
	[Address(RVA = "0x6FDE50", Offset = "0x6FC450", VA = "0x1806FDE50")]
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

	// Token: 0x06003381 RID: 13185 RVA: 0x00111258 File Offset: 0x0010F458
	[Token(Token = "0x6003381")]
	[Address(RVA = "0x6FD6E0", Offset = "0x6FBCE0", VA = "0x1806FD6E0", Slot = "5")]
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

	// Token: 0x06003382 RID: 13186 RVA: 0x00111334 File Offset: 0x0010F534
	[Token(Token = "0x6003382")]
	[Address(RVA = "0x6FDB20", Offset = "0x6FC120", VA = "0x1806FDB20")]
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

	// Token: 0x06003383 RID: 13187 RVA: 0x0011137C File Offset: 0x0010F57C
	[Token(Token = "0x6003383")]
	[Address(RVA = "0x6FD560", Offset = "0x6FBB60", VA = "0x1806FD560")]
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

	// Token: 0x06003384 RID: 13188 RVA: 0x001113F0 File Offset: 0x0010F5F0
	[Token(Token = "0x6003384")]
	[Address(RVA = "0x6FD2F0", Offset = "0x6FB8F0", VA = "0x1806FD2F0")]
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

	// Token: 0x06003385 RID: 13189 RVA: 0x001114BC File Offset: 0x0010F6BC
	[Token(Token = "0x6003385")]
	[Address(RVA = "0x6FDD00", Offset = "0x6FC300", VA = "0x1806FDD00")]
	private void RemoveZombieTypeFromWave(ZombieSpawnData data, int wave)
	{
		new CustomMenuPage_initZombies.<>c__DisplayClass15_0().wave = wave;
		Func<OrderedSpawn, bool> func;
		OrderedSpawn orderedSpawn = Enumerable.FirstOrDefault<OrderedSpawn>(CustomMenu._levelData.orderedSpawns, func);
		if (orderedSpawn != 0)
		{
			bool flag = orderedSpawn.Zombies.Remove(data);
		}
	}

	// Token: 0x06003386 RID: 13190 RVA: 0x00111500 File Offset: 0x0010F700
	[Token(Token = "0x6003386")]
	[Address(RVA = "0x6FCFD0", Offset = "0x6FB5D0", VA = "0x1806FCFD0")]
	private ZombieSpawnData AddZombieTypeToWave(ZombieType zombieType, int wave)
	{
		Func<OrderedSpawn, bool> func;
		OrderedSpawn orderedSpawn = Enumerable.FirstOrDefault<OrderedSpawn>(CustomMenu._levelData.orderedSpawns, func);
		if (orderedSpawn == 0)
		{
			OrderedSpawn orderedSpawn2 = new OrderedSpawn();
			int wave2 = wave;
			orderedSpawn2.wave = wave2;
			List<OrderedSpawn> orderedSpawns = CustomMenu._levelData.orderedSpawns;
			int size = orderedSpawns._size;
			orderedSpawns._size = typeof(CustomMenu).TypeHandle;
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

	// Token: 0x06003387 RID: 13191 RVA: 0x001115A4 File Offset: 0x0010F7A4
	[Token(Token = "0x6003387")]
	[Address(RVA = "0x6FE210", Offset = "0x6FC810", VA = "0x1806FE210")]
	public CustomMenuPage_initZombies()
	{
	}

	// Token: 0x04002509 RID: 9481
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002509")]
	public RectTransform content;

	// Token: 0x0400250A RID: 9482
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400250A")]
	public RectTransform content2;

	// Token: 0x0400250B RID: 9483
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400250B")]
	public TextMeshProUGUI currentWaveText;

	// Token: 0x0400250C RID: 9484
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400250C")]
	private int currentWave = (int)((ulong)1L);

	// Token: 0x0400250D RID: 9485
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400250D")]
	public TMP_InputField input;
}
