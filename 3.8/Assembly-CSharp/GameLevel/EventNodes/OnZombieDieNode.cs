using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B98 RID: 2968
	[Token(Token = "0x2000B98")]
	[Serializable]
	public class OnZombieDieNode : EventNodeBase
	{
		// Token: 0x06003DD3 RID: 15827 RVA: 0x001468B8 File Offset: 0x00144AB8
		[Token(Token = "0x6003DD3")]
		[Address(RVA = "0x7FE740", Offset = "0x7FCD40", VA = "0x1807FE740", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003DD4 RID: 15828 RVA: 0x001468C8 File Offset: 0x00144AC8
		[Token(Token = "0x6003DD4")]
		[Address(RVA = "0x7FE780", Offset = "0x7FCD80", VA = "0x1807FE780", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[2];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.trigger_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			PortDefinition portDefinition2 = new PortDefinition(this.zombie_PortName, (PortType)((uint)12), (PortDirection)((uint)1));
			if (portDefinition2 != 0)
			{
			}
			array[1] = portDefinition2;
			return array;
		}

		// Token: 0x06003DD5 RID: 15829 RVA: 0x00146920 File Offset: 0x00144B20
		[Token(Token = "0x6003DD5")]
		[Address(RVA = "0x74FFB0", Offset = "0x74E5B0", VA = "0x18074FFB0")]
		public void SetZombie(Zombie zombie)
		{
			this.currentZombie = zombie;
		}

		// Token: 0x06003DD6 RID: 15830 RVA: 0x00146934 File Offset: 0x00144B34
		[Token(Token = "0x6003DD6")]
		[Address(RVA = "0x9F7C30", Offset = "0x9F6230", VA = "0x1809F7C30", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003DD7 RID: 15831 RVA: 0x0014697C File Offset: 0x00144B7C
		[Token(Token = "0x6003DD7")]
		[Address(RVA = "0x7FE600", Offset = "0x7FCC00", VA = "0x1807FE600", Slot = "6")]
		public override void Execute()
		{
			Zombie zombie = this.currentZombie;
			int num = 0;
			if (!(zombie == num))
			{
				ZombieType theZombieType = this.currentZombie.theZombieType;
				EventNodeDebug.Log(string.Format("[OnZombieDieNode] 触发僵尸死亡事件: {0}", theZombieType));
				string text = this.trigger_PortName;
				base.TriggerConnectedNodes(text);
				return;
			}
			string nodeId = this.nodeId;
			EventNodeDebug.LogWarning("[OnZombieDieNode] currentZombie 为 null，无法触发僵尸死亡事件，节点ID: " + nodeId);
		}

		// Token: 0x06003DD8 RID: 15832 RVA: 0x001469E8 File Offset: 0x00144BE8
		[Token(Token = "0x6003DD8")]
		[Address(RVA = "0x7FE8F0", Offset = "0x7FCEF0", VA = "0x1807FE8F0")]
		public OnZombieDieNode()
		{
		}

		// Token: 0x04002E87 RID: 11911
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E87")]
		public string trigger_PortName = "触发";

		// Token: 0x04002E88 RID: 11912
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E88")]
		public string zombie_PortName = "僵尸";

		// Token: 0x04002E89 RID: 11913
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002E89")]
		private Zombie currentZombie;
	}
}
