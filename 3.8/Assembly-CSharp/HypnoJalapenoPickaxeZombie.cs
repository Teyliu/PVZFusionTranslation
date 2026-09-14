using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200067D RID: 1661
[Token(Token = "0x200067D")]
public class HypnoJalapenoPickaxeZombie : Pickaxe_b
{
	// Token: 0x06001FE1 RID: 8161 RVA: 0x000A93C8 File Offset: 0x000A75C8
	[Token(Token = "0x6001FE1")]
	[Address(RVA = "0x54F330", Offset = "0x54D930", VA = "0x18054F330", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)12L);
		this.digSpeed = 10f;
	}

	// Token: 0x06001FE2 RID: 8162 RVA: 0x000A93F0 File Offset: 0x000A75F0
	[Token(Token = "0x6001FE2")]
	[Address(RVA = "0x54F400", Offset = "0x54DA00", VA = "0x18054F400", Slot = "74")]
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

	// Token: 0x06001FE3 RID: 8163 RVA: 0x000A9478 File Offset: 0x000A7678
	[Token(Token = "0x6001FE3")]
	[Address(RVA = "0x54F360", Offset = "0x54D960", VA = "0x18054F360", Slot = "37")]
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

	// Token: 0x06001FE4 RID: 8164 RVA: 0x000A94B8 File Offset: 0x000A76B8
	[Token(Token = "0x6001FE4")]
	[Address(RVA = "0x54F190", Offset = "0x54D790", VA = "0x18054F190", Slot = "23")]
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

	// Token: 0x06001FE5 RID: 8165 RVA: 0x000A954C File Offset: 0x000A774C
	[Token(Token = "0x6001FE5")]
	[Address(RVA = "0x54F5B0", Offset = "0x54DBB0", VA = "0x18054F5B0", Slot = "18")]
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

	// Token: 0x06001FE6 RID: 8166 RVA: 0x000A9678 File Offset: 0x000A7878
	[Token(Token = "0x6001FE6")]
	[Address(RVA = "0x54FA30", Offset = "0x54E030", VA = "0x18054FA30")]
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

	// Token: 0x040010B4 RID: 4276
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x40010B4")]
	private readonly List<ZombieType> hypnoZombies;
}
