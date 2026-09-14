using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

namespace Core
{
	// Token: 0x02000A46 RID: 2630
	[Token(Token = "0x2000A46")]
	[DisallowMultipleComponent]
	public class SortingGroupRebuilder : MonoBehaviour
	{
		// Token: 0x060035F5 RID: 13813 RVA: 0x0011F1B8 File Offset: 0x0011D3B8
		[Token(Token = "0x60035F5")]
		[Address(RVA = "0x7A6790", Offset = "0x7A4D90", VA = "0x1807A6790")]
		[ProButton]
		public void StartRebuild()
		{
			Transform transform = base.transform;
			Dictionary<SpriteRenderer, int> dictionary = new Dictionary();
			ulong num;
			this.Rebuild(transform, 1, (int)num, dictionary);
			if (this.reName)
			{
				Transform transform2 = base.transform;
				this.RebuildRename(transform2, 1, (int)num);
			}
		}

		// Token: 0x060035F6 RID: 13814 RVA: 0x0011F1F8 File Offset: 0x0011D3F8
		[Token(Token = "0x60035F6")]
		[Address(RVA = "0x7A5CB0", Offset = "0x7A42B0", VA = "0x1807A5CB0")]
		private void Rebuild(Transform transform, int startOrder, [Out] int nextOrder, [Optional] Dictionary<SpriteRenderer, int> srToOrder)
		{
			for (;;)
			{
				int num = 0;
				List<ValueTuple<object, int, bool>> list = new List();
				int childCount = transform.childCount;
				if (num < childCount)
				{
					Transform child = transform.GetChild(num);
					bool flag = child.TryGetComponent<SortingGroup>(num);
					bool flag2 = child.TryGetComponent<SpriteRenderer>(num);
					if (!flag)
					{
						if (!flag2)
						{
						}
					}
					num++;
				}
				Func<ValueTuple<object, int, bool>, bool> func;
				if (SortingGroupRebuilder.<>c.<>9__2_0 == 0)
				{
					func = ([TupleElementNames(new string[] { "item", "order", "hasRenderer" })] ValueTuple<object, int, bool> x) => false;
					SortingGroupRebuilder.<>c.<>9__2_0 = func;
				}
				List<ValueTuple<object, int, bool>> list2 = Enumerable.ToList<ValueTuple<object, int, bool>>(Enumerable.Where<ValueTuple<object, int, bool>>(list, func));
				Func<ValueTuple<object, int, bool>, bool> func2;
				if (SortingGroupRebuilder.<>c.<>9__2_1 == 0)
				{
					func2 = delegate([TupleElementNames(new string[] { "item", "order", "hasRenderer" })] ValueTuple<object, int, bool> x)
					{
						bool flag6;
						return flag6;
					};
					SortingGroupRebuilder.<>c.<>9__2_1 = func2;
				}
				List<ValueTuple<object, int, bool>> list3 = Enumerable.ToList<ValueTuple<object, int, bool>>(Enumerable.Where<ValueTuple<object, int, bool>>(list, func2));
				Func<ValueTuple<object, int, bool>, int> func3;
				if (SortingGroupRebuilder.<>c.<>9__2_2 == 0)
				{
					SortingGroupRebuilder.<>c.<>9__2_2 = func3;
				}
				List<ValueTuple<object, int, bool>> list4 = Enumerable.ToList<ValueTuple<object, int, bool>>(Enumerable.OrderBy<ValueTuple<object, int, bool>, int>(list2, func3));
				bool flag3;
				if (flag3)
				{
					Transform transform2;
					if (transform2.childCount <= 0)
					{
						continue;
					}
					List<ValueTuple<SpriteRenderer, int>> list5 = new List();
					Comparison<ValueTuple<SpriteRenderer, int>> comparison;
					if (SortingGroupRebuilder.<>c.<>9__2_3 == 0)
					{
						comparison = delegate([TupleElementNames(new string[] { "renderer", "originalOrder" })] ValueTuple<SpriteRenderer, int> a, [TupleElementNames(new string[] { "renderer", "originalOrder" })] ValueTuple<SpriteRenderer, int> b)
						{
							int num3;
							return num3;
						};
						SortingGroupRebuilder.<>c.<>9__2_3 = comparison;
					}
					list5.Sort(comparison);
					bool flag4;
					if (flag4)
					{
						num++;
					}
					if (num != 0)
					{
						goto IL_0140;
					}
				}
				if (num == 0)
				{
					int num2 = 0;
					bool flag5;
					if (flag5)
					{
					}
					if (num2 == 0)
					{
						break;
					}
				}
			}
			return;
			IL_0140:
			throw new NullReferenceException();
		}

		// Token: 0x060035F7 RID: 13815 RVA: 0x0011F34C File Offset: 0x0011D54C
		[Token(Token = "0x60035F7")]
		[Address(RVA = "0x7A4FC0", Offset = "0x7A35C0", VA = "0x1807A4FC0")]
		private void CollectAllSpriteRenderers(Transform transform, [TupleElementNames(new string[] { "renderer", "originalOrder" })] List<ValueTuple<SpriteRenderer, int>> result)
		{
			int num = 0;
			if (!(transform == num))
			{
				GameObject gameObject = transform.gameObject;
				int num2 = 0;
				if (!(gameObject == num2))
				{
					SpriteRenderer component = transform.GetComponent<SpriteRenderer>();
					int num3 = 0;
					if (component != num3)
					{
						int sortingOrder = component.sortingOrder;
						int num4 = 0;
						int size = result._size;
						result.Add(num4);
					}
					int num5 = 0;
					int childCount = transform.childCount;
					if (num5 < childCount)
					{
						Transform transform2 = transform.GetChild(num5);
						this.CollectAllSpriteRenderers(transform2, result);
						num5++;
						result._size = transform2;
						transform2 += transform2;
					}
				}
			}
		}

		// Token: 0x060035F8 RID: 13816 RVA: 0x0011F3EC File Offset: 0x0011D5EC
		[Token(Token = "0x60035F8")]
		[Address(RVA = "0x7A51E0", Offset = "0x7A37E0", VA = "0x1807A51E0")]
		private void RebuildRename(Transform transform, int startOrder, [Out] int nextOrder)
		{
			for (;;)
			{
				int num = 0;
				List<ValueTuple<object, int, bool>> list = new List();
				int childCount = transform.childCount;
				if (num < childCount)
				{
					Transform child = transform.GetChild(num);
					bool flag = child.TryGetComponent<SortingGroup>(num);
					bool flag2 = child.TryGetComponent<SpriteRenderer>(num);
					if (!flag)
					{
						if (!flag2)
						{
						}
					}
					num++;
				}
				Func<ValueTuple<object, int, bool>, bool> func;
				if (SortingGroupRebuilder.<>c.<>9__4_0 == 0)
				{
					func = ([TupleElementNames(new string[] { "item", "order", "hasRenderer" })] ValueTuple<object, int, bool> x) => false;
					SortingGroupRebuilder.<>c.<>9__4_0 = func;
				}
				List<ValueTuple<object, int, bool>> list2 = Enumerable.ToList<ValueTuple<object, int, bool>>(Enumerable.Where<ValueTuple<object, int, bool>>(list, func));
				Func<ValueTuple<object, int, bool>, bool> func2;
				if (SortingGroupRebuilder.<>c.<>9__4_1 == 0)
				{
					func2 = delegate([TupleElementNames(new string[] { "item", "order", "hasRenderer" })] ValueTuple<object, int, bool> x)
					{
						bool flag6;
						return flag6;
					};
					SortingGroupRebuilder.<>c.<>9__4_1 = func2;
				}
				List<ValueTuple<object, int, bool>> list3 = Enumerable.ToList<ValueTuple<object, int, bool>>(Enumerable.Where<ValueTuple<object, int, bool>>(list, func2));
				Func<ValueTuple<object, int, bool>, int> func3;
				if (SortingGroupRebuilder.<>c.<>9__4_2 == 0)
				{
					SortingGroupRebuilder.<>c.<>9__4_2 = func3;
				}
				List<ValueTuple<object, int, bool>> list4 = Enumerable.ToList<ValueTuple<object, int, bool>>(Enumerable.OrderBy<ValueTuple<object, int, bool>, int>(list2, func3));
				bool flag3;
				if (flag3)
				{
					string text2;
					string text = "order:" + text2;
					Transform transform2;
					if (transform2.childCount <= 0)
					{
						continue;
					}
					while (this == 0)
					{
					}
					while (this == 0)
					{
					}
					List<ValueTuple<SpriteRenderer, int>> list5 = new List();
					Transform transform3 = base.transform;
					this.CollectAllSpriteRenderers(transform3, list5);
					Comparison<ValueTuple<SpriteRenderer, int>> comparison;
					if (SortingGroupRebuilder.<>c.<>9__4_3 == 0)
					{
						comparison = delegate([TupleElementNames(new string[] { "renderer", "originalOrder" })] ValueTuple<SpriteRenderer, int> a, [TupleElementNames(new string[] { "renderer", "originalOrder" })] ValueTuple<SpriteRenderer, int> b)
						{
							int num3;
							return num3;
						};
						SortingGroupRebuilder.<>c.<>9__4_3 = comparison;
					}
					list5.Sort(comparison);
					bool flag4;
					if (flag4)
					{
						string text4;
						string text3 = "order:" + text4;
					}
					if (num != 0)
					{
						goto IL_0175;
					}
				}
				if (num == 0)
				{
					int num2 = 0;
					bool flag5;
					if (flag5)
					{
					}
					if (num2 == 0)
					{
						break;
					}
				}
			}
			return;
			IL_0175:
			throw new NullReferenceException();
		}

		// Token: 0x060035F9 RID: 13817 RVA: 0x0011F574 File Offset: 0x0011D774
		[Token(Token = "0x60035F9")]
		[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
		public SortingGroupRebuilder()
		{
		}

		// Token: 0x04002967 RID: 10599
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002967")]
		public bool reName;
	}
}
