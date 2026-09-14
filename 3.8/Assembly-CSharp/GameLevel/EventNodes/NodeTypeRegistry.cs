using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B58 RID: 2904
	[Token(Token = "0x2000B58")]
	public class NodeTypeRegistry
	{
		// Token: 0x06003C7A RID: 15482 RVA: 0x0013E008 File Offset: 0x0013C208
		[Token(Token = "0x6003C7A")]
		[Address(RVA = "0x7D2B80", Offset = "0x7D1180", VA = "0x1807D2B80")]
		static NodeTypeRegistry()
		{
			NodeTypeRegistry.RegisterBuiltInNodes();
		}

		// Token: 0x06003C7B RID: 15483 RVA: 0x0013E034 File Offset: 0x0013C234
		[Token(Token = "0x6003C7B")]
		[Address(RVA = "0x7D0720", Offset = "0x7CED20", VA = "0x1807D0720")]
		private static void RegisterBuiltInNodes()
		{
		}

		// Token: 0x06003C7C RID: 15484 RVA: 0x0013E044 File Offset: 0x0013C244
		[Token(Token = "0x6003C7C")]
		[Address(RVA = "0x9F47D0", Offset = "0x9F2DD0", VA = "0x1809F47D0")]
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

		// Token: 0x06003C7D RID: 15485 RVA: 0x0013E0AC File Offset: 0x0013C2AC
		[Token(Token = "0x6003C7D")]
		[Address(RVA = "0x7D05A0", Offset = "0x7CEBA0", VA = "0x1807D05A0")]
		public static NodeTypeInfo GetNodeInfo(string typeName)
		{
			int num = 0;
			bool flag = NodeTypeRegistry.nodeTypes.TryGetValue(typeName, num);
			throw new NullReferenceException();
		}

		// Token: 0x06003C7E RID: 15486 RVA: 0x0013E0D0 File Offset: 0x0013C2D0
		[Token(Token = "0x6003C7E")]
		[Address(RVA = "0x7D0530", Offset = "0x7CEB30", VA = "0x1807D0530")]
		public static IEnumerable<NodeTypeInfo> GetAllNodeTypes()
		{
			Dictionary<string, NodeTypeInfo>.ValueCollection values = NodeTypeRegistry.nodeTypes.Values;
			throw new NullReferenceException();
		}

		// Token: 0x06003C7F RID: 15487 RVA: 0x0013E0F8 File Offset: 0x0013C2F8
		[Token(Token = "0x6003C7F")]
		[Address(RVA = "0x7D0640", Offset = "0x7CEC40", VA = "0x1807D0640")]
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

		// Token: 0x06003C80 RID: 15488 RVA: 0x0013E128 File Offset: 0x0013C328
		[Token(Token = "0x6003C80")]
		[Address(RVA = "0x7D04B0", Offset = "0x7CEAB0", VA = "0x1807D04B0")]
		public static IEnumerable<string> GetAllCategories()
		{
			Dictionary<string, List<NodeTypeInfo>>.KeyCollection keys = NodeTypeRegistry.categorizedNodes.Keys;
			throw new NullReferenceException();
		}

		// Token: 0x06003C81 RID: 15489 RVA: 0x0013E150 File Offset: 0x0013C350
		[Token(Token = "0x6003C81")]
		[Address(RVA = "0x7D02B0", Offset = "0x7CE8B0", VA = "0x1807D02B0")]
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

		// Token: 0x06003C82 RID: 15490 RVA: 0x0013E1A8 File Offset: 0x0013C3A8
		[Token(Token = "0x6003C82")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public NodeTypeRegistry()
		{
		}

		// Token: 0x04002CD4 RID: 11476
		[Token(Token = "0x4002CD4")]
		private static Dictionary<string, NodeTypeInfo> nodeTypes = new Dictionary();

		// Token: 0x04002CD5 RID: 11477
		[Token(Token = "0x4002CD5")]
		private static Dictionary<string, List<NodeTypeInfo>> categorizedNodes = new Dictionary();
	}
}
