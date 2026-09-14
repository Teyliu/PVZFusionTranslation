using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B9A RID: 2970
	[Token(Token = "0x2000B9A")]
	public class NodeTypeRegistry
	{
		// Token: 0x06003DCB RID: 15819 RVA: 0x001432B8 File Offset: 0x001414B8
		[Token(Token = "0x6003DCB")]
		[Address(RVA = "0x84EEE0", Offset = "0x84D4E0", VA = "0x18084EEE0")]
		static NodeTypeRegistry()
		{
			NodeTypeRegistry.RegisterBuiltInNodes();
		}

		// Token: 0x06003DCC RID: 15820 RVA: 0x001432E4 File Offset: 0x001414E4
		[Token(Token = "0x6003DCC")]
		[Address(RVA = "0x84CA80", Offset = "0x84B080", VA = "0x18084CA80")]
		private static void RegisterBuiltInNodes()
		{
		}

		// Token: 0x06003DCD RID: 15821 RVA: 0x001432F4 File Offset: 0x001414F4
		[Token(Token = "0x6003DCD")]
		[Address(RVA = "0xAA6010", Offset = "0xAA4610", VA = "0x180AA6010")]
		public static void RegisterNode<T>(string category, string displayName, string description, Color color) where T : EventNodeBase
		{
			Type type;
			string name = type.Name;
			NodeTypeInfo nodeTypeInfo;
			NodeTypeRegistry.nodeTypes[name] = nodeTypeInfo;
			if (!NodeTypeRegistry.categorizedNodes.ContainsKey(category))
			{
				Dictionary<string, List<NodeTypeInfo>> dictionary = NodeTypeRegistry.categorizedNodes;
				List<NodeTypeInfo> list = new List();
				dictionary[category] = list;
			}
			int size = NodeTypeRegistry.categorizedNodes[category]._size;
		}

		// Token: 0x06003DCE RID: 15822 RVA: 0x0014335C File Offset: 0x0014155C
		[Token(Token = "0x6003DCE")]
		[Address(RVA = "0x84C900", Offset = "0x84AF00", VA = "0x18084C900")]
		public static NodeTypeInfo GetNodeInfo(string typeName)
		{
			int num = 0;
			bool flag = NodeTypeRegistry.nodeTypes.TryGetValue(typeName, num);
			throw new NullReferenceException();
		}

		// Token: 0x06003DCF RID: 15823 RVA: 0x00143380 File Offset: 0x00141580
		[Token(Token = "0x6003DCF")]
		[Address(RVA = "0x84C890", Offset = "0x84AE90", VA = "0x18084C890")]
		public static IEnumerable<NodeTypeInfo> GetAllNodeTypes()
		{
			Dictionary<string, NodeTypeInfo>.ValueCollection values = NodeTypeRegistry.nodeTypes.Values;
			throw new NullReferenceException();
		}

		// Token: 0x06003DD0 RID: 15824 RVA: 0x001433A8 File Offset: 0x001415A8
		[Token(Token = "0x6003DD0")]
		[Address(RVA = "0x84C9A0", Offset = "0x84AFA0", VA = "0x18084C9A0")]
		public static IEnumerable<NodeTypeInfo> GetNodesByCategory(string category)
		{
			Dictionary<string, List<NodeTypeInfo>> dictionary = NodeTypeRegistry.categorizedNodes;
			bool flag;
			if (flag)
			{
			}
			List<NodeTypeInfo> list = new List();
			throw new NullReferenceException();
		}

		// Token: 0x06003DD1 RID: 15825 RVA: 0x001433D8 File Offset: 0x001415D8
		[Token(Token = "0x6003DD1")]
		[Address(RVA = "0x84C810", Offset = "0x84AE10", VA = "0x18084C810")]
		public static IEnumerable<string> GetAllCategories()
		{
			Dictionary<string, List<NodeTypeInfo>>.KeyCollection keys = NodeTypeRegistry.categorizedNodes.Keys;
			throw new NullReferenceException();
		}

		// Token: 0x06003DD2 RID: 15826 RVA: 0x00143400 File Offset: 0x00141600
		[Token(Token = "0x6003DD2")]
		[Address(RVA = "0x84C610", Offset = "0x84AC10", VA = "0x18084C610")]
		public static EventNodeBase CreateNode(string typeName)
		{
			string text = "GameLevel.EventNodes." + typeName;
			int num = 0;
			if (!text.Equals(num))
			{
				Type typeFromHandle = typeof(EventNodeBase);
				bool flag;
				if (flag)
				{
					object obj;
					if (obj != 0)
					{
					}
				}
			}
			EventNodeDebug.LogError("未知的节点类型: " + typeName);
			throw new NullReferenceException();
		}

		// Token: 0x06003DD3 RID: 15827 RVA: 0x00143458 File Offset: 0x00141658
		[Token(Token = "0x6003DD3")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public NodeTypeRegistry()
		{
		}

		// Token: 0x04002E48 RID: 11848
		[Token(Token = "0x4002E48")]
		private static Dictionary<string, NodeTypeInfo> nodeTypes = new Dictionary();

		// Token: 0x04002E49 RID: 11849
		[Token(Token = "0x4002E49")]
		private static Dictionary<string, List<NodeTypeInfo>> categorizedNodes = new Dictionary();
	}
}
