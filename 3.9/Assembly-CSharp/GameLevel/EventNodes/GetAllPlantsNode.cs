using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000C0D RID: 3085
	[Token(Token = "0x2000C0D")]
	[Serializable]
	public class GetAllPlantsNode : EventNodeBase
	{
		// Token: 0x06004028 RID: 16424 RVA: 0x0015192C File Offset: 0x0014FB2C
		[Token(Token = "0x6004028")]
		[Address(RVA = "0x85D370", Offset = "0x85B970", VA = "0x18085D370", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06004029 RID: 16425 RVA: 0x0015193C File Offset: 0x0014FB3C
		[Token(Token = "0x6004029")]
		[Address(RVA = "0x85D3B0", Offset = "0x85B9B0", VA = "0x18085D3B0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			PortDefinition portDefinition = new PortDefinition(this.plants_PortName, (PortType)((uint)14), (PortDirection)((uint)1));
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x0600402A RID: 16426 RVA: 0x00151974 File Offset: 0x0014FB74
		[Token(Token = "0x600402A")]
		[Address(RVA = "0xA55DD0", Offset = "0xA543D0", VA = "0x180A55DD0", Slot = "9")]
		public override T GetPortValue<T>(string portName, T defaultValue)
		{
			List<Plant> list;
			ulong num4;
			do
			{
				if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
				{
				}
				int num = 0;
				if (num == 0)
				{
					goto IL_00AB;
				}
				Type typeFromHandle = typeof(List<Plant>);
				Type type;
				if (!type.Equals(typeFromHandle))
				{
					goto IL_00AB;
				}
				Board instance = Board.Instance;
				int num2 = 0;
				if (instance == num2)
				{
					goto IL_009D;
				}
				list = new List();
				List<Plant> plantArray = instance.boardEntity.plantArray;
				bool flag;
				if (flag)
				{
					int num3 = 0;
					if (!(num != num3))
					{
						continue;
					}
				}
			}
			while (num4 != (ulong)0L);
			int size = list._size;
			string text = string.Format("[GetAllPlantsNode] 获取场上全部植物，共{0}个", size);
			EventNodeDebug.Log(text);
			IL_009D:
			string text2;
			EventNodeDebug.LogWarning(text2);
			List<Plant> list2 = new List();
			IL_00AB:
			throw new NullReferenceException();
		}

		// Token: 0x0600402B RID: 16427 RVA: 0x00151A3C File Offset: 0x0014FC3C
		[Token(Token = "0x600402B")]
		[Address(RVA = "0x85D4A0", Offset = "0x85BAA0", VA = "0x18085D4A0")]
		public GetAllPlantsNode()
		{
		}

		// Token: 0x04003130 RID: 12592
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003130")]
		public string plants_PortName = "全部植物";
	}
}
