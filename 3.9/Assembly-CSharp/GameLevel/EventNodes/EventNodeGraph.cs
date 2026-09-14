using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B82 RID: 2946
	[Token(Token = "0x2000B82")]
	[Serializable]
	public class EventNodeGraph
	{
		// Token: 0x06003D4B RID: 15691 RVA: 0x0013F8C4 File Offset: 0x0013DAC4
		[Token(Token = "0x6003D4B")]
		[Address(RVA = "0xA2EF60", Offset = "0xA2D560", VA = "0x180A2EF60")]
		public T AddNode<T>(Vector2 position) where T : EventNodeBase, new()
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			Type typeFromHandle = typeof(Type);
			string name = typeFromHandle.Name;
			string name2 = Type.GetTypeFromHandle(typeFromHandle._impl).Name;
			List<EventNodeBase> list = this.nodes;
			int num = list._size + 1;
			list._size = num;
			throw new NullReferenceException();
		}

		// Token: 0x06003D4C RID: 15692 RVA: 0x0013F934 File Offset: 0x0013DB34
		[Token(Token = "0x6003D4C")]
		[Address(RVA = "0x829C30", Offset = "0x828230", VA = "0x180829C30")]
		public void Connect(string sourceNodeId, string sourcePort, string targetNodeId, string targetPort)
		{
			List<NodeConnection> list = this.connections;
			int num = 0;
			NodeConnection nodeConnection;
			nodeConnection.FieldGetter(num, sourcePort, targetNodeId);
			nodeConnection.sourceNodeId = sourceNodeId;
			nodeConnection.sourcePortName = sourcePort;
			nodeConnection.targetNodeId = targetNodeId;
			nodeConnection.targetPortName = 0;
			int size = list._size;
		}

		// Token: 0x06003D4D RID: 15693 RVA: 0x0013F984 File Offset: 0x0013DB84
		[Token(Token = "0x6003D4D")]
		[Address(RVA = "0x82A000", Offset = "0x828600", VA = "0x18082A000")]
		public void Disconnect(string sourceNodeId, string sourcePort, string targetNodeId, string targetPort)
		{
			int num = 0;
			EventNodeGraph.<>c__DisplayClass9_0 CS$<>8__locals1;
			CS$<>8__locals1.FieldGetter(num, sourcePort, targetNodeId);
			CS$<>8__locals1.sourceNodeId = sourceNodeId;
			CS$<>8__locals1.sourcePort = sourcePort;
			CS$<>8__locals1.targetNodeId = targetNodeId;
			CS$<>8__locals1.targetPort = 0;
			Predicate<NodeConnection> predicate;
			int num2 = this.connections.RemoveAll(predicate);
		}

		// Token: 0x06003D4E RID: 15694 RVA: 0x0013F9CC File Offset: 0x0013DBCC
		[Token(Token = "0x6003D4E")]
		[Address(RVA = "0x82AE90", Offset = "0x829490", VA = "0x18082AE90")]
		public void RemoveNode(string nodeId)
		{
			new EventNodeGraph.<>c__DisplayClass10_0().nodeId = nodeId;
			Predicate<EventNodeBase> predicate;
			int num = this.nodes.RemoveAll(predicate);
			Predicate<NodeConnection> predicate2;
			int num2 = this.connections.RemoveAll(predicate2);
		}

		// Token: 0x06003D4F RID: 15695 RVA: 0x0013FA08 File Offset: 0x0013DC08
		[Token(Token = "0x6003D4F")]
		[Address(RVA = "0x829180", Offset = "0x827780", VA = "0x180829180")]
		public void BuildCache()
		{
			int num4;
			do
			{
				int num = 0;
				int num2 = 0;
				Dictionary<string, EventNodeBase> dictionary = new Dictionary();
				this.nodeCache = dictionary;
				List<EventNodeBase> list = this.nodes;
				bool flag;
				if (flag)
				{
					int num3 = 0;
					bool flag2;
					while (flag2)
					{
					}
					this.nodeCache[num3] = num;
				}
				if (num2 != 0)
				{
					goto IL_0107;
				}
				num4 = 0;
				Dictionary<string, List<EventNodeBase>> dictionary2 = new Dictionary();
				Dictionary<string, List<SourcePortInfo>> dictionary3 = new Dictionary();
				bool flag3;
				if (flag3)
				{
					bool flag4;
					if (!flag4)
					{
						List<EventNodeBase> list2 = new List();
					}
					bool flag5;
					if (flag5)
					{
					}
					bool flag6;
					if (!flag6)
					{
						List<SourcePortInfo> list3 = new List();
					}
					bool flag7;
					while (!flag7)
					{
					}
				}
			}
			while (num4 != 0);
			object[] array = new object[4];
			if (array != 0)
			{
			}
			array[0] = array;
			int num5 = array.Length;
			if (num5 != 0)
			{
			}
			array[1] = num5;
			int num6;
			num5 = num6;
			if (num6 != 0)
			{
			}
			array[2] = num5;
			int num7;
			if (num7 != 0)
			{
			}
			array[3] = num7;
			string text = string.Format("[EventNodeGraph] 构建缓存完成: {0} 个节点, {1} 条连接, {2} 个输出端口, {3} 个输入端口", array);
			if (GameAPP.config.debug)
			{
				Debug.Log(text);
			}
			return;
			IL_0107:
			throw new NullReferenceException();
		}

		// Token: 0x06003D50 RID: 15696 RVA: 0x0013FB60 File Offset: 0x0013DD60
		[Token(Token = "0x6003D50")]
		[Address(RVA = "0x829AB0", Offset = "0x8280B0", VA = "0x180829AB0")]
		public void ClearCache()
		{
			Dictionary<string, EventNodeBase> dictionary = this.nodeCache;
			int num = 0;
			if (dictionary != 0)
			{
				int count = dictionary.Count;
			}
			Dictionary<string, List<EventNodeBase>> dictionary2 = this.connectionCache;
			if (dictionary2 != 0)
			{
				int count2 = dictionary2.Count;
			}
			Dictionary<string, List<SourcePortInfo>> dictionary3 = this.reverseConnectionCache;
			if (dictionary3 != 0)
			{
				int count3 = dictionary3.Count;
			}
			this.nodeCache = num;
			this.connectionCache = num;
			this.reverseConnectionCache = num;
			int num2;
			int num3;
			int num4;
			EventNodeDebug.Log(string.Format("[EventNodeGraph] 清空缓存完成: 释放 {0} 个节点引用, {1} 个输出端口, {2} 个输入端口", num2, num3, num4));
		}

		// Token: 0x06003D51 RID: 15697 RVA: 0x0013FBD4 File Offset: 0x0013DDD4
		[Token(Token = "0x6003D51")]
		[Address(RVA = "0x82A130", Offset = "0x828730", VA = "0x18082A130")]
		public List<EventNodeBase> GetConnectedNodes(string sourceNodeId, string portName)
		{
			for (;;)
			{
				int num = 0;
				int num2 = 0;
				if (this.connectionCache != num2)
				{
					string text = sourceNodeId + ":" + portName;
					if (!this.connectionCache.TryGetValue(text, num))
					{
						break;
					}
				}
				EventNodeDebug.LogWarning("[EventNodeGraph] 缓存未构建，使用慢速查询");
				List<EventNodeBase> list = new List();
				List<NodeConnection> list2 = this.connections;
				bool flag;
				if (flag)
				{
					while (!flag)
					{
					}
					while (!flag)
					{
					}
					List<EventNodeBase> list3 = this.nodes;
					bool flag2;
					if (flag2)
					{
						while (!flag2)
						{
						}
					}
					if (num != 0)
					{
						goto IL_008A;
					}
				}
				if (num == 0)
				{
					goto Block_3;
				}
			}
			return new List();
			Block_3:
			throw new NullReferenceException();
			IL_008A:
			throw new NullReferenceException();
		}

		// Token: 0x06003D52 RID: 15698 RVA: 0x0013FC84 File Offset: 0x0013DE84
		[Token(Token = "0x6003D52")]
		[Address(RVA = "0x82A520", Offset = "0x828B20", VA = "0x18082A520")]
		public EventNodeBase GetNodeById(string nodeId)
		{
			int num;
			do
			{
				num = 0;
				int num2 = 0;
				if (this.nodeCache != num2 && !this.nodeCache.TryGetValue(nodeId, num))
				{
					break;
				}
				List<EventNodeBase> list = this.nodes;
				bool flag;
				if (flag)
				{
					while (!flag)
					{
					}
				}
			}
			while (num != 0);
			throw new NullReferenceException();
		}

		// Token: 0x06003D53 RID: 15699 RVA: 0x0013FCD8 File Offset: 0x0013DED8
		[Token(Token = "0x6003D53")]
		[Address(RVA = "0x82A7B0", Offset = "0x828DB0", VA = "0x18082A7B0")]
		public List<SourcePortInfo> GetSourceNodes(string targetNodeId, string targetPortName)
		{
			for (;;)
			{
				int num = 0;
				int num2 = 0;
				if (this.reverseConnectionCache != num2)
				{
					string text = targetNodeId + ":" + targetPortName;
					if (!this.reverseConnectionCache.TryGetValue(text, num))
					{
						break;
					}
				}
				EventNodeDebug.LogWarning("[EventNodeGraph] 反向缓存未构建，使用慢速查询");
				List<SourcePortInfo> list = new List();
				List<NodeConnection> list2 = this.connections;
				bool flag;
				if (flag)
				{
					while (!flag)
					{
					}
					while (!flag)
					{
					}
					if (!this.nodeCache.TryGetValue(targetPortName, num))
					{
						continue;
					}
					SourcePortInfo sourcePortInfo = new SourcePortInfo(num, targetPortName);
				}
				if (num == 0)
				{
					goto Block_4;
				}
			}
			return new List();
			Block_4:
			throw new NullReferenceException();
		}

		// Token: 0x06003D54 RID: 15700 RVA: 0x0013FD80 File Offset: 0x0013DF80
		[Token(Token = "0x6003D54")]
		[Address(RVA = "0x829D70", Offset = "0x828370", VA = "0x180829D70")]
		public NodeGroup CreateGroup(List<string> nodeIds, string title = "新分组")
		{
			NodeGroup nodeGroup;
			ulong num2;
			do
			{
				int num = 0;
				nodeGroup = new NodeGroup();
				nodeGroup.title = title;
				bool flag;
				if (flag)
				{
					nodeGroup.AddNode(num);
				}
			}
			while (num2 != (ulong)0L);
			string title2 = nodeGroup.title;
			int nodeCount = nodeGroup.NodeCount;
			EventNodeDebug.Log(string.Format("[EventNodeGraph] 创建分组: {0}, 包含 {1} 个节点", title2, nodeCount));
			return nodeGroup;
		}

		// Token: 0x06003D55 RID: 15701 RVA: 0x0013FDE0 File Offset: 0x0013DFE0
		[Token(Token = "0x6003D55")]
		[Address(RVA = "0x82AAE0", Offset = "0x8290E0", VA = "0x18082AAE0")]
		public void RemoveGroup(string groupId)
		{
			Predicate<NodeGroup> predicate;
			int num = this.groups.RemoveAll(predicate);
			string groupId2 = groupId;
			EventNodeDebug.Log("[EventNodeGraph] 删除分组: " + groupId2);
		}

		// Token: 0x06003D56 RID: 15702 RVA: 0x0013FE28 File Offset: 0x0013E028
		[Token(Token = "0x6003D56")]
		[Address(RVA = "0x829010", Offset = "0x827610", VA = "0x180829010")]
		public void AddNodeToGroup(string nodeId, string groupId)
		{
			new EventNodeGraph.<>c__DisplayClass18_0().groupId = groupId;
			Predicate<NodeGroup> predicate;
			NodeGroup nodeGroup = this.groups.Find(predicate);
			if (nodeGroup != 0)
			{
				nodeGroup.AddNode(nodeId);
				string title = nodeGroup.title;
				EventNodeDebug.Log("[EventNodeGraph] 节点 " + nodeId + " 添加到分组 " + title);
			}
		}

		// Token: 0x06003D57 RID: 15703 RVA: 0x0013FE7C File Offset: 0x0013E07C
		[Token(Token = "0x6003D57")]
		[Address(RVA = "0x82AC10", Offset = "0x829210", VA = "0x18082AC10")]
		public void RemoveNodeFromGroup(string nodeId)
		{
			ulong num;
			do
			{
				List<NodeGroup> list = this.groups;
				bool flag;
				if (flag)
				{
					bool flag2;
					while (!flag2)
					{
					}
					EventNodeDebug.Log(string.Concat(new string[] { "[EventNodeGraph] 节点 ", nodeId, " 从分组 ", " 从分组 ", " 移除" }));
				}
			}
			while (num != (ulong)0L);
		}

		// Token: 0x06003D58 RID: 15704 RVA: 0x0013FF24 File Offset: 0x0013E124
		[Token(Token = "0x6003D58")]
		[Address(RVA = "0x82A6D0", Offset = "0x828CD0", VA = "0x18082A6D0")]
		public NodeGroup GetNodeGroup(string nodeId)
		{
			new EventNodeGraph.<>c__DisplayClass20_0().nodeId = nodeId;
			Predicate<NodeGroup> predicate;
			return this.groups.Find(predicate);
		}

		// Token: 0x06003D59 RID: 15705 RVA: 0x0013FF50 File Offset: 0x0013E150
		[Token(Token = "0x6003D59")]
		[Address(RVA = "0x82AFE0", Offset = "0x8295E0", VA = "0x18082AFE0")]
		public EventNodeGraph()
		{
			List<EventNodeBase> list = new List();
			this.nodes = list;
			List<NodeConnection> list2 = new List();
			this.connections = list2;
			List<VariableAsset> list3 = new List();
			this.variables = list3;
			List<NodeGroup> list4 = new List();
			this.groups = list4;
			base..ctor();
		}

		// Token: 0x04002DE5 RID: 11749
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002DE5")]
		[SerializeReference]
		public List<EventNodeBase> nodes;

		// Token: 0x04002DE6 RID: 11750
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002DE6")]
		public List<NodeConnection> connections;

		// Token: 0x04002DE7 RID: 11751
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002DE7")]
		[SerializeReference]
		public List<VariableAsset> variables;

		// Token: 0x04002DE8 RID: 11752
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002DE8")]
		[SerializeReference]
		public List<NodeGroup> groups;

		// Token: 0x04002DE9 RID: 11753
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002DE9")]
		[NonSerialized]
		private Dictionary<string, List<EventNodeBase>> connectionCache;

		// Token: 0x04002DEA RID: 11754
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002DEA")]
		[NonSerialized]
		private Dictionary<string, List<SourcePortInfo>> reverseConnectionCache;

		// Token: 0x04002DEB RID: 11755
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002DEB")]
		[NonSerialized]
		private Dictionary<string, EventNodeBase> nodeCache;
	}
}
