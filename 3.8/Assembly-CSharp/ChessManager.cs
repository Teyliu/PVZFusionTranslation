using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020000A3 RID: 163
[Token(Token = "0x20000A3")]
public class ChessManager : MonoBehaviour
{
	// Token: 0x1700003D RID: 61
	// (get) Token: 0x060002BE RID: 702 RVA: 0x0000BB48 File Offset: 0x00009D48
	// (set) Token: 0x060002BF RID: 703 RVA: 0x0000BC30 File Offset: 0x00009E30
	[Token(Token = "0x1700003D")]
	private List<ChessManager.ZombieWithRow> NewWaveZombies
	{
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x3BE550", Offset = "0x3BCB50", VA = "0x1803BE550")]
		get
		{
			if (this._newWaveZombies == (ulong)0L)
			{
				int theWave = this.board.theWave;
				List<ZombieType> list = new List();
				int num = 0;
				List<List<ZombieSpawnData>> zombieList = InitZombieList.zombieList;
				List<ZombieSpawnData> list2 = zombieList[theWave];
				ZombieSpawnData zombieSpawnData = zombieList[theWave][num];
				ZombieType zombieType = zombieSpawnData.zombieType;
				int size = list._size;
				num++;
				list._size = zombieSpawnData;
				num++;
				List<ChessManager.ZombieWithRow> list3 = new List();
				int size2 = list._size;
				int num2 = size2 - 1;
				if (size2 > 0)
				{
					int num3 = 0;
					ZombieType zombieType2 = list[num3];
					int rowNum = this.board.rowNum;
					int num4 = global::UnityEngine.Random.Range(0, rowNum);
					int size3 = list3._size;
					list3._size = num4;
					int num5 = 0;
					list.RemoveAt(num5);
				}
				this._newWaveZombies = list3;
			}
			return this._newWaveZombies;
		}
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x3BE880", Offset = "0x3BCE80", VA = "0x1803BE880")]
		set
		{
			this._newWaveZombies = value;
		}
	}

	// Token: 0x060002C0 RID: 704 RVA: 0x0000BC44 File Offset: 0x00009E44
	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x3BBCE0", Offset = "0x3BA2E0", VA = "0x1803BBCE0")]
	private void Awake()
	{
		ChessManager.Instance = this;
	}

	// Token: 0x060002C1 RID: 705 RVA: 0x0000BC58 File Offset: 0x00009E58
	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x3BE1A0", Offset = "0x3BC7A0", VA = "0x1803BE1A0")]
	private void Start()
	{
		this.ResetBoard();
		Board board = this.board;
		this.InitTextMesh();
		this.restMoveTimes = (int)((ulong)1L);
		InGameText instance = InGameText.Instance;
		int num = 0;
		instance.ShowText("游戏规则：旗子移动规则满足中国象棋的旗子移动规则\n玩家每回合只可移动1株植物，随后僵尸将展开进攻\n击败这一波僵尸后可以继续移动1株植物", 7.5f, num != 0);
		Transform transform = this.board.background.transform;
		int num2 = 0;
		GameObject gameObject = transform.GetChild(num2).Find("Fog").gameObject;
		this.fog = gameObject;
		throw new NullReferenceException();
	}

	// Token: 0x060002C2 RID: 706 RVA: 0x0000BCD8 File Offset: 0x00009ED8
	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x3BE410", Offset = "0x3BCA10", VA = "0x1803BE410")]
	private void Update()
	{
		Board board = this.board;
		if (!this.playerRound)
		{
			this.MoveNext();
			return;
		}
	}

	// Token: 0x060002C3 RID: 707 RVA: 0x0000BD04 File Offset: 0x00009F04
	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x3BC090", Offset = "0x3BA690", VA = "0x1803BC090")]
	private void InitTextMesh()
	{
		GameObject gameObject = new GameObject();
		Transform transform = gameObject.transform;
		Transform transform2 = this.board.transform;
		transform.parentInternal = transform2;
		Transform transform3 = gameObject.transform;
		TextMeshPro textMeshPro = gameObject.AddComponent<TextMeshPro>();
		this.textMesh = textMeshPro;
		TextMeshPro textMeshPro2 = this.textMesh;
		TMP_FontAsset tmp_FontAsset = Resources.Load<TMP_FontAsset>("fonts/Dynamic");
		textMeshPro2.font = tmp_FontAsset;
		this.textMesh.fontSize = 5f;
		this.textMesh.enableAutoSizing = true;
		this.textMesh.fontSizeMin = 5f;
		this.textMesh.fontSizeMax = 10f;
		TextMeshPro textMeshPro3 = this.textMesh;
		TextMeshPro textMeshPro4 = this.textMesh;
		int num = SortingLayer.NameToID("fog");
		textMeshPro4.sortingLayerID = num;
		this.textMesh.sortingOrder = 30000;
		Transform transform4 = this.textMesh.transform;
		this.UpdateText();
		this.ShowZombiePreviews();
	}

	// Token: 0x060002C4 RID: 708 RVA: 0x0000BDFC File Offset: 0x00009FFC
	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x3BDA80", Offset = "0x3BC080", VA = "0x1803BDA80")]
	private void ShowZombiePreviews()
	{
		int num;
		do
		{
			num = 0;
			this.ClearPreviews();
			List<ChessManager.ZombieWithRow> newWaveZombies = this.NewWaveZombies;
			Func<ChessManager.ZombieWithRow, int> <>9__16_ = ChessManager.<>c.<>9__16_0;
			if (<>9__16_ == 0)
			{
				Func<ChessManager.ZombieWithRow, int> func;
				ChessManager.<>c.<>9__16_0 = func;
			}
			IEnumerable enumerable = Enumerable.GroupBy<ChessManager.ZombieWithRow, int>(newWaveZombies, <>9__16_);
			Func<IGrouping<int, ChessManager.ZombieWithRow>, int> func2;
			if (ChessManager.<>c.<>9__16_1 == 0)
			{
				ChessManager.<>c.<>9__16_1 = func2;
			}
			if (Enumerable.OrderBy<IGrouping<int, ChessManager.ZombieWithRow>, int>(enumerable, func2) != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					if (num == typeof(IEnumerator).TypeHandle)
					{
						goto IL_00A4;
					}
					num++;
				}
				if (num < num)
				{
					num += num;
					if (num == 0)
					{
						goto IL_00A4;
					}
					num++;
				}
				if (ChessManager.<>c.<>9__16_2 == 0)
				{
					Func<ChessManager.ZombieWithRow, ZombieType> func3;
					ChessManager.<>c.<>9__16_2 = func3;
				}
				Func<IGrouping<ZombieType, ChessManager.ZombieWithRow>, ZombieType> func4;
				if (ChessManager.<>c.<>9__16_3 == 0)
				{
					ChessManager.<>c.<>9__16_3 = func4;
				}
				Func<IGrouping<ZombieType, ChessManager.ZombieWithRow>, int> func5;
				if (ChessManager.<>c.<>9__16_4 == 0)
				{
					ChessManager.<>c.<>9__16_4 = func5;
				}
				IEnumerable enumerable2;
				Dictionary<IGrouping<ZombieType, ChessManager.ZombieWithRow>, ZombieType> dictionary = Enumerable.ToDictionary<IGrouping<ZombieType, ChessManager.ZombieWithRow>, ZombieType, int>(enumerable2, func4, func5);
			}
			IL_00A4:
			if ("{il2cpp array field local16->}" != (ulong)0L)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x060002C5 RID: 709 RVA: 0x0000BED4 File Offset: 0x0000A0D4
	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x3BBD40", Offset = "0x3BA340", VA = "0x1803BBD40")]
	private void ClearPreviews()
	{
		ulong num2;
		do
		{
			int num = 0;
			List<GameObject> list = this.zombiePreviews;
			bool flag;
			if (flag)
			{
				global::UnityEngine.Object.Destroy(num);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x060002C6 RID: 710 RVA: 0x0000BF08 File Offset: 0x0000A108
	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x3BD170", Offset = "0x3BB770", VA = "0x1803BD170")]
	private void SetZombiePreview(int row, Dictionary<ZombieType, int> zombieWithCount)
	{
		int num2;
		do
		{
			uint num;
			float boxYFromRow = global::Lawnf.GetBoxYFromRow(row, (int)num);
			num2 = 0;
			bool flag;
			if (flag)
			{
				int size = this.zombiePreviews._size;
				GameObject gameObject;
				Transform transform = gameObject.transform;
				Transform transform2 = this.board.transform;
				transform.parentInternal = transform2;
				SortingGroup sortingGroup = gameObject.AddComponent<SortingGroup>();
				string text = string.Format("zombie{0}", sortingGroup);
				sortingGroup.sortingLayerName = text;
				sortingGroup.sortingOrder = num2;
				GameObject gameObject2 = new GameObject();
				Transform transform3 = gameObject2.transform;
				Transform transform4 = gameObject.transform.Find("Shadow");
				Vector3 vector;
				float z = vector.z;
				Transform transform5 = gameObject2.transform;
				Transform transform6 = gameObject.transform;
				transform5.parentInternal = transform6;
				TextMeshPro textMeshPro = gameObject2.AddComponent<TextMeshPro>();
				string text2 = string.Format("x{0}", textMeshPro);
				textMeshPro.text = text2;
				textMeshPro.fontSize = 8f;
				uint num3;
				textMeshPro.sortingOrder = (int)num3;
				Transform transform7 = textMeshPro.transform;
				num2++;
			}
		}
		while (num2 != 0);
	}

	// Token: 0x060002C7 RID: 711 RVA: 0x0000C068 File Offset: 0x0000A268
	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x3BC480", Offset = "0x3BAA80", VA = "0x1803BC480")]
	public void MoveNext()
	{
		if (!this.playerRound)
		{
			ChessManager.<WaveEnd>d__21 <WaveEnd>d__;
			<WaveEnd>d__.System.IDisposable.Dispose();
			<WaveEnd>d__.<>1__state = (int)((ulong)0L);
			<WaveEnd>d__.<>4__this = this;
			Coroutine coroutine = base.StartCoroutine(<WaveEnd>d__);
			bool flag = !this.playerRound;
			this.playerRound = flag;
			return;
		}
		this.UpdateText();
		GameObject gameObject = this.textMesh.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
		this.ClearPreviews();
		ChessManager.<StartSummonZombie>d__20 <StartSummonZombie>d__;
		<StartSummonZombie>d__.System.IDisposable.Dispose();
		<StartSummonZombie>d__.<>1__state = (int)((ulong)0L);
		<StartSummonZombie>d__.<>4__this = this;
		Coroutine coroutine2 = base.StartCoroutine(<StartSummonZombie>d__);
		Board board = this.board;
		int num2 = this.restMoveTimes;
		num2++;
		<StartSummonZombie>d__ += <StartSummonZombie>d__;
		num2 += <StartSummonZombie>d__;
		this.restMoveTimes = num2;
		GameObject gloveBank = InGameUI.Instance.GloveBank;
		int num3 = 0;
		gloveBank.SetActive(num3 != 0);
		GameObject wheelBank = InGameUI.Instance.WheelBank;
		int num4 = 0;
		wheelBank.SetActive(num4 != 0);
	}

	// Token: 0x060002C8 RID: 712 RVA: 0x0000C158 File Offset: 0x0000A358
	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x3BE130", Offset = "0x3BC730", VA = "0x1803BE130")]
	private IEnumerator StartSummonZombie()
	{
		ChessManager.<StartSummonZombie>d__20 <StartSummonZombie>d__;
		<StartSummonZombie>d__.System.IDisposable.Dispose();
		<StartSummonZombie>d__.<>1__state = (int)((ulong)0L);
		<StartSummonZombie>d__.<>4__this = this;
		return null;
	}

	// Token: 0x060002C9 RID: 713 RVA: 0x0000C17C File Offset: 0x0000A37C
	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x3BE450", Offset = "0x3BCA50", VA = "0x1803BE450")]
	private IEnumerator WaveEnd()
	{
		ChessManager.<WaveEnd>d__21 <WaveEnd>d__;
		<WaveEnd>d__.System.IDisposable.Dispose();
		<WaveEnd>d__.<>1__state = (int)((ulong)0L);
		<WaveEnd>d__.<>4__this = this;
		return null;
	}

	// Token: 0x060002CA RID: 714 RVA: 0x0000C1A0 File Offset: 0x0000A3A0
	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x3BE2B0", Offset = "0x3BC8B0", VA = "0x1803BE2B0")]
	public void UpdateText()
	{
		Board board = this.board;
		TextMeshPro textMeshPro = this.textMesh;
		int theWave = board.theWave;
		int theMaxWave = this.board.theMaxWave;
		string text = string.Format("当前波数：{0}/{1}\n\n", theWave, theWave);
		textMeshPro.text = text;
		TextMeshPro textMeshPro2 = this.textMesh;
		string text2 = textMeshPro2.text;
		int num = this.restMoveTimes;
		string text3 = string.Format("剩余可用步数：{0}", text2);
		string text4 = text2 + text3;
		textMeshPro2.text = text4;
	}

	// Token: 0x060002CB RID: 715 RVA: 0x0000C228 File Offset: 0x0000A428
	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x3BD8B0", Offset = "0x3BBEB0", VA = "0x1803BD8B0")]
	private void SetZombies()
	{
		int num;
		do
		{
			List<ChessManager.ZombieWithRow> newWaveZombies = this.NewWaveZombies;
			num = 0;
			bool flag;
			if (flag)
			{
				CreateZombie instance = CreateZombie.Instance;
			}
		}
		while (num != 0);
	}

	// Token: 0x060002CC RID: 716 RVA: 0x0000C264 File Offset: 0x0000A464
	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x3BD730", Offset = "0x3BBD30", VA = "0x1803BD730")]
	private List<ChessManager.ZombieWithRow> SetZombieRow(List<ZombieType> zombieTypes)
	{
		List<ChessManager.ZombieWithRow> list = new List();
		int size = zombieTypes._size;
		int num = size - 1;
		if (size > 0)
		{
			int num2 = 0;
			ZombieType zombieType = zombieTypes[num2];
			int rowNum = this.board.rowNum;
			int num3 = global::UnityEngine.Random.Range(0, rowNum);
			int size2 = list._size;
			list._size = num3;
			int num4 = 0;
			zombieTypes.RemoveAt(num4);
		}
		return list;
	}

	// Token: 0x060002CD RID: 717 RVA: 0x0000C2D8 File Offset: 0x0000A4D8
	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x3BBED0", Offset = "0x3BA4D0", VA = "0x1803BBED0")]
	private List<ZombieType> GetZombies(int wave)
	{
		List<ZombieType> list = new List();
		int num = 0;
		List<List<ZombieSpawnData>> zombieList = InitZombieList.zombieList;
		List<ZombieSpawnData> list2 = zombieList[wave];
		ZombieSpawnData zombieSpawnData = zombieList[wave][num];
		ZombieType zombieType = zombieSpawnData.zombieType;
		int size = list._size;
		num++;
		list._size = zombieSpawnData;
		num++;
		return list;
	}

	// Token: 0x060002CE RID: 718 RVA: 0x0000C340 File Offset: 0x0000A540
	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x3BC660", Offset = "0x3BAC60", VA = "0x1803BC660")]
	private void ResetBoard()
	{
		int num = 0;
		int num2 = 0;
		this.SetChess((ChessType)num2, PlantType.WallNut, 3, num);
		int num3 = 0;
		ulong num4;
		this.SetChess((ChessType)num3, PlantType.WallNut, 3, (int)num4);
		int num5 = 0;
		ulong num6;
		this.SetChess((ChessType)num5, PlantType.WallNut, 3, (int)num6);
		int num7 = 0;
		ulong num8;
		this.SetChess((ChessType)num7, PlantType.WallNut, 3, (int)num8);
		int num9 = 0;
		ulong num10;
		this.SetChess((ChessType)num9, PlantType.WallNut, 3, (int)num10);
		ulong num11;
		this.SetChess((ChessType)((uint)3), (PlantType)((uint)26), 2, (int)num11);
		ulong num12;
		this.SetChess((ChessType)((uint)3), (PlantType)((uint)26), 2, (int)num12);
		int num13 = 0;
		int num14 = 0;
		this.SetChess((ChessType)((uint)1), (PlantType)num14, num13, num);
		int num15 = 0;
		ulong num16;
		this.SetChess((ChessType)((uint)2), (PlantType)((uint)23), num15, (int)num16);
		int num17 = 0;
		ulong num18;
		this.SetChess((ChessType)((uint)4), (PlantType)((uint)14), num17, (int)num18);
		int num19 = 0;
		ulong num20;
		this.SetChess((ChessType)((uint)5), (PlantType)((uint)5), num19, (int)num20);
		int num21 = 0;
		ulong num22;
		this.SetChess((ChessType)((uint)6), (PlantType)((uint)1), num21, (int)num22);
		int num23 = 0;
		ulong num24;
		this.SetChess((ChessType)((uint)5), (PlantType)((uint)5), num23, (int)num24);
		int num25 = 0;
		ulong num26;
		this.SetChess((ChessType)((uint)4), (PlantType)((uint)14), num25, (int)num26);
		int num27 = 0;
		ulong num28;
		this.SetChess((ChessType)((uint)2), (PlantType)((uint)23), num27, (int)num28);
		int num29 = 0;
		int num30 = 0;
		ulong num31;
		this.SetChess((ChessType)((uint)1), (PlantType)num30, num29, (int)num31);
	}

	// Token: 0x060002CF RID: 719 RVA: 0x0000C454 File Offset: 0x0000A654
	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x3BD020", Offset = "0x3BB620", VA = "0x1803BD020")]
	private void SetChess(ChessType chessType, PlantType thePlantType, int theColumn, int theRow)
	{
		CreatePlant instance = CreatePlant.Instance;
		Plant plant;
		Chess chess = plant.gameObject.AddComponent<Chess>();
		chess.chessType = chessType;
		chess.plant = plant;
		chess.chessManager = this;
		if (chessType == ChessType.将)
		{
			chess.plant.dieMeansLose = true;
			this.将 = chess;
		}
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x0000C4B4 File Offset: 0x0000A6B4
	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x3BC890", Offset = "0x3BAE90", VA = "0x1803BC890")]
	public bool Rule_兵(Chess chess, int theColumn, int theRow)
	{
		do
		{
			if (chess.plant.thePlantColumn < 5)
			{
				if (theRow == 0)
				{
					Plant plant = chess.plant;
					if (theColumn == 1)
					{
						break;
					}
				}
			}
			if (theColumn == 0)
			{
				Plant plant2 = chess.plant;
				if (theColumn == 1)
				{
					break;
				}
			}
			Plant plant3 = chess.plant;
			while (theRow != 0)
			{
			}
		}
		while (chess.plant != (ulong)1L);
		throw new NullReferenceException();
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x0000C50C File Offset: 0x0000A70C
	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x3BCD00", Offset = "0x3BB300", VA = "0x1803BCD00")]
	public bool Rule_车(Chess chess, int theColumn, int theRow)
	{
		Plant plant = chess.plant;
		if (theColumn == plant.thePlantColumn || theRow != plant.thePlantRow)
		{
		}
		int thePlantColumn = plant.thePlantColumn;
		int thePlantRow = plant.thePlantRow;
		return this.IsStraightPathClear(thePlantColumn, thePlantRow, theRow, theRow);
	}

	// Token: 0x060002D2 RID: 722 RVA: 0x0000C55C File Offset: 0x0000A75C
	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x3BCEA0", Offset = "0x3BB4A0", VA = "0x1803BCEA0")]
	public bool Rule_马(Chess chess, int theColumn, int theRow)
	{
		Plant plant = chess.plant;
		Plant plant2 = chess.plant;
		if (theColumn != 1 || theColumn != 2)
		{
			while (theColumn != 2)
			{
			}
			while (theColumn != 1)
			{
			}
		}
		Plant plant3 = chess.plant;
		List<Plant> list = global::Lawnf.Get1x1Plants(theColumn, theColumn);
		throw new NullReferenceException();
	}

	// Token: 0x060002D3 RID: 723 RVA: 0x0000C5A0 File Offset: 0x0000A7A0
	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x3BCD00", Offset = "0x3BB300", VA = "0x1803BCD00")]
	public bool Rule_炮(Chess chess, int theColumn, int theRow)
	{
		Plant plant = chess.plant;
		if (theColumn == plant.thePlantColumn || theRow != plant.thePlantRow)
		{
		}
		int thePlantColumn = plant.thePlantColumn;
		int thePlantRow = plant.thePlantRow;
		return this.IsStraightPathClear(thePlantColumn, thePlantRow, theRow, theRow);
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x0000C5F0 File Offset: 0x0000A7F0
	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x3BCAD0", Offset = "0x3BB0D0", VA = "0x1803BCAD0")]
	public bool Rule_士(Chess chess, int theColumn, int theRow)
	{
		if (theColumn <= 2)
		{
			Plant plant = chess.plant;
			Plant plant2 = chess.plant;
			if (theColumn == 1)
			{
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x0000C61C File Offset: 0x0000A81C
	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x3BCD60", Offset = "0x3BB360", VA = "0x1803BCD60")]
	public bool Rule_象(Chess chess, int theColumn, int theRow)
	{
		if (theColumn < 5)
		{
			Plant plant = chess.plant;
			Plant plant2 = chess.plant;
			if (theColumn == 2 && theColumn == 0)
			{
				Plant plant3 = chess.plant;
				int num = plant3.thePlantRow;
				num += theRow;
				num -= plant2;
				int num2 = plant3.thePlantColumn;
				num2 += theColumn;
				num2 -= plant2;
				if (!this.IsPositionOccupied(num2, theColumn))
				{
				}
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x0000C684 File Offset: 0x0000A884
	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x3BCBE0", Offset = "0x3BB1E0", VA = "0x1803BCBE0")]
	public bool Rule_将(Chess chess, int theColumn, int theRow)
	{
		if (theColumn <= 2)
		{
			Plant plant = chess.plant;
			Plant plant2 = chess.plant;
			if ((theColumn == 1 && theRow != 0) || theColumn == 0)
			{
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x060002D7 RID: 727 RVA: 0x0000C6B8 File Offset: 0x0000A8B8
	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x3BC340", Offset = "0x3BA940", VA = "0x1803BC340")]
	private bool IsInPalace(int column, int row)
	{
		return column <= 2 && row <= 5;
	}

	// Token: 0x060002D8 RID: 728 RVA: 0x0000C6D4 File Offset: 0x0000A8D4
	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x3BC3C0", Offset = "0x3BA9C0", VA = "0x1803BC3C0")]
	private bool IsStraightPathClear(int fromCol, int fromRow, int toCol, int toRow)
	{
		bool flag;
		if ((fromCol == toCol && flag) || fromCol == 0 || !this.IsPositionOccupied(fromCol, fromRow))
		{
		}
		return true;
	}

	// Token: 0x060002D9 RID: 729 RVA: 0x0000C6FC File Offset: 0x0000A8FC
	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x3BC360", Offset = "0x3BA960", VA = "0x1803BC360")]
	private bool IsPositionOccupied(int theColumn, int theRow)
	{
		List<Plant> list = global::Lawnf.Get1x1Plants(theColumn, theColumn);
		throw new NullReferenceException();
	}

	// Token: 0x060002DA RID: 730 RVA: 0x0000C718 File Offset: 0x0000A918
	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x3BC650", Offset = "0x3BAC50", VA = "0x1803BC650")]
	private bool OverRiver(int theColumn)
	{
		return theColumn >= 5;
	}

	// Token: 0x060002DB RID: 731 RVA: 0x0000C72C File Offset: 0x0000A92C
	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x3BE4C0", Offset = "0x3BCAC0", VA = "0x1803BE4C0")]
	public ChessManager()
	{
		List<GameObject> list = new List();
		this.zombiePreviews = list;
		base..ctor();
	}

	// Token: 0x04000115 RID: 277
	[Token(Token = "0x4000115")]
	public static ChessManager Instance;

	// Token: 0x04000116 RID: 278
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000116")]
	public Board board;

	// Token: 0x04000117 RID: 279
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000117")]
	public bool playerRound = true;

	// Token: 0x04000118 RID: 280
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000118")]
	public Chess 将;

	// Token: 0x04000119 RID: 281
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000119")]
	public int restMoveTimes = (int)((ulong)1L);

	// Token: 0x0400011A RID: 282
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400011A")]
	private GameObject fog;

	// Token: 0x0400011B RID: 283
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400011B")]
	private List<ChessManager.ZombieWithRow> _newWaveZombies;

	// Token: 0x0400011C RID: 284
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400011C")]
	private TextMeshPro textMesh;

	// Token: 0x0400011D RID: 285
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400011D")]
	private readonly List<GameObject> zombiePreviews;

	// Token: 0x020000A4 RID: 164
	[Token(Token = "0x20000A4")]
	private struct ZombieWithRow
	{
		// Token: 0x0400011E RID: 286
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400011E")]
		public ZombieType zombieType;

		// Token: 0x0400011F RID: 287
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400011F")]
		public int row;
	}
}
