using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B8A RID: 2954
	[Token(Token = "0x2000B8A")]
	[Serializable]
	public class PlayZombieAnimNode : EventNodeBase
	{
		// Token: 0x06003D8B RID: 15755 RVA: 0x001451E0 File Offset: 0x001433E0
		[Token(Token = "0x6003D8B")]
		[Address(RVA = "0x8014E0", Offset = "0x7FFAE0", VA = "0x1808014E0", Slot = "4")]
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

		// Token: 0x06003D8C RID: 15756 RVA: 0x00145240 File Offset: 0x00143440
		[Token(Token = "0x6003D8C")]
		[Address(RVA = "0x801650", Offset = "0x7FFC50", VA = "0x180801650", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			return null;
		}

		// Token: 0x06003D8D RID: 15757 RVA: 0x00145250 File Offset: 0x00143450
		[Token(Token = "0x6003D8D")]
		[Address(RVA = "0x801690", Offset = "0x7FFC90", VA = "0x180801690", Slot = "7")]
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

		// Token: 0x06003D8E RID: 15758 RVA: 0x001452B0 File Offset: 0x001434B0
		[Token(Token = "0x6003D8E")]
		[Address(RVA = "0x8012C0", Offset = "0x7FF8C0", VA = "0x1808012C0", Slot = "6")]
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

		// Token: 0x06003D8F RID: 15759 RVA: 0x00145334 File Offset: 0x00143534
		[Token(Token = "0x6003D8F")]
		[Address(RVA = "0x801750", Offset = "0x7FFD50", VA = "0x180801750", Slot = "10")]
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

		// Token: 0x06003D90 RID: 15760 RVA: 0x00145370 File Offset: 0x00143570
		[Token(Token = "0x6003D90")]
		[Address(RVA = "0x801950", Offset = "0x7FFF50", VA = "0x180801950")]
		public PlayZombieAnimNode()
		{
		}

		// Token: 0x04002E3C RID: 11836
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E3C")]
		public string animationName = "idle";

		// Token: 0x04002E3D RID: 11837
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E3D")]
		public string trigger_PortName = "触发";

		// Token: 0x04002E3E RID: 11838
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002E3E")]
		public string zombie_PortName = "僵尸";

		// Token: 0x04002E3F RID: 11839
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002E3F")]
		[NonSerialized]
		private EventNodeBase zombieSourceNode;

		// Token: 0x04002E40 RID: 11840
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002E40")]
		[NonSerialized]
		private string zombieSourcePort;

		// Token: 0x04002E41 RID: 11841
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002E41")]
		[NonSerialized]
		private EventNodeBase animNameSourceNode;

		// Token: 0x04002E42 RID: 11842
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002E42")]
		[NonSerialized]
		private string animNameSourcePort;
	}
}
