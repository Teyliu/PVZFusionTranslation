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
	// Token: 0x02000BEA RID: 3050
	[Token(Token = "0x2000BEA")]
	public class RuntimeNodeUI : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler, IPointerClickHandler
	{
		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06003F84 RID: 16260 RVA: 0x00150B20 File Offset: 0x0014ED20
		// (set) Token: 0x06003F85 RID: 16261 RVA: 0x00150B34 File Offset: 0x0014ED34
		[Token(Token = "0x170004AC")]
		public EventNodeBase Node
		{
			[Token(Token = "0x6003F84")]
			[Address(RVA = "0x70F770", Offset = "0x70DD70", VA = "0x18070F770")]
			get;
			[Token(Token = "0x6003F85")]
			[Address(RVA = "0x7A2420", Offset = "0x7A0A20", VA = "0x1807A2420")]
			private set;
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06003F86 RID: 16262 RVA: 0x00150B48 File Offset: 0x0014ED48
		// (set) Token: 0x06003F87 RID: 16263 RVA: 0x00150B5C File Offset: 0x0014ED5C
		[Token(Token = "0x170004AD")]
		public RuntimeEventNodeEditor Editor
		{
			[Token(Token = "0x6003F86")]
			[Address(RVA = "0x7A23C0", Offset = "0x7A09C0", VA = "0x1807A23C0")]
			get;
			[Token(Token = "0x6003F87")]
			[Address(RVA = "0x7A2440", Offset = "0x7A0A40", VA = "0x1807A2440")]
			private set;
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06003F88 RID: 16264 RVA: 0x00150B70 File Offset: 0x0014ED70
		[Token(Token = "0x170004AE")]
		public RectTransform RectTransform
		{
			[Token(Token = "0x6003F88")]
			[Address(RVA = "0x7A23D0", Offset = "0x7A09D0", VA = "0x1807A23D0")]
			get
			{
				return this.rectTransform;
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06003F89 RID: 16265 RVA: 0x00150B84 File Offset: 0x0014ED84
		// (set) Token: 0x06003F8A RID: 16266 RVA: 0x00150B98 File Offset: 0x0014ED98
		[Token(Token = "0x170004AF")]
		public bool IsSelected
		{
			[Token(Token = "0x6003F89")]
			[Address(RVA = "0x81A080", Offset = "0x818680", VA = "0x18081A080")]
			get
			{
				return this.isSelected;
			}
			[Token(Token = "0x6003F8A")]
			[Address(RVA = "0x81A0A0", Offset = "0x8186A0", VA = "0x18081A0A0")]
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

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06003F8B RID: 16267 RVA: 0x00150C18 File Offset: 0x0014EE18
		[Token(Token = "0x170004B0")]
		internal List<RuntimePortUI> Ports
		{
			[Token(Token = "0x6003F8B")]
			[Address(RVA = "0x81A090", Offset = "0x818690", VA = "0x18081A090")]
			get
			{
				return this.ports;
			}
		}

		// Token: 0x06003F8C RID: 16268 RVA: 0x00150C2C File Offset: 0x0014EE2C
		[Token(Token = "0x6003F8C")]
		[Address(RVA = "0x818370", Offset = "0x816970", VA = "0x180818370")]
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

		// Token: 0x06003F8D RID: 16269 RVA: 0x00150CD0 File Offset: 0x0014EED0
		[Token(Token = "0x6003F8D")]
		[Address(RVA = "0x8190F0", Offset = "0x8176F0", VA = "0x1808190F0")]
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

		// Token: 0x06003F8E RID: 16270 RVA: 0x00150E08 File Offset: 0x0014F008
		[Token(Token = "0x6003F8E")]
		[Address(RVA = "0x819420", Offset = "0x817A20", VA = "0x180819420")]
		private void OnEnable()
		{
			this.UpdateBounds();
		}

		// Token: 0x06003F8F RID: 16271 RVA: 0x00150E1C File Offset: 0x0014F01C
		[Token(Token = "0x6003F8F")]
		[Address(RVA = "0x819450", Offset = "0x817A50", VA = "0x180819450")]
		public void UpdateBounds()
		{
			if (base.transform != 0)
			{
			}
		}

		// Token: 0x06003F90 RID: 16272 RVA: 0x00150E34 File Offset: 0x0014F034
		[Token(Token = "0x6003F90")]
		[Address(RVA = "0x819E90", Offset = "0x818490", VA = "0x180819E90")]
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

		// Token: 0x06003F91 RID: 16273 RVA: 0x00150E74 File Offset: 0x0014F074
		[Token(Token = "0x6003F91")]
		[Address(RVA = "0x8194F0", Offset = "0x817AF0", VA = "0x1808194F0")]
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

		// Token: 0x06003F92 RID: 16274 RVA: 0x00150F9C File Offset: 0x0014F19C
		[Token(Token = "0x6003F92")]
		[Address(RVA = "0x818540", Offset = "0x816B40", VA = "0x180818540")]
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

		// Token: 0x06003F93 RID: 16275 RVA: 0x00151044 File Offset: 0x0014F244
		[Token(Token = "0x6003F93")]
		[Address(RVA = "0x819D30", Offset = "0x818330", VA = "0x180819D30")]
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

		// Token: 0x06003F94 RID: 16276 RVA: 0x001510B4 File Offset: 0x0014F2B4
		[Token(Token = "0x6003F94")]
		[Address(RVA = "0x818960", Offset = "0x816F60", VA = "0x180818960")]
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

		// Token: 0x06003F95 RID: 16277 RVA: 0x00151114 File Offset: 0x0014F314
		[Token(Token = "0x6003F95")]
		[Address(RVA = "0x819440", Offset = "0x817A40", VA = "0x180819440", Slot = "7")]
		public void OnPointerClick(PointerEventData eventData)
		{
			EventNodeInputHandler.Node.OnPointerClick(this, eventData);
		}

		// Token: 0x06003F96 RID: 16278 RVA: 0x00151128 File Offset: 0x0014F328
		[Token(Token = "0x6003F96")]
		[Address(RVA = "0x819410", Offset = "0x817A10", VA = "0x180819410", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
			EventNodeInputHandler.Node.OnDrag(this, eventData);
		}

		// Token: 0x06003F97 RID: 16279 RVA: 0x0015113C File Offset: 0x0014F33C
		[Token(Token = "0x6003F97")]
		[Address(RVA = "0x819400", Offset = "0x817A00", VA = "0x180819400", Slot = "4")]
		public void OnBeginDrag(PointerEventData eventData)
		{
			EventNodeInputHandler.Node.OnBeginDrag(this, eventData);
		}

		// Token: 0x06003F98 RID: 16280 RVA: 0x00151150 File Offset: 0x0014F350
		[Token(Token = "0x6003F98")]
		[Address(RVA = "0x819430", Offset = "0x817A30", VA = "0x180819430", Slot = "6")]
		public void OnEndDrag(PointerEventData eventData)
		{
			EventNodeInputHandler.Node.OnEndDrag(this, eventData);
		}

		// Token: 0x06003F99 RID: 16281 RVA: 0x00151164 File Offset: 0x0014F364
		[Token(Token = "0x6003F99")]
		[Address(RVA = "0x818BF0", Offset = "0x8171F0", VA = "0x180818BF0")]
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

		// Token: 0x06003F9A RID: 16282 RVA: 0x001511D8 File Offset: 0x0014F3D8
		[Token(Token = "0x6003F9A")]
		[Address(RVA = "0x818E80", Offset = "0x817480", VA = "0x180818E80")]
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

		// Token: 0x06003F9B RID: 16283 RVA: 0x00151244 File Offset: 0x0014F444
		[Token(Token = "0x6003F9B")]
		[Address(RVA = "0x81A000", Offset = "0x818600", VA = "0x18081A000")]
		public RuntimeNodeUI()
		{
			List<RuntimePortUI> list = new List();
			this.ports = list;
			base..ctor();
		}

		// Token: 0x0400305B RID: 12379
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400305B")]
		[Header("UI组件")]
		public Image backgroundImage;

		// Token: 0x0400305C RID: 12380
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400305C")]
		public TextMeshProUGUI titleText;

		// Token: 0x0400305D RID: 12381
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400305D")]
		public RectTransform inputPortsContainer;

		// Token: 0x0400305E RID: 12382
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400305E")]
		public RectTransform outputPortsContainer;

		// Token: 0x0400305F RID: 12383
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400305F")]
		public RectTransform valueEditContainer;

		// Token: 0x04003060 RID: 12384
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003060")]
		public RectTransform splitLine_mid;

		// Token: 0x04003061 RID: 12385
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003061")]
		public RectTransform splitLine_lower;

		// Token: 0x04003062 RID: 12386
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4003062")]
		[Header("预制体")]
		public GameObject LeftPortPrefab;

		// Token: 0x04003063 RID: 12387
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4003063")]
		public GameObject rightPortPrefab;

		// Token: 0x04003064 RID: 12388
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4003064")]
		public GameObject inputFieldPrefab;

		// Token: 0x04003065 RID: 12389
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4003065")]
		public GameObject togglePrefab;

		// Token: 0x04003066 RID: 12390
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4003066")]
		public GameObject dropdownPrefab;

		// Token: 0x04003067 RID: 12391
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4003067")]
		public TheButton buttonPrefab;

		// Token: 0x04003068 RID: 12392
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4003068")]
		[SerializeReference]
		private EventNodeBase _node;

		// Token: 0x0400306B RID: 12395
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x400306B")]
		public NodeGroupUI group;

		// Token: 0x0400306C RID: 12396
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x400306C")]
		private RectTransform rectTransform;

		// Token: 0x0400306D RID: 12397
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x400306D")]
		internal TMP_InputField valueInputField;

		// Token: 0x0400306E RID: 12398
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x400306E")]
		[SerializeField]
		internal bool isDragging;

		// Token: 0x0400306F RID: 12399
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x400306F")]
		[SerializeField]
		private List<RuntimePortUI> ports;

		// Token: 0x04003070 RID: 12400
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x4003070")]
		[Header("选中状态")]
		[SerializeField]
		private bool isSelected;

		// Token: 0x04003071 RID: 12401
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x4003071")]
		private Outline outline;

		// Token: 0x04003072 RID: 12402
		[FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x4003072")]
		internal Vector2 thisNodeInitialPosition;

		// Token: 0x04003073 RID: 12403
		[FieldOffset(Offset = "0xE0")]
		[Token(Token = "0x4003073")]
		private Bounds worldBounds;
	}
}
