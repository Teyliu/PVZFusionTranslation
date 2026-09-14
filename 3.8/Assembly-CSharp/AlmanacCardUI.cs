using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020001ED RID: 493
[Token(Token = "0x20001ED")]
public class AlmanacCardUI : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerClickHandler, IPointerDownHandler, IPointerExitHandler
{
	// Token: 0x1700006C RID: 108
	// (get) Token: 0x06000849 RID: 2121 RVA: 0x0002A294 File Offset: 0x00028494
	// (set) Token: 0x0600084A RID: 2122 RVA: 0x0002A2A8 File Offset: 0x000284A8
	[Token(Token = "0x1700006C")]
	public PlantType PlantType
	{
		[Token(Token = "0x6000849")]
		[Address(RVA = "0x3D1110", Offset = "0x3CF710", VA = "0x1803D1110")]
		get
		{
			return this._plantType;
		}
		[Token(Token = "0x600084A")]
		[Address(RVA = "0x8525C0", Offset = "0x850BC0", VA = "0x1808525C0")]
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

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x0600084B RID: 2123 RVA: 0x0002A350 File Offset: 0x00028550
	// (set) Token: 0x0600084C RID: 2124 RVA: 0x0002A364 File Offset: 0x00028564
	[Token(Token = "0x1700006D")]
	public ZombieType ZombieType
	{
		[Token(Token = "0x600084B")]
		[Address(RVA = "0x525960", Offset = "0x523F60", VA = "0x180525960")]
		get
		{
			return this._zombieType;
		}
		[Token(Token = "0x600084C")]
		[Address(RVA = "0x852890", Offset = "0x850E90", VA = "0x180852890")]
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

	// Token: 0x0600084D RID: 2125 RVA: 0x0002A3A0 File Offset: 0x000285A0
	[Token(Token = "0x600084D")]
	[Address(RVA = "0x851700", Offset = "0x84FD00", VA = "0x180851700")]
	private void Awake()
	{
		Sprite sprite = this.background.m_Sprite;
		this.originalSprite = sprite;
		throw new NullReferenceException();
	}

	// Token: 0x0600084E RID: 2126 RVA: 0x0002A3C8 File Offset: 0x000285C8
	[Token(Token = "0x600084E")]
	[Address(RVA = "0x525520", Offset = "0x523B20", VA = "0x180525520", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
		CursorChange.SetClickCursor();
	}

	// Token: 0x0600084F RID: 2127 RVA: 0x0002A3DC File Offset: 0x000285DC
	[Token(Token = "0x600084F")]
	[Address(RVA = "0x851D80", Offset = "0x850380", VA = "0x180851D80", Slot = "5")]
	public void OnPointerClick(PointerEventData eventData)
	{
		if (this.onClick != 0)
		{
		}
	}

	// Token: 0x06000850 RID: 2128 RVA: 0x0002A3F4 File Offset: 0x000285F4
	[Token(Token = "0x6000850")]
	[Address(RVA = "0x851DA0", Offset = "0x8503A0", VA = "0x180851DA0", Slot = "6")]
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
					int num3 = 0;
					instance.ShowText(text5, 1f, num3 != 0);
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
				int num4;
				if (eventData.<button>k__BackingField == PointerEventData.InputButton.Left && global::Lawnf.IsBasicPlant(this._plantType))
				{
					PlantType plantType = this._plantType;
					num4 = 0;
					CursorChange.SetDefaultCursor();
				}
				if (num4 != 0 && almanacSecondMenu2 != 0)
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
			int num5 = 0;
			if (instance2 != num5)
			{
				ExploreMakeMenu instance3 = ExploreMakeMenu.Instance;
				PlantType plantType2 = this._plantType;
				instance3.selectedPlantType = plantType2;
			}
		}
	}

	// Token: 0x06000851 RID: 2129 RVA: 0x0002A5C4 File Offset: 0x000287C4
	[Token(Token = "0x6000851")]
	[Address(RVA = "0x51B300", Offset = "0x519900", VA = "0x18051B300", Slot = "7")]
	public void OnPointerExit(PointerEventData eventData)
	{
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06000852 RID: 2130 RVA: 0x0002A5D8 File Offset: 0x000287D8
	[Token(Token = "0x6000852")]
	[Address(RVA = "0x851730", Offset = "0x84FD30", VA = "0x180851730")]
	private void ChangeSprite(Sprite sprite)
	{
		this.image.sprite = sprite;
		Transform transform = this.image.transform;
		this.image.SetNativeSize();
	}

	// Token: 0x06000853 RID: 2131 RVA: 0x0002A614 File Offset: 0x00028814
	[Token(Token = "0x6000853")]
	[Address(RVA = "0x851A50", Offset = "0x850050", VA = "0x180851A50")]
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

	// Token: 0x06000854 RID: 2132 RVA: 0x0002A648 File Offset: 0x00028848
	[Token(Token = "0x6000854")]
	[Address(RVA = "0x851880", Offset = "0x84FE80", VA = "0x180851880")]
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

	// Token: 0x06000855 RID: 2133 RVA: 0x0002A6A0 File Offset: 0x000288A0
	[Token(Token = "0x6000855")]
	[Address(RVA = "0x851B40", Offset = "0x850140", VA = "0x180851B40")]
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

	// Token: 0x06000856 RID: 2134 RVA: 0x0002A714 File Offset: 0x00028914
	[Token(Token = "0x6000856")]
	[Address(RVA = "0x852380", Offset = "0x850980", VA = "0x180852380")]
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

	// Token: 0x06000857 RID: 2135 RVA: 0x0002A780 File Offset: 0x00028980
	[Token(Token = "0x6000857")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public AlmanacCardUI()
	{
	}

	// Token: 0x040003CA RID: 970
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003CA")]
	private PlantType _plantType;

	// Token: 0x040003CB RID: 971
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40003CB")]
	private ZombieType _zombieType;

	// Token: 0x040003CC RID: 972
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003CC")]
	public PlantType realType;

	// Token: 0x040003CD RID: 973
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40003CD")]
	[Header("引用")]
	public AlmanacSecondMenu menu;

	// Token: 0x040003CE RID: 974
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40003CE")]
	public Image image;

	// Token: 0x040003CF RID: 975
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40003CF")]
	public Image shadowMask;

	// Token: 0x040003D0 RID: 976
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40003D0")]
	public TextMeshProUGUI cost;

	// Token: 0x040003D1 RID: 977
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40003D1")]
	public Image background;

	// Token: 0x040003D2 RID: 978
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40003D2")]
	public Sprite originalSprite;

	// Token: 0x040003D3 RID: 979
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40003D3")]
	public Sprite selectedSprite;

	// Token: 0x040003D4 RID: 980
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40003D4")]
	public Action<AlmanacCardUI> onClick;

	// Token: 0x040003D5 RID: 981
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40003D5")]
	public Action<AlmanacCardUI> onMouseDown;
}
