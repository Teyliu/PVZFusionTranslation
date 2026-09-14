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
	// Token: 0x02000A9A RID: 2714
	[Token(Token = "0x2000A9A")]
	public class PVPScareyPot : MonoBehaviour
	{
		// Token: 0x060037B6 RID: 14262 RVA: 0x0012AD14 File Offset: 0x00128F14
		[Token(Token = "0x60037B6")]
		[Address(RVA = "0x7D4C10", Offset = "0x7D3210", VA = "0x1807D4C10")]
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

		// Token: 0x060037B7 RID: 14263 RVA: 0x0012AE48 File Offset: 0x00129048
		[Token(Token = "0x60037B7")]
		[Address(RVA = "0x7D5B40", Offset = "0x7D4140", VA = "0x1807D5B40")]
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

		// Token: 0x060037B8 RID: 14264 RVA: 0x0012AEBC File Offset: 0x001290BC
		[Token(Token = "0x60037B8")]
		[Address(RVA = "0x7D5FE0", Offset = "0x7D45E0", VA = "0x1807D5FE0")]
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

		// Token: 0x060037B9 RID: 14265 RVA: 0x0012AFB8 File Offset: 0x001291B8
		[Token(Token = "0x60037B9")]
		[Address(RVA = "0x7D5300", Offset = "0x7D3900", VA = "0x1807D5300")]
		public void HardMode(UIButton button)
		{
			int num2;
			do
			{
				int num = 0;
				InGameText instance = InGameText.Instance;
				num2 = 0;
				Board instance2 = Board.Instance;
				List<GridItem> list = Enumerable.ToList<GridItem>(instance2.griditemArray);
				bool flag;
				if (flag)
				{
					int num3 = 0;
					if (!(num != num3))
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

		// Token: 0x060037BA RID: 14266 RVA: 0x0012B038 File Offset: 0x00129238
		[Token(Token = "0x60037BA")]
		[Address(RVA = "0x7D55F0", Offset = "0x7D3BF0", VA = "0x1807D55F0")]
		public bool OnZombieNearLine(Zombie zombie)
		{
			ulong num2;
			do
			{
				int num = 0;
				if (!zombie.Alive || zombie.isMindControlled)
				{
					goto IL_004F;
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
			return true;
			IL_004F:
			throw new NullReferenceException();
		}

		// Token: 0x060037BB RID: 14267 RVA: 0x0012B0A0 File Offset: 0x001292A0
		[Token(Token = "0x60037BB")]
		[Address(RVA = "0x7D5100", Offset = "0x7D3700", VA = "0x1807D5100")]
		private void GenerateRedPot(int column, int row)
		{
			List<GridItem> griditemArray = Board.Instance.griditemArray;
			Func<GridItem, bool> func = delegate(GridItem a)
			{
				int num2 = 0;
				if (a != num2 && a != 0)
				{
					int column3 = column;
					if (a.theItemColumn == column3)
					{
						int row3 = row;
						return a.theItemRow == row3;
					}
				}
				return false;
			};
			if (!Enumerable.Any<GridItem>(griditemArray, func))
			{
				ZombieType random = ListExtensions.GetRandom<ZombieType>(Enumerable.ToList<ZombieType>(TypeMgr.LeaderZombies));
				int row2 = row;
				int column2 = column;
				int num = 0;
				GridItem gridItem = GridItem.SetGridItem(column2, row2, (GridItemType)((uint)12), (GraveType)num);
			}
		}

		// Token: 0x060037BC RID: 14268 RVA: 0x0012B128 File Offset: 0x00129328
		[Token(Token = "0x60037BC")]
		[Address(RVA = "0x7D58A0", Offset = "0x7D3EA0", VA = "0x1807D58A0")]
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

		// Token: 0x060037BD RID: 14269 RVA: 0x0012B1B0 File Offset: 0x001293B0
		[Token(Token = "0x60037BD")]
		[Address(RVA = "0x7D4B90", Offset = "0x7D3190", VA = "0x1807D4B90")]
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

		// Token: 0x060037BE RID: 14270 RVA: 0x0012B1EC File Offset: 0x001293EC
		[Token(Token = "0x60037BE")]
		[Address(RVA = "0x7D6330", Offset = "0x7D4930", VA = "0x1807D6330")]
		public PVPScareyPot()
		{
			List<ValueTuple<int, int>> list = new List();
			this.redPotPositions = list;
			base..ctor();
		}

		// Token: 0x04002B48 RID: 11080
		[Token(Token = "0x4002B48")]
		public static PVPScareyPot Instance;

		// Token: 0x04002B49 RID: 11081
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002B49")]
		public bool rightPutPot;

		// Token: 0x04002B4A RID: 11082
		[FieldOffset(Offset = "0x21")]
		[Token(Token = "0x4002B4A")]
		public bool randomCard;

		// Token: 0x04002B4B RID: 11083
		[FieldOffset(Offset = "0x22")]
		[Token(Token = "0x4002B4B")]
		public bool autoRule;

		// Token: 0x04002B4C RID: 11084
		[Token(Token = "0x4002B4C")]
		public static bool streamerMode;

		// Token: 0x04002B4D RID: 11085
		[Token(Token = "0x4002B4D")]
		public static bool waterPrint1;

		// Token: 0x04002B4E RID: 11086
		[Token(Token = "0x4002B4E")]
		public static bool waterPrint2;

		// Token: 0x04002B4F RID: 11087
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002B4F")]
		private PVPScareyPot.PlayerData currentPlayer;

		// Token: 0x04002B50 RID: 11088
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002B50")]
		public PVPScareyPot.PlayerData player1;

		// Token: 0x04002B51 RID: 11089
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002B51")]
		public PVPScareyPot.PlayerData player2;

		// Token: 0x04002B52 RID: 11090
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002B52")]
		[TupleElementNames(new string[] { "column", "row" })]
		private readonly List<ValueTuple<int, int>> redPotPositions;

		// Token: 0x02000A9B RID: 2715
		[Token(Token = "0x2000A9B")]
		public class PlayerData
		{
			// Token: 0x1700028F RID: 655
			// (get) Token: 0x060037C1 RID: 14273 RVA: 0x0012B284 File Offset: 0x00129484
			// (set) Token: 0x060037C2 RID: 14274 RVA: 0x0012B2A0 File Offset: 0x001294A0
			[Token(Token = "0x1700028F")]
			public string Name
			{
				[Token(Token = "0x60037C1")]
				[Address(RVA = "0x7D7750", Offset = "0x7D5D50", VA = "0x1807D7750")]
				get
				{
					TextMeshPro textMeshPro = this.textMesh;
					throw new NullReferenceException();
				}
				[Token(Token = "0x60037C2")]
				[Address(RVA = "0x7D7780", Offset = "0x7D5D80", VA = "0x1807D7780")]
				set
				{
					TextMeshPro textMeshPro = this.textMesh;
					throw new NullReferenceException();
				}
			}

			// Token: 0x060037C3 RID: 14275 RVA: 0x0012B2BC File Offset: 0x001294BC
			[Token(Token = "0x60037C3")]
			[Address(RVA = "0x7D7660", Offset = "0x7D5C60", VA = "0x1807D7660")]
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

			// Token: 0x060037C4 RID: 14276 RVA: 0x0012B2FC File Offset: 0x001294FC
			[Token(Token = "0x60037C4")]
			[Address(RVA = "0x7D74F0", Offset = "0x7D5AF0", VA = "0x1807D74F0")]
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
				InGameUI.Instance.SetLevelName(text2);
			}

			// Token: 0x060037C5 RID: 14277 RVA: 0x0012B364 File Offset: 0x00129564
			[Token(Token = "0x60037C5")]
			[Address(RVA = "0x7D7490", Offset = "0x7D5A90", VA = "0x1807D7490")]
			public void OnRoundEnd()
			{
				TextMeshPro textMeshPro = this.textMesh;
				this.nextPlayer.OnRoundStart();
			}

			// Token: 0x060037C6 RID: 14278 RVA: 0x0012B38C File Offset: 0x0012958C
			[Token(Token = "0x60037C6")]
			[Address(RVA = "0x7D71A0", Offset = "0x7D57A0", VA = "0x1807D71A0")]
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
						InGameUI.Instance.SetLevelName(text3);
						return;
					}
					int num2 = 0;
					plant.Die((Plant.DieReason)num2);
					InGameText instance2 = InGameText.Instance;
				}
				int num3 = 0;
				plant.Die((Plant.DieReason)num3);
				InGameText instance3 = InGameText.Instance;
				string text4 = this.textMesh.text + "，你已经没有行动次数了";
				GameAPP.PlaySound((SoundType)((uint)26), 0.5f, 1f);
			}

			// Token: 0x04002B53 RID: 11091
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4002B53")]
			public List<int> rows;

			// Token: 0x04002B54 RID: 11092
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4002B54")]
			public PVPScareyPot.PlayerData nextPlayer;

			// Token: 0x04002B55 RID: 11093
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4002B55")]
			public int actionCount;

			// Token: 0x04002B56 RID: 11094
			[FieldOffset(Offset = "0x24")]
			[Token(Token = "0x4002B56")]
			public bool zombiePassed;

			// Token: 0x04002B57 RID: 11095
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x4002B57")]
			public TextMeshPro textMesh;
		}
	}
}
