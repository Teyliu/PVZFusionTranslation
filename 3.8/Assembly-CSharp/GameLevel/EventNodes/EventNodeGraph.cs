using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B40 RID: 2880
	[Token(Token = "0x2000B40")]
	[Serializable]
	public class EventNodeGraph
	{
		// Token: 0x06003BFA RID: 15354 RVA: 0x0013A61C File Offset: 0x0013881C
		[Token(Token = "0x6003BFA")]
		[Address(RVA = "0x967BE0", Offset = "0x9661E0", VA = "0x180967BE0")]
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

		// Token: 0x06003BFB RID: 15355 RVA: 0x0013A68C File Offset: 0x0013888C
		[Token(Token = "0x6003BFB")]
		[Address(RVA = "0x7AE6F0", Offset = "0x7ACCF0", VA = "0x1807AE6F0")]
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

		// Token: 0x06003BFC RID: 15356 RVA: 0x0013A6DC File Offset: 0x001388DC
		[Token(Token = "0x6003BFC")]
		[Address(RVA = "0x7AEAC0", Offset = "0x7AD0C0", VA = "0x1807AEAC0")]
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

		// Token: 0x06003BFD RID: 15357 RVA: 0x0013A724 File Offset: 0x00138924
		[Token(Token = "0x6003BFD")]
		[Address(RVA = "0x7AF950", Offset = "0x7ADF50", VA = "0x1807AF950")]
		public void RemoveNode(string nodeId)
		{
			new EventNodeGraph.<>c__DisplayClass10_0().nodeId = nodeId;
			Predicate<EventNodeBase> predicate;
			int num = this.nodes.RemoveAll(predicate);
			Predicate<NodeConnection> predicate2;
			int num2 = this.connections.RemoveAll(predicate2);
		}

		// Token: 0x06003BFE RID: 15358 RVA: 0x0013A760 File Offset: 0x00138960
		[Token(Token = "0x6003BFE")]
		[Address(RVA = "0x7ADC40", Offset = "0x7AC240", VA = "0x1807ADC40")]
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

		// Token: 0x06003BFF RID: 15359 RVA: 0x0013A8B8 File Offset: 0x00138AB8
		[Token(Token = "0x6003BFF")]
		[Address(RVA = "0x7AE570", Offset = "0x7ACB70", VA = "0x1807AE570")]
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

		// Token: 0x06003C00 RID: 15360 RVA: 0x0013A92C File Offset: 0x00138B2C
		[Token(Token = "0x6003C00")]
		[Address(RVA = "0x7AEBF0", Offset = "0x7AD1F0", VA = "0x1807AEBF0")]
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

		// Token: 0x06003C01 RID: 15361 RVA: 0x0013A9DC File Offset: 0x00138BDC
		[Token(Token = "0x6003C01")]
		[Address(RVA = "0x7AEFE0", Offset = "0x7AD5E0", VA = "0x1807AEFE0")]
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

		// Token: 0x06003C02 RID: 15362 RVA: 0x0013AA30 File Offset: 0x00138C30
		[Token(Token = "0x6003C02")]
		[Address(RVA = "0x7AF270", Offset = "0x7AD870", VA = "0x1807AF270")]
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

		// Token: 0x06003C03 RID: 15363 RVA: 0x0013AAD8 File Offset: 0x00138CD8
		[Token(Token = "0x6003C03")]
		[Address(RVA = "0x7AE830", Offset = "0x7ACE30", VA = "0x1807AE830")]
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

		// Token: 0x06003C04 RID: 15364 RVA: 0x0013AB38 File Offset: 0x00138D38
		[Token(Token = "0x6003C04")]
		[Address(RVA = "0x7AF5A0", Offset = "0x7ADBA0", VA = "0x1807AF5A0")]
		public void RemoveGroup(string groupId)
		{
			Predicate<NodeGroup> predicate;
			int num = this.groups.RemoveAll(predicate);
			string groupId2 = groupId;
			EventNodeDebug.Log("[EventNodeGraph] 删除分组: " + groupId2);
		}

		// Token: 0x06003C05 RID: 15365 RVA: 0x0013AB80 File Offset: 0x00138D80
		[Token(Token = "0x6003C05")]
		[Address(RVA = "0x7ADAD0", Offset = "0x7AC0D0", VA = "0x1807ADAD0")]
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

		// Token: 0x06003C06 RID: 15366 RVA: 0x0013ABD4 File Offset: 0x00138DD4
		[Token(Token = "0x6003C06")]
		[Address(RVA = "0x7AF6D0", Offset = "0x7ADCD0", VA = "0x1807AF6D0")]
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

		// Token: 0x06003C07 RID: 15367 RVA: 0x0013AC7C File Offset: 0x00138E7C
		[Token(Token = "0x6003C07")]
		[Address(RVA = "0x7AF190", Offset = "0x7AD790", VA = "0x1807AF190")]
		public NodeGroup GetNodeGroup(string nodeId)
		{
			new EventNodeGraph.<>c__DisplayClass20_0().nodeId = nodeId;
			Predicate<NodeGroup> predicate;
			return this.groups.Find(predicate);
		}

		// Token: 0x06003C08 RID: 15368 RVA: 0x0013ACA8 File Offset: 0x00138EA8
		[Token(Token = "0x6003C08")]
		[Address(RVA = "0x7AFAA0", Offset = "0x7AE0A0", VA = "0x1807AFAA0")]
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

		// Token: 0x04002C71 RID: 11377
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002C71")]
		[SerializeReference]
		public List<EventNodeBase> nodes;

		// Token: 0x04002C72 RID: 11378
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002C72")]
		public List<NodeConnection> connections;

		// Token: 0x04002C73 RID: 11379
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002C73")]
		[SerializeReference]
		public List<VariableAsset> variables;

		// Token: 0x04002C74 RID: 11380
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002C74")]
		[SerializeReference]
		public List<NodeGroup> groups;

		// Token: 0x04002C75 RID: 11381
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002C75")]
		[NonSerialized]
		private Dictionary<string, List<EventNodeBase>> connectionCache;

		// Token: 0x04002C76 RID: 11382
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002C76")]
		[NonSerialized]
		private Dictionary<string, List<SourcePortInfo>> reverseConnectionCache;

		// Token: 0x04002C77 RID: 11383
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002C77")]
		[NonSerialized]
		private Dictionary<string, EventNodeBase> nodeCache;
	}
}
