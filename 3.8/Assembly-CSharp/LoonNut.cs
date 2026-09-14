using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020000C4 RID: 196
[Token(Token = "0x20000C4")]
public class LoonNut : MonoBehaviour, IDamageMaker
{
	// Token: 0x1700004C RID: 76
	// (get) Token: 0x06000381 RID: 897 RVA: 0x000107E0 File Offset: 0x0000E9E0
	// (set) Token: 0x06000382 RID: 898 RVA: 0x000107F8 File Offset: 0x0000E9F8
	[Token(Token = "0x1700004C")]
	public Team Team
	{
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "4")]
		get
		{
			return Team.Player;
		}
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x4B64E0", Offset = "0x4B4AE0", VA = "0x1804B64E0", Slot = "5")]
		set
		{
			NotImplementedException ex = new NotImplementedException();
		}
	}

	// Token: 0x06000383 RID: 899 RVA: 0x0001080C File Offset: 0x0000EA0C
	[Token(Token = "0x6000383")]
	[Address(RVA = "0x4B51E0", Offset = "0x4B37E0", VA = "0x1804B51E0")]
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

	// Token: 0x06000384 RID: 900 RVA: 0x00010AD0 File Offset: 0x0000ECD0
	[Token(Token = "0x6000384")]
	[Address(RVA = "0x4B4FB0", Offset = "0x4B35B0", VA = "0x1804B4FB0")]
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

	// Token: 0x06000385 RID: 901 RVA: 0x00010B20 File Offset: 0x0000ED20
	[Token(Token = "0x6000385")]
	[Address(RVA = "0x4B6260", Offset = "0x4B4860", VA = "0x1804B6260")]
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

	// Token: 0x06000386 RID: 902 RVA: 0x00010BA8 File Offset: 0x0000EDA8
	[Token(Token = "0x6000386")]
	[Address(RVA = "0x4B5F60", Offset = "0x4B4560", VA = "0x1804B5F60")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		this.HitUpdate(collision);
	}

	// Token: 0x06000387 RID: 903 RVA: 0x00010BBC File Offset: 0x0000EDBC
	[Token(Token = "0x6000387")]
	[Address(RVA = "0x4B5D30", Offset = "0x4B4330", VA = "0x1804B5D30")]
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

	// Token: 0x06000388 RID: 904 RVA: 0x00010C8C File Offset: 0x0000EE8C
	[Token(Token = "0x6000388")]
	[Address(RVA = "0x4B63F0", Offset = "0x4B49F0", VA = "0x1804B63F0")]
	private void Update()
	{
		this.PositionUpdate();
	}

	// Token: 0x06000389 RID: 905 RVA: 0x00010CA0 File Offset: 0x0000EEA0
	[Token(Token = "0x6000389")]
	[Address(RVA = "0x4B5F70", Offset = "0x4B4570", VA = "0x1804B5F70")]
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

	// Token: 0x0600038A RID: 906 RVA: 0x00010D88 File Offset: 0x0000EF88
	[Token(Token = "0x600038A")]
	[Address(RVA = "0x4B50D0", Offset = "0x4B36D0", VA = "0x1804B50D0")]
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

	// Token: 0x0600038B RID: 907 RVA: 0x00010E00 File Offset: 0x0000F000
	[Token(Token = "0x600038B")]
	[Address(RVA = "0x4B5090", Offset = "0x4B3690", VA = "0x1804B5090", Slot = "6")]
	public bool CanAttack(IDamageable target)
	{
		NotImplementedException ex = new NotImplementedException();
		return false;
	}

	// Token: 0x0600038C RID: 908 RVA: 0x00010E14 File Offset: 0x0000F014
	[Token(Token = "0x600038C")]
	[Address(RVA = "0x4B6460", Offset = "0x4B4A60", VA = "0x1804B6460")]
	public LoonNut()
	{
		List<float> list = new List();
		this.ys = list;
		base..ctor();
	}

	// Token: 0x040001DA RID: 474
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001DA")]
	public PlantType thePlantType;

	// Token: 0x040001DB RID: 475
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40001DB")]
	public int currentRow;

	// Token: 0x040001DC RID: 476
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001DC")]
	public int damage;

	// Token: 0x040001DD RID: 477
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001DD")]
	public SortingGroup sortingGroup;

	// Token: 0x040001DE RID: 478
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001DE")]
	public LoonNut.LoonDirection direction;

	// Token: 0x040001DF RID: 479
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40001DF")]
	private float damageMultiplier = 1f;

	// Token: 0x040001E0 RID: 480
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001E0")]
	private Animator anim;

	// Token: 0x040001E1 RID: 481
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001E1")]
	private Board board;

	// Token: 0x040001E2 RID: 482
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001E2")]
	private int hitCount;

	// Token: 0x040001E3 RID: 483
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40001E3")]
	private bool hit;

	// Token: 0x040001E4 RID: 484
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40001E4")]
	private readonly List<float> ys;

	// Token: 0x020000C5 RID: 197
	[Token(Token = "0x20000C5")]
	public enum LoonDirection
	{
		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		Right,
		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		Up,
		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		Down
	}
}
