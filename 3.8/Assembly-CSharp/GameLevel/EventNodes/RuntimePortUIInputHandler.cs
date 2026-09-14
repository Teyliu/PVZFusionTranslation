using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BED RID: 3053
	[Token(Token = "0x2000BED")]
	public static class RuntimePortUIInputHandler
	{
		// Token: 0x06003FBB RID: 16315 RVA: 0x00151C58 File Offset: 0x0014FE58
		[Token(Token = "0x6003FBB")]
		[Address(RVA = "0x81A2C0", Offset = "0x8188C0", VA = "0x18081A2C0")]
		public static void BeginDragPort(RuntimePortUI portUI, PointerEventData eventData)
		{
			int num = 0;
			if (!(portUI == num))
			{
				RuntimeEventNodeEditor <Editor>k__BackingField = portUI.<Editor>k__BackingField;
				int num2 = 0;
				if (!(<Editor>k__BackingField == num2) && eventData.<button>k__BackingField == PointerEventData.InputButton.Left)
				{
					RuntimeEventNodeEditor <Editor>k__BackingField2 = portUI.<Editor>k__BackingField;
					RuntimeNodeUI <NodeUI>k__BackingField = portUI.<NodeUI>k__BackingField;
					PortDefinition <Port>k__BackingField = portUI.<Port>k__BackingField;
					bool <IsInput>k__BackingField = portUI.<IsInput>k__BackingField;
					RuntimeEventNodeEditor.PortData portData = new RuntimeEventNodeEditor.PortData();
					string nodeId = <NodeUI>k__BackingField.<Node>k__BackingField.nodeId;
					portData.nodeId = nodeId;
					string portName = <Port>k__BackingField.portName;
					portData.portName = portName;
					PortType portType = <Port>k__BackingField.portType;
					portData.portType = portType;
					portData.isInput = <IsInput>k__BackingField;
					portData.nodeUI = <NodeUI>k__BackingField;
					<Editor>k__BackingField2.draggingPort = portData;
					<Editor>k__BackingField2.CreateTempConnectionLine();
					string portName2 = <Port>k__BackingField.portName;
					EventNodeDebug.Log("开始拖拽端口: " + portName2);
					string portName3 = portUI.<Port>k__BackingField.portName;
					EventNodeDebug.Log("[RuntimePortUIInputHandler] 开始拖拽端口: " + portName3);
				}
			}
		}

		// Token: 0x06003FBC RID: 16316 RVA: 0x00151D58 File Offset: 0x0014FF58
		[Token(Token = "0x6003FBC")]
		[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10")]
		public static void DragPort(RuntimePortUI portUI, PointerEventData eventData)
		{
		}

		// Token: 0x06003FBD RID: 16317 RVA: 0x00151D68 File Offset: 0x0014FF68
		[Token(Token = "0x6003FBD")]
		[Address(RVA = "0x81A690", Offset = "0x818C90", VA = "0x18081A690")]
		public static void EndDragPort(RuntimePortUI portUI, PointerEventData eventData)
		{
			int num = 0;
			if (!(portUI == num))
			{
				RuntimeEventNodeEditor <Editor>k__BackingField = portUI.<Editor>k__BackingField;
				int num2 = 0;
				if (!(<Editor>k__BackingField == num2))
				{
					EventNodeDebug.Log("[RuntimePortUIInputHandler] 松开鼠标");
					if (eventData.<button>k__BackingField == PointerEventData.InputButton.Left)
					{
						if (eventData.<pointerCurrentRaycast>k__BackingField != 0)
						{
						}
						int num3 = 0;
						int num4 = 0;
						EventNodeDebug.Log("[RuntimePortUIInputHandler] 停留在: " + num4);
						int num5 = 0;
						if (num3 != num5 && num3 != portUI)
						{
							EventNodeDebug.Log("[RuntimePortUIInputHandler] 找到了目标端口");
							if (portUI.<IsInput>k__BackingField != typeof(global::UnityEngine.Object).TypeHandle && portUI.<Port>k__BackingField.portType == typeof(global::UnityEngine.Object).TypeHandle)
							{
								RuntimeNodeUI <NodeUI>k__BackingField = portUI.<NodeUI>k__BackingField;
								bool flag;
								if (!flag)
								{
									RuntimeEventNodeEditor <Editor>k__BackingField2 = portUI.<Editor>k__BackingField;
									return;
								}
							}
							EventNodeDebug.LogWarning("[RuntimePortUIInputHandler] 端口类型不兼容，无法连接");
						}
						EventNodeDebug.Log("[RuntimePortUIInputHandler] 拖到空白处，打开右键菜单");
						throw new NullReferenceException();
					}
				}
			}
		}

		// Token: 0x06003FBE RID: 16318 RVA: 0x00151E44 File Offset: 0x00150044
		[Token(Token = "0x6003FBE")]
		[Address(RVA = "0x81A510", Offset = "0x818B10", VA = "0x18081A510")]
		private static void ConnectToTargetPort(RuntimePortUI sourcePort, RuntimePortUI targetPort)
		{
			EventNodeDebug.Log("[RuntimePortUIInputHandler] 找到了目标端口");
			bool <IsInput>k__BackingField = targetPort.<IsInput>k__BackingField;
			if (sourcePort.<IsInput>k__BackingField != <IsInput>k__BackingField)
			{
				PortDefinition <Port>k__BackingField = sourcePort.<Port>k__BackingField;
				PortType portType = targetPort.<Port>k__BackingField.portType;
				if (<Port>k__BackingField.portType == portType)
				{
					RuntimeNodeUI <NodeUI>k__BackingField = sourcePort.<NodeUI>k__BackingField;
					RuntimeNodeUI <NodeUI>k__BackingField2 = targetPort.<NodeUI>k__BackingField;
					if (!(<NodeUI>k__BackingField == <NodeUI>k__BackingField2))
					{
						RuntimeEventNodeEditor <Editor>k__BackingField = sourcePort.<Editor>k__BackingField;
						bool <IsInput>k__BackingField2 = targetPort.<IsInput>k__BackingField;
						PortDefinition <Port>k__BackingField2 = targetPort.<Port>k__BackingField;
						RuntimeNodeUI <NodeUI>k__BackingField3 = targetPort.<NodeUI>k__BackingField;
						<Editor>k__BackingField.EndPortDrop(<NodeUI>k__BackingField3, <Port>k__BackingField2, <IsInput>k__BackingField2);
						return;
					}
				}
			}
			EventNodeDebug.LogWarning("[RuntimePortUIInputHandler] 端口类型不兼容，无法连接");
			sourcePort.<Editor>k__BackingField.DestroyTempConnectionLine();
		}

		// Token: 0x06003FBF RID: 16319 RVA: 0x00151EEC File Offset: 0x001500EC
		[Token(Token = "0x6003FBF")]
		[Address(RVA = "0x81A210", Offset = "0x818810", VA = "0x18081A210")]
		private static bool ArePortsCompatible(RuntimePortUI port1, RuntimePortUI port2)
		{
			bool <IsInput>k__BackingField = port2.<IsInput>k__BackingField;
			if (port1.<IsInput>k__BackingField != <IsInput>k__BackingField)
			{
				PortDefinition <Port>k__BackingField = port1.<Port>k__BackingField;
				PortType portType = port2.<Port>k__BackingField.portType;
				if (<Port>k__BackingField.portType == portType)
				{
					RuntimeNodeUI <NodeUI>k__BackingField = port1.<NodeUI>k__BackingField;
					RuntimeNodeUI <NodeUI>k__BackingField2 = port2.<NodeUI>k__BackingField;
					if (!(<NodeUI>k__BackingField == <NodeUI>k__BackingField2))
					{
						return true;
					}
				}
			}
			throw new NullReferenceException();
		}

		// Token: 0x06003FC0 RID: 16320 RVA: 0x00151F4C File Offset: 0x0015014C
		[Token(Token = "0x6003FC0")]
		[Address(RVA = "0x81AA70", Offset = "0x819070", VA = "0x18081AA70")]
		private static void ShowPortContextMenu(RuntimePortUI portUI, PointerEventData eventData)
		{
			portUI.<Editor>k__BackingField.DestroyTempConnectionLine();
			RuntimeEventNodeEditor <Editor>k__BackingField = portUI.<Editor>k__BackingField;
			EventNodeDebug.Log("[RuntimePortUIInputHandler] 拖到空白处，打开右键菜单");
		}
	}
}
