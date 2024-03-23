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
        private int _size = 32;
        public void Add(int key, string value)
        {
            if (_storage == null)
            {
                if (value == null || value == "")
                {
                    throw new ArgumentException("Значение не может быть пустым");
                }
                else
                {
                    _storage = new string[_size];
                    key = GetHash(key);
                    _storage[key] = value;
                }

            }
            else if (GetDictionaryCount() == _size)
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
                    key = GetHash(key);
                    if (_storage[key] != null)
                    {
                        _storage[key] += $" {value}";
                    }
                    else
                    {
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
            var hash = key % _storage.Length;
            return hash;
        }
    }
}
