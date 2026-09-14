using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000329 RID: 809
[Token(Token = "0x2000329")]
public class Potathisom : PotatoMine
{
	// Token: 0x06000EA9 RID: 3753 RVA: 0x0005392C File Offset: 0x00051B2C
	[Token(Token = "0x6000EA9")]
	[Address(RVA = "0x467B90", Offset = "0x466190", VA = "0x180467B90", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("unrised");
	}

	// Token: 0x06000EAA RID: 3754 RVA: 0x00053958 File Offset: 0x00051B58
	[Token(Token = "0x6000EAA")]
	[Address(RVA = "0x4675A0", Offset = "0x465BA0", VA = "0x1804675A0", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.AnimStartRise(0.5f);
		this.anim.SetTrigger("rise");
		this.invincible = true;
	}

	// Token: 0x06000EAB RID: 3755 RVA: 0x00053990 File Offset: 0x00051B90
	[Token(Token = "0x6000EAB")]
	[Address(RVA = "0x467AF0", Offset = "0x4660F0", VA = "0x180467AF0", Slot = "68")]
	protected override void PotatoUpdate()
	{
		base.SetFlash();
		float deltaTime = Time.deltaTime;
		this.flashTime = deltaTime;
		Animator anim = this.anim;
		this.flashTime = 0f;
		anim.Play("flash");
	}

	// Token: 0x06000EAC RID: 3756 RVA: 0x000539D8 File Offset: 0x00051BD8
	[Token(Token = "0x6000EAC")]
	[Address(RVA = "0x467610", Offset = "0x465C10", VA = "0x180467610", Slot = "73")]
	protected override void BombEffect()
	{
		int num3;
		do
		{
			int num = 0;
			int num2 = 0;
			base.Die((Plant.DieReason)num2);
			BoardAction boardAction = this.board.boardAction;
			int attackDamage = this.attackDamage;
			PlantType thePlantType = this.thePlantType;
			num3 = 0;
			Board board = this.board;
			Func<Plant, bool> <>9__4_ = Potathisom.<>c.<>9__4_0;
			if (<>9__4_ == 0)
			{
				Potathisom.<>c.<>9__4_0 = delegate(Plant plant)
				{
					if (plant.plantTag == (ulong)0L)
					{
						bool flag2;
						return flag2;
					}
					throw new NullReferenceException();
				};
			}
			uint num4;
			List<Vector2Int> randomFreeBoxes = Lawnf.GetRandomFreeBoxes(board, (int)num4, <>9__4_);
			bool flag;
			if (flag)
			{
				GameObject gameObject = this.seedPrefab;
				Transform axis = this.axis;
				Vector3 vector;
				float z = vector.z;
				Quaternion identityQuaternion = Quaternion.identityQuaternion;
				Transform transform = this.board.transform;
				GameObject gameObject2;
				PotatoSeed component = gameObject2.GetComponent<PotatoSeed>();
				component.theColumn = num;
				component.theRow = 0;
				Board board2 = this.board;
				component.board = board2;
				SortingGroup sortingGroup = component.AddComponent<SortingGroup>();
				int thePlantRow = this.thePlantRow;
				string text = string.Format("bullet{0}", sortingGroup);
				sortingGroup.sortingLayerName = text;
			}
		}
		while (num3 != 0);
	}

	// Token: 0x06000EAD RID: 3757 RVA: 0x00053AF8 File Offset: 0x00051CF8
	[Token(Token = "0x6000EAD")]
	[Address(RVA = "0x467BF0", Offset = "0x4661F0", VA = "0x180467BF0")]
	public Potathisom()
	{
		this.flashInterval = 3f;
		base..ctor();
	}

	// Token: 0x04000B37 RID: 2871
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000B37")]
	public GameObject seedPrefab;
}
