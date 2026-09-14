using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020002CE RID: 718
[Token(Token = "0x20002CE")]
public class HealthSlider : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
{
	// Token: 0x170000E2 RID: 226
	// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x000486D4 File Offset: 0x000468D4
	// (set) Token: 0x06000CBA RID: 3258 RVA: 0x000486F0 File Offset: 0x000468F0
	[Token(Token = "0x170000E2")]
	private Color FillColor
	{
		[Token(Token = "0x6000CB9")]
		[Address(RVA = "0x433840", Offset = "0x431E40", VA = "0x180433840")]
		get
		{
			throw new NullReferenceException();
		}
		[Token(Token = "0x6000CBA")]
		[Address(RVA = "0x433940", Offset = "0x431F40", VA = "0x180433940")]
		set
		{
			Image image = this.healthFill;
		}
	}

	// Token: 0x170000E3 RID: 227
	// (get) Token: 0x06000CBB RID: 3259 RVA: 0x0004870C File Offset: 0x0004690C
	// (set) Token: 0x06000CBC RID: 3260 RVA: 0x0004872C File Offset: 0x0004692C
	[Token(Token = "0x170000E3")]
	public float HealthValue
	{
		[Token(Token = "0x6000CBB")]
		[Address(RVA = "0x433880", Offset = "0x431E80", VA = "0x180433880")]
		get
		{
			return this.healthFill.m_FillAmount;
		}
		[Token(Token = "0x6000CBC")]
		[Address(RVA = "0x433980", Offset = "0x431F80", VA = "0x180433980")]
		set
		{
			this.healthFill.fillAmount = value;
			Plant plant = this.follow;
			TextMeshProUGUI textMeshProUGUI = this.fillText;
			int thePlantHealth = plant.thePlantHealth;
			string text = string.Format("{0}", thePlantHealth);
			textMeshProUGUI.text = text;
			if (this.follow.theShieldHealth > 0)
			{
				TextMeshProUGUI textMeshProUGUI2 = this.fillText;
				string text2 = textMeshProUGUI2.text;
				Plant plant2 = this.follow;
				string text3 = string.Format("+{0}", text2);
				string text4 = text2 + text3;
				textMeshProUGUI2.text = text4;
			}
			CrackStatus crackStatus = Lawnf.GetCrackStatus(value, 1f);
			if (crackStatus != CrackStatus.Good)
			{
				if (crackStatus != CrackStatus.Good)
				{
					if (crackStatus != CrackStatus.Normal)
					{
						goto IL_00B1;
					}
					Image image = this.healthFill;
				}
				Image image2 = this.healthFill;
			}
			Image image3 = this.healthFill;
			IL_00B1:
			if (this.healthText.gameObject.activeInHierarchy)
			{
				Plant plant3 = this.follow;
				TextMeshProUGUI textMeshProUGUI3 = this.healthText;
				string text6;
				if (plant3.theShieldHealth == 0)
				{
					int num = plant3.thePlantHealth;
					int thePlantMaxHealth = plant3.thePlantMaxHealth;
					string text5;
					if (plant3.thePlantHealth == thePlantMaxHealth)
					{
						num = thePlantMaxHealth;
						text5 = string.Format("{0}", num);
					}
					Plant plant4 = this.follow;
					text6 = string.Format("{0}/{1}", text5, text5);
				}
				Plant plant5 = this.follow;
				Plant plant6 = this.follow;
				string text7 = string.Format("{0}+{1}/{2}", text6, text6, text6);
				textMeshProUGUI3.text = text7;
				Board instance = Board.Instance;
				TextMeshProUGUI textMeshProUGUI4 = this.healthText;
				Image image4 = this.healthFill;
				Plant plant7 = this.follow;
			}
		}
	}

	// Token: 0x170000E4 RID: 228
	// (get) Token: 0x06000CBD RID: 3261 RVA: 0x000488B4 File Offset: 0x00046AB4
	// (set) Token: 0x06000CBE RID: 3262 RVA: 0x000488D4 File Offset: 0x00046AD4
	[Token(Token = "0x170000E4")]
	public float ShieldValue
	{
		[Token(Token = "0x6000CBD")]
		[Address(RVA = "0x4338C0", Offset = "0x431EC0", VA = "0x1804338C0")]
		get
		{
			return this.shieldFill.m_FillAmount;
		}
		[Token(Token = "0x6000CBE")]
		[Address(RVA = "0x433E30", Offset = "0x432430", VA = "0x180433E30")]
		set
		{
			this.shieldFill.fillAmount = value;
		}
	}

	// Token: 0x170000E5 RID: 229
	// (get) Token: 0x06000CBF RID: 3263 RVA: 0x000488F4 File Offset: 0x00046AF4
	// (set) Token: 0x06000CC0 RID: 3264 RVA: 0x00048914 File Offset: 0x00046B14
	[Token(Token = "0x170000E5")]
	public float ProgressFill
	{
		[Token(Token = "0x6000CBF")]
		[Address(RVA = "0x4338A0", Offset = "0x431EA0", VA = "0x1804338A0")]
		get
		{
			return this.progressFill.m_FillAmount;
		}
		[Token(Token = "0x6000CC0")]
		[Address(RVA = "0x433E10", Offset = "0x432410", VA = "0x180433E10")]
		set
		{
			this.progressFill.fillAmount = value;
		}
	}

	// Token: 0x170000E6 RID: 230
	// (set) Token: 0x06000CC1 RID: 3265 RVA: 0x00048934 File Offset: 0x00046B34
	[Token(Token = "0x170000E6")]
	public float CurseFill
	{
		[Token(Token = "0x6000CC1")]
		[Address(RVA = "0x4338E0", Offset = "0x431EE0", VA = "0x1804338E0")]
		set
		{
			Image image = this.healthFill;
			Image image2 = this.curseFill;
			float fillAmount = image.m_FillAmount;
			if (0 > (int)value || value > 1f)
			{
			}
			image2.fillAmount = fillAmount;
		}
	}

	// Token: 0x06000CC2 RID: 3266 RVA: 0x00048970 File Offset: 0x00046B70
	[Token(Token = "0x6000CC2")]
	[Address(RVA = "0x433590", Offset = "0x431B90", VA = "0x180433590")]
	public void UpdateText()
	{
		ulong num;
		do
		{
			Dictionary<TextMeshProUGUI, Func<string>> dictionary = this.registedTexts;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06000CC3 RID: 3267 RVA: 0x000489A4 File Offset: 0x00046BA4
	[Token(Token = "0x6000CC3")]
	[Address(RVA = "0x4331A0", Offset = "0x4317A0", VA = "0x1804331A0")]
	public TextMeshProUGUI RegisterText(Color color, Func<string> getText, [Optional] Vector2? size)
	{
		if (getText != 0)
		{
			TextMeshProUGUI textMeshProUGUI = this.healthText;
			RectTransform rectTransform = this.healthTextContainer;
			TextMeshProUGUI textMeshProUGUI2 = global::UnityEngine.Object.Instantiate<TextMeshProUGUI>(textMeshProUGUI, rectTransform);
			textMeshProUGUI2.gameObject.SetActive(true);
			this.registedTexts[textMeshProUGUI2] = getText;
			RectTransform component = textMeshProUGUI2.GetComponent<RectTransform>();
			Vector2 value = size.Value;
			component.sizeDelta = value;
			return textMeshProUGUI2;
		}
		return null;
	}

	// Token: 0x06000CC4 RID: 3268 RVA: 0x00048A00 File Offset: 0x00046C00
	[Token(Token = "0x6000CC4")]
	[Address(RVA = "0x433710", Offset = "0x431D10", VA = "0x180433710")]
	private void Update()
	{
		Plant plant = this.follow;
		int num = 0;
		if (!(plant == num))
		{
			if (this.showType != 0)
			{
				this.PositionUpdate();
				return;
			}
		}
		else
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000CC5 RID: 3269 RVA: 0x00048A3C File Offset: 0x00046C3C
	[Token(Token = "0x6000CC5")]
	[Address(RVA = "0x4333A0", Offset = "0x4319A0", VA = "0x1804333A0")]
	public void Show(int type)
	{
		this.showType = type;
		GameObject gameObject = this.fillObject;
		bool flag = type == 2;
		gameObject.SetActive(flag);
		GameObject gameObject2 = this.healthText.gameObject;
		bool flag2 = type == 1;
		gameObject2.SetActive(flag2);
		GameObject gameObject3 = this.healthTextContainer.gameObject;
		bool flag3 = type != 0;
		gameObject3.SetActive(flag3);
	}

	// Token: 0x06000CC6 RID: 3270 RVA: 0x00048AA0 File Offset: 0x00046CA0
	[Token(Token = "0x6000CC6")]
	[Address(RVA = "0x433010", Offset = "0x431610", VA = "0x180433010")]
	private void PositionUpdate()
	{
		Transform transform = base.transform;
		Transform axis = this.follow.axis;
		Vector3 vector;
		float z = vector.z;
		Transform transform2 = base.transform;
		Transform transform3 = base.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		Vector3 vector3;
		float z3 = vector3.z;
	}

	// Token: 0x06000CC7 RID: 3271 RVA: 0x00048AF4 File Offset: 0x00046CF4
	[Token(Token = "0x6000CC7")]
	[Address(RVA = "0x433430", Offset = "0x431A30", VA = "0x180433430")]
	private void Start()
	{
		Board instance = Board.Instance;
		Transform transform = this.healthText.transform;
		Vector3 vector;
		float z = vector.z;
		Transform transform2 = this.healthText.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		this.PositionUpdate();
	}

	// Token: 0x06000CC8 RID: 3272 RVA: 0x00048B40 File Offset: 0x00046D40
	[Token(Token = "0x6000CC8")]
	[Address(RVA = "0x432A80", Offset = "0x431080", VA = "0x180432A80")]
	private Color Get2048Color(int value)
	{
		return default(Color);
	}

	// Token: 0x06000CC9 RID: 3273 RVA: 0x00048B58 File Offset: 0x00046D58
	[Token(Token = "0x6000CC9")]
	[Address(RVA = "0x432B90", Offset = "0x431190", VA = "0x180432B90", Slot = "4")]
	public void OnPointerClick(PointerEventData eventData)
	{
		if (!GameAPP.config.disableHealthToData)
		{
			Plant plant = this.follow;
			int num = 0;
			if (plant != num)
			{
				UIResourcesLoader uimanager = GameAPP.UIManager;
				Transform canvasUp = GameAPP.canvasUp;
				int num2 = 0;
				BaseMenu baseMenu = uimanager.Push((UIType)((uint)69), canvasUp, num2 != 0);
				Plant plant2 = this.follow;
				Time.timeScale = (float)0;
				CursorChange.SetDefaultCursor();
				Image image = this.outLine;
				GameAPP.PlaySound((SoundType)((uint)29), 0.5f, 1f);
			}
		}
	}

	// Token: 0x06000CCA RID: 3274 RVA: 0x00048BDC File Offset: 0x00046DDC
	[Token(Token = "0x6000CCA")]
	[Address(RVA = "0x432DF0", Offset = "0x4313F0", VA = "0x180432DF0", Slot = "5")]
	public void OnPointerEnter(PointerEventData eventData)
	{
		if (!GameAPP.config.disableHealthToData)
		{
			Plant plant = this.follow;
			int num = 0;
			if (plant != num)
			{
				CursorChange.SetClickCursor();
				Image image = this.outLine;
			}
		}
	}

	// Token: 0x06000CCB RID: 3275 RVA: 0x00048C20 File Offset: 0x00046E20
	[Token(Token = "0x6000CCB")]
	[Address(RVA = "0x432F00", Offset = "0x431500", VA = "0x180432F00", Slot = "6")]
	public void OnPointerExit(PointerEventData eventData)
	{
		if (!GameAPP.config.disableHealthToData)
		{
			Plant plant = this.follow;
			int num = 0;
			if (plant != num)
			{
				CursorChange.SetDefaultCursor();
				Image image = this.outLine;
			}
		}
	}

	// Token: 0x06000CCC RID: 3276 RVA: 0x00048C64 File Offset: 0x00046E64
	[Token(Token = "0x6000CCC")]
	[Address(RVA = "0x4337C0", Offset = "0x431DC0", VA = "0x1804337C0")]
	public HealthSlider()
	{
		Dictionary<TextMeshProUGUI, Func<string>> dictionary = new Dictionary();
		this.registedTexts = dictionary;
		base..ctor();
	}

	// Token: 0x040008CD RID: 2253
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008CD")]
	public GameObject fillObject;

	// Token: 0x040008CE RID: 2254
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008CE")]
	public Image outLine;

	// Token: 0x040008CF RID: 2255
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008CF")]
	public Image healthFill;

	// Token: 0x040008D0 RID: 2256
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008D0")]
	public Image shieldFill;

	// Token: 0x040008D1 RID: 2257
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008D1")]
	public Image curseFill;

	// Token: 0x040008D2 RID: 2258
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40008D2")]
	public Image progressFill;

	// Token: 0x040008D3 RID: 2259
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40008D3")]
	public Plant follow;

	// Token: 0x040008D4 RID: 2260
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40008D4")]
	public TextMeshProUGUI fillText;

	// Token: 0x040008D5 RID: 2261
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40008D5")]
	public TextMeshProUGUI healthText;

	// Token: 0x040008D6 RID: 2262
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40008D6")]
	public VerticalLayoutGroup layout;

	// Token: 0x040008D7 RID: 2263
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40008D7")]
	public RectTransform healthTextContainer;

	// Token: 0x040008D8 RID: 2264
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40008D8")]
	public Vector2 offset;

	// Token: 0x040008D9 RID: 2265
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40008D9")]
	public float progressMaxValue;

	// Token: 0x040008DA RID: 2266
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40008DA")]
	private readonly Dictionary<TextMeshProUGUI, Func<string>> registedTexts;

	// Token: 0x040008DB RID: 2267
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40008DB")]
	private int showType;
}
