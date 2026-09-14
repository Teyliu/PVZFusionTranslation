using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using UnityEngine.Events;

namespace GameLevel
{
	// Token: 0x02000B2E RID: 2862
	[Token(Token = "0x2000B2E")]
	public class TimeTrackLevel : ChallengeLevelData
	{
		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06003B75 RID: 15221 RVA: 0x001382AC File Offset: 0x001364AC
		[Token(Token = "0x17000451")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x6003B75")]
			[Address(RVA = "0x544FE0", Offset = "0x5435E0", VA = "0x180544FE0", Slot = "42")]
			get
			{
				return ChallengeLevel.TimeTrack;
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06003B76 RID: 15222 RVA: 0x001382C0 File Offset: 0x001364C0
		[Token(Token = "0x17000452")]
		public override string Name
		{
			[Token(Token = "0x6003B76")]
			[Address(RVA = "0x7FAC20", Offset = "0x7F9220", VA = "0x1807FAC20", Slot = "8")]
			get
			{
				return "时间陷阱";
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06003B77 RID: 15223 RVA: 0x001382D4 File Offset: 0x001364D4
		[Token(Token = "0x17000453")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003B77")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
			get
			{
				return SceneType.Pool;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06003B78 RID: 15224 RVA: 0x001382E4 File Offset: 0x001364E4
		[Token(Token = "0x17000454")]
		public override int MaxWave
		{
			[Token(Token = "0x6003B78")]
			[Address(RVA = "0x717080", Offset = "0x715680", VA = "0x180717080", Slot = "10")]
			get
			{
				return 40;
			}
		}

		// Token: 0x06003B79 RID: 15225 RVA: 0x001382F4 File Offset: 0x001364F4
		[Token(Token = "0x6003B79")]
		[Address(RVA = "0x7FA6F0", Offset = "0x7F8CF0", VA = "0x1807FA6F0", Slot = "40")]
		public override void OnAnimUIOver(Board board)
		{
			base.OnAnimUIOver(board);
			InGameText instance = InGameText.Instance;
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			this.plants.Clear();
			UnityEvent dieEvent = board.DieEvent;
			UnityAction unityAction = delegate
			{
				this.plants.Clear();
			};
			dieEvent.AddListener(unityAction);
			int num = 0;
			Action<object> action;
			EventManager.AddListener_obj((GameEvent)((uint)2), action, num != 0);
			int num2 = 0;
			Action<object> action2;
			EventManager.AddListener_obj((GameEvent)((uint)8), action2, num2 != 0);
		}

		// Token: 0x06003B7A RID: 15226 RVA: 0x00138374 File Offset: 0x00136574
		[Token(Token = "0x6003B7A")]
		[Address(RVA = "0x7FAAD0", Offset = "0x7F90D0", VA = "0x1807FAAD0")]
		private void Update(Board board)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06003B7B RID: 15227 RVA: 0x00138398 File Offset: 0x00136598
		[Token(Token = "0x17000455")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003B7B")]
			[Address(RVA = "0x7FAC50", Offset = "0x7F9250", VA = "0x1807FAC50", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				int size4 = list._size;
				int size5 = list._size;
				int size6 = list._size;
				int size7 = list._size;
				int size8 = list._size;
				int size9 = list._size;
				int size10 = list._size;
				int size11 = list._size;
				int size12 = list._size;
				return list;
			}
		}

		// Token: 0x06003B7C RID: 15228 RVA: 0x00138428 File Offset: 0x00136628
		[Token(Token = "0x6003B7C")]
		[Address(RVA = "0x7FABA0", Offset = "0x7F91A0", VA = "0x1807FABA0")]
		public TimeTrackLevel()
		{
			HashSet<PlantType> hashSet = new HashSet();
			this.plants = hashSet;
			base..ctor();
		}

		// Token: 0x04002CC6 RID: 11462
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002CC6")]
		private float restTimer;

		// Token: 0x04002CC7 RID: 11463
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002CC7")]
		private readonly HashSet<PlantType> plants;
	}
}
