using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B36 RID: 2870
	[Token(Token = "0x2000B36")]
	public class ConnectionLine : MaskableGraphic
	{
		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06003BB8 RID: 15288 RVA: 0x001390EC File Offset: 0x001372EC
		// (set) Token: 0x06003BB9 RID: 15289 RVA: 0x00139100 File Offset: 0x00137300
		[Token(Token = "0x1700049F")]
		public NodeConnection Connection
		{
			[Token(Token = "0x6003BB8")]
			[Address(RVA = "0x7A1C40", Offset = "0x7A0240", VA = "0x1807A1C40")]
			get;
			[Token(Token = "0x6003BB9")]
			[Address(RVA = "0x7A1CE0", Offset = "0x7A02E0", VA = "0x1807A1CE0")]
			private set;
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06003BBA RID: 15290 RVA: 0x00139114 File Offset: 0x00137314
		// (set) Token: 0x06003BBB RID: 15291 RVA: 0x00139128 File Offset: 0x00137328
		[Token(Token = "0x170004A0")]
		public RuntimeEventNodeEditor Editor
		{
			[Token(Token = "0x6003BBA")]
			[Address(RVA = "0x7A1C50", Offset = "0x7A0250", VA = "0x1807A1C50")]
			get;
			[Token(Token = "0x6003BBB")]
			[Address(RVA = "0x7A1D00", Offset = "0x7A0300", VA = "0x1807A1D00")]
			set;
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06003BBC RID: 15292 RVA: 0x0013913C File Offset: 0x0013733C
		// (set) Token: 0x06003BBD RID: 15293 RVA: 0x00139150 File Offset: 0x00137350
		[Token(Token = "0x170004A1")]
		public bool IsTempLine
		{
			[Token(Token = "0x6003BBC")]
			[Address(RVA = "0x7A1CD0", Offset = "0x7A02D0", VA = "0x1807A1CD0")]
			get;
			[Token(Token = "0x6003BBD")]
			[Address(RVA = "0x7A1D20", Offset = "0x7A0320", VA = "0x1807A1D20")]
			set;
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06003BBE RID: 15294 RVA: 0x00139164 File Offset: 0x00137364
		[Token(Token = "0x170004A2")]
		private bool IsSelected
		{
			[Token(Token = "0x6003BBE")]
			[Address(RVA = "0x7A1C60", Offset = "0x7A0260", VA = "0x1807A1C60")]
			get
			{
				return this.<Editor>k__BackingField.selectedLine == this;
			}
		}

		// Token: 0x06003BBF RID: 15295 RVA: 0x00139188 File Offset: 0x00137388
		[Token(Token = "0x6003BBF")]
		[Address(RVA = "0x7A0950", Offset = "0x79EF50", VA = "0x1807A0950")]
		public void Initialize(NodeConnection conn, RuntimeEventNodeEditor editor)
		{
			this.<Connection>k__BackingField = conn;
			this.<Editor>k__BackingField = editor;
			int num = 0;
			base.raycastTarget = num != 0;
			RuntimeEventNodeEditor runtimeEventNodeEditor = this.<Editor>k__BackingField;
			string sourceNodeId = conn.sourceNodeId;
			RuntimeNodeUI nodeUI = runtimeEventNodeEditor.GetNodeUI(sourceNodeId);
			RuntimeEventNodeEditor runtimeEventNodeEditor2 = this.<Editor>k__BackingField;
			string targetNodeId = conn.targetNodeId;
			RuntimeNodeUI nodeUI2 = runtimeEventNodeEditor2.GetNodeUI(targetNodeId);
			int num2 = 0;
			if (nodeUI != num2)
			{
				int num3 = 0;
				if (nodeUI2 != num3)
				{
					string sourcePortName = conn.sourcePortName;
					int num4 = 0;
					RuntimePortUI runtimePortUI = this.FindPortUI(nodeUI, sourcePortName, num4 != 0);
					this.sourcePortUI = runtimePortUI;
					string targetPortName = conn.targetPortName;
					RuntimePortUI runtimePortUI2 = this.FindPortUI(nodeUI2, targetPortName, true);
					this.targetPortUI = runtimePortUI2;
				}
			}
			throw new NullReferenceException();
		}

		// Token: 0x06003BC0 RID: 15296 RVA: 0x0013923C File Offset: 0x0013743C
		[Token(Token = "0x6003BC0")]
		[Address(RVA = "0x7A01A0", Offset = "0x79E7A0", VA = "0x1807A01A0")]
		private RuntimePortUI FindPortUI(RuntimeNodeUI nodeUI, string portName, bool isInput)
		{
			int num;
			do
			{
				num = 0;
				int num2 = 0;
				if (nodeUI == num2)
				{
					break;
				}
				if (isInput)
				{
				}
				RectTransform outputPortsContainer = nodeUI.outputPortsContainer;
				int num3 = 0;
				if (outputPortsContainer == num3)
				{
					break;
				}
				RuntimePortUI runtimePortUI;
				if (outputPortsContainer.GetEnumerator() != 0)
				{
					int num4 = 0;
					bool flag = runtimePortUI != num4;
					while (!flag)
					{
					}
					string portName2 = runtimePortUI.<Port>k__BackingField.portName;
					while (!flag)
					{
					}
				}
				if (runtimePortUI != 0)
				{
				}
			}
			while (num != 0);
			throw new NullReferenceException();
		}

		// Token: 0x06003BC1 RID: 15297 RVA: 0x001392D0 File Offset: 0x001374D0
		[Token(Token = "0x6003BC1")]
		[Address(RVA = "0x7A1BE0", Offset = "0x7A01E0", VA = "0x1807A1BE0")]
		public void UpdateLinePosition()
		{
		}

		// Token: 0x06003BC2 RID: 15298 RVA: 0x001392E0 File Offset: 0x001374E0
		[Token(Token = "0x6003BC2")]
		[Address(RVA = "0x7A1920", Offset = "0x79FF20", VA = "0x1807A1920")]
		public void SetSourcePort(RuntimePortUI sourcePortUI)
		{
			this.sourcePortUI = sourcePortUI;
		}

		// Token: 0x06003BC3 RID: 15299 RVA: 0x001392F4 File Offset: 0x001374F4
		[Token(Token = "0x6003BC3")]
		[Address(RVA = "0x7A0B00", Offset = "0x79F100", VA = "0x1807A0B00", Slot = "44")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
			base.OnPopulateMesh(vh);
			vh.Clear();
			RuntimePortUI runtimePortUI = this.sourcePortUI;
			int num = 0;
			if (!(runtimePortUI == num))
			{
				float y = this.startPos.y;
				float y2 = this.endPos.y;
				ulong num2;
				if (num2 == (ulong)0L)
				{
				}
				float y3 = this.endPos.y;
				ulong num3;
				if (num3 == (ulong)0L)
				{
				}
				Vector2[] array = new Vector2[33];
				int i = 0;
				i++;
				while (i <= 32)
				{
				}
				Vector2 zeroVector = Vector2.zeroVector;
				float num4 = this.lineThickness;
				if (this.<IsTempLine>k__BackingField)
				{
				}
				uint num6;
				uint num5 = num6 - 1U;
				vh.AddTriangle((int)y3, (int)num5, (int)num6);
				uint num7 = num6 + 1U;
				vh.AddTriangle((int)y3, (int)num6, (int)num7);
				i++;
				num6 += (uint)4;
			}
		}

		// Token: 0x06003BC4 RID: 15300 RVA: 0x001393C8 File Offset: 0x001375C8
		[Token(Token = "0x6003BC4")]
		[Address(RVA = "0x7A00E0", Offset = "0x79E6E0", VA = "0x1807A00E0")]
		private Vector2 CalculateBezierPoint(float t, Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3)
		{
			return default(Vector2);
		}

		// Token: 0x06003BC5 RID: 15301 RVA: 0x001393E0 File Offset: 0x001375E0
		[Token(Token = "0x6003BC5")]
		[Address(RVA = "0x7A08E0", Offset = "0x79EEE0", VA = "0x1807A08E0")]
		private Vector2 GetLocalPoint(Vector3 worldPos)
		{
			Transform parent = base.rectTransform.parent;
			float z = worldPos.z;
			throw new NullReferenceException();
		}

		// Token: 0x06003BC6 RID: 15302 RVA: 0x00139410 File Offset: 0x00137610
		[Token(Token = "0x6003BC6")]
		[Address(RVA = "0x7A14E0", Offset = "0x79FAE0", VA = "0x1807A14E0")]
		public void PersistentUpdate()
		{
			RuntimePortUI runtimePortUI = this.targetPortUI;
			int num = 0;
			if (!(runtimePortUI == num))
			{
				RuntimeNodeUI <NodeUI>k__BackingField = this.sourcePortUI.<NodeUI>k__BackingField;
				NodeGroupUI group = this.targetPortUI.<NodeUI>k__BackingField.group;
				NodeGroupUI group2 = <NodeUI>k__BackingField.group;
				if (group2 == group)
				{
					int num2 = 0;
					if (group2 != num2 && group2.group.isFolded)
					{
						GameObject gameObject = base.gameObject;
						int num3 = 0;
						gameObject.SetActive(num3 != 0);
						return;
					}
				}
				Vector3 vector;
				float z = vector.z;
				Vector3 vector2;
				float z2 = vector2.z;
				bool flag;
				while (!flag)
				{
				}
				RectTransform rectTransform;
				Transform parent = rectTransform.parent;
				Vector3 vector3;
				float z3 = vector3.z;
				RectTransform rectTransform2;
				Transform parent2 = rectTransform2.parent;
				int num4 = 0;
				if (num4 == 0 || num4 == 0)
				{
				}
				throw new NullReferenceException();
			}
		}

		// Token: 0x06003BC7 RID: 15303 RVA: 0x001394D8 File Offset: 0x001376D8
		[Token(Token = "0x6003BC7")]
		[Address(RVA = "0x7A1940", Offset = "0x79FF40", VA = "0x1807A1940")]
		public void TempUpdate()
		{
			Transform parent = base.rectTransform.parent;
			int num = 0;
			Transform transform = this.<Editor>k__BackingField.transform;
			int num2 = 0;
			Vector3 mousePosition = Input.mousePosition;
			Camera main = Camera.main;
			int num3 = 0;
			if (transform != 0)
			{
			}
			if (RectTransformUtility.ScreenPointToLocalPointInRectangle(num3, num2, main, num))
			{
				Transform transform2 = this.<Editor>k__BackingField.transform;
				int num4 = 0;
				Transform parent2 = base.rectTransform.parent;
				Vector2 vector = this.startPos;
				float y = this.startPos.y;
				this.startPos = vector;
				this.startPos.y = y;
				this.endPos.y = (float)num4;
				base.SetVerticesDirty();
			}
		}

		// Token: 0x06003BC8 RID: 15304 RVA: 0x0013958C File Offset: 0x0013778C
		[Token(Token = "0x6003BC8")]
		[Address(RVA = "0x7A1370", Offset = "0x79F970", VA = "0x1807A1370")]
		public void OnUpdate()
		{
			RuntimePortUI runtimePortUI = this.sourcePortUI;
			int num = 0;
			if (!(runtimePortUI == num))
			{
				Transform transform = base.transform;
				Transform transform2 = RuntimeEventNodeEditor.Instance.transform;
				Vector3 vector;
				float z = vector.z;
				Transform transform3 = base.transform;
				int num2 = 0;
				if ((this.<IsTempLine>k__BackingField ? 1 : 0) != num2)
				{
					return;
				}
				this.PersistentUpdate();
			}
		}

		// Token: 0x06003BC9 RID: 15305 RVA: 0x001395EC File Offset: 0x001377EC
		[Token(Token = "0x6003BC9")]
		[Address(RVA = "0x7A0450", Offset = "0x79EA50", VA = "0x1807A0450")]
		private Vector3 GetActualSourcePosition()
		{
			bool flag;
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L && !flag)
			{
				int num = 0;
				RuntimeNodeUI runtimeNodeUI;
				if (!(runtimeNodeUI == num))
				{
					int num2 = 0;
					NodeGroupUI nodeGroupUI;
					if (!(nodeGroupUI != num2) || nodeGroupUI.group.isFolded)
					{
					}
				}
			}
			Vector3 vector;
			float z = vector.z;
			throw new NullReferenceException();
		}

		// Token: 0x06003BCA RID: 15306 RVA: 0x0013964C File Offset: 0x0013784C
		[Token(Token = "0x6003BCA")]
		[Address(RVA = "0x7A05E0", Offset = "0x79EBE0", VA = "0x1807A05E0")]
		private Vector3 GetActualTargetPosition()
		{
			bool flag;
			bool flag2;
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L && !flag && !flag2)
			{
				int num = 0;
				RuntimeNodeUI runtimeNodeUI;
				if (!(runtimeNodeUI == num))
				{
					int num2 = 0;
					NodeGroupUI nodeGroupUI;
					if (!(nodeGroupUI != num2) || nodeGroupUI.group.isFolded)
					{
					}
				}
			}
			Vector3 vector;
			float z = vector.z;
			throw new NullReferenceException();
		}

		// Token: 0x06003BCB RID: 15307 RVA: 0x001396B4 File Offset: 0x001378B4
		[Token(Token = "0x6003BCB")]
		[Address(RVA = "0x7A07A0", Offset = "0x79EDA0", VA = "0x1807A07A0")]
		private Vector3 GetGroupFoldedPosition(NodeGroupUI groupUI, bool isSource)
		{
			bool flag;
			bool flag2;
			if (flag || !flag2)
			{
			}
			throw new NullReferenceException();
		}

		// Token: 0x06003BCC RID: 15308 RVA: 0x001396E0 File Offset: 0x001378E0
		[Token(Token = "0x6003BCC")]
		[Address(RVA = "0x7A1C00", Offset = "0x7A0200", VA = "0x1807A1C00")]
		public ConnectionLine()
		{
		}

		// Token: 0x04002C2E RID: 11310
		[FieldOffset(Offset = "0xE0")]
		[Token(Token = "0x4002C2E")]
		[Header("设置")]
		public float lineThickness = 3f;

		// Token: 0x04002C31 RID: 11313
		[FieldOffset(Offset = "0xF8")]
		[Token(Token = "0x4002C31")]
		private RuntimePortUI sourcePortUI;

		// Token: 0x04002C32 RID: 11314
		[FieldOffset(Offset = "0x100")]
		[Token(Token = "0x4002C32")]
		private RuntimePortUI targetPortUI;

		// Token: 0x04002C33 RID: 11315
		[FieldOffset(Offset = "0x108")]
		[Token(Token = "0x4002C33")]
		public Vector2 startPos;

		// Token: 0x04002C34 RID: 11316
		[FieldOffset(Offset = "0x110")]
		[Token(Token = "0x4002C34")]
		public Vector2 endPos;

		// Token: 0x04002C35 RID: 11317
		[FieldOffset(Offset = "0x118")]
		[Token(Token = "0x4002C35")]
		private Vector2 lastStartPos;

		// Token: 0x04002C36 RID: 11318
		[FieldOffset(Offset = "0x120")]
		[Token(Token = "0x4002C36")]
		private Vector2 lastEndPos;

		// Token: 0x04002C37 RID: 11319
		[FieldOffset(Offset = "0x128")]
		[Token(Token = "0x4002C37")]
		private Color normalColor;

		// Token: 0x04002C38 RID: 11320
		[FieldOffset(Offset = "0x138")]
		[Token(Token = "0x4002C38")]
		private Color highlightColor;

		// Token: 0x04002C39 RID: 11321
		[FieldOffset(Offset = "0x148")]
		[Token(Token = "0x4002C39")]
		private Color selectedColor;

		// Token: 0x04002C3B RID: 11323
		[FieldOffset(Offset = "0x15C")]
		[Token(Token = "0x4002C3B")]
		private Vector2 offset;
	}
}
