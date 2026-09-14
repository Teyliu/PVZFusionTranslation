using System;
using System.Collections;
using System.Collections.Generic;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C2C RID: 3116
	[Token(Token = "0x2000C2C")]
	public class RuntimeNodeUI : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler, IPointerClickHandler
	{
		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x060040D5 RID: 16597 RVA: 0x00155D48 File Offset: 0x00153F48
		// (set) Token: 0x060040D6 RID: 16598 RVA: 0x00155D5C File Offset: 0x00153F5C
		[Token(Token = "0x170004FC")]
		public EventNodeBase Node
		{
			[Token(Token = "0x60040D5")]
			[Address(RVA = "0x774CA0", Offset = "0x7732A0", VA = "0x180774CA0")]
			get;
			[Token(Token = "0x60040D6")]
			[Address(RVA = "0x81D940", Offset = "0x81BF40", VA = "0x18081D940")]
			private set;
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x060040D7 RID: 16599 RVA: 0x00155D70 File Offset: 0x00153F70
		// (set) Token: 0x060040D8 RID: 16600 RVA: 0x00155D84 File Offset: 0x00153F84
		[Token(Token = "0x170004FD")]
		public RuntimeEventNodeEditor Editor
		{
			[Token(Token = "0x60040D7")]
			[Address(RVA = "0x81D8E0", Offset = "0x81BEE0", VA = "0x18081D8E0")]
			get;
			[Token(Token = "0x60040D8")]
			[Address(RVA = "0x81D960", Offset = "0x81BF60", VA = "0x18081D960")]
			private set;
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x060040D9 RID: 16601 RVA: 0x00155D98 File Offset: 0x00153F98
		[Token(Token = "0x170004FE")]
		public RectTransform RectTransform
		{
			[Token(Token = "0x60040D9")]
			[Address(RVA = "0x81D8F0", Offset = "0x81BEF0", VA = "0x18081D8F0")]
			get
			{
				return this.rectTransform;
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x060040DA RID: 16602 RVA: 0x00155DAC File Offset: 0x00153FAC
		// (set) Token: 0x060040DB RID: 16603 RVA: 0x00155DC0 File Offset: 0x00153FC0
		[Token(Token = "0x170004FF")]
		public bool IsSelected
		{
			[Token(Token = "0x60040DA")]
			[Address(RVA = "0x88B600", Offset = "0x889C00", VA = "0x18088B600")]
			get
			{
				return this.isSelected;
			}
			[Token(Token = "0x60040DB")]
			[Address(RVA = "0x88B620", Offset = "0x889C20", VA = "0x18088B620")]
			set
			{
				if (this.isSelected != value)
				{
					this.isSelected = value;
					Outline outline = this.outline;
					int num = 0;
					if (outline != num)
					{
						this.outline.enabled = true;
						Outline outline2 = this.outline;
						if (this.isSelected)
						{
							throw new NullReferenceException();
						}
					}
					EventNodeBase eventNodeBase = this.<Node>k__BackingField;
					bool flag = this.isSelected;
					string nodeName = eventNodeBase.nodeName;
					EventNodeDebug.Log(string.Format("[RuntimeNodeUI] 节点 {0} 选中状态: {1}", nodeName, flag));
				}
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x060040DC RID: 16604 RVA: 0x00155E40 File Offset: 0x00154040
		[Token(Token = "0x17000500")]
		internal List<RuntimePortUI> Ports
		{
			[Token(Token = "0x60040DC")]
			[Address(RVA = "0x88B610", Offset = "0x889C10", VA = "0x18088B610")]
			get
			{
				return this.ports;
			}
		}

		// Token: 0x060040DD RID: 16605 RVA: 0x00155E54 File Offset: 0x00154054
		[Token(Token = "0x60040DD")]
		[Address(RVA = "0x8898F0", Offset = "0x887EF0", VA = "0x1808898F0")]
		private void Awake()
		{
			RectTransform component = base.GetComponent<RectTransform>();
			this.rectTransform = component;
			Image image = this.backgroundImage;
			int num = 0;
			if (image != num)
			{
				Outline component2 = this.backgroundImage.GetComponent<Outline>();
				this.outline = component2;
				Outline outline = this.outline;
				int num2 = 0;
				if (outline == num2)
				{
					Outline outline2 = this.backgroundImage.gameObject.AddComponent<Outline>();
					this.outline = outline2;
				}
				Outline outline3 = this.outline;
				Outline outline4 = this.outline;
				this.outline.useGraphicAlpha = true;
				this.outline.enabled = true;
			}
		}

		// Token: 0x060040DE RID: 16606 RVA: 0x00155EF8 File Offset: 0x001540F8
		[Token(Token = "0x60040DE")]
		[Address(RVA = "0x88A670", Offset = "0x888C70", VA = "0x18088A670")]
		public void Initialize(EventNodeBase node, RuntimeEventNodeEditor editor)
		{
			this._node = node;
			this.<Node>k__BackingField = node;
			this.<Editor>k__BackingField = editor;
			RectTransform rectTransform = this.rectTransform;
			int num = 0;
			if (rectTransform == num)
			{
				RectTransform component = base.GetComponent<RectTransform>();
				this.rectTransform = component;
			}
			this.rectTransform.anchoredPosition = num;
			NodeTypeInfo nodeInfo = NodeTypeRegistry.GetNodeInfo(node.nodeType);
			TextMeshProUGUI textMeshProUGUI = this.titleText;
			int num2 = 0;
			if (textMeshProUGUI != num2)
			{
				TextMeshProUGUI textMeshProUGUI2 = this.titleText;
				string nodeName;
				if (nodeInfo == 0 || nodeInfo.displayName == 0)
				{
					nodeName = node.nodeName;
				}
				textMeshProUGUI2.text = nodeName;
			}
			TextMeshProUGUI textMeshProUGUI3 = this.titleText;
			Image image = this.backgroundImage;
			int num3 = 0;
			if (image != num3 && nodeInfo != 0)
			{
				Image image2 = this.backgroundImage;
				Color nodeColor = nodeInfo.nodeColor;
				image2.color = nodeColor;
			}
			PortDefinition[] inputPorts = node.GetInputPorts();
			RectTransform rectTransform2 = this.inputPortsContainer;
			this.CreatePorts(inputPorts, rectTransform2, true);
			PortDefinition[] outputPorts = node.GetOutputPorts();
			RectTransform rectTransform3 = this.outputPortsContainer;
			int num4 = 0;
			this.CreatePorts(outputPorts, rectTransform3, num4 != 0);
			int num5 = this.CreateValueEditUI(node);
			this.UpdateDisplay(num5);
			this.UpdateBounds();
			this.UpdateVisable();
		}

		// Token: 0x060040DF RID: 16607 RVA: 0x00156030 File Offset: 0x00154230
		[Token(Token = "0x60040DF")]
		[Address(RVA = "0x88A9A0", Offset = "0x888FA0", VA = "0x18088A9A0")]
		private void OnEnable()
		{
			this.UpdateBounds();
		}

		// Token: 0x060040E0 RID: 16608 RVA: 0x00156044 File Offset: 0x00154244
		[Token(Token = "0x60040E0")]
		[Address(RVA = "0x88A9D0", Offset = "0x888FD0", VA = "0x18088A9D0")]
		public void UpdateBounds()
		{
			if (base.transform != 0)
			{
			}
		}

		// Token: 0x060040E1 RID: 16609 RVA: 0x0015605C File Offset: 0x0015425C
		[Token(Token = "0x60040E1")]
		[Address(RVA = "0x88B410", Offset = "0x889A10", VA = "0x18088B410")]
		public void UpdateVisable()
		{
			Bounds bounds = this.worldBounds;
			Bounds <WorldBounds>k__BackingField = this.<Editor>k__BackingField.<WorldBounds>k__BackingField;
			GameObject gameObject = base.gameObject;
			bool flag;
			if (flag)
			{
			}
			bool flag2;
			gameObject.SetActive(flag2);
		}

		// Token: 0x060040E2 RID: 16610 RVA: 0x0015609C File Offset: 0x0015429C
		[Token(Token = "0x60040E2")]
		[Address(RVA = "0x88AA70", Offset = "0x889070", VA = "0x18088AA70")]
		[ProButton]
		private void UpdateDisplay(int extraCount)
		{
			int num;
			int num2;
			do
			{
				num = 0;
				Vector2 anchoredPosition = this.inputPortsContainer.anchoredPosition;
				float spacing = this.inputPortsContainer.GetComponent<VerticalLayoutGroup>().m_Spacing;
				IEnumerator enumerator = this.inputPortsContainer.GetEnumerator();
				if (enumerator != 0)
				{
					if (num < typeof(IEnumerator).TypeHandle)
					{
						num += num;
						num++;
					}
					enumerator += enumerator;
				}
				if (enumerator != 0)
				{
				}
				if (num != 0)
				{
					goto IL_0100;
				}
				num2 = 0;
				int num3 = 0;
				if (num2 < num3)
				{
					num2 += num2;
					num2++;
				}
				if (num2 < num2)
				{
					num2 += num2;
					num2++;
				}
				IEnumerator enumerator2;
				enumerator2 += enumerator2;
				enumerator2 += enumerator2;
				Vector2 vector;
				if (vector != 0)
				{
				}
			}
			while (num2 != 0);
			int num4 = 0;
			Transform transform2;
			Transform transform = transform2.transform;
			Transform transform3 = transform2.transform;
			Vector2 vector2 = Vector3Extensions.With(num, num4, num);
			int num5 = 0;
			GameObject gameObject;
			gameObject.SetActive(num5 != 0);
			return;
			IL_0100:
			throw new NullReferenceException();
		}

		// Token: 0x060040E3 RID: 16611 RVA: 0x001561C4 File Offset: 0x001543C4
		[Token(Token = "0x60040E3")]
		[Address(RVA = "0x889AC0", Offset = "0x8880C0", VA = "0x180889AC0")]
		private void CreatePorts(PortDefinition[] ports, RectTransform container, bool isInput)
		{
			int num;
			do
			{
				num = 0;
				int num2 = 0;
				if (container == num2)
				{
					return;
				}
				GameObject leftPortPrefab = this.LeftPortPrefab;
				int num3 = 0;
				if (leftPortPrefab == num3)
				{
					return;
				}
				IEnumerator enumerator = container.GetEnumerator();
				if (enumerator != 0)
				{
					if (num < typeof(IEnumerator).TypeHandle)
					{
						num += num;
						num++;
					}
					GameObject gameObject;
					global::UnityEngine.Object.Destroy(gameObject);
					gameObject += gameObject;
				}
				if (enumerator != 0)
				{
				}
			}
			while (num != 0);
			int num4 = 0;
			if (num4 < ports.Length)
			{
				GameObject gameObject2;
				if (!gameObject2.TryGetComponent<RuntimePortUI>(num))
				{
					RuntimePortUI runtimePortUI = gameObject2.AddComponent<RuntimePortUI>();
				}
				num4++;
			}
		}

		// Token: 0x060040E4 RID: 16612 RVA: 0x0015626C File Offset: 0x0015446C
		[Token(Token = "0x60040E4")]
		[Address(RVA = "0x88B2B0", Offset = "0x8898B0", VA = "0x18088B2B0")]
		private void UpdateSelectionVisual()
		{
			Outline outline = this.outline;
			int num = 0;
			if (outline != num)
			{
				this.outline.enabled = true;
				Outline outline2 = this.outline;
				if (this.isSelected)
				{
					throw new NullReferenceException();
				}
			}
			EventNodeBase eventNodeBase = this.<Node>k__BackingField;
			bool flag = this.isSelected;
			string nodeName = eventNodeBase.nodeName;
			EventNodeDebug.Log(string.Format("[RuntimeNodeUI] 节点 {0} 选中状态: {1}", nodeName, flag));
		}

		// Token: 0x060040E5 RID: 16613 RVA: 0x001562DC File Offset: 0x001544DC
		[Token(Token = "0x60040E5")]
		[Address(RVA = "0x889EE0", Offset = "0x8884E0", VA = "0x180889EE0")]
		private int CreateValueEditUI(EventNodeBase node)
		{
			int num;
			do
			{
				num = 0;
				IEnumerator enumerator = this.valueEditContainer.GetEnumerator();
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
			int num2;
			return num2;
		}

		// Token: 0x060040E6 RID: 16614 RVA: 0x0015633C File Offset: 0x0015453C
		[Token(Token = "0x60040E6")]
		[Address(RVA = "0x88A9C0", Offset = "0x888FC0", VA = "0x18088A9C0", Slot = "7")]
		public void OnPointerClick(PointerEventData eventData)
		{
			EventNodeInputHandler.Node.OnPointerClick(this, eventData);
		}

		// Token: 0x060040E7 RID: 16615 RVA: 0x00156350 File Offset: 0x00154550
		[Token(Token = "0x60040E7")]
		[Address(RVA = "0x88A990", Offset = "0x888F90", VA = "0x18088A990", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
			EventNodeInputHandler.Node.OnDrag(this, eventData);
		}

		// Token: 0x060040E8 RID: 16616 RVA: 0x00156364 File Offset: 0x00154564
		[Token(Token = "0x60040E8")]
		[Address(RVA = "0x88A980", Offset = "0x888F80", VA = "0x18088A980", Slot = "4")]
		public void OnBeginDrag(PointerEventData eventData)
		{
			EventNodeInputHandler.Node.OnBeginDrag(this, eventData);
		}

		// Token: 0x060040E9 RID: 16617 RVA: 0x00156378 File Offset: 0x00154578
		[Token(Token = "0x60040E9")]
		[Address(RVA = "0x88A9B0", Offset = "0x888FB0", VA = "0x18088A9B0", Slot = "6")]
		public void OnEndDrag(PointerEventData eventData)
		{
			EventNodeInputHandler.Node.OnEndDrag(this, eventData);
		}

		// Token: 0x060040EA RID: 16618 RVA: 0x0015638C File Offset: 0x0015458C
		[Token(Token = "0x60040EA")]
		[Address(RVA = "0x88A170", Offset = "0x888770", VA = "0x18088A170")]
		public RectTransform GetPortRect(string portName, bool isInput)
		{
			int num;
			do
			{
				num = 0;
				bool flag;
				if (flag)
				{
					break;
				}
				IEnumerator enumerator;
				if (enumerator != 0)
				{
					int num2 = 0;
					RuntimePortUI runtimePortUI;
					bool flag2 = runtimePortUI != num2;
					while (!flag2)
					{
					}
					string portName2 = runtimePortUI.<Port>k__BackingField.portName;
					while (!flag2)
					{
					}
					RectTransform component = runtimePortUI.GetComponent<RectTransform>();
				}
				if (enumerator != 0)
				{
				}
			}
			while (num != 0);
			throw new NullReferenceException();
		}

		// Token: 0x060040EB RID: 16619 RVA: 0x00156400 File Offset: 0x00154600
		[Token(Token = "0x60040EB")]
		[Address(RVA = "0x88A400", Offset = "0x888A00", VA = "0x18088A400")]
		public RuntimePortUI GetPortUI(string portName, bool isInput)
		{
			int num;
			do
			{
				num = 0;
				bool flag;
				if (flag)
				{
					break;
				}
				IEnumerator enumerator;
				if (enumerator != 0)
				{
					int num2 = 0;
					RuntimePortUI runtimePortUI;
					bool flag2 = runtimePortUI != num2;
					while (!flag2)
					{
					}
					string portName2 = runtimePortUI.<Port>k__BackingField.portName;
					while (!flag2)
					{
					}
				}
				if (enumerator != 0)
				{
				}
			}
			while (num != 0);
			throw new NullReferenceException();
		}

		// Token: 0x060040EC RID: 16620 RVA: 0x0015646C File Offset: 0x0015466C
		[Token(Token = "0x60040EC")]
		[Address(RVA = "0x88B580", Offset = "0x889B80", VA = "0x18088B580")]
		public RuntimeNodeUI()
		{
			List<RuntimePortUI> list = new List();
			this.ports = list;
			base..ctor();
		}

		// Token: 0x040031CE RID: 12750
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40031CE")]
		[Header("UI组件")]
		public Image backgroundImage;

		// Token: 0x040031CF RID: 12751
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40031CF")]
		public TextMeshProUGUI titleText;

		// Token: 0x040031D0 RID: 12752
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40031D0")]
		public RectTransform inputPortsContainer;

		// Token: 0x040031D1 RID: 12753
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40031D1")]
		public RectTransform outputPortsContainer;

		// Token: 0x040031D2 RID: 12754
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40031D2")]
		public RectTransform valueEditContainer;

		// Token: 0x040031D3 RID: 12755
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40031D3")]
		public RectTransform splitLine_mid;

		// Token: 0x040031D4 RID: 12756
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40031D4")]
		public RectTransform splitLine_lower;

		// Token: 0x040031D5 RID: 12757
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40031D5")]
		[Header("预制体")]
		public GameObject LeftPortPrefab;

		// Token: 0x040031D6 RID: 12758
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40031D6")]
		public GameObject rightPortPrefab;

		// Token: 0x040031D7 RID: 12759
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40031D7")]
		public GameObject inputFieldPrefab;

		// Token: 0x040031D8 RID: 12760
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40031D8")]
		public GameObject togglePrefab;

		// Token: 0x040031D9 RID: 12761
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x40031D9")]
		public GameObject dropdownPrefab;

		// Token: 0x040031DA RID: 12762
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x40031DA")]
		public TheButton buttonPrefab;

		// Token: 0x040031DB RID: 12763
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x40031DB")]
		[SerializeReference]
		private EventNodeBase _node;

		// Token: 0x040031DE RID: 12766
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x40031DE")]
		public NodeGroupUI group;

		// Token: 0x040031DF RID: 12767
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x40031DF")]
		private RectTransform rectTransform;

		// Token: 0x040031E0 RID: 12768
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x40031E0")]
		internal TMP_InputField valueInputField;

		// Token: 0x040031E1 RID: 12769
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x40031E1")]
		[SerializeField]
		internal bool isDragging;

		// Token: 0x040031E2 RID: 12770
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x40031E2")]
		[SerializeField]
		private List<RuntimePortUI> ports;

		// Token: 0x040031E3 RID: 12771
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x40031E3")]
		[Header("选中状态")]
		[SerializeField]
		private bool isSelected;

		// Token: 0x040031E4 RID: 12772
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x40031E4")]
		private Outline outline;

		// Token: 0x040031E5 RID: 12773
		[FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x40031E5")]
		internal Vector2 thisNodeInitialPosition;

		// Token: 0x040031E6 RID: 12774
		[FieldOffset(Offset = "0xE0")]
		[Token(Token = "0x40031E6")]
		private Bounds worldBounds;
	}
}
