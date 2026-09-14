using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000270 RID: 624
[Token(Token = "0x2000270")]
public class LookingStar : MonoBehaviour
{
	// Token: 0x06000B39 RID: 2873 RVA: 0x000406CC File Offset: 0x0003E8CC
	[Token(Token = "0x6000B39")]
	[Address(RVA = "0x8A46C0", Offset = "0x8A2CC0", VA = "0x1808A46C0")]
	private void Awake()
	{
		this.Instance = this;
		Board instance = Board.Instance;
		this.board = instance;
	}

	// Token: 0x06000B3A RID: 2874 RVA: 0x000406F0 File Offset: 0x0003E8F0
	[Token(Token = "0x6000B3A")]
	[Address(RVA = "0x8A4A50", Offset = "0x8A3050", VA = "0x1808A4A50")]
	private void Start()
	{
		ChallengeLevel challengeLevel = this.level;
		if (challengeLevel == ChallengeLevel.LookStar)
		{
			this.SetPlantPreview(1, 2, (PlantType)((uint)1085));
			this.SetPlantPreview(2, 2, (PlantType)((uint)1081));
			int num = 0;
			this.SetPlantPreview(3, num, (PlantType)((uint)1081));
			this.SetPlantPreview(3, 1, (PlantType)((uint)1104));
			this.SetPlantPreview(3, 2, (PlantType)((uint)1084));
			this.SetPlantPreview(3, 3, (PlantType)((uint)1104));
			this.SetPlantPreview(3, 4, (PlantType)((uint)1081));
			this.SetPlantPreview(4, 1, (PlantType)((uint)1094));
			this.SetPlantPreview(4, 2, (PlantType)((uint)1093));
			this.SetPlantPreview(4, 3, (PlantType)((uint)1094));
			this.SetPlantPreview(5, 2, (PlantType)((uint)1096));
			this.SetPlantPreview(5, 3, (PlantType)((uint)1096));
			this.SetPlantPreview(6, 2, (PlantType)((uint)1095));
			this.SetPlantPreview(6, 4, (PlantType)((uint)1095));
			return;
		}
		while (challengeLevel != ChallengeLevel.LookNut)
		{
		}
		TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)1006));
		int num2 = 0;
		this.SetPlantPreview(3, num2, (PlantType)((uint)1004));
		int num3 = 0;
		this.SetPlantPreview(4, num3, (PlantType)((uint)1006));
		int num4 = 0;
		this.SetPlantPreview(5, num4, (PlantType)((uint)1003));
		int num5 = 0;
		this.SetPlantPreview(6, num5, (PlantType)((uint)1010));
		int num6 = 0;
		this.SetPlantPreview(7, num6, (PlantType)((uint)1012));
		this.SetPlantPreview(3, 1, (PlantType)((uint)1312));
		this.SetPlantPreview(4, 1, (PlantType)((uint)1147));
		this.SetPlantPreview(5, 1, (PlantType)((uint)1310));
		this.SetPlantPreview(6, 1, (PlantType)((uint)1189));
		this.SetPlantPreview(7, 1, (PlantType)((uint)1236));
		this.SetPlantPreview(3, 2, (PlantType)((uint)1250));
		this.SetPlantPreview(4, 2, (PlantType)((uint)1295));
		this.SetPlantPreview(5, 2, (PlantType)((uint)1235));
		this.SetPlantPreview(6, 2, (PlantType)((uint)1048));
		this.SetPlantPreview(7, 2, (PlantType)((uint)1282));
		this.SetPlantPreview(3, 3, (PlantType)((uint)1309));
		this.SetPlantPreview(4, 3, (PlantType)((uint)1256));
		this.SetPlantPreview(5, 3, (PlantType)((uint)1255));
		this.SetPlantPreview(6, 3, (PlantType)((uint)1257));
		this.SetPlantPreview(7, 3, (PlantType)((uint)1279));
		this.SetPlantPreview(3, 4, (PlantType)((uint)1262));
		this.SetPlantPreview(4, 4, (PlantType)((uint)1263));
		this.SetPlantPreview(5, 4, (PlantType)((uint)1278));
		this.SetPlantPreview(6, 4, (PlantType)((uint)1206));
		throw new NullReferenceException();
	}

	// Token: 0x06000B3B RID: 2875 RVA: 0x0004095C File Offset: 0x0003EB5C
	[Token(Token = "0x6000B3B")]
	[Address(RVA = "0x8A4F50", Offset = "0x8A3550", VA = "0x1808A4F50")]
	private void Update()
	{
		if (!this.over)
		{
			List<LookingStar.PreStar> list = this.preStars;
			int num = 0;
			List<LookingStar.PreStar> list2 = this.preStars;
			int num2 = 0;
			Plant plant;
			if (!(plant != num2))
			{
			}
			bool flag;
			if (flag)
			{
				GameAPP.PlaySound(125, 0.5f, 1f);
				Vector3 vector;
				float z = vector.z;
			}
			List<LookingStar.PreStar> list3 = this.preStars;
			num++;
			if ((ulong)1L != 0UL)
			{
				Board board = this.board;
				this.over = true;
				this.board.boardTag.disableSummonZombie = true;
			}
		}
	}

	// Token: 0x06000B3C RID: 2876 RVA: 0x000409EC File Offset: 0x0003EBEC
	[Token(Token = "0x6000B3C")]
	[Address(RVA = "0x8A47C0", Offset = "0x8A2DC0", VA = "0x1808A47C0")]
	private void SetPlantPreview(int theColumn, int theRow, PlantType thePlantType)
	{
		Board board = this.board;
		Transform transform = this.board.transform;
		GameObject gameObject;
		SortingGroup component = gameObject.GetComponent<SortingGroup>();
		string text = string.Format("plant{0}", component);
		component.sortingLayerName = text;
		List<LookingStar.PreStar> list = this.preStars;
		int size = list._size;
	}

	// Token: 0x06000B3D RID: 2877 RVA: 0x00040A5C File Offset: 0x0003EC5C
	[Token(Token = "0x6000B3D")]
	[Address(RVA = "0x8A4720", Offset = "0x8A2D20", VA = "0x1808A4720")]
	private bool CheckPlant(int theColumn, int theRow, PlantType thePlantType)
	{
		int num = 0;
		Plant plant;
		return plant != num;
	}

	// Token: 0x06000B3E RID: 2878 RVA: 0x00040A7C File Offset: 0x0003EC7C
	[Token(Token = "0x6000B3E")]
	[Address(RVA = "0x8A5270", Offset = "0x8A3870", VA = "0x1808A5270")]
	public LookingStar()
	{
		List<LookingStar.PreStar> list = new List();
		this.preStars = list;
		this.level = (ChallengeLevel)((ulong)107L);
		base..ctor();
	}

	// Token: 0x0400074D RID: 1869
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400074D")]
	public LookingStar Instance;

	// Token: 0x0400074E RID: 1870
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400074E")]
	public readonly List<LookingStar.PreStar> preStars;

	// Token: 0x0400074F RID: 1871
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400074F")]
	public ChallengeLevel level;

	// Token: 0x04000750 RID: 1872
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000750")]
	private Board board;

	// Token: 0x04000751 RID: 1873
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000751")]
	private bool over;

	// Token: 0x02000271 RID: 625
	[Token(Token = "0x2000271")]
	public struct PreStar
	{
		// Token: 0x04000752 RID: 1874
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000752")]
		public int theColumn;

		// Token: 0x04000753 RID: 1875
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000753")]
		public int theRow;

		// Token: 0x04000754 RID: 1876
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000754")]
		public PlantType thePlantType;

		// Token: 0x04000755 RID: 1877
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000755")]
		public GameObject preview;
	}
}
