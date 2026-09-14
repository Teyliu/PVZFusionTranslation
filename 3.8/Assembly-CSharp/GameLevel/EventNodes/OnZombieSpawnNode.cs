using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B99 RID: 2969
	[Token(Token = "0x2000B99")]
	[Serializable]
	public class OnZombieSpawnNode : EventNodeBase
	{
		// Token: 0x06003DD9 RID: 15833 RVA: 0x00146A14 File Offset: 0x00144C14
		[Token(Token = "0x6003DD9")]
		[Address(RVA = "0x7FEAB0", Offset = "0x7FD0B0", VA = "0x1807FEAB0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003DDA RID: 15834 RVA: 0x00146A24 File Offset: 0x00144C24
		[Token(Token = "0x6003DDA")]
		[Address(RVA = "0x7FEAF0", Offset = "0x7FD0F0", VA = "0x1807FEAF0", Slot = "5")]
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

		// Token: 0x06003DDB RID: 15835 RVA: 0x00146A7C File Offset: 0x00144C7C
		[Token(Token = "0x6003DDB")]
		[Address(RVA = "0x74FFB0", Offset = "0x74E5B0", VA = "0x18074FFB0")]
		public void SetZombie(Zombie zombie)
		{
			this.currentZombie = zombie;
		}

		// Token: 0x06003DDC RID: 15836 RVA: 0x00146A90 File Offset: 0x00144C90
		[Token(Token = "0x6003DDC")]
		[Address(RVA = "0x9F7C30", Offset = "0x9F6230", VA = "0x1809F7C30", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003DDD RID: 15837 RVA: 0x00146AD8 File Offset: 0x00144CD8
		[Token(Token = "0x6003DDD")]
		[Address(RVA = "0x7FE970", Offset = "0x7FCF70", VA = "0x1807FE970", Slot = "6")]
		public override void Execute()
		{
			Zombie zombie = this.currentZombie;
			int num = 0;
			if (!(zombie == num))
			{
				ZombieType theZombieType = this.currentZombie.theZombieType;
				EventNodeDebug.Log(string.Format("[OnZombieSpawnNode] 触发僵尸生成事件: {0}", theZombieType));
				string text = this.trigger_PortName;
				base.TriggerConnectedNodes(text);
				return;
			}
			string nodeId = this.nodeId;
			EventNodeDebug.LogWarning("[OnZombieSpawnNode] currentZombie 为 null，无法触发僵尸生成事件，节点ID: " + nodeId);
		}

		// Token: 0x06003DDE RID: 15838 RVA: 0x00146B44 File Offset: 0x00144D44
		[Token(Token = "0x6003DDE")]
		[Address(RVA = "0x7FEC60", Offset = "0x7FD260", VA = "0x1807FEC60")]
		public OnZombieSpawnNode()
		{
		}

		// Token: 0x04002E8A RID: 11914
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E8A")]
		public string trigger_PortName = "触发";

		// Token: 0x04002E8B RID: 11915
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E8B")]
		public string zombie_PortName = "僵尸";

		// Token: 0x04002E8C RID: 11916
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002E8C")]
		private Zombie currentZombie;
	}
}
