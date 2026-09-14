using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B96 RID: 2966
	[Token(Token = "0x2000B96")]
	public class EventNodeManager : MonoBehaviour
	{
		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06003DB5 RID: 15797 RVA: 0x00142760 File Offset: 0x00140960
		[Token(Token = "0x170004F4")]
		public static EventNodeManager Instance
		{
			[Token(Token = "0x6003DB5")]
			[Address(RVA = "0x8429C0", Offset = "0x840FC0", VA = "0x1808429C0")]
			get
			{
				EventNodeManager instance = EventNodeManager._instance;
				int num = 0;
				if (instance == num)
				{
					GameObject gameObject = new GameObject("EventNodeManager");
					EventNodeManager._instance = gameObject.AddComponent<EventNodeManager>();
					global::UnityEngine.Object.DontDestroyOnLoad(gameObject);
				}
				return EventNodeManager._instance;
			}
		}

		// Token: 0x06003DB6 RID: 15798 RVA: 0x001427A8 File Offset: 0x001409A8
		[Token(Token = "0x6003DB6")]
		[Address(RVA = "0x8415D0", Offset = "0x83FBD0", VA = "0x1808415D0")]
		public void RegisterGraph(EventNodeGraph graph)
		{
			int num3;
			bool flag2;
			do
			{
				int num = 0;
				this.currentGraph = graph;
				if (graph == 0)
				{
					return;
				}
				graph.BuildCache();
				List<EventNodeBase> nodes = graph.nodes;
				int num2 = 0;
				bool flag;
				if (flag)
				{
				}
				if (num2 != 0)
				{
					goto IL_00C0;
				}
				num3 = 0;
				int num4 = 0;
				string text = string.Format("[EventNodeManager] 已初始化 {0} 个节点的连接引用", flag);
				EventNodeDebug.Log(text);
				if (num4 > 0)
				{
					int stringLength = text._stringLength;
				}
				if (num4 > 0)
				{
				}
				if (num4 > 0)
				{
				}
				if (num4 > 0)
				{
				}
				if (num4 > 0)
				{
				}
				if (num4 > 0)
				{
				}
				if (num4 > 0)
				{
				}
				if (num4 > 0)
				{
				}
				if (num4 > 0)
				{
				}
				if (num4 > 0)
				{
				}
				if (num4 > 0)
				{
				}
				if (flag2)
				{
					while (num == 0)
					{
					}
					if (num != 0)
					{
					}
				}
			}
			while (num3 != 0);
			EventNodeDebug.Log(string.Format("[EventNodeManager] 节点图已注册，共 {0} 个节点", flag2));
			return;
			IL_00C0:
			throw new NullReferenceException();
		}

		// Token: 0x06003DB7 RID: 15799 RVA: 0x001428B8 File Offset: 0x00140AB8
		[Token(Token = "0x6003DB7")]
		[Address(RVA = "0x83F970", Offset = "0x83DF70", VA = "0x18083F970")]
		public void Initialize()
		{
			ulong num8;
			do
			{
				Action action = new Action(this.OnWaveAdd);
				int num = 0;
				EventManager.AddListener(GameEvent.BoardWaveAdd, action, num != 0);
				int num2 = 0;
				Action<object> action2;
				EventManager.AddListener_obj((GameEvent)((uint)8), action2, num2 != 0);
				int num3 = 0;
				Action<object> action3;
				EventManager.AddListener_obj((GameEvent)((uint)9), action3, num3 != 0);
				int num4 = 0;
				Action<object> action4;
				EventManager.AddListener_obj((GameEvent)((uint)2), action4, num4 != 0);
				int num5 = 0;
				Action<object> action5;
				EventManager.AddListener_obj((GameEvent)((uint)14), action5, num5 != 0);
				int num6 = 0;
				Action<object> action6;
				EventManager.AddListener_obj((GameEvent)((uint)1), action6, num6 != 0);
				int num7 = 0;
				Action<object> action7;
				EventManager.AddListener_obj((GameEvent)((uint)7), action7, num7 != 0);
				EventNodeDebug.Log("[EventNodeManager] 已注册BoardWaveAdd、OnPlantCreate、OnMouseClick、OnPlantClick、ZombieDeath、OnZombieSpawn和PlantZeroHealth事件监听");
				List<OnBoardStartNode> list = this.boardStartNodes;
				bool flag;
				if (flag)
				{
				}
			}
			while (num8 != (ulong)0L);
		}

		// Token: 0x06003DB8 RID: 15800 RVA: 0x00142960 File Offset: 0x00140B60
		[Token(Token = "0x6003DB8")]
		[Address(RVA = "0x842280", Offset = "0x840880", VA = "0x180842280")]
		public void Unregister()
		{
			List<WaveEventNode> list = this.waveEventNodes;
			int size = list._size;
			int num = 0;
			list._size = num;
			if (size > 0)
			{
			}
			List<OnBoardStartNode> list2 = this.boardStartNodes;
			int size2 = list2._size;
			list2._size = num;
			if (size2 > 0)
			{
			}
			List<OnGameStartNode> list3 = this.gameStartNodes;
			int size3 = list3._size;
			list3._size = num;
			if (size3 > 0)
			{
			}
			List<OnGameStartNode> list4 = this.gameStartNodes;
			int size4 = list4._size;
			list4._size = num;
			if (size4 > 0)
			{
			}
			List<OnPlantCreateNode> list5 = this.plantCreateNodes;
			int size5 = list5._size;
			list5._size = num;
			if (size5 > 0)
			{
			}
			List<OnMouseClickNode> list6 = this.mouseClickNodes;
			int size6 = list6._size;
			list6._size = num;
			if (size6 > 0)
			{
			}
			List<OnZombieDieNode> list7 = this.zombieDieNodes;
			int size7 = list7._size;
			list7._size = num;
			if (size7 > 0)
			{
			}
			List<OnZombieSpawnNode> list8 = this.zombieSpawnNodes;
			int size8 = list8._size;
			list8._size = num;
			if (size8 > 0)
			{
			}
			List<OnPlantDieNode> list9 = this.plantDieNodes;
			int size9 = list9._size;
			list9._size = num;
			if (size9 > 0)
			{
			}
			List<OnPlantClickNode> list10 = this.plantClickNodes;
			int size10 = list10._size;
			list10._size = num;
			if (size10 > 0)
			{
			}
			List<OnKeyPressNode> list11 = this.keyPressNodes;
			int size11 = list11._size;
			list11._size = num;
			if (size11 > 0)
			{
			}
			this.currentGraph = num;
			base.StopAllCoroutines();
			EventNodeDebug.Log("[EventNodeManager] 已停止所有协程");
			EventNodeDebug.Log("[EventNodeManager] 已取消注册");
		}

		// Token: 0x06003DB9 RID: 15801 RVA: 0x00142AFC File Offset: 0x00140CFC
		[Token(Token = "0x6003DB9")]
		[Address(RVA = "0x840DB0", Offset = "0x83F3B0", VA = "0x180840DB0")]
		private void OnWaveAdd()
		{
			ulong num;
			do
			{
				Board instance = Board.Instance;
				List<WaveEventNode> list = this.waveEventNodes;
				int size = list._size;
				int theWave = instance.theWave;
				EventNodeDebug.Log(string.Format("[EventNodeManager] 触发 {0} 个波次事件节点，当前波次: {1}", list, list));
				List<WaveEventNode> list2 = this.waveEventNodes;
				bool flag;
				if (flag)
				{
				}
			}
			while (num != (ulong)0L);
		}

		// Token: 0x06003DBA RID: 15802 RVA: 0x00142B58 File Offset: 0x00140D58
		[Token(Token = "0x6003DBA")]
		[Address(RVA = "0x840530", Offset = "0x83EB30", VA = "0x180840530")]
		private void OnPlantCreate(object data)
		{
			int num;
			do
			{
				List<OnPlantCreateNode> list = this.plantCreateNodes;
				if (data == 0)
				{
				}
				num = 0;
				if (data == 0)
				{
					break;
				}
				List<OnPlantCreateNode> list2 = this.plantCreateNodes;
				int size = list2._size;
				EventNodeDebug.Log(string.Format("[EventNodeManager] 触发 {0} 个植物种植事件节点，植物类型: {1}", list2, list2));
				List<OnPlantCreateNode> list3 = this.plantCreateNodes;
				bool flag;
				if (flag)
				{
				}
			}
			while (num != 0);
			Type type;
			string name = type.Name;
			EventNodeDebug.LogWarning("[EventNodeManager] OnPlantCreate事件收到的数据不是Plant对象，而是: " + name);
		}

		// Token: 0x06003DBB RID: 15803 RVA: 0x00142BD8 File Offset: 0x00140DD8
		[Token(Token = "0x6003DBB")]
		[Address(RVA = "0x83FCE0", Offset = "0x83E2E0", VA = "0x18083FCE0")]
		private void OnMouseClick(object data)
		{
			int num;
			do
			{
				List<OnMouseClickNode> list = this.mouseClickNodes;
				if (data == 0)
				{
				}
				num = 0;
				if (data == 0)
				{
					break;
				}
				bool flag;
				if (flag)
				{
				}
				object[] array = new object[5];
				int size = this.mouseClickNodes._size;
				if (array != 0)
				{
				}
				array[0] = array;
				if (array != 0)
				{
				}
				array[1] = array;
				if (array != 0)
				{
				}
				array[2] = array;
				if ("无" != 0)
				{
				}
				array[3] = "无";
				string text;
				if (text != 0)
				{
				}
				array[4] = text;
				EventNodeDebug.Log(string.Format("[EventNodeManager] 触发 {0} 个鼠标点击事件节点，位置: 行{1}, 列{2}, 手上物品: {3}, 按键: {4}", array));
				List<OnMouseClickNode> list2 = this.mouseClickNodes;
				bool flag2;
				if (flag2)
				{
				}
			}
			while (num != 0);
			Type type;
			string name = type.Name;
			EventNodeDebug.LogWarning("[EventNodeManager] OnMouseClick事件收到的数据不是MouseClickData对象，而是: " + name);
		}

		// Token: 0x06003DBC RID: 15804 RVA: 0x00142CB0 File Offset: 0x00140EB0
		[Token(Token = "0x6003DBC")]
		[Address(RVA = "0x840FD0", Offset = "0x83F5D0", VA = "0x180840FD0")]
		private void OnZombieDeath(object data)
		{
			int num;
			do
			{
				List<OnZombieDieNode> list = this.zombieDieNodes;
				if (data == 0)
				{
				}
				num = 0;
				if (data == 0)
				{
					break;
				}
				List<OnZombieDieNode> list2 = this.zombieDieNodes;
				int size = list2._size;
				EventNodeDebug.Log(string.Format("[EventNodeManager] 触发 {0} 个僵尸死亡事件节点，僵尸类型: {1}", list2, list2));
				List<OnZombieDieNode> list3 = this.zombieDieNodes;
				bool flag;
				if (flag)
				{
				}
			}
			while (num != 0);
			Type type;
			string name = type.Name;
			EventNodeDebug.LogWarning("[EventNodeManager] OnZombieDeath事件收到的数据不是Zombie对象，而是: " + name);
		}

		// Token: 0x06003DBD RID: 15805 RVA: 0x00142D30 File Offset: 0x00140F30
		[Token(Token = "0x6003DBD")]
		[Address(RVA = "0x8412D0", Offset = "0x83F8D0", VA = "0x1808412D0")]
		private void OnZombieSpawn(object data)
		{
			int num;
			do
			{
				List<OnZombieSpawnNode> list = this.zombieSpawnNodes;
				if (data == 0)
				{
				}
				num = 0;
				if (data == 0)
				{
					break;
				}
				List<OnZombieSpawnNode> list2 = this.zombieSpawnNodes;
				int size = list2._size;
				EventNodeDebug.Log(string.Format("[EventNodeManager] 触发 {0} 个僵尸生成事件节点，僵尸类型: {1}", list2, list2));
				List<OnZombieSpawnNode> list3 = this.zombieSpawnNodes;
				bool flag;
				if (flag)
				{
				}
			}
			while (num != 0);
			Type type;
			string name = type.Name;
			EventNodeDebug.LogWarning("[EventNodeManager] OnZombieSpawn事件收到的数据不是Zombie对象，而是: " + name);
		}

		// Token: 0x06003DBE RID: 15806 RVA: 0x00142DB0 File Offset: 0x00140FB0
		[Token(Token = "0x6003DBE")]
		[Address(RVA = "0x840840", Offset = "0x83EE40", VA = "0x180840840")]
		public void OnPlantDeathComplete(Plant plant, Plant.DieReason reason)
		{
			ulong num;
			do
			{
				List<OnPlantDeathCompleteNode> list = this.plantDeathCompleteNodes;
				int size = list._size;
				PlantType thePlantType = plant.thePlantType;
				EventNodeDebug.Log(string.Format("[EventNodeManager] 触发 {0} 个植物死亡完成事件节点，植物类型: {1}, 死亡原因: {2}", list, list, list));
				List<OnPlantDeathCompleteNode> list2 = this.plantDeathCompleteNodes;
				bool flag;
				if (flag)
				{
				}
			}
			while (num != (ulong)0L);
		}

		// Token: 0x06003DBF RID: 15807 RVA: 0x00142E08 File Offset: 0x00141008
		[Token(Token = "0x6003DBF")]
		[Address(RVA = "0x840AA0", Offset = "0x83F0A0", VA = "0x180840AA0")]
		private void OnPlantDeath(object data)
		{
			int num;
			do
			{
				List<OnPlantDieNode> list = this.plantDieNodes;
				if (data == 0)
				{
				}
				num = 0;
				if (data == 0)
				{
					break;
				}
				List<OnPlantDieNode> list2 = this.plantDieNodes;
				int size = list2._size;
				EventNodeDebug.Log(string.Format("[EventNodeManager] 触发 {0} 个植物死亡事件节点，植物类型: {1}", list2, list2));
				List<OnPlantDieNode> list3 = this.plantDieNodes;
				bool flag;
				if (flag)
				{
				}
			}
			while (num != 0);
			Type type;
			string name = type.Name;
			EventNodeDebug.LogWarning("[EventNodeManager] OnPlantDeath事件收到的数据不是Plant对象，而是: " + name);
		}

		// Token: 0x06003DC0 RID: 15808 RVA: 0x00142E88 File Offset: 0x00141088
		[Token(Token = "0x6003DC0")]
		[Address(RVA = "0x840220", Offset = "0x83E820", VA = "0x180840220")]
		private void OnPlantClick(object data)
		{
			int num;
			do
			{
				List<OnPlantClickNode> list = this.plantClickNodes;
				if (data == 0)
				{
				}
				num = 0;
				if (data == 0)
				{
					break;
				}
				List<OnPlantClickNode> list2 = this.plantClickNodes;
				int size = list2._size;
				EventNodeDebug.Log(string.Format("[EventNodeManager] 触发 {0} 个植物点击事件节点，植物类型: {1}", list2, list2));
				List<OnPlantClickNode> list3 = this.plantClickNodes;
				bool flag;
				if (flag)
				{
				}
			}
			while (num != 0);
			Type type;
			string name = type.Name;
			EventNodeDebug.LogWarning("[EventNodeManager] OnPlantClick事件收到的数据不是Plant对象，而是: " + name);
		}

		// Token: 0x06003DC1 RID: 15809 RVA: 0x00142F08 File Offset: 0x00141108
		[Token(Token = "0x6003DC1")]
		[Address(RVA = "0x842160", Offset = "0x840760", VA = "0x180842160")]
		public void StartWaitTask(string nodeId, string outputPortName, float duration, CancellationToken cancellationToken)
		{
		}

		// Token: 0x06003DC2 RID: 15810 RVA: 0x00142F1C File Offset: 0x0014111C
		[Token(Token = "0x6003DC2")]
		[Address(RVA = "0x842040", Offset = "0x840640", VA = "0x180842040")]
		public void StartCycleTask(string nodeId, string outputPortName, float interval, CancellationToken cancellationToken, List<EventNodeBase> targetNodes)
		{
		}

		// Token: 0x06003DC3 RID: 15811 RVA: 0x00142F30 File Offset: 0x00141130
		[Token(Token = "0x6003DC3")]
		[Address(RVA = "0x842570", Offset = "0x840B70", VA = "0x180842570")]
		private UniTaskVoid WaitAndTriggerAsync(string nodeId, string outputPortName, float duration, CancellationToken cancellationToken)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06003DC4 RID: 15812 RVA: 0x00142F50 File Offset: 0x00141150
		[Token(Token = "0x6003DC4")]
		[Address(RVA = "0x83F860", Offset = "0x83DE60", VA = "0x18083F860")]
		private UniTaskVoid CycleAndTriggerAsync(string nodeId, string outputPortName, float interval, CancellationToken cancellationToken, List<EventNodeBase> targetNodes)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06003DC5 RID: 15813 RVA: 0x00142F70 File Offset: 0x00141170
		[Token(Token = "0x6003DC5")]
		[Address(RVA = "0x842680", Offset = "0x840C80", VA = "0x180842680")]
		public EventNodeManager()
		{
			List<WaveEventNode> list = new List();
			this.waveEventNodes = list;
			List<OnBoardStartNode> list2 = new List();
			this.boardStartNodes = list2;
			List<OnPlantCreateNode> list3 = new List();
			this.plantCreateNodes = list3;
			List<OnMouseClickNode> list4 = new List();
			this.mouseClickNodes = list4;
			List<OnZombieDieNode> list5 = new List();
			this.zombieDieNodes = list5;
			List<OnZombieSpawnNode> list6 = new List();
			this.zombieSpawnNodes = list6;
			List<OnPlantDieNode> list7 = new List();
			this.plantDieNodes = list7;
			List<OnPlantDeathCompleteNode> list8 = new List();
			this.plantDeathCompleteNodes = list8;
			List<OnPlantClickNode> list9 = new List();
			this.plantClickNodes = list9;
			List<OnKeyPressNode> list10 = new List();
			this.keyPressNodes = list10;
			List<OnGameStartNode> list11 = new List();
			this.gameStartNodes = list11;
			base..ctor();
		}

		// Token: 0x04002E25 RID: 11813
		[Token(Token = "0x4002E25")]
		private static EventNodeManager _instance;

		// Token: 0x04002E26 RID: 11814
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002E26")]
		public EventNodeGraph currentGraph;

		// Token: 0x04002E27 RID: 11815
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002E27")]
		private readonly List<WaveEventNode> waveEventNodes;

		// Token: 0x04002E28 RID: 11816
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E28")]
		private readonly List<OnBoardStartNode> boardStartNodes;

		// Token: 0x04002E29 RID: 11817
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E29")]
		private readonly List<OnPlantCreateNode> plantCreateNodes;

		// Token: 0x04002E2A RID: 11818
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002E2A")]
		private readonly List<OnMouseClickNode> mouseClickNodes;

		// Token: 0x04002E2B RID: 11819
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002E2B")]
		private readonly List<OnZombieDieNode> zombieDieNodes;

		// Token: 0x04002E2C RID: 11820
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002E2C")]
		private readonly List<OnZombieSpawnNode> zombieSpawnNodes;

		// Token: 0x04002E2D RID: 11821
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002E2D")]
		private readonly List<OnPlantDieNode> plantDieNodes;

		// Token: 0x04002E2E RID: 11822
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002E2E")]
		private readonly List<OnPlantDeathCompleteNode> plantDeathCompleteNodes;

		// Token: 0x04002E2F RID: 11823
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002E2F")]
		private readonly List<OnPlantClickNode> plantClickNodes;

		// Token: 0x04002E30 RID: 11824
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002E30")]
		public readonly List<OnKeyPressNode> keyPressNodes;

		// Token: 0x04002E31 RID: 11825
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002E31")]
		public readonly List<OnGameStartNode> gameStartNodes;
	}
}
