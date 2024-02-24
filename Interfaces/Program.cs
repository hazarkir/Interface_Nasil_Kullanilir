﻿using System;

namespace Interfaces
{
    public class Program
    {
        //interface new'lenemez
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();

            //IPersonManager employeeManager = new /*implamente eden sınıfın referansı demek*/ EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());
        }
    }


    interface IPersonManager
    {
        //uniplamentated operation
        void Add();
        void Update();
    } 

    //inherits - class --------------- implements - interface
    class CustomerManager : IPersonManager
    {
        //implemented operation
         public void Add()
        {
            //müşteri ekleme kodları  
            Console.WriteLine("Müşteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");

        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("Personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi");

        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            //stajyer ekleme kodları
            Console.WriteLine("Stajyer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi");

        }
    }
    

    

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }

    }
}
