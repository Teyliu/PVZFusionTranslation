using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020000C9 RID: 201
[Token(Token = "0x20000C9")]
public class LoonNut : MonoBehaviour, IDamageMaker
{
	// Token: 0x17000089 RID: 137
	// (get) Token: 0x0600039C RID: 924 RVA: 0x00010B24 File Offset: 0x0000ED24
	// (set) Token: 0x0600039D RID: 925 RVA: 0x00010B3C File Offset: 0x0000ED3C
	[Token(Token = "0x17000089")]
	public Team Team
	{
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "4")]
		get
		{
			return Team.Player;
		}
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x4F5BA0", Offset = "0x4F41A0", VA = "0x1804F5BA0", Slot = "5")]
		set
		{
			NotImplementedException ex = new NotImplementedException();
		}
	}

	// Token: 0x0600039E RID: 926 RVA: 0x00010B50 File Offset: 0x0000ED50
	[Token(Token = "0x600039E")]
	[Address(RVA = "0x4F48A0", Offset = "0x4F2EA0", VA = "0x1804F48A0")]
	private void HitEffect(Zombie zombie)
	{
		PlantType plantType = this.thePlantType;
		if (plantType > PlantType.CaltropNut)
		{
			if (plantType > PlantType.PortalNut)
			{
				if (plantType == PlantType.FireNut)
				{
					int num = 0;
					zombie.JalaedExplode(true, 100, num != 0);
					if (this.hitCount == 3)
					{
						BoardAction boardAction = this.board.boardAction;
						float num2 = this.damageMultiplier;
					}
					return;
				}
				if (plantType == PlantType.DoomNut)
				{
					BoardAction boardAction2 = this.board.boardAction;
					int column = zombie.Column;
					float num3 = this.damageMultiplier;
				}
				Crater crater;
				if (crater != (ulong)1250L)
				{
					goto IL_02A3;
				}
				int num4 = 0;
				int num5 = this.hitCount;
				num5++;
				int num6;
				if (num5 > 0)
				{
					CreateBullet instance = CreateBullet.Instance;
					Transform transform = base.transform;
					Transform transform2 = base.transform;
					num6 = this.hitCount;
					num4++;
					num6++;
				}
				GameAPP.PlaySound(num6, 0.5f, 1f);
				while (this.hitCount != 3)
				{
				}
				CreatePlant instance2 = CreatePlant.Instance;
				int column2 = zombie.Column;
				int theZombieRow = zombie.theZombieRow;
				ulong num7;
				ulong num8;
				Plant plant = instance2.SetPlant(column2, theZombieRow, (PlantType)((uint)13), num4, num4, num7 != 0UL, num8 != 0UL, num4);
			}
			CreateZombie instance3;
			Zombie zombie2;
			if (plantType == PlantType.HypnoNut)
			{
				Transform axis = zombie.axis;
				ZombieType theZombieType = zombie.theZombieType;
				instance3 = CreateZombie.Instance;
				Lawnf.SetZombieHealth(zombie2, 0.5f);
			}
			if (zombie2 == (ulong)1189L)
			{
				int num9 = 0;
				zombie.SetFreeze(0.5f, num9);
				Transform transform3 = instance3.transform;
			}
			Vector3 vector;
			if (vector != (ulong)1215L)
			{
				goto IL_02A3;
			}
			Transform axis2 = zombie.axis;
			ParticleManager instance4 = ParticleManager.Instance;
			int num10 = 0;
			Vector3 vector2;
			float z = vector2.z;
			int num11 = 0;
			int theZombieRow2 = zombie.theZombieRow;
			ulong num12;
			Particle particle = instance4.SetParticle((ParticleType)((uint)11), num10, theZombieRow2, num12 != 0UL, (float)num11);
			Mouse instance5 = Mouse.Instance;
			int theZombieRow3 = zombie.theZombieRow;
			float num13;
			float landY = instance5.GetLandY(num13, theZombieRow3);
		}
		if (plantType > PlantType.CherryNut)
		{
			if (plantType == PlantType.SunNut)
			{
				int num14 = this.hitCount;
				int num15 = 0;
				num14++;
				if (num14 > 0)
				{
					CreateItem instance6 = CreateItem.Instance;
					Transform transform4 = base.transform;
					Vector3 vector3;
					float z2 = vector3.z;
					int num16 = this.hitCount;
					num15++;
					num16++;
				}
			}
			if (this.hitCount != 1)
			{
			}
			GameAPP.PlaySound(49, 0.5f, 1f);
			zombie.Die(2);
			zombie.KillByCaltrop();
			GameAPP.PlaySound(77, 0.5f, 1f);
		}
		zombie.KillByCaltrop();
		BoardAction boardAction3 = this.board.boardAction;
		Transform transform5 = base.transform;
		float num17 = this.damageMultiplier;
		GameObject gameObject = base.gameObject;
		global::UnityEngine.Object.Destroy(gameObject);
		IL_02A3:
		PlantType plantType2 = this.thePlantType;
		throw new NullReferenceException();
	}

	// Token: 0x0600039F RID: 927 RVA: 0x00010E14 File Offset: 0x0000F014
	[Token(Token = "0x600039F")]
	[Address(RVA = "0x4F4670", Offset = "0x4F2C70", VA = "0x1804F4670")]
	private void Awake()
	{
		Board instance = Board.Instance;
		this.board = instance;
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
		if (AdvantureConfig.data.GetResult((AdvantureLevel)((uint)4), (MissionResult)((uint)1)))
		{
			float num = this.damageMultiplier;
			this.damageMultiplier = num;
		}
	}

	// Token: 0x060003A0 RID: 928 RVA: 0x00010E64 File Offset: 0x0000F064
	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x4F5920", Offset = "0x4F3F20", VA = "0x1804F5920")]
	private void Start()
	{
		GameAPP.PlaySound(53, 0.5f, 1f);
		Board board = this.board;
		int num = 0;
		if (num < board.rowNum)
		{
			int rowNum = this.board.rowNum;
			float boxYFromRow = Lawnf.GetBoxYFromRow(num, rowNum);
			List<float> list = this.ys;
			int size = list._size;
			BoxType boxType = board.roadType[10];
			int num2 = size + 1;
			list._size = num2;
			Board board2 = this.board;
			num++;
		}
	}

	// Token: 0x060003A1 RID: 929 RVA: 0x00010EEC File Offset: 0x0000F0EC
	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x4F5620", Offset = "0x4F3C20", VA = "0x1804F5620")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		this.HitUpdate(collision);
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x00010F00 File Offset: 0x0000F100
	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x4F53F0", Offset = "0x4F39F0", VA = "0x1804F53F0")]
	private void HitUpdate(Collider2D collision)
	{
		int num = 0;
		if (collision.TryGetComponent<Zombie>(num))
		{
			int num2 = this.currentRow;
			if ((this.hit ? 1 : 0) == num && Lawnf.InLandStatus((ZombieStatus)num))
			{
				this.hit = true;
				this.HitEffect(num);
				GameAPP.PlaySound(global::UnityEngine.Random.Range(54, 56), 0.5f, 1f);
				ScreenShake.TriggerShake(0.02f);
				if (num != 0)
				{
					int rowNum = this.board.rowNum;
					if (num != rowNum)
					{
						bool flag = "{il2cpp field on {'constant28' (constant value of type Cpp2IL.Core.Analysis.ResultModels.FieldPointer)}, offset 0x0}" == (ulong)1L;
						int num3 = global::UnityEngine.Random.Range(0, 2);
					}
				}
				this.direction = (LoonNut.LoonDirection)((uint)2);
				if (this.direction == LoonNut.LoonDirection.Up && num > 0)
				{
					SortingGroup sortingGroup = this.sortingGroup;
					int num4;
					string text = string.Format("bullet{0}", num4);
					sortingGroup.sortingLayerName = text;
				}
			}
		}
	}

	// Token: 0x060003A3 RID: 931 RVA: 0x00010FD0 File Offset: 0x0000F1D0
	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x4F5AB0", Offset = "0x4F40B0", VA = "0x1804F5AB0")]
	private void Update()
	{
		this.PositionUpdate();
	}

	// Token: 0x060003A4 RID: 932 RVA: 0x00010FE4 File Offset: 0x0000F1E4
	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x4F5630", Offset = "0x4F3C30", VA = "0x1804F5630")]
	private void PositionUpdate()
	{
		Transform transform = base.transform;
		Board board = this.board;
		Animator animator = this.anim;
		LoonNut.LoonDirection loonDirection = this.direction;
		if (loonDirection == LoonNut.LoonDirection.Up)
		{
			if (this.currentRow != 0)
			{
				Transform transform2 = base.transform;
			}
			this.direction = (LoonNut.LoonDirection)((ulong)2L);
		}
		Transform transform3;
		if (loonDirection == LoonNut.LoonDirection.Down)
		{
			int rowNum = this.board.rowNum;
			if (this.currentRow != rowNum)
			{
				transform3 = base.transform;
				Vector3 vector;
				float z = vector.z;
			}
			this.direction = (LoonNut.LoonDirection)((ulong)1L);
		}
		Func<float, bool> func;
		float num = Enumerable.FirstOrDefault<float>(this.ys, func);
		if (transform3 != 0)
		{
			List<float> list = this.ys;
			int num2;
			if (num2 != this.currentRow)
			{
				this.hit = false;
			}
			SortingGroup sortingGroup = this.sortingGroup;
			this.currentRow = num2;
			string text = string.Format("bullet{0}", num2);
			sortingGroup.sortingLayerName = text;
		}
	}

	// Token: 0x060003A5 RID: 933 RVA: 0x000110CC File Offset: 0x0000F2CC
	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x4F4790", Offset = "0x4F2D90", VA = "0x1804F4790")]
	private void GetDirection(int currentRow)
	{
		if (currentRow != 0)
		{
			int rowNum = this.board.rowNum;
			if (currentRow != rowNum)
			{
				bool flag = "{il2cpp field on {'constant10' (constant value of type Cpp2IL.Core.Analysis.ResultModels.FieldPointer)}, offset 0x0}" == (ulong)1L;
				uint num2;
				int num = global::UnityEngine.Random.Range(0, (int)num2);
				num += 2;
			}
		}
		uint num3;
		this.direction = (LoonNut.LoonDirection)num3;
		if (this.direction == LoonNut.LoonDirection.Up && currentRow > 0)
		{
			int num4 = currentRow - 1;
			SortingGroup sortingGroup = this.sortingGroup;
			string text = string.Format("bullet{0}", num4);
			sortingGroup.sortingLayerName = text;
		}
	}

	// Token: 0x060003A6 RID: 934 RVA: 0x00011144 File Offset: 0x0000F344
	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x4F4750", Offset = "0x4F2D50", VA = "0x1804F4750", Slot = "6")]
	public bool CanAttack(IDamageable target)
	{
		NotImplementedException ex = new NotImplementedException();
		return false;
	}

	// Token: 0x060003A7 RID: 935 RVA: 0x00011158 File Offset: 0x0000F358
	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x4F5B20", Offset = "0x4F4120", VA = "0x1804F5B20")]
	public LoonNut()
	{
		List<float> list = new List();
		this.ys = list;
		base..ctor();
	}

	// Token: 0x040001E7 RID: 487
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001E7")]
	public PlantType thePlantType;

	// Token: 0x040001E8 RID: 488
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40001E8")]
	public int currentRow;

	// Token: 0x040001E9 RID: 489
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001E9")]
	public int damage;

	// Token: 0x040001EA RID: 490
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001EA")]
	public SortingGroup sortingGroup;

	// Token: 0x040001EB RID: 491
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001EB")]
	public LoonNut.LoonDirection direction;

	// Token: 0x040001EC RID: 492
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40001EC")]
	private float damageMultiplier = 1f;

	// Token: 0x040001ED RID: 493
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001ED")]
	private Animator anim;

	// Token: 0x040001EE RID: 494
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001EE")]
	private Board board;

	// Token: 0x040001EF RID: 495
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001EF")]
	private int hitCount;

	// Token: 0x040001F0 RID: 496
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40001F0")]
	private bool hit;

	// Token: 0x040001F1 RID: 497
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40001F1")]
	private readonly List<float> ys;

	// Token: 0x020000CA RID: 202
	[Token(Token = "0x20000CA")]
	public enum LoonDirection
	{
		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		Right,
		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		Up,
		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		Down
	}
}
