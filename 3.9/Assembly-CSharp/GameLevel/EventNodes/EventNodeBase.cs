using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B7E RID: 2942
	[Token(Token = "0x2000B7E")]
	[Serializable]
	public abstract class EventNodeBase
	{
		// Token: 0x06003D3E RID: 15678 RVA: 0x0013F644 File Offset: 0x0013D844
		[Token(Token = "0x6003D3E")]
		[Address(RVA = "0x81F330", Offset = "0x81D930", VA = "0x18081F330")]
		public EventNodeBase()
		{
			this.Execute();
			Guid guid = Guid.NewGuid();
			string text;
			this.nodeId = text;
		}

		// Token: 0x06003D3F RID: 15679
		[Token(Token = "0x6003D3F")]
		[Address(Slot = "4")]
		public abstract PortDefinition[] GetInputPorts();

		// Token: 0x06003D40 RID: 15680
		[Token(Token = "0x6003D40")]
		[Address(Slot = "5")]
		public abstract PortDefinition[] GetOutputPorts();

		// Token: 0x06003D41 RID: 15681 RVA: 0x0013F668 File Offset: 0x0013D868
		[Token(Token = "0x6003D41")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "6")]
		public virtual void Execute()
		{
		}

		// Token: 0x06003D42 RID: 15682 RVA: 0x0013F678 File Offset: 0x0013D878
		[Token(Token = "0x6003D42")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "7")]
		public virtual void InitializeConnections(EventNodeGraph graph)
		{
		}

		// Token: 0x06003D43 RID: 15683 RVA: 0x0013F688 File Offset: 0x0013D888
		[Token(Token = "0x6003D43")]
		[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "8")]
		public virtual void OnBoardStart(Board board)
		{
		}

		// Token: 0x06003D44 RID: 15684 RVA: 0x0013F698 File Offset: 0x0013D898
		[Token(Token = "0x6003D44")]
		[Address(RVA = "0xA2E570", Offset = "0xA2CB70", VA = "0x180A2E570", Slot = "9")]
		public virtual T GetPortValue<T>(string portName, T defaultValue)
		{
			string[] array = new string[5];
			array[0] = "[";
			string name = base.GetType().Name;
			array[1] = name;
			array[2] = "] 端口 ";
			array[3] = portName;
			array[4] = " 未实现 GetPortValue，返回默认值";
			EventNodeDebug.LogWarning(string.Concat(array));
			return defaultValue;
		}

		// Token: 0x06003D45 RID: 15685 RVA: 0x0013F700 File Offset: 0x0013D900
		[Token(Token = "0x6003D45")]
		[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "10")]
		public virtual int ShowEditorUI(RuntimeNodeUI ui)
		{
			return 0;
		}

		// Token: 0x06003D46 RID: 15686 RVA: 0x0013F710 File Offset: 0x0013D910
		[Token(Token = "0x6003D46")]
		[Address(RVA = "0x81EEB0", Offset = "0x81D4B0", VA = "0x18081EEB0")]
		protected void TriggerConnectedNodes(string portName)
		{
			int num;
			do
			{
				EventNodeGraph currentGraph = EventNodeManager.Instance.currentGraph;
				string text = this.nodeId;
				List<EventNodeBase> connectedNodes = currentGraph.GetConnectedNodes(text, portName);
				string name = base.GetType().Name;
				int size = connectedNodes._size;
				num = 0;
				EventNodeDebug.Log(string.Format("[{0}] 触发 '{1}' 端口，共 {2} 个节点", name, portName, name));
				string name2 = base.GetType().Name;
				EventNodeDebug.Log("[" + name2 + "] 触发节点: " + name);
			}
			while (num != 0);
			string[] array = new string[5];
			array[0] = "[";
			string name3 = base.GetType().Name;
			array[1] = name3;
			array[2] = "] 没有连接到'";
			array[3] = portName;
			array[4] = "'端口的节点";
			EventNodeDebug.Log(string.Concat(array));
		}

		// Token: 0x04002DD8 RID: 11736
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002DD8")]
		public string nodeId;

		// Token: 0x04002DD9 RID: 11737
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002DD9")]
		public string nodeType;

		// Token: 0x04002DDA RID: 11738
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002DDA")]
		public Vector2 position;

		// Token: 0x04002DDB RID: 11739
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002DDB")]
		public string nodeName;
	}
}
