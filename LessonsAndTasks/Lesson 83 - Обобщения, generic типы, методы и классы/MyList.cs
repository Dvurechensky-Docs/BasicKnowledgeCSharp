/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 декабря 2025 14:56:01
 * Version: 1.0.108
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