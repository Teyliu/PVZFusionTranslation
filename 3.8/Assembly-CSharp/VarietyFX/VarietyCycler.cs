using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace VarietyFX
{
	// Token: 0x02000D20 RID: 3360
	[Token(Token = "0x2000D20")]
	public class VarietyCycler : MonoBehaviour
	{
		// Token: 0x0600461C RID: 17948 RVA: 0x00162318 File Offset: 0x00160518
		[Token(Token = "0x600461C")]
		[Address(RVA = "0x850A90", Offset = "0x84F090", VA = "0x180850A90")]
		private void Start()
		{
			List<GameObject> list = this.listOfEffects;
			int num = this.effectIndex;
			GameObject gameObject = list[num];
			Transform transform = base.transform;
			Vector3 vector;
			float z = vector.z;
			Transform transform2 = base.transform;
			GameObject gameObject2;
			this.instantiatedEffect = gameObject2;
			float time = Time.time;
			this.timeOfLastInstantiate = time;
		}

		// Token: 0x0600461D RID: 17949 RVA: 0x00162374 File Offset: 0x00160574
		[Token(Token = "0x600461D")]
		[Address(RVA = "0x850BD0", Offset = "0x84F1D0", VA = "0x180850BD0")]
		private void Update()
		{
			float time = Time.time;
			float num = this.timeOfLastInstantiate;
			global::UnityEngine.Object.Destroy(this.instantiatedEffect);
			List<GameObject> list = this.listOfEffects;
			int num2 = this.effectIndex;
			GameObject gameObject = list[num2];
			Transform transform = base.transform;
			Vector3 vector;
			float z = vector.z;
			Transform transform2 = base.transform;
			GameObject gameObject2;
			this.instantiatedEffect = gameObject2;
			float time2 = Time.time;
			List<GameObject> list2 = this.listOfEffects;
			this.timeOfLastInstantiate = time2;
			int size = list2._size;
			this.effectIndex = (int)((ulong)0L);
		}

		// Token: 0x0600461E RID: 17950 RVA: 0x00162408 File Offset: 0x00160608
		[Token(Token = "0x600461E")]
		[Address(RVA = "0x850D60", Offset = "0x84F360", VA = "0x180850D60")]
		public VarietyCycler()
		{
		}

		// Token: 0x040031F9 RID: 12793
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40031F9")]
		[SerializeField]
		private List<GameObject> listOfEffects;

		// Token: 0x040031FA RID: 12794
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40031FA")]
		[SerializeField]
		[Header("Loop length in seconds")]
		private float loopTimeLength = 5f;

		// Token: 0x040031FB RID: 12795
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40031FB")]
		private float timeOfLastInstantiate;

		// Token: 0x040031FC RID: 12796
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40031FC")]
		private GameObject instantiatedEffect;

		// Token: 0x040031FD RID: 12797
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40031FD")]
		private int effectIndex;
	}
}
