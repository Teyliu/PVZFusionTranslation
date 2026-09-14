using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BEC RID: 3052
	[Token(Token = "0x2000BEC")]
	public class RuntimePortUI : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
	{
		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06003FAC RID: 16300 RVA: 0x00151AA0 File Offset: 0x0014FCA0
		// (set) Token: 0x06003FAD RID: 16301 RVA: 0x00151AB4 File Offset: 0x0014FCB4
		[Token(Token = "0x170004B1")]
		public PortDefinition Port
		{
			[Token(Token = "0x6003FAC")]
			[Address(RVA = "0x7291C0", Offset = "0x7277C0", VA = "0x1807291C0")]
			get;
			[Token(Token = "0x6003FAD")]
			[Address(RVA = "0x788ED0", Offset = "0x7874D0", VA = "0x180788ED0")]
			private set;
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06003FAE RID: 16302 RVA: 0x00151AC8 File Offset: 0x0014FCC8
		// (set) Token: 0x06003FAF RID: 16303 RVA: 0x00151ADC File Offset: 0x0014FCDC
		[Token(Token = "0x170004B2")]
		public bool IsInput
		{
			[Token(Token = "0x6003FAE")]
			[Address(RVA = "0x81AF80", Offset = "0x819580", VA = "0x18081AF80")]
			get;
			[Token(Token = "0x6003FAF")]
			[Address(RVA = "0x81AF90", Offset = "0x819590", VA = "0x18081AF90")]
			private set;
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06003FB0 RID: 16304 RVA: 0x00151AF0 File Offset: 0x0014FCF0
		// (set) Token: 0x06003FB1 RID: 16305 RVA: 0x00151B04 File Offset: 0x0014FD04
		[Token(Token = "0x170004B3")]
		public RuntimeNodeUI NodeUI
		{
			[Token(Token = "0x6003FB0")]
			[Address(RVA = "0x74FED0", Offset = "0x74E4D0", VA = "0x18074FED0")]
			get;
			[Token(Token = "0x6003FB1")]
			[Address(RVA = "0x74FFB0", Offset = "0x74E5B0", VA = "0x18074FFB0")]
			private set;
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06003FB2 RID: 16306 RVA: 0x00151B18 File Offset: 0x0014FD18
		// (set) Token: 0x06003FB3 RID: 16307 RVA: 0x00151B2C File Offset: 0x0014FD2C
		[Token(Token = "0x170004B4")]
		public RuntimeEventNodeEditor Editor
		{
			[Token(Token = "0x6003FB2")]
			[Address(RVA = "0x5B7FE0", Offset = "0x5B65E0", VA = "0x1805B7FE0")]
			get;
			[Token(Token = "0x6003FB3")]
			[Address(RVA = "0x3BE880", Offset = "0x3BCE80", VA = "0x1803BE880")]
			private set;
		}

		// Token: 0x06003FB4 RID: 16308 RVA: 0x00151B40 File Offset: 0x0014FD40
		[Token(Token = "0x6003FB4")]
		[Address(RVA = "0x81AD40", Offset = "0x819340", VA = "0x18081AD40")]
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

		// Token: 0x06003FB5 RID: 16309 RVA: 0x00151BBC File Offset: 0x0014FDBC
		[Token(Token = "0x6003FB5")]
		[Address(RVA = "0x81AC30", Offset = "0x819230", VA = "0x18081AC30")]
		private string GetPortTypeShortName(PortType type)
		{
			if (type <= PortType.Bool)
			{
				return "触发";
			}
			string text;
			return text;
		}

		// Token: 0x06003FB6 RID: 16310 RVA: 0x00151BF0 File Offset: 0x0014FDF0
		[Token(Token = "0x6003FB6")]
		[Address(RVA = "0x81AB40", Offset = "0x819140", VA = "0x18081AB40")]
		private Color GetPortColor(PortType type)
		{
			return default(Color);
		}

		// Token: 0x06003FB7 RID: 16311 RVA: 0x00151C08 File Offset: 0x0014FE08
		[Token(Token = "0x6003FB7")]
		[Address(RVA = "0x81AF50", Offset = "0x819550", VA = "0x18081AF50", Slot = "4")]
		public void OnBeginDrag(PointerEventData eventData)
		{
			EventNodeInputHandler.Port.OnBeginDrag(this, eventData);
		}

		// Token: 0x06003FB8 RID: 16312 RVA: 0x00151C1C File Offset: 0x0014FE1C
		[Token(Token = "0x6003FB8")]
		[Address(RVA = "0x81AF70", Offset = "0x819570", VA = "0x18081AF70", Slot = "6")]
		public void OnEndDrag(PointerEventData eventData)
		{
			EventNodeInputHandler.Port.OnEndDrag(this, eventData);
		}

		// Token: 0x06003FB9 RID: 16313 RVA: 0x00151C30 File Offset: 0x0014FE30
		[Token(Token = "0x6003FB9")]
		[Address(RVA = "0x81AF60", Offset = "0x819560", VA = "0x18081AF60", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
			EventNodeInputHandler.Port.OnDrag(this, eventData);
		}

		// Token: 0x06003FBA RID: 16314 RVA: 0x00151C44 File Offset: 0x0014FE44
		[Token(Token = "0x6003FBA")]
		[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
		public RuntimePortUI()
		{
		}

		// Token: 0x04003074 RID: 12404
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4003074")]
		[Header("UI组件")]
		public Image portImage;

		// Token: 0x04003075 RID: 12405
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4003075")]
		public TextMeshProUGUI portNameText;
	}
}
