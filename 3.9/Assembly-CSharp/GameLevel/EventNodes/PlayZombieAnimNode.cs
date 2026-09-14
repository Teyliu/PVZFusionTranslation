using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BCC RID: 3020
	[Token(Token = "0x2000BCC")]
	[Serializable]
	public class PlayZombieAnimNode : EventNodeBase
	{
		// Token: 0x06003EDC RID: 16092 RVA: 0x0014A454 File Offset: 0x00148654
		[Token(Token = "0x6003EDC")]
		[Address(RVA = "0x868E90", Offset = "0x867490", VA = "0x180868E90", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			int num2;
			PortDefinition portDefinition = new PortDefinition(this.trigger_PortName, (PortType)num, (PortDirection)num2);
			num2 = 0;
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			int num3;
			PortDefinition portDefinition2 = new PortDefinition(this.zombie_PortName, (PortType)((uint)12), (PortDirection)num3);
			num3 = 0;
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003EDD RID: 16093 RVA: 0x0014A4B4 File Offset: 0x001486B4
		[Token(Token = "0x6003EDD")]
		[Address(RVA = "0x869000", Offset = "0x867600", VA = "0x180869000", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003EDE RID: 16094 RVA: 0x0014A4C4 File Offset: 0x001486C4
		[Token(Token = "0x6003EDE")]
		[Address(RVA = "0x869040", Offset = "0x867640", VA = "0x180869040", Slot = "7")]
		public override void InitializeConnections(EventNodeGraph graph)
		{
			string text = this.zombie_PortName;
			string nodeId = this.nodeId;
			List<SourcePortInfo> sourceNodes = graph.GetSourceNodes(nodeId, text);
			int num = 0;
			EventNodeBase sourceNode = sourceNodes[num].sourceNode;
			this.zombieSourceNode = sourceNode;
			int num2 = 0;
			string sourcePortName = sourceNodes[num2].sourcePortName;
			this.zombieSourcePort = sourcePortName;
		}

		// Token: 0x06003EDF RID: 16095 RVA: 0x0014A524 File Offset: 0x00148724
		[Token(Token = "0x6003EDF")]
		[Address(RVA = "0x868C70", Offset = "0x867270", VA = "0x180868C70", Slot = "6")]
		public override void Execute()
		{
			if (this.zombieSourceNode != (ulong)0L)
			{
			}
			int num = 0;
			int num2 = 0;
			int num3;
			if (!(num == num2))
			{
				bool flag;
				if (!flag)
				{
					string text2;
					string text = "[PlayZombieAnimNode] 僵尸 " + text2 + " 的anim组件为空";
				}
				string text3 = this.animationName;
				string text4 = this.animationName;
				string text6;
				string text5 = "[PlayZombieAnimNode] 播放僵尸动画: " + text4 + "，僵尸: " + text6;
				num3 = 0;
				EventNodeDebug.Log(text5);
				return;
			}
			EventNodeDebug.LogWarning("[PlayZombieAnimNode] 僵尸对象为空，无法播放动画，节点ID: " + num3);
		}

		// Token: 0x06003EE0 RID: 16096 RVA: 0x0014A5A8 File Offset: 0x001487A8
		[Token(Token = "0x6003EE0")]
		[Address(RVA = "0x869100", Offset = "0x867700", VA = "0x180869100", Slot = "10")]
		public override int ShowEditorUI(RuntimeNodeUI ui)
		{
			GameObject inputFieldPrefab = ui.inputFieldPrefab;
			RectTransform valueEditContainer = ui.valueEditContainer;
			GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(inputFieldPrefab, valueEditContainer);
			bool flag;
			if (flag)
			{
				string text = this.animationName;
			}
			return 1;
		}

		// Token: 0x06003EE1 RID: 16097 RVA: 0x0014A5E4 File Offset: 0x001487E4
		[Token(Token = "0x6003EE1")]
		[Address(RVA = "0x869300", Offset = "0x867900", VA = "0x180869300")]
		public PlayZombieAnimNode()
		{
		}

		// Token: 0x04002FB0 RID: 12208
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002FB0")]
		public string animationName = "idle";

		// Token: 0x04002FB1 RID: 12209
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002FB1")]
		public string trigger_PortName = "触发";

		// Token: 0x04002FB2 RID: 12210
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002FB2")]
		public string zombie_PortName = "僵尸";

		// Token: 0x04002FB3 RID: 12211
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002FB3")]
		[NonSerialized]
		private EventNodeBase zombieSourceNode;

		// Token: 0x04002FB4 RID: 12212
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002FB4")]
		[NonSerialized]
		private string zombieSourcePort;

		// Token: 0x04002FB5 RID: 12213
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002FB5")]
		[NonSerialized]
		private EventNodeBase animNameSourceNode;

		// Token: 0x04002FB6 RID: 12214
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002FB6")]
		[NonSerialized]
		private string animNameSourcePort;
	}
}
