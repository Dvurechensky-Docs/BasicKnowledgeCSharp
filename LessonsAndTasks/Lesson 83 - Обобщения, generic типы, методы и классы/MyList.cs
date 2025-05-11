/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 02:47:11
 * Version: 1.0.3
 */

using System;

class MyList<T>
{
    private T[] _array = Array.Empty<T>();
    public T this[int index]
    {
        get => _array[index];
        set => _array[index] = value;
    }

    public int Count => _array.Length;

    public void Add(T value)
    {
        var newArray = new T[_array.Length + 1];
        for (int el = 0; el < _array.Length; el++)
            newArray[el] = _array[el];
        newArray[_array.Length] = value;
        _array = newArray;
    }
}