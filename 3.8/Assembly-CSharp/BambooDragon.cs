using System;
using System.Collections.Generic;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000341 RID: 833
[Token(Token = "0x2000341")]
public class BambooDragon : Shooter
{
	// Token: 0x06000F4A RID: 3914 RVA: 0x00058F58 File Offset: 0x00057158
	[Token(Token = "0x6000F4A")]
	[Address(RVA = "0x4197C0", Offset = "0x417DC0", VA = "0x1804197C0")]
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

	// Token: 0x06000F4B RID: 3915 RVA: 0x00059080 File Offset: 0x00057280
	[Token(Token = "0x6000F4B")]
	[Address(RVA = "0x419600", Offset = "0x417C00", VA = "0x180419600", Slot = "44")]
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

	// Token: 0x06000F4C RID: 3916 RVA: 0x00059108 File Offset: 0x00057308
	[Token(Token = "0x6000F4C")]
	[Address(RVA = "0x4190E0", Offset = "0x4176E0", VA = "0x1804190E0", Slot = "17")]
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

	// Token: 0x06000F4D RID: 3917 RVA: 0x0005926C File Offset: 0x0005746C
	[Token(Token = "0x6000F4D")]
	[Address(RVA = "0x418FE0", Offset = "0x4175E0", VA = "0x180418FE0")]
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

	// Token: 0x06000F4E RID: 3918 RVA: 0x000592CC File Offset: 0x000574CC
	[Token(Token = "0x6000F4E")]
	[Address(RVA = "0x419B10", Offset = "0x418110", VA = "0x180419B10")]
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

	// Token: 0x06000F4F RID: 3919 RVA: 0x00059318 File Offset: 0x00057518
	[Token(Token = "0x6000F4F")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public BambooDragon()
	{
	}

	// Token: 0x04000B3E RID: 2878
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000B3E")]
	public GameObject fireLinePrefab;

	// Token: 0x04000B3F RID: 2879
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000B3F")]
	public GameObject flyingDragonPrefab;

	// Token: 0x04000B40 RID: 2880
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000B40")]
	private FireLine fireLine;

	// Token: 0x04000B41 RID: 2881
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000B41")]
	public SortingGroup particle;

	// Token: 0x04000B42 RID: 2882
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000B42")]
	private int hitCount;
}
