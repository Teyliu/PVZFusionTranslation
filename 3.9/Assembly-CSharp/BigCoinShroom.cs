using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004CA RID: 1226
[Token(Token = "0x20004CA")]
public class BigCoinShroom : Producer
{
	// Token: 0x06001721 RID: 5921 RVA: 0x0007F154 File Offset: 0x0007D354
	[Token(Token = "0x6001721")]
	[Address(RVA = "0x509530", Offset = "0x507B30", VA = "0x180509530", Slot = "69")]
	protected override void ProduceSun()
	{
		int i = 0;
		CreateItem instance = CreateItem.Instance;
		CreateItem instance2 = CreateItem.Instance;
		CreateItem instance3 = CreateItem.Instance;
		int num = this.thePlantColumn;
		num += num;
		CreateItem instance4 = CreateItem.Instance;
		int num2 = this.thePlantColumn;
		i++;
		num2 += num2;
		while (i <= num2)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001722 RID: 5922 RVA: 0x0007F1B0 File Offset: 0x0007D3B0
	[Token(Token = "0x6001722")]
	[Address(RVA = "0x509790", Offset = "0x507D90", VA = "0x180509790", Slot = "42")]
	public override bool SuperSkill()
	{
		int num2;
		do
		{
			int num = 0;
			if (this.flashCountDown > (float)num)
			{
				break;
			}
			Transform shoot = this.shoot;
			Vector3 vector;
			float z = vector.z;
			num2 = 0;
			uint num3;
			GameAPP.PlaySound((int)num3, 0.5f, 1f);
			base.UpdateText();
			int num4 = 0;
			Board board = this.board;
			List<Plant> plants = Lawnf.GetPlants(this.thePlantType, board, num4 != 0);
			bool flag;
			if (flag)
			{
				float thePlantProduceInterval = this.thePlantProduceInterval;
			}
		}
		while (num2 != 0);
		throw new NullReferenceException();
	}

	// Token: 0x06001723 RID: 5923 RVA: 0x0007F230 File Offset: 0x0007D430
	[Token(Token = "0x6001723")]
	[Address(RVA = "0x509460", Offset = "0x507A60", VA = "0x180509460", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001724 RID: 5924 RVA: 0x0007F250 File Offset: 0x0007D450
	[Token(Token = "0x6001724")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public BigCoinShroom()
	{
	}
}
