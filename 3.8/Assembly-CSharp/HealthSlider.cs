using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020002C0 RID: 704
[Token(Token = "0x20002C0")]
public class HealthSlider : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
{
	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x06000C76 RID: 3190 RVA: 0x00047B08 File Offset: 0x00045D08
	// (set) Token: 0x06000C77 RID: 3191 RVA: 0x00047B24 File Offset: 0x00045D24
	[Token(Token = "0x170000A1")]
	private Color FillColor
	{
		[Token(Token = "0x6000C76")]
		[Address(RVA = "0x3E2BA0", Offset = "0x3E11A0", VA = "0x1803E2BA0")]
		get
		{
			throw new NullReferenceException();
		}
		[Token(Token = "0x6000C77")]
		[Address(RVA = "0x3E2CA0", Offset = "0x3E12A0", VA = "0x1803E2CA0")]
		set
		{
			Image image = this.healthFill;
		}
	}

	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x06000C78 RID: 3192 RVA: 0x00047B40 File Offset: 0x00045D40
	// (set) Token: 0x06000C79 RID: 3193 RVA: 0x00047B60 File Offset: 0x00045D60
	[Token(Token = "0x170000A2")]
	public float HealthValue
	{
		[Token(Token = "0x6000C78")]
		[Address(RVA = "0x3E2BE0", Offset = "0x3E11E0", VA = "0x1803E2BE0")]
		get
		{
			return this.healthFill.m_FillAmount;
		}
		[Token(Token = "0x6000C79")]
		[Address(RVA = "0x3E2CE0", Offset = "0x3E12E0", VA = "0x1803E2CE0")]
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

	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x06000C7A RID: 3194 RVA: 0x00047CE8 File Offset: 0x00045EE8
	// (set) Token: 0x06000C7B RID: 3195 RVA: 0x00047D08 File Offset: 0x00045F08
	[Token(Token = "0x170000A3")]
	public float ShieldValue
	{
		[Token(Token = "0x6000C7A")]
		[Address(RVA = "0x3E2C20", Offset = "0x3E1220", VA = "0x1803E2C20")]
		get
		{
			return this.shieldFill.m_FillAmount;
		}
		[Token(Token = "0x6000C7B")]
		[Address(RVA = "0x3E3190", Offset = "0x3E1790", VA = "0x1803E3190")]
		set
		{
			this.shieldFill.fillAmount = value;
		}
	}

	// Token: 0x170000A4 RID: 164
	// (get) Token: 0x06000C7C RID: 3196 RVA: 0x00047D28 File Offset: 0x00045F28
	// (set) Token: 0x06000C7D RID: 3197 RVA: 0x00047D48 File Offset: 0x00045F48
	[Token(Token = "0x170000A4")]
	public float ProgressFill
	{
		[Token(Token = "0x6000C7C")]
		[Address(RVA = "0x3E2C00", Offset = "0x3E1200", VA = "0x1803E2C00")]
		get
		{
			return this.progressFill.m_FillAmount;
		}
		[Token(Token = "0x6000C7D")]
		[Address(RVA = "0x3E3170", Offset = "0x3E1770", VA = "0x1803E3170")]
		set
		{
			this.progressFill.fillAmount = value;
		}
	}

	// Token: 0x170000A5 RID: 165
	// (set) Token: 0x06000C7E RID: 3198 RVA: 0x00047D68 File Offset: 0x00045F68
	[Token(Token = "0x170000A5")]
	public float CurseFill
	{
		[Token(Token = "0x6000C7E")]
		[Address(RVA = "0x3E2C40", Offset = "0x3E1240", VA = "0x1803E2C40")]
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

	// Token: 0x06000C7F RID: 3199 RVA: 0x00047DA4 File Offset: 0x00045FA4
	[Token(Token = "0x6000C7F")]
	[Address(RVA = "0x3E28F0", Offset = "0x3E0EF0", VA = "0x1803E28F0")]
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

	// Token: 0x06000C80 RID: 3200 RVA: 0x00047DD8 File Offset: 0x00045FD8
	[Token(Token = "0x6000C80")]
	[Address(RVA = "0x3E2500", Offset = "0x3E0B00", VA = "0x1803E2500")]
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

	// Token: 0x06000C81 RID: 3201 RVA: 0x00047E34 File Offset: 0x00046034
	[Token(Token = "0x6000C81")]
	[Address(RVA = "0x3E2A70", Offset = "0x3E1070", VA = "0x1803E2A70")]
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

	// Token: 0x06000C82 RID: 3202 RVA: 0x00047E70 File Offset: 0x00046070
	[Token(Token = "0x6000C82")]
	[Address(RVA = "0x3E2700", Offset = "0x3E0D00", VA = "0x1803E2700")]
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

	// Token: 0x06000C83 RID: 3203 RVA: 0x00047ED4 File Offset: 0x000460D4
	[Token(Token = "0x6000C83")]
	[Address(RVA = "0x3E2370", Offset = "0x3E0970", VA = "0x1803E2370")]
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

	// Token: 0x06000C84 RID: 3204 RVA: 0x00047F28 File Offset: 0x00046128
	[Token(Token = "0x6000C84")]
	[Address(RVA = "0x3E2790", Offset = "0x3E0D90", VA = "0x1803E2790")]
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

	// Token: 0x06000C85 RID: 3205 RVA: 0x00047F74 File Offset: 0x00046174
	[Token(Token = "0x6000C85")]
	[Address(RVA = "0x3E1DE0", Offset = "0x3E03E0", VA = "0x1803E1DE0")]
	private Color Get2048Color(int value)
	{
		return default(Color);
	}

	// Token: 0x06000C86 RID: 3206 RVA: 0x00047F8C File Offset: 0x0004618C
	[Token(Token = "0x6000C86")]
	[Address(RVA = "0x3E1EF0", Offset = "0x3E04F0", VA = "0x1803E1EF0", Slot = "4")]
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

	// Token: 0x06000C87 RID: 3207 RVA: 0x00048010 File Offset: 0x00046210
	[Token(Token = "0x6000C87")]
	[Address(RVA = "0x3E2150", Offset = "0x3E0750", VA = "0x1803E2150", Slot = "5")]
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

	// Token: 0x06000C88 RID: 3208 RVA: 0x00048054 File Offset: 0x00046254
	[Token(Token = "0x6000C88")]
	[Address(RVA = "0x3E2260", Offset = "0x3E0860", VA = "0x1803E2260", Slot = "6")]
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

	// Token: 0x06000C89 RID: 3209 RVA: 0x00048098 File Offset: 0x00046298
	[Token(Token = "0x6000C89")]
	[Address(RVA = "0x3E2B20", Offset = "0x3E1120", VA = "0x1803E2B20")]
	public HealthSlider()
	{
		Dictionary<TextMeshProUGUI, Func<string>> dictionary = new Dictionary();
		this.registedTexts = dictionary;
		base..ctor();
	}

	// Token: 0x04000890 RID: 2192
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000890")]
	public GameObject fillObject;

	// Token: 0x04000891 RID: 2193
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000891")]
	public Image outLine;

	// Token: 0x04000892 RID: 2194
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000892")]
	public Image healthFill;

	// Token: 0x04000893 RID: 2195
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000893")]
	public Image shieldFill;

	// Token: 0x04000894 RID: 2196
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000894")]
	public Image curseFill;

	// Token: 0x04000895 RID: 2197
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000895")]
	public Image progressFill;

	// Token: 0x04000896 RID: 2198
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000896")]
	public Plant follow;

	// Token: 0x04000897 RID: 2199
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000897")]
	public TextMeshProUGUI fillText;

	// Token: 0x04000898 RID: 2200
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000898")]
	public TextMeshProUGUI healthText;

	// Token: 0x04000899 RID: 2201
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000899")]
	public VerticalLayoutGroup layout;

	// Token: 0x0400089A RID: 2202
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400089A")]
	public RectTransform healthTextContainer;

	// Token: 0x0400089B RID: 2203
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400089B")]
	public Vector2 offset;

	// Token: 0x0400089C RID: 2204
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400089C")]
	public float progressMaxValue;

	// Token: 0x0400089D RID: 2205
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400089D")]
	private readonly Dictionary<TextMeshProUGUI, Func<string>> registedTexts;

	// Token: 0x0400089E RID: 2206
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400089E")]
	private int showType;
}
