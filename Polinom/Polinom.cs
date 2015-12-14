using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolinomNS
{
    public sealed class Polinom
    {
        private double[] polinomArray;

        public int GetLength()
        {
            return polinomArray.Length;
        }

        public Polinom(params double[] array)
        {
            this.polinomArray = array;
        }

        public double[] PolinomArray
        {
            get { return polinomArray; }
            private set { polinomArray = value; }
        }

        public double GetFactor(int index)
        {
            return polinomArray[index];
        }

        public override bool Equals(System.Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Polinom p = obj as Polinom;
            if ((System.Object)p == null)
            {
                return false;
            }

            if (this.polinomArray.Length != p.polinomArray.Length)
            {
                return false;
            }

            for (int i = 0; i < this.polinomArray.Length; i++)
            {
                if (this.polinomArray[i] != p.polinomArray[i])
                {
                    return false;
                }
            }

            return true;

        }

        public override int GetHashCode()
        {
            int CONST = 42;
            int temp = 0;

            for (int i = 0; i < this.polinomArray.Length; i++)
            {
                temp += polinomArray[i].GetHashCode()*i;
            }

            return temp ^ (this.polinomArray.Length * CONST);
        }

        public override string ToString()
        {
            if (this.polinomArray.Length == 0)
            {
                return "Polinom haven't elements ";
            }

            var temp = new StringBuilder(this.polinomArray[0].ToString());

            for (int i = 1; i < this.polinomArray.Length; i++)
            {

                if (this.polinomArray[i] != 0)
                {

                    if (this.polinomArray[i] > 0)
                    {
                        temp.Append("+" + this.polinomArray[i] + "X^" + i);
                    }
                    if (this.polinomArray[i] < 0)
                    {
                        temp.Append(this.polinomArray[i] + "X^" + i);
                    }
                    if (this.polinomArray[i] != 0)
                    {

                    }
                }
            }

            return temp.ToString();
        }

        public double CalculatePolinom(double x)
        {
            double res = this.polinomArray[0];
            for (int i = 1; i < this.PolinomArray.Length; i++)
            {
                res += this.PolinomArray[i] * Math.Pow(x, i);
            }


            return res;
        }

        public static bool operator ==(Polinom polinom1, Polinom polinom2)
        {
            return polinom1.Equals(polinom2);
        }

        public static bool operator !=(Polinom polinom1, Polinom polinom2)
        {
            return !polinom1.Equals(polinom2);
        }

        public static Polinom operator +(Polinom polinom1, Polinom polinom2)
        {

            double[] resultArray;

            if (polinom1.polinomArray.Length >= polinom2.polinomArray.Length)
            {
                resultArray = polinom1.polinomArray;
                for (int i = 0; i < polinom2.polinomArray.Length; i++)
                {
                    resultArray[i] += polinom2.polinomArray[i];
                }
            }
            else
            {
                resultArray = polinom2.polinomArray;
                for (int i = 0; i < polinom1.polinomArray.Length; i++)
                {
                    resultArray[i] += polinom1.polinomArray[i];
                }
            }

            return new Polinom(resultArray);

        }

        public static Polinom operator -(Polinom polinom1, Polinom polinom2)
        {

            double[] resultArray = { };

            if (polinom1.polinomArray.Length >= polinom2.polinomArray.Length)
            {
                resultArray = polinom1.polinomArray;
                for (int i = 0; i < polinom2.polinomArray.Length; i++)
                {
                    resultArray[i] -= polinom2.polinomArray[i];
                }
            }
            if (polinom1.polinomArray.Length < polinom2.polinomArray.Length)
            {
                resultArray = polinom2.polinomArray;
                for (int i = 0; i < polinom1.polinomArray.Length; i++)
                {
                    resultArray[i] -= polinom1.polinomArray[i];
                }
            }

            return new Polinom(resultArray);

        }

        //Not ready
        public static Polinom operator *(Polinom polinom1, Polinom polinom2)
        {

            double[] resultArray;

            if (polinom1.polinomArray.Length >= polinom2.polinomArray.Length)
            {
                resultArray = polinom1.polinomArray;
                for (int i = 0; i < polinom2.polinomArray.Length; i++)
                {
                    resultArray[i] *= polinom2.polinomArray[i];
                }
            }
            else
            {
                resultArray = polinom2.polinomArray;
                for (int i = 0; i < polinom1.polinomArray.Length; i++)
                {
                    resultArray[i] *= polinom1.polinomArray[i];
                }
            }

            return new Polinom(resultArray);

        }

        public Polinom Addition(Polinom polinom)
        {
            double[] resultArray = { };

            if (this.polinomArray.Length >= polinom.polinomArray.Length)
            {
                resultArray = this.polinomArray;
                for (int i = 0; i < polinom.polinomArray.Length; i++)
                {
                    resultArray[i] += polinom.polinomArray[i];
                }
            }
            if (this.polinomArray.Length < polinom.polinomArray.Length)
            {
                resultArray = polinom.polinomArray;
                for (int i = 0; i < this.polinomArray.Length; i++)
                {
                    resultArray[i] += this.polinomArray[i];
                }
            }

            return new Polinom(resultArray);
        }


    }
}
