using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus_Dictionary
{
    public class OtusDictionary
    {
        private string[] _storage;
        private int _size;

        public OtusDictionary()
        {
            _size = 32;
            _storage = new string[_size];
        }
        public void Add(int key, string value)
        {            
            if (GetDictionaryCount() == _size)
            {
                throw new ArgumentException("Словарь полность заполнен");
            }
            else
            {
                if (value == null || value == "")
                {
                    throw new ArgumentException("Значение не может быть пустым");
                }
                else
                {                    
                    if (_storage[GetHash(key)] != null)
                    {
                        _size *= 2;
                        Array.Resize(ref _storage, _size);
                        key = GetHash(key);
                        _storage[key] += $" {value}";
                    }
                    else
                    {
                        key = GetHash(key);
                        _storage[key] = value;
                    }
                }
            }
        }

        private int GetDictionaryCount()
        {
            var count = 0;
            for (int i = 0; i < _storage.Length; i++)
            {
                if (_storage[i] != null)
                    count++;
            }
            return count;
        }
        public string GetValue(int key)
        {
            key = GetHash(key);
            if (_storage[key] == null)
            {
                throw new ArgumentException($"Значений по адресу {key} не найдено");
            }
            return _storage[key];
        }
        private int GetHash(int key)
        {
            var hash = key % _size;
            return hash;
        }
    }
}
