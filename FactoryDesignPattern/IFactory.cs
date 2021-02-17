using System;

namespace FactoryDesignPattern
{
    public interface IFactory<T> 
    {
        T Create();
    }
}