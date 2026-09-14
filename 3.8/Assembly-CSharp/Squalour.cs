using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000428 RID: 1064
[Token(Token = "0x2000428")]
public class Squalour : Squash
{
	// Token: 0x0600139A RID: 5018 RVA: 0x0006DDDC File Offset: 0x0006BFDC
	[Token(Token = "0x600139A")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "71")]
	protected override void Sound()
	{
	}

	// Token: 0x0600139B RID: 5019 RVA: 0x0006DDEC File Offset: 0x0006BFEC
	[Token(Token = "0x600139B")]
	[Address(RVA = "0x4683D0", Offset = "0x4669D0", VA = "0x1804683D0", Slot = "72")]
	protected override void ActionOnZombie(Zombie zombie)
	{
		int attackDamage = this.attackDamage;
		PlantType thePlantType = this.thePlantType;
		ulong num;
		zombie.TakeDamage(attackDamage, this, (DamageType)((uint)11), thePlantType, num != 0UL);
		this.squashed = true;
	}

	// Token: 0x0600139C RID: 5020 RVA: 0x0006DE24 File Offset: 0x0006C024
	[Token(Token = "0x600139C")]
	[Address(RVA = "0x468770", Offset = "0x466D70", VA = "0x180468770", Slot = "73")]
	protected override void AttackZombie()
	{
		if (!this.skin)
		{
			base.AttackZombie();
			return;
		}
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		base.AttackZombie();
		Transform axis2 = this.axis;
		Vector3 vector2;
		float z2 = vector2.z;
	}

	// Token: 0x0600139D RID: 5021 RVA: 0x0006DE6C File Offset: 0x0006C06C
	[Token(Token = "0x600139D")]
	[Address(RVA = "0x468890", Offset = "0x466E90", VA = "0x180468890")]
	private void LourDie()
	{
		int num = 0;
		CreatePlant instance = CreatePlant.Instance;
		int num2 = this.thePlantColumn;
		int i = this.thePlantColumn;
		num2++;
		Board board = this.board;
		if (i < board.columnNum)
		{
			int j = this.thePlantRow;
			int num3 = this.thePlantRow;
			num3++;
			Board board2 = this.board;
			if (j < board2.rowNum)
			{
				CreatePlant instance2 = CreatePlant.Instance;
			}
			int num4 = this.thePlantRow;
			j++;
			num4++;
			while (j <= num4)
			{
			}
		}
		int num5 = this.thePlantColumn;
		i++;
		num5++;
		while (i <= num5)
		{
		}
		Transform axis = this.axis;
		Vector3 vector;
		float y = vector.y;
		if ((this.squashed ? 1 : 0) != num)
		{
			int num6 = this.squashCount;
			if (num < 3)
			{
				num++;
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600139E RID: 5022 RVA: 0x0006DF44 File Offset: 0x0006C144
	[Token(Token = "0x600139E")]
	[Address(RVA = "0x468440", Offset = "0x466A40", VA = "0x180468440", Slot = "74")]
	protected override void AnimMove()
	{
		if (this.skin)
		{
			global::UnityEngine.Object.Destroy(this.axis.GetComponent<SpriteRenderer>());
			this.freeMoving = false;
			base.RemoveFromList();
			bool flag;
			if (flag)
			{
				int thePlantRow = this.thePlantRow;
				string text = string.Format("bullet{0}", thePlantRow);
			}
			Zombie targetZombie = this.targetZombie;
			int num = 0;
			if (!(targetZombie != num))
			{
				Transform axis = this.axis;
			}
			Zombie component = this.targetZombie.GetComponent<Zombie>();
			int theZombieRow = component.theZombieRow;
			this.thePlantRow = theZombieRow;
			float time = Time.time;
			this.endTime = time;
			Transform axis2 = component.axis;
			Vector3 vector;
			float z = vector.z;
			this.endPos.y = time;
			Vector2 startJumpPos = this.startJumpPos;
			Transform axis3 = component.axis;
			int num2 = 0;
			Squash.<MoveToZombie>d__17 <MoveToZombie>d__;
			<MoveToZombie>d__.System.IDisposable.Dispose();
			<MoveToZombie>d__.<>1__state = (int)((ulong)0L);
			<MoveToZombie>d__.<>4__this = this;
			<MoveToZombie>d__.endPos.z = (float)num2;
			<MoveToZombie>d__.speed = 8f;
			Coroutine coroutine = base.StartCoroutine(<MoveToZombie>d__);
			return;
		}
		base.AnimMove();
	}

	// Token: 0x0600139F RID: 5023 RVA: 0x0006E060 File Offset: 0x0006C260
	[Token(Token = "0x600139F")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public Squalour()
	{
	}

	// Token: 0x04000C78 RID: 3192
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000C78")]
	public bool skin;

	// Token: 0x04000C79 RID: 3193
	[FieldOffset(Offset = "0x244")]
	[Token(Token = "0x4000C79")]
	private int squashCount;

	// Token: 0x04000C7A RID: 3194
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000C7A")]
	private bool squashed;
}
