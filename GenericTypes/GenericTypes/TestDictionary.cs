using System.Collections;

namespace GenericTypes;

public class TestDictionary<T1, T2> : IEnumerable<TestKeyValuePairs<T1, T2>>, IEnumerator<TestKeyValuePairs<T1, T2>>
{
    private List<TestKeyValuePairs<T1, T2>> _dictionary = new List<TestKeyValuePairs<T1, T2>>();
    
    public TestKeyValuePairs<T1, T2> Current { get; private set; }
    
    object IEnumerator.Current => Current;

    private int _index = -1;
    
    public void AddPair(T1 key, T2 value)
    {
        try
        {
            FindByKey(key);
        }
        catch (ElementNotFoundException exception)
        {
            _dictionary.Add(new TestKeyValuePairs<T1, T2>(key, value));
            return;
        }

        throw new Exception($"Key {key} already exists");
    }
    
    public TestKeyValuePairs<T1, T2> FindByKey(T1 key)
    {
        foreach (var pair in _dictionary)
        {
            if (pair.Key.ToString() == key.ToString())
            {
                return pair;
            }
        }
        
        throw new ElementNotFoundException();
    }
    
    public TestKeyValuePairs<T1, T2> FindByValue(T2 value)
    {
        foreach (var pair in _dictionary)
        {
            if (pair.Value.ToString() == value.ToString())
            {
                return pair;
            }
        }
        
        throw new ElementNotFoundException();
    }
    

    public void RemoveByKey(T1 key)
    {
        var pairToRemove = FindByKey(key);
        _dictionary.Remove(pairToRemove);
    }
    
    public void RemoveByValue(T2 value)
    {
        var pairToRemove = FindByValue(value);
        _dictionary.Remove(pairToRemove);
    }

    public IEnumerator<TestKeyValuePairs<T1, T2>> GetEnumerator()
    {
        return this;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool MoveNext()
    {
        if (_index + 1 < _dictionary.Count)
        {
            _index++;
            Current = _dictionary[_index];
            
            return true;
        }
        
        return false;
    }

    public void Reset()
    {
        _index = -1;
        Current = default;
    }

    public void Dispose()
    {
        
    }
}