using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BDB RID: 3035
	[Token(Token = "0x2000BDB")]
	[Serializable]
	public class OnZombieSpawnNode : EventNodeBase
	{
		// Token: 0x06003F2A RID: 16170 RVA: 0x0014BC84 File Offset: 0x00149E84
		[Token(Token = "0x6003F2A")]
		[Address(RVA = "0x866460", Offset = "0x864A60", VA = "0x180866460", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003F2B RID: 16171 RVA: 0x0014BC94 File Offset: 0x00149E94
		[Token(Token = "0x6003F2B")]
		[Address(RVA = "0x8664A0", Offset = "0x864AA0", VA = "0x1808664A0", Slot = "5")]
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

		// Token: 0x06003F2C RID: 16172 RVA: 0x0014BCEC File Offset: 0x00149EEC
		[Token(Token = "0x6003F2C")]
		[Address(RVA = "0x7B6970", Offset = "0x7B4F70", VA = "0x1807B6970")]
		public void SetZombie(Zombie zombie)
		{
			this.currentZombie = zombie;
		}

		// Token: 0x06003F2D RID: 16173 RVA: 0x0014BD00 File Offset: 0x00149F00
		[Token(Token = "0x6003F2D")]
		[Address(RVA = "0xAA9470", Offset = "0xAA7A70", VA = "0x180AA9470", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003F2E RID: 16174 RVA: 0x0014BD48 File Offset: 0x00149F48
		[Token(Token = "0x6003F2E")]
		[Address(RVA = "0x866320", Offset = "0x864920", VA = "0x180866320", Slot = "6")]
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

		// Token: 0x06003F2F RID: 16175 RVA: 0x0014BDB4 File Offset: 0x00149FB4
		[Token(Token = "0x6003F2F")]
		[Address(RVA = "0x866610", Offset = "0x864C10", VA = "0x180866610")]
		public OnZombieSpawnNode()
		{
		}

		// Token: 0x04002FFE RID: 12286
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002FFE")]
		public string trigger_PortName = "触发";

		// Token: 0x04002FFF RID: 12287
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002FFF")]
		public string zombie_PortName = "僵尸";

		// Token: 0x04003000 RID: 12288
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4003000")]
		private Zombie currentZombie;
	}
}
