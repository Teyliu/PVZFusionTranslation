using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

namespace PVPScaryPot
{
	// Token: 0x02000A5A RID: 2650
	[Token(Token = "0x2000A5A")]
	public class PVPScareyPot : MonoBehaviour
	{
		// Token: 0x06003672 RID: 13938 RVA: 0x00125A94 File Offset: 0x00123C94
		[Token(Token = "0x6003672")]
		[Address(RVA = "0x76DDD0", Offset = "0x76C3D0", VA = "0x18076DDD0")]
		private void Awake()
		{
			PVPScareyPot.Instance = this;
			List<int> list = new List();
			int size = list._size;
			list._size = 1;
			list._syncRoot = (ulong)0L;
			int size2 = list._size;
			list._size = 1;
			int size3 = list._size;
			list._size = 1;
			Transform transform = Board.Instance.background.transform;
			int num = 0;
			TextMeshPro componentInChildren = transform.GetChild(num).Find("Player1").GetComponentInChildren<TextMeshPro>();
			PVPScareyPot.PlayerData playerData = new PVPScareyPot.PlayerData(list, "玩家A", componentInChildren);
			this.player1 = playerData;
			List<int> list2 = new List();
			int size4 = list2._size;
			int size5 = list2._size;
			int size6 = list2._size;
			Transform transform2 = Board.Instance.background.transform;
			int num2 = 0;
			TextMeshPro componentInChildren2 = transform2.GetChild(num2).Find("Player2").GetComponentInChildren<TextMeshPro>();
			PVPScareyPot.PlayerData playerData2 = new PVPScareyPot.PlayerData(list2, "玩家B", componentInChildren2);
			this.player2 = playerData2;
			PVPScareyPot.PlayerData playerData3 = this.player1;
			PVPScareyPot.PlayerData playerData4 = this.player2;
			playerData3.nextPlayer = playerData4;
			PVPScareyPot.PlayerData playerData5 = this.player2;
			PVPScareyPot.PlayerData playerData6 = this.player1;
			playerData5.nextPlayer = playerData6;
			throw new NullReferenceException();
		}

		// Token: 0x06003673 RID: 13939 RVA: 0x00125BC8 File Offset: 0x00123DC8
		[Token(Token = "0x6003673")]
		[Address(RVA = "0x76ECD0", Offset = "0x76D2D0", VA = "0x18076ECD0")]
		private void Start()
		{
			InGameUI instance = InGameUI.Instance;
			Action<UIButton> <>9__12_ = PVPScareyPot.<>c.<>9__12_1;
			if (<>9__12_ == 0)
			{
				Action<UIButton> action;
				PVPScareyPot.<>c.<>9__12_1 = action;
			}
			UIButton uibutton = instance.CreateLeftButton("关闭下方水印", <>9__12_);
			InGameUI instance2 = InGameUI.Instance;
			Action<UIButton> action2;
			if (PVPScareyPot.<>c.<>9__12_2 == 0)
			{
				PVPScareyPot.<>c.<>9__12_2 = action2;
			}
			UIButton uibutton2 = instance2.CreateLeftButton("关闭上方水印", action2);
			Action<UIButton> action3;
			UIButton uibutton3 = InGameUI.Instance.CreateLeftButton("开启官方裁判", action3);
		}

		// Token: 0x06003674 RID: 13940 RVA: 0x00125C3C File Offset: 0x00123E3C
		[Token(Token = "0x6003674")]
		[Address(RVA = "0x76F170", Offset = "0x76D770", VA = "0x18076F170")]
		private void Update()
		{
			if (typeof(PVPScareyPot.<>c).TypeHandle != 0)
			{
				Time.timeScale = Time.timeScale;
			}
			if (typeof(PVPScareyPot.<>c).TypeHandle != 0)
			{
				Time.timeScale = Time.timeScale;
			}
			bool flag;
			if (typeof(PVPScareyPot.<>c).TypeHandle != 0)
			{
				flag = !this.randomCard;
				this.randomCard = flag;
			}
			bool flag2;
			if (flag)
			{
				flag2 = !this.rightPutPot;
				this.rightPutPot = flag2;
			}
			if (flag2)
			{
				List<Plant> allPlants = global::Lawnf.GetAllPlants();
				Action<Plant> action;
				if (PVPScareyPot.<>c.<>9__13_0 == 0)
				{
					PVPScareyPot.<>c.<>9__13_0 = action;
				}
				allPlants.ForEach(action);
			}
			if (typeof(PVPScareyPot.<>c).TypeHandle != 0)
			{
				List<Zombie> allZombies = global::Lawnf.GetAllZombies(false);
				Action<Zombie> action2;
				if (PVPScareyPot.<>c.<>9__13_1 == 0)
				{
					PVPScareyPot.<>c.<>9__13_1 = action2;
				}
				allZombies.ForEach(action2);
			}
			if (this.randomCard)
			{
				this.RandomCardUpdate();
			}
			if (this.autoRule && typeof(PVPScareyPot.<>c).TypeHandle != 0)
			{
				PVPScareyPot.PlayerData playerData = this.currentPlayer;
				TextMeshPro textMesh = playerData.textMesh;
				playerData.nextPlayer.OnRoundStart();
			}
		}

		// Token: 0x06003675 RID: 13941 RVA: 0x00125D38 File Offset: 0x00123F38
		[Token(Token = "0x6003675")]
		[Address(RVA = "0x76E4C0", Offset = "0x76CAC0", VA = "0x18076E4C0")]
		public void HardMode(UIButton button)
		{
			int num2;
			do
			{
				int num = 0;
				InGameText instance = InGameText.Instance;
				num2 = 0;
				int num3 = 0;
				instance.ShowText("危机模式已开启，红色罐子开出的僵尸品质概率大幅提高", 10f, num3 != 0);
				Board instance2 = Board.Instance;
				List<GridItem> list = Enumerable.ToList<GridItem>(instance2.griditemArray);
				bool flag;
				if (flag)
				{
					int num4 = 0;
					if (!(num != num4))
					{
						continue;
					}
					int columnNum = instance2.columnNum;
					if (columnNum != 1)
					{
						while (columnNum != 4)
						{
						}
					}
					List<ValueTuple<int, int>> list2 = this.redPotPositions;
				}
			}
			while (num2 != 0);
			GameObject gameObject;
			global::UnityEngine.Object.Destroy(gameObject);
		}

		// Token: 0x06003676 RID: 13942 RVA: 0x00125DCC File Offset: 0x00123FCC
		[Token(Token = "0x6003676")]
		[Address(RVA = "0x76E7A0", Offset = "0x76CDA0", VA = "0x18076E7A0")]
		public bool OnZombieNearLine(Zombie zombie)
		{
			ulong num2;
			do
			{
				int num = 0;
				if (!zombie.Alive || zombie.isMindControlled)
				{
					goto IL_0062;
				}
				zombie.SetGold();
				int theZombieType = (int)zombie.theZombieType;
				bool flag;
				if (!flag)
				{
					break;
				}
				List<ValueTuple<int, int>> list = this.redPotPositions;
				bool flag2;
				if (flag2)
				{
					this.GenerateRedPot(num, num);
				}
			}
			while (num2 != (ulong)0L);
			InGameText instance = InGameText.Instance;
			int num3 = 0;
			string text;
			instance.ShowText(text, 3f, num3 != 0);
			return true;
			IL_0062:
			throw new NullReferenceException();
		}

		// Token: 0x06003677 RID: 13943 RVA: 0x00125E48 File Offset: 0x00124048
		[Token(Token = "0x6003677")]
		[Address(RVA = "0x76E2C0", Offset = "0x76C8C0", VA = "0x18076E2C0")]
		private void GenerateRedPot(int column, int row)
		{
			Func<GridItem, bool> func;
			if (!Enumerable.Any<GridItem>(Board.Instance.griditemArray, func))
			{
				ZombieType random = ListExtensions.GetRandom<ZombieType>(Enumerable.ToList<ZombieType>(TypeMgr.LeaderZombies));
				int row2 = row;
				int column2 = column;
				int num = 0;
				GridItem gridItem = GridItem.SetGridItem(column2, row2, (GridItemType)((uint)12), (GraveType)num);
			}
		}

		// Token: 0x06003678 RID: 13944 RVA: 0x00125EC0 File Offset: 0x001240C0
		[Token(Token = "0x6003678")]
		[Address(RVA = "0x76EA30", Offset = "0x76D030", VA = "0x18076EA30")]
		private void RandomCardUpdate()
		{
			int num;
			do
			{
				num = 0;
				List<PlantType> randomPlant = global::Lawnf.GetRandomPlant();
				if (InGameUI.Instance._cardSlotManager.Cards != 0)
				{
					if (num < typeof(IEnumerator).TypeHandle)
					{
						num += num;
						if (num == typeof(IEnumerator).TypeHandle)
						{
							goto IL_0047;
						}
						num++;
					}
					bool flag;
					while (!flag)
					{
					}
					PlantType plantType = randomPlant[flag ? 1 : 0];
					int num2 = 0;
					IL_0047:
					num2 += 312;
				}
				if ("{il2cpp array field local9->}" != (ulong)0L)
				{
				}
			}
			while (num != 0);
		}

		// Token: 0x06003679 RID: 13945 RVA: 0x00125F48 File Offset: 0x00124148
		[Token(Token = "0x6003679")]
		[Address(RVA = "0x76DD50", Offset = "0x76C350", VA = "0x18076DD50")]
		private void AutoRuleUpdate()
		{
			if (Input.GetKeyDownInt((KeyCode)((uint)13)))
			{
				PVPScareyPot.PlayerData playerData = this.currentPlayer;
				TextMeshPro textMesh = playerData.textMesh;
				playerData.nextPlayer.OnRoundStart();
				return;
			}
		}

		// Token: 0x0600367A RID: 13946 RVA: 0x00125F84 File Offset: 0x00124184
		[Token(Token = "0x600367A")]
		[Address(RVA = "0x76F4C0", Offset = "0x76DAC0", VA = "0x18076F4C0")]
		public PVPScareyPot()
		{
			List<ValueTuple<int, int>> list = new List();
			this.redPotPositions = list;
			base..ctor();
		}

		// Token: 0x040029D5 RID: 10709
		[Token(Token = "0x40029D5")]
		public static PVPScareyPot Instance;

		// Token: 0x040029D6 RID: 10710
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40029D6")]
		public bool rightPutPot;

		// Token: 0x040029D7 RID: 10711
		[FieldOffset(Offset = "0x21")]
		[Token(Token = "0x40029D7")]
		public bool randomCard;

		// Token: 0x040029D8 RID: 10712
		[FieldOffset(Offset = "0x22")]
		[Token(Token = "0x40029D8")]
		public bool autoRule;

		// Token: 0x040029D9 RID: 10713
		[Token(Token = "0x40029D9")]
		public static bool streamerMode;

		// Token: 0x040029DA RID: 10714
		[Token(Token = "0x40029DA")]
		public static bool waterPrint1;

		// Token: 0x040029DB RID: 10715
		[Token(Token = "0x40029DB")]
		public static bool waterPrint2;

		// Token: 0x040029DC RID: 10716
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40029DC")]
		private PVPScareyPot.PlayerData currentPlayer;

		// Token: 0x040029DD RID: 10717
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40029DD")]
		public PVPScareyPot.PlayerData player1;

		// Token: 0x040029DE RID: 10718
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40029DE")]
		public PVPScareyPot.PlayerData player2;

		// Token: 0x040029DF RID: 10719
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40029DF")]
		[TupleElementNames(new string[] { "column", "row" })]
		private readonly List<ValueTuple<int, int>> redPotPositions;

		// Token: 0x02000A5B RID: 2651
		[Token(Token = "0x2000A5B")]
		public class PlayerData
		{
			// Token: 0x17000247 RID: 583
			// (get) Token: 0x0600367D RID: 13949 RVA: 0x0012601C File Offset: 0x0012421C
			// (set) Token: 0x0600367E RID: 13950 RVA: 0x00126038 File Offset: 0x00124238
			[Token(Token = "0x17000247")]
			public string Name
			{
				[Token(Token = "0x600367D")]
				[Address(RVA = "0x7708C0", Offset = "0x76EEC0", VA = "0x1807708C0")]
				get
				{
					TextMeshPro textMeshPro = this.textMesh;
					throw new NullReferenceException();
				}
				[Token(Token = "0x600367E")]
				[Address(RVA = "0x7708F0", Offset = "0x76EEF0", VA = "0x1807708F0")]
				set
				{
					TextMeshPro textMeshPro = this.textMesh;
					throw new NullReferenceException();
				}
			}

			// Token: 0x0600367F RID: 13951 RVA: 0x00126054 File Offset: 0x00124254
			[Token(Token = "0x600367F")]
			[Address(RVA = "0x7707D0", Offset = "0x76EDD0", VA = "0x1807707D0")]
			public PlayerData(List<int> rows, string name, TextMeshPro textMesh)
			{
				List<int> list = new List();
				this.rows = list;
				int num = 0;
				base.FieldGetter(num, name, textMesh);
				this.rows = rows;
				this.textMesh = textMesh;
				TextMeshPro textMeshPro = this.textMesh;
				throw new NullReferenceException();
			}

			// Token: 0x06003680 RID: 13952 RVA: 0x00126094 File Offset: 0x00124294
			[Token(Token = "0x6003680")]
			[Address(RVA = "0x770660", Offset = "0x76EC60", VA = "0x180770660")]
			public void OnRoundStart()
			{
				TextMeshPro textMeshPro = this.textMesh;
				PVPScareyPot.Instance.currentPlayer = this;
				TextMeshPro textMeshPro2 = this.textMesh;
				this.zombiePassed = false;
				string text = textMeshPro2.text;
				int num = this.actionCount;
				string text2 = string.Format("{0}的回合开始了，你有{1}次行动机会\n可在指定位置放置礼盒", text, text);
				InGameText instance = InGameText.Instance;
				int num2 = 0;
				instance.ShowText(text2, 5f, num2 != 0);
				InGameUI.Instance.SetLevelName(text2);
			}

			// Token: 0x06003681 RID: 13953 RVA: 0x00126110 File Offset: 0x00124310
			[Token(Token = "0x6003681")]
			[Address(RVA = "0x770600", Offset = "0x76EC00", VA = "0x180770600")]
			public void OnRoundEnd()
			{
				TextMeshPro textMeshPro = this.textMesh;
				this.nextPlayer.OnRoundStart();
			}

			// Token: 0x06003682 RID: 13954 RVA: 0x00126138 File Offset: 0x00124338
			[Token(Token = "0x6003682")]
			[Address(RVA = "0x770330", Offset = "0x76E930", VA = "0x180770330")]
			public void Action(Plant plant)
			{
				if (this.actionCount != 0)
				{
					List<int> list = this.rows;
					int thePlantRow = plant.thePlantRow;
					if (list.Contains(thePlantRow))
					{
						string text = this.textMesh.text;
						int num = this.actionCount;
						string text2 = string.Format("{0}还有{1}次行动机会\n可在指定位置放置礼盒", text, text);
						InGameUI.Instance.SetLevelName(text2);
						string text3 = this.textMesh.text + "没有行动次数了，请选择继续砸罐子或者按下回车键结束回合";
						InGameText instance = InGameText.Instance;
						int num2 = 0;
						instance.ShowText(text3, 5f, num2 != 0);
						InGameUI.Instance.SetLevelName(text3);
						return;
					}
					int num3 = 0;
					plant.Die((Plant.DieReason)num3);
					InGameText instance2 = InGameText.Instance;
				}
				int num4 = 0;
				plant.Die((Plant.DieReason)num4);
				InGameText instance3 = InGameText.Instance;
				string text4 = this.textMesh.text + "，你已经没有行动次数了";
				int num5 = 0;
				instance3.ShowText(text4, 5f, num5 != 0);
				GameAPP.PlaySound((SoundType)((uint)26), 0.5f, 1f);
			}

			// Token: 0x040029E0 RID: 10720
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40029E0")]
			public List<int> rows;

			// Token: 0x040029E1 RID: 10721
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40029E1")]
			public PVPScareyPot.PlayerData nextPlayer;

			// Token: 0x040029E2 RID: 10722
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x40029E2")]
			public int actionCount;

			// Token: 0x040029E3 RID: 10723
			[FieldOffset(Offset = "0x24")]
			[Token(Token = "0x40029E3")]
			public bool zombiePassed;

			// Token: 0x040029E4 RID: 10724
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x40029E4")]
			public TextMeshPro textMesh;
		}
	}
}
