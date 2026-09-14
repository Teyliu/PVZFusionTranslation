using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007A1 RID: 1953
[Token(Token = "0x20007A1")]
public class GiveFertilize : MonoBehaviour
{
	// Token: 0x060027A6 RID: 10150 RVA: 0x000D22D8 File Offset: 0x000D04D8
	[Token(Token = "0x60027A6")]
	[Address(RVA = "0x645990", Offset = "0x643F90", VA = "0x180645990")]
	private void AnimGive()
	{
		Board instance = Board.Instance;
		int num = 0;
		if (instance != num)
		{
			Board instance2 = Board.Instance;
		}
		if (!Lawnf.HasZombie((ZombieType)((uint)259)))
		{
			bool[] advLevelCompleted = GameAPP.advLevelCompleted;
			if ("{il2cpp array field local8->}" != (ulong)0L)
			{
				Board instance3 = Board.Instance;
				int num2 = this.occurrences;
				num2++;
				this.occurrences = num2;
				if (num2 > 8)
				{
					this.occurrences = (int)((ulong)0L);
					GameObject gameObject = Resources.Load<GameObject>("Items/Fertilize/Ferilize");
					Quaternion identityQuaternion = Quaternion.identityQuaternion;
					Transform transform = Board.Instance.transform;
					GameAPP.PlaySound(66, 0.5f, 1f);
				}
			}
		}
	}

	// Token: 0x060027A7 RID: 10151 RVA: 0x000D2380 File Offset: 0x000D0580
	[Token(Token = "0x60027A7")]
	[Address(RVA = "0x645CA0", Offset = "0x6442A0", VA = "0x180645CA0")]
	public static bool AvaliableToGive()
	{
		Board instance = Board.Instance;
		int num = 0;
		if (instance != num)
		{
			Board instance2 = Board.Instance;
		}
		if (!Lawnf.HasZombie((ZombieType)((uint)259)))
		{
			bool[] advLevelCompleted = GameAPP.advLevelCompleted;
			return "{il2cpp array field local7->}" != (ulong)0L;
		}
		throw new IndexOutOfRangeException();
	}

	// Token: 0x060027A8 RID: 10152 RVA: 0x000D23D4 File Offset: 0x000D05D4
	[Token(Token = "0x60027A8")]
	[Address(RVA = "0x645DA0", Offset = "0x6443A0", VA = "0x180645DA0")]
	public GiveFertilize()
	{
		this.pos.y = 4f;
		base..ctor();
	}

	// Token: 0x040014EC RID: 5356
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40014EC")]
	private int occurrences;

	// Token: 0x040014ED RID: 5357
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40014ED")]
	private Vector2 pos = (ulong)3236954112L;
}
