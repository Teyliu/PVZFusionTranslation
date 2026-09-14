using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B54 RID: 2900
	[Token(Token = "0x2000B54")]
	public class EventNodeManager : MonoBehaviour
	{
		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06003C64 RID: 15460 RVA: 0x0013D4B0 File Offset: 0x0013B6B0
		[Token(Token = "0x170004A4")]
		public static EventNodeManager Instance
		{
			[Token(Token = "0x6003C64")]
			[Address(RVA = "0x7C6660", Offset = "0x7C4C60", VA = "0x1807C6660")]
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

		// Token: 0x06003C65 RID: 15461 RVA: 0x0013D4F8 File Offset: 0x0013B6F8
		[Token(Token = "0x6003C65")]
		[Address(RVA = "0x7C5270", Offset = "0x7C3870", VA = "0x1807C5270")]
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

		// Token: 0x06003C66 RID: 15462 RVA: 0x0013D608 File Offset: 0x0013B808
		[Token(Token = "0x6003C66")]
		[Address(RVA = "0x7C3610", Offset = "0x7C1C10", VA = "0x1807C3610")]
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

		// Token: 0x06003C67 RID: 15463 RVA: 0x0013D6B0 File Offset: 0x0013B8B0
		[Token(Token = "0x6003C67")]
		[Address(RVA = "0x7C5F20", Offset = "0x7C4520", VA = "0x1807C5F20")]
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

		// Token: 0x06003C68 RID: 15464 RVA: 0x0013D84C File Offset: 0x0013BA4C
		[Token(Token = "0x6003C68")]
		[Address(RVA = "0x7C4A50", Offset = "0x7C3050", VA = "0x1807C4A50")]
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

		// Token: 0x06003C69 RID: 15465 RVA: 0x0013D8A8 File Offset: 0x0013BAA8
		[Token(Token = "0x6003C69")]
		[Address(RVA = "0x7C41D0", Offset = "0x7C27D0", VA = "0x1807C41D0")]
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

		// Token: 0x06003C6A RID: 15466 RVA: 0x0013D928 File Offset: 0x0013BB28
		[Token(Token = "0x6003C6A")]
		[Address(RVA = "0x7C3980", Offset = "0x7C1F80", VA = "0x1807C3980")]
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

		// Token: 0x06003C6B RID: 15467 RVA: 0x0013DA00 File Offset: 0x0013BC00
		[Token(Token = "0x6003C6B")]
		[Address(RVA = "0x7C4C70", Offset = "0x7C3270", VA = "0x1807C4C70")]
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

		// Token: 0x06003C6C RID: 15468 RVA: 0x0013DA80 File Offset: 0x0013BC80
		[Token(Token = "0x6003C6C")]
		[Address(RVA = "0x7C4F70", Offset = "0x7C3570", VA = "0x1807C4F70")]
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

		// Token: 0x06003C6D RID: 15469 RVA: 0x0013DB00 File Offset: 0x0013BD00
		[Token(Token = "0x6003C6D")]
		[Address(RVA = "0x7C44E0", Offset = "0x7C2AE0", VA = "0x1807C44E0")]
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

		// Token: 0x06003C6E RID: 15470 RVA: 0x0013DB58 File Offset: 0x0013BD58
		[Token(Token = "0x6003C6E")]
		[Address(RVA = "0x7C4740", Offset = "0x7C2D40", VA = "0x1807C4740")]
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

		// Token: 0x06003C6F RID: 15471 RVA: 0x0013DBD8 File Offset: 0x0013BDD8
		[Token(Token = "0x6003C6F")]
		[Address(RVA = "0x7C3EC0", Offset = "0x7C24C0", VA = "0x1807C3EC0")]
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

		// Token: 0x06003C70 RID: 15472 RVA: 0x0013DC58 File Offset: 0x0013BE58
		[Token(Token = "0x6003C70")]
		[Address(RVA = "0x7C5E00", Offset = "0x7C4400", VA = "0x1807C5E00")]
		public void StartWaitTask(string nodeId, string outputPortName, float duration, CancellationToken cancellationToken)
		{
		}

		// Token: 0x06003C71 RID: 15473 RVA: 0x0013DC6C File Offset: 0x0013BE6C
		[Token(Token = "0x6003C71")]
		[Address(RVA = "0x7C5CE0", Offset = "0x7C42E0", VA = "0x1807C5CE0")]
		public void StartCycleTask(string nodeId, string outputPortName, float interval, CancellationToken cancellationToken, List<EventNodeBase> targetNodes)
		{
		}

		// Token: 0x06003C72 RID: 15474 RVA: 0x0013DC80 File Offset: 0x0013BE80
		[Token(Token = "0x6003C72")]
		[Address(RVA = "0x7C6210", Offset = "0x7C4810", VA = "0x1807C6210")]
		private UniTaskVoid WaitAndTriggerAsync(string nodeId, string outputPortName, float duration, CancellationToken cancellationToken)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06003C73 RID: 15475 RVA: 0x0013DCA0 File Offset: 0x0013BEA0
		[Token(Token = "0x6003C73")]
		[Address(RVA = "0x7C3500", Offset = "0x7C1B00", VA = "0x1807C3500")]
		private UniTaskVoid CycleAndTriggerAsync(string nodeId, string outputPortName, float interval, CancellationToken cancellationToken, List<EventNodeBase> targetNodes)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06003C74 RID: 15476 RVA: 0x0013DCC0 File Offset: 0x0013BEC0
		[Token(Token = "0x6003C74")]
		[Address(RVA = "0x7C6320", Offset = "0x7C4920", VA = "0x1807C6320")]
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

		// Token: 0x04002CB1 RID: 11441
		[Token(Token = "0x4002CB1")]
		private static EventNodeManager _instance;

		// Token: 0x04002CB2 RID: 11442
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002CB2")]
		public EventNodeGraph currentGraph;

		// Token: 0x04002CB3 RID: 11443
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002CB3")]
		private readonly List<WaveEventNode> waveEventNodes;

		// Token: 0x04002CB4 RID: 11444
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002CB4")]
		private readonly List<OnBoardStartNode> boardStartNodes;

		// Token: 0x04002CB5 RID: 11445
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002CB5")]
		private readonly List<OnPlantCreateNode> plantCreateNodes;

		// Token: 0x04002CB6 RID: 11446
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002CB6")]
		private readonly List<OnMouseClickNode> mouseClickNodes;

		// Token: 0x04002CB7 RID: 11447
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002CB7")]
		private readonly List<OnZombieDieNode> zombieDieNodes;

		// Token: 0x04002CB8 RID: 11448
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002CB8")]
		private readonly List<OnZombieSpawnNode> zombieSpawnNodes;

		// Token: 0x04002CB9 RID: 11449
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002CB9")]
		private readonly List<OnPlantDieNode> plantDieNodes;

		// Token: 0x04002CBA RID: 11450
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002CBA")]
		private readonly List<OnPlantDeathCompleteNode> plantDeathCompleteNodes;

		// Token: 0x04002CBB RID: 11451
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002CBB")]
		private readonly List<OnPlantClickNode> plantClickNodes;

		// Token: 0x04002CBC RID: 11452
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002CBC")]
		public readonly List<OnKeyPressNode> keyPressNodes;

		// Token: 0x04002CBD RID: 11453
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002CBD")]
		public readonly List<OnGameStartNode> gameStartNodes;
	}
}
