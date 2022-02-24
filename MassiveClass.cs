using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class MassiveClass
    {
        private const int STEP = 1;
        private const int LENGHT = 10;
        private int[] massive = new int[LENGHT];

        private int startData;
        public MassiveClass(int startData)
        {
            this.startData = startData;
            for (int i = 0; i < massive.Length; i++)
            {
                if (i == 0)
                    massive[i] = startData;
                else
                    massive[i] = massive[i-1] + STEP;
            }
        }

        private int Sum;

        public int SumProperty
        {
            get 
            {
                for (int i = 0; i < massive.Length; i++)
                {
                    Sum = Sum + massive[i];
                }
                return Sum; 
            }
        }

        public static int[] Inverse(MassiveClass enterData)
        {
            int[] inverseMassive = new int[enterData.massive.Length];
            for (int i = 0; i < enterData.massive.Length; i++)
            {
                inverseMassive[i] = enterData.massive[i] * -1;
            }
            return inverseMassive;
        }

        public static int[] Multiply(MassiveClass enterData, int number)
        {
            int[] multiplyMassive = new int[enterData.massive.Length];
            for (int i = 0; i < enterData.massive.Length; i++)
            {
                multiplyMassive[i] = enterData.massive[i] * number;
            }
            return multiplyMassive;
        }



    }
}
