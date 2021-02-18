using System;

namespace UniversityConsole
{
    class Course
    {
        public string Code;
        public string Name;
        private int Shift; //0: night, 1: day

        public void SetShift(int newShift)
        {
            if (newShift == 0 || newShift == 1)
            {
                Shift = newShift;
            }
            else
            {
                Console.WriteLine("La jornada no puede ser diferente de ceo o uno");
            }
        }
        public int GetShift()
        {
            return Shift;
        }
    }
}
