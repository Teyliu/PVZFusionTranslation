using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace VarietyFX
{
	// Token: 0x02000DEC RID: 3564
	[Token(Token = "0x2000DEC")]
	public class VarietyCycler : MonoBehaviour
	{
		// Token: 0x060049CB RID: 18891 RVA: 0x0016CA30 File Offset: 0x0016AC30
		[Token(Token = "0x60049CB")]
		[Address(RVA = "0x8DC5C0", Offset = "0x8DABC0", VA = "0x1808DC5C0")]
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

		// Token: 0x060049CC RID: 18892 RVA: 0x0016CA8C File Offset: 0x0016AC8C
		[Token(Token = "0x60049CC")]
		[Address(RVA = "0x8DC700", Offset = "0x8DAD00", VA = "0x1808DC700")]
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

		// Token: 0x060049CD RID: 18893 RVA: 0x0016CB20 File Offset: 0x0016AD20
		[Token(Token = "0x60049CD")]
		[Address(RVA = "0x8DC890", Offset = "0x8DAE90", VA = "0x1808DC890")]
		public VarietyCycler()
		{
		}

		// Token: 0x04003418 RID: 13336
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4003418")]
		[SerializeField]
		private List<GameObject> listOfEffects;

		// Token: 0x04003419 RID: 13337
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4003419")]
		[Header("Loop length in seconds")]
		[SerializeField]
		private float loopTimeLength = 5f;

		// Token: 0x0400341A RID: 13338
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x400341A")]
		private float timeOfLastInstantiate;

		// Token: 0x0400341B RID: 13339
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400341B")]
		private GameObject instantiatedEffect;

		// Token: 0x0400341C RID: 13340
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400341C")]
		private int effectIndex;
	}
}
