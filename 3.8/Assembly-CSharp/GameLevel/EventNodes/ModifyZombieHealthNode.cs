using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BC6 RID: 3014
	[Token(Token = "0x2000BC6")]
	[Serializable]
	public class ModifyZombieHealthNode : EventNodeBase
	{
		// Token: 0x06003EBE RID: 16062 RVA: 0x0014BC64 File Offset: 0x00149E64
		[Token(Token = "0x6003EBE")]
		[Address(RVA = "0x7FB770", Offset = "0x7F9D70", VA = "0x1807FB770", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			PortDefinition[] array = new PortDefinition[3];
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
			int num4;
			PortDefinition portDefinition3 = new PortDefinition(this.ratio_PortName, (PortType)((uint)3), (PortDirection)num4);
			num4 = 0;
			if (portDefinition3 != 0)
			{
			}
			array[2] = portDefinition3;
			return array;
		}

		// Token: 0x06003EBF RID: 16063 RVA: 0x0014BCE4 File Offset: 0x00149EE4
		[Token(Token = "0x6003EBF")]
		[Address(RVA = "0x7FB950", Offset = "0x7F9F50", VA = "0x1807FB950", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.onModified_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			PortDefinition portDefinition2 = new PortDefinition(this.zombieOut_PortName, (PortType)((uint)12), (PortDirection)((uint)1));
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003EC0 RID: 16064 RVA: 0x0014BD3C File Offset: 0x00149F3C
		[Token(Token = "0x6003EC0")]
		[Address(RVA = "0x7FBAC0", Offset = "0x7FA0C0", VA = "0x1807FBAC0", Slot = "7")]
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
			string text2 = this.ratio_PortName;
			string nodeId2 = this.nodeId;
			List<SourcePortInfo> sourceNodes2 = graph.GetSourceNodes(nodeId2, text2);
			int num3 = 0;
			EventNodeBase sourceNode2 = sourceNodes2[num3].sourceNode;
			this.ratioSourceNode = sourceNode2;
			int num4 = 0;
			string sourcePortName2 = sourceNodes2[num4].sourcePortName;
			this.ratioSourcePort = sourcePortName2;
			string text3 = this.onModified_PortName;
			string nodeId3 = this.nodeId;
			List<EventNodeBase> connectedNodes = graph.GetConnectedNodes(nodeId3, text3);
			this.onModifiedTargets = connectedNodes;
			throw new NullReferenceException();
		}

		// Token: 0x06003EC1 RID: 16065 RVA: 0x0014BE10 File Offset: 0x0014A010
		[Token(Token = "0x6003EC1")]
		[Address(RVA = "0x9E7780", Offset = "0x9E5D80", VA = "0x1809E7780", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003EC2 RID: 16066 RVA: 0x0014BE58 File Offset: 0x0014A058
		[Token(Token = "0x6003EC2")]
		[Address(RVA = "0x7FB400", Offset = "0x7F9A00", VA = "0x1807FB400", Slot = "6")]
		public override void Execute()
		{
			ulong num4;
			do
			{
				int num = 0;
				if (this.zombieSourceNode != 0)
				{
					num += 20;
					num += num;
				}
				this.targetZombie = num;
				if (this.ratioSourceNode != 0)
				{
					string text = this.ratioSourcePort;
					num += 20;
					num += num;
				}
				Zombie zombie = this.targetZombie;
				int num2 = 0;
				bool flag = zombie != num2;
				if (!flag)
				{
					break;
				}
				float num3;
				Lawnf.SetZombieHealth(this.targetZombie, num3);
				EventNodeDebug.Log(string.Format("[ModifyZombieHealthNode] 修改僵尸血量倍率{0}", flag));
				List<EventNodeBase> list = this.onModifiedTargets;
				bool flag2;
				if (flag2)
				{
				}
			}
			while (num4 != (ulong)0L);
			string text2;
			EventNodeDebug.LogWarning(text2);
		}

		// Token: 0x06003EC3 RID: 16067 RVA: 0x0014BF04 File Offset: 0x0014A104
		[Token(Token = "0x6003EC3")]
		[Address(RVA = "0x7FBC30", Offset = "0x7FA230", VA = "0x1807FBC30")]
		public ModifyZombieHealthNode()
		{
			List<EventNodeBase> list = new List();
			this.onModifiedTargets = list;
			base..ctor();
		}

		// Token: 0x04002F9A RID: 12186
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002F9A")]
		public string trigger_PortName = "触发";

		// Token: 0x04002F9B RID: 12187
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002F9B")]
		public string zombie_PortName = "僵尸";

		// Token: 0x04002F9C RID: 12188
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002F9C")]
		public string ratio_PortName = "血量倍率";

		// Token: 0x04002F9D RID: 12189
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002F9D")]
		public string onModified_PortName = "修改成功";

		// Token: 0x04002F9E RID: 12190
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002F9E")]
		public string zombieOut_PortName = "僵尸";

		// Token: 0x04002F9F RID: 12191
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002F9F")]
		[NonSerialized]
		private EventNodeBase zombieSourceNode;

		// Token: 0x04002FA0 RID: 12192
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002FA0")]
		[NonSerialized]
		private string zombieSourcePort;

		// Token: 0x04002FA1 RID: 12193
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002FA1")]
		[NonSerialized]
		private EventNodeBase ratioSourceNode;

		// Token: 0x04002FA2 RID: 12194
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002FA2")]
		[NonSerialized]
		private string ratioSourcePort;

		// Token: 0x04002FA3 RID: 12195
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002FA3")]
		[NonSerialized]
		private List<EventNodeBase> onModifiedTargets;

		// Token: 0x04002FA4 RID: 12196
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002FA4")]
		private Zombie targetZombie;
	}
}
