﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class Animal
    {
        public int Order { get; set; }
        public string Name { get; private set; }
        public Animal(string name)
        {
            Name = name;
        }
    }

    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }
    }

    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }
    }

    public class AnimalQueue
    {
        LinkedList<Dog> dogQueue = new LinkedList<Dog>();
        LinkedList<Cat> catQueue = new LinkedList<Cat>();
        int order = 0;
        public int Size()
        {
            return dogQueue.Count + catQueue.Count;
        }

        public void Enqueue(Animal a)
        {
            a.Order = order;
            order++;
            if(a is Dog)
            {
                dogQueue.AddLast((Dog)a);
            }
            else if(a is Cat)
            {
                catQueue.AddLast((Cat)a);
            }
        }

        public Animal DequeueAny()
        {
            if(dogQueue.Count == 0)
            {
                return DequeueCat();
            }
            else if(catQueue.Count == 0)
            {
                return DequeueDog();
            }

            if(dogQueue.First.Value.Order > catQueue.First.Value.Order)
            {
                return DequeueCat();
            }
            else
            {
                return DequeueDog();
            }
        }

        public Dog DequeueDog()
        {
            var dog = dogQueue.First();
            dogQueue.RemoveFirst();
            return dog;
        }
        public Cat DequeueCat()
        {
            var cat = catQueue.First();
            catQueue.RemoveFirst();
            return cat;
        }
    }

    public class Question_3_6
    {
        public void Run()
        {
            AnimalQueue animals = new AnimalQueue();
            animals.Enqueue(new Cat("Callie"));
            animals.Enqueue(new Cat("Kiki"));
            animals.Enqueue(new Dog("Fido"));
            animals.Enqueue(new Dog("Dora"));
            animals.Enqueue(new Cat("Kari"));
            animals.Enqueue(new Dog("Dexter"));
            animals.Enqueue(new Dog("Dobo"));
            animals.Enqueue(new Cat("Copa"));

            Console.WriteLine("Dequeued:" + animals.DequeueAny().Name);
            Console.WriteLine("Dequeued:" + animals.DequeueAny().Name);
            Console.WriteLine("Dequeued:" + animals.DequeueAny().Name);

            animals.Enqueue(new Dog("Dapa"));
            animals.Enqueue(new Cat("Kilo"));

            while (animals.Size() != 0)
            {
                Console.WriteLine(animals.DequeueAny().Name);
            }
            Console.WriteLine("\n\n");
        }
    }
}
