using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C2E RID: 3118
	[Token(Token = "0x2000C2E")]
	public class RuntimePortUI : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
	{
		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x060040FD RID: 16637 RVA: 0x00156CCC File Offset: 0x00154ECC
		// (set) Token: 0x060040FE RID: 16638 RVA: 0x00156CE0 File Offset: 0x00154EE0
		[Token(Token = "0x17000501")]
		public PortDefinition Port
		{
			[Token(Token = "0x60040FD")]
			[Address(RVA = "0x78F240", Offset = "0x78D840", VA = "0x18078F240")]
			get;
			[Token(Token = "0x60040FE")]
			[Address(RVA = "0x7EF900", Offset = "0x7EDF00", VA = "0x1807EF900")]
			private set;
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x060040FF RID: 16639 RVA: 0x00156CF4 File Offset: 0x00154EF4
		// (set) Token: 0x06004100 RID: 16640 RVA: 0x00156D08 File Offset: 0x00154F08
		[Token(Token = "0x17000502")]
		public bool IsInput
		{
			[Token(Token = "0x60040FF")]
			[Address(RVA = "0x88C500", Offset = "0x88AB00", VA = "0x18088C500")]
			get;
			[Token(Token = "0x6004100")]
			[Address(RVA = "0x88C510", Offset = "0x88AB10", VA = "0x18088C510")]
			private set;
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06004101 RID: 16641 RVA: 0x00156D1C File Offset: 0x00154F1C
		// (set) Token: 0x06004102 RID: 16642 RVA: 0x00156D30 File Offset: 0x00154F30
		[Token(Token = "0x17000503")]
		public RuntimeNodeUI NodeUI
		{
			[Token(Token = "0x6004101")]
			[Address(RVA = "0x7B6890", Offset = "0x7B4E90", VA = "0x1807B6890")]
			get;
			[Token(Token = "0x6004102")]
			[Address(RVA = "0x7B6970", Offset = "0x7B4F70", VA = "0x1807B6970")]
			private set;
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06004103 RID: 16643 RVA: 0x00156D44 File Offset: 0x00154F44
		// (set) Token: 0x06004104 RID: 16644 RVA: 0x00156D58 File Offset: 0x00154F58
		[Token(Token = "0x17000504")]
		public RuntimeEventNodeEditor Editor
		{
			[Token(Token = "0x6004103")]
			[Address(RVA = "0x5EDAB0", Offset = "0x5EC0B0", VA = "0x1805EDAB0")]
			get;
			[Token(Token = "0x6004104")]
			[Address(RVA = "0x40B630", Offset = "0x409C30", VA = "0x18040B630")]
			private set;
		}

		// Token: 0x06004105 RID: 16645 RVA: 0x00156D6C File Offset: 0x00154F6C
		[Token(Token = "0x6004105")]
		[Address(RVA = "0x88C2C0", Offset = "0x88A8C0", VA = "0x18088C2C0")]
		public void Initialize(PortDefinition port, bool isInput, RuntimeNodeUI nodeUI, RuntimeEventNodeEditor editor)
		{
			this.<Port>k__BackingField = port;
			this.<IsInput>k__BackingField = isInput;
			this.<NodeUI>k__BackingField = nodeUI;
			this.<Editor>k__BackingField = 0;
			TextMeshProUGUI textMeshProUGUI = this.portNameText;
			int num = 0;
			if (textMeshProUGUI != num)
			{
				string portName = port.portName;
				this.portNameText.text = portName;
			}
			Image image = this.portImage;
			int num2 = 0;
			if (image != num2)
			{
				Image image2 = this.portImage;
				if (port.portType <= PortType.Bool)
				{
				}
			}
		}

		// Token: 0x06004106 RID: 16646 RVA: 0x00156DE8 File Offset: 0x00154FE8
		[Token(Token = "0x6004106")]
		[Address(RVA = "0x88C1B0", Offset = "0x88A7B0", VA = "0x18088C1B0")]
		private string GetPortTypeShortName(PortType type)
		{
			if (type <= PortType.Bool)
			{
				return "触发";
			}
			string text;
			return text;
		}

		// Token: 0x06004107 RID: 16647 RVA: 0x00156E20 File Offset: 0x00155020
		[Token(Token = "0x6004107")]
		[Address(RVA = "0x88C0C0", Offset = "0x88A6C0", VA = "0x18088C0C0")]
		private Color GetPortColor(PortType type)
		{
			return default(Color);
		}

		// Token: 0x06004108 RID: 16648 RVA: 0x00156E38 File Offset: 0x00155038
		[Token(Token = "0x6004108")]
		[Address(RVA = "0x88C4D0", Offset = "0x88AAD0", VA = "0x18088C4D0", Slot = "4")]
		public void OnBeginDrag(PointerEventData eventData)
		{
			EventNodeInputHandler.Port.OnBeginDrag(this, eventData);
		}

		// Token: 0x06004109 RID: 16649 RVA: 0x00156E4C File Offset: 0x0015504C
		[Token(Token = "0x6004109")]
		[Address(RVA = "0x88C4F0", Offset = "0x88AAF0", VA = "0x18088C4F0", Slot = "6")]
		public void OnEndDrag(PointerEventData eventData)
		{
			EventNodeInputHandler.Port.OnEndDrag(this, eventData);
		}

		// Token: 0x0600410A RID: 16650 RVA: 0x00156E60 File Offset: 0x00155060
		[Token(Token = "0x600410A")]
		[Address(RVA = "0x88C4E0", Offset = "0x88AAE0", VA = "0x18088C4E0", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
			EventNodeInputHandler.Port.OnDrag(this, eventData);
		}

		// Token: 0x0600410B RID: 16651 RVA: 0x00156E74 File Offset: 0x00155074
		[Token(Token = "0x600410B")]
		[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
		public RuntimePortUI()
		{
		}

		// Token: 0x040031E7 RID: 12775
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40031E7")]
		[Header("UI组件")]
		public Image portImage;

		// Token: 0x040031E8 RID: 12776
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40031E8")]
		public TextMeshProUGUI portNameText;
	}
}
