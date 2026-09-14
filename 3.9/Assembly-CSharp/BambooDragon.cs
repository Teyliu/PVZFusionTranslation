using System;
using System.Collections.Generic;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000351 RID: 849
[Token(Token = "0x2000351")]
public class BambooDragon : Shooter
{
	// Token: 0x06000F95 RID: 3989 RVA: 0x00059EF0 File Offset: 0x000580F0
	[Token(Token = "0x6000F95")]
	[Address(RVA = "0x470690", Offset = "0x46EC90", VA = "0x180470690")]
	private void StartShooting()
	{
		FireLine fireLine = this.fireLine;
		int num = 0;
		if (fireLine == num)
		{
			Transform shoot = this.shoot;
			GameObject gameObject = this.fireLinePrefab;
			Vector3 vector;
			float z = vector.z;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			GameObject gameObject2;
			FireLine component = gameObject2.GetComponent<FireLine>();
			this.fireLine = component;
			this.fireLine.auto = false;
			Transform transform = this.fireLine.transform;
			Transform transform2 = base.transform;
			transform.parentInternal = transform2;
		}
		SortingGroup component2 = this.fireLine.GetComponent<SortingGroup>();
		int thePlantRow = this.thePlantRow;
		string text = string.Format("particle{0}", component2);
		component2.sortingLayerName = text;
		component2.sortAtRoot = true;
		int thePlantRow2 = this.thePlantRow;
		SortingGroup sortingGroup = this.particle;
		string text2 = string.Format("particle{0}", thePlantRow2);
		sortingGroup.sortingLayerName = text2;
		this.fireLine.gameObject.SetActive(true);
		this.fireLine.InitFireLine();
		this.theStatus = (PlantStatus)((ulong)25L);
		GameAPP.PlaySound(42, 0.2f, 1f);
		bool flag = Lawnf.TravelAdvanced((AdvBuff)((uint)37));
		this.hitCount = (int)((uint)37);
	}

	// Token: 0x06000F96 RID: 3990 RVA: 0x0005A018 File Offset: 0x00058218
	[Token(Token = "0x6000F96")]
	[Address(RVA = "0x4704D0", Offset = "0x46EAD0", VA = "0x1804704D0", Slot = "43")]
	protected override GameObject SearchZombie()
	{
		Zombie zombie;
		int num;
		do
		{
			int size = this.board.zombieArray._size;
			if (size <= 0)
			{
				goto IL_0073;
			}
			zombie = this.board.zombieArray[size];
			num = 0;
		}
		while (!(zombie != num));
		while (zombie.isMindControlled)
		{
		}
		int thePlantRow = this.thePlantRow;
		while (zombie.theZombieRow != thePlantRow)
		{
		}
		Transform axis = zombie.axis;
		Transform axis2 = this.axis;
		Transform axis3 = zombie.axis;
		Transform axis4 = this.axis;
		return zombie.gameObject;
		IL_0073:
		throw new NullReferenceException();
	}

	// Token: 0x06000F97 RID: 3991 RVA: 0x0005A0A0 File Offset: 0x000582A0
	[Token(Token = "0x6000F97")]
	[Address(RVA = "0x46FFB0", Offset = "0x46E5B0", VA = "0x18046FFB0", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (base.Active)
		{
			uint num;
			GameAPP.PlaySound((int)num, 0.5f, 1f);
			List<Zombie> zombieArray = this.board.zombieArray;
			Transform axis = this.axis;
			int size = zombieArray._size;
			List<IceRoad> iceRoads = this.board.iceRoads;
			int thePlantRow = this.thePlantRow;
			IceRoad iceRoad = iceRoads[thePlantRow];
			List<IceRoad> iceRoads2 = this.board.iceRoads;
			int thePlantRow2 = this.thePlantRow;
			IceRoad iceRoad2 = iceRoads2[thePlantRow2];
			int attributeCount = this.attributeCount;
			int num2 = attributeCount + 1;
			this.attributeCount = num2;
			bool flag;
			if (!flag)
			{
			}
			uint num3;
			num3 += (uint)attributeCount;
			int num4 = 0;
			this.attributeCount = num4;
			if (this.hitCount != -1)
			{
			}
			if (size > 0)
			{
				Zombie zombie = this.board.zombieArray[size];
				int num5 = 0;
				if (zombie != num5 && (zombie.isMindControlled ? 1 : 0) == num4)
				{
					int thePlantRow3 = this.thePlantRow;
					if (zombie.theZombieRow == thePlantRow3)
					{
						Transform axis2 = zombie.axis;
						Transform axis3 = this.axis;
						Transform axis4 = zombie.axis;
						Board board = this.board;
						Transform axis5 = zombie.axis;
						BoardAction boardAction = board.boardAction;
						PlantType thePlantType = this.thePlantType;
						zombie.Warm();
						if (this.hitCount != -1)
						{
							int num6 = this.hitCount;
						}
					}
				}
			}
		}
	}

	// Token: 0x06000F98 RID: 3992 RVA: 0x0005A204 File Offset: 0x00058404
	[Token(Token = "0x6000F98")]
	[Address(RVA = "0x46FEB0", Offset = "0x46E4B0", VA = "0x18046FEB0")]
	private void EndShooting()
	{
		this.fireLine.Fade();
		this.theStatus = (PlantStatus)((ulong)0L);
		Board board = this.board;
		GameObject gameObject = this.flyingDragonPrefab;
		Transform transform = board.transform;
		FlyingDragon component = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform).GetComponent<FlyingDragon>();
		component.plant = this;
		Board board2 = this.board;
		component.board = board2;
		throw new NullReferenceException();
	}

	// Token: 0x06000F99 RID: 3993 RVA: 0x0005A264 File Offset: 0x00058464
	[Token(Token = "0x6000F99")]
	[Address(RVA = "0x4709E0", Offset = "0x46EFE0", VA = "0x1804709E0")]
	[ProButton]
	public void SummonFlying()
	{
		Board board = this.board;
		GameObject gameObject = this.flyingDragonPrefab;
		Transform transform = board.transform;
		FlyingDragon component = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform).GetComponent<FlyingDragon>();
		component.plant = this;
		Board board2 = this.board;
		component.board = board2;
		throw new NullReferenceException();
	}

	// Token: 0x06000F9A RID: 3994 RVA: 0x0005A2B0 File Offset: 0x000584B0
	[Token(Token = "0x6000F9A")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public BambooDragon()
	{
	}

	// Token: 0x04000B8F RID: 2959
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000B8F")]
	public GameObject fireLinePrefab;

	// Token: 0x04000B90 RID: 2960
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000B90")]
	public GameObject flyingDragonPrefab;

	// Token: 0x04000B91 RID: 2961
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000B91")]
	private FireLine fireLine;

	// Token: 0x04000B92 RID: 2962
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000B92")]
	public SortingGroup particle;

	// Token: 0x04000B93 RID: 2963
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000B93")]
	private int hitCount;
}
