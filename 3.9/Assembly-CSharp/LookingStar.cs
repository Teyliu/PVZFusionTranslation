using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000276 RID: 630
[Token(Token = "0x2000276")]
public class LookingStar : MonoBehaviour
{
	// Token: 0x06000B55 RID: 2901 RVA: 0x00040504 File Offset: 0x0003E704
	[Token(Token = "0x6000B55")]
	[Address(RVA = "0x9346A0", Offset = "0x932CA0", VA = "0x1809346A0")]
	private void Awake()
	{
		this.Instance = this;
		Board instance = Board.Instance;
		this.board = instance;
	}

	// Token: 0x06000B56 RID: 2902 RVA: 0x00040528 File Offset: 0x0003E728
	[Token(Token = "0x6000B56")]
	[Address(RVA = "0x934A30", Offset = "0x933030", VA = "0x180934A30")]
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

	// Token: 0x06000B57 RID: 2903 RVA: 0x00040794 File Offset: 0x0003E994
	[Token(Token = "0x6000B57")]
	[Address(RVA = "0x934F30", Offset = "0x933530", VA = "0x180934F30")]
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

	// Token: 0x06000B58 RID: 2904 RVA: 0x00040824 File Offset: 0x0003EA24
	[Token(Token = "0x6000B58")]
	[Address(RVA = "0x9347A0", Offset = "0x932DA0", VA = "0x1809347A0")]
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

	// Token: 0x06000B59 RID: 2905 RVA: 0x00040894 File Offset: 0x0003EA94
	[Token(Token = "0x6000B59")]
	[Address(RVA = "0x934700", Offset = "0x932D00", VA = "0x180934700")]
	private bool CheckPlant(int theColumn, int theRow, PlantType thePlantType)
	{
		int num = 0;
		Plant plant;
		return plant != num;
	}

	// Token: 0x06000B5A RID: 2906 RVA: 0x000408B4 File Offset: 0x0003EAB4
	[Token(Token = "0x6000B5A")]
	[Address(RVA = "0x935250", Offset = "0x933850", VA = "0x180935250")]
	public LookingStar()
	{
		List<LookingStar.PreStar> list = new List();
		this.preStars = list;
		this.level = (ChallengeLevel)((ulong)107L);
		base..ctor();
	}

	// Token: 0x04000759 RID: 1881
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000759")]
	public LookingStar Instance;

	// Token: 0x0400075A RID: 1882
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400075A")]
	public readonly List<LookingStar.PreStar> preStars;

	// Token: 0x0400075B RID: 1883
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400075B")]
	public ChallengeLevel level;

	// Token: 0x0400075C RID: 1884
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400075C")]
	private Board board;

	// Token: 0x0400075D RID: 1885
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400075D")]
	private bool over;

	// Token: 0x02000277 RID: 631
	[Token(Token = "0x2000277")]
	public struct PreStar
	{
		// Token: 0x0400075E RID: 1886
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400075E")]
		public int theColumn;

		// Token: 0x0400075F RID: 1887
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400075F")]
		public int theRow;

		// Token: 0x04000760 RID: 1888
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000760")]
		public PlantType thePlantType;

		// Token: 0x04000761 RID: 1889
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000761")]
		public GameObject preview;
	}
}
