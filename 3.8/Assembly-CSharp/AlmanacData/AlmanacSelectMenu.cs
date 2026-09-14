using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace AlmanacData
{
	// Token: 0x02000A48 RID: 2632
	[Token(Token = "0x2000A48")]
	public class AlmanacSelectMenu : BaseMenu
	{
		// Token: 0x0600360F RID: 13839 RVA: 0x00123650 File Offset: 0x00121850
		[Token(Token = "0x600360F")]
		[Address(RVA = "0x74C5D0", Offset = "0x74ABD0", VA = "0x18074C5D0", Slot = "6")]
		protected override void Awake()
		{
			base.Awake();
			this.InitMenu();
		}

		// Token: 0x06003610 RID: 13840 RVA: 0x0012366C File Offset: 0x0012186C
		[Token(Token = "0x6003610")]
		[Address(RVA = "0x74C5F0", Offset = "0x74ABF0", VA = "0x18074C5F0")]
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

		// Token: 0x06003611 RID: 13841 RVA: 0x0012376C File Offset: 0x0012196C
		[Token(Token = "0x6003611")]
		[Address(RVA = "0x603FF0", Offset = "0x6025F0", VA = "0x180603FF0")]
		public AlmanacSelectMenu()
		{
		}

		// Token: 0x04002965 RID: 10597
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002965")]
		public GameObject leftShow;

		// Token: 0x04002966 RID: 10598
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002966")]
		public UIButton selection;

		// Token: 0x04002967 RID: 10599
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002967")]
		public TextMeshProUGUI pageTitle;

		// Token: 0x04002968 RID: 10600
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002968")]
		public TextMeshProUGUI mainTitle;

		// Token: 0x04002969 RID: 10601
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002969")]
		public TextMeshProUGUI mainText;
	}
}
