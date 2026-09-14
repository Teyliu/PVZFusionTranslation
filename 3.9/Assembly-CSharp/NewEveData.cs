using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020009D3 RID: 2515
[Token(Token = "0x20009D3")]
[Serializable]
public class NewEveData
{
	// Token: 0x0600333C RID: 13116 RVA: 0x0010C9C0 File Offset: 0x0010ABC0
	[Token(Token = "0x600333C")]
	[Address(RVA = "0x756780", Offset = "0x754D80", VA = "0x180756780")]
	public void GetBuff(EveBuff eveBuff, int row)
	{
		int size = this.eveBuffs[row]._size;
		if (row == 0 || row == 0 || row == 0 || row == 0 || row == 1)
		{
			List<EveBuff> list = this.buff1;
		}
	}

	// Token: 0x0600333D RID: 13117 RVA: 0x0010CA04 File Offset: 0x0010AC04
	[Token(Token = "0x600333D")]
	[Address(RVA = "0x7568A0", Offset = "0x754EA0", VA = "0x1807568A0")]
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

	// Token: 0x0600333E RID: 13118 RVA: 0x0010CA7C File Offset: 0x0010AC7C
	[Token(Token = "0x600333E")]
	[Address(RVA = "0x7566F0", Offset = "0x754CF0", VA = "0x1807566F0")]
	public bool CheckBuff(EveBuff eveBuff, int row)
	{
		List<EveBuff> list = this.eveBuffs[row];
		bool flag;
		return flag;
	}

	// Token: 0x0600333F RID: 13119 RVA: 0x0010CAA0 File Offset: 0x0010ACA0
	[Token(Token = "0x600333F")]
	[Address(RVA = "0x756AD0", Offset = "0x7550D0", VA = "0x180756AD0")]
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

	// Token: 0x040024C6 RID: 9414
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40024C6")]
	public int round;

	// Token: 0x040024C7 RID: 9415
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40024C7")]
	public int selectedRow;

	// Token: 0x040024C8 RID: 9416
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40024C8")]
	public List<int> points;

	// Token: 0x040024C9 RID: 9417
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40024C9")]
	public List<int> recoverTimes;

	// Token: 0x040024CA RID: 9418
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40024CA")]
	public List<float> longDamageAdder;

	// Token: 0x040024CB RID: 9419
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40024CB")]
	public List<List<EveBuff>> eveBuffs;

	// Token: 0x040024CC RID: 9420
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40024CC")]
	public List<EveZombieBuff> zombieBuffs;

	// Token: 0x040024CD RID: 9421
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40024CD")]
	[SerializeField]
	private List<EveBuff> buff1;

	// Token: 0x040024CE RID: 9422
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40024CE")]
	[SerializeField]
	private List<EveBuff> buff2;

	// Token: 0x040024CF RID: 9423
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40024CF")]
	[SerializeField]
	private List<EveBuff> buff3;

	// Token: 0x040024D0 RID: 9424
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40024D0")]
	[SerializeField]
	private List<EveBuff> buff4;

	// Token: 0x040024D1 RID: 9425
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40024D1")]
	[SerializeField]
	private List<EveBuff> buff5;
}
