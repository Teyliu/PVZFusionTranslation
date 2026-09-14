using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000447 RID: 1095
[Token(Token = "0x2000447")]
public class Squalour : Squash
{
	// Token: 0x06001424 RID: 5156 RVA: 0x00070084 File Offset: 0x0006E284
	[Token(Token = "0x6001424")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "70")]
	protected override void Sound()
	{
	}

	// Token: 0x06001425 RID: 5157 RVA: 0x00070094 File Offset: 0x0006E294
	[Token(Token = "0x6001425")]
	[Address(RVA = "0x4BF3C0", Offset = "0x4BD9C0", VA = "0x1804BF3C0", Slot = "71")]
	protected override void ActionOnZombie(Zombie zombie)
	{
		int attackDamage = this.attackDamage;
		PlantType thePlantType = this.thePlantType;
		ulong num;
		zombie.TakeDamage(attackDamage, this, (DamageType)((uint)11), thePlantType, num != 0UL);
		this.squashed = true;
	}

	// Token: 0x06001426 RID: 5158 RVA: 0x000700CC File Offset: 0x0006E2CC
	[Token(Token = "0x6001426")]
	[Address(RVA = "0x4BF760", Offset = "0x4BDD60", VA = "0x1804BF760", Slot = "72")]
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

	// Token: 0x06001427 RID: 5159 RVA: 0x00070114 File Offset: 0x0006E314
	[Token(Token = "0x6001427")]
	[Address(RVA = "0x4BF880", Offset = "0x4BDE80", VA = "0x1804BF880")]
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

	// Token: 0x06001428 RID: 5160 RVA: 0x000701EC File Offset: 0x0006E3EC
	[Token(Token = "0x6001428")]
	[Address(RVA = "0x4BF430", Offset = "0x4BDA30", VA = "0x1804BF430", Slot = "73")]
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

	// Token: 0x06001429 RID: 5161 RVA: 0x00070308 File Offset: 0x0006E508
	[Token(Token = "0x6001429")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public Squalour()
	{
	}

	// Token: 0x04000D02 RID: 3330
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000D02")]
	public bool skin;

	// Token: 0x04000D03 RID: 3331
	[FieldOffset(Offset = "0x244")]
	[Token(Token = "0x4000D03")]
	private int squashCount;

	// Token: 0x04000D04 RID: 3332
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000D04")]
	private bool squashed;
}
