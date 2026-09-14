using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace AlmanacData
{
	// Token: 0x02000A88 RID: 2696
	[Token(Token = "0x2000A88")]
	public class AlmanacSelectMenu : BaseMenu
	{
		// Token: 0x06003753 RID: 14163 RVA: 0x001288CC File Offset: 0x00126ACC
		[Token(Token = "0x6003753")]
		[Address(RVA = "0x7B2F90", Offset = "0x7B1590", VA = "0x1807B2F90", Slot = "6")]
		protected override void Awake()
		{
			base.Awake();
			this.InitMenu();
		}

		// Token: 0x06003754 RID: 14164 RVA: 0x001288E8 File Offset: 0x00126AE8
		[Token(Token = "0x6003754")]
		[Address(RVA = "0x7B2FB0", Offset = "0x7B15B0", VA = "0x1807B2FB0")]
		public void InitMenu()
		{
			int num3;
			do
			{
				int num = 0;
				GameObject gameObject = this.selection.gameObject;
				int num2 = 0;
				gameObject.SetActive(num2 != 0);
				num3 = 0;
				Transform parent = this.selection.transform.parent;
				List<Details> details = AlmanacDataLoader.almanacData.details;
				bool flag;
				if (flag)
				{
					AlmanacSelectMenu.<>c__DisplayClass6_0 CS$<>8__locals1;
					CS$<>8__locals1.<>4__this = this;
					CS$<>8__locals1.item = num;
					UIButton uibutton = global::UnityEngine.Object.Instantiate<UIButton>(this.selection, parent);
					int num4 = 0;
					bool flag2 = num3 == num4;
					uibutton.gameObject.SetActive(true);
					UnityEvent clickEvent = uibutton.clickEvent;
					UnityAction unityAction = delegate
					{
						AlmanacSelectMenu <>4__this = CS$<>8__locals1.<>4__this;
						Details item = CS$<>8__locals1.item;
						TextMeshProUGUI textMeshProUGUI = <>4__this.mainTitle;
						string title2 = item.title;
						textMeshProUGUI.text = title2;
						AlmanacSelectMenu <>4__this2 = CS$<>8__locals1.<>4__this;
						Details item2 = CS$<>8__locals1.item;
						TextMeshProUGUI textMeshProUGUI2 = <>4__this2.mainText;
						throw new NullReferenceException();
					};
					clickEvent.AddListener(unityAction);
					TextMeshProUGUI componentInChildren = uibutton.GetComponentInChildren<TextMeshProUGUI>();
					string title = CS$<>8__locals1.item.title;
					componentInChildren.text = title;
				}
			}
			while (num3 != 0);
			if (num3 != 0)
			{
			}
		}

		// Token: 0x06003755 RID: 14165 RVA: 0x001289E8 File Offset: 0x00126BE8
		[Token(Token = "0x6003755")]
		[Address(RVA = "0x667800", Offset = "0x665E00", VA = "0x180667800")]
		public AlmanacSelectMenu()
		{
		}

		// Token: 0x04002AD8 RID: 10968
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002AD8")]
		public GameObject leftShow;

		// Token: 0x04002AD9 RID: 10969
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002AD9")]
		public UIButton selection;

		// Token: 0x04002ADA RID: 10970
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002ADA")]
		public TextMeshProUGUI pageTitle;

		// Token: 0x04002ADB RID: 10971
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002ADB")]
		public TextMeshProUGUI mainTitle;

		// Token: 0x04002ADC RID: 10972
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002ADC")]
		public TextMeshProUGUI mainText;
	}
}
