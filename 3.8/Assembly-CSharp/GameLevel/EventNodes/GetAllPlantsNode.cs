using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.EventNodes
{
	// Token: 0x02000BCB RID: 3019
	[Token(Token = "0x2000BCB")]
	[Serializable]
	public class GetAllPlantsNode : EventNodeBase
	{
		// Token: 0x06003ED7 RID: 16087 RVA: 0x0014C6C0 File Offset: 0x0014A8C0
		[Token(Token = "0x6003ED7")]
		[Address(RVA = "0x7F57C0", Offset = "0x7F3DC0", VA = "0x1807F57C0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003ED8 RID: 16088 RVA: 0x0014C6D0 File Offset: 0x0014A8D0
		[Token(Token = "0x6003ED8")]
		[Address(RVA = "0x7F5800", Offset = "0x7F3E00", VA = "0x1807F5800", Slot = "5")]
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

		// Token: 0x06003ED9 RID: 16089 RVA: 0x0014C708 File Offset: 0x0014A908
		[Token(Token = "0x6003ED9")]
		[Address(RVA = "0x9AC810", Offset = "0x9AAE10", VA = "0x1809AC810", Slot = "9")]
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

		// Token: 0x06003EDA RID: 16090 RVA: 0x0014C7D0 File Offset: 0x0014A9D0
		[Token(Token = "0x6003EDA")]
		[Address(RVA = "0x7F58F0", Offset = "0x7F3EF0", VA = "0x1807F58F0")]
		public GetAllPlantsNode()
		{
		}

		// Token: 0x04002FBC RID: 12220
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002FBC")]
		public string plants_PortName = "全部植物";
	}
}
