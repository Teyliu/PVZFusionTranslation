using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020001F4 RID: 500
[Token(Token = "0x20001F4")]
public class AlmanacCardUI : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerClickHandler, IPointerDownHandler, IPointerExitHandler
{
	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x06000863 RID: 2147 RVA: 0x0002A284 File Offset: 0x00028484
	// (set) Token: 0x06000864 RID: 2148 RVA: 0x0002A298 File Offset: 0x00028498
	[Token(Token = "0x170000A9")]
	public PlantType PlantType
	{
		[Token(Token = "0x6000863")]
		[Address(RVA = "0x41DF70", Offset = "0x41C570", VA = "0x18041DF70")]
		get
		{
			return this._plantType;
		}
		[Token(Token = "0x6000864")]
		[Address(RVA = "0x8E0800", Offset = "0x8DEE00", VA = "0x1808E0800")]
		set
		{
			if (value != PlantType.Nothing)
			{
				this._plantType = value;
				UnlockType unlockType;
				if (unlockType != UnlockType.Unlocked)
				{
					HashSet<PlantType> meetPlant_runTime = GameAPP.config.meetPlant_runTime;
					bool flag;
					if (!flag)
					{
						Sprite sprite = Resources.Load<Sprite>("UI/Spirte/lock");
						this.ChangeSprite(sprite);
						this.shadowMask.enabled = true;
						this.cost.text = "待解锁";
						return;
					}
				}
				Dictionary<PlantType, GameObject> plantPreviews = GameAPP.resourcesManager.plantPreviews;
				bool flag2;
				if (flag2)
				{
					SpriteRenderer spriteRenderer;
					Sprite sprite2 = spriteRenderer.sprite;
					this.ChangeSprite(sprite2);
				}
				string text;
				this.cost.text = text;
				Image image = this.shadowMask;
				int num = 0;
				image.enabled = num != 0;
				return;
			}
		}
	}

	// Token: 0x170000AA RID: 170
	// (get) Token: 0x06000865 RID: 2149 RVA: 0x0002A340 File Offset: 0x00028540
	// (set) Token: 0x06000866 RID: 2150 RVA: 0x0002A354 File Offset: 0x00028554
	[Token(Token = "0x170000AA")]
	public ZombieType ZombieType
	{
		[Token(Token = "0x6000865")]
		[Address(RVA = "0x590AF0", Offset = "0x58F0F0", VA = "0x180590AF0")]
		get
		{
			return this._zombieType;
		}
		[Token(Token = "0x6000866")]
		[Address(RVA = "0x8E0AD0", Offset = "0x8DF0D0", VA = "0x1808E0AD0")]
		set
		{
			Image image = this.shadowMask;
			this._zombieType = value;
			int num = 0;
			image.enabled = num != 0;
			TextMeshProUGUI textMeshProUGUI = this.cost;
			Dictionary<ZombieType, ZombieDataManager.ZombieData> zombieDataDic = ZombieDataManager.zombieDataDic;
			throw new NullReferenceException();
		}
	}

	// Token: 0x06000867 RID: 2151 RVA: 0x0002A390 File Offset: 0x00028590
	[Token(Token = "0x6000867")]
	[Address(RVA = "0x8DF930", Offset = "0x8DDF30", VA = "0x1808DF930")]
	private void Awake()
	{
		Sprite sprite = this.background.m_Sprite;
		this.originalSprite = sprite;
		throw new NullReferenceException();
	}

	// Token: 0x06000868 RID: 2152 RVA: 0x0002A3B8 File Offset: 0x000285B8
	[Token(Token = "0x6000868")]
	[Address(RVA = "0x5906B0", Offset = "0x58ECB0", VA = "0x1805906B0", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
		CursorChange.SetClickCursor();
	}

	// Token: 0x06000869 RID: 2153 RVA: 0x0002A3CC File Offset: 0x000285CC
	[Token(Token = "0x6000869")]
	[Address(RVA = "0x8DFFB0", Offset = "0x8DE5B0", VA = "0x1808DFFB0", Slot = "5")]
	public void OnPointerClick(PointerEventData eventData)
	{
		if (this.onClick != 0)
		{
		}
	}

	// Token: 0x0600086A RID: 2154 RVA: 0x0002A3E4 File Offset: 0x000285E4
	[Token(Token = "0x600086A")]
	[Address(RVA = "0x8DFFD0", Offset = "0x8DE5D0", VA = "0x1808DFFD0", Slot = "6")]
	public void OnPointerDown(PointerEventData eventData)
	{
		if (this.onMouseDown != 0)
		{
		}
		AlmanacSecondMenu almanacSecondMenu = this.menu;
		int num = 0;
		if (!(almanacSecondMenu == num))
		{
			if (this.shadowMask.enabled)
			{
				List<PlantMixTreeManager.MixParentInfo> parents6 = PlantMixTreeManager.GetParents(this._plantType);
				string empty = string.Empty;
				List<PlantType> list = new List();
				List<PlantType> parents = list;
				int num2 = 0;
				if (num2 != 0)
				{
					string text = empty + "或 ";
				}
				string text3;
				string text4;
				string text2 = empty + text3 + "+" + text4;
				int size = parents6._size;
				string text5;
				if (num2 != size)
				{
					text5 = text2 + "\n";
				}
				List<PlantType> parents2 = parents;
				List<PlantType> parents3 = parents;
				num2++;
				if (!string.IsNullOrEmpty(text5))
				{
					InGameText instance = InGameText.Instance;
					List<PlantType> parents4 = parents;
					if (this.menu != 0)
					{
						Func<PlantType, bool> func = delegate(PlantType parent)
						{
							List<PlantType> parents5 = parents;
							bool flag;
							return flag;
						};
						CursorChange.SetDefaultCursor();
					}
				}
				GameAPP.PlaySound(19, 0.5f, 1f);
				throw new NullReferenceException();
			}
			AlmanacSecondMenu almanacSecondMenu2 = this.menu;
			if (almanacSecondMenu2 != 0)
			{
				int num3;
				if (eventData.<button>k__BackingField == PointerEventData.InputButton.Left && global::Lawnf.IsBasicPlant(this._plantType))
				{
					PlantType plantType = this._plantType;
					num3 = 0;
					CursorChange.SetDefaultCursor();
				}
				if (num3 != 0 && almanacSecondMenu2 != 0)
				{
					ZombieType zombieType = this._zombieType;
				}
			}
			GameAPP.PlaySound(19, 0.5f, 1f);
			if (eventData.<button>k__BackingField == PointerEventData.InputButton.Right && this.menu != 0)
			{
				CursorChange.SetDefaultCursor();
			}
			ExploreMakeMenu instance2 = ExploreMakeMenu.Instance;
			int num4 = 0;
			if (instance2 != num4)
			{
				ExploreMakeMenu instance3 = ExploreMakeMenu.Instance;
				PlantType plantType2 = this._plantType;
				instance3.selectedPlantType = plantType2;
			}
		}
	}

	// Token: 0x0600086B RID: 2155 RVA: 0x0002A5A0 File Offset: 0x000287A0
	[Token(Token = "0x600086B")]
	[Address(RVA = "0x575490", Offset = "0x573A90", VA = "0x180575490", Slot = "7")]
	public void OnPointerExit(PointerEventData eventData)
	{
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x0600086C RID: 2156 RVA: 0x0002A5B4 File Offset: 0x000287B4
	[Token(Token = "0x600086C")]
	[Address(RVA = "0x8DF960", Offset = "0x8DDF60", VA = "0x1808DF960")]
	private void ChangeSprite(Sprite sprite)
	{
		this.image.sprite = sprite;
		Transform transform = this.image.transform;
		this.image.SetNativeSize();
	}

	// Token: 0x0600086D RID: 2157 RVA: 0x0002A5F0 File Offset: 0x000287F0
	[Token(Token = "0x600086D")]
	[Address(RVA = "0x8DFC80", Offset = "0x8DE280", VA = "0x1808DFC80")]
	private void ChangeSprite(PlantType thePlantType)
	{
		Dictionary<PlantType, GameObject> plantPreviews = GameAPP.resourcesManager.plantPreviews;
		bool flag;
		if (flag)
		{
			SpriteRenderer spriteRenderer;
			Sprite sprite = spriteRenderer.sprite;
			this.ChangeSprite(sprite);
		}
	}

	// Token: 0x0600086E RID: 2158 RVA: 0x0002A624 File Offset: 0x00028824
	[Token(Token = "0x600086E")]
	[Address(RVA = "0x8DFAB0", Offset = "0x8DE0B0", VA = "0x1808DFAB0")]
	private void ChangeSprite(ZombieType theZombieType)
	{
		Image image = this.image;
		int num = 0;
		Transform transform = image.transform;
		Dictionary<ZombieType, Sprite> zombieSprites = GameAPP.resourcesManager.zombieSprites;
		bool flag;
		if (flag || transform != 0)
		{
			if (transform != 0)
			{
			}
			this.image.sprite = num;
		}
		this.image.SetNativeSize();
	}

	// Token: 0x0600086F RID: 2159 RVA: 0x0002A67C File Offset: 0x0002887C
	[Token(Token = "0x600086F")]
	[Address(RVA = "0x8DFD70", Offset = "0x8DE370", VA = "0x1808DFD70")]
	public void FakeHide()
	{
		int num;
		do
		{
			num = 0;
			Image component = base.GetComponent<Image>();
			int num2 = 0;
			component.enabled = num2 != 0;
			IEnumerator enumerator = base.transform.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				int num3 = 0;
				GameObject gameObject;
				gameObject.SetActive(num3 != 0);
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x06000870 RID: 2160 RVA: 0x0002A6F0 File Offset: 0x000288F0
	[Token(Token = "0x6000870")]
	[Address(RVA = "0x8E05C0", Offset = "0x8DEBC0", VA = "0x1808E05C0")]
	public void UnHide()
	{
		int num;
		do
		{
			num = 0;
			ulong num2;
			base.GetComponent<Image>().enabled = num2 != 0UL;
			IEnumerator enumerator = base.transform.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				GameObject gameObject;
				ulong num3;
				gameObject.SetActive(num3 != 0UL);
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x06000871 RID: 2161 RVA: 0x0002A75C File Offset: 0x0002895C
	[Token(Token = "0x6000871")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public AlmanacCardUI()
	{
	}

	// Token: 0x040003D4 RID: 980
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003D4")]
	private PlantType _plantType;

	// Token: 0x040003D5 RID: 981
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40003D5")]
	private ZombieType _zombieType;

	// Token: 0x040003D6 RID: 982
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003D6")]
	public PlantType realType;

	// Token: 0x040003D7 RID: 983
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40003D7")]
	[Header("引用")]
	public AlmanacSecondMenu menu;

	// Token: 0x040003D8 RID: 984
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40003D8")]
	public Image image;

	// Token: 0x040003D9 RID: 985
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40003D9")]
	public Image shadowMask;

	// Token: 0x040003DA RID: 986
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40003DA")]
	public TextMeshProUGUI cost;

	// Token: 0x040003DB RID: 987
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40003DB")]
	public Image background;

	// Token: 0x040003DC RID: 988
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40003DC")]
	public Sprite originalSprite;

	// Token: 0x040003DD RID: 989
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40003DD")]
	public Sprite selectedSprite;

	// Token: 0x040003DE RID: 990
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40003DE")]
	public Action<AlmanacCardUI> onClick;

	// Token: 0x040003DF RID: 991
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40003DF")]
	public Action<AlmanacCardUI> onMouseDown;
}
