using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000497 RID: 1175
[Token(Token = "0x2000497")]
public class UltimateIceDoom : Plant
{
	// Token: 0x060015C6 RID: 5574 RVA: 0x00077C6C File Offset: 0x00075E6C
	[Token(Token = "0x60015C6")]
	[Address(RVA = "0x4E1F90", Offset = "0x4E0590", VA = "0x1804E1F90", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.UpdateSprite();
	}

	// Token: 0x060015C7 RID: 5575 RVA: 0x00077C88 File Offset: 0x00075E88
	[Token(Token = "0x60015C7")]
	[Address(RVA = "0x4E1CC0", Offset = "0x4E02C0", VA = "0x1804E1CC0", Slot = "35")]
	protected override bool OnCrash()
	{
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		this.Explode(thePlantColumn, thePlantRow);
		return true;
	}

	// Token: 0x060015C8 RID: 5576 RVA: 0x00077CAC File Offset: 0x00075EAC
	[Token(Token = "0x60015C8")]
	[Address(RVA = "0x4E15A0", Offset = "0x4DFBA0", VA = "0x1804E15A0", Slot = "39")]
	protected override void AttributeEvent()
	{
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		this.Explode(thePlantColumn, thePlantRow);
	}

	// Token: 0x060015C9 RID: 5577 RVA: 0x00077CD0 File Offset: 0x00075ED0
	[Token(Token = "0x60015C9")]
	[Address(RVA = "0x4E1CE0", Offset = "0x4E02E0", VA = "0x1804E1CE0")]
	public void SetTarget(int theColumn, int theRow)
	{
		int num = 0;
		int num2 = 0;
		base.AttributeCountdown = (float)num;
		this.anim.SetTrigger("portal");
		GameAPP.PlaySound(95, 0.5f, 1f);
		this.targetColumn = theColumn;
		this.targetRow = theRow;
		float boxXFromColumn = Lawnf.GetBoxXFromColumn(this.targetColumn);
		Mouse instance = Mouse.Instance;
		int num3 = this.targetRow;
		float landY = instance.GetLandY(boxXFromColumn, num3);
		Transform transform = this.portalOut.transform;
		ParticleManager instance2 = ParticleManager.Instance;
		Transform transform2 = this.portalIn.transform;
		int num4 = 0;
		Vector3 vector;
		float z = vector.z;
		ulong num5;
		Particle particle = instance2.SetParticle(ParticleType.RandomCloud, num4, 11, num5 != 0UL, (float)num2);
		ParticleManager instance3 = ParticleManager.Instance;
		Transform transform3 = this.portalOut.transform;
		int num6 = 0;
		ulong num7;
		Particle particle2 = instance3.SetParticle(ParticleType.RandomCloud, num6, 11, num7 != 0UL, (float)num2);
	}

	// Token: 0x060015CA RID: 5578 RVA: 0x00077DB4 File Offset: 0x00075FB4
	[Token(Token = "0x60015CA")]
	[Address(RVA = "0x4E1520", Offset = "0x4DFB20", VA = "0x1804E1520")]
	private void AnimPortal()
	{
		int num = this.targetRow;
		int num2 = this.targetColumn;
		this.Explode(num2, num);
	}

	// Token: 0x060015CB RID: 5579 RVA: 0x00077DD8 File Offset: 0x00075FD8
	[Token(Token = "0x60015CB")]
	[Address(RVA = "0x4E1540", Offset = "0x4DFB40", VA = "0x1804E1540")]
	private void AnimPreExplode()
	{
		GameAPP.PlaySound(39, 0.5f, 1f);
	}

	// Token: 0x060015CC RID: 5580 RVA: 0x00077DF8 File Offset: 0x00075FF8
	[Token(Token = "0x60015CC")]
	[Address(RVA = "0x4E1C70", Offset = "0x4E0270", VA = "0x1804E1C70")]
	public bool LevelUp()
	{
		int num = this.attributeCount;
		num++;
		this.attributeCount = num;
		if (num == 2)
		{
			base.AttributeCountdown = 10f;
		}
		this.UpdateSprite();
		return true;
	}

	// Token: 0x060015CD RID: 5581 RVA: 0x00077E34 File Offset: 0x00076034
	[Token(Token = "0x60015CD")]
	[Address(RVA = "0x4E15C0", Offset = "0x4DFBC0", VA = "0x1804E15C0")]
	private void Explode(int theColumn, int theRow)
	{
		int num = 0;
		base.Die((Plant.DieReason)num);
		int attributeCount = this.attributeCount;
		int attackDamage = this.attackDamage;
		if (attributeCount != 0)
		{
			if (attributeCount != 0)
			{
				if (attributeCount != 1)
				{
					goto IL_00EA;
				}
				this.board.iceDoomFreezeTime = 10f;
				int num2 = 0;
				List<Zombie> zombiesByRow = Lawnf.GetZombiesByRow(theRow, num2 != 0);
				Func<Zombie, bool> func = (Zombie z) => z.Column == theColumn;
				IEnumerable<Zombie> enumerable = Enumerable.Where<Zombie>(zombiesByRow, func);
				Func<Zombie, long> <>9__13_ = UltimateIceDoom.<>c.<>9__13_1;
				if (<>9__13_ == 0)
				{
					Func<Zombie, long> func2;
					UltimateIceDoom.<>c.<>9__13_1 = func2;
				}
				Zombie zombie = Enumerable.FirstOrDefault<Zombie>(Enumerable.OrderByDescending<Zombie, long>(enumerable, <>9__13_));
				int num3 = 0;
				if (zombie != num3)
				{
					zombie.SetPortaled(30f);
					num3 += num3;
				}
				Transform axis = this.axis;
				Vector3 vector;
				float z3 = vector.z;
			}
			this.board.iceDoomFreezeTime = 3f;
		}
		this.board.iceDoomFreezeTime = 1f;
		IL_00EA:
		Board board = this.board;
		this._dmg = attackDamage;
		BoardAction boardAction = board.boardAction;
		PlantType thePlantType = this.thePlantType;
		float num4 = Lawnf.GetBoxXFromColumn(theColumn);
		float num5 = Mouse.Instance.GetLandY(num4, theRow);
		Board board2 = this.board;
		num5 = num4;
		if (this.portalIn.activeSelf)
		{
			ParticleManager instance = ParticleManager.Instance;
			Transform transform = this.portalIn.transform;
			Vector3 vector2;
			float z2 = vector2.z;
			ParticleManager instance2 = ParticleManager.Instance;
			Transform transform2 = this.portalOut.transform;
			num4 = num5;
		}
		int attackDamage2 = this.attackDamage;
		bool flag;
		uint num7;
		if (!flag)
		{
			uint num6;
			ConnectPortal connectPortal = ConnectPortal.CreatePortalGroups((int)num6, (int)num7, num4, 4f, attackDamage2);
			return;
		}
		num7 += num7;
		throw new NullReferenceException();
	}

	// Token: 0x060015CE RID: 5582 RVA: 0x00077FF0 File Offset: 0x000761F0
	[Token(Token = "0x60015CE")]
	[Address(RVA = "0x4E1420", Offset = "0x4DFA20", VA = "0x1804E1420")]
	private void ActionOnZombie(Zombie zombie)
	{
		bool flag;
		if (!flag)
		{
			zombie.SetPortaled(4f);
			return;
		}
		int dmg = this._dmg;
	}

	// Token: 0x060015CF RID: 5583 RVA: 0x0007801C File Offset: 0x0007621C
	[Token(Token = "0x60015CF")]
	[Address(RVA = "0x4E1FB0", Offset = "0x4E05B0", VA = "0x1804E1FB0")]
	private void UpdateSprite()
	{
		for (;;)
		{
			int num = 0;
			int attributeCount = this.attributeCount;
			if (attributeCount == 0 || attributeCount != 1)
			{
				List<GameObject> list = this.bodies;
				bool flag;
				if (flag)
				{
					Lawnf.ChangeSprite(3f, 3f, num);
				}
				ulong num2;
				if (num2 != (ulong)0L)
				{
					continue;
				}
			}
			List<GameObject> list2 = this.bodies;
			bool flag2;
			ulong num3;
			if (flag2)
			{
				Lawnf.ChangeSprite((float)num3, 3f, num);
			}
			if (num3 == (ulong)0L)
			{
				bool flag3;
				if (flag3)
				{
					Lawnf.ChangeSprite(1f, 3f, num);
				}
				ulong num4;
				if (num4 == (ulong)0L)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060015D0 RID: 5584 RVA: 0x000780A0 File Offset: 0x000762A0
	[Token(Token = "0x60015D0")]
	[Address(RVA = "0x4E22A0", Offset = "0x4E08A0", VA = "0x1804E22A0")]
	public UltimateIceDoom()
	{
		List<GameObject> list = new List();
		this.bodies = list;
		base..ctor();
	}

	// Token: 0x04000D90 RID: 3472
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000D90")]
	public GameObject targetPrefab;

	// Token: 0x04000D91 RID: 3473
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000D91")]
	public List<GameObject> bodies;

	// Token: 0x04000D92 RID: 3474
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000D92")]
	public GameObject portalIn;

	// Token: 0x04000D93 RID: 3475
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000D93")]
	public GameObject portalOut;

	// Token: 0x04000D94 RID: 3476
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000D94")]
	private int targetColumn;

	// Token: 0x04000D95 RID: 3477
	[FieldOffset(Offset = "0x23C")]
	[Token(Token = "0x4000D95")]
	private int targetRow;

	// Token: 0x04000D96 RID: 3478
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000D96")]
	private int _dmg;
}
