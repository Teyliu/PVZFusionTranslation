using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000319 RID: 793
[Token(Token = "0x2000319")]
public class Potathisom : PotatoMine
{
	// Token: 0x06000E5F RID: 3679 RVA: 0x00052934 File Offset: 0x00050B34
	[Token(Token = "0x6000E5F")]
	[Address(RVA = "0x412510", Offset = "0x410B10", VA = "0x180412510", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("unrised");
	}

	// Token: 0x06000E60 RID: 3680 RVA: 0x00052960 File Offset: 0x00050B60
	[Token(Token = "0x6000E60")]
	[Address(RVA = "0x411F20", Offset = "0x410520", VA = "0x180411F20", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.AnimStartRise(0.5f);
		this.anim.SetTrigger("rise");
		this.invincible = true;
	}

	// Token: 0x06000E61 RID: 3681 RVA: 0x00052998 File Offset: 0x00050B98
	[Token(Token = "0x6000E61")]
	[Address(RVA = "0x412470", Offset = "0x410A70", VA = "0x180412470", Slot = "69")]
	protected override void PotatoUpdate()
	{
		base.SetFlash();
		float deltaTime = Time.deltaTime;
		this.flashTime = deltaTime;
		Animator anim = this.anim;
		this.flashTime = 0f;
		anim.Play("flash");
	}

	// Token: 0x06000E62 RID: 3682 RVA: 0x000529E0 File Offset: 0x00050BE0
	[Token(Token = "0x6000E62")]
	[Address(RVA = "0x411F90", Offset = "0x410590", VA = "0x180411F90", Slot = "74")]
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
				Func<Plant, bool> func;
				Potathisom.<>c.<>9__4_0 = func;
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

	// Token: 0x06000E63 RID: 3683 RVA: 0x00052AF0 File Offset: 0x00050CF0
	[Token(Token = "0x6000E63")]
	[Address(RVA = "0x401F90", Offset = "0x400590", VA = "0x180401F90")]
	public Potathisom()
	{
		this.flashInterval = 3f;
		base..ctor();
	}

	// Token: 0x04000AE6 RID: 2790
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000AE6")]
	public GameObject seedPrefab;
}
