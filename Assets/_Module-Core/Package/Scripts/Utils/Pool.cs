using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool<T> where T : class
{
	public class PoolItem<U>
	{
		public U item;
		public bool isFree;

		public PoolItem(U item)
		{
			this.item = item;
			isFree = true;
		}

		public void Consume()
		{
			isFree = false;
		}

		public void Free()
		{
			isFree = true;
		}
	}

	private List<PoolItem<T>> m_items;

	public Action<T> OnFree;
	public Action<T> OnConsume;

	public Pool()
	{
		m_items = new List<PoolItem<T>>(50);
	}

	public T Consume(Predicate<T> searchPattern, Func<T> onInstantiate)
	{
		int lIndex = m_items.FindIndex(x => x.isFree && searchPattern(x.item));

		if (lIndex == -1)
		{
			m_items.Add(new PoolItem<T>(onInstantiate()));
			lIndex = m_items.Count - 1;
		}

		m_items[lIndex].Consume();
		OnConsume?.Invoke(m_items[lIndex].item);

		return m_items[lIndex].item;
	}

	public T Consume()
	{
		return Consume(x => true, () => default);
	}

	public void Free(T[] _items)
	{
		for (int i = 0; i < _items.Length; i++)
			Free(_items[i]);
	}

	public void Free(T item)
	{
		int lIndex = m_items.FindIndex(x => x.item == item);

		if (item != null)
			OnFree?.Invoke(item);
	
		if (lIndex != -1)
			m_items[lIndex].Free();
	}
}