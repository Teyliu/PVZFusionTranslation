using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B78 RID: 2936
	[Token(Token = "0x2000B78")]
	public class ConnectionLine : MaskableGraphic
	{
		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06003D09 RID: 15625 RVA: 0x0013E394 File Offset: 0x0013C594
		// (set) Token: 0x06003D0A RID: 15626 RVA: 0x0013E3A8 File Offset: 0x0013C5A8
		[Token(Token = "0x170004EF")]
		public NodeConnection Connection
		{
			[Token(Token = "0x6003D09")]
			[Address(RVA = "0x81D150", Offset = "0x81B750", VA = "0x18081D150")]
			get;
			[Token(Token = "0x6003D0A")]
			[Address(RVA = "0x81D1F0", Offset = "0x81B7F0", VA = "0x18081D1F0")]
			private set;
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06003D0B RID: 15627 RVA: 0x0013E3BC File Offset: 0x0013C5BC
		// (set) Token: 0x06003D0C RID: 15628 RVA: 0x0013E3D0 File Offset: 0x0013C5D0
		[Token(Token = "0x170004F0")]
		public RuntimeEventNodeEditor Editor
		{
			[Token(Token = "0x6003D0B")]
			[Address(RVA = "0x81D160", Offset = "0x81B760", VA = "0x18081D160")]
			get;
			[Token(Token = "0x6003D0C")]
			[Address(RVA = "0x81D210", Offset = "0x81B810", VA = "0x18081D210")]
			set;
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06003D0D RID: 15629 RVA: 0x0013E3E4 File Offset: 0x0013C5E4
		// (set) Token: 0x06003D0E RID: 15630 RVA: 0x0013E3F8 File Offset: 0x0013C5F8
		[Token(Token = "0x170004F1")]
		public bool IsTempLine
		{
			[Token(Token = "0x6003D0D")]
			[Address(RVA = "0x81D1E0", Offset = "0x81B7E0", VA = "0x18081D1E0")]
			get;
			[Token(Token = "0x6003D0E")]
			[Address(RVA = "0x81D230", Offset = "0x81B830", VA = "0x18081D230")]
			set;
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06003D0F RID: 15631 RVA: 0x0013E40C File Offset: 0x0013C60C
		[Token(Token = "0x170004F2")]
		private bool IsSelected
		{
			[Token(Token = "0x6003D0F")]
			[Address(RVA = "0x81D170", Offset = "0x81B770", VA = "0x18081D170")]
			get
			{
				return this.<Editor>k__BackingField.selectedLine == this;
			}
		}

		// Token: 0x06003D10 RID: 15632 RVA: 0x0013E430 File Offset: 0x0013C630
		[Token(Token = "0x6003D10")]
		[Address(RVA = "0x81BE80", Offset = "0x81A480", VA = "0x18081BE80")]
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

		// Token: 0x06003D11 RID: 15633 RVA: 0x0013E4E4 File Offset: 0x0013C6E4
		[Token(Token = "0x6003D11")]
		[Address(RVA = "0x81B6D0", Offset = "0x819CD0", VA = "0x18081B6D0")]
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

		// Token: 0x06003D12 RID: 15634 RVA: 0x0013E578 File Offset: 0x0013C778
		[Token(Token = "0x6003D12")]
		[Address(RVA = "0x44A700", Offset = "0x448D00", VA = "0x18044A700")]
		public void UpdateLinePosition()
		{
		}

		// Token: 0x06003D13 RID: 15635 RVA: 0x0013E588 File Offset: 0x0013C788
		[Token(Token = "0x6003D13")]
		[Address(RVA = "0x81CE50", Offset = "0x81B450", VA = "0x18081CE50")]
		public void SetSourcePort(RuntimePortUI sourcePortUI)
		{
			this.sourcePortUI = sourcePortUI;
		}

		// Token: 0x06003D14 RID: 15636 RVA: 0x0013E59C File Offset: 0x0013C79C
		[Token(Token = "0x6003D14")]
		[Address(RVA = "0x81C030", Offset = "0x81A630", VA = "0x18081C030", Slot = "44")]
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

		// Token: 0x06003D15 RID: 15637 RVA: 0x0013E670 File Offset: 0x0013C870
		[Token(Token = "0x6003D15")]
		[Address(RVA = "0x81B610", Offset = "0x819C10", VA = "0x18081B610")]
		private Vector2 CalculateBezierPoint(float t, Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3)
		{
			return default(Vector2);
		}

		// Token: 0x06003D16 RID: 15638 RVA: 0x0013E688 File Offset: 0x0013C888
		[Token(Token = "0x6003D16")]
		[Address(RVA = "0x81BE10", Offset = "0x81A410", VA = "0x18081BE10")]
		private Vector2 GetLocalPoint(Vector3 worldPos)
		{
			Transform parent = base.rectTransform.parent;
			float z = worldPos.z;
			throw new NullReferenceException();
		}

		// Token: 0x06003D17 RID: 15639 RVA: 0x0013E6B8 File Offset: 0x0013C8B8
		[Token(Token = "0x6003D17")]
		[Address(RVA = "0x81CA10", Offset = "0x81B010", VA = "0x18081CA10")]
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

		// Token: 0x06003D18 RID: 15640 RVA: 0x0013E780 File Offset: 0x0013C980
		[Token(Token = "0x6003D18")]
		[Address(RVA = "0x81CE70", Offset = "0x81B470", VA = "0x18081CE70")]
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

		// Token: 0x06003D19 RID: 15641 RVA: 0x0013E834 File Offset: 0x0013CA34
		[Token(Token = "0x6003D19")]
		[Address(RVA = "0x81C8A0", Offset = "0x81AEA0", VA = "0x18081C8A0")]
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

		// Token: 0x06003D1A RID: 15642 RVA: 0x0013E894 File Offset: 0x0013CA94
		[Token(Token = "0x6003D1A")]
		[Address(RVA = "0x81B980", Offset = "0x819F80", VA = "0x18081B980")]
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

		// Token: 0x06003D1B RID: 15643 RVA: 0x0013E8F4 File Offset: 0x0013CAF4
		[Token(Token = "0x6003D1B")]
		[Address(RVA = "0x81BB10", Offset = "0x81A110", VA = "0x18081BB10")]
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

		// Token: 0x06003D1C RID: 15644 RVA: 0x0013E95C File Offset: 0x0013CB5C
		[Token(Token = "0x6003D1C")]
		[Address(RVA = "0x81BCD0", Offset = "0x81A2D0", VA = "0x18081BCD0")]
		private Vector3 GetGroupFoldedPosition(NodeGroupUI groupUI, bool isSource)
		{
			bool flag;
			bool flag2;
			if (flag || !flag2)
			{
			}
			throw new NullReferenceException();
		}

		// Token: 0x06003D1D RID: 15645 RVA: 0x0013E988 File Offset: 0x0013CB88
		[Token(Token = "0x6003D1D")]
		[Address(RVA = "0x81D110", Offset = "0x81B710", VA = "0x18081D110")]
		public ConnectionLine()
		{
		}

		// Token: 0x04002DA2 RID: 11682
		[FieldOffset(Offset = "0xE0")]
		[Token(Token = "0x4002DA2")]
		[Header("设置")]
		public float lineThickness = 3f;

		// Token: 0x04002DA5 RID: 11685
		[FieldOffset(Offset = "0xF8")]
		[Token(Token = "0x4002DA5")]
		private RuntimePortUI sourcePortUI;

		// Token: 0x04002DA6 RID: 11686
		[FieldOffset(Offset = "0x100")]
		[Token(Token = "0x4002DA6")]
		private RuntimePortUI targetPortUI;

		// Token: 0x04002DA7 RID: 11687
		[FieldOffset(Offset = "0x108")]
		[Token(Token = "0x4002DA7")]
		public Vector2 startPos;

		// Token: 0x04002DA8 RID: 11688
		[FieldOffset(Offset = "0x110")]
		[Token(Token = "0x4002DA8")]
		public Vector2 endPos;

		// Token: 0x04002DA9 RID: 11689
		[FieldOffset(Offset = "0x118")]
		[Token(Token = "0x4002DA9")]
		private Vector2 lastStartPos;

		// Token: 0x04002DAA RID: 11690
		[FieldOffset(Offset = "0x120")]
		[Token(Token = "0x4002DAA")]
		private Vector2 lastEndPos;

		// Token: 0x04002DAB RID: 11691
		[FieldOffset(Offset = "0x128")]
		[Token(Token = "0x4002DAB")]
		private Color normalColor;

		// Token: 0x04002DAC RID: 11692
		[FieldOffset(Offset = "0x138")]
		[Token(Token = "0x4002DAC")]
		private Color highlightColor;

		// Token: 0x04002DAD RID: 11693
		[FieldOffset(Offset = "0x148")]
		[Token(Token = "0x4002DAD")]
		private Color selectedColor;

		// Token: 0x04002DAF RID: 11695
		[FieldOffset(Offset = "0x15C")]
		[Token(Token = "0x4002DAF")]
		private Vector2 offset;
	}
}
