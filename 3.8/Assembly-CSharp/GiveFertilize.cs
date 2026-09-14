using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000768 RID: 1896
[Token(Token = "0x2000768")]
public class GiveFertilize : MonoBehaviour
{
	// Token: 0x06002677 RID: 9847 RVA: 0x000CD260 File Offset: 0x000CB460
	[Token(Token = "0x6002677")]
	[Address(RVA = "0x5E2760", Offset = "0x5E0D60", VA = "0x1805E2760")]
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

	// Token: 0x06002678 RID: 9848 RVA: 0x000CD308 File Offset: 0x000CB508
	[Token(Token = "0x6002678")]
	[Address(RVA = "0x5E2A70", Offset = "0x5E1070", VA = "0x1805E2A70")]
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

	// Token: 0x06002679 RID: 9849 RVA: 0x000CD35C File Offset: 0x000CB55C
	[Token(Token = "0x6002679")]
	[Address(RVA = "0x5E2B70", Offset = "0x5E1170", VA = "0x1805E2B70")]
	public GiveFertilize()
	{
		this.pos.y = 4f;
		base..ctor();
	}

	// Token: 0x04001410 RID: 5136
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001410")]
	private int occurrences;

	// Token: 0x04001411 RID: 5137
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001411")]
	private Vector2 pos = (ulong)3236954112L;
}
