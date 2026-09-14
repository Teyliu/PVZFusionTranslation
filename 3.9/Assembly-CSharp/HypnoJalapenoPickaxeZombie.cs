using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020006B3 RID: 1715
[Token(Token = "0x20006B3")]
public class HypnoJalapenoPickaxeZombie : Pickaxe_b
{
	// Token: 0x060020E3 RID: 8419 RVA: 0x000ADCD8 File Offset: 0x000ABED8
	[Token(Token = "0x60020E3")]
	[Address(RVA = "0x5B2EC0", Offset = "0x5B14C0", VA = "0x1805B2EC0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)12L);
		this.digSpeed = 10f;
	}

	// Token: 0x060020E4 RID: 8420 RVA: 0x000ADD00 File Offset: 0x000ABF00
	[Token(Token = "0x60020E4")]
	[Address(RVA = "0x5B2F90", Offset = "0x5B1590", VA = "0x1805B2F90", Slot = "76")]
	protected override void RiseUpdate()
	{
		int column = base.Column;
		base.Rise();
		Transform axis = this.axis;
		this.towards = (Towards)((ulong)1L);
		Vector3 vector;
		float z = vector.z;
		Transform transform = base.transform;
		float num = global::UnityEngine.Random.Range(13.22f, 22.68f);
		this.attributeCountDown = num;
		List<GameObject> theUniqueItems = this.theUniqueItems;
		int num2 = 0;
		GameObject gameObject = theUniqueItems[num2];
		int num3 = 0;
		if (gameObject == num3)
		{
			base.Rise();
		}
	}

	// Token: 0x060020E5 RID: 8421 RVA: 0x000ADD88 File Offset: 0x000ABF88
	[Token(Token = "0x60020E5")]
	[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0", Slot = "39")]
	protected override void PlayEatSound2()
	{
		List<GameObject> theUniqueItems = this.theUniqueItems;
		int num = 0;
		GameObject gameObject = theUniqueItems[num];
		int num2 = 0;
		if (!(gameObject == num2))
		{
			base.PlayEatSound2();
			return;
		}
		base.PlayEatSound();
	}

	// Token: 0x060020E6 RID: 8422 RVA: 0x000ADDC8 File Offset: 0x000ABFC8
	[Token(Token = "0x60020E6")]
	[Address(RVA = "0x5B2D20", Offset = "0x5B1320", VA = "0x1805B2D20", Slot = "24")]
	protected override void AttributeEvent()
	{
		base.Die(2);
		BoardAction boardAction = this.board.boardAction;
		int num = this.theZombieRow;
		boardAction.CreateFireLineVision(num);
		int size = this.board.zombieArray._size;
		int num2 = size - 1;
		if (size > 0)
		{
			List<Zombie> zombieArray = this.board.zombieArray;
			num = num2;
			Zombie zombie = zombieArray[num];
			int num3 = 0;
			if (zombie != num3 && zombie.isMindControlled)
			{
				int theZombieRow = this.theZombieRow;
				if (zombie.theZombieRow == theZombieRow)
				{
				}
			}
		}
	}

	// Token: 0x060020E7 RID: 8423 RVA: 0x000ADE5C File Offset: 0x000AC05C
	[Token(Token = "0x60020E7")]
	[Address(RVA = "0x5B3140", Offset = "0x5B1740", VA = "0x1805B3140", Slot = "19")]
	protected override void ZombieUpdate()
	{
		IDamageable theAttackTarget = this.theAttackTarget;
		List<GameObject> theUniqueItems = this.theUniqueItems;
		int num = 0;
		GameObject gameObject = theUniqueItems[num];
		int num2 = 0;
		if (gameObject != num2)
		{
			float digSpeed = this.digSpeed;
			float deltaTime = Time.deltaTime;
			this.progress = deltaTime;
			this.progress = 0f;
			GameObject gameObject2 = this.progressText.gameObject;
			gameObject2.SetActive(true);
			SortingGroup textGroup = this.textGroup;
			string text = string.Format("bullet{0}", gameObject2);
			textGroup.sortingLayerName = text;
			float num3 = this.progress * 100f;
			TextMeshPro progressText = this.progressText;
			string text2 = string.Format("{0:F0}%", text);
			progressText.text = text2;
			GameObject gameObject3 = this.progressText.gameObject;
			Transform transform = gameObject3.transform;
			Vector3 vector;
			float z = vector.z;
			int num4 = 0;
			if (this.progress > (float)num4)
			{
				base.CancelAttack();
			}
			base.CancelAttack();
			List<ZombieType> list = this.hypnoZombies;
			CreateZombie instance = CreateZombie.Instance;
			int num5 = list._size;
			num5 = global::UnityEngine.Random.Range(0, num5);
			ZombieType zombieType = list[num5];
		}
	}

	// Token: 0x060020E8 RID: 8424 RVA: 0x000ADF88 File Offset: 0x000AC188
	[Token(Token = "0x60020E8")]
	[Address(RVA = "0x5B35C0", Offset = "0x5B1BC0", VA = "0x1805B35C0")]
	public HypnoJalapenoPickaxeZombie()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		this.hypnoZombies = list;
		base..ctor();
	}

	// Token: 0x04001181 RID: 4481
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x4001181")]
	private readonly List<ZombieType> hypnoZombies;
}
