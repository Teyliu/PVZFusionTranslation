using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020000A8 RID: 168
[Token(Token = "0x20000A8")]
public class ChessManager : MonoBehaviour
{
	// Token: 0x1700007A RID: 122
	// (get) Token: 0x060002D9 RID: 729 RVA: 0x0000BEF4 File Offset: 0x0000A0F4
	// (set) Token: 0x060002DA RID: 730 RVA: 0x0000BFDC File Offset: 0x0000A1DC
	[Token(Token = "0x1700007A")]
	private List<ChessManager.ZombieWithRow> NewWaveZombies
	{
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x40B300", Offset = "0x409900", VA = "0x18040B300")]
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
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x40B630", Offset = "0x409C30", VA = "0x18040B630")]
		set
		{
			this._newWaveZombies = value;
		}
	}

	// Token: 0x060002DB RID: 731 RVA: 0x0000BFF0 File Offset: 0x0000A1F0
	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x408A90", Offset = "0x407090", VA = "0x180408A90")]
	private void Awake()
	{
		ChessManager.Instance = this;
	}

	// Token: 0x060002DC RID: 732 RVA: 0x0000C004 File Offset: 0x0000A204
	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x40AF50", Offset = "0x409550", VA = "0x18040AF50")]
	private void Start()
	{
		this.ResetBoard();
		Board board = this.board;
		this.InitTextMesh();
		this.restMoveTimes = (int)((ulong)1L);
		InGameText instance = InGameText.Instance;
		Transform transform = this.board.background.transform;
		int num = 0;
		GameObject gameObject = transform.GetChild(num).Find("Fog").gameObject;
		this.fog = gameObject;
		throw new NullReferenceException();
	}

	// Token: 0x060002DD RID: 733 RVA: 0x0000C074 File Offset: 0x0000A274
	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x40B1C0", Offset = "0x4097C0", VA = "0x18040B1C0")]
	private void Update()
	{
		Board board = this.board;
		if (!this.playerRound)
		{
			this.MoveNext();
			return;
		}
	}

	// Token: 0x060002DE RID: 734 RVA: 0x0000C0A0 File Offset: 0x0000A2A0
	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x408E40", Offset = "0x407440", VA = "0x180408E40")]
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

	// Token: 0x060002DF RID: 735 RVA: 0x0000C198 File Offset: 0x0000A398
	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x40A830", Offset = "0x408E30", VA = "0x18040A830")]
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

	// Token: 0x060002E0 RID: 736 RVA: 0x0000C270 File Offset: 0x0000A470
	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x408AF0", Offset = "0x4070F0", VA = "0x180408AF0")]
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

	// Token: 0x060002E1 RID: 737 RVA: 0x0000C2A4 File Offset: 0x0000A4A4
	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x409F20", Offset = "0x408520", VA = "0x180409F20")]
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

	// Token: 0x060002E2 RID: 738 RVA: 0x0000C404 File Offset: 0x0000A604
	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x409230", Offset = "0x407830", VA = "0x180409230")]
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

	// Token: 0x060002E3 RID: 739 RVA: 0x0000C4F4 File Offset: 0x0000A6F4
	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x40AEE0", Offset = "0x4094E0", VA = "0x18040AEE0")]
	private IEnumerator StartSummonZombie()
	{
		ChessManager.<StartSummonZombie>d__20 <StartSummonZombie>d__;
		<StartSummonZombie>d__.System.IDisposable.Dispose();
		<StartSummonZombie>d__.<>1__state = (int)((ulong)0L);
		<StartSummonZombie>d__.<>4__this = this;
		return null;
	}

	// Token: 0x060002E4 RID: 740 RVA: 0x0000C518 File Offset: 0x0000A718
	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x40B200", Offset = "0x409800", VA = "0x18040B200")]
	private IEnumerator WaveEnd()
	{
		ChessManager.<WaveEnd>d__21 <WaveEnd>d__;
		<WaveEnd>d__.System.IDisposable.Dispose();
		<WaveEnd>d__.<>1__state = (int)((ulong)0L);
		<WaveEnd>d__.<>4__this = this;
		return null;
	}

	// Token: 0x060002E5 RID: 741 RVA: 0x0000C53C File Offset: 0x0000A73C
	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x40B060", Offset = "0x409660", VA = "0x18040B060")]
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

	// Token: 0x060002E6 RID: 742 RVA: 0x0000C5C4 File Offset: 0x0000A7C4
	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x40A660", Offset = "0x408C60", VA = "0x18040A660")]
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

	// Token: 0x060002E7 RID: 743 RVA: 0x0000C600 File Offset: 0x0000A800
	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x40A4E0", Offset = "0x408AE0", VA = "0x18040A4E0")]
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

	// Token: 0x060002E8 RID: 744 RVA: 0x0000C674 File Offset: 0x0000A874
	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x408C80", Offset = "0x407280", VA = "0x180408C80")]
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

	// Token: 0x060002E9 RID: 745 RVA: 0x0000C6DC File Offset: 0x0000A8DC
	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x409410", Offset = "0x407A10", VA = "0x180409410")]
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

	// Token: 0x060002EA RID: 746 RVA: 0x0000C7F0 File Offset: 0x0000A9F0
	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x409DD0", Offset = "0x4083D0", VA = "0x180409DD0")]
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

	// Token: 0x060002EB RID: 747 RVA: 0x0000C850 File Offset: 0x0000AA50
	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x409640", Offset = "0x407C40", VA = "0x180409640")]
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

	// Token: 0x060002EC RID: 748 RVA: 0x0000C8A8 File Offset: 0x0000AAA8
	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x409AB0", Offset = "0x4080B0", VA = "0x180409AB0")]
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

	// Token: 0x060002ED RID: 749 RVA: 0x0000C8F8 File Offset: 0x0000AAF8
	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x409C50", Offset = "0x408250", VA = "0x180409C50")]
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

	// Token: 0x060002EE RID: 750 RVA: 0x0000C93C File Offset: 0x0000AB3C
	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x409AB0", Offset = "0x4080B0", VA = "0x180409AB0")]
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

	// Token: 0x060002EF RID: 751 RVA: 0x0000C98C File Offset: 0x0000AB8C
	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x409880", Offset = "0x407E80", VA = "0x180409880")]
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

	// Token: 0x060002F0 RID: 752 RVA: 0x0000C9B8 File Offset: 0x0000ABB8
	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x409B10", Offset = "0x408110", VA = "0x180409B10")]
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

	// Token: 0x060002F1 RID: 753 RVA: 0x0000CA20 File Offset: 0x0000AC20
	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x409990", Offset = "0x407F90", VA = "0x180409990")]
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

	// Token: 0x060002F2 RID: 754 RVA: 0x0000CA54 File Offset: 0x0000AC54
	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x4090F0", Offset = "0x4076F0", VA = "0x1804090F0")]
	private bool IsInPalace(int column, int row)
	{
		return column <= 2 && row <= 5;
	}

	// Token: 0x060002F3 RID: 755 RVA: 0x0000CA70 File Offset: 0x0000AC70
	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x409170", Offset = "0x407770", VA = "0x180409170")]
	private bool IsStraightPathClear(int fromCol, int fromRow, int toCol, int toRow)
	{
		bool flag;
		if ((fromCol == toCol && flag) || fromCol == 0 || !this.IsPositionOccupied(fromCol, fromRow))
		{
		}
		return true;
	}

	// Token: 0x060002F4 RID: 756 RVA: 0x0000CA98 File Offset: 0x0000AC98
	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x409110", Offset = "0x407710", VA = "0x180409110")]
	private bool IsPositionOccupied(int theColumn, int theRow)
	{
		List<Plant> list = global::Lawnf.Get1x1Plants(theColumn, theColumn);
		throw new NullReferenceException();
	}

	// Token: 0x060002F5 RID: 757 RVA: 0x0000CAB4 File Offset: 0x0000ACB4
	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x409400", Offset = "0x407A00", VA = "0x180409400")]
	private bool OverRiver(int theColumn)
	{
		return theColumn >= 5;
	}

	// Token: 0x060002F6 RID: 758 RVA: 0x0000CAC8 File Offset: 0x0000ACC8
	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x40B270", Offset = "0x409870", VA = "0x18040B270")]
	public ChessManager()
	{
		List<GameObject> list = new List();
		this.zombiePreviews = list;
		base..ctor();
	}

	// Token: 0x04000122 RID: 290
	[Token(Token = "0x4000122")]
	public static ChessManager Instance;

	// Token: 0x04000123 RID: 291
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000123")]
	public Board board;

	// Token: 0x04000124 RID: 292
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000124")]
	public bool playerRound = true;

	// Token: 0x04000125 RID: 293
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000125")]
	public Chess 将;

	// Token: 0x04000126 RID: 294
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000126")]
	public int restMoveTimes = (int)((ulong)1L);

	// Token: 0x04000127 RID: 295
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000127")]
	private GameObject fog;

	// Token: 0x04000128 RID: 296
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000128")]
	private List<ChessManager.ZombieWithRow> _newWaveZombies;

	// Token: 0x04000129 RID: 297
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000129")]
	private TextMeshPro textMesh;

	// Token: 0x0400012A RID: 298
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400012A")]
	private readonly List<GameObject> zombiePreviews;

	// Token: 0x020000A9 RID: 169
	[Token(Token = "0x20000A9")]
	private struct ZombieWithRow
	{
		// Token: 0x0400012B RID: 299
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400012B")]
		public ZombieType zombieType;

		// Token: 0x0400012C RID: 300
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400012C")]
		public int row;
	}
}
