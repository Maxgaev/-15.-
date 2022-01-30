using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_15.Интерфейсы
{
    interface ISeries
    {
        void setStart(int firstvalue);
        int getNext();
        void reset();
    }

    class ArithProgression : ISeries
    {
        int StepValue;
        int FirstValue;
        int CurrentValue;
        public ArithProgression(int firstValue, int stepValue)
        {
            FirstValue = firstValue;
            CurrentValue = firstValue;
            StepValue = stepValue;
        }
        public int getNext()
        {
            CurrentValue += StepValue;
            return CurrentValue;
        }

        public void reset()
        {
            CurrentValue = FirstValue;
        }

        public void setStart(int firstvalue)
        {
            FirstValue = firstvalue;
            CurrentValue = FirstValue;
        }
        public void setStep(int step)
        {
            StepValue = step;
        }
    }

    class GeomProgression : ISeries
    {
        int FirstValue;
        int CurrentValue;
        int DenomValue;
        public GeomProgression(int firstValue, int denomValue)
        {
            FirstValue = firstValue;
            CurrentValue = firstValue;
            DenomValue = denomValue;
        }
        public int getNext()
        {
            CurrentValue *= DenomValue;
            return CurrentValue;
        }
        public void reset()
        {
            CurrentValue = FirstValue;

        }
        public void setStart(int firstValue)
        {
            FirstValue = firstValue;
            CurrentValue = FirstValue;
        }
    }


    
}
