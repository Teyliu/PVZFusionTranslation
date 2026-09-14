using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006F7 RID: 1783
[Token(Token = "0x20006F7")]
public class UltimateGargantuar : SuperGargantuar
{
	// Token: 0x0600235D RID: 9053 RVA: 0x000B8FF4 File Offset: 0x000B71F4
	[Token(Token = "0x600235D")]
	[Address(RVA = "0x585380", Offset = "0x583980", VA = "0x180585380", Slot = "15")]
	protected override void Start()
	{
		int num2;
		do
		{
			int num = 0;
			base.Start();
			this.board.punishTime = 100000f;
			Board board = this.board;
			Lawnf.SetZombieHealth(this, (float)num);
			List<Zombie> allZombies = Lawnf.GetAllZombies(this.isMindControlled);
			num2 = 0;
			bool flag;
			if (flag)
			{
			}
		}
		while (num2 != 0);
	}

	// Token: 0x0600235E RID: 9054 RVA: 0x000B905C File Offset: 0x000B725C
	[Token(Token = "0x600235E")]
	[Address(RVA = "0x584BA0", Offset = "0x5831A0", VA = "0x180584BA0", Slot = "75")]
	protected override Zombie AnimThrow()
	{
		Transform transform = base.transform.Find("Shoot");
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = Resources.Load<GameObject>("Zombies/Gargantuar/UltimateGargantuar/UltimateBall");
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform2 = this.board.transform;
		GameObject gameObject2;
		SpriteRenderer component = gameObject2.GetComponent<SpriteRenderer>();
		int sortingLayerID = this.sortingGroup.sortingLayerID;
		component.sortingLayerID = sortingLayerID;
		SpriteRenderer component2 = gameObject2.GetComponent<SpriteRenderer>();
		int num = this.sortingGroup.sortingOrder + 1;
		component2.sortingOrder = num;
		SuperBall component3 = gameObject2.GetComponent<SuperBall>();
		int theZombieRow = this.theZombieRow;
		component3.theRow = theZombieRow;
		Transform transform3 = base.transform;
		int num2 = 0;
		global::UnityEngine.Object.Destroy(transform3.GetChild(num2).GetChild(2).gameObject);
		throw new NullReferenceException();
	}

	// Token: 0x0600235F RID: 9055 RVA: 0x000B9130 File Offset: 0x000B7330
	[Token(Token = "0x600235F")]
	[Address(RVA = "0x584EA0", Offset = "0x5834A0", VA = "0x180584EA0", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		int num3;
		do
		{
			Zombie next = this.next;
			int num = 0;
			if (!(next == num))
			{
				break;
			}
			Zombie pre = this.pre;
			int num2 = 0;
			if (!(pre == num2))
			{
				break;
			}
			List<Zombie> allZombies = Lawnf.GetAllZombies(this.isMindControlled);
			num3 = 0;
			bool flag;
			if (flag)
			{
			}
		}
		while (num3 != 0);
		int num4 = 0;
		if (Lawnf.TravelDebuff((TravelDebuff)((uint)3001)))
		{
			CreateZombie instance = CreateZombie.Instance;
			int num5 = 0;
			ulong num6;
			Lawnf.SetZombieHealth(instance.SetZombie(num5, (ZombieType)((uint)44), (float)num4, num6 != 0UL), 10f);
			this.board.punishTime = 100000f;
		}
		bool flag2 = Lawnf.TravelAdvanced((AdvBuff)((uint)2007));
	}

	// Token: 0x06002360 RID: 9056 RVA: 0x000B91E8 File Offset: 0x000B73E8
	[Token(Token = "0x6002360")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x06002361 RID: 9057 RVA: 0x000B91F8 File Offset: 0x000B73F8
	[Token(Token = "0x6002361")]
	[Address(RVA = "0x585140", Offset = "0x583740", VA = "0x180585140", Slot = "79")]
	protected override void SetImps()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		int num = 0;
		GameObject gameObject;
		if (gameObject > 0)
		{
			int theZombieRow = this.theZombieRow;
			CreateZombie instance = CreateZombie.Instance;
			float num2 = global::UnityEngine.Random.Range(-1f, 1f);
			Zombie zombie = instance.SetZombie(theZombieRow, (ZombieType)((uint)213), float.Epsilon, num != 0);
			int num3 = 0;
			if (zombie != num3)
			{
				Board board = this.board;
				Zombie component = zombie.GetComponent<Zombie>();
				board.SetHealthInTravel(component);
			}
			num++;
		}
	}

	// Token: 0x06002362 RID: 9058 RVA: 0x000B928C File Offset: 0x000B748C
	[Token(Token = "0x6002362")]
	[Address(RVA = "0x5855E0", Offset = "0x583BE0", VA = "0x1805855E0")]
	public UltimateGargantuar()
	{
	}
}
