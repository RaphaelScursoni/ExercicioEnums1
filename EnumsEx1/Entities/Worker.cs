using System;
using System.Collections.Generic;
using System.Text;
using EnumsEx1.Entities;
using EnumsEx1.Entities.Enums;

namespace EnumsEx1
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }

        public Worker() { }

        public Worker(string name, WorkerLevel level, double baseSalary)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
