using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B3C RID: 2876
	[Token(Token = "0x2000B3C")]
	[Serializable]
	public abstract class EventNodeBase
	{
		// Token: 0x06003BED RID: 15341 RVA: 0x0013A39C File Offset: 0x0013859C
		[Token(Token = "0x6003BED")]
		[Address(RVA = "0x7A3E10", Offset = "0x7A2410", VA = "0x1807A3E10")]
		public EventNodeBase()
		{
			this.Execute();
			Guid guid = Guid.NewGuid();
			string text;
			this.nodeId = text;
		}

		// Token: 0x06003BEE RID: 15342
		[Token(Token = "0x6003BEE")]
		[Address(Slot = "4")]
		public abstract PortDefinition[] GetInputPorts();

		// Token: 0x06003BEF RID: 15343
		[Token(Token = "0x6003BEF")]
		[Address(Slot = "5")]
		public abstract PortDefinition[] GetOutputPorts();

		// Token: 0x06003BF0 RID: 15344 RVA: 0x0013A3C0 File Offset: 0x001385C0
		[Token(Token = "0x6003BF0")]
		[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "6")]
		public virtual void Execute()
		{
		}

		// Token: 0x06003BF1 RID: 15345 RVA: 0x0013A3D0 File Offset: 0x001385D0
		[Token(Token = "0x6003BF1")]
		[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "7")]
		public virtual void InitializeConnections(EventNodeGraph graph)
		{
		}

		// Token: 0x06003BF2 RID: 15346 RVA: 0x0013A3E0 File Offset: 0x001385E0
		[Token(Token = "0x6003BF2")]
		[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "8")]
		public virtual void OnBoardStart(Board board)
		{
		}

		// Token: 0x06003BF3 RID: 15347 RVA: 0x0013A3F0 File Offset: 0x001385F0
		[Token(Token = "0x6003BF3")]
		[Address(RVA = "0x9671F0", Offset = "0x9657F0", VA = "0x1809671F0", Slot = "9")]
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

		// Token: 0x06003BF4 RID: 15348 RVA: 0x0013A458 File Offset: 0x00138658
		[Token(Token = "0x6003BF4")]
		[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "10")]
		public virtual int ShowEditorUI(RuntimeNodeUI ui)
		{
			return 0;
		}

		// Token: 0x06003BF5 RID: 15349 RVA: 0x0013A468 File Offset: 0x00138668
		[Token(Token = "0x6003BF5")]
		[Address(RVA = "0x7A3990", Offset = "0x7A1F90", VA = "0x1807A3990")]
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

		// Token: 0x04002C64 RID: 11364
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002C64")]
		public string nodeId;

		// Token: 0x04002C65 RID: 11365
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002C65")]
		public string nodeType;

		// Token: 0x04002C66 RID: 11366
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002C66")]
		public Vector2 position;

		// Token: 0x04002C67 RID: 11367
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002C67")]
		public string nodeName;
	}
}
