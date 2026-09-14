using System;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BDA RID: 3034
	[Token(Token = "0x2000BDA")]
	[Serializable]
	public class OnZombieDieNode : EventNodeBase
	{
		// Token: 0x06003F24 RID: 16164 RVA: 0x0014BB28 File Offset: 0x00149D28
		[Token(Token = "0x6003F24")]
		[Address(RVA = "0x8660F0", Offset = "0x8646F0", VA = "0x1808660F0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003F25 RID: 16165 RVA: 0x0014BB38 File Offset: 0x00149D38
		[Token(Token = "0x6003F25")]
		[Address(RVA = "0x866130", Offset = "0x864730", VA = "0x180866130", Slot = "5")]
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

		// Token: 0x06003F26 RID: 16166 RVA: 0x0014BB90 File Offset: 0x00149D90
		[Token(Token = "0x6003F26")]
		[Address(RVA = "0x7B6970", Offset = "0x7B4F70", VA = "0x1807B6970")]
		public void SetZombie(Zombie zombie)
		{
			this.currentZombie = zombie;
		}

		// Token: 0x06003F27 RID: 16167 RVA: 0x0014BBA4 File Offset: 0x00149DA4
		[Token(Token = "0x6003F27")]
		[Address(RVA = "0xAA9470", Offset = "0xAA7A70", VA = "0x180AA9470", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			return base.GetPortValue(portName, defaultValue);
		}

		// Token: 0x06003F28 RID: 16168 RVA: 0x0014BBEC File Offset: 0x00149DEC
		[Token(Token = "0x6003F28")]
		[Address(RVA = "0x865FB0", Offset = "0x8645B0", VA = "0x180865FB0", Slot = "6")]
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

		// Token: 0x06003F29 RID: 16169 RVA: 0x0014BC58 File Offset: 0x00149E58
		[Token(Token = "0x6003F29")]
		[Address(RVA = "0x8662A0", Offset = "0x8648A0", VA = "0x1808662A0")]
		public OnZombieDieNode()
		{
		}

		// Token: 0x04002FFB RID: 12283
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002FFB")]
		public string trigger_PortName = "触发";

		// Token: 0x04002FFC RID: 12284
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002FFC")]
		public string zombie_PortName = "僵尸";

		// Token: 0x04002FFD RID: 12285
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002FFD")]
		private Zombie currentZombie;
	}
}
