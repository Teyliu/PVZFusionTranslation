using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000997 RID: 2455
[Token(Token = "0x2000997")]
[Serializable]
public class NewEveData
{
	// Token: 0x06003208 RID: 12808 RVA: 0x00107BE4 File Offset: 0x00105DE4
	[Token(Token = "0x6003208")]
	[Address(RVA = "0x6F13F0", Offset = "0x6EF9F0", VA = "0x1806F13F0")]
	public void GetBuff(EveBuff eveBuff, int row)
	{
		int size = this.eveBuffs[row]._size;
		if (row == 0 || row == 0 || row == 0 || row == 0 || row == 1)
		{
			List<EveBuff> list = this.buff1;
		}
	}

	// Token: 0x06003209 RID: 12809 RVA: 0x00107C28 File Offset: 0x00105E28
	[Token(Token = "0x6003209")]
	[Address(RVA = "0x6F1510", Offset = "0x6EFB10", VA = "0x1806F1510")]
	public void GetPoint(int row, int point)
	{
		bool flag;
		if (point != 5 && flag)
		{
			int num = 0;
			if (row > 0)
			{
				CreateZombie instance = CreateZombie.Instance;
				int num2 = row - 1;
			}
			int rowNum = Board.Instance.rowNum;
			if (row < rowNum)
			{
				CreateZombie instance2 = CreateZombie.Instance;
			}
			num++;
		}
		List<List<EveBuff>> list = this.eveBuffs;
		List<EveBuff> list2 = list[row];
		List<int> list3 = this.points;
		int num3 = list3[row];
		list3[row] = point;
	}

	// Token: 0x0600320A RID: 12810 RVA: 0x00107CA0 File Offset: 0x00105EA0
	[Token(Token = "0x600320A")]
	[Address(RVA = "0x6F1360", Offset = "0x6EF960", VA = "0x1806F1360")]
	public bool CheckBuff(EveBuff eveBuff, int row)
	{
		List<EveBuff> list = this.eveBuffs[row];
		bool flag;
		return flag;
	}

	// Token: 0x0600320B RID: 12811 RVA: 0x00107CC4 File Offset: 0x00105EC4
	[Token(Token = "0x600320B")]
	[Address(RVA = "0x6F1740", Offset = "0x6EFD40", VA = "0x1806F1740")]
	public NewEveData()
	{
		List<int> list = new List();
		int size = list._size;
		int num = 0;
		list._size = 1;
		list._syncRoot = num;
		int size2 = list._size;
		list._size = 1;
		int size3 = list._size;
		list._size = 1;
		int size4 = list._size;
		list._size = 1;
		int size5 = list._size;
		list._size = 1;
		this.points = list;
		List<int> list2 = new List();
		int size6 = list2._size;
		int size7 = list2._size;
		int size8 = list2._size;
		int size9 = list2._size;
		int size10 = list2._size;
		this.recoverTimes = list2;
		List<float> list3 = new List();
		int num2 = list3._size + 1;
		list3._size = num2;
		list3._syncRoot = num;
		int size11 = list3._size;
		list3._size = num2;
		int size12 = list3._size;
		list3._size = num2;
		int size13 = list3._size;
		list3._size = num2;
		int size14 = list3._size;
		list3._size = num2;
		this.longDamageAdder = list3;
		List<List<EveBuff>> list4 = new List();
		List<EveBuff> list5 = new List();
		int size15 = list4._size;
		list5._syncRoot = list5;
		List<EveBuff> list6 = new List();
		int size16 = list4._size;
		list6._syncRoot = list6;
		List<EveBuff> list7 = new List();
		int size17 = list4._size;
		list7._syncRoot = list7;
		List<EveBuff> list8 = new List();
		int size18 = list4._size;
		list8._syncRoot = list8;
		List<EveBuff> list9 = new List();
		int size19 = list4._size;
		list9._syncRoot = list9;
		this.eveBuffs = list4;
		List<EveZombieBuff> list10 = new List();
		this.zombieBuffs = list10;
		List<EveBuff> list11 = new List();
		this.buff1 = list11;
		List<EveBuff> list12 = new List();
		this.buff2 = list12;
		List<EveBuff> list13 = new List();
		this.buff3 = list13;
		List<EveBuff> list14 = new List();
		this.buff4 = list14;
		List<EveBuff> list15 = new List();
		this.buff5 = list15;
		base..ctor();
	}

	// Token: 0x040023B8 RID: 9144
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40023B8")]
	public int round;

	// Token: 0x040023B9 RID: 9145
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40023B9")]
	public int selectedRow;

	// Token: 0x040023BA RID: 9146
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40023BA")]
	public List<int> points;

	// Token: 0x040023BB RID: 9147
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40023BB")]
	public List<int> recoverTimes;

	// Token: 0x040023BC RID: 9148
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40023BC")]
	public List<float> longDamageAdder;

	// Token: 0x040023BD RID: 9149
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40023BD")]
	public List<List<EveBuff>> eveBuffs;

	// Token: 0x040023BE RID: 9150
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40023BE")]
	public List<EveZombieBuff> zombieBuffs;

	// Token: 0x040023BF RID: 9151
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40023BF")]
	[SerializeField]
	private List<EveBuff> buff1;

	// Token: 0x040023C0 RID: 9152
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40023C0")]
	[SerializeField]
	private List<EveBuff> buff2;

	// Token: 0x040023C1 RID: 9153
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40023C1")]
	[SerializeField]
	private List<EveBuff> buff3;

	// Token: 0x040023C2 RID: 9154
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40023C2")]
	[SerializeField]
	private List<EveBuff> buff4;

	// Token: 0x040023C3 RID: 9155
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40023C3")]
	[SerializeField]
	private List<EveBuff> buff5;
}
