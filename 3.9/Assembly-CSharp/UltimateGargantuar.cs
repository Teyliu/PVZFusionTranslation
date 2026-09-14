using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200072F RID: 1839
[Token(Token = "0x200072F")]
public class UltimateGargantuar : SuperGargantuar
{
	// Token: 0x06002479 RID: 9337 RVA: 0x000BDC04 File Offset: 0x000BBE04
	[Token(Token = "0x6002479")]
	[Address(RVA = "0x5FE200", Offset = "0x5FC800", VA = "0x1805FE200", Slot = "16")]
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

	// Token: 0x0600247A RID: 9338 RVA: 0x000BDC64 File Offset: 0x000BBE64
	[Token(Token = "0x600247A")]
	[Address(RVA = "0x5FDA50", Offset = "0x5FC050", VA = "0x1805FDA50", Slot = "77")]
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

	// Token: 0x0600247B RID: 9339 RVA: 0x000BDD38 File Offset: 0x000BBF38
	[Token(Token = "0x600247B")]
	[Address(RVA = "0x5FDD50", Offset = "0x5FC350", VA = "0x1805FDD50", Slot = "29")]
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
	}

	// Token: 0x0600247C RID: 9340 RVA: 0x000BDDE8 File Offset: 0x000BBFE8
	[Token(Token = "0x600247C")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x0600247D RID: 9341 RVA: 0x000BDDF8 File Offset: 0x000BBFF8
	[Token(Token = "0x600247D")]
	[Address(RVA = "0x5FDFC0", Offset = "0x5FC5C0", VA = "0x1805FDFC0", Slot = "81")]
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

	// Token: 0x0600247E RID: 9342 RVA: 0x000BDE8C File Offset: 0x000BC08C
	[Token(Token = "0x600247E")]
	[Address(RVA = "0x5FE3B0", Offset = "0x5FC9B0", VA = "0x1805FE3B0")]
	public UltimateGargantuar()
	{
	}
}
